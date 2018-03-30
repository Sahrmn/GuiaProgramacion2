using System;

namespace Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            bool validacion = true;
            int acum = 0;
            int numero = 0;
            char resp;

            Console.WriteLine("EJERCICIO 12\n");

            while (validacion == true)
            {
                Console.Write("Ingrese un numero: ");
                numero = int.Parse(Console.ReadLine());
                acum += numero;
                Console.Write("¿Continuar?(S/N) ");
                resp = char.Parse(Console.ReadLine());
                validacion = ValidarRespuesta.ValidaS_N(resp);
            }
            Console.WriteLine("\nTotal {0}", acum);
            Console.ReadLine();
        }
    }
}
