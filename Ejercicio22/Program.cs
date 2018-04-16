using System;
using Conversor;

namespace Ejercicio22
{
    class Program
    {
        static void Main(string[] args)
        {
            NumeroBinario bin = new NumeroBinario("10001");
            NumeroDecimal dec = new NumeroDecimal(20);

            double dec2 = dec + bin;
            string bin2 = bin + dec;
            Console.WriteLine(dec2);
            Console.WriteLine(bin2);

            dec2 = dec - bin;
            bin2 = bin - dec;
            Console.WriteLine(dec2);
            Console.WriteLine(bin2);

            Console.WriteLine(bin == dec);
            Console.WriteLine(bin != dec);
            Console.WriteLine(dec == bin);
            Console.WriteLine(dec != bin);

            double dec3 = 3;
            Console.WriteLine(dec3 == (dec - bin));

            Console.ReadLine();
        }
    }
}
