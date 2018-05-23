using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehiculos;

namespace TestVehiculo
{
    class Program
    {
        static void Main(string[] args)
        {
            Moto moto1 = new Moto("4545d", 2, Vehiculo.EMarcas.Honda, 1, 1, 70);
            Moto moto2 = new Moto("dsds4", 2, Vehiculo.EMarcas.Zanella, 1, 1, 70);
            Camion camion1 = new Camion("54ad", 8, Vehiculo.EMarcas.Ford, 1, 1, 120);
            Auto auto1 = new Auto("32dgfg", 4, Vehiculo.EMarcas.Scania, 1, 1, 100);
            List<Vehiculo> lista = new List<Vehiculo>();
            lista.Add(moto1);
            lista.Add(camion1);
            lista.Add(auto1);
            lista.Add(moto2);
            Lavadero nuevoLavadero = new Lavadero(lista,35, 45, 20);
            Camion elcanion = new Camion("asdf45", 4, Vehiculo.EMarcas.Ford, 1, 4, 150);
            
            //Console.WriteLine(moto1.ToString());
            //Console.WriteLine(camion1.ToString());
            //Console.WriteLine(auto1.ToString());

            //Console.WriteLine("\n");

            //Console.WriteLine(moto1.Equals(camion1));
            //Console.WriteLine(moto1.Equals(moto2));
            //Console.WriteLine(camion1 != auto1);

            //Console.WriteLine("\n");

            Console.WriteLine(nuevoLavadero.MiLavadero);
            Console.WriteLine("\n");

            //Console.WriteLine(nuevoLavadero == elcanion);
            //nuevoLavadero += elcanion;
            //Console.WriteLine("\n");

            //Console.WriteLine(nuevoLavadero.MiLavadero);
            //Console.WriteLine("\n");


            Console.WriteLine("Total ganado con camiones: " + nuevoLavadero.MostrarTotalFacturado(Lavadero.EVehiculos.Camion));
            Console.WriteLine("Total ganado con motos: " + nuevoLavadero.MostrarTotalFacturado(Lavadero.EVehiculos.Moto));
            Console.WriteLine("Total ganado con autos: " + nuevoLavadero.MostrarTotalFacturado(Lavadero.EVehiculos.Auto));
            Console.WriteLine("Total: " + nuevoLavadero.MostrarTotalFacturado());

            nuevoLavadero.Ordenar(1);
            Console.WriteLine("\n");
            Console.WriteLine(nuevoLavadero.MiLavadero);
            


            Console.ReadLine();
        }
    }
}
