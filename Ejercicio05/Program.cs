using System;

namespace Ejercicio05
{
    class Ejercicio05
    {
        static void Main(string[] args)
        {
            int centernumber = 2;
            int ingresousuario = 0;
            int i = 0, j = 0;
            int suma1 = 0, suma2 = 0;

            Console.Write("Ingrese un numero:");
            ingresousuario = int.Parse(Console.ReadLine());
            while (ingresousuario < 6)
            {
                Console.Write("Ingrese un numero:");
                ingresousuario = int.Parse(Console.ReadLine());
            }
            do
            {
                for (i = 1; i < centernumber; i++)
                {
                    suma1 += i;
                }
                if (centernumber + 1 < suma1 && suma2 <= suma1)
                {
                    for (j = 1; j < ingresousuario; j++)
                    {
                        suma2 += (centernumber + j);
                        if (suma1 == suma2)
                        {
                            Console.WriteLine(centernumber);
                            break;
                        }
                        else if (suma2 > suma1)
                            break;
                    }
                }
                suma2 = 0;
                suma1 = 0;
                centernumber++;
            } while (centernumber != ingresousuario);
            Console.ReadLine();
        }
    }
}
