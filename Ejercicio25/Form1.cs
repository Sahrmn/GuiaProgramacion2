using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Conversor;

namespace Ejercicio25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConverBin_Click(object sender, EventArgs e)
        {
            string bin = txtBin1.Text;
            double dec = Conversor.Conversor.BinarioDecimal(bin);
            txtBin2.Text = dec.ToString();
        }

        private void btnConverDec_Click(object sender, EventArgs e)
        {
            double dec = double.Parse(txtDec1.Text);
            string bin = Conversor.Conversor.DecimalBinario(dec);
            txtDec2.Text = bin;
        }
    }
}
