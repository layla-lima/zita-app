namespace Zita
{
    partial class frmCaixa
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
            btnAbrirCaixa = new Button();
            SuspendLayout();
            // 
            // btnAbrirCaixa
            // 
            btnAbrirCaixa.BackColor = SystemColors.ActiveCaptionText;
            btnAbrirCaixa.Cursor = Cursors.Hand;
            btnAbrirCaixa.FlatStyle = FlatStyle.Popup;
            btnAbrirCaixa.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAbrirCaixa.ForeColor = SystemColors.ButtonFace;
            btnAbrirCaixa.Location = new Point(402, 253);
            btnAbrirCaixa.Name = "btnAbrirCaixa";
            btnAbrirCaixa.Size = new Size(271, 90);
            btnAbrirCaixa.TabIndex = 21;
            btnAbrirCaixa.Text = "Abrir Caixa";
            btnAbrirCaixa.UseVisualStyleBackColor = false;
            btnAbrirCaixa.Click += btnAbrirCaixa_Click;
            // 
            // frmCaixa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1056, 636);
            Controls.Add(btnAbrirCaixa);
            Name = "frmCaixa";
            Text = "frmCaixa";
            ResumeLayout(false);
        }

        #endregion
        private Button btnAbrirCaixa;
    }
}