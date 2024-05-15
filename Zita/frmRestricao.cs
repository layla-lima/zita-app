using Zita;

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
        if (txtSenha.Text == "0506")
        {
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
            this.Close();
        }
        else
        {
            MessageBox.Show("Senha incorreta. Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtSenha.Text = "";
            txtSenha.Focus();
        }
    }

    private void InitializeComponent()
    {
        label1 = new Label();
        txtSenha = new TextBox();
        btnEntrar = new Button();
        pictureBox1 = new PictureBox();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label1.Location = new Point(155, 132);
        label1.Name = "label1";
        label1.Size = new Size(61, 21);
        label1.TabIndex = 0;
        label1.Text = "Senha:";
        // 
        // txtSenha
        // 
        txtSenha.Location = new Point(222, 132);
        txtSenha.Name = "txtSenha";
        txtSenha.Size = new Size(181, 23);
        txtSenha.TabIndex = 1;
        txtSenha.UseSystemPasswordChar = true;
        // 
        // btnEntrar
        // 
        btnEntrar.BackColor = SystemColors.ActiveCaptionText;
        btnEntrar.FlatStyle = FlatStyle.Popup;
        btnEntrar.ForeColor = SystemColors.Control;
        btnEntrar.Location = new Point(271, 194);
        btnEntrar.Name = "btnEntrar";
        btnEntrar.Size = new Size(75, 23);
        btnEntrar.TabIndex = 2;
        btnEntrar.Text = "Entrar";
        btnEntrar.UseVisualStyleBackColor = false;
        btnEntrar.Click += btnEntrar_Click;
        // 
        // pictureBox1
        // 
        pictureBox1.Image = Zita.Properties.Resources.iconAdmin1;
        pictureBox1.Location = new Point(271, 43);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(74, 67);
        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox1.TabIndex = 3;
        pictureBox1.TabStop = false;
        // 
        // frmRestricao
        // 
        BackColor = Color.White;
        ClientSize = new Size(605, 285);
        Controls.Add(pictureBox1);
        Controls.Add(btnEntrar);
        Controls.Add(txtSenha);
        Controls.Add(label1);
        Name = "frmRestricao";
        StartPosition = FormStartPosition.CenterScreen;
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private Label label1;
    private TextBox txtSenha;
    private Button btnEntrar;
    private PictureBox pictureBox1;
}
