using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class Producto
    {
        public string nombre;
        public int stock;

        public Producto(string nom, int stock)
        {
            this.nombre = nom;
            this.stock = stock;
        }

        public Producto() { }
    }
}
