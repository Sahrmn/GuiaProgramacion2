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
                try
                {
                    return this._clientes.Peek();
                }
                catch
                {
                    //Console.WriteLine("No hay clientes!");
                    Cliente nuevo = new Cliente(0);
                    return nuevo;
                }
            }
            set
            {
                if (this != value)
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
            return !(n == c);
        }

        public static bool operator +(Negocio n, Cliente c)
        {
            bool retValue = false;
            bool flag = false;
            foreach (Cliente item in n._clientes)
            {
                if (item == c)
                {
                    flag = true;
                    break;
                }
            }
            if (flag == false)
            {
                try
                {
                    n._clientes.Enqueue(c);
                    retValue = true;
                }
                catch
                {
                    retValue = false;
                }
            }
            return retValue;
        }

        public static bool operator ~(Negocio n)
        {
            bool retValue = false;
            try
            {
                Cliente nuevoCliente = n._clientes.Dequeue();
                if (n._caja.Atender(nuevoCliente))
                    retValue = true;
            }
            catch
            {
                Console.WriteLine("No hay mas clientes que atender!");
            }
            return retValue;
        }
    }
}
