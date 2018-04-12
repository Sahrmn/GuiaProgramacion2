using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio19
{
    class Sumador
    {
        private int _cantidadSumas;

        public Sumador(int cant)
        {
            this._cantidadSumas = cant;
        }

        public Sumador() : this(0)
        { }

        public long Sumar(long a, long b)
        {
            long retValue = a + b;
            this._cantidadSumas++;
            return retValue;
        }

        public string Sumar(string a, string b)
        {
            string retValue = a + b;
            this._cantidadSumas++;
            return retValue;
        }

        public static explicit operator int(Sumador s)
        {
            return s._cantidadSumas;
        }

        public static long operator +(Sumador s1, Sumador s2)
        {
            long retValue = (int)s1 + (int)s2;
            return retValue;
        }

        public static bool operator |(Sumador s1, Sumador s2)
        {
            bool retValue = false;
            if ((int)s1 == (int)s2)
            {
                retValue = true;
            }
            return retValue;
        }
    }
}
