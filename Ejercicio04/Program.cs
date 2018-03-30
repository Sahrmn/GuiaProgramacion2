using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    class Ejercicio04
    {
        static void Main(string[] args)
        {
            int i = 2;
            int j = 0;
            int count = 0;
            int modulo = 0;
            int suma = 0;

            Console.WriteLine("Numeros perfectos:");
            while (count != 4)
            {
                j = i-1;
                while (j != 0)
                {
                    modulo = i % j;
                    if (modulo == 0)
                        suma += j;
                    j--;
                }
                if(suma == i)
                {
                    count++;
                    Console.WriteLine(i);
                }
                i++;
                suma = 0;
            }
            Console.ReadLine();
        }
    }
}
