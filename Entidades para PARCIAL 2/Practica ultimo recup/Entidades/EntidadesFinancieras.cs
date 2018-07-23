using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public delegate void DelegadoEntidadesF(object sender, EventArgs e);

    public class EntidadesFinancieras<T>
    {
        public List<T> _elementos;
        public int _capacidad;

        public event DelegadoEntidadesF ElementosParesEvent;

        private EntidadesFinancieras()
        {
            this._elementos = new List<T>();
        }

        public EntidadesFinancieras(int capacidad):this()
        {
            if (capacidad <= 0)
            {
                this._capacidad = 1;
            }
            else
            {
                this._capacidad = capacidad;
            }
        }

        public bool Add(T e)
        {
            EventArgs ev = new EventArgs();
            bool retValue = false;
            if (e != null && this._capacidad >= 1)
            {
                this._elementos.Add(e);
                this._capacidad--;
                if (this._elementos.Count % 2 == 0)
                {
                    this.ElementosParesEvent(e, ev);
                }
                retValue = true;
            }
            return retValue;
        }

        public override string ToString()
        {
            string retValue = "Capacidad: " + this._capacidad + "\n";
            foreach (T item in this._elementos)
            {
                retValue += item.ToString();
                retValue += "\n";
            }
            return retValue;
        }
    }
}
