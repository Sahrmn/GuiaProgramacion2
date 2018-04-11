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
    public partial class frmEquipo : Form
    {
        private Equipo _equipo;

        public frmEquipo()
        {
            InitializeComponent();
        }

        private void frmEquipo_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.ToString();
            short cantJugadores = short.Parse(txtCantJugadores.Text);

            _equipo = new Equipo(cantJugadores, nombre);
            btnAceptar.Visible = false;
            btnCancelar.Visible = false;
            txtCantJugadores.Enabled = false;
            txtNombre.Enabled = false;
            lstEquipo.Visible = true;
            btnAgregar.Visible = true;
            btnMenos.Visible = true;
            btnModificar.Visible = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //creo instancia de frmJugador
            frmJugador formularioJugador = new frmJugador();
            //muestro formulario
            formularioJugador.ShowDialog();

            if (formularioJugador.DialogResult == DialogResult.OK)
            {
                //recupero getJugador
                Jugador tomoJugador = formularioJugador.GetJugador();
                //agrego al equipo
                bool resp = this._equipo + tomoJugador;
                if (resp == false)
                {
                    MessageBox.Show("No se pudo agregar el jugador","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Jugador agregado!","Listo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                mostrarListJugadores();
            }
        }

        private void mostrarListJugadores()
        {
            lstEquipo.Items.Clear();
            List<Jugador> equipJug = _equipo.GetJugadores();
            foreach (Jugador item in equipJug)
	        {
                lstEquipo.Items.Add(item.MostrarDatos());
            }
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            int indexSeleccionado = lstEquipo.SelectedIndex;
            bool flag = false;

            if (indexSeleccionado != -1)
            {
                //frmJugador muestraJugador = new frmJugador();
                List<Jugador> jug = _equipo.GetJugadores();
                if (jug.Count > 0)
                {
                    for (int i = 0; i < jug.Count; i++)
                    {
                        if (i == indexSeleccionado)
                        {
                            MessageBox.Show(jug[i].MostrarDatos());
                            //muestraJugador.Show();
                            DialogResult resp =  MessageBox.Show("¿Esta seguro que quiere eliminar a este jugador?","Eliminar",MessageBoxButtons.YesNo,MessageBoxIcon.Question); // AGREGAR NOMBRE DE JUGADOR A LA PREGUNTA
                            if (resp == System.Windows.Forms.DialogResult.Yes)
                            {
                                flag = this._equipo - jug[i];    
                            }
                            break;
                        }
                    }
                }
            }
            if (flag == true)
            {
                MessageBox.Show("Jugador eliminado","Eliminado",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            mostrarListJugadores();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int indexSeleccionado = lstEquipo.SelectedIndex;
            List<Jugador> listaJug = _equipo.GetJugadores();
            Jugador jugModificado = null;

            if (indexSeleccionado != -1)
            {
                for (int i = 0; i < listaJug.Count; i++)
                {
                    if (i == indexSeleccionado)
                    {
                        jugModificado = listaJug[i];
                        frmJugador frmModifJugador = new frmJugador(jugModificado);
                        frmModifJugador.ShowDialog();

                        if (frmModifJugador.DialogResult == DialogResult.OK)
                        {
                            DialogResult resp = MessageBox.Show("¿Esta seguro que quiere modificar a este jugador?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question); // AGREGAR NOMBRE DE JUGADOR A LA PREGUNTA
                            if (resp == System.Windows.Forms.DialogResult.Yes)
                            {
                                bool val = this._equipo - jugModificado;

                                jugModificado = frmModifJugador.GetJugador();//recupero getJugador

                                val = this._equipo + jugModificado; //agrego jugador con modificacion
                                if (val == false)
                                {
                                    MessageBox.Show("No se pudo modificar el jugador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    MessageBox.Show("Jugador modificado!", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }

                        break;
                    }
                }

                mostrarListJugadores();
            }
        }
    }
}
