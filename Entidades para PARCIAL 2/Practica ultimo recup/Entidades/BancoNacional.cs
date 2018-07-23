using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class BancoNacional: Banco
    {
        public string pais;

        public BancoNacional(string nombre, string pais) : base(nombre)
        {
            this.pais = pais;
        }

        public override string Mostrar()
        {
            return "Banco Nacional \n" + this.nombre;
        }

        public override string Mostrar(Banco b)
        {
            string retValue = "//" + b.Mostrar() + " - Pais: " + this.pais;
            return retValue;
        }

        public override string ToString()
        {
            return Mostrar(this);
        }
    }
}
