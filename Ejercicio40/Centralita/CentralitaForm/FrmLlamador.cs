using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaHerencia;

namespace CentralitaForm
{
    public partial class FrmLlamador : Form
    {
        private Centralita _central;

        public FrmLlamador(Centralita centralita)
        {
            InitializeComponent();
            this._central = centralita;
        }

        public Centralita MiCentralita
        {
            get { return this._central; }
        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {
            string num = txtNroDestino.Text;
            char[] primerLetra = num.ToCharArray();
            Random rand = new Random();
            float duracion = rand.Next(1, 50);
            if (primerLetra[0] =='#')
            {
                //es provincial 
                Franja franja;
                Enum.TryParse<Franja>(comboFranja.SelectedValue.ToString(), out franja); //convierte el texto del combo en franja
                Provincial nuevaLlamadaProv = new Provincial(txtNroOrigen.Text, franja, duracion, txtNroDestino.Text);
                this._central += nuevaLlamadaProv;
            }
            else
            {
                comboFranja.Enabled = false;
                //es local
                float costo = (float)(rand.NextDouble() * (5.6 - 0.5) + 0.5);
                Local nuevaLlamadaLocal = new Local(txtNroOrigen.Text, duracion, txtNroDestino.Text, costo);
                this._central += nuevaLlamadaLocal;
            }
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += 1;
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += 2;
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += 9;
        }

        private void btnAsterisco_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "*";
        }

        private void btnCero_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += 0;
        }

        private void btnNumeral_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "#";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmLlamador_Load(object sender, EventArgs e)
        {
            comboFranja.DataSource = Enum.GetValues(typeof(Franja));
        }
    }
}
