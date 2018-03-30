using System;

namespace Ejercicio09
{
    class Program
    {
        static void Main(string[] args)
        {
            int alt = 0;
            int estrellas = 1;
            Console.WriteLine("PIRAMIDE\n");
            Console.Write("Altura de la piramide: ");
            alt = int.Parse(Console.ReadLine());

            while (alt != 0)
            {
                for (int i = 0; i < estrellas; i++)
                {
                    Console.Write("*");
                }
                estrellas++;
                alt--;
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}
