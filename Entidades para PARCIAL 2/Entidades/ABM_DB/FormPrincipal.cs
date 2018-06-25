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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Cargo los datos al datagridview con getData 
            CargaDataGrid();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAgregar formularioAgrega = new FormAgregar();
            formularioAgrega.ShowDialog(this);
            if (formularioAgrega.DialogResult == DialogResult.OK)
            {
                Persona persona = formularioAgrega.unaPersona;
                string consulta = "INSERT INTO Personas (nombre, apellido, edad) VALUES(";
                consulta += "'" + persona.Nombre + "','" + persona.Apellido + "'," + persona.Edad.ToString() + ")";
                try
                {
                    DB.InsertarEnDB(Properties.Settings.Default.Conexion, consulta);
                    CargaDataGrid();
                }
                catch
                {
                    MessageBox.Show("Error al agregar.");
                }
            }
        }

        private void CargaDataGrid()
        {
            dataGridView1.DataSource = DB.GetData(Properties.Settings.Default.Conexion, "SELECT * FROM Personas");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int data = CapturoID();
            string consulta = "DELETE FROM Personas WHERE id = ";
            consulta += data.ToString();
            DialogResult dial = MessageBox.Show("¿Esta seguro de querer eliminar la celda?", "Eliminar celda", MessageBoxButtons.OKCancel);
            if (dial == DialogResult.OK)
            {
                bool re = DB.EliminarDeDB(Properties.Settings.Default.Conexion, consulta);
                if (re)
                {
                    CargaDataGrid();
                }
                else
                {
                    MessageBox.Show("Error al eliminar!");
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int id = CapturoID();//pasar al formulario los datos ya cargados
            FormAgregar FormularioModificar = new FormAgregar(id);
            FormularioModificar.ShowDialog(this);
            if (FormularioModificar.DialogResult == DialogResult.OK)
            {
                Persona persona = FormularioModificar.unaPersona;
                string consulta = "UPDATE Personas SET nombre = ";
                consulta += "'" + persona.Nombre + "', apellido = '" + persona.Apellido + "', edad = " + persona.Edad.ToString() + " WHERE id = " + id.ToString();
                try
                {
                    DB.InsertarEnDB(Properties.Settings.Default.Conexion, consulta);
                    CargaDataGrid();
                }
                catch
                {
                    MessageBox.Show("Error al modificar.");
                }
            }
        }

        private int CapturoID()
        {
            int filaSelect = dataGridView1.CurrentCell.RowIndex;//capturo la fila seleccionada
            object data = dataGridView1[0, filaSelect].Value;//a partir de la fila obtengo el valor de la columna 0(id)
            return (int)data;
        }
    }
}
