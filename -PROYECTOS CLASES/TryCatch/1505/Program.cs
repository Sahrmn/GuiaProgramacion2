using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace _1505
{
    class Program
    {
        static void Main(string[] args)
        {
            Numero unNumero = new Numero(9);
            Numero otroNumero;
            bool resp = Numero.Parse("8", out otroNumero);
            if (resp == true)
            {
                Console.WriteLine(otroNumero.Numeros);
            }
            Console.ReadLine();
        }
    }
}
