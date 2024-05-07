using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Zita
{
    public partial class frmCadastro : Form
    {
        string connectionString = "Data Source=DESKTOP-M2PRVUH;Initial Catalog=Zita;Integrated Security=True";

        public frmCadastro()
        {
            InitializeComponent();
            
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string email = txtEmail.Text;
            string senha = txtSenha.Text;
            string confirmarSenha = txtConfirmarSenha.Text;

            // Verifica se as senhas coincidem
            if (senha != confirmarSenha)
            {
                MessageBox.Show("As senhas não coincidem. Por favor, insira senhas iguais.", "Erro de Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Insere os dados na tabela Usuarios
            string query = "INSERT INTO Usuarios (NomeUsuario, Email, Senha) VALUES (@NomeUsuario, @Email, @Senha)";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NomeUsuario", nome);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Senha", senha);

                        command.ExecuteNonQuery();

                        MessageBox.Show("Cadastro realizado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Após o cadastro bem-sucedido, abre o formulário de login
                        frmLogin loginForm = new frmLogin();
                        loginForm.Show();

                        this.Hide(); // Fecha o formulário de cadastro
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar usuário: " + ex.Message, "Erro de Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
