using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Zita
{
    public partial class frmRegistros : Form
    {
        private string connectionString = DBHelper.ConnectionString;
        private SqlConnection connection;
        public frmRegistros()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            connection = new SqlConnection(connectionString);

            // Desativa os estilos visuais dos cabeçalhos
            dgrRegistros.EnableHeadersVisualStyles = false;

            // Define o estilo para o cabeçalho das colunas
            dgrRegistros.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dgrRegistros.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgrRegistros.AdvancedColumnHeadersBorderStyle.All = DataGridViewAdvancedCellBorderStyle.None;
            dgrRegistros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CarregarRegistros();
            ConfigurarDataGridView();

            // Inscreve o evento CellFormatting
            dgrRegistros.CellFormatting += dgrRegistros_CellFormatting;
        }

        private void ConfigurarDataGridView()
        {
            // Oculta a coluna "IDTransacoes"
            dgrRegistros.Columns["IDTransacao"].Visible = false;
        }

        private void dgrRegistros_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgrRegistros.Columns[e.ColumnIndex].Name == "PrecoTotal" && e.Value != null)
            {
                // Formata o valor para exibir como "00,00"
                if (decimal.TryParse(e.Value.ToString(), out decimal precoTotal))
                {
                    e.Value = precoTotal.ToString("N2");
                    e.FormattingApplied = true;
                }
            }
        }

        private void CarregarRegistros()
        {
            try
            {
                connection.Open();
                string query = "SELECT * FROM Registros";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgrRegistros.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar registros: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

    }
}