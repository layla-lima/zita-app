using System;
using System.Windows.Forms;

namespace Zita
{
    public partial class frmRestricao : Form
    {
        private frmMenu menuForm;
        private Button targetButton;

        public frmRestricao(frmMenu menuForm, Button targetButton)
        {
            InitializeComponent();
            this.menuForm = menuForm;
            this.targetButton = targetButton;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string senha = txtSenha.Text.Trim();

            // Verifica se a senha está correta
            if (senha == "0506")
            {
                // Abre o formulário associado ao botão clicado
                if (targetButton == menuForm.BtnEstoque)
                {
                    frmEstoque estoqueForm = new frmEstoque();
                    menuForm.OpenChildForm(estoqueForm);
                }
                else if (targetButton == menuForm.BtnRegistros)
                {
                    frmRegistros registrosForm = new frmRegistros();
                    menuForm.OpenChildForm(registrosForm);
                }
                else if (targetButton == menuForm.BtnRelatorio)
                {
                    frmRelatorio relatorioForm = new frmRelatorio();
                    menuForm.OpenChildForm(relatorioForm);
                }
                // Fecha o formulário de restrição após o acesso concedido
                this.Close();
            }
            else
            {
                // Exibe uma mensagem de erro se a senha estiver incorreta
                MessageBox.Show("Senha incorreta. Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenha.Text = "";
                txtSenha.Focus();
            }
        }
    }
}
