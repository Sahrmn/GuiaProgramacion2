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
    public partial class FrmMostrar : Form
    {
        private TipoLlamada _tipoLlamada;

        public TipoLlamada TipoLlamada 
            {
            set { this._tipoLlamada = value; }
            }

        public FrmMostrar(Centralita central, TipoLlamada tipo)
        {
            InitializeComponent();
            this.TipoLlamada = tipo;
            richtxtMostrar.Text = "";
            switch (this._tipoLlamada)
            {
                case TipoLlamada.Local:
                    //foreach (Llamada item in central.Llamadas)
                    //{
                    //    if (item is Local)
                    //    {
                    //        richtxtMostrar.Text += ((Local)item).ToString();
                    //    }
                    //}
                    richtxtMostrar.Text = "Ganancia Llamadas Locales: " + central.GananciaPorLocal;
                    break;
                case TipoLlamada.Provincial:
                    //foreach (Llamada item in central.Llamadas)
                    //{
                    //    if (item is Provincial)
                    //    {
                    //        richtxtMostrar.Text = ((Provincial)item).ToString();
                    //    }
                    //}
                    richtxtMostrar.Text = "Ganancia Llamadas Provinciales: " + central.GananciaPorProvincial;
                    break;
                case TipoLlamada.Todas:
                    //foreach (Llamada item in central.Llamadas)
                    //{
                    //    if (item is Local)
                    //    {
                    //        richtxtMostrar.Text = ((Local)item).ToString();
                    //    }
                    //    else if (item is Provincial)
                    //    {
                    //        richtxtMostrar.Text = ((Provincial)item).ToString();
                    //    }
                    //}
                    richtxtMostrar.Text = central.ToString();
                    break;
                default:
                    break;
            }
        }

        private void richtxtMostrar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
