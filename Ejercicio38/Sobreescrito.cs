using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio38
{
    class Sobreescrito
    {
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
