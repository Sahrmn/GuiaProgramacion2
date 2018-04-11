using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace TestTinta
{
    class Program
    {
        static void Main(string[] args)
        {
            Tinta nuevaTinta1 = new Tinta();
            Tinta nuevaTinta2 = new Tinta(ConsoleColor.DarkBlue);
            Tinta nuevaTinta3 = new Tinta(ConsoleColor.DarkCyan, ETipoTinta.conBrillito);
            Pluma pluma1 = new Pluma();
            Pluma pluma2 = new Pluma("Una marca");
            Pluma pluma3 = new Pluma("Otra marca", 5);
            Pluma pluma4 = new Pluma("Una marca mas",9,nuevaTinta3);
            string a = pluma1;
            string b = pluma2;
            string c = pluma3;
            string d = pluma4;

            //Console.WriteLine(Tinta.Mostrar(nuevaTinta1) +"\n");
            //Console.WriteLine(Tinta.Mostrar(nuevaTinta2) + "\n");
            Console.WriteLine(Tinta.Mostrar(nuevaTinta3) + "\n");
            
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
            Console.WriteLine(d);

            //if (nuevaTinta1 != nuevaTinta3)
            //{
            //    Console.WriteLine("No son iguales");
            //}
            //else
            //    Console.WriteLine("Son iguales");

            pluma4 = pluma4 + nuevaTinta3;
            d = pluma4;
            Console.WriteLine(d);

            pluma4 = pluma4 - nuevaTinta3;
            d = pluma4;
            Console.WriteLine(d);
            pluma4 = pluma4 - nuevaTinta3;
            d = pluma4;
           
            Console.ReadLine();
        }
    }
}
