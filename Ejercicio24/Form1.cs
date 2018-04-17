using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Temperatura;

namespace Ejercicio24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double temp = double.Parse(txtFaOriginal.Text);
            Fahrenheit fa = new Fahrenheit(temp);

            txtfa1.Text = fa.GetCantidad().ToString();
            Celcius ce = (Celcius)fa;
            txtce1.Text = ce.GetCantidad().ToString();
            Kelvin ke = (Kelvin)fa;
            txtKe1.Text = ke.GetCantidad().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double temp = double.Parse(txtCeOriginal.Text);
            Celcius ce = new Celcius(temp);

            Fahrenheit fa = (Fahrenheit)ce;
            txtfa2.Text = fa.GetCantidad().ToString();
            txtce2.Text = ce.GetCantidad().ToString();
            Kelvin ke = (Kelvin)ce;
            txtKe2.Text = ke.GetCantidad().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double temp = double.Parse(txtKeOriginal.Text);
            Kelvin ke = new Kelvin(temp);

            txtKe3.Text = ke.GetCantidad().ToString();
            Fahrenheit fa = (Fahrenheit)ke;
            txtfa3.Text = fa.GetCantidad().ToString();
            Celcius ce = (Celcius)ke;
            txtce3.Text = ce.GetCantidad().ToString();
        }
    }
}
