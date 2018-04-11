using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Tinta
    {
        private ConsoleColor _color;
        private ETipoTinta _tipoTinta;

        #region Constructores

        public Tinta(): this(ConsoleColor.Black, ETipoTinta.comun)
        {
        }

        public Tinta(ConsoleColor color)
        {
            this._color = color;
        }

        public Tinta(ConsoleColor color, ETipoTinta tinta):this(color)
        {
            this._tipoTinta = tinta;
        }

        #endregion

        #region Metodos

        private string Mostrar()
        {
            string retValue = "Tipo de Tinta: " + this._tipoTinta + " | Color: " + this._color;  
            return retValue;
        }

        public static string Mostrar(Tinta t)
        {
            string retValue = "";
            if ((object)t != null)
            {
                retValue = t.Mostrar();
            }
            return retValue;
        }

        #endregion

        #region Sobrecargas

        public static bool operator ==(Tinta a, Tinta b)
        {
            bool retValue = false;
            if ((object)a != null && (object)b != null)
            {
                if (a._color == b._color && a._tipoTinta == b._tipoTinta)
                {
                    retValue = true;
                }
            }
            return retValue;
        }

        public static bool operator !=(Tinta a, Tinta b)
        {
            return !(a == b);
        }

        #endregion

    }

    public class Pluma
    {
        private string _marca;
        private Tinta _tinta;
        private int _cantidad;

        #region Constructores

        public Pluma(): this("sin marca",0,null)
        {}

        public Pluma(string marca)
        {
            this._marca = marca;
        }

        public Pluma(string marca, int cant):this(marca)
        {
            this._cantidad = cant;
        }

        public Pluma(string marca, int cant, Tinta tinta):this(marca, cant)
        {
            this._tinta = tinta;
        }

        #endregion

        #region Metodos

        private string Mostrar()
        {
            string retValue = "Marca de tinta: " + this._marca + " \nCantidad: " + this._cantidad + " \nTinta: " + Tinta.Mostrar(this._tinta) + "\n";
            return retValue;
        }

        #endregion

        #region Sobrecargas

        public static implicit operator string(Pluma pluma1)
        {
            string retValue = pluma1.Mostrar();   
            return retValue;
        }

        public static bool operator ==(Pluma p, Tinta t)
        {
            bool retValue = false;
            if ((object)p != null && (object)t != null)
            {
                retValue = (p._tinta == t);
            }
            return retValue;
        }

        public static bool operator !=(Pluma p, Tinta t)
        {
            bool retValue = (!(p == t));
            return retValue;
        }

        /// <summary>
        /// Suma 1 a tinta de la pluma si la tinta de la pluma y la tinta pasada por parametro son del mismo tipo
        /// </summary>
        /// <param name="p"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static Pluma operator +(Pluma p, Tinta t)
        {
            if ((object)p != null && (object)t != null)
            {
                if (p == t && p._cantidad < 100)
                {
                    p._cantidad++;
                }
            }
            return p;
        }

        /// <summary>
        /// Resta 1 a tinta de la pluma si la tinta de la pluma y la tinta pasada por parametro son del mismo tipo
        /// </summary>
        /// <param name="p"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static Pluma operator -(Pluma p, Tinta t)
        {
            if ((object)p != null && (object)t != null)
            {
                if (p == t && p._cantidad > 0)
                {
                    p._cantidad--;
                }
            }
            return p;
        }

        #endregion
    }

}
