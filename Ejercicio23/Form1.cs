using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Moneda;

namespace Ejercicio23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConverEuro_Click(object sender, EventArgs e)
        {
            double cant = double.Parse(txtEuroOriginal.Text);
            Euro unEuro = new Euro(cant);

            txtEuro1.Text = unEuro.GetCantidad().ToString();
            Dolar elDolar = (Dolar)unEuro;
            txtDolar1.Text = elDolar.GetCantidad().ToString();
            Pesos elPeso = (Pesos)unEuro;
            txtPesos1.Text = elPeso.GetCantidad().ToString();
        }

        private void btnConverDolar_Click(object sender, EventArgs e)
        {
            double cant = double.Parse(txtDolarOriginal.Text);
            Dolar unDolar = new Dolar(cant);

            txtDolar2.Text = unDolar.GetCantidad().ToString();
            Euro unEuro = (Euro)unDolar;
            txtEuro2.Text = unEuro.GetCantidad().ToString();
            Pesos elPeso = (Pesos)unDolar;
            txtPesos2.Text = elPeso.GetCantidad().ToString();
        }

        private void btnConverPesos_Click(object sender, EventArgs e)
        {
            double cant = double.Parse(txtPesosOriginal.Text);
            Pesos unPeso = new Pesos(cant);

            txtPesos3.Text = unPeso.GetCantidad().ToString();
            Euro unEuro = (Euro)unPeso;
            txtEuro3.Text = unEuro.GetCantidad().ToString();
            Dolar unDolar = (Dolar)unPeso;
            txtDolar3.Text = unDolar.GetCantidad().ToString();
        }
    }
}
