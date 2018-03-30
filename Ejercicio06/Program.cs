using System;

namespace Ejercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            int anioingresado;

            Console.WriteLine("CALCULO DE AÑO BISIESTO");
            Console.WriteLine("\n");
            Console.WriteLine("Ingrese un año: ");
            anioingresado = int.Parse(Console.ReadLine());

            if ((anioingresado % 4) == 0)
            {
                if ((anioingresado % 100) == 0)
                {
                    if((anioingresado % 400) == 0)
                        Console.WriteLine("Es bisiesto!");
                    else
                        Console.WriteLine("NO es bisiesto!");
                }
                else
                    Console.WriteLine("Es bisiesto!");
            }
            else
                Console.WriteLine("NO es bisiesto!");
            Console.ReadLine();
        }
    }
}
