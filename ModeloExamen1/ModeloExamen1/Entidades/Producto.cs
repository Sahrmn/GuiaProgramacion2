using System;

namespace Entidades
{
    public class Producto
    {
        protected int _codigoBarra;
        protected EmarcaProducto _marca;
        protected float _precio;

        public EmarcaProducto Marca
        {
            get {return this._marca; }
        }

        public float Precio
        {
            get { return this._precio; }
        }

        public static explicit operator int(Producto prod)
        {
            return prod._codigoBarra;
        }

        protected static string MostrarProducto(Producto prod)
        {
            string retValue = "Codigo de Barra: " + prod._codigoBarra + " -- Marca: " + prod._marca + "-- Precio: " + prod._precio;
            return retValue;
        }

        public static bool operator ==(Producto productoUno, EmarcaProducto marca)
        {
            bool retValue = false;
            if (productoUno.Marca == marca)
            {
                retValue = true;
            }
            return retValue;
        }

        public static bool operator !=(Producto productoUno, EmarcaProducto marca)
        {
            return !(productoUno == marca);
        }

        public static bool operator ==(Producto productoUno, Producto productoDos)
        {
            bool retValue = false;
            if (productoUno.Marca == productoDos.Marca && productoUno._codigoBarra == productoDos._codigoBarra)
            {
                retValue = true;
            }
            return retValue;
        }

        public static bool operator !=(Producto productoUno, Producto productoDos)
        {
            return !(productoUno == productoDos);
        }

        public Producto(int codigo, EmarcaProducto marca, float precio)
        {
            this._codigoBarra = codigo;
            this._marca = marca;
            this._precio = precio;
        }
            

    }
}
