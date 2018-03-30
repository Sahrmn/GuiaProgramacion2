using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    class Ejercicio01
    {
        static void Main(string[] args)
        {
            int max = 0;
            int min = 0;
            float promedio = 0;
            int num;
            int i;

            for (i = 0; i < 5; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("Ingrese un numero:");
                    num = int.Parse(Console.ReadLine());
                    max = num;
                    min = num;
                    promedio = num;
                }
                else
                {
                    num = int.Parse(Console.ReadLine());
                    if (max < num)
                        max = num;
                    if (min > num)
                        min = num;
                    promedio += num;
                }
            }
            promedio = promedio / 5;
            Console.WriteLine("Maximo: " + max);
            Console.WriteLine("Minimo: " + min);
            Console.WriteLine("Promedio: " + promedio);
            Console.ReadLine();
        }
    }
}
