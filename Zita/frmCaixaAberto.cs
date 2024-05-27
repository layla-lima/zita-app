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
        private string connectionString = DBHelper.ConnectionString;
        private SqlConnection connection;
        private string formaDePagamento = "";
        private double valorTotalOriginal;

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
            txtDesconto.Leave += TxtDesconto_Leave;

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



        private void AtualizarValorTotal()
        {
            double total = 0;

            // Itera pelas linhas do DataGridView
            foreach (DataGridViewRow row in dgrCompras.Rows)
            {
                // Obtém o valor da última célula da linha (ValorFinal)
                string valorFinalStr = row.Cells["ValorFinal"].Value.ToString();

                // Remove o prefixo "R$ " da string e converte para um valor double
                double valorFinal;
                if (valorFinalStr.StartsWith("R$ "))
                {
                    valorFinal = Convert.ToDouble(valorFinalStr.Substring(3));
                }
                else
                {
                    valorFinal = Convert.ToDouble(valorFinalStr);
                }

                // Soma ao total
                total += valorFinal;
            }

            // Atualiza o valor total original
            valorTotalOriginal = total;

            // Exibe o total no label lblValorTotal
            lblValorTotal.Text = total.ToString("C2");
        }





        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            txtCodProduto.Focus();
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
            AtualizarValorTotal();
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
                AtualizarValorTotal();
            }
            else
            {
                MessageBox.Show("Selecione uma linha inteira para editar.");
            }
        }

        private void optCredito_CheckedChanged(object sender, EventArgs e)
        {
            // Verifica se a opção está marcada
            if (optCredito.Checked)
            {
                formaDePagamento = "Crédito";
            }
        }

        private void optDebito_CheckedChanged(object sender, EventArgs e)
        {
            // Verifica se a opção está marcada
            if (optDebito.Checked)
            {
                formaDePagamento = "Débito";
            }
        }

        private void optPix_CheckedChanged(object sender, EventArgs e)
        {
            // Verifica se a opção está marcada
            if (optPix.Checked)
            {
                formaDePagamento = "Pix";
            }
        }

        private void optDinheiro_CheckedChanged(object sender, EventArgs e)
        {
            // Armazena a forma de pagamento selecionada e torna os controles visíveis
            if (optDinheiro.Checked)
            {
                formaDePagamento = "Dinheiro";

                // Torna os controles visíveis
                lblTextoValorPago.Visible = true;
                txtValorPago.Visible = true;
                lblTextoTroco.Visible = true;
                lblTroco.Visible = true;
                btnConfirmar.Visible = true;
            }
            else
            {
                // Se outra opção for selecionada, torna os controles invisíveis
                lblTextoValorPago.Visible = false;
                txtValorPago.Visible = false;
                lblTextoTroco.Visible = false;
                lblTroco.Visible = false;
                btnConfirmar.Visible = false;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            // Verifica se o valor pago é válido
            if (!string.IsNullOrWhiteSpace(txtValorPago.Text))
            {
                // Obtém o valor pago pelo cliente
                double valorPago = Convert.ToDouble(txtValorPago.Text);

                // Obtém o valor total a ser pago
                double valorTotal = Convert.ToDouble(lblValorTotal.Text.Replace("R$ ", ""));

                // Calcula o troco
                double troco = valorPago - valorTotal;

                // Exibe o troco no label lblTroco
                lblTroco.Text = troco.ToString("C2");
            }
        }


        private void btnFinalizarCompra_Click(object sender, EventArgs e)
        {
            // Verifica se a forma de pagamento foi selecionada
            if (string.IsNullOrWhiteSpace(formaDePagamento))
            {
                MessageBox.Show("Selecione uma forma de pagamento.");
                return;
            }

            // Verifica se há itens na compra
            if (dgrCompras.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum item na compra.");
                return;
            }

            try
            {
                connection.Open();
                // Cria uma transação para garantir que todas as operações sejam feitas de forma segura
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Insere os detalhes da compra na tabela Registros
                        string insertRegistroQuery = "INSERT INTO Registros (DataHora, PrecoTotal, FormaDePagamento) VALUES (@DataHora, @PrecoTotal, @FormaDePagamento); SELECT SCOPE_IDENTITY();";
                        using (SqlCommand insertRegistroCommand = new SqlCommand(insertRegistroQuery, connection, transaction))
                        {
                            insertRegistroCommand.Parameters.AddWithValue("@DataHora", DateTime.Now);
                            insertRegistroCommand.Parameters.AddWithValue("@PrecoTotal", Convert.ToDouble(lblValorTotal.Text.Replace("R$ ", "")));
                            insertRegistroCommand.Parameters.AddWithValue("@FormaDePagamento", formaDePagamento);

                            // Executa o comando e obtém o IDTransacao gerado
                            int idTransacao = Convert.ToInt32(insertRegistroCommand.ExecuteScalar());

                            // Itera pelas linhas do DataGridView para atualizar o estoque e inserir os detalhes na tabela ItensVendidos
                            foreach (DataGridViewRow row in dgrCompras.Rows)
                            {
                                string codigo = row.Cells["Codigo"].Value.ToString();
                                string produto = row.Cells["Produto"].Value.ToString();
                                int quantidade = Convert.ToInt32(row.Cells["Quantidade"].Value.ToString());
                                double valorUnitario = Convert.ToDouble(row.Cells["ValorUnitario"].Value.ToString().Replace("R$ ", ""));
                                double valorFinal = Convert.ToDouble(row.Cells["ValorFinal"].Value.ToString().Replace("R$ ", ""));

                                // Atualiza o estoque na tabela Produtos
                                string updateQuery = "UPDATE Produtos SET QuantidadeEmEstoque = QuantidadeEmEstoque - @Quantidade WHERE Codigo = @Codigo";
                                using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection, transaction))
                                {
                                    updateCommand.Parameters.AddWithValue("@Quantidade", quantidade);
                                    updateCommand.Parameters.AddWithValue("@Codigo", codigo);
                                    updateCommand.ExecuteNonQuery();
                                }

                                // Insere os detalhes da compra na tabela ItensVendidos
                                string insertItemVendidoQuery = "INSERT INTO ItensVendidos (IDTransacao, CodigoProduto, NomeProduto, Quantidade, PrecoUnitario, PrecoTotal) VALUES (@IDTransacao, @CodigoProduto, @NomeProduto, @Quantidade, @PrecoUnitario, @PrecoTotal)";
                                using (SqlCommand insertItemVendidoCommand = new SqlCommand(insertItemVendidoQuery, connection, transaction))
                                {
                                    insertItemVendidoCommand.Parameters.AddWithValue("@IDTransacao", idTransacao);
                                    insertItemVendidoCommand.Parameters.AddWithValue("@CodigoProduto", codigo);
                                    insertItemVendidoCommand.Parameters.AddWithValue("@NomeProduto", produto);
                                    insertItemVendidoCommand.Parameters.AddWithValue("@Quantidade", quantidade);
                                    insertItemVendidoCommand.Parameters.AddWithValue("@PrecoUnitario", valorUnitario);
                                    insertItemVendidoCommand.Parameters.AddWithValue("@PrecoTotal", valorFinal);
                                    insertItemVendidoCommand.ExecuteNonQuery();
                                }
                            }

                            // Confirma a transação
                            transaction.Commit();

                            // Exibe mensagem de sucesso
                            MessageBox.Show("Compra realizada com sucesso!");

                            // Limpa os campos
                            LimparCampos();
                        }
                    }
                    catch (Exception ex)
                    {
                        // Em caso de erro, faz rollback na transação
                        transaction.Rollback();
                        MessageBox.Show("Erro ao finalizar compra: " + ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }




        private void btnConfirmarDesconto_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtDesconto.Text))
            {
                // Remove o símbolo '%' se já estiver presente
                string descontoText = txtDesconto.Text.Replace("%", "");

                // Verifica se o texto é um número válido
                if (double.TryParse(descontoText, out double desconto))
                {
                    if (desconto == 0)
                    {
                        // Se o desconto for zero, restaura o valor total original da compra
                        lblValorTotal.Text = valorTotalOriginal.ToString("C2");
                    }
                    else
                    {
                        // Calcula o valor com desconto
                        double valorTotal = Convert.ToDouble(lblValorTotal.Text.Replace("R$ ", ""));
                        double valorComDesconto = valorTotal - (valorTotal * (desconto / 100));

                        // Exibe o valor com desconto no label lblValorTotal
                        lblValorTotal.Text = valorComDesconto.ToString("C2");
                    }
                }
            }
            else
            {
                // Se o texto estiver vazio, não há desconto
                MessageBox.Show("Por favor, insira um valor de desconto válido.");
            }
        }


        private void TxtDesconto_Leave(object sender, EventArgs e)
        {
            // Verifica se o texto contém apenas números
            if (double.TryParse(txtDesconto.Text, out double desconto))
            {
                // Se sim, formata o texto adicionando o símbolo '%' sem casas decimais
                txtDesconto.Text = string.Format("{0:0}%", desconto);
            }
        }



        private void LimparCampos()
        {
            // Limpa os campos relacionados à compra
            txtCodProduto.Text = "";
            lblNomeProduto.Text = "";
            lblValorUnitario.Text = "";
            txtQuantidade.Text = "";
            dgrCompras.Rows.Clear();
            lblValorTotal.Text = "";

            // Limpa os campos relacionados ao pagamento
            txtValorPago.Text = "";
            lblTroco.Text = "";

            // Volta o foco para o campo de código do produto
            txtCodProduto.Focus();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }

}