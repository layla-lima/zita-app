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
            dgrRegistros = new Zuby.ADGV.AdvancedDataGridView();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgrRegistros).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 447);
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
            label4.Location = new Point(106, 22);
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
            lblValorTotalFiltrado.Location = new Point(180, 398);
            lblValorTotalFiltrado.Name = "lblValorTotalFiltrado";
            lblValorTotalFiltrado.Size = new Size(114, 32);
            lblValorTotalFiltrado.TabIndex = 23;
            lblValorTotalFiltrado.Text = "R$ 00,00";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(106, 398);
            label1.Name = "label1";
            label1.Size = new Size(81, 32);
            label1.TabIndex = 24;
            label1.Text = "Valor:";
            // 
            // dgrRegistros
            // 
            dgrRegistros.AllowUserToAddRows = false;
            dgrRegistros.AllowUserToDeleteRows = false;
            dgrRegistros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrRegistros.FilterAndSortEnabled = true;
            dgrRegistros.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            dgrRegistros.Location = new Point(106, 75);
            dgrRegistros.MaxFilterButtonImageHeight = 23;
            dgrRegistros.Name = "dgrRegistros";
            dgrRegistros.ReadOnly = true;
            dgrRegistros.RightToLeft = RightToLeft.No;
            dgrRegistros.Size = new Size(857, 306);
            dgrRegistros.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            dgrRegistros.TabIndex = 25;
            // 
            // frmRegistros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1056, 535);
            Controls.Add(dgrRegistros);
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
        private Zuby.ADGV.AdvancedDataGridView dgrRegistros;
    }
}