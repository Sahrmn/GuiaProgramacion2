using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Clase08;

namespace TestEquipoJugador
{
    class Program
    {
        static void Main(string[] args)
        {
            Jugador jugador1 = new Jugador("Osvaldo");
            Jugador jugador2 = new Jugador("Mariano", 33665888);
            Jugador jugador3 = new Jugador("Alejandro", 885566988, 5, 8);
            Jugador jugador4 = new Jugador("Leandro", 3213213, 6, 5);
            Equipo nuevoEquipo = new Equipo(2, "un equipo");

            /*Console.WriteLine(jugador1.MostrarDatos());
            Console.WriteLine(jugador2.MostrarDatos());
            Console.WriteLine(jugador3.MostrarDatos());
            Console.ReadLine();*/

            Console.WriteLine(nuevoEquipo + jugador1);
            Console.WriteLine(nuevoEquipo + jugador1);
            Console.WriteLine(nuevoEquipo + jugador2);
            Console.WriteLine(nuevoEquipo + jugador2);
            Console.WriteLine(nuevoEquipo + jugador3);
            Console.WriteLine(nuevoEquipo + jugador4);
            //foreach (Jugador item in nuevoEquipo)
            //{
            //    Console.WriteLine(item);
            //}
            Console.ReadLine();

        }
    }
}
