using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajeroAutomatico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnAceptar.Click += new EventHandler(Calcular);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            btnAceptar.Click -= new EventHandler(Calcular);
            btnLimpiar.Click += new EventHandler(Limpiar);
            btnAceptar.Click += new EventHandler(Informar);
        }

        public void Calcular(object sender, EventArgs e)
        {
            int cantidad = int.Parse(txtCantARetirar.Text);
            int calculo100 = (int)cantidad / 100;
            if (calculo100 >= 1)
            {
                txt100.Text = calculo100.ToString();
            }
            else
            {
                txt100.Text = "0";
            }

            int queda = (int)cantidad - (calculo100 * 100);
            int calculo50 = queda / 50;
            if (calculo50 >= 1)
            {
                txt50.Text = calculo50.ToString();
            }
            else
            {
                txt50.Text = "0";
            }

            queda = queda - (calculo50 * 50);
            int calculo20 = queda / 20;
            if (calculo20 >= 1)
            {
                txt20.Text = calculo20.ToString();
            }
            else
            {
                txt20.Text = "0";
            }

            queda = queda - (calculo20 * 20);
            int calculo10 = queda / 10;
            if (calculo10 >= 1)
            {
                txt10.Text = calculo10.ToString();
            }
            else
            {
                txt10.Text = "0";
            }

            queda = queda - (calculo10 * 10);
            int calculo5 = queda / 5;
            if (calculo5 >= 1)
            {
                txt5.Text = calculo5.ToString();
            }
            else
            {
                txt5.Text = "0";
            }

            queda = queda - (calculo5 * 5);
            int calculo2 = queda / 2;
            if (calculo2 >= 1)
            {
                txt2.Text = calculo2.ToString();
            }
            else
            {
                txt2.Text = "0";
            }
            queda = queda - (calculo2 * 2);
            if (queda == 1)
            {
                MessageBox.Show("Le queda $1 Pesos", "Vuelto", MessageBoxButtons.OK);
            }
        }

        public void Limpiar(object sender, EventArgs e)
        {
            txtCantARetirar.Text = "0";
            txt100.Text = "0";
            txt50.Text = "0";
            txt20.Text = "0";
            txt10.Text = "0";
            txt5.Text = "0";
            txt2.Text = "0";
        }

        public void Informar(object sender, EventArgs e)
        {
            MessageBox.Show("Debe limpiar la pantalla para seguir operando", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void btnLimpiar_Click(object sender, EventArgs e)
        {
            btnLimpiar.Click -= new EventHandler(Limpiar);
            btnAceptar.Click -= new EventHandler(Informar);
            btnAceptar.Click -= new EventHandler(Informar);
            btnAceptar.Click += new EventHandler(Calcular);
        }
    }
}
