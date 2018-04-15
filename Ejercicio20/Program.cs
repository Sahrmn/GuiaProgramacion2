using System;

namespace Ejercicio20
{
    class Program
    {
        static void Main(string[] args)
        {
            Dolar undolar = new Dolar(1);
            Dolar dosdolares = new Dolar(4);
            Console.WriteLine("{0} Dolares", undolar.GetCantidad());
            Euro a = (Euro)undolar;
            Pesos b = (Pesos)undolar;
            Console.WriteLine("{0:0.00} Euros",a.GetCantidad());
            Console.WriteLine("{0:0.00} Pesos\n", b.GetCantidad());

            Euro uneuro = new Euro(1);
            Console.WriteLine("{0} Euros",uneuro.GetCantidad());
            Dolar c = (Dolar)uneuro;
            Pesos d = (Pesos)uneuro;
            Console.WriteLine("{0:0.00} Dolares", c.GetCantidad());
            Console.WriteLine("{0:0.00} Pesos\n", d.GetCantidad());

            Pesos unpeso = new Pesos(20);
            Console.WriteLine("{0} Pesos", unpeso.GetCantidad());
            Dolar e = (Dolar)unpeso;
            Euro f = (Euro)unpeso;
            Console.WriteLine("{0:0.00} Dolares", e.GetCantidad());
            Console.WriteLine("{0:0.00} Euros\n", f.GetCantidad());

            Console.WriteLine((undolar != dosdolares));
            Console.WriteLine((undolar == unpeso));
            Console.WriteLine((undolar == uneuro));
            Dolar asdf = undolar + uneuro;
            Console.WriteLine(asdf.GetCantidad());
            asdf = undolar - uneuro;
            Console.WriteLine(asdf.GetCantidad());
            asdf = undolar + unpeso;
            Console.WriteLine(asdf.GetCantidad());
            asdf = undolar - unpeso;
            Console.WriteLine(asdf.GetCantidad());
            Console.ReadLine();
        }
    }
}
