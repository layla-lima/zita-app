namespace Zita
{
    partial class frmMenu
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            panel1 = new Panel();
            btnMaximize = new PictureBox();
            btnMinimize = new PictureBox();
            btnClose = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox4 = new PictureBox();
            panel2 = new Panel();
            panel6 = new Panel();
            btnRelatorio = new Button();
            panel7 = new Panel();
            panel4 = new Panel();
            btnCaixa = new Button();
            btnRegistros = new Button();
            panel5 = new Panel();
            btnEstoque = new Button();
            pnlContainer = new Panel();
            lblSair = new Label();
            pictureBox5 = new PictureBox();
            pnlDesktop = new Panel();
            lblData = new Label();
            lblHora = new Label();
            panel3 = new Panel();
            label2 = new Label();
            hora = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMaximize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            pnlDesktop.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(btnMaximize);
            panel1.Controls.Add(btnMinimize);
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(298, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1072, 74);
            panel1.TabIndex = 17;
            // 
            // btnMaximize
            // 
            btnMaximize.Image = (Image)resources.GetObject("btnMaximize.Image");
            btnMaximize.Location = new Point(972, 3);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(50, 18);
            btnMaximize.SizeMode = PictureBoxSizeMode.Zoom;
            btnMaximize.TabIndex = 4;
            btnMaximize.TabStop = false;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.Image = (Image)resources.GetObject("btnMinimize.Image");
            btnMinimize.Location = new Point(925, 3);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(50, 18);
            btnMinimize.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimize.TabIndex = 3;
            btnMinimize.TabStop = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnClose
            // 
            btnClose.Image = Properties.Resources.close;
            btnClose.Location = new Point(1019, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(50, 18);
            btnClose.SizeMode = PictureBoxSizeMode.Zoom;
            btnClose.TabIndex = 1;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(356, -26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(347, 118);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Logo_branco_Photoroom_png_Photoroom;
            pictureBox4.Location = new Point(45, 28);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(202, 204);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(18, 18, 18);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(btnRelatorio);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(btnCaixa);
            panel2.Controls.Add(btnRegistros);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(btnEstoque);
            panel2.Controls.Add(pnlContainer);
            panel2.Controls.Add(lblSair);
            panel2.Controls.Add(pictureBox5);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(298, 749);
            panel2.TabIndex = 18;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(50, 50, 50);
            panel6.Location = new Point(0, 470);
            panel6.Name = "panel6";
            panel6.Size = new Size(5, 53);
            panel6.TabIndex = 26;
            // 
            // btnRelatorio
            // 
            btnRelatorio.FlatAppearance.BorderSize = 0;
            btnRelatorio.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 50);
            btnRelatorio.FlatStyle = FlatStyle.Flat;
            btnRelatorio.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnRelatorio.ForeColor = SystemColors.ControlLight;
            btnRelatorio.Image = (Image)resources.GetObject("btnRelatorio.Image");
            btnRelatorio.ImageAlign = ContentAlignment.MiddleLeft;
            btnRelatorio.Location = new Point(3, 470);
            btnRelatorio.Name = "btnRelatorio";
            btnRelatorio.Size = new Size(295, 53);
            btnRelatorio.TabIndex = 27;
            btnRelatorio.Text = "Relatório";
            btnRelatorio.UseVisualStyleBackColor = true;
            btnRelatorio.Click += btnRelatorio_Click;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(50, 50, 50);
            panel7.Location = new Point(0, 264);
            panel7.Name = "panel7";
            panel7.Size = new Size(5, 53);
            panel7.TabIndex = 24;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(50, 50, 50);
            panel4.Location = new Point(0, 402);
            panel4.Name = "panel4";
            panel4.Size = new Size(5, 53);
            panel4.TabIndex = 22;
            // 
            // btnCaixa
            // 
            btnCaixa.FlatAppearance.BorderSize = 0;
            btnCaixa.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 50);
            btnCaixa.FlatStyle = FlatStyle.Flat;
            btnCaixa.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnCaixa.ForeColor = SystemColors.ControlLight;
            btnCaixa.Image = (Image)resources.GetObject("btnCaixa.Image");
            btnCaixa.ImageAlign = ContentAlignment.MiddleLeft;
            btnCaixa.Location = new Point(3, 264);
            btnCaixa.Name = "btnCaixa";
            btnCaixa.Size = new Size(295, 53);
            btnCaixa.TabIndex = 25;
            btnCaixa.Text = "Caixa";
            btnCaixa.UseVisualStyleBackColor = true;
            btnCaixa.Click += btnCaixa_Click;
            // 
            // btnRegistros
            // 
            btnRegistros.FlatAppearance.BorderSize = 0;
            btnRegistros.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 50);
            btnRegistros.FlatStyle = FlatStyle.Flat;
            btnRegistros.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnRegistros.ForeColor = SystemColors.ControlLight;
            btnRegistros.Image = (Image)resources.GetObject("btnRegistros.Image");
            btnRegistros.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegistros.Location = new Point(3, 402);
            btnRegistros.Name = "btnRegistros";
            btnRegistros.Size = new Size(295, 53);
            btnRegistros.TabIndex = 23;
            btnRegistros.Text = "Registros";
            btnRegistros.UseVisualStyleBackColor = true;
            btnRegistros.Click += btnRegistros_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(50, 50, 50);
            panel5.Location = new Point(0, 333);
            panel5.Name = "panel5";
            panel5.Size = new Size(5, 53);
            panel5.TabIndex = 4;
            // 
            // btnEstoque
            // 
            btnEstoque.FlatAppearance.BorderSize = 0;
            btnEstoque.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 50);
            btnEstoque.FlatStyle = FlatStyle.Flat;
            btnEstoque.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnEstoque.ForeColor = SystemColors.ControlLight;
            btnEstoque.Image = (Image)resources.GetObject("btnEstoque.Image");
            btnEstoque.ImageAlign = ContentAlignment.MiddleLeft;
            btnEstoque.Location = new Point(3, 333);
            btnEstoque.Name = "btnEstoque";
            btnEstoque.Size = new Size(295, 53);
            btnEstoque.TabIndex = 19;
            btnEstoque.Text = "Estoque";
            btnEstoque.UseVisualStyleBackColor = true;
            btnEstoque.Click += btnEstoque_Click;
            // 
            // pnlContainer
            // 
            pnlContainer.Location = new Point(298, 75);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(1072, 666);
            pnlContainer.TabIndex = 17;
            // 
            // lblSair
            // 
            lblSair.AutoSize = true;
            lblSair.Cursor = Cursors.Hand;
            lblSair.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            lblSair.ForeColor = Color.White;
            lblSair.Location = new Point(150, 617);
            lblSair.Name = "lblSair";
            lblSair.Size = new Size(66, 37);
            lblSair.TabIndex = 6;
            lblSair.Text = "Sair";
            lblSair.Click += lblSair_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.sair;
            pictureBox5.Location = new Point(77, 601);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(67, 67);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 5;
            pictureBox5.TabStop = false;
            // 
            // pnlDesktop
            // 
            pnlDesktop.BackColor = SystemColors.Control;
            pnlDesktop.Controls.Add(lblData);
            pnlDesktop.Controls.Add(lblHora);
            pnlDesktop.Controls.Add(panel3);
            pnlDesktop.Dock = DockStyle.Fill;
            pnlDesktop.Location = new Point(298, 74);
            pnlDesktop.Name = "pnlDesktop";
            pnlDesktop.Size = new Size(1072, 675);
            pnlDesktop.TabIndex = 19;
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblData.ForeColor = SystemColors.ControlDarkDark;
            lblData.Location = new Point(241, 287);
            lblData.Name = "lblData";
            lblData.Size = new Size(478, 42);
            lblData.TabIndex = 4;
            lblData.Text = "semana, dia de mês de ano";
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHora.ForeColor = Color.FromArgb(60, 60, 60);
            lblHora.Location = new Point(385, 190);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(292, 73);
            lblHora.TabIndex = 3;
            lblHora.Text = "00:00:00";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 587);
            panel3.Name = "panel3";
            panel3.Size = new Size(1072, 88);
            panel3.TabIndex = 2;
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
            // hora
            // 
            hora.Enabled = true;
            hora.Tick += hora_Tick;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(pnlDesktop);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "frmMenu";
            Text = "frmMenu";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnMaximize).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            pnlDesktop.ResumeLayout(false);
            pnlDesktop.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
        private Panel panel2;
        private Panel pnlContainer;
        private Label lblSair;
        private PictureBox pictureBox5;
        private Panel pnlDesktop;
        private Label label2;
        private Panel panel3;
        private PictureBox btnMinimize;
        private PictureBox btnClose;
        private PictureBox btnMaximize;
        private Button btnEstoque;
        private Panel panel5;
        private Panel panel4;
        private Button btnRegistros;
        private Panel panel6;
        private Button btnRelatorio;
        private Panel panel7;
        private Button btnCaixa;
        private Label lblData;
        private Label lblHora;
        private System.Windows.Forms.Timer hora;
    }
}