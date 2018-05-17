using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace TestContabilidad
{
    class Program
    {
        static void Main(string[] args)
        {
            Contabilidad<Factura, Recibo> a = new Contabilidad<Factura, Recibo>();
            Recibo recibo1 = new Recibo(1);
            Factura fact1 = new Factura(2);

            a = a + recibo1;
            a = a + fact1;
            a += fact1;
            a += recibo1;

            Recibo rec2 = new Recibo(4);
            Recibo rec3 = new Recibo(7);
            a += rec2;
            a += rec3;
            Factura fact2 = new Factura(5);
            a += fact2;

            Console.WriteLine("Facturas:");
            foreach (Factura item in a._egresos)
            {
                Console.WriteLine(item.Numero);
            }
            Console.WriteLine("Recibos:");
            foreach (Recibo item in a._ingresos)
            {
                Console.WriteLine(item.Numero);
            }

            Console.ReadLine();
        }
    }
}
