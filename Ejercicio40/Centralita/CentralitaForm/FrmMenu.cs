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
    public partial class FrmMenu : Form
    {
        public Centralita central;

        public FrmMenu()
        {
            InitializeComponent();
            central = new Centralita();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGenerarLlamada_Click(object sender, EventArgs e)
        {
            FrmLlamador nuevaLlamada = new FrmLlamador(this.central);
            nuevaLlamada.ShowDialog();
            this.central = nuevaLlamada.MiCentralita;//recupero centralita del formulario frmLlamador
        }

        private void btnFactTotal_Click(object sender, EventArgs e)
        {
            FrmMostrar mostrar = new FrmMostrar(this.central, TipoLlamada.Todas);
            //mostrar.TipoLlamada = TipoLlamada.Todas;
            mostrar.ShowDialog();
        }

        private void btnFactLocal_Click(object sender, EventArgs e)
        {
            FrmMostrar mostrar = new FrmMostrar(this.central, TipoLlamada.Local);
            //mostrar.TipoLlamada = TipoLlamada.Local;
            mostrar.ShowDialog();
        }

        private void btnFactProv_Click(object sender, EventArgs e)
        {
            FrmMostrar mostrar = new FrmMostrar(this.central, TipoLlamada.Provincial);
            //mostrar.TipoLlamada = TipoLlamada.Provincial;
            mostrar.ShowDialog();
        }
    }
}
