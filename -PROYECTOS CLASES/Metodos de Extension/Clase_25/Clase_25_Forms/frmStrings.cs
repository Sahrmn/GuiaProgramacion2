using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Extension;

namespace Clase_6_Forms
{
    public partial class frmStrings : Form
    {
        public frmStrings()
        {
            InitializeComponent();
        }

        private void rtxtTexto_TextChanged(object sender, EventArgs e)
        {
            // Quito los espacios en blanco a izquierda y derecha
            string texto = rtxtTexto.Text.Trim();

            lblCantPalabras.Text = texto.CuentaPalabras().ToString();
            lblCantFinalizaLA.Text = texto.CuentaPalabrasLA().ToString();
        }

        private void btn20Palabras_Click(object sender, EventArgs e)
        {
            // Limpio el cuadro de resultados
            txtResultado.Text = "";

            txtResultado.Text = rtxtTexto.Text.Primeras20Palabras();
        }

        private void btn100Letras_Click(object sender, EventArgs e)
        {
            // Limpio el cuadro de resultados
            txtResultado.Text = "";

            txtResultado.Text = rtxtTexto.Text.Primeras100Letras();
        }

        private void btn3PrimerasA_Click(object sender, EventArgs e)
        {
            txtResultado.Text = rtxtTexto.Text.buscarPalabraFinalizadaEn("a ", 3);
        }

        private void btn3PrimerasO_Click(object sender, EventArgs e)
        {
            txtResultado.Text = rtxtTexto.Text.buscarPalabraFinalizadaEn("o ", 3);
        }
    }
}
