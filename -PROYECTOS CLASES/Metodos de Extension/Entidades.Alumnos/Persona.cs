using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Externa;

namespace Entidades.Alumnos
{
    public class Persona: PersonaExterna
    {
        //protected string _nombre;
        //protected string _apellido;
        //protected int _edad;
        //protected ESexo _sexo;

        public string Nombre 
        {
            get { return this._nombre; }
        }

        public string Apellido
        {
            get { return this._apellido; }
        }

        public int Edad
        {
            get { return this._edad; }
        }

        public Externa.ESexo Sexo
        {
            get { return this._sexo; }
        }

        public Persona(string nombre, string apellido, int edad, Externa.ESexo sexo): base(nombre, apellido, edad, sexo)
        {
            //this._nombre = nombre;
            //this._apellido = apellido;
            //this._edad = edad;
            //this._sexo = sexo;
        }

        public Persona(string nombre, string apellido, Externa.ESexo sexo): base(nombre, apellido, 0, sexo)
        {
        }

        public override string ToString()
        {
            return this.Apellido + " - " + this.Nombre + " - " + this.Edad + " - " + this.Sexo;
        }
    }
}
