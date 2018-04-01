using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio13
{
    class Conversor
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
            while (Math.Pow(2, indice) < num && Math.Pow(2,indice+1) < num)
            {
                indice++;
            }
            numBinario += "1";
            sumatoria += Math.Pow(2, indice);
            for (int i = indice-1; i >= 0; i--)
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
            var cadenaIngresada = cadena.ToCharArray(0,cadena.Length);
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
}
