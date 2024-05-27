using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Zita
{
    public partial class frmLogin : Form
    {
        private string connectionString = DBHelper.ConnectionString;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string senha = txtSenha.Text;

            // Consulta SQL para verificar se o usuário e senha estão corretos
            string query = "SELECT COUNT(*) FROM Usuarios WHERE Email = @Email AND Senha = @Senha";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Senha", senha);

                        int count = (int)command.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("Login bem-sucedido!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Consulta SQL para obter o nome do usuário
                            string nomeQuery = "SELECT NomeUsuario FROM Usuarios WHERE Email = @Email";
                            using (SqlCommand nomeCommand = new SqlCommand(nomeQuery, connection))
                            {
                                nomeCommand.Parameters.AddWithValue("@Email", email);
                                string nomeUsuario = (string)nomeCommand.ExecuteScalar();

                                // Abre o formulário do menu (frmMenu) e passa o nome do usuário
                                frmMenu menuForm = new frmMenu(nomeUsuario);
                                menuForm.Show();

                                // Fecha o formulário de login
                                this.Hide();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Email ou senha incorretos. Por favor, tente novamente.", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar fazer login: " + ex.Message, "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        private void lblCriarConta_Click(object sender, EventArgs e)
        {
            // Abrir o formulário de cadastro
            frmCadastro cadastroForm = new frmCadastro();
            cadastroForm.Show();

            // Fechar o formulário de login
            this.Hide();
        }
    }
}
