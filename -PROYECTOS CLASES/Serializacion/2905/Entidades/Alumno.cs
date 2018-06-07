using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class Alumno: Persona
    {
        public int legajo;

        public Alumno():this("","",0,0)
        { }

        public Alumno(string nom, string ap, int dni, int leg)
            : base(nom, ap, dni)
        {
            this.legajo = leg;
        }

        public override string ToString()
        {
            string ret = base.ToString() + " - " + this.legajo;
            return ret;
        }
    }
}
