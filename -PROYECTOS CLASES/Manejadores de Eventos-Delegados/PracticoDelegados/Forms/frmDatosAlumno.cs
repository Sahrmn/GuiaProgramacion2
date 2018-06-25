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

namespace Forms
{
    public partial class frmDatosAlumno : frmAltaAlumno
    {
        public frmDatosAlumno()
        {
            InitializeComponent();
            //((FormPrincipal)this.Owner).delegadoAlumno.Invoke()
        }

        public void ActualizarAlumno(Alumno sender, EventArgs e)
        {
            txtApellido.Text = sender.Apellido;
            txtNombre.Text = sender.Nombre;
            txtDni.Text = sender.Dni.ToString();
            txtFoto.Text = sender.FotoAlumno;
            pictureBox1.ImageLocation = sender.FotoAlumno;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
