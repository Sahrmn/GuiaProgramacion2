using System;
using Ejercicio14;

namespace Ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Area de un cuadrado de {0}cm de lado: {1}",5,CalculoDeArea.CalcularCuadrado(5));
            Console.WriteLine("Area de un triangulo de {0}cm de base y {1}cm de altura: {2}", 10,5, CalculoDeArea.CalcularTriangulo(10,5));
            Console.WriteLine("Area de un circulo de {0}cm de radio: {1:0}", 8, CalculoDeArea.CalcularCirculo(8));
            Console.ReadLine();
        }
    }
}
