using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    public abstract class Vehiculo
    {
        private string _patente;
        private byte _cantRuedas;
        public enum EMarcas {Honda, Ford, Zanella, Scania, Iveco, Fiat};
        protected EMarcas _marca;

        public string GetPatente
        {
            get { return this._patente; }
        }

        public EMarcas GetMarca
        {
            get { return this._marca; }
        }

        protected virtual string Mostrar()
        {
            string retValue = "Patente: " + this._patente + "\nCantidad de Ruedas: " + this._cantRuedas + "\nMarca: " + this._marca;
            return retValue;
        }

        public Vehiculo(string p, byte r, EMarcas m)
        {
            this._patente = p;
            this._cantRuedas = r;
            this._marca = m;
        }

        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            bool retValue = false;
            if (v1._patente == v2._patente && v1._marca == v2._marca)
            {
                retValue = true;
            }
            return retValue;
        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }

        public abstract string Acelerar();
        
    }
}
