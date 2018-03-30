using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseCosa
{
    public class Cosa
    {
        public int entero;
        public string cadena;
        public DateTime fecha;

        /// <summary>
        /// Establecer un valor para un atributo de tipo entero de la clase.
        /// </summary>
        /// <param name="a"></param>
        public void EstablecerValor(int a)
        {
            this.entero = a;
        }
        /// <summary>
        /// Establecer un valor para un atributo de tipo string.
        /// </summary>
        /// <param name="cad"></param>
        public void EstablecerValor(string cad)
        {
            this.cadena = cad;
        }
        /// <summary>
        /// Establecer un valor para un atributo de tipo DateTime.
        /// </summary>
        /// <param name="f"></param>
        public void EstablecerValor(DateTime f)
        {
            this.fecha = f;
        }
        /// <summary>
        /// Retorna una cadena de strings con los atributos de la clase.
        /// </summary>
        /// <returns></returns>
        public string Mostrar()
        {
            string cadena;
            cadena = this.entero + "\n" + this.cadena + "\n" + this.fecha;
            return cadena;
        }

        //CONSTRUCTOR
        public Cosa()
        {
            this.entero = 10;
            this.cadena = "sin valor";
            this.fecha = DateTime.Now;
        }
        public Cosa(int a, string b, DateTime c)
        {
            this.entero = a;
            this.cadena = b;
            this.fecha = c;
        }
        public Cosa(int a, string b):this(a)//llamo al constructor con un solo parametro -> setteo las variables con valores default, despues reescribo b
        {
            this.cadena = b;
        }
        public Cosa(int a):this()//llamo al constructor vacio -> setteo las variables con valores default, excepto a
        {
            this.entero = a;
        }
    }
}
