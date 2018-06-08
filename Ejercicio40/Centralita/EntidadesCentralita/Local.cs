using System;
using System.Collections.Generic;
using System.Text;

namespace CentralitaHerencia
{
    public class Local: Llamada
    {
        protected float _costo;

        public override float CostoLlamada
        {
            get { return this.CalcularCosto(); }
        }

        private float CalcularCosto()
        {
            return this._costo * base.Duracion;
        }

        public override bool Equals(object obj)
        {
            bool retValue = false;
            if ((Llamada)obj is Local)
            {
                retValue = true;
            }
            return retValue;
        }

        public Local(Llamada unaLlamada, float costo):this(unaLlamada.NroOrigen, unaLlamada.Duracion, unaLlamada.NroDestino, costo)
        {

        }

        public Local(string origen, float duracion, string destino, float costo):base(origen, destino, duracion)
        {
            this._costo = costo;
        }

        protected override string Mostrar()
        {
            return base.Mostrar() + "Costo Llamada: " + this.CostoLlamada;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
