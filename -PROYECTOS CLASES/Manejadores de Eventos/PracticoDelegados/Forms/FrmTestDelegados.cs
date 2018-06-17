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
    public partial class FrmTestDelegados : Form
    {
        private string _imageLocation;

        public FrmTestDelegados()
        {
            InitializeComponent();
            ConfigurarOpenSaveFileDialog();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ((FormPrincipal)this.Owner).delegado.Invoke(txtIngreso.Text);//4to invoco delegado
            ((FormPrincipal)this.Owner).delegadoParaFoto.Invoke(this._imageLocation);
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

        private void btnBuscarFoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            this._imageLocation = openFileDialog1.FileName;
        }
    }
}
