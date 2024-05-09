﻿using System;
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
        private string formaDePagamento = "";

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

            // Exibe o total no label lblValorTotal
            lblValorTotal.Text = total.ToString("C2");
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
            // Armazena a forma de pagamento selecionada
            if (optCredito.Checked)
            {
                formaDePagamento = "Crédito";
            }
        }

        private void optDebito_CheckedChanged(object sender, EventArgs e)
        {
            // Armazena a forma de pagamento selecionada
            if (optDebito.Checked)
            {
                formaDePagamento = "Débito";
            }
        }

        private void optPix_CheckedChanged(object sender, EventArgs e)
        {
            // Armazena a forma de pagamento selecionada
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
            // Verifica se há um valor total válido
            if (!string.IsNullOrWhiteSpace(lblValorTotal.Text))
            {
                // Obtém o preço total
                double precoTotal = Convert.ToDouble(lblValorTotal.Text.Replace("R$ ", ""));

                // Obtém a forma de pagamento
                string formaDePagamento = this.formaDePagamento;

                // Obtém a data e hora atuais
                DateTime dataHoraAtual = DateTime.Now;

                try
                {
                    // Cria a conexão com o banco de dados
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        // Abre a conexão
                        connection.Open();

                        // Cria a consulta SQL para inserir os dados na tabela Registros
                        string query = "INSERT INTO Registros (DataHora, PrecoTotal, FormaDePagamento) VALUES (@DataHora, @PrecoTotal, @FormaDePagamento)";

                        // Cria e configura o comando SQL
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Adiciona os parâmetros à consulta SQL
                            command.Parameters.AddWithValue("@DataHora", dataHoraAtual);
                            command.Parameters.AddWithValue("@PrecoTotal", precoTotal);
                            command.Parameters.AddWithValue("@FormaDePagamento", formaDePagamento);

                            // Executa a consulta SQL
                            command.ExecuteNonQuery();
                        }
                    }

                    // Exibe mensagem de sucesso
                    MessageBox.Show("Compra realizada com sucesso!");

                    // Limpa todos os campos
                    LimparCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao finalizar compra: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Nenhum item na compra.");
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
