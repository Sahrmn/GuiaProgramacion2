using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Auto
    {
        private string _color;
        private string _marca;

        public string Color
        {
            get { return this._color; }
        }

        public string Marca
        {
            get { return this._marca; }
        }

        public Auto(string color, string marca)
        {
            this._color = color;
            this._marca = marca;
        }

        public override bool Equals(object obj)
        {
            bool retValue = false;
            if (obj is Auto && ((Auto)obj)._color == this._color && ((Auto)obj)._marca == this._marca)
            {
                retValue = true;
            }
            return retValue;
        }


        public static bool operator ==(Auto a, Auto b)
        {
            bool retValue = false;
            if (a._color == b._color && a._marca == b._marca)
            {
                retValue = true;
            }
            return retValue;
        }

        public static bool operator !=(Auto a, Auto b)
        {
            return !(a == b);
        }

        public override string ToString()
        {
            string retValue = "MARCA:" + this._marca + " -- COLOR: " + this._color;
            return retValue;
        }

    }
}
