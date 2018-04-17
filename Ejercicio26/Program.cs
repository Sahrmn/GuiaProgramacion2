using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio26
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[20];
            Random rand = new Random();
            int verif = 0;
            int aux = 0;

            for (int i = 0; i < 20; i++)
            {
                verif = rand.Next(-100, 100);
                while (verif == 0)
                {
                    verif = rand.Next(-100, 100);
                }
                numeros[i] = verif;
                Console.WriteLine(numeros[i]);
            }

            for (int i = 1; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    if (numeros[i] < numeros[j])
                    {
                        aux = numeros[i];
                        numeros[i] = numeros[j];
                        numeros[j] = aux;
                    }
                }
            }
            Console.WriteLine("\nElementos positivos\n");

            for (int i = 19; i > 0; i--)
            {
                if (numeros[i] > 0)
                {
                    Console.WriteLine(numeros[i]);
                }
            }

            Console.WriteLine("\nElementos negativos\n");

            foreach (int item in numeros)
            {
                if (item < 0)
                {
                    Console.WriteLine(item);
                }
            }

            Console.ReadLine();


        }
    }
}
