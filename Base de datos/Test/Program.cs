using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

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
            
            Console.ReadLine();
        }
    }
}
