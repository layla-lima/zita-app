namespace Zita
{
    partial class frmEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstoque));
            label1 = new Label();
            txtNomeProduto = new TextBox();
            txtPreco = new TextBox();
            label2 = new Label();
            label3 = new Label();
            cboCategoria = new ComboBox();
            btnEditar = new Button();
            btnAdicionar = new Button();
            btnDeletar = new Button();
            dgrEstoque = new DataGridView();
            txtCodigo = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtQuant = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgrEstoque).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(254, 67);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 2;
            label1.Text = "Nome do Produto:";
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.Location = new Point(254, 85);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(145, 23);
            txtNomeProduto.TabIndex = 2;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(653, 85);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(145, 23);
            txtPreco.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(453, 67);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 4;
            label2.Text = "Categoria:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(653, 67);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 6;
            label3.Text = "Preço:";
            // 
            // cboCategoria
            // 
            cboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategoria.FlatStyle = FlatStyle.System;
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Items.AddRange(new object[] { "Bolsas", "Semijoias", "Calçados", "Óculos", "Acessórios" });
            cboCategoria.Location = new Point(453, 85);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(145, 23);
            cboCategoria.TabIndex = 3;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = SystemColors.ActiveCaptionText;
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.FlatStyle = FlatStyle.Popup;
            btnEditar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEditar.ForeColor = SystemColors.ButtonFace;
            btnEditar.Location = new Point(480, 152);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(122, 40);
            btnEditar.TabIndex = 7;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = SystemColors.ActiveCaptionText;
            btnAdicionar.Cursor = Cursors.Hand;
            btnAdicionar.FlatStyle = FlatStyle.Popup;
            btnAdicionar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAdicionar.ForeColor = SystemColors.ButtonFace;
            btnAdicionar.Location = new Point(320, 152);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(122, 40);
            btnAdicionar.TabIndex = 6;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnDeletar
            // 
            btnDeletar.BackColor = SystemColors.ActiveCaptionText;
            btnDeletar.Cursor = Cursors.Hand;
            btnDeletar.FlatStyle = FlatStyle.Popup;
            btnDeletar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDeletar.ForeColor = SystemColors.ButtonFace;
            btnDeletar.Location = new Point(639, 152);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(122, 40);
            btnDeletar.TabIndex = 8;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = false;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // dgrEstoque
            // 
            dgrEstoque.AllowUserToAddRows = false;
            dgrEstoque.AllowUserToDeleteRows = false;
            dgrEstoque.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrEstoque.EnableHeadersVisualStyles = false;
            dgrEstoque.Location = new Point(98, 251);
            dgrEstoque.Name = "dgrEstoque";
            dgrEstoque.ReadOnly = true;
            dgrEstoque.Size = new Size(872, 296);
            dgrEstoque.TabIndex = 15;
            dgrEstoque.TabStop = false;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(56, 85);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(145, 23);
            txtCodigo.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(56, 67);
            label5.Name = "label5";
            label5.Size = new Size(113, 15);
            label5.TabIndex = 17;
            label5.Text = "Código do Produto:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(853, 67);
            label6.Name = "label6";
            label6.Size = new Size(74, 15);
            label6.TabIndex = 19;
            label6.Text = "Quantidade:";
            // 
            // txtQuant
            // 
            txtQuant.Location = new Point(853, 85);
            txtQuant.Name = "txtQuant";
            txtQuant.Size = new Size(145, 23);
            txtQuant.TabIndex = 5;
            // 
            // frmEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1056, 636);
            Controls.Add(label6);
            Controls.Add(txtQuant);
            Controls.Add(txtCodigo);
            Controls.Add(label5);
            Controls.Add(dgrEstoque);
            Controls.Add(btnDeletar);
            Controls.Add(btnAdicionar);
            Controls.Add(btnEditar);
            Controls.Add(cboCategoria);
            Controls.Add(label3);
            Controls.Add(txtPreco);
            Controls.Add(label2);
            Controls.Add(txtNomeProduto);
            Controls.Add(label1);
            ForeColor = Color.FromArgb(13, 13, 13);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Name = "frmEstoque";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Zita ";
            ((System.ComponentModel.ISupportInitialize)dgrEstoque).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox txtNomeProduto;
        private TextBox txtPreco;
        private Label label2;
        private Label label3;
        private ComboBox cboCategoria;
        private Button btnEditar;
        private Button btnAdicionar;
        private Button btnDeletar;
        private DataGridView dgrEstoque;
        private TextBox txtCodigo;
        private Label label5;
        private Label label6;
        private TextBox txtQuant;
    }
}