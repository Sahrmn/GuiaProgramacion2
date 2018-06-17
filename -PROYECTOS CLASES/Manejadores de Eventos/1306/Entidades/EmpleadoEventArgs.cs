using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public delegate void DelegadoLimiteSueldoMejorado(Empleado em, EmpleadoEventArgs evento);

    public class EmpleadoEventArgs
    {
        public double Sueldo { get; set; }

        public event DelegadoLimiteSueldoMejorado SueldoMaximoMejorado;

        public void SueldoMejorado(Empleado em, EmpleadoEventArgs evento)
        {
            if (em.Sueldo > 20000 && em.Sueldo < 300000)
            {
                //EmpleadoEventArgs e = new EmpleadoEventArgs();
                
            }
        }
    }
}
