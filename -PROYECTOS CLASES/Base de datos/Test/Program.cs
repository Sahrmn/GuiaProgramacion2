using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Persona.TraerTodos();
            foreach (Persona item in Persona.TraerTodos())
            {
                Console.WriteLine(item.ID + " - " + item.Apellido + " - " + item.Nombre);
            }

            Persona persona1 = new Persona("Pedrito", "Ruiz", 36);
            //Console.WriteLine(persona1.Agregar().ToString());
            //Console.WriteLine(Persona.Borrar(persona1).ToString());
            //Console.WriteLine(persona1.Modificar().ToString());
            Persona persona2 = Persona.TraerTodos(5);
            //if (persona2 != null)
            //{
            //    Console.WriteLine(persona2.ToString());    
            //}
            //else
            //    Console.WriteLine("No se pudo mostrar");

            DataTable data = Persona.TraerTodosTabla();
            foreach (DataRow item in data.Rows)
            {
                Console.WriteLine(item["nombre"].ToString() + " - " + item["apellido"].ToString());
            }

            Console.ReadLine();
        }
    }
}
