using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class Profesor: Persona
    {
        public string titulo;

        public Profesor()
            : this("", "", 0, "")
        { }

        public Profesor(string nom, string ap, int dni, string titulo)
            : base(nom, ap, dni)
        {
            this.titulo = titulo;
        }

        public override string ToString()
        {
            string ret = base.ToString() + " - " + this.titulo;
            return ret;
        }
    }
}
