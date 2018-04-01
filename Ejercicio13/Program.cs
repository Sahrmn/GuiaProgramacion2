using System;

namespace Ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero = 564;
            string respuesta = "";
            string binario = "10010011100";
            double respuesta2 = 0;
            Conversor nuevoConversor = new Conversor();
            respuesta = Conversor.DecimalBinario(numero);
            Console.WriteLine("Decimal: {0} \nBinario: {1}",numero, respuesta);
            Console.ReadLine();
            respuesta2 = Conversor.BinarioDecimal(binario);
            Console.WriteLine("Binario: {0} \nDecimal: {1}", binario, respuesta2);
            Console.ReadLine();
        }
    }
}
