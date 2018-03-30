using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadSello
{
    public class Sello
    {
        public static string mensaje;
        public static ConsoleColor color;

        public static void Imprimir()
        {
            string salida = "";
            bool resp = TryParse(Sello.mensaje,out salida);
            if(resp == true)
            {
                Console.ForegroundColor = color;
                Console.Write(salida);
                Console.ReadLine();
                Console.ResetColor();
            }
            else
            {
                Console.Write("");
            }
        }

        public static void Borrar()
        {
            Console.Clear();
            //Console.ReadLine();
        }

        private static string ArmarFormatoMensaje()
        {
            int longitud = Sello.mensaje.Length;
            string msj = "";
            int i;

            for (i = 0; i < longitud+2; i++)
            {
                msj += "*";
            }
            msj += "\n";
            msj += "*";
            msj += mensaje;
            msj += "*";
            msj += "\n";
            for (i = 0; i < longitud + 2; i++)
            {
                msj += "*";
            }
            return msj;
        }

        private static bool TryParse(string msj,out string salida)
        {
            int longitud = msj.Length;
            bool resp = false;

            if (longitud == 0)
            {
                resp = false;
            }
            else
            {
                resp = true;
                msj = ArmarFormatoMensaje();
            }
            salida = msj;
            return resp;
        }
    }
}
