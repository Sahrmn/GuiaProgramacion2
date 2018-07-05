using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Numero
    {
        private double _numero;

        private string SetNumero
        {
            set { this._numero = ValidarNumero(value); }
        }

        public Numero() : this("0") { }

        public Numero(double num) : this(num.ToString()) { }

        public Numero(string srtNum)
        {
            this.SetNumero = srtNum;
        }

        private double ValidarNumero(string strNumero)
        {
            double retValue = 0;
            double temp = 0;
            bool tryParsear = double.TryParse(strNumero, out temp);
            if (tryParsear)
            {
                retValue = temp;
            }
            return retValue;
        }

        /// <summary>
        /// Convierte un número binario a decimal, en caso de ser posible. Caso contrario retornará "Valor inválido"
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns>
        public static string BinarioDecimal(string binario)
        {
            bool flag = true;
            int numDecimal = 0;
            string retValue = "Valor invalido";
            char[] cadenaIngresada = binario.ToCharArray();
            Array.Reverse(cadenaIngresada);

            for (int i = 0; i < cadenaIngresada.Length; i++)
            {
                if (cadenaIngresada[i] != '0' && cadenaIngresada[i] != '1')
                {
                    flag = false;
                    break;
                }
                if (cadenaIngresada[i] == '1')
                {
                    numDecimal += (int)Math.Pow(2, i);
                }
            }
            if (flag)
            {
                retValue = numDecimal.ToString();
            }
            return retValue;
        }


        /// <summary>
        ///  Convierte un número decimal a binario, en caso de ser posible. Caso contrario retornará "Valor inválido". 
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static string DecimalBinario(double num)
        {
            string numBinario = "";
            try
            {
                while(num > 0)
                {
                    if (num % 2 == 0)
                    {
                        numBinario = "0" + numBinario;
                    }
                    else
                    {
                        numBinario = "1" + numBinario;
                    }
                    num = (int)num / 2;
                }
            }
            catch
            {
                numBinario = "Valor invalido";
            }
            return numBinario;
        }

        public string DecimalBinario(string num)
        {
            double conver; 
            string retValue = "Valor invalido";
            bool verif = double.TryParse(num, out conver);
            if (verif)
            {
                retValue = DecimalBinario(conver);
            }
            return retValue;
        }

        public static double operator +(Numero n1, Numero n2)
        {
            double retValue = n1._numero + n2._numero;
            return retValue;
        }

        public static double operator -(Numero n1, Numero n2)
        {
            double retValue = n1._numero - n2._numero;
            return retValue;
        }

        public static double operator *(Numero n1, Numero n2)
        {
            double retValue = n1._numero * n2._numero;
            return retValue;
        }

        public static double operator /(Numero n1, Numero n2)
        {
            double retValue = 0;
            if (n2._numero != 0)
            {
                retValue = n1._numero / n2._numero;
            }
            return retValue;
        }
    }
}
