namespace Zita
{
    partial class frmCaixaAberto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCaixaAberto));
            button3 = new Button();
            dgrCompras = new DataGridView();
            Código = new DataGridViewTextBoxColumn();
            Produto = new DataGridViewTextBoxColumn();
            ValorUnitario = new DataGridViewTextBoxColumn();
            Quantidade = new DataGridViewTextBoxColumn();
            ValorFinal = new DataGridViewTextBoxColumn();
            btnRemover = new Button();
            btnAdicionar = new Button();
            txtQuantidade = new TextBox();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtCodProduto = new TextBox();
            label1 = new Label();
            lblNomeProduto = new Label();
            lblValorUnitario = new Label();
            panel1 = new Panel();
            label7 = new Label();
            panel2 = new Panel();
            btnBuscar = new Button();
            panel3 = new Panel();
            btnClose = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgrCompras).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaptionText;
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Location = new Point(928, 552);
            button3.Name = "button3";
            button3.Size = new Size(267, 79);
            button3.TabIndex = 36;
            button3.Text = "Finalizar Compra";
            button3.UseVisualStyleBackColor = false;
            // 
            // dgrCompras
            // 
            dgrCompras.AllowUserToAddRows = false;
            dgrCompras.AllowUserToDeleteRows = false;
            dgrCompras.BackgroundColor = SystemColors.Window;
            dgrCompras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrCompras.Columns.AddRange(new DataGridViewColumn[] { Código, Produto, ValorUnitario, Quantidade, ValorFinal });
            dgrCompras.EnableHeadersVisualStyles = false;
            dgrCompras.Location = new Point(54, 354);
            dgrCompras.Name = "dgrCompras";
            dgrCompras.ReadOnly = true;
            dgrCompras.Size = new Size(669, 341);
            dgrCompras.TabIndex = 35;
            // 
            // Código
            // 
            Código.HeaderText = "Código";
            Código.Name = "Código";
            Código.ReadOnly = true;
            // 
            // Produto
            // 
            Produto.HeaderText = "Produto";
            Produto.Name = "Produto";
            Produto.ReadOnly = true;
            // 
            // ValorUnitario
            // 
            ValorUnitario.HeaderText = "ValorUnitario";
            ValorUnitario.Name = "ValorUnitario";
            ValorUnitario.ReadOnly = true;
            // 
            // Quantidade
            // 
            Quantidade.HeaderText = "Quantidade";
            Quantidade.Name = "Quantidade";
            Quantidade.ReadOnly = true;
            // 
            // ValorFinal
            // 
            ValorFinal.HeaderText = "ValorFinal";
            ValorFinal.Name = "ValorFinal";
            ValorFinal.ReadOnly = true;
            // 
            // btnRemover
            // 
            btnRemover.BackColor = SystemColors.ActiveCaptionText;
            btnRemover.Cursor = Cursors.Hand;
            btnRemover.FlatStyle = FlatStyle.Popup;
            btnRemover.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnRemover.ForeColor = SystemColors.ButtonFace;
            btnRemover.Location = new Point(245, 199);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(190, 38);
            btnRemover.TabIndex = 34;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = false;
            btnRemover.Click += btnRemover_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = SystemColors.ActiveCaptionText;
            btnAdicionar.Cursor = Cursors.Hand;
            btnAdicionar.FlatStyle = FlatStyle.Popup;
            btnAdicionar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAdicionar.ForeColor = SystemColors.ButtonFace;
            btnAdicionar.Location = new Point(33, 199);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(190, 38);
            btnAdicionar.TabIndex = 33;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(453, 138);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(74, 23);
            txtQuantidade.TabIndex = 32;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(313, 131);
            label6.Name = "label6";
            label6.Size = new Size(134, 30);
            label6.TabIndex = 31;
            label6.Text = "Quantidade:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(32, 131);
            label3.Name = "label3";
            label3.Size = new Size(155, 30);
            label3.TabIndex = 28;
            label3.Text = "Valor Unitário:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(33, 82);
            label2.Name = "label2";
            label2.Size = new Size(198, 30);
            label2.TabIndex = 27;
            label2.Text = "Nome do produto:";
            // 
            // txtCodProduto
            // 
            txtCodProduto.Location = new Point(245, 38);
            txtCodProduto.Name = "txtCodProduto";
            txtCodProduto.Size = new Size(140, 23);
            txtCodProduto.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 31);
            label1.Name = "label1";
            label1.Size = new Size(209, 30);
            label1.TabIndex = 25;
            label1.Text = "Código do Produto:";
            // 
            // lblNomeProduto
            // 
            lblNomeProduto.AutoSize = true;
            lblNomeProduto.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblNomeProduto.Location = new Point(237, 80);
            lblNomeProduto.Name = "lblNomeProduto";
            lblNomeProduto.Size = new Size(171, 32);
            lblNomeProduto.TabIndex = 37;
            lblNomeProduto.Text = "Nome produto";
            // 
            // lblValorUnitario
            // 
            lblValorUnitario.AutoSize = true;
            lblValorUnitario.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblValorUnitario.Location = new Point(193, 131);
            lblValorUnitario.Name = "lblValorUnitario";
            lblValorUnitario.Size = new Size(85, 30);
            lblValorUnitario.TabIndex = 38;
            lblValorUnitario.Text = "R$ 0,00";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label7);
            panel1.Location = new Point(782, 93);
            panel1.Name = "panel1";
            panel1.Size = new Size(561, 396);
            panel1.TabIndex = 39;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(16, 18);
            label7.Name = "label7";
            label7.Size = new Size(228, 30);
            label7.TabIndex = 41;
            label7.Text = "Forma de Pagamento:";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnBuscar);
            panel2.Controls.Add(txtCodProduto);
            panel2.Controls.Add(txtQuantidade);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(btnRemover);
            panel2.Controls.Add(lblValorUnitario);
            panel2.Controls.Add(btnAdicionar);
            panel2.Controls.Add(lblNomeProduto);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(21, 93);
            panel2.Name = "panel2";
            panel2.Size = new Size(731, 627);
            panel2.TabIndex = 40;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.ActiveCaptionText;
            btnBuscar.FlatStyle = FlatStyle.Popup;
            btnBuscar.ForeColor = SystemColors.ButtonHighlight;
            btnBuscar.Location = new Point(411, 37);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 40;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaptionText;
            panel3.Controls.Add(btnClose);
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1370, 74);
            panel3.TabIndex = 41;
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.Image = Properties.Resources.close;
            btnClose.Location = new Point(1324, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(46, 18);
            btnClose.SizeMode = PictureBoxSizeMode.Zoom;
            btnClose.TabIndex = 1;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(534, -21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(347, 118);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // frmCaixaAberto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(button3);
            Controls.Add(dgrCompras);
            Controls.Add(panel2);
            Name = "frmCaixaAberto";
            Text = "CaixaAberto";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgrCompras).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button3;
        private DataGridView dgrCompras;
        private Button btnRemover;
        private Button btnAdicionar;
        private TextBox txtQuantidade;
        private Label label6;
        private Label label3;
        private Label label2;
        private TextBox txtCodProduto;
        private Label label1;
        private Label lblNomeProduto;
        private Label lblValorUnitario;
        private Panel panel1;
        private Panel panel2;
        private Label label7;
        private Panel panel3;
        private PictureBox btnClose;
        private PictureBox pictureBox1;
        private Button btnBuscar;
        private DataGridViewTextBoxColumn Código;
        private DataGridViewTextBoxColumn Produto;
        private DataGridViewTextBoxColumn ValorUnitario;
        private DataGridViewTextBoxColumn Quantidade;
        private DataGridViewTextBoxColumn ValorFinal;
    }
}