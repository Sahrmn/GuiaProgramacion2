using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    class Ejercicio02
    {
        static void Main(string[] args)
        {
            int numero = 0;

            Console.Write("Ingrese un numero:");
            numero = int.Parse(Console.ReadLine());
            while (numero <= 0)
            {
                Console.WriteLine("ERROR. ¡Reingresar numero!");
                numero = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Cuadrado: " + Math.Pow(numero,2));
            Console.WriteLine("Cubo: {0}" , Math.Pow(numero, 3));
            Console.ReadLine();
        }
    }
}
