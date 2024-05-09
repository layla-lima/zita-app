using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zita
{
    public partial class frmCaixaAberto : Form
    {
        private string connectionString = "Data Source=DESKTOP-M2PRVUH;Initial Catalog=Zita;Integrated Security=True";
        private SqlConnection connection;

        public frmCaixaAberto()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            connection = new SqlConnection(connectionString);
            // Desativa os estilos visuais dos cabeçalhos
            dgrCompras.EnableHeadersVisualStyles = false;

            // Define o estilo para o cabeçalho das colunas
            dgrCompras.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dgrCompras.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgrCompras.AdvancedColumnHeadersBorderStyle.All = DataGridViewAdvancedCellBorderStyle.None;
            dgrCompras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodProduto.Text;

            try
            {
                connection.Open();
                string query = "SELECT Nome, Preco FROM Produtos WHERE Codigo=@Codigo";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Codigo", codigo);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    string nome = reader["Nome"].ToString();
                    double preco = Convert.ToDouble(reader["Preco"]);

                    lblNomeProduto.Text = nome;
                    lblValorUnitario.Text = $"R$ {preco.ToString("F2")}";
                }
                else
                {
                    lblNomeProduto.Text = "Produto não encontrado";
                    lblValorUnitario.Text = "";
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar produto: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            // Obtém os valores dos controles
            string codigo = txtCodProduto.Text;
            string produto = lblNomeProduto.Text;
            double valorUnitario = Convert.ToDouble(lblValorUnitario.Text.Replace("R$ ", ""));
            int quantidade = Convert.ToInt32(txtQuantidade.Text);
            double valorFinal = valorUnitario * quantidade;

            // Adiciona os valores ao DataGridView
            dgrCompras.Rows.Add(codigo, produto, valorUnitario.ToString("C2"), quantidade, valorFinal.ToString("C2"));
            txtCodProduto.Text = "";
            lblNomeProduto.Text = "";
            lblValorUnitario.Text = "";
            txtQuantidade.Text = "";
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            // Verifica se há uma linha selecionada
            if (dgrCompras.SelectedRows.Count > 0)
            {
                // Obtém o índice da linha selecionada
                int rowIndex = dgrCompras.SelectedRows[0].Index;

                // Remove a linha do DataGridView
                dgrCompras.Rows.RemoveAt(rowIndex);
            }
            else
            {
                MessageBox.Show("Selecione uma linha inteira para editar.");
            }
        }

    }

}
