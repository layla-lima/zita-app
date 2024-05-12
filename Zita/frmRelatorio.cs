using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using OxyPlot;
using OxyPlot.Axes;
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
            pnlGraficoPizza.SizeChanged += PnlGraficoPizza_SizeChanged;
            AtualizarRelatorio();
            ConfigurarGraficoAnel();
            ConfigurarGraficoBarras(); // Adicionado aqui para configurar o gráfico de barras
        }

        private void AtualizarRelatorio()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string queryVendas = "SELECT COUNT(*) FROM Registros";
                    SqlCommand cmdVendas = new SqlCommand(queryVendas, connection);
                    numeroDeVendas = (int)cmdVendas.ExecuteScalar();

                    string queryGanhoTotal = "SELECT SUM(PrecoTotal) FROM Registros";
                    SqlCommand cmdGanhoTotal = new SqlCommand(queryGanhoTotal, connection);
                    object result = cmdGanhoTotal.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        ganhoTotal = Convert.ToDecimal(result);
                    }

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
                        lblGanhosDoDia.Text = "R$ 0,00";
                    }

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
            plotView.Dock = DockStyle.Fill;
            pnlGraficoPizza.Controls.Add(plotView);

            var model = new PlotModel { Title = "Formas de Pagamento" };
            model.TitleHorizontalAlignment = TitleHorizontalAlignment.CenteredWithinPlotArea;
            model.TitlePadding = 20;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string queryFormasPagamento = "SELECT FormaDePagamento, COUNT(*) AS Total FROM Registros GROUP BY FormaDePagamento";
                    SqlCommand cmdFormasPagamento = new SqlCommand(queryFormasPagamento, connection);
                    SqlDataReader reader = cmdFormasPagamento.ExecuteReader();

                    double startAngle = 0;
                    int numeroDeVendas = 0;

                    // Obter o número total de vendas
                    while (reader.Read())
                    {
                        numeroDeVendas += Convert.ToInt32(reader["Total"]);
                    }

                    reader.Close();

                    SqlDataReader reader2 = cmdFormasPagamento.ExecuteReader();

                    var colors = new OxyColor[]
                    {
                OxyColor.Parse("#45b39d"),
                OxyColor.Parse("#5ac8b8"),
                OxyColor.Parse("#30987d"),
                OxyColor.Parse("#1d7862")
                    };

                    int colorIndex = 0;

                    while (reader2.Read())
                    {
                        string formaPagamento = reader2["FormaDePagamento"].ToString();
                        int quantidade = Convert.ToInt32(reader2["Total"]);

                        // Calculamos a porcentagem correta usando o número total de vendas
                        double percentual = (double)quantidade / numeroDeVendas * 100;

                        double sliceAngle = 360 * quantidade / numeroDeVendas;

                        var pieSeries = new PieSeries
                        {
                            StartAngle = startAngle,
                            AngleSpan = sliceAngle,
                            InnerDiameter = 0.4,
                            OutsideLabelFormat = ""
                        };

                        pieSeries.Slices.Add(new PieSlice(formaPagamento, quantidade)
                        {
                            Fill = colors[colorIndex],
                            IsExploded = true
                        });

                        pieSeries.TextColor = OxyColors.White;

                        // Adiciona a porcentagem como rótulo de ferramenta (tool tip)
                        pieSeries.ToolTip = $"{formaPagamento}: {percentual:0.##}%";

                        model.Series.Add(pieSeries);

                        startAngle += sliceAngle;
                        colorIndex = (colorIndex + 1) % colors.Length;
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




        private void ConfigurarGraficoBarras()
        {
            plotView = new PlotView();
            plotView.Dock = DockStyle.Fill;
            pnlGraficoBarras.Controls.Add(plotView);

            var model = new PlotModel { Title = "Categorias Mais Vendidas" };
            model.TitleHorizontalAlignment = TitleHorizontalAlignment.CenteredWithinPlotArea;
            model.TitlePadding = 20;
            model.DefaultFont = "Arial"; // Definindo a fonte padrão como Arial

            // Definindo as categorias manualmente
            string[] categorias = { "Bolsas", "Semijoias", "Calçados", "Óculos", "Acessórios" };

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Consulta para obter a quantidade total de itens vendidos por categoria
                    string queryQuantidadePorCategoria = @"
                SELECT P.Categoria, SUM(IV.Quantidade) AS TotalQuantidade
                FROM Produtos P
                LEFT JOIN ItensVendidos IV ON IV.CodigoProduto = P.Codigo
                GROUP BY P.Categoria
                ORDER BY TotalQuantidade DESC";
                    SqlCommand cmdQuantidadePorCategoria = new SqlCommand(queryQuantidadePorCategoria, connection);
                    SqlDataReader reader = cmdQuantidadePorCategoria.ExecuteReader();

                    // Dicionário para armazenar a quantidade total de itens vendidos para cada categoria
                    Dictionary<string, int> quantidadePorCategoria = new Dictionary<string, int>();

                    // Inicializando o dicionário com quantidade zero para cada categoria
                    foreach (string categoria in categorias)
                    {
                        quantidadePorCategoria.Add(categoria, 0);
                    }

                    // Preenchendo o dicionário com as quantidades reais de itens vendidos
                    while (reader.Read())
                    {
                        string categoria = reader["Categoria"].ToString();
                        int totalQuantidade = Convert.ToInt32(reader["TotalQuantidade"]);

                        // Verificando se a categoria está na lista de categorias definidas
                        if (quantidadePorCategoria.ContainsKey(categoria))
                        {
                            quantidadePorCategoria[categoria] = totalQuantidade;
                        }
                    }

                    reader.Close();

                    // Adicionando as barras ao modelo do gráfico
                    var barSeries = new ColumnSeries { LabelPlacement = LabelPlacement.Inside };

                    // Cores para cada categoria (em tons de roxo)
                    var cores = new OxyColor[]
                    {
                        OxyColor.FromRgb(177, 16, 76),    // #b1104c
                        OxyColor.FromRgb(197, 45, 99),    // #c52d63
                        OxyColor.FromRgb(216, 74, 121),   // #d84a79
                        OxyColor.FromRgb(236, 102, 144),  // #ec6690
                        OxyColor.FromRgb(255, 131, 166)   // #ff83a6
                    };

                    int indiceCor = 0; // Índice para percorrer o array de cores

                    foreach (string categoria in categorias)
                    {
                        var cor = cores[indiceCor]; // Seleciona a cor para a categoria atual
                        barSeries.Items.Add(new ColumnItem { Value = quantidadePorCategoria[categoria], Color = cor });
                        indiceCor++;
                    }

                    model.Series.Add(barSeries);

                    // Adicionando os nomes das categorias ao eixo X
                    var categoryAxis = new CategoryAxis { Position = AxisPosition.Bottom };
                    foreach (string categoria in categorias)
                    {
                        categoryAxis.Labels.Add(categoria);
                    }
                    model.Axes.Add(categoryAxis);

                    // Adicionando o título ao eixo Y
                    var valueAxis = new LinearAxis { Position = AxisPosition.Left, Title = "Quantidade de Itens Vendidos", AxisTitleDistance = 15 }; // Ajusta a distância da legenda dos números do eixo Y
                    model.Axes.Add(valueAxis);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter dados das categorias mais vendidas: " + ex.Message);
            }

            plotView.Model = model;
        }





        private void PnlGraficoPizza_SizeChanged(object sender, EventArgs e)
        {
            plotView.Width = pnlGraficoPizza.Width;
            plotView.Height = pnlGraficoPizza.Height;
        }
    }
}
