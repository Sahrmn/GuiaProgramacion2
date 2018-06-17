using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace TestEmpleado
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado nuevoEmpleado = new Empleado("Marcelo", "Navarro", 45454545);
            nuevoEmpleado.SueldoCero += new DelegadoSueldoCero(nuevoEmpleado.ManejadorEvento);
            nuevoEmpleado.LimiteDeSueldo += new DelegadoLimiteSueldo(nuevoEmpleado.LimiteSueldo);
            nuevoEmpleado.Sueldo = -10;
            nuevoEmpleado.Sueldo = 0;
            nuevoEmpleado.Sueldo = 111111111;
            //Console.WriteLine(nuevoEmpleado.Sueldo.ToString());
            
            //Console.WriteLine(nuevoEmpleado.Sueldo.ToString());
            Console.ReadLine();
        }
    }
}
