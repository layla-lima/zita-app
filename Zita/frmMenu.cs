using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Zita
{
    public partial class frmMenu : Form
    {
        public Form CurrentChildForm { get; private set; }
        public Button LastClickedButton { get; private set; }
        public Button BtnRelatorio { get { return btnRelatorio; } }


        private List<Button> menuButtons;

        public Button BtnEstoque { get { return btnEstoque; } }
        public Button BtnRegistros { get { return btnRegistros; } }

        private string nomeUsuario;
        private string usuarioLogado;

        public frmMenu(string usuarioLogado)
        {
            InitializeComponent();
            this.nomeUsuario = usuarioLogado;
            this.FormBorderStyle = FormBorderStyle.None;
            menuButtons = new List<Button> { btnCaixa, btnRegistros, btnEstoque, btnRelatorio };
            this.usuarioLogado = usuarioLogado;

        }

        public void ToggleFullScreen()
        {
            if (this.FormBorderStyle == FormBorderStyle.None)
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
            }
        }

        public void OpenChildForm(Form childForm)
        {
            if (CurrentChildForm != null)
            {
                CurrentChildForm.Close();
            }
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlDesktop.Controls.Add(childForm);
            Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            CurrentChildForm = childForm;
        }

        private void frmMenu_KeyDown(object sender, KeyEventArgs e)
        {
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
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblSair_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja deslogar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Deslogar();
            }
        }

        private void Deslogar()
        {
            // Fecha o formulário atual
            this.Hide();

            // Abre o formulário de login
            frmLogin loginForm = new frmLogin();
            loginForm.ShowDialog();

            // Fecha a aplicação se o formulário de login for fechado
            this.Close();
        }


        private void btnCaixa_Click(object sender, EventArgs e)
        {
            frmCaixa frmCaixa = new frmCaixa(usuarioLogado);
            frmCaixa.TopLevel = false;
            frmCaixa.FormBorderStyle = FormBorderStyle.None;
            frmCaixa.Dock = DockStyle.Fill;
            this.Controls.Add(frmCaixa);
            this.Tag = frmCaixa;
            frmCaixa.BringToFront();
            frmCaixa.Show();
        }

        public void btnRegistros_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            clickedButton.BackColor = Color.FromArgb(50, 50, 50);

            foreach (Button button in menuButtons)
            {
                if (button != clickedButton)
                {
                    button.BackColor = Color.FromArgb(18, 18, 18);
                }
            }

            LastClickedButton = clickedButton;
            frmRestricao restricaoForm = new frmRestricao(this, clickedButton);
            restricaoForm.ShowDialog();
        }

        public void btnEstoque_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            clickedButton.BackColor = Color.FromArgb(50, 50, 50);

            foreach (Button button in menuButtons)
            {
                if (button != clickedButton)
                {
                    button.BackColor = Color.FromArgb(18, 18, 18);
                }
            }

            frmEstoque estoqueForm = new frmEstoque();
            OpenChildForm(estoqueForm);
        }

        public void btnRelatorio_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            clickedButton.BackColor = Color.FromArgb(50, 50, 50);

            foreach (Button button in menuButtons)
            {
                if (button != clickedButton)
                {
                    button.BackColor = Color.FromArgb(18, 18, 18);
                }
            }

            LastClickedButton = clickedButton;
            frmRestricao restricaoForm = new frmRestricao(this, clickedButton);
            restricaoForm.ShowDialog();
        }

        private void hora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblData.Text = DateTime.Now.ToLongDateString();
        }

        public void ResetToInitialState()
        {
            if (CurrentChildForm != null)
            {
                CurrentChildForm.Close();
                CurrentChildForm = null;
            }

            // Se necessário, redefina outros elementos visuais ou dados do formulário aqui
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ResetToInitialState();
        }
    }
}
