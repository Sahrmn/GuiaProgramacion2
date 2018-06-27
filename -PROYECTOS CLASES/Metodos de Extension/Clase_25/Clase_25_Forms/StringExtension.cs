using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension
{
    public static class StringExtension
    {
        /// <summary>
        /// Cuenta la cantidad de palabras en la cadena
        /// </summary>
        /// <param name="texto">Cadena para analizar</param>
        /// <returns></returns>
        public static int CuentaPalabras(this String texto)
        {
            int cantidadPalabras = 0;

            // Divido la cadena a través de los espacios vacios ' ' y la recorro
            foreach (string s in texto.Split(' '))
            {
                // Si la palabra no es null o vacia, incremento mi acumulador
                if (!string.IsNullOrEmpty(s))
                {
                    cantidadPalabras += 1;
                }
            }

            return cantidadPalabras;
        }
        /// <summary>
        /// Cuenta la cantidad de palabras que finalice con la subcadena "la"
        /// </summary>
        /// <param name="texto">Cadena para analizar</param>
        /// <returns></returns>
        public static int CuentaPalabrasLA(this String texto)
        {
            int cantidadFinalizaLA = 0;

            foreach (string s in texto.Split(' '))
            {
                // Si la palabra no es null o vacia, incremento mi acumulador
                if (!string.IsNullOrEmpty(s))
                {
                    // Si finaliza en "la" incremento mi acumulador
                    if (s.Length >= 2)
                        if (s.ToLower().LastIndexOf("la") == s.Length - 2)
                            cantidadFinalizaLA += 1;
                }
            }

            return cantidadFinalizaLA;
        }
        /// <summary>
        /// Primeras 20 palabras de la cadena
        /// </summary>
        /// <param name="texto">Cadena para analizar</param>
        /// <returns></returns>
        public static string Primeras20Palabras(this String texto)
        {
            string resultado = "";

            int acum = 0;
            // Quito los espacios en blanco a izquierda y derecha
            texto = texto.Trim();
            // Divido la cadena a través de los espacios vacios ' ' y la recorro
            foreach (string s in texto.Split(' '))
            {
                // Si la palabra no es null o vacia, la muestro
                if (!string.IsNullOrEmpty(s))
                {
                    resultado += "* " + s;
                    // Cuanto haya llegado a las 20 palabras, rompo el FOR
                    acum++;
                    if (acum >= 20)
                        break;
                }
            }

            return resultado;
        }
        /// <summary>
        /// Primeras 100 letras de la cadena
        /// </summary>
        /// <param name="texto">Cadena para analizar</param>
        /// <returns></returns>
        public static string Primeras100Letras(this String texto)
        {
            // Calculo el valor máximo para substring
            //         = CONDICION ? true : false;
            int valMax = texto.Length >= 100 ? 100 : texto.Length;

            return texto.Substring(0, valMax);
        }

        public static string buscarPalabraFinalizadaEn(this String texto, string contenidoFinal, short cantidadAEncontrar)
        {
            string acumPalabras = "";
            int acum = 0;
            int indice = -1;
            int inicioCadena;
            // Quito los espacios en blanco a izquierda y derecha
            texto = texto.Trim();
            // 
            do
            {
                // Busco una palabra finalizada según el parámetro contenidoFinal,
                // tomando como indice de inicio al último obtenido
                indice = texto.IndexOf(contenidoFinal, indice + 1);
                if (indice == -1)
                    break;
                // ¡Encontré una nueva palabra!
                acum++;

                // Calculo donde inicia la palabra. Si inicioCadena es -1,
                // quiere decir que estoy en la primer palabra del texto,
                // por ende el indice de inicio será 0.
                inicioCadena = texto.LastIndexOf(" ", indice);
                if (inicioCadena == -1)
                    inicioCadena = 0;
                // Recorto la palabra y la acumulo
                acumPalabras += "* " + texto.Substring(inicioCadena, (indice - inicioCadena) + 1);
            } while (acum < cantidadAEncontrar);

            return acumPalabras;
        }
    }
}
