using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno
    {
        private string _apellido;
        private int _dni;
        private string _fotoAlumno;
        private string _nombre;

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

        public string FotoAlumno
        {
            get { return this._fotoAlumno; }
            set { this._fotoAlumno = value; }
        }

        public string Nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }

        public Alumno(string nom, string ap, int dni, string ruta)
        {
            this.Apellido = ap;
            this.Nombre = nom;
            this.Dni = dni;
            this.FotoAlumno = ruta;
        }
    }
}
