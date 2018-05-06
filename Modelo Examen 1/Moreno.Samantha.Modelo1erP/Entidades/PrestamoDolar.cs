using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrestamosPersonales;

namespace PrestamosPersonales
{
    public class PrestamoDolar: Prestamo
    {
        private PeriodicidadDePagos _periodisidad;

        public float Interes
        {
            get { return this.CalcularInteres(); }
        }
        
        public PeriodicidadDePagos Periodicidad
        {
            get
            {
                return this._periodisidad;
            }
        }

        private float CalcularInteres()
        {
            double interes = 0;
            switch (this._periodisidad)
            { 
                case PeriodicidadDePagos.Mensual:
                    interes = 1.25;
                    break;
                case PeriodicidadDePagos.Bimestral:
                    interes = 1.35;
                    break;
                case PeriodicidadDePagos.Trimestral:
                    interes = 1.40;
                    break;
            }
            return (float)(base._monto * interes);       
        }

        public override void ExtenderPlazo(DateTime nuevoVencimiento)
        {
            TimeSpan diasDif = nuevoVencimiento - this._vencimiento;
            int diasExtendidos = diasDif.Days;
            this._monto = this._monto + (2.5f * diasExtendidos);
            this.Vencimiento = nuevoVencimiento;
        }

        public override string Mostrar()
        {
            string retValue = base.Mostrar();
            retValue += " -- Periodisidad: " + this._periodisidad;
            return retValue;
        }

        public PrestamoDolar(float monto, DateTime vencimiento, PeriodicidadDePagos periodicidad):base(monto, vencimiento)
        {
            this._periodisidad = periodicidad;
        }

        public PrestamoDolar(Prestamo prestamo, PeriodicidadDePagos periodicidad):this(prestamo.Monto, prestamo.Vencimiento, periodicidad)
        {
            
        }
  
    }
}
