using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using F1;

namespace TestF1_Ejercicio30
{
    class Program
    {
        static void Main(string[] args)
        {
            AutoF1 a1 = new AutoF1(8, "Ferrari");
            AutoF1 a2 = new AutoF1(10, "Porche");
            AutoF1 a3 = new AutoF1(14, "BMW");
            AutoF1 a4 = new AutoF1(28, "Ford");
            Competencia da = new Competencia(3,3);
            if ((da + a1))
            {
                Console.WriteLine("Se ha agregado el item!!!");
            }
            if ((da + a2))
            {
                Console.WriteLine("Se ha agregado el item!!!");
            }
            if ((da + a3))
            {
                Console.WriteLine("Se ha agregado el item!!!");
            }
            if (!(da + a4))
            {
                Console.WriteLine("No se pudo agregar el item!!!");
            }
            Console.WriteLine(da.MostrarDatos());
            
            if (!(da - a4))
            {
                Console.WriteLine("No se pudo remover el item!!!");
            }
            Console.WriteLine(da.MostrarDatos());
            Console.ReadLine();
        }
    }
}
