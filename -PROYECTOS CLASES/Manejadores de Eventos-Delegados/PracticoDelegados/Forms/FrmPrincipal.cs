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
    public delegate void DelegadoForm(string n);//1ero creo la firma del delegado
    public delegate void DelegadoFormAlumno(Alumno sender, EventArgs e);

    public partial class FormPrincipal : Form
    {
        protected Alumno _al;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        public DelegadoForm delegado;//2do creo el atributo delegado
        public DelegadoForm delegadoParaFoto;
        public DelegadoFormAlumno delegadoAlumno;

        private void testDelegadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTestDelegados formDelegado = new FrmTestDelegados();
            formDelegado.Show(this);
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDatos formDatos = new FrmDatos();
            formDatos.Show(this);
            delegado = new DelegadoForm(formDatos.ActualizarNombre);//3ero instancio delegado
            delegadoParaFoto = new DelegadoForm(formDatos.ActualizarFoto);
        }

        private void alumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatosAlumno formularioDatosAlumno = new frmDatosAlumno();
            //  formularioDatosAlumno.MdiParent = this;
            formularioDatosAlumno.Show(this);
            delegadoAlumno = new DelegadoFormAlumno(formularioDatosAlumno.ActualizarAlumno);
            delegadoAlumno.Invoke(formularioDatosAlumno.RetornoAlumno, EventArgs.Empty);
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaAlumno formAlta = new frmAltaAlumno();
            formAlta.Show(this);
            //((FormPrincipal)this.Owner).delegadoAlumno.Invoke()
        }
    }
}
