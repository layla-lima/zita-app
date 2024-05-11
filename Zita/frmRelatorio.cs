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
            AtualizarRelatorio();
            ConfigurarGraficoPizza();
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

                    lblVendasRealizadas.Text = numeroDeVendas.ToString();
                    lblGanhoTotal.Text = ganhoTotal.ToString("C2");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar o relatório: " + ex.Message);
            }
        }

        private void ConfigurarGraficoPizza()
        {
            plotView = new PlotView();
            plotView.Location = new Point(51, 295);
            plotView.Size = new Size(598, 264);
            Controls.Add(plotView);

            var model = new PlotModel { Title = "Formas de Pagamento" };
            var series = new PieSeries();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Consulta para obter a contagem de registros por forma de pagamento
                    string queryFormasPagamento = "SELECT FormaDePagamento, COUNT(*) AS Total FROM Registros GROUP BY FormaDePagamento";
                    SqlCommand cmdFormasPagamento = new SqlCommand(queryFormasPagamento, connection);
                    SqlDataReader reader = cmdFormasPagamento.ExecuteReader();

                    while (reader.Read())
                    {
                        string formaPagamento = reader["FormaDePagamento"].ToString();
                        int total = Convert.ToInt32(reader["Total"]);

                        // Adiciona os dados ao gráfico de pizza
                        series.Slices.Add(new PieSlice(formaPagamento, total));
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter dados de formas de pagamento: " + ex.Message);
            }

            // Define as cores para cada fatia do gráfico
            series.Slices[0].Fill = OxyColor.Parse("#2478c9");
            series.Slices[1].Fill = OxyColor.Parse("#1b68b7");
            series.Slices[2].Fill = OxyColor.Parse("#1259a5");
            series.Slices[3].Fill = OxyColor.Parse("#094992");

            // Configuração para mostrar a porcentagem dentro das fatias
            series.LabelField = "Value";

            model.Series.Add(series);
            plotView.Model = model;
        }






    }
}
