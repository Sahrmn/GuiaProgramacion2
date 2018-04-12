using System;

namespace Ejercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sumador suma = new Sumador();
            //Console.WriteLine(suma.Sumar("hola","mundo"));
            //Console.WriteLine(suma.Sumar(4,8));

            Sumador sumita = new Sumador(14);
            Sumador sumita2 = new Sumador(14);
            Console.WriteLine(sumita + sumita2);
            Console.WriteLine(sumita|sumita2);

            Console.ReadLine();
        }
    }
}
