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
            label6 = new Label();
            panel3 = new Panel();
            label2 = new Label();
            dgrRegistros = new DataGridView();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgrRegistros).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(390, 52);
            label6.Name = "label6";
            label6.Size = new Size(266, 40);
            label6.TabIndex = 6;
            label6.Text = "Vendas Realizadas";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 539);
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
            // dgrRegistros
            // 
            dgrRegistros.AllowUserToAddRows = false;
            dgrRegistros.AllowUserToDeleteRows = false;
            dgrRegistros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrRegistros.Location = new Point(110, 151);
            dgrRegistros.Name = "dgrRegistros";
            dgrRegistros.ReadOnly = true;
            dgrRegistros.Size = new Size(861, 314);
            dgrRegistros.TabIndex = 8;
            // 
            // frmRegistros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1056, 627);
            Controls.Add(dgrRegistros);
            Controls.Add(panel3);
            Controls.Add(label6);
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
        private Label label6;
        private Panel panel3;
        private Label label2;
        private DataGridView dgrRegistros;
    }
}