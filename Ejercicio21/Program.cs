using System;

namespace Ejercicio21
{
    class Program
    {
        static void Main(string[] args)
        {
            Celcius cel = new Celcius(1);
            Fahrenheit fah = new Fahrenheit(1);
            Kelvin kel = new Kelvin(1);

            Fahrenheit prueba1 = (Fahrenheit)cel;
            Console.WriteLine(prueba1.GetCantidad());
            Kelvin prueba2 = (Kelvin)cel;
            Console.WriteLine(prueba2.GetCantidad());

            Console.WriteLine("\n");

            Celcius prueba3 = (Celcius)fah;
            Console.WriteLine(prueba3.GetCantidad());
            prueba2 = (Kelvin)fah;
            Console.WriteLine(prueba2.GetCantidad());

            Console.WriteLine("\n");

            prueba3 = (Celcius)kel;
            Console.WriteLine(prueba3.GetCantidad());
            prueba1 = (Fahrenheit)kel;
            Console.WriteLine(prueba1.GetCantidad());

            Console.WriteLine("\n");

            Celcius x = cel + prueba3;
            Console.WriteLine(x.GetCantidad());
            x = cel + prueba1;
            Console.WriteLine(x.GetCantidad());

            Console.ReadLine();

        }
    }
}
