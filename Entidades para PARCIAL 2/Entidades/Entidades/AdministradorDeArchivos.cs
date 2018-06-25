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
        /// Escribe un archivo. Devuelve true si pudo realizar correctamente la tarea
        /// </summary>
        /// <param name="path">Direccion del archivo mas nombre de archivo</param>
        /// <param name="contenido"></param>
        /// <param name="sobreescribir">false para sobreescribir, true para agregar al final</param>
        /// <returns></returns>
        public static bool Escribir(string path, string contenido, bool sobreescribir)
        {
            bool retValue = true;
            try
            {
                StreamWriter escribe = new StreamWriter(path, sobreescribir);
                //escribe.Write(contenido); escribe una cadena sin provocar salto de linea
                escribe.WriteLine(contenido);
                escribe.Close();
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
                //contenido = leyendo.ReadLine();  lee una linea
                //contenido = leyendo.Read(); lee una letra
                contenido = leyendo.ReadToEnd();
                leyendo.Close();
            }
            catch
            {
                retValue = false;
            }
            return retValue;
        }

        public static bool LogErrores(Exception e)
        {
            bool retValue = true;
            try
            {
                StreamWriter escribe = new StreamWriter("logErrores.txt",false);//averiguar cual es la forma de poner el directorio del proyecto
                string contenido = e.ToString();
                escribe.WriteLine(contenido);
                escribe.Close();
            }
            catch
            {
                retValue = false;
            }
            return retValue;
        }

    }
}
