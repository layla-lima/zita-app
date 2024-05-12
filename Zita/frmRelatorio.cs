using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.WindowsForms;

namespace Zita
{
    public partial class frmRelatorio : Form
    {
        private string connectionString = DBHelper.ConnectionString;
        private int numeroDeVendas = 0;
        private decimal ganhoTotal = 0;
        private PlotView plotView;

        public frmRelatorio()
        {
            InitializeComponent();
            pnlGraficoPizza.SizeChanged += PnlGraficoPizza_SizeChanged; // Adicionando o evento SizeChanged aqui
            AtualizarRelatorio();
            ConfigurarGraficoAnel();

        }

        private void AtualizarRelatorio()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Calcula o número de vendas
                    string queryVendas = "SELECT COUNT(*) FROM Registros";
                    SqlCommand cmdVendas = new SqlCommand(queryVendas, connection);
                    numeroDeVendas = (int)cmdVendas.ExecuteScalar();

                    // Calcula o ganho total
                    string queryGanhoTotal = "SELECT SUM(PrecoTotal) FROM Registros";
                    SqlCommand cmdGanhoTotal = new SqlCommand(queryGanhoTotal, connection);
                    object result = cmdGanhoTotal.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        ganhoTotal = Convert.ToDecimal(result);
                    }

                    // Calcula os ganhos do dia atual
                    DateTime dataAtual = DateTime.Today;
                    string queryGanhosDiaAtual = "SELECT SUM(PrecoTotal) FROM Registros WHERE CONVERT(date, DataHora) = @DataAtual";
                    SqlCommand cmdGanhosDiaAtual = new SqlCommand(queryGanhosDiaAtual, connection);
                    cmdGanhosDiaAtual.Parameters.AddWithValue("@DataAtual", dataAtual);
                    object resultGanhosDiaAtual = cmdGanhosDiaAtual.ExecuteScalar();
                    if (resultGanhosDiaAtual != DBNull.Value)
                    {
                        decimal ganhosDiaAtual = Convert.ToDecimal(resultGanhosDiaAtual);
                        lblGanhosDoDia.Text = ganhosDiaAtual.ToString("C2");
                    }
                    else
                    {
                        lblGanhosDoDia.Text = "R$ 0,00"; // Se não houver registros, exibe 0,00 como total dos ganhos do dia atual
                    }

                    // Atualiza os outros dados do relatório
                    lblVendasRealizadas.Text = numeroDeVendas.ToString();
                    lblGanhoTotal.Text = ganhoTotal.ToString("C2");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar o relatório: " + ex.Message);
            }
        }



        private void ConfigurarGraficoAnel()
        {
            plotView = new PlotView();
            plotView.Dock = DockStyle.Fill; // Preenche todo o espaço do Panel
            pnlGraficoPizza.Controls.Add(plotView);

            var model = new PlotModel { Title = "Formas de Pagamento" };
            model.TitleHorizontalAlignment = TitleHorizontalAlignment.CenteredWithinPlotArea; // Alinha o título ao centro horizontalmente
            model.TitlePadding = 20; // ajusta distancia entre titulo e grafico

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Consulta para obter a contagem de registros por forma de pagamento
                    string queryFormasPagamento = "SELECT FormaDePagamento, COUNT(*) AS Total FROM Registros GROUP BY FormaDePagamento";
                    SqlCommand cmdFormasPagamento = new SqlCommand(queryFormasPagamento, connection);
                    SqlDataReader reader = cmdFormasPagamento.ExecuteReader();

                    double startAngle = 0;
                    double total = 0;

                    // Calcula o total de vendas para calcular os ângulos
                    while (reader.Read())
                    {
                        total += Convert.ToInt32(reader["Total"]);
                    }

                    reader.Close();

                    // Consulta novamente para obter os dados reais
                    SqlDataReader reader2 = cmdFormasPagamento.ExecuteReader();

                    var colors = new OxyColor[]
                    {
                OxyColor.Parse("#45b39d"), // COR DO CREDITO
                OxyColor.Parse("#5ac8b8"), // COR DO DEBITO
                OxyColor.Parse("#30987d"), //COR DO DINHEIRO
                OxyColor.Parse("#1d7862") // COR DO PIX
                    };

                    int colorIndex = 0;

                    // Adiciona as fatias ao gráfico de anel
                    while (reader2.Read())
                    {
                        string formaPagamento = reader2["FormaDePagamento"].ToString();
                        int quantidade = Convert.ToInt32(reader2["Total"]);
                        double sliceAngle = 360 * quantidade / total;

                        var pieSeries = new PieSeries
                        {
                            StartAngle = startAngle,
                            AngleSpan = sliceAngle,
                            InnerDiameter = 0.4,
                            OutsideLabelFormat = null
                        };

                        // Define a cor da fatia
                        pieSeries.Slices.Add(new PieSlice(formaPagamento, quantidade)
                        {
                            Fill = colors[colorIndex],
                            IsExploded = true // Ajusta o espaçamento entre as fatias
                        });

                        // Define a cor do texto dentro das fatias como branco
                        pieSeries.TextColor = OxyColors.White;

                        model.Series.Add(pieSeries);

                        startAngle += sliceAngle;
                        colorIndex = (colorIndex + 1) % colors.Length; // Avança para a próxima cor na lista de cores
                    }

                    reader2.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter dados de formas de pagamento: " + ex.Message);
            }

            plotView.Model = model;
        }



        private void PnlGraficoPizza_SizeChanged(object sender, EventArgs e)
        {
            // Ajusta o tamanho do PlotView sempre que o tamanho do Panel mudar
            plotView.Width = pnlGraficoPizza.Width;
            plotView.Height = pnlGraficoPizza.Height;
        }



    }
}
