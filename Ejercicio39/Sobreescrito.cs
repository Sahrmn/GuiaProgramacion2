using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio39
{
    public abstract class Sobreescrito
    {
        protected string _miAtributo;

        public Sobreescrito()
        {
            this._miAtributo = "Probar abstractos";
        }

        public abstract string MiPropiedad
        {
            get;
        }

        public abstract string MiMetodo();

        public override string ToString()
        {
            return "Este es mi metodo ToString sobreescrito!";
        }

        public override bool Equals(object obj)
        {
            bool retValue = false;
            if (this.GetType() == obj.GetType())
            {
                retValue = true;
            }
            return retValue;
        }

        public override int GetHashCode()
        {
            return 1142510187;
        }
    }
}
