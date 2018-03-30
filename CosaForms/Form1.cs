using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClaseCosa;

namespace CosaForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int numero = int.Parse(this.number.Text);
            string cadena = this.cadena.Text;
            DateTime fecha = DateTime.Parse(this.fecha.Text);
            Cosa cosita = new Cosa(numero, cadena);
            string cadenaCompleta = "Numero " + numero + "\nCadena:" + cadena + "\nfecha " + fecha;
            MessageBox.Show(cadenaCompleta, "Titulo Cosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
