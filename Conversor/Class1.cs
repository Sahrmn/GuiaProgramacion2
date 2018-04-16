using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor
{
    public class Conversor
    {
        /// <summary>
        /// Convierte un número de decimal a binario
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static string DecimalBinario(double num)
        {
            string numBinario = "";
            int indice = 0;
            double sumatoria = 0;
            while (Math.Pow(2, indice) < num && Math.Pow(2, indice + 1) < num)
            {
                indice++;
            }
            numBinario += "1";
            sumatoria += Math.Pow(2, indice);
            for (int i = indice - 1; i >= 0; i--)
            {
                if ((sumatoria + Math.Pow(2, i)) <= num)
                {
                    numBinario += "1";
                    sumatoria += Math.Pow(2, i);
                }
                else
                    numBinario += "0";
            }
            return numBinario;
        }

        /// <summary>
        ///  Convierte un número binario a decimal.
        /// </summary>
        /// <param name="cadena"></param>
        /// <returns></returns>
        public static double BinarioDecimal(string cadena)
        {
            double numDecimal = 0;
            var cadenaIngresada = cadena.ToCharArray(0, cadena.Length);
            int indice = cadena.Length - 1;
            for (int i = 0; i < cadena.Length; i++)
            {
                if (cadenaIngresada[i] == '1')
                {
                    numDecimal += Math.Pow(2, indice);
                }
                indice--;
            }
            return numDecimal;
        }
    }

    public class NumeroBinario
    {
        private string _atrib;

        public NumeroBinario(string a)
        {
            this._atrib = a;
        }

        public string GetAtrib()
        {
            return this._atrib;
        }

        public static string operator +(NumeroBinario b, NumeroDecimal d)
        {
            double dec = d + b;
            string retValue = Conversor.DecimalBinario(dec);
            return retValue;
        }

        public static string operator -(NumeroBinario b, NumeroDecimal d)
        {
            double dec = d - b;
            string retValue = Conversor.DecimalBinario(dec);
            return retValue;
        }

        public static bool operator ==(NumeroBinario b, NumeroDecimal d)
        {
            return (d == b);
        }

        public static bool operator !=(NumeroBinario b, NumeroDecimal d)
        {
            return !(b == d);
        }

        public static implicit operator NumeroBinario(string s)
        {
            NumeroBinario retValue = new NumeroBinario(s);
            return retValue;
        }

        public static explicit operator string(NumeroBinario b)
        {
            return b._atrib;
        }
    }

    public class NumeroDecimal
    {
        private double _num;

        public NumeroDecimal(double a)
        {
            this._num = a;
        }

        public double GetNum()
        {
            return this._num;
        }

        public static double operator +(NumeroDecimal d, NumeroBinario b)
        {
            double retValue = Conversor.BinarioDecimal(b.GetAtrib());
            retValue = d._num + retValue;
            return retValue;
        }

        public static double operator -(NumeroDecimal d, NumeroBinario b)
        {
            double retValue = Conversor.BinarioDecimal(b.GetAtrib());
            retValue = d._num - retValue;
            return retValue;
        }

        public static bool operator ==(NumeroDecimal d, NumeroBinario b)
        {
            bool retValue = false;
            double dec = Conversor.BinarioDecimal(b.GetAtrib());
            if (dec == d._num)
            {
                retValue = true;
            }
            return retValue;
        }

        public static bool operator !=(NumeroDecimal d, NumeroBinario b)
        {
            return !(d == b);
        }

        public static implicit operator NumeroDecimal(double d)
        {
            NumeroDecimal retValue = new NumeroDecimal(d);
            return retValue;
        }

        public static explicit operator double(NumeroDecimal d)
        {
            return d._num;
        }
    }
}
