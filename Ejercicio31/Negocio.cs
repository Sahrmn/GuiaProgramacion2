using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio31
{
    public class Negocio
    {
        private PuestoAtencion _caja;
        private Queue<Cliente> _clientes;
        private string _nombre;

        public Cliente Cliente
        {
            get
            {
                return this._clientes.Peek();
            }
            set
            {
                bool a = true;
                foreach (Cliente item in this._clientes)
                {
                    if (item == value)
                    {
                        a = false;
                        break;
                    }
                }
                if (a == true)
                {
                    this._clientes.Enqueue(value);
                }
            }
        }

        private Negocio()
        {
            this._clientes = new Queue<Cliente>();
            this._caja = new PuestoAtencion(PuestoAtencion.EPuesto.Caja1);
        }

        public Negocio(string nombre):this()
        {
            this._nombre = nombre;
        }

        public static bool operator ==(Negocio n, Cliente c)
        {
            bool retValue = false;
            foreach (Cliente item in n._clientes)
            {
                if (item == c)
                {
                    retValue = true;
                    break;
                }
            }
            return retValue;
        }

        public static bool operator !=(Negocio n, Cliente c)
        {
            return false;
        }

        public static bool operator +(Negocio n, Cliente c)
        {
            bool retValue = false;
            foreach (Cliente item in n._clientes)
            {
                if (item == c)
                {
                    n._clientes.Enqueue(c);
                    retValue = true;
                    break;
                }
            }
            return retValue;
        }
    }
}
