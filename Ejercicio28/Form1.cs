using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio28
{
    public partial class Form1 : Form
    {
        Dictionary<string, int> diccionario;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            diccionario = new Dictionary<string, int>();
            string palabras = txtPalabras.Text;
            string[] palabrasSeparadas = palabras.Split(' ');
            int count = 0;
            
            foreach (string item in palabrasSeparadas)
            {
                if (diccionario.ContainsKey(item) != true)
                {
                    count = 1;
                    diccionario.Add(item, count);
                }
                else
                {
                    if (diccionario.TryGetValue(item, out int key)) //busca la key de la palabra, si existe devuelve el valor entero que lo acompaña
                    {
                        diccionario[item] = key + 1;
                    }
                    else
                        MessageBox.Show("Hubo un error");
                }
            }

            //SortedDictionary<string, int> ordenado = new SortedDictionary<string, int>(diccionario);

            var ordenado = from elemento in diccionario orderby elemento.Value descending select elemento;

            string mostrar = "";
            int contador = 0;
            foreach (object item in ordenado)
            {
                if (contador < 3)
                {
                    mostrar += item + "\n";
                    contador++;
                }
                else
                    break;
            }

            MessageBox.Show(mostrar);

            //MessageBox.Show("Realizado!");
            

        }
    }
}
