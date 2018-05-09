using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Gaseosa: Producto
    {
        protected float _litros;

        public Gaseosa(int codigo, float precio, EmarcaProducto marca, float litros):base(codigo, marca, precio)
        {
            this._litros = litros;
        }

        public Gaseosa(Producto producto, float litros): this((int)producto , producto.Precio, producto.Marca, litros)
        { }

        public string MostrarGaseosa()
        {
            string retValue = Producto.MostrarProducto(this) + " -- Litros: " + this._litros;
            return retValue;
        }
    }
}
