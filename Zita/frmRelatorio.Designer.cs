namespace Zita
{
    partial class frmRelatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelatorio));
            label1 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lblVendasRealizadas = new Label();
            label2 = new Label();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            lblGanhoTotal = new Label();
            label5 = new Label();
            pnlGraficoPizza = new Panel();
            panel3 = new Panel();
            pictureBox3 = new PictureBox();
            lblGanhosDoDia = new Label();
            label4 = new Label();
            pnlGraficoBarras = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(51, 27);
            label1.Name = "label1";
            label1.Size = new Size(132, 31);
            label1.TabIndex = 0;
            label1.Text = "Relatório";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(52, 152, 219);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblVendasRealizadas);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(51, 90);
            panel1.Name = "panel1";
            panel1.Size = new Size(240, 108);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.comprasIcon;
            pictureBox1.Location = new Point(163, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // lblVendasRealizadas
            // 
            lblVendasRealizadas.AutoSize = true;
            lblVendasRealizadas.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVendasRealizadas.ForeColor = SystemColors.ButtonFace;
            lblVendasRealizadas.Location = new Point(63, 50);
            lblVendasRealizadas.Name = "lblVendasRealizadas";
            lblVendasRealizadas.Size = new Size(57, 39);
            lblVendasRealizadas.TabIndex = 1;
            lblVendasRealizadas.Text = "00";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(20, 10);
            label2.Name = "label2";
            label2.Size = new Size(131, 20);
            label2.TabIndex = 0;
            label2.Text = "Vendas Realizadas";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(46, 204, 113);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(lblGanhoTotal);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(332, 90);
            panel2.Name = "panel2";
            panel2.Size = new Size(317, 108);
            panel2.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(240, 37);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(59, 52);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // lblGanhoTotal
            // 
            lblGanhoTotal.AutoSize = true;
            lblGanhoTotal.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGanhoTotal.ForeColor = SystemColors.ButtonFace;
            lblGanhoTotal.Location = new Point(20, 50);
            lblGanhoTotal.Name = "lblGanhoTotal";
            lblGanhoTotal.Size = new Size(204, 39);
            lblGanhoTotal.TabIndex = 1;
            lblGanhoTotal.Text = "R$ 0000,00";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(20, 10);
            label5.Name = "label5";
            label5.Size = new Size(115, 20);
            label5.TabIndex = 0;
            label5.Text = "Ganhos no Total";
            // 
            // pnlGraficoPizza
            // 
            pnlGraficoPizza.BackColor = SystemColors.ButtonFace;
            pnlGraficoPizza.ForeColor = SystemColors.ActiveCaptionText;
            pnlGraficoPizza.Location = new Point(51, 227);
            pnlGraficoPizza.Name = "pnlGraficoPizza";
            pnlGraficoPizza.Size = new Size(404, 359);
            pnlGraficoPizza.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Orange;
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(lblGanhosDoDia);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(689, 90);
            panel3.Name = "panel3";
            panel3.Size = new Size(306, 108);
            panel3.TabIndex = 4;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(229, 37);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(59, 52);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // lblGanhosDoDia
            // 
            lblGanhosDoDia.AutoSize = true;
            lblGanhosDoDia.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGanhosDoDia.ForeColor = SystemColors.ButtonFace;
            lblGanhosDoDia.Location = new Point(20, 50);
            lblGanhosDoDia.Name = "lblGanhosDoDia";
            lblGanhosDoDia.Size = new Size(164, 39);
            lblGanhosDoDia.TabIndex = 1;
            lblGanhosDoDia.Text = "R$ 00,00";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(20, 10);
            label4.Name = "label4";
            label4.Size = new Size(107, 20);
            label4.TabIndex = 0;
            label4.Text = "Ganhos do Dia";
            // 
            // pnlGraficoBarras
            // 
            pnlGraficoBarras.BackColor = SystemColors.ButtonFace;
            pnlGraficoBarras.Location = new Point(485, 227);
            pnlGraficoBarras.Name = "pnlGraficoBarras";
            pnlGraficoBarras.Size = new Size(519, 355);
            pnlGraficoBarras.TabIndex = 5;
            // 
            // frmRelatorio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1056, 636);
            Controls.Add(pnlGraficoBarras);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(pnlGraficoPizza);
            Name = "frmRelatorio";
            Text = "frmRelatorio";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label lblVendasRealizadas;
        private PictureBox pictureBox1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Label lblGanhoTotal;
        private Label label5;
        private Panel pnlGraficoPizza;
        private Panel panel3;
        private PictureBox pictureBox3;
        private Label lblGanhosDoDia;
        private Label label4;
        private Panel pnlGraficoBarras;
    }
}