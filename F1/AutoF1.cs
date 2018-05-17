using System;

namespace F1
{
    public class AutoF1
    {
        private short _cantidadCombustible;
        private bool _enCompetencia;
        private string _escuderia;
        private short _numero;
        private short _vueltasRestantes;

        public short CantidadDeCombustible
        {
            get { return this._cantidadCombustible; }
            set { this._cantidadCombustible = value; }    
        }

        public bool EnCompetencia
        {
            get { return this._enCompetencia; }
            set { this._enCompetencia = value; }
        }

        public short VueltasRestantes
        {
            get { return this._vueltasRestantes; }
            set { this._vueltasRestantes = value; }
        }

        public AutoF1(short numero, string escuderia)
        {
            this._numero = numero;
            this._escuderia = escuderia;
            this._enCompetencia = false;
            this._cantidadCombustible = 0;
            this._vueltasRestantes = 0;
        }

        public string MostrarDatos()
        {
            string retValue = "NUMERO: " + this._numero + "\nEN COMPETENCIA: " + this._enCompetencia;
            retValue += "\nESCUDERIA: " + this._escuderia + "\nCANT. DE COMBUSTIBLE: " + this._cantidadCombustible;
            retValue += "\nVUELTAS RESTANTES: " + this._vueltasRestantes;
            return retValue;
        }

        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            bool retValue = false;
            if (a1._numero == a2._numero && a1._escuderia == a2._escuderia)
            {
                retValue = true;
            }
            return retValue;
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }
    }
}
