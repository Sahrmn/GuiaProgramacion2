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

namespace ABM_DB
{
    public partial class FormAgregar : Form
    {
        public Persona unaPersona;

        public FormAgregar()
        {
            InitializeComponent();
        }

        public FormAgregar(int id)
        {
            InitializeComponent();
            string consulta = "SELECT * FROM Personas WHERE id = " + id;
            unaPersona = DB.MostrarBD(Properties.Settings.Default.Conexion, id, consulta);
            txtApellido.Text = unaPersona.Apellido;
            txtNombre.Text = unaPersona.Nombre;
            txtEdad.Text = unaPersona.Edad.ToString();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string ap = txtApellido.Text;
            string nom = txtNombre.Text;
            int edad = int.Parse(txtEdad.Text);

            Persona per = new Persona(nom, ap, edad);
            this.unaPersona = per;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
