namespace Zita
{
    partial class frmRegistros
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
            panel3 = new Panel();
            label2 = new Label();
            label4 = new Label();
            lblValorTotalFiltrado = new Label();
            label1 = new Label();
            dateTimePickerInicio = new DateTimePicker();
            dateTimePickerFim = new DateTimePicker();
            btnFiltrar = new Button();
            label3 = new Label();
            label5 = new Label();
            dgrRegistros = new DataGridView();
            label6 = new Label();
            cboFormaDePagamento = new ComboBox();
            btnLimparFiltro = new Button();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgrRegistros).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 548);
            panel3.Name = "panel3";
            panel3.Size = new Size(1056, 88);
            panel3.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(339, 38);
            label2.Name = "label2";
            label2.Size = new Size(398, 15);
            label2.TabIndex = 1;
            label2.Text = "Sistema desenvolvido por Layla Lima © 2024. Todos os direitos reservados.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Banner", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(105, 23);
            label4.Name = "label4";
            label4.Size = new Size(302, 39);
            label4.TabIndex = 22;
            label4.Text = "Gerenciamento de Vendas";
            // 
            // lblValorTotalFiltrado
            // 
            lblValorTotalFiltrado.AutoSize = true;
            lblValorTotalFiltrado.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblValorTotalFiltrado.ForeColor = Color.DimGray;
            lblValorTotalFiltrado.Location = new Point(176, 500);
            lblValorTotalFiltrado.Name = "lblValorTotalFiltrado";
            lblValorTotalFiltrado.Size = new Size(114, 32);
            lblValorTotalFiltrado.TabIndex = 23;
            lblValorTotalFiltrado.Text = "R$ 00,00";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(102, 500);
            label1.Name = "label1";
            label1.Size = new Size(81, 32);
            label1.TabIndex = 24;
            label1.Text = "Valor:";
            // 
            // dateTimePickerInicio
            // 
            dateTimePickerInicio.Format = DateTimePickerFormat.Short;
            dateTimePickerInicio.Location = new Point(162, 81);
            dateTimePickerInicio.Name = "dateTimePickerInicio";
            dateTimePickerInicio.Size = new Size(101, 23);
            dateTimePickerInicio.TabIndex = 26;
            // 
            // dateTimePickerFim
            // 
            dateTimePickerFim.Format = DateTimePickerFormat.Short;
            dateTimePickerFim.Location = new Point(307, 81);
            dateTimePickerFim.Name = "dateTimePickerFim";
            dateTimePickerFim.Size = new Size(101, 23);
            dateTimePickerFim.TabIndex = 27;
            // 
            // btnFiltrar
            // 
            btnFiltrar.BackColor = SystemColors.ActiveCaptionText;
            btnFiltrar.FlatStyle = FlatStyle.Popup;
            btnFiltrar.ForeColor = SystemColors.ButtonFace;
            btnFiltrar.Location = new Point(740, 81);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(93, 23);
            btnFiltrar.TabIndex = 28;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = false;
            btnFiltrar.Click += BtnFiltrar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(127, 85);
            label3.Name = "label3";
            label3.Size = new Size(29, 17);
            label3.TabIndex = 29;
            label3.Text = "De:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label5.Location = new Point(268, 85);
            label5.Name = "label5";
            label5.Size = new Size(33, 17);
            label5.TabIndex = 30;
            label5.Text = "Até:";
            // 
            // dgrRegistros
            // 
            dgrRegistros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrRegistros.Location = new Point(103, 117);
            dgrRegistros.Name = "dgrRegistros";
            dgrRegistros.Size = new Size(852, 371);
            dgrRegistros.TabIndex = 31;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label6.Location = new Point(418, 85);
            label6.Name = "label6";
            label6.Size = new Size(144, 17);
            label6.TabIndex = 32;
            label6.Text = "Forma de Pagamento:";
            // 
            // cboFormaDePagamento
            // 
            cboFormaDePagamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFormaDePagamento.FormattingEnabled = true;
            cboFormaDePagamento.Location = new Point(568, 81);
            cboFormaDePagamento.Name = "cboFormaDePagamento";
            cboFormaDePagamento.Size = new Size(143, 23);
            cboFormaDePagamento.TabIndex = 33;
            // 
            // btnLimparFiltro
            // 
            btnLimparFiltro.BackColor = SystemColors.ActiveCaptionText;
            btnLimparFiltro.FlatStyle = FlatStyle.Popup;
            btnLimparFiltro.ForeColor = SystemColors.ButtonFace;
            btnLimparFiltro.Location = new Point(864, 81);
            btnLimparFiltro.Name = "btnLimparFiltro";
            btnLimparFiltro.Size = new Size(91, 23);
            btnLimparFiltro.TabIndex = 34;
            btnLimparFiltro.Text = "Limpar Filtro";
            btnLimparFiltro.UseVisualStyleBackColor = false;
            btnLimparFiltro.Click += BtnLimparFiltro_Click;
            // 
            // frmRegistros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1056, 636);
            Controls.Add(btnLimparFiltro);
            Controls.Add(cboFormaDePagamento);
            Controls.Add(label6);
            Controls.Add(dgrRegistros);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(btnFiltrar);
            Controls.Add(dateTimePickerFim);
            Controls.Add(dateTimePickerInicio);
            Controls.Add(label1);
            Controls.Add(lblValorTotalFiltrado);
            Controls.Add(label4);
            Controls.Add(panel3);
            Name = "frmRegistros";
            Text = "frmRegistros";
            WindowState = FormWindowState.Maximized;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgrRegistros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel3;
        private Label label2;
        private Label label4;
        private Label lblValorTotalFiltrado;
        private Label label1;
        private DateTimePicker dateTimePickerInicio;
        private DateTimePicker dateTimePickerFim;
        private Button btnFiltrar;
        private Label label3;
        private Label label5;
        private DataGridView dgrRegistros;
        private Label label6;
        private ComboBox cboFormaDePagamento;
        private Button btnLimparFiltro;
    }
}