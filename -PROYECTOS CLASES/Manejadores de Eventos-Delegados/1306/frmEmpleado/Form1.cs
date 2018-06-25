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

namespace frmEmpleado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nom = txtNombre.Text;
            string ap = txtApellido.Text;
            int dni = int.Parse(txtdni.Text);
            int sueldo = int.Parse(txtSueldo.Text);

            Empleado em1 = new Empleado(nom, ap, dni);
            em1.SueldoCero += new DelegadoSueldoCero(ManejadorEvento);
            //em1.LimiteDeSueldo += new DelegadoLimiteSueldo(LimiteSueldo);
            EmpleadoEventArgs ev = new EmpleadoEventArgs();
            ev.SueldoMaximoMejorado += new DelegadoLimiteSueldoMejorado(SueldoMejorado);
            
            em1.Sueldo = sueldo;
        }

        

        public void ManejadorEvento()
        {
            MessageBox.Show("El sueldo ingresado es cero!", "Sueldo incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //Console.WriteLine("El sueldo es cero!!!");

        }

        public void LimiteSueldo(double limite, Empleado em)
        {
            //if (em._sueldo > limite)
            //{
            //Console.WriteLine("El sueldo sobrepasa el limite dado!");
            MessageBox.Show("El sueldo ingresado sobrepasa el limite dado!", "Sueldo incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public void SueldoMejorado(Empleado em, EmpleadoEventArgs evento)
        {
            if (em.Sueldo > 20000 && em.Sueldo < 300000)
            {
                //EmpleadoEventArgs e = new EmpleadoEventArgs();
                MessageBox.Show("El sueldo ingresado esta entre 20k y 30k", "Sueldo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
