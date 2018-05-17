using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Contabilidad<T,U> 
        where T: Documento
        where U: Documento, new()
    {
        public List<T> _egresos;
        public List<U> _ingresos;

        // para inicializar atributos genericos uso -> default(T)

        public Contabilidad()
        {
            this._egresos = new List<T>();
            this._ingresos = new List<U>();
        }

        public static Contabilidad<T, U> operator +(Contabilidad<T, U> c, T egreso)
        {
            if (egreso != null)
            {
                c._egresos.Add(egreso);
            }
            return c;
        }

        public static Contabilidad<T, U> operator +(Contabilidad<T, U> c, U ingreso)
        {
            if (ingreso != null)
            {
                c._ingresos.Add(ingreso);
            }
            return c;
        }
    }
}
