using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DepositoDeCocinas
    {
        private int _capacidadMaxima;
        private List<Cocina> _lista;

        public bool Agregar(Cocina c)
        {
            return (this + c);
        }

        public DepositoDeCocinas(int capacidad)
        {
            this._lista = new List<Cocina>();
            this._capacidadMaxima = capacidad;
        }

        private int GetIndice(Cocina c)
        {
            int indice = -1;
            for (int i = 0; i < this._lista.Count; i++)
            {
                if (this._lista[i] == c)
                {
                    indice = i;
                    break;
                }
            }
            return indice;
        }

        public static bool operator +(DepositoDeCocinas d, Cocina a)
        {
            bool retValue = false;
            if (d._capacidadMaxima > d._lista.Count)
            {
                d._lista.Add(a);
                retValue = true;
            }
            return retValue;
        }

        public static bool operator -(DepositoDeCocinas d, Cocina a)
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

        public bool Remover(Cocina c)
        {
            return (this - c);
        }

        public override string ToString()
        {
            string retValue = "CAPACIDAD: " + this._capacidadMaxima + "\n";
            retValue += "Listado de cocinas:\n";
            foreach (Cocina i in this._lista)
            {
                retValue += i.ToString();
                retValue += "\n";
            }
            return retValue;
        }

    }
}
