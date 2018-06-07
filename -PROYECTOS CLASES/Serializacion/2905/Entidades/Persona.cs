using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace Entidades
{
    [Serializable]
    [XmlInclude(typeof(Alumno))] // deben estar incluidos las clases hijas
    [XmlInclude(typeof(Profesor))]
    public abstract class Persona
    {
        protected string _nombre;
        protected string _apellido;
        protected int _dni;

        public Persona(string nom, string ap, int dni)
        {
            this._apellido = ap;
            this._nombre = nom;
            this._dni = dni;
        }

        public string Nombre 
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }

        public string Apellido
        {
            get { return this._apellido; }
            set { this._apellido = value; }
        }

        public int Dni
        {
            get { return this._dni; }
            set { this._dni = value; }
        }

        public override string ToString()
        {
            string ret = this._apellido + " - " + this._nombre + " - " + this._dni;
            return ret;
        }

    }
}
