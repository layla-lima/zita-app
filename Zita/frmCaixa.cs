using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zita
{
    public partial class frmCaixa : Form
    {
        public frmCaixa()
        {
            InitializeComponent();
        }

        private async void btnAbrirCaixa_Click(object sender, EventArgs e)
        {
            await Task.Delay(300);
            frmCaixaAberto frmCaixaAberto = new frmCaixaAberto();
            frmCaixaAberto.Show();
            
        }
    }
}
