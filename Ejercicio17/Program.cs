using System;

namespace Ejercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            Boligrafo lapicera1 = new Boligrafo(3, ConsoleColor.Blue);
            Boligrafo lapicera2 = new Boligrafo(10, ConsoleColor.Red);
            string dibujo1 = "";
            string dibujo2 = "";

            lapicera1.Pintar(4, out dibujo1);
            Console.WriteLine(dibujo1);
            lapicera2.Pintar(5, out dibujo2);
            Console.WriteLine(dibujo2);
            Console.ReadLine();
        }
    }
}
