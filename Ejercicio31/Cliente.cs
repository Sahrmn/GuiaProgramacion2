using System;

namespace Ejercicio31
{
    public class Cliente
    {
        private string _nombre;
        private int _numero;

        public string Nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }

        public int Numero
        {
            get { return this._numero; }
            set { this._numero = value; }
        }

        public Cliente(int numero)
        {
            this.Numero = numero;
        }

        public Cliente(int numero, string nombre):this(numero)
        {
            this.Nombre = nombre;
        }

        public static bool operator ==(Cliente c1, Cliente c2)
        {
            bool retValue = false;
            if (c1.Numero == c2.Numero)
            {
                retValue = true;
            }
            return retValue;
        }

        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }
    }
}
