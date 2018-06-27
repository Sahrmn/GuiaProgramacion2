using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades
{
    public static class Extension
    {
        /// <summary>
        /// Escribe en un archivo de texto el dia, hora e informacion del error.
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public static bool LogErrores(this Exception e)
        {
            bool retValue = true;
            try
            {
                StreamWriter escribe = new StreamWriter("logErrores.txt", true);
                string contenido = e.ToString();
                escribe.WriteLine("");
                escribe.WriteLine(DateTime.Now.ToString());
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
