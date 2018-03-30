using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerClase02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sello.mensaje = "Hola!";
            //Sello.Imprimir();
            //Sello.Borrar();

            EntidadSello.Sello.color = ConsoleColor.Yellow;
            EntidadSello.Sello.mensaje = "It's work!";
            EntidadSello.Sello.Imprimir();
            Console.WriteLine("Pulse enter para salir.");
            Console.ReadLine();
            EntidadSello.Sello.Borrar(); 
        }
    }
}
