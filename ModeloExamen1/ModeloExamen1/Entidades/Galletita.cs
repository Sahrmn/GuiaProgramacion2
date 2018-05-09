using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Galletita: Producto
    {
        protected float _peso;

        public Galletita(int codigo, float precio, EmarcaProducto marca, float peso): base(codigo, marca, precio)
        {
            this._peso = peso;
        }

        public static string MostrarGalletita(Galletita galleta)
        {
            string retValue = Producto.MostrarProducto(galleta) + " -- Peso: " + galleta._peso;
            return retValue;
        }

    }
}
