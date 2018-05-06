using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrestamosPersonales;

namespace PrestamosPersonales
{
    public class PrestamoPesos: Prestamo
    {
        protected float _porcentajeInteres;

        public float Interes
        {
            get { return CalcularInteres(); }
        }

        private float CalcularInteres()
        {
            float retValue = this._monto + (this._monto * (this._porcentajeInteres / 100));
            return retValue;
        }

        public override void ExtenderPlazo(DateTime nuevoVencimiento)
        {
            TimeSpan diasDif = nuevoVencimiento - this._vencimiento;
            int diasExtendidos = diasDif.Days;
            this._porcentajeInteres = this._porcentajeInteres + (0.25f * diasExtendidos);
            this.Vencimiento = nuevoVencimiento;
        }

        public override string Mostrar()
        {
            string retValue = base.Mostrar();
            retValue += " -- % Interes: " + this._porcentajeInteres;
            return retValue;
        }

        public PrestamoPesos(float monto, DateTime vencimiento, float interes):base(monto, vencimiento)
        {
            this._porcentajeInteres = interes;
        }

        public PrestamoPesos(Prestamo prestamo, float porcentajeInteres):this(prestamo.Monto, prestamo.Vencimiento, porcentajeInteres)
        {

        }

    }
}
