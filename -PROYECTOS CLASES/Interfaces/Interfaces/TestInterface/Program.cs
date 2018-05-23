using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2205;

namespace TestInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Avion nuevoAvion = new Avion(70000, 325);
            Deportivo nuevoAuto = new Deportivo(20000, "asdasd45", 500);
            Console.WriteLine("Impuesto Avion");
            Console.WriteLine(((IAFIP)nuevoAvion).CalcularImpuesto().ToString());//debo castear la interfaz
            Console.WriteLine("Impuesto Auto Deportivo");
            Console.WriteLine(((IARBA)nuevoAuto).CalcularImpuesto().ToString());//castear interfaz
            
            Privado avionPrivado = new Privado(800000, 250, 10);
            Comercial avionComercial = new Comercial(50000, 200, 155);

            Console.WriteLine(Gestion.MostrarImpuestoNacional(nuevoAuto).ToString());
            Console.WriteLine(Gestion.MostrarImpuestoNacional(avionPrivado).ToString());
            Console.WriteLine(Gestion.MostrarImpuestoNacional(avionComercial).ToString());

            avionComercial.MostrarPrecio();
            avionPrivado.MostrarPrecio();

            Console.ReadLine();
        }
    }
}
