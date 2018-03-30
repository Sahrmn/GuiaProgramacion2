using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClaseCosa;

namespace Clase04
{
    class Program
    {
        static void Main(string[] args)
        {
            int entero = 2;
            string cadena = "Hola";
            DateTime fecha = DateTime.Now; 
            DateTime fecha2 = new DateTime(1991,7,2);

            Cosa cosita = new Cosa();
            Cosa cosita2 = new Cosa(80,"samantha", fecha2);
            Console.WriteLine(cosita2.Mostrar());
            Console.ReadLine();

            Console.WriteLine(cosita.Mostrar());
            Console.ReadLine();
            cosita.EstablecerValor(entero);
            cosita.EstablecerValor(cadena);
            cosita.EstablecerValor(fecha);
            Console.WriteLine(cosita.Mostrar());
            Console.ReadLine();
            

        }
    }
}
