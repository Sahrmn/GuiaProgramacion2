using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio31;

namespace TestPuestoDeAtencion___Ejer31
{
    class Program
    {
        static void Main(string[] args)
        {
            PuestoAtencion caja = new PuestoAtencion(PuestoAtencion.EPuesto.Caja1);
            Cliente marta = new Cliente(1, "marta");
            Cliente roberto = new Cliente(2, "roberto");
            Cliente ramiro = new Cliente(3, "ramiro");
            Negocio elNegocio = new Negocio("La parrillada");

            Console.WriteLine("Comparacion clientes:");
            Console.WriteLine(marta == roberto);
            Console.WriteLine(ramiro != marta);

            if (elNegocio + marta)
                Console.WriteLine("Agregada marta");
            else
                Console.WriteLine("No se pudo agregar");

            if (!(elNegocio + marta))//repito
                Console.WriteLine("No se pudo agregar marta");

            if (elNegocio + roberto)
                Console.WriteLine("Agregado roberto");
            else
                Console.WriteLine("No se pudo agregar roberto");

            if (elNegocio + ramiro)
                Console.WriteLine("Agregado ramiro");
            else
                Console.WriteLine("No se pudo agregar ramiro");

            Console.WriteLine("Atender el cliente " + elNegocio.Cliente.Nombre);
            if (~(elNegocio))
            {
                Console.WriteLine("Atendido!");
            }
            Console.WriteLine("Atender el cliente " + elNegocio.Cliente.Nombre);
            if (~(elNegocio))
            {
                Console.WriteLine("Atendido!");
            }
            Console.WriteLine("Atender el cliente " + elNegocio.Cliente.Nombre);
            if (~(elNegocio))
            {
                Console.WriteLine("Atendido!");
            }
            Console.WriteLine("Atender el cliente " + elNegocio.Cliente.Nombre);
            if (~(elNegocio))
            {
                Console.WriteLine("Atendido!");
            }

            Console.ReadLine();

        }
    }
}
