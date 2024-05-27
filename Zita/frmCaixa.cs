using System;
using System.Windows.Forms;

namespace Zita
{
    public partial class frmCaixa : Form
    {
        private string nomeUsuario;

        public frmCaixa(string nomeUsuario)
        {
            InitializeComponent();
            this.nomeUsuario = nomeUsuario;
        }

        private async void btnAbrirCaixa_Click(object sender, EventArgs e)
        {
            await Task.Delay(300);

            // Agora, ao criar uma instância de frmCaixaAberto, você passa o nome do usuário como argumento para o construtor
            frmCaixaAberto frmCaixaAberto = new frmCaixaAberto(nomeUsuario);
            frmCaixaAberto.Show();
        }

        private void frmCaixa_Load(object sender, EventArgs e)
        {
            // Aqui você pode usar o nome do usuário conforme necessário
            // Por exemplo, exibir o nome do usuário em um label, se necessário
            // lblNomeUsuario.Text = $"Bem-vindo, {nomeUsuario}";
        }
    }
}
