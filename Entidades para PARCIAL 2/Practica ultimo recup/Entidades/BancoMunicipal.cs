using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class BancoMunicipal : BancoProvincial
    {
        public string municipio;

        public BancoMunicipal(BancoProvincial bp, string municipio) : base((BancoNacional)bp,bp.provincia)
        {
            this.municipio = municipio;
        }

        public override string Mostrar()
        {
            return "Banco Provincial \n" + base.Mostrar();
        }

        public override string Mostrar(Banco b)
        {
            string retValue = b.Mostrar() + " - Municipio: " + this.municipio;
            return retValue;
        }

        public override string ToString()
        {
            return Mostrar(this);
        }
    }
}
