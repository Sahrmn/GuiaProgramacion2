using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DepositoDeAutos
    {
        private int _capacidadMaxima;
        private List<Auto> _lista;

        public bool Agregar(Auto a)
        {
            return (this + a);
        }

        public DepositoDeAutos(int capacidad)
        {
            this._lista = new List<Auto>();
            this._capacidadMaxima = capacidad;
        }

        private int GetIndice(Auto a)
        {
            int indice = -1;
            for (int i = 0; i < this._lista.Count; i++)
            {
                if (this._lista[i] == a)
                {
                    indice = i;
                    break;
                }
            }
            return indice;
        }

        public static bool operator +(DepositoDeAutos d, Auto a)
        {
            bool retValue = false;
            if (d._capacidadMaxima > d._lista.Count)
            {
                d._lista.Add(a);
                retValue = true;
            }
            return retValue;
        }

        public static bool operator -(DepositoDeAutos d, Auto a)
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

        public bool Remover(Auto a)
        {
            return (this - a);
        }

        public override string ToString()
        {
            string retValue = "CAPACIDAD: " + this._capacidadMaxima + "\n";
            retValue += "Listado de autos:\n";
            foreach (Auto i in this._lista)
            {
                retValue += i.ToString();
                retValue += "\n";
            }
            return retValue;
        }

    }
}
