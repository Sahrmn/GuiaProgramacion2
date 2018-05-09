using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Estante
    {
        protected sbyte _capacidad;
        protected List<Producto> _productos;

        public float ValorEstanteTotal
        {
            get { return this._capacidad; }
        }

        private Estante()
        {
            this._productos = new List<Producto>();
        }

        public Estante(sbyte capacidad):this()
        {
            this._capacidad = capacidad;
        }

        public List<Producto> GetProductos()
        {
            return this._productos;
        }

        private float GetValorEstante()
        {
            return 0;
        }

        public float GetValorEstante(ETipoProducto tipo)
        {
            return 0;
        }

        public static string MostrarEstante(Estante est)
        {
            string retValue = "Capacidad: " + est._capacidad + " -- PRODUCTOS  \n";
            foreach (Producto item in est._productos)
            {
                if (item is Jugo)
                {
                    retValue += ((Jugo)item).MostrarJugo();
                }
                else if(item is Galletita)
                {
                    retValue += Galletita.MostrarGalletita((Galletita)item);
                }
                else if(item is Gaseosa)
                {
                    retValue += ((Gaseosa)item).MostrarGaseosa();
                }
                retValue += "\n";
            }
            return retValue;
        }

        public static bool operator ==(Estante est, Producto prod)
        {
            bool retValue = false;
            foreach (Producto item in est._productos)
            {
                if (item == prod)
                {
                    retValue = true;
                    break;
                }
            }
            return retValue;
        }

        public static bool operator !=(Estante est, Producto prod)
        {
            return !(est == prod);
        }

        public static bool operator +(Estante est, Producto prod)
        {
            bool retValue = false;
            if ((est != prod) && est._capacidad > 0)
            {
                retValue = true;
            }
            return retValue;
        }

        public static Estante operator -(Estante est, ETipoProducto tipo)
        {
            //Estante nuevoEstante = est;
            //for (int i = 0; i < est._productos.Count; i++)
            //{
            //    if (est._productos[i] is tipo)
            //    {

            //    }
            //}
            return null;
        }

        public static Estante operator -(Estante est, Producto prod)
        {
            if (est == prod)
            {
                est._productos.Remove(prod);
            }
            else
                Console.WriteLine("Producto no encontrado!");
            return est;
        }


    }
}
