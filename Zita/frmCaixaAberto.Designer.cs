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
            btnFinalizarCompra = new Button();
            dgrCompras = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
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
            btnConfirmarDesconto = new Button();
            txtDesconto = new TextBox();
            label5 = new Label();
            label4 = new Label();
            lblValorTotal = new Label();
            btnConfirmar = new Button();
            txtValorPago = new TextBox();
            lblTroco = new Label();
            lblTextoTroco = new Label();
            lblTextoValorPago = new Label();
            optDinheiro = new RadioButton();
            optPix = new RadioButton();
            optDebito = new RadioButton();
            optCredito = new RadioButton();
            label7 = new Label();
            panel2 = new Panel();
            btnBuscar = new Button();
            panel3 = new Panel();
            btnClose = new PictureBox();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            lblFuncionario = new Label();
            ((System.ComponentModel.ISupportInitialize)dgrCompras).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnFinalizarCompra
            // 
            btnFinalizarCompra.BackColor = SystemColors.ActiveCaptionText;
            btnFinalizarCompra.Cursor = Cursors.Hand;
            btnFinalizarCompra.FlatStyle = FlatStyle.Popup;
            btnFinalizarCompra.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnFinalizarCompra.ForeColor = SystemColors.ButtonFace;
            btnFinalizarCompra.Location = new Point(928, 552);
            btnFinalizarCompra.Name = "btnFinalizarCompra";
            btnFinalizarCompra.Size = new Size(267, 79);
            btnFinalizarCompra.TabIndex = 36;
            btnFinalizarCompra.Text = "Finalizar Compra";
            btnFinalizarCompra.UseVisualStyleBackColor = false;
            btnFinalizarCompra.Click += btnFinalizarCompra_Click;
            // 
            // dgrCompras
            // 
            dgrCompras.AllowUserToAddRows = false;
            dgrCompras.AllowUserToDeleteRows = false;
            dgrCompras.BackgroundColor = SystemColors.Window;
            dgrCompras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrCompras.Columns.AddRange(new DataGridViewColumn[] { Codigo, Produto, ValorUnitario, Quantidade, ValorFinal });
            dgrCompras.EnableHeadersVisualStyles = false;
            dgrCompras.Location = new Point(54, 387);
            dgrCompras.Name = "dgrCompras";
            dgrCompras.ReadOnly = true;
            dgrCompras.Size = new Size(663, 301);
            dgrCompras.TabIndex = 35;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Código";
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
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
            btnRemover.Location = new Point(244, 195);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(190, 38);
            btnRemover.TabIndex = 5;
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
            btnAdicionar.Location = new Point(32, 195);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(190, 38);
            btnAdicionar.TabIndex = 4;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(452, 134);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(74, 23);
            txtQuantidade.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(312, 127);
            label6.Name = "label6";
            label6.Size = new Size(134, 30);
            label6.TabIndex = 31;
            label6.Text = "Quantidade:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(31, 127);
            label3.Name = "label3";
            label3.Size = new Size(155, 30);
            label3.TabIndex = 28;
            label3.Text = "Valor Unitário:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(32, 78);
            label2.Name = "label2";
            label2.Size = new Size(198, 30);
            label2.TabIndex = 27;
            label2.Text = "Nome do produto:";
            // 
            // txtCodProduto
            // 
            txtCodProduto.Location = new Point(244, 34);
            txtCodProduto.Name = "txtCodProduto";
            txtCodProduto.Size = new Size(140, 23);
            txtCodProduto.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 27);
            label1.Name = "label1";
            label1.Size = new Size(209, 30);
            label1.TabIndex = 25;
            label1.Text = "Código do Produto:";
            // 
            // lblNomeProduto
            // 
            lblNomeProduto.AutoSize = true;
            lblNomeProduto.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblNomeProduto.Location = new Point(236, 76);
            lblNomeProduto.Name = "lblNomeProduto";
            lblNomeProduto.Size = new Size(171, 32);
            lblNomeProduto.TabIndex = 37;
            lblNomeProduto.Text = "Nome produto";
            // 
            // lblValorUnitario
            // 
            lblValorUnitario.AutoSize = true;
            lblValorUnitario.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblValorUnitario.Location = new Point(192, 127);
            lblValorUnitario.Name = "lblValorUnitario";
            lblValorUnitario.Size = new Size(85, 30);
            lblValorUnitario.TabIndex = 38;
            lblValorUnitario.Text = "R$ 0,00";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnConfirmarDesconto);
            panel1.Controls.Add(txtDesconto);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(lblValorTotal);
            panel1.Controls.Add(btnConfirmar);
            panel1.Controls.Add(txtValorPago);
            panel1.Controls.Add(lblTroco);
            panel1.Controls.Add(lblTextoTroco);
            panel1.Controls.Add(lblTextoValorPago);
            panel1.Controls.Add(optDinheiro);
            panel1.Controls.Add(optPix);
            panel1.Controls.Add(optDebito);
            panel1.Controls.Add(optCredito);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(782, 123);
            panel1.Name = "panel1";
            panel1.Size = new Size(561, 375);
            panel1.TabIndex = 39;
            // 
            // btnConfirmarDesconto
            // 
            btnConfirmarDesconto.BackColor = SystemColors.ActiveCaptionText;
            btnConfirmarDesconto.FlatStyle = FlatStyle.Popup;
            btnConfirmarDesconto.ForeColor = SystemColors.ButtonFace;
            btnConfirmarDesconto.Location = new Point(417, 87);
            btnConfirmarDesconto.Name = "btnConfirmarDesconto";
            btnConfirmarDesconto.Size = new Size(71, 24);
            btnConfirmarDesconto.TabIndex = 56;
            btnConfirmarDesconto.Text = "confirmar";
            btnConfirmarDesconto.UseVisualStyleBackColor = false;
            btnConfirmarDesconto.Click += btnConfirmarDesconto_Click;
            // 
            // txtDesconto
            // 
            txtDesconto.Location = new Point(352, 87);
            txtDesconto.Name = "txtDesconto";
            txtDesconto.PlaceholderText = "0%";
            txtDesconto.Size = new Size(47, 23);
            txtDesconto.TabIndex = 55;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(247, 89);
            label5.Name = "label5";
            label5.Size = new Size(86, 21);
            label5.TabIndex = 54;
            label5.Text = "Desconto:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(182, 306);
            label4.Name = "label4";
            label4.Size = new Size(89, 37);
            label4.TabIndex = 42;
            label4.Text = "Total:";
            // 
            // lblValorTotal
            // 
            lblValorTotal.AutoSize = true;
            lblValorTotal.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold);
            lblValorTotal.Location = new Point(263, 302);
            lblValorTotal.Name = "lblValorTotal";
            lblValorTotal.Size = new Size(120, 41);
            lblValorTotal.TabIndex = 43;
            lblValorTotal.Text = "R$ 0,00";
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = SystemColors.ActiveCaptionText;
            btnConfirmar.FlatStyle = FlatStyle.Popup;
            btnConfirmar.ForeColor = SystemColors.ButtonFace;
            btnConfirmar.Location = new Point(417, 135);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(71, 24);
            btnConfirmar.TabIndex = 53;
            btnConfirmar.Text = "confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Visible = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // txtValorPago
            // 
            txtValorPago.Location = new Point(352, 135);
            txtValorPago.Name = "txtValorPago";
            txtValorPago.Size = new Size(47, 23);
            txtValorPago.TabIndex = 52;
            txtValorPago.Visible = false;
            // 
            // lblTroco
            // 
            lblTroco.AutoSize = true;
            lblTroco.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            lblTroco.Location = new Point(305, 181);
            lblTroco.Name = "lblTroco";
            lblTroco.Size = new Size(78, 25);
            lblTroco.TabIndex = 51;
            lblTroco.Text = "R$ 0,00";
            lblTroco.Visible = false;
            // 
            // lblTextoTroco
            // 
            lblTextoTroco.AutoSize = true;
            lblTextoTroco.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTextoTroco.Location = new Point(247, 184);
            lblTextoTroco.Name = "lblTextoTroco";
            lblTextoTroco.Size = new Size(56, 21);
            lblTextoTroco.TabIndex = 50;
            lblTextoTroco.Text = "Troco:";
            lblTextoTroco.Visible = false;
            // 
            // lblTextoValorPago
            // 
            lblTextoValorPago.AutoSize = true;
            lblTextoValorPago.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTextoValorPago.ForeColor = SystemColors.ActiveCaptionText;
            lblTextoValorPago.Location = new Point(247, 137);
            lblTextoValorPago.Name = "lblTextoValorPago";
            lblTextoValorPago.Size = new Size(97, 21);
            lblTextoValorPago.TabIndex = 48;
            lblTextoValorPago.Text = "Valor Pago:";
            lblTextoValorPago.Visible = false;
            // 
            // optDinheiro
            // 
            optDinheiro.AutoSize = true;
            optDinheiro.Font = new Font("Segoe UI", 11.25F);
            optDinheiro.Location = new Point(35, 179);
            optDinheiro.Name = "optDinheiro";
            optDinheiro.Size = new Size(84, 24);
            optDinheiro.TabIndex = 47;
            optDinheiro.TabStop = true;
            optDinheiro.Text = "Dinheiro";
            optDinheiro.UseVisualStyleBackColor = true;
            optDinheiro.CheckedChanged += optDinheiro_CheckedChanged;
            // 
            // optPix
            // 
            optPix.AutoSize = true;
            optPix.Font = new Font("Segoe UI", 11.25F);
            optPix.Location = new Point(35, 149);
            optPix.Name = "optPix";
            optPix.Size = new Size(46, 24);
            optPix.TabIndex = 46;
            optPix.TabStop = true;
            optPix.Text = "Pix";
            optPix.UseVisualStyleBackColor = true;
            optPix.CheckedChanged += optPix_CheckedChanged;
            // 
            // optDebito
            // 
            optDebito.AutoSize = true;
            optDebito.Font = new Font("Segoe UI", 11.25F);
            optDebito.Location = new Point(35, 119);
            optDebito.Name = "optDebito";
            optDebito.Size = new Size(142, 24);
            optDebito.TabIndex = 45;
            optDebito.TabStop = true;
            optDebito.Text = "Cartão de Débito";
            optDebito.UseVisualStyleBackColor = true;
            optDebito.CheckedChanged += optDebito_CheckedChanged;
            // 
            // optCredito
            // 
            optCredito.AutoSize = true;
            optCredito.Font = new Font("Segoe UI", 11.25F);
            optCredito.Location = new Point(35, 89);
            optCredito.Name = "optCredito";
            optCredito.Size = new Size(145, 24);
            optCredito.TabIndex = 44;
            optCredito.TabStop = true;
            optCredito.Text = "Cartão de Crédito";
            optCredito.UseVisualStyleBackColor = true;
            optCredito.CheckedChanged += optCredito_CheckedChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(19, 29);
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
            panel2.Location = new Point(21, 123);
            panel2.Name = "panel2";
            panel2.Size = new Size(731, 597);
            panel2.TabIndex = 40;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.ActiveCaptionText;
            btnBuscar.FlatStyle = FlatStyle.Popup;
            btnBuscar.ForeColor = SystemColors.ButtonHighlight;
            btnBuscar.Location = new Point(410, 33);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 2;
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
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(21, 93);
            label8.Name = "label8";
            label8.Size = new Size(260, 25);
            label8.TabIndex = 39;
            label8.Text = "Nome do(a) Funcionário(a):";
            // 
            // lblFuncionario
            // 
            lblFuncionario.AutoSize = true;
            lblFuncionario.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFuncionario.ForeColor = Color.FromArgb(60, 60, 60);
            lblFuncionario.Location = new Point(277, 93);
            lblFuncionario.Name = "lblFuncionario";
            lblFuncionario.Size = new Size(71, 25);
            lblFuncionario.TabIndex = 40;
            lblFuncionario.Text = "Nome ";
            // 
            // frmCaixaAberto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(lblFuncionario);
            Controls.Add(panel3);
            Controls.Add(label8);
            Controls.Add(panel1);
            Controls.Add(btnFinalizarCompra);
            Controls.Add(dgrCompras);
            Controls.Add(panel2);
            Name = "frmCaixaAberto";
            Text = "CaixaAberto";
            WindowState = FormWindowState.Maximized;
            Load += frmCaixaAberto_Load;
            ((System.ComponentModel.ISupportInitialize)dgrCompras).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFinalizarCompra;
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
        private Label label4;
        private Label lblValorTotal;
        private Label lblTextoTroco;
        private Label lblTextoValorPago;
        private RadioButton optDinheiro;
        private RadioButton optPix;
        private RadioButton optDebito;
        private RadioButton optCredito;
        private TextBox txtValorPago;
        private Label lblTroco;
        private Button btnConfirmar;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Produto;
        private DataGridViewTextBoxColumn ValorUnitario;
        private DataGridViewTextBoxColumn Quantidade;
        private DataGridViewTextBoxColumn ValorFinal;
        private Button btnConfirmarDesconto;
        private TextBox txtDesconto;
        private Label label5;
        private Label label8;
        private Label lblFuncionario;
    }
}