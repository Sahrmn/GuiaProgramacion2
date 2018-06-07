using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Aula
    {
        private int _numero;
        public List<Persona> _lista;

        public int Numero 
        {
            get { return this._numero; }
            set { this._numero = value; }
        }

        public List<Persona> Listado 
        {
            get { return this._lista; }
        }

        private Aula()
        {
            this._lista = new List<Persona>();
        }

        public Aula(int num): this()
        {
            this._numero = num;
        }

        public override string ToString()
        {
            string ret = "Numero de alumnos: " + this._numero + "\n";
            foreach (Persona item in this._lista)
            {
                ret += item.ToString();
                ret += "\n";
            }
            return ret;
        }
    }
}
