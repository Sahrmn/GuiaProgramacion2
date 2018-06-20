using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        private char _operacion;
        private int _num1;
        private int _num2;

        public Form1()
        {
            InitializeComponent();
            this._num1 = -1;
        }

        public void ManejadorCentral(object sender, EventArgs e)
        {
            if (this._num1 == -1)
            {
                btnMultiplicar.Click += new EventHandler(ManejadorCentral);
                btnSumar.Click += new EventHandler(ManejadorCentral);
                btnRestar.Click += new EventHandler(ManejadorCentral);
                btnDividir.Click += new EventHandler(ManejadorCentral);
                this._num1 = 0;
            }
            else
            {
                try
                {
                    Button elBoton = (Button)sender;
                    int flag = 0;
                    foreach (Control item in groupBoxNumeros.Controls)
                    {
                        if ((Button)item == elBoton)
                        {
                            flag = 1;
                            break;
                        }
                    }
                    foreach (Control item in groupBoxOperaciones.Controls)
                    {
                        if ((Button)item == elBoton)
                        {
                            flag = -1;
                            break;
                        }
                    }
                    if (flag == -1)
                    {

                        if (elBoton == btnSumar)
                        {
                            this._operacion = '+';
                        }
                        else if (elBoton == btnRestar)
                        {
                            this._operacion = '-';
                        }
                        else if (elBoton == btnMultiplicar)
                        {
                            this._operacion = '*';
                        }
                        else if (elBoton == btnDividir)
                        {
                            this._operacion = '/';
                        }
                        this._num1 = int.Parse(txtNumero.Text);//recordar quitar manejadores de los otros botones antes de reiniciar un calculo
                        txtNumero.Text = "";
                        txtNumero.Focus();
                    }
                    else if (flag == 1)
                    {
                        btnCalcular.Click += new EventHandler(ManejadorCentral);
                    }
                    else
                    {
                        txtNumero.Text = Calculadora.Calcular(this._num1, this._num2, this._operacion).ToString();
                        this._num1 = -1;
                    }
                }
                catch
                {
                    MessageBox.Show("Debe limpiar la pantalla antes de proseguir", "Ocurrio un problema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn0.Click += new EventHandler(ManejadorCentral);
            btn1.Click += new EventHandler(ManejadorCentral);
            btn2.Click += new EventHandler(ManejadorCentral);
            btn3.Click += new EventHandler(ManejadorCentral);
            btn4.Click += new EventHandler(ManejadorCentral);
            btn5.Click += new EventHandler(ManejadorCentral);
            btn6.Click += new EventHandler(ManejadorCentral);
            btn7.Click += new EventHandler(ManejadorCentral);
            btn8.Click += new EventHandler(ManejadorCentral);
            btn9.Click += new EventHandler(ManejadorCentral);
            
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            btnMultiplicar.Click -= new EventHandler(ManejadorCentral);
            btnSumar.Click -= new EventHandler(ManejadorCentral);
            btnRestar.Click -= new EventHandler(ManejadorCentral);
            btnDividir.Click -= new EventHandler(ManejadorCentral);
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            btnMultiplicar.Click -= new EventHandler(ManejadorCentral);
            btnSumar.Click -= new EventHandler(ManejadorCentral);
            btnRestar.Click -= new EventHandler(ManejadorCentral);
            btnDividir.Click -= new EventHandler(ManejadorCentral);
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            btnMultiplicar.Click -= new EventHandler(ManejadorCentral);
            btnSumar.Click -= new EventHandler(ManejadorCentral);
            btnRestar.Click -= new EventHandler(ManejadorCentral);
            btnDividir.Click -= new EventHandler(ManejadorCentral);
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            btnMultiplicar.Click -= new EventHandler(ManejadorCentral);
            btnSumar.Click -= new EventHandler(ManejadorCentral);
            btnRestar.Click -= new EventHandler(ManejadorCentral);
            btnDividir.Click -= new EventHandler(ManejadorCentral);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            btnCalcular.Click -= new EventHandler(ManejadorCentral);
            btnCalcular.Click -= new EventHandler(ManejadorCentral);
            btnCalcular.Click -= new EventHandler(ManejadorCentral);
            try
            {
                this._num2 = int.Parse(txtNumero.Text);
            }
            catch
            {
                this._num2 = 0;
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtNumero.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtNumero.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtNumero.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtNumero.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtNumero.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtNumero.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtNumero.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtNumero.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtNumero.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtNumero.Text != "")
            {
                txtNumero.Text += "0";
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero.Text = "";
            this._num1 = -1;
            btnCalcular.Click -= new EventHandler(ManejadorCentral);
        }
    }
}
