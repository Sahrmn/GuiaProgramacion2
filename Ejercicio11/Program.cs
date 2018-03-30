using System;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            bool valid = false;
            int min = 0, max = 0, acum = 0;
            float promedio = 0;
            bool flag = false;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Ingrese un numero: ");
                num = int.Parse(Console.ReadLine());
                valid = Validacion.Validar(num, -100, 100);
                if (valid == true)
                {
                    if (flag == false)
                    {
                        min = num;
                        max = num;
                        acum += num;
                        flag = true;
                    }
                    else
                    {
                        if (num < min)
                        {
                            min = num;
                        }
                        else if (num > max)
                        {
                            max = num;
                        }
                        acum += num;
                    }
                }
                else
                {
                    Console.WriteLine("Los valores tiene que estar entre -100 y 100...\n");
                    i--;
                }
            }
            promedio = acum / 10;
            Console.WriteLine("Maximo: {0}", max);
            Console.WriteLine("Minimo: {0}", min);
            Console.WriteLine("Promedio: {0}", promedio);
            Console.ReadLine();
        }
    }
}
