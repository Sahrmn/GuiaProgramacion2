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
    [XmlInclude(typeof(DepositoHeredado))]
    public class Deposito
    {
        public Producto[] productos;

        public Deposito():this(3)
        {
        }

        public Deposito(int cantidad)
        {
            this.productos = new Producto[cantidad];
            for (int i = 0; i < this.productos.Length; i++)
            {
                this.productos[i] = new Producto("", 0);
            }
        }

        public static Producto[] operator +(Deposito d1, Deposito d2)
        {
            List<Producto> prod = new List<Producto>();
            bool flag = false;
            int ultimoAgregado = 0;
            prod.Add(d1.productos[0]);
            for (int i = 0; i < d1.productos.Length; i++)
            {
                for (int j = i+1; j < d1.productos.Length; j++)
                {
                    if (prod[i].nombre == d1.productos[j].nombre)
                    {
                        prod[i].stock += d1.productos[j].stock;
                        ultimoAgregado = j;
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                {
                    prod.Add(d1.productos[ultimoAgregado + 1]);
                    ultimoAgregado++;
                    flag = false;
                }
            }

            flag = false;

            for (int i = 0; i < d2.productos.Length; i++)
            {
                for (int j = i + 1; j < d2.productos.Length; j++)
                {
                    if (prod[i].nombre == d2.productos[j].nombre)
                    {
                        prod[i].stock += d2.productos[j].stock;
                        ultimoAgregado = j;
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                {
                    prod.Add(d2.productos[ultimoAgregado + 1]);
                    ultimoAgregado++;
                    flag = false;
                }
            }
            Producto[] nuevoArray = prod.ToArray();
            return nuevoArray;
        }
    }
}
