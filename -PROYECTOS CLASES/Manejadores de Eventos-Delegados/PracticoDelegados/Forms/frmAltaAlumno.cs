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
    public partial class frmAltaAlumno : Form
    {
        public static Alumno al;

        public Alumno RetornoAlumno
        {
            get { return al; }
        }

        public frmAltaAlumno()
        {
            InitializeComponent();
            ConfigurarOpenSaveFileDialog();
        }

        public void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                string nom = txtNombre.Text;
                string ap = txtApellido.Text;
                string ruta = txtFoto.Text;
                int dni = int.Parse(txtDni.Text);

                Alumno unAlumno = new Alumno(nom, ap, dni, ruta);
                al = unAlumno;
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message, "Error en carga", MessageBoxButtons.OK ,MessageBoxIcon.Error);
            }
            this.Close();
        }

        private void txtFoto_DoubleClick(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            txtFoto.Text = openFileDialog1.FileName;
        }

        private void ConfigurarOpenSaveFileDialog()
        {
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            openFileDialog1.DefaultExt = "jpg";
            openFileDialog1.Multiselect = false;
            openFileDialog1.Title = "Seleccione una foto...";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
