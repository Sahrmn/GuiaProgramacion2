using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class FrmDatos : Form
    {
        public FrmDatos()
        {
            InitializeComponent();
        }

        public void ActualizarNombre(string n)
        {
            lblTexto.Text = n;
        }

        public void ActualizarFoto(string n)
        {
            pictureBoxImagen.ImageLocation = n;
        }
    }
}
