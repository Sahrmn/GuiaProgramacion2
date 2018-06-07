using System;

namespace Ejercicio34
{
    class Program
    {
        static void Main(string[] args)
        {
            Camion camion1 = new Camion(4, 4000, 8, 2, EColores.Blanco);
            Moto moto1 = new Moto(70, 2, 0, EColores.Gris);
            Automovil auto1 = new Automovil(4, 4, 4, 5, EColores.Rojo);

            Console.WriteLine("Color del Camion: " + camion1._color);
            Console.ReadLine();
        }
    }
}
