using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio18;

namespace PruebaGeometria
{
    class Program
    {
        static void Main(string[] args)
        {
            Punto punto1 = new Punto(0, 0);
            Punto punto2 = new Punto(16, 20);
            Rectangulo nuevoRectangulo = new Rectangulo(punto1, punto2);
            nuevoRectangulo.CalculoArea();
            nuevoRectangulo.CalculoPerimetro();
            Console.WriteLine("NUEVO RECTANGULO \n");
            Console.WriteLine("Area: {0}",nuevoRectangulo.GetArea());
            Console.WriteLine("Perimetro: {0}", nuevoRectangulo.GetPerimetro());
            Console.ReadLine();
        }
    }
}
