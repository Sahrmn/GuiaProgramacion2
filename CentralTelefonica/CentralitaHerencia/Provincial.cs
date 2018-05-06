using System;
using System.Collections.Generic;
using System.Text;

namespace CentralitaHerencia
{
    public class Provincial: Llamada
    {
        protected Franja _franjaHoraria;

        public override float CostoLlamada
        {
            get{ return this.CalcularCosto(); }
        }

        //*************************

        private float CalcularCosto()
        {
            float retValue = 0;
            switch (this._franjaHoraria)
            {
                case Franja.Franja_1:
                    retValue = 0.99f;
                    break;
                case Franja.Franja_2:
                    retValue = 1.25f;
                    break;
                case Franja.Franja_3:
                    retValue = 0.66f;
                    break;
            }
            retValue = retValue * this._duracion;
            return retValue;
        }

        public override bool Equals(object obj)
        {
            bool retValue = false;
            if ((Llamada)obj is Provincial)
            {
                retValue = true;
            }
            return retValue;
        }

        protected override string Mostrar()
        {
            return base.Mostrar() + "Franja Horaria: " + this._franjaHoraria + "\nCosto Llamada: " + this.CostoLlamada;
        }

        public Provincial(Franja miFranja, Llamada unaLlamada):this(unaLlamada.NroOrigen, miFranja, unaLlamada.Duracion, unaLlamada.NroDestino)
        {

        }

        public Provincial(string origen, Franja mifranja, float duracion, string destino):base(origen, destino, duracion)
        {
            this._franjaHoraria = mifranja;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }



    }
}
