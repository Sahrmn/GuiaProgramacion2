using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades
{
    public static class AdministradorDeArchivos
    {
        /// <summary>
        /// Escribe un archivo. Devuelve true si pudo leer el archivo
        /// </summary>
        /// <param name="path"></param>
        /// <param name="contenido"></param>
        /// <param name="sobreescribir">true para sobreescribir, false para agregar al final</param>
        /// <returns></returns>
        public static bool Escribir(string path, string contenido, bool sobreescribir)
        {
            bool retValue = true;
            try
            {
                if (sobreescribir == true)
                {
                    StreamWriter escribe = new StreamWriter(path, sobreescribir);
                    escribe.WriteLine(contenido);
                    escribe.Close();
                }
                else
                {
                    StreamWriter escribe = new StreamWriter(path);
                    escribe.WriteLine(contenido);
                    escribe.Close();
                }
            }
            catch
            {
                retValue = false;
            }
            return retValue;
        }

        public static bool Leer(string path, out string contenido)
        {
            bool retValue = true;
            contenido = "";
            try
            {
                StreamReader leyendo = new StreamReader(path);
                contenido = leyendo.ReadToEnd();
                leyendo.Close();
            }
            catch
            {
                retValue = false;
            }
            return retValue;
        }

    }
}
