using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerClase02
{
    class Sello
    {
        public static string mensaje = "";

        public static void Imprimir()
        {
            Console.Write(mensaje);
            Console.ReadLine();
        }

        public static void Borrar()
        {
            Console.Clear();
            Console.ReadLine();
        }
    }
}
