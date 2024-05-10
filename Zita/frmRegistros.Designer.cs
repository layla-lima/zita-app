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
            dgrRegistros = new DataGridView();
            label4 = new Label();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgrRegistros).BeginInit();
            SuspendLayout();
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
            dgrRegistros.Location = new Point(110, 102);
            dgrRegistros.Name = "dgrRegistros";
            dgrRegistros.ReadOnly = true;
            dgrRegistros.Size = new Size(861, 363);
            dgrRegistros.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Banner", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(156, 60);
            label4.Name = "label4";
            label4.Size = new Size(302, 39);
            label4.TabIndex = 22;
            label4.Text = "Gerenciamento de Vendas";
            // 
            // frmRegistros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1056, 627);
            Controls.Add(label4);
            Controls.Add(dgrRegistros);
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
        private DataGridView dgrRegistros;
        private Label label4;
    }
}