using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Jugo: Producto
    {
        protected ESaborJugo _sabor;

        public Jugo(int codigo, float precio, EmarcaProducto marca, ESaborJugo sabor):base(codigo, marca, precio)
        {
            this._sabor = sabor;
        }

        public string MostrarJugo()
        {
            string retValue = Producto.MostrarProducto(this) + " -- Sabor: " + this._sabor;
            return retValue;
        }
    }
}
