using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using System.IO;

namespace FormEntidades
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            foreach (Jugador.EPuesto item in Enum.GetValues(typeof(Jugador.EPuesto)))//recorrer enumerado
            {
                this.comboPuesto.Items.Add(item);
            }
            this.comboPuesto.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboPuesto.SelectedItem = Jugador.EPuesto.Medio;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            Jugador.EPuesto puesto = (Jugador.EPuesto)comboPuesto.SelectedItem;
            Jugador unJugador = new Jugador(nombre, apellido, puesto);
            //MessageBox.Show(unJugador.ToString());

            //StreamWriter archivo = new StreamWriter("C:\\Users\\alumno\\Desktop\\Jugadores.txt", true);
            /* el \\ para que tome el \ solo
            * el @ antes del string es para no tener que poner 
            * el \\ cada vez */
            //archivo.WriteLine(unJugador.ToString());
            //archivo.Close();
            
            //StreamReader leerArchivo = new StreamReader("C:\\Users\\alumno\\Desktop\\Jugadores.txt");
            //string linea = leerArchivo.ReadLine();
            //while (linea != null)
            //{
            //    MessageBox.Show(linea);
            //    linea = leerArchivo.ReadLine();
            //}
            //leerArchivo.Close();
            //string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Jugadores.txt";
            string path = "";
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path = saveFileDialog1.FileNames[0];
            }
            AdministradorDeArchivos.Escribir(path, unJugador.ToString(), true);
            string linea;
            AdministradorDeArchivos.Leer(path, out linea);
            MessageBox.Show(linea);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nom = txtNombre.Text;
            string ap = txtApellido.Text;
            Jugador.EPuesto p = (Jugador.EPuesto)comboPuesto.SelectedItem;

            Jugador jugadorBuscado = new Jugador(nom, ap, p);
            string path = "";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path = openFileDialog1.FileNames[0];
            }
            Jugador jugadorEncontrado;
            if (Jugador.TraerUno(path, jugadorBuscado, out jugadorEncontrado))
            {
                MessageBox.Show(jugadorEncontrado.ToString());
            }
            else
            {
                MessageBox.Show("Jugador no encontrado", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
