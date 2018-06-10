using System;
using System.Collections.Generic;
using System.Text;

namespace CentralitaHerencia
{
    public abstract class Llamada
    {
        protected float _duracion;
        protected string _nroDestino;
        protected string _nroOrigen;

        public abstract float CostoLlamada
        {
            get;
        }

        public float Duracion
        {
            get { return this._duracion; }
        }

        public string NroDestino
        {
            get { return this._nroDestino; }
        }

        public string NroOrigen
        {
            get { return this._nroOrigen; }
        }

        public Llamada(string origen, string destino, float duracion)
        {
            this._duracion = duracion;
            this._nroDestino = destino;
            this._nroOrigen = origen;
        }

        protected virtual string Mostrar()
        {
            string retValue = "";
            retValue += "Duracion: " + this.Duracion + "\n";
            retValue += "Nro. Destino: " + this.NroDestino + "\n";
            retValue += "Nro. Origen: " + this.NroOrigen;
            retValue += "\n";
            return retValue;
        }

        public static int OrdenarPorDuracion(Llamada uno, Llamada dos)
        {
            int retValue = -1;
            if (uno.Duracion > dos.Duracion)
                retValue = 1;
            else if (uno.Duracion == dos.Duracion)
                retValue = 0;
            return retValue;
        }

        public static bool operator ==(Llamada uno, Llamada dos)
        {
            bool retValue = false;
            if (uno.Equals(dos) && uno.NroDestino == dos.NroDestino && uno.NroOrigen == dos.NroOrigen)
            {
                retValue = true;
            }
            return retValue;
        }

        public static bool operator !=(Llamada uno, Llamada dos)
        {
            return !(uno == dos);
        }

    }
}
