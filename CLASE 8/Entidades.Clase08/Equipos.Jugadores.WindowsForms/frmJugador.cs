using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.Clase08;

namespace Equipos.Jugadores.WindowsForms
{
    public partial class frmJugador : Form
    {
        private Jugador _jugador;

        public Jugador GetJugador()
        {
            return this._jugador;
        }

        public frmJugador()
        {
            InitializeComponent();
        }

        public frmJugador(Jugador jug):this()
        {
            this.txtNombre.Text = jug.Nombre;
            this.txtDNI.Text = jug.Dni.ToString();
            this.txtGoles.Text = jug.TotalGoles.ToString();
            this.txtPartidosJugados.Text = jug.PartidosJugados.ToString();
            this.txtDNI.ReadOnly = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if ((object)_jugador == null)
            {
                long dni = long.Parse(txtDNI.Text);
                string nombre = txtNombre.Text;
                int partidosJugados = int.Parse(txtPartidosJugados.Text);
                int goles = int.Parse(txtGoles.Text);

                this._jugador = new Jugador(nombre, dni, goles, partidosJugados);
                //MessageBox.Show(this._jugador.MostrarDatos(),"Jugador");
            }
            else
            {
                this._jugador.Nombre = txtNombre.Text;
                this._jugador.PartidosJugados = int.Parse(txtPartidosJugados.Text);
                this._jugador.TotalGoles = int.Parse(txtGoles.Text);
            }
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
