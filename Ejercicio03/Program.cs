using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    class Ejercicio03
    {
        static void Main(string[] args)
        {
            int num = 0;
            int contador = 0;
            int modulo = 0;
            int i,j;

            Console.Write("Ingrese un numero:");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("Numeros Primos");
            for (i = 2; i < num; i++)
            {
                j = i;
                while (j != 0)
                {
                    modulo = i % j;
                    if (modulo == 0)
                        contador++;
                    j--;
                }
                if (contador == 2)
                    Console.WriteLine("{0, 4}",i);
                contador = 0;
            }
            Console.ReadLine();
        }
    }
}
