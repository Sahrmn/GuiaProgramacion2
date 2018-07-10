using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    [Serializable]
    public class Platano: Fruta
    {
        public string paisOrigen;

        public override bool TieneCarozo
        {
            get { return true; }
        }

        public string Tipo
        {
            get { return "Manzana"; }
        }

        protected override string FrutaToString()
        {
            return base.FrutaToString() + "-" + this.paisOrigen;
        }

        public Platano(float peso, ConsoleColor color, string pais): base(peso, color)
        {
            this.paisOrigen = pais;
        }

        public override string ToString()
        {
            return FrutaToString();
        }

        public Platano():base(0,ConsoleColor.Gray)
        { }
    }
}
