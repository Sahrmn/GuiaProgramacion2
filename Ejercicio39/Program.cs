using System;

namespace Ejercicio39
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nº39 Guía 2017";
            SobreSobreescrito sobrecarga = new SobreSobreescrito();
            Console.WriteLine(sobrecarga.ToString());
            string objeto = "¡Este es mi método ToString sobreescrito!";
            Console.WriteLine("----------------------------------------------");
            Console.Write("Comparación Sobrecargas con String: ");
            Console.WriteLine(sobrecarga.Equals(objeto));
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(sobrecarga.GetHashCode());
            Console.WriteLine(sobrecarga.MiPropiedad.ToString());
            Console.ReadKey();
        }
    }
}
