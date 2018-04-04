using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesClase06
{
    public class Tempera
    {
        private ConsoleColor _color;
        private string _marca;
        private int _cantidad;

        public Tempera(ConsoleColor color, string marca, int cant)
        {
            this._color = color;
            this._marca = marca;
            this._cantidad = cant;
        }

        private string Mostrar()
        {
            string retValue = "Color: " + this._color + " Marca: " + this._marca + " Cantidad: " + this._cantidad;
            return retValue;
        }

        public static string Mostrar(Tempera t)
        {
            return t.Mostrar();
        }

        //sobrecargas

        public static bool operator ==(Tempera a, Tempera b)
        {
            bool retValue = false;
            if (a._marca == b._marca && a._color == b._color)
            {
                retValue = true;
            }
            return retValue;
        }

        public static bool operator !=(Tempera a, Tempera b)
        {
            return !(a == b);
        }

        public static implicit operator int(Tempera t)
        {
            return t._cantidad;
        }

        public static explicit operator string(Tempera t)
        {
            return t.Mostrar();
        }

        public static Tempera operator +(Tempera t, int cant)
        {
            Tempera retValue = new Tempera(t._color, t._marca, (t._cantidad + cant));
            return retValue;
        }

        public static Tempera operator +(Tempera t1, Tempera t2)
        {
            Tempera retValue = new Tempera(t1._color, t1._marca, t1._cantidad);
            if (t1 == t2)
            {
                retValue = retValue + t2._cantidad;
            }
            return retValue;
        }

    }

    public class Paleta
    {
        private Tempera[] _colores;
        private int _cantidadMaximaColores;

        #region Constructores

        private Paleta():this(5)
        { }

        private Paleta(int cant)
        {
            this._cantidadMaximaColores = cant;
            this._colores = new Tempera[this._cantidadMaximaColores];
        }

        #endregion

        public static implicit operator Paleta(int num)
        {
            Paleta retValue = new Paleta(num);
            return retValue;
        }

        /// <summary>
        /// Muestra cada elemento tempera en Paleta
        /// </summary>
        /// <returns></returns>
        private string Mostrar()
        {
            string retValue = "";
            for (int i = 0; i < this._cantidadMaximaColores; i++)
            {
                if (this._colores.GetValue(i) != null)
                {
                    retValue += this._colores[i];
                }
            }
            //foreach (Tempera t in this._colores)
            //{
            //    retValue += Tempera.Mostrar(t);
            //}
            return retValue;
        }

        public static explicit operator string(Paleta p)
        {
            return p.Mostrar();
        }

        public static bool operator ==(Paleta p, Tempera t)
        {
            bool retValue = false;
            if (t != null)
            {
                for (int i = 0; i < p._cantidadMaximaColores; i++)
                {
                    if (p._colores[i] == t && p._colores.GetValue(i) != null) //getvalue devuelve un tipo objet, 
                    {                                                           //nos evitamos el error de las sobrecargas
                        retValue = true;
                        break;
                    }
                }
            }
            return retValue;
        }

        /// <summary>
        /// Obtiene el primer indice vacio
        /// </summary>
        /// <returns></returns>
        private int ObtenerIndice()
        {
            int retValue = -1;
            for (int i = 0; i < this._cantidadMaximaColores; i++)
            {
                if (this._colores.GetValue(i) == null)
                {
                    retValue = i;
                    break;
                }
            }
            return retValue;
        }

        private int ObtenerIndice(Tempera t)
        {
            int retValue = -1;
            for (int i = 0; i < this._cantidadMaximaColores; i++)
            {
                if (this._colores.GetValue(i) == t)
                {
                    retValue = i;
                    break;
                }
            }
            return retValue;
        }

        /// <summary>
        /// Agrega una tempera a la paleta si esta no existe, si existe suma la cantidad de tempera
        /// </summary>
        /// <param name="p"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static Paleta operator +(Paleta p, Tempera t)
        {
            int indice;
            if (p != null && t != null)
            {
                for (int i = 0; i < p._cantidadMaximaColores; i++)
                {
                    if (p._colores[i] == t)
                    {
                        p._colores[i] = p._colores[i] + t;
                    }
                    else
                    {
                        indice = p.ObtenerIndice();
                        p._colores[indice] = t;
                    }
                }
            }
            return p;
        }

        public static Paleta operator -(Paleta p, Tempera t)
        {
            int resta;
            if (p != null && t != null)
            {
                for (int i = 0; i < p._cantidadMaximaColores; i++)
                {
                    if (p._colores[i] == t)
                    {
                        resta = (int)p._colores[i] - (int)t;
                        if (resta <= 0)
                        {
                            p._colores[i] = null;
                        }
                        else
                        {
                           // p._colores[i] =  RECORDAR ESTABLECER EL VALOR DE CANTIDAD DESPUES DE RESTARLO 
                        }
                    }
                }
            }
            return p;
        }
     // HACER SOBRECARGA DE
        // +(PALETA,PALETA):PALETA
        //SUMA COLORES Y CANTIDADES
    }
}
