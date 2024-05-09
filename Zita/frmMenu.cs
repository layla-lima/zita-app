using System;
using System.Windows.Forms;

namespace Zita
{
    public partial class frmMenu : Form
    {
        private Form currentChildForm;

        public frmMenu()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;

        }

        private void ToggleFullScreen()
        {
            if (this.FormBorderStyle == FormBorderStyle.None)
            {
                // Se estiver em tela cheia, restaura para o tamanho normal e exibe a borda do formulário
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                // Se estiver no modo normal, entra em tela cheia
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlDesktop.Controls.Add(childForm); // Adicione o childForm ao pnlContainer
            Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            currentChildForm = childForm;
        }


        private void frmMenu_KeyDown(object sender, KeyEventArgs e)
        {
            // Verifica se a tecla F11 foi pressionada
            if (e.KeyCode == Keys.F11)
            {
                ToggleFullScreen();
            }
        }


        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            {
                if (this.WindowState == FormWindowState.Normal)
                    this.WindowState = FormWindowState.Maximized;
                else
                    this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblSair_Click(object sender, EventArgs e)
        {
            // Exibe uma caixa de diálogo de confirmação
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verifica se o usuário clicou no botão "Sim" na caixa de diálogo
            if (resultado == DialogResult.Yes)
            {
                // Fecha o sistema
                Application.Exit();
            }
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            frmEstoque estoqueForm = new frmEstoque();

            // Chama o método OpenChildForm para abrir frmEstoque como formulário filho
            OpenChildForm(estoqueForm);
        }

        private void btnRegistros_Click(object sender, EventArgs e)
        {
            // Cria uma nova instância do frmRegistros
            frmRegistros registrosForm = new frmRegistros();

            // Chama o método OpenChildForm para abrir frmRegistros como formulário filho
            OpenChildForm(registrosForm);
        }

        private void btnCaixa_Click(object sender, EventArgs e)
        {
            frmCaixa caixaForm = new frmCaixa();

            // Chama o método OpenChildForm para abrir frmEstoque como formulário filho
            OpenChildForm(caixaForm);
        }
    }
}
