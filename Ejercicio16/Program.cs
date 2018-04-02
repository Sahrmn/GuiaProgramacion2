using System;

namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno();
            Alumno alumno2 = new Alumno();
            Alumno alumno3 = new Alumno();

            alumno1.nombre = "Pedro";
            alumno1.apellido = "Ruiz";
            alumno1.legajo = 123;
            alumno1.Estudiar(5,2);
            alumno1.Mostar();
            alumno2.nombre = "Maria";
            alumno2.apellido = "Cejas";
            alumno2.legajo = 124;
            alumno2.Estudiar(9, 6);
            alumno2.Mostar();
            alumno3.nombre = "Samantha";
            alumno3.apellido = "Moreno";
            alumno3.legajo = 125;
            alumno3.Estudiar(5, 7);
            alumno3.Mostar();
            Console.ReadLine();
        }
    }
}
