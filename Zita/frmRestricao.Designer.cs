namespace Zita
{
    partial class frmRestricao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
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
            label1.Location = new Point(155, 177);
            label1.Name = "label1";
            label1.Size = new Size(61, 21);
            label1.TabIndex = 0;
            label1.Text = "Senha:";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(222, 177);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(193, 23);
            txtSenha.TabIndex = 1;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = SystemColors.ActiveCaptionText;
            btnEntrar.FlatStyle = FlatStyle.Popup;
            btnEntrar.ForeColor = Color.White;
            btnEntrar.Location = new Point(274, 241);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(75, 23);
            btnEntrar.TabIndex = 2;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.iconAdmin3;
            pictureBox1.Location = new Point(256, 82);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(121, 72);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // frmRestricao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(602, 311);
            Controls.Add(pictureBox1);
            Controls.Add(btnEntrar);
            Controls.Add(txtSenha);
            Controls.Add(label1);
            Name = "frmRestricao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Acesso Restrito";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSenha;
        private Button btnEntrar;
        private PictureBox pictureBox1;
    }
}