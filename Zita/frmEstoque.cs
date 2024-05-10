using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Zita
{
    public partial class frmEstoque : Form
    {
        private string connectionString = "Data Source=DESKTOP-M2PRVUH;Initial Catalog=Zita;Integrated Security=True";
        private int idProdutoEditando = -1;


        public frmEstoque()
        {
            InitializeComponent();
            txtPesquisar.TextChanged += new EventHandler(txtPesquisar_TextChanged);
            CarregarDados();

            // Desativa os estilos visuais dos cabeçalhos
            dgrEstoque.EnableHeadersVisualStyles = false;

            // Define o estilo para o cabeçalho das colunas
            dgrEstoque.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dgrEstoque.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgrEstoque.AdvancedColumnHeadersBorderStyle.All = DataGridViewAdvancedCellBorderStyle.None;

            // Associando o evento SelectionChanged ao DataGridView
            dgrEstoque.SelectionChanged += DgrEstoque_SelectionChanged;

        }


        private void CarregarDados()
        {
            string query = "SELECT IDProduto, Codigo, Nome, Categoria, Preco, QuantidadeEmEstoque FROM Produtos";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dgrEstoque.DataSource = dataTable;

                    // Define a propriedade AutoSizeColumnsMode para que as colunas preencham a largura do controle
                    dgrEstoque.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    dgrEstoque.Columns["IDProduto"].Visible = false; // Para o IDProduto não aparecer
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void DgrEstoque_SelectionChanged(object sender, EventArgs e)
        {
            // Verifica se há linhas selecionadas no grid
            if (dgrEstoque.SelectedRows.Count > 0 &&
                dgrEstoque.SelectedRows[0] != null &&
                dgrEstoque.SelectedRows[0].Index != dgrEstoque.Rows.Count - 1 && // Verifica se a linha selecionada não é a última
                dgrEstoque.SelectedRows[0].Cells[0].Value != null)
            {
                // Se houver linhas selecionadas e a célula na primeira coluna não estiver vazia,
                // e a linha selecionada não for a última, o código abaixo será executado

                // Obtém os dados do produto selecionado
                string nomeProduto = dgrEstoque.SelectedRows[0].Cells["Nome"].Value.ToString();
                string categoria = dgrEstoque.SelectedRows[0].Cells["Categoria"].Value.ToString();
                decimal preco = Convert.ToDecimal(dgrEstoque.SelectedRows[0].Cells["Preco"].Value);
                int quantidade = Convert.ToInt32(dgrEstoque.SelectedRows[0].Cells["QuantidadeEmEstoque"].Value);

                // Preenche os campos com os dados do produto selecionado
                txtNomeProduto.Text = nomeProduto;
                // Define o valor selecionado do ComboBox de Categoria
                cboCategoria.SelectedItem = categoria;
                txtPreco.Text = preco.ToString();
                txtQuant.Text = quantidade.ToString();

                // Obtém e preenche o código do produto selecionado
                string codigoProduto = dgrEstoque.SelectedRows[0].Cells["Codigo"].Value.ToString();
                txtCodigo.Text = codigoProduto;

                // Habilita o botão "Editar"
                btnEditar.Enabled = true;

                // Armazena o ID do produto selecionado
                idProdutoEditando = Convert.ToInt32(dgrEstoque.SelectedRows[0].Cells["IDProduto"].Value);

                // Debug
                Debug.WriteLine("idProdutoEditando: " + idProdutoEditando);
            }
            else
            {
                // Limpa os campos se nenhuma linha estiver selecionada, se a célula na primeira coluna estiver vazia
                // ou se a linha selecionada for a última
                LimparCampos();
            }
        }





        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            // Verifica se todos os campos obrigatórios estão preenchidos
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) || cboCategoria.SelectedItem == null || string.IsNullOrWhiteSpace(txtPreco.Text) || string.IsNullOrWhiteSpace(txtQuant.Text) || string.IsNullOrWhiteSpace(txtNomeProduto.Text))
            {
                MessageBox.Show("Todos os campos devem ser preenchidos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Coleta as informações dos campos
            string codigoProduto = txtCodigo.Text;
            string nomeProduto = txtNomeProduto.Text;
            string categoria = cboCategoria.SelectedItem.ToString();
            decimal preco = decimal.Parse(txtPreco.Text);
            int quantidade = int.Parse(txtQuant.Text);

            // Insere as informações no banco de dados
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string insertQuery = "INSERT INTO Produtos (Codigo, Nome, Categoria, Preco, QuantidadeEmEstoque) VALUES (@Codigo, @Nome, @Categoria, @Preco, @Quantidade)";
                    SqlCommand command = new SqlCommand(insertQuery, connection);
                    command.Parameters.AddWithValue("@Codigo", codigoProduto);
                    command.Parameters.AddWithValue("@Nome", nomeProduto);
                    command.Parameters.AddWithValue("@Categoria", categoria);
                    command.Parameters.AddWithValue("@Preco", preco);
                    command.Parameters.AddWithValue("@Quantidade", quantidade);
                    command.ExecuteNonQuery();
                }

                // Recarrega os dados no grid após a adição
                CarregarDados();

                // Limpa os campos e exibe uma mensagem informando que o produto foi adicionado com sucesso
                LimparCampos();
                MessageBox.Show("Produto adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNomeProduto.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar produto: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Verifica se uma linha completa está selecionada
            if (dgrEstoque.SelectedRows.Count != 1)
            {
                MessageBox.Show("Selecione uma linha inteira para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Coleta as informações dos campos do DataGridView
            string codigoProduto = txtCodigo.Text;
            string nomeProduto = txtNomeProduto.Text;
            string categoria = cboCategoria.SelectedItem.ToString();
            decimal preco = Convert.ToDecimal(txtPreco.Text);
            int quantidade = Convert.ToInt32(txtQuant.Text);

            // Atualiza as informações do produto no banco de dados
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string updateQuery = "UPDATE Produtos SET Codigo = @Codigo, Nome = @Nome, Categoria = @Categoria, Preco = @Preco, QuantidadeEmEstoque = @Quantidade WHERE IDProduto = @ID";
                    SqlCommand command = new SqlCommand(updateQuery, connection);
                    command.Parameters.AddWithValue("@Codigo", codigoProduto); // Atualiza o código do produto
                    command.Parameters.AddWithValue("@Nome", nomeProduto); // Atualiza o nome do produto
                    command.Parameters.AddWithValue("@Categoria", categoria); // Atualiza a categoria
                    command.Parameters.AddWithValue("@Preco", preco);
                    command.Parameters.AddWithValue("@Quantidade", quantidade);
                    command.Parameters.AddWithValue("@ID", idProdutoEditando);
                    command.ExecuteNonQuery(); // Executa o comando SQL de atualização
                }

                // Recarrega os dados no grid após a edição
                CarregarDados();

                // Exibe uma mensagem informando que o produto foi editado com sucesso
                MessageBox.Show("Produto editado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar produto: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnDeletar_Click(object sender, EventArgs e)
        {
            // Verifica se uma linha completa está selecionada
            if (dgrEstoque.SelectedRows.Count != 1)
            {
                MessageBox.Show("Selecione uma linha inteira para deletar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtém o ID do produto a ser deletado
            int idProdutoDeletar = Convert.ToInt32(dgrEstoque.SelectedRows[0].Cells["IDProduto"].Value);

            // Exibe uma caixa de diálogo de confirmação
            DialogResult result = MessageBox.Show("Tem certeza que deseja deletar este produto?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verifica se o usuário confirmou a exclusão
            if (result == DialogResult.Yes)
            {
                // Executa a consulta para deletar o produto do banco de dados
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string deleteQuery = "DELETE FROM Produtos WHERE IDProduto = @ID";
                        SqlCommand command = new SqlCommand(deleteQuery, connection);
                        command.Parameters.AddWithValue("@ID", idProdutoDeletar);
                        command.ExecuteNonQuery();
                    }

                    // Recarrega os dados no grid após a exclusão
                    CarregarDados();

                    // Exibe uma mensagem informando que o produto foi deletado com sucesso
                    MessageBox.Show("Produto deletado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao deletar produto: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LimparCampos()
        {
            // Limpa os campos de texto
            txtCodigo.Text = "";
            txtNomeProduto.Text = "";
            cboCategoria.SelectedIndex = -1;
            txtPreco.Text = "";
            txtQuant.Text = "";
        }


        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void Pesquisar()
        {
            string termoPesquisa = txtPesquisar.Text.Trim(); // Termo de pesquisa

            string query = "SELECT Nome, Categoria, Preco, QuantidadeEmEstoque, IDProduto, Codigo FROM Produtos WHERE Nome LIKE @termo OR Categoria LIKE @termo"; // Consulta SQL para pesquisar por nome ou categoria
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@termo", "%" + termoPesquisa + "%"); // Adiciona o termo de pesquisa ao parâmetro da consulta
                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dgrEstoque.DataSource = dataTable; // Define o DataTable como a fonte de dados do DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao pesquisar no banco de dados: " + ex.Message, "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }





    }
}