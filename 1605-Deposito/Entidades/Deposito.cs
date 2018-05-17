using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Deposito<T>
    {
        private int _capacidadMaxima;
        private List<T> _lista;

        public bool Agregar(T a)
        {
            return (this + a);
        }

        public Deposito(int capacidad)
        {
            this._lista = new List<T>();
            this._capacidadMaxima = capacidad;
        }

        private int GetIndice(T a)
        {
            int indice = -1;
            for (int i = 0; i < this._lista.Count; i++)
            {
                if (this._lista[i].Equals(a))
                {
                    indice = i;
                    break;
                }
            }
            return indice;
        }

        public static bool operator +(Deposito<T> d, T a)
        {
            bool retValue = false;
            if (d._capacidadMaxima > d._lista.Count)
            {
                d._lista.Add(a);
                retValue = true;
            }
            return retValue;
        }

        public static bool operator -(Deposito<T> d, T a)
        {
            bool retValue = false;
            int indice = d.GetIndice(a);
            if (indice != -1)
            {
                d._lista.Remove(a);
                retValue = true;
            }
            return retValue;
        }

        public bool Remover(T a)
        {
            return (this - a);
        }

        public override string ToString()
        {
            string retValue = "CAPACIDAD: " + this._capacidadMaxima + "\n";
            retValue += "Listado:\n";
            foreach (T i in this._lista)
            {
                retValue += i.ToString();
                retValue += "\n";
            }
            return retValue;
        }
    }
}
