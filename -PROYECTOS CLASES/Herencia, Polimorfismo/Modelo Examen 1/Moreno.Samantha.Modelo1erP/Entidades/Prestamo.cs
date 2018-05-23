using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    public abstract class Prestamo
    {
        protected float _monto;
        protected DateTime _vencimiento;
        
        public float Monto
        {
            get { return this._monto; }
        }

        public DateTime Vencimiento 
        {
            get { return this._vencimiento; }
            set {
                if (DateTime.Compare(value, DateTime.Now) > 0 )
                {
                    this._vencimiento = value;
                }
                else
                    this._vencimiento = DateTime.Now;
                }
        }

        public abstract void ExtenderPlazo(DateTime nuevoVencimiento);

        public virtual string Mostrar()
        {
            return  "Monto: " + this._monto + " -- Vencimiento: " + this._vencimiento ;
        }

        public static int OrdenarPorFecha(Prestamo p1, Prestamo p2)
        {
            int retValue = -1;
            if (DateTime.Compare(p1._vencimiento, p2._vencimiento) > 0)
            {
                retValue = 1;
            }
            else if (DateTime.Compare(p1._vencimiento, p2._vencimiento) == 0)
                retValue = 0;
            return retValue;
        }

        public Prestamo(float monto, DateTime vencimiento)
        {
            this._monto = monto;
            this._vencimiento = vencimiento;
        }
    }
}
