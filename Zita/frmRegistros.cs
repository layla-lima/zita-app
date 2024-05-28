﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Zita
{
    public partial class frmRegistros : Form
    {
        private string connectionString = DBHelper.ConnectionString;
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataTable dataTable;

        public frmRegistros()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            connection = new SqlConnection(connectionString);

            // Configura o adaptador com a consulta SQL para incluir o nome do usuário
            adapter = new SqlDataAdapter("SELECT r.*, u.NomeUsuario AS NomeUsuario FROM Registros r JOIN Usuarios u ON r.IDUsuario = u.IDUsuario", connection);
            dataTable = new DataTable();
            this.Load += frmRegistros_Load;

            // Adiciona o evento ao TextBox de pesquisa
            txtPesquisar.TextChanged += TxtPesquisar_TextChanged;

            // Adiciona os eventos aos botões
            btnFiltrar.Click += BtnFiltrar_Click;
            btnLimparFiltro.Click += BtnLimparFiltro_Click;

            // Desativa os estilos visuais dos cabeçalhos
            dgrRegistros.EnableHeadersVisualStyles = false;

            // Define o estilo para o cabeçalho das colunas
            dgrRegistros.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dgrRegistros.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgrRegistros.AdvancedColumnHeadersBorderStyle.All = DataGridViewAdvancedCellBorderStyle.None;
            dgrRegistros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Carrega os registros ao inicializar o formulário
            CarregarRegistros();
        }

        private void frmRegistros_Load(object sender, EventArgs e)
        {
            // Oculta a coluna "IDTransacao" se ela existir
            if (dgrRegistros.Columns.Contains("IDTransacao"))
            {
                dgrRegistros.Columns["IDTransacao"].Visible = false;
            }
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            FiltrarRegistrosPorDataEUsuario();
        }

        private void BtnLimparFiltro_Click(object sender, EventArgs e)
        {
            // Limpa os filtros
            txtPesquisar.Clear();
            CarregarRegistros();
        }

        private void FiltrarRegistrosPorDataEUsuario()
        {
            try
            {
                // Obtém os valores dos DateTimePickers
                DateTime dataInicio = dateTimePickerInicio.Value.Date; // Apenas a data, sem a parte do tempo
                DateTime dataFim = dateTimePickerFim.Value.Date.AddDays(1).AddSeconds(-1); // Ajusta para o final do dia selecionado

                // Limpa a DataTable antes de preencher com os dados filtrados
                dataTable.Clear();

                // Configura os parâmetros da consulta SQL
                adapter.SelectCommand.Parameters.Clear();
                adapter.SelectCommand.Parameters.AddWithValue("@DataInicio", dataInicio);
                adapter.SelectCommand.Parameters.AddWithValue("@DataFim", dataFim);

                // Constrói a cláusula de filtro
                string filtro = "r.DataHora >= @DataInicio AND r.DataHora <= @DataFim";

                // Adiciona o filtro por usuário e forma de pagamento
                if (!string.IsNullOrEmpty(txtPesquisar.Text))
                {
                    filtro += " AND (u.NomeUsuario LIKE @TermoPesquisa OR r.FormaDePagamento LIKE @TermoPesquisa)";
                    adapter.SelectCommand.Parameters.AddWithValue("@TermoPesquisa", "%" + txtPesquisar.Text.Trim() + "%");
                }

                // Monta a consulta SQL completa
                string consultaCompleta = "SELECT r.*, u.NomeUsuario AS Funcionario FROM Registros r JOIN Usuarios u ON r.NomeUsuario = u.NomeUsuario WHERE " + filtro;

                // Preenche a DataTable com os dados filtrados
                adapter.SelectCommand.CommandText = consultaCompleta;
                adapter.Fill(dataTable);

                // Atualiza o DataGridView com os dados filtrados
                dgrRegistros.DataSource = dataTable;

                // Calcula e exibe o valor total filtrado
                CalcularEExibirValorTotalFiltrado();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao filtrar registros por data e usuário: " + ex.Message);
            }
        }







        private void CalcularEExibirValorTotalFiltrado()
        {
            decimal valorTotal = 0;
            foreach (DataRow row in dataTable.Rows)
            {
                valorTotal += Convert.ToDecimal(row["PrecoTotal"]);
            }
            lblValorTotalFiltrado.Text = valorTotal.ToString("C"); // Exibe apenas o valor no formato de moeda
        }

        private void CarregarRegistros()
        {
            try
            {
                // Limpa a DataTable antes de preencher com todos os registros
                dataTable?.Clear();

                // Preenche a DataTable com todos os registros, incluindo apenas a coluna Funcionario (NomeUsuario)
                adapter.SelectCommand.CommandText = "SELECT *, NomeUsuario AS Funcionario FROM Registros";
                adapter.Fill(dataTable);

                if (dataTable != null && dataTable.Rows.Count > 0)
                {
                    // Oculta a coluna "IDTransacao" se ela existir
                    if (dgrRegistros.Columns.Contains("IDTransacao"))
                    {
                        dgrRegistros.Columns["IDTransacao"].Visible = false;
                    }

                    // Atualiza o DataGridView com todos os registros
                    dgrRegistros.DataSource = dataTable;

                    // Remove a coluna NomeUsuario do grid
                    if (dgrRegistros.Columns.Contains("NomeUsuario"))
                    {
                        dgrRegistros.Columns["NomeUsuario"].Visible = false;
                    }

                    // Calcula e exibe o valor total
                    CalcularEExibirValorTotalFiltrado();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar registros: " + ex.Message);
            }
        }

        private void TxtPesquisar_TextChanged(object sender, EventArgs e)
        {
            // Quando o texto da caixa de pesquisa é alterado, filtramos novamente
            FiltrarRegistrosPorDataEUsuario();
        }
    }
}
