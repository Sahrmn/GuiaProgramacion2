using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ColectoraDeNumeros
    {
        protected List<Numero> _numeros;

        public ETipoNumero Tipo { get; set; }

        private ColectoraDeNumeros()
        {
            this._numeros = new List<Numero>();
        }

        public ColectoraDeNumeros(ETipoNumero tipo)
        {
            this.Tipo = tipo;
        }

        public static bool operator ==(ColectoraDeNumeros col, Numero num)
        {
            bool retValue = false;
            if (num != null)
            {
                foreach (Numero item in col._numeros)
                {
                    if (item == num)
                    {
                        retValue = true;
                        break;
                    }
                }
            }
            return retValue;
        }

        public static bool operator !=(ColectoraDeNumeros col, Numero num)
        { 
            return !(col == num);
        }

        public static ColectoraDeNumeros operator +(ColectoraDeNumeros col, Numero num)
        {
            if (num != null)
            {
                if (col != num)
                {
                    bool verif = Verificadora.VerificarNumero(col.Tipo, num);
                    if (verif == false)
                    {
                        throw new Exception("El tipo de numero es distinto al de la colectora");
                    }
                    else
                        col._numeros.Add(num);
                }
            }
            return col;
        }

        public static ColectoraDeNumeros operator -(ColectoraDeNumeros col, Numero num)
        {
            if (col == num)
            {
                col._numeros.Remove(num);
            }
            else
            {
                string mensaje = "El numero no se encuentra en la colectora." + col.ToString();
                throw new Exception(mensaje);
            }
            return col;
        }

        public override string ToString()
        {
            string retValue = "Tipo: " + this.Tipo + "\n";
            foreach (Numero item in this._numeros)
            {
                retValue += item.Numeros;
                retValue += "\n";
            }

            return retValue;
        }
    }
}
