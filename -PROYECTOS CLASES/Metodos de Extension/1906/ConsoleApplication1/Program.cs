using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Alumnos;
using Entidades.Externa;

/*
 * 2DO PARCIAL!!!
 eventos, clases genericas, delegados
 * armar abm con insercion, modificacion, eliminacion de base de datos
 * armar metodos de extension con los anteriores , con todos los metodos posibles 
 * 
 */
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona unaPersona = new Persona("Marta", "Romero", 45, Entidades.Externa.ESexo.Femenino);
            Console.WriteLine(unaPersona.ToString());

            Console.WriteLine(unaPersona.ObtenerInfo());
            Console.WriteLine(unaPersona.ObtenerInfoDll());
            bool resp = unaPersona.EscribirEnArchivo("D:\\UnaPersonaPrueba.txt");
            if (resp)
            {
                Console.WriteLine("Listo!");
            }
            else
                Console.WriteLine("Error!");
            Console.WriteLine(unaPersona.EsNulo());
            Console.WriteLine("Cantidad de caracteres: " + unaPersona.Apellido.CantidadCaracteres());
            resp = unaPersona.AgregarEnBaseDeDatos();
            if (resp)
            {
                Console.WriteLine("Agregado a la db!");
            }
            else
                Console.WriteLine("Error agregando a la db!");
            Console.ReadLine();
        }
    }
}
