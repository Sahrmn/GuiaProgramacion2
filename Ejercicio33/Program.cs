using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio33
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro unLibro = new Libro();
            string pagina1 = "hola!!!";
            unLibro[0] = pagina1;
            Console.WriteLine(unLibro[0]);

            Console.ReadLine();
        }

        public class Libro
        {
            private List<string> _paginas;

            public Libro()
            {
                this._paginas = new List<string>();
            }

            public string this[int i]
            {
                get
                {
                    if (i < this._paginas.Count)
                    {
                        return this._paginas[i];
                    }
                    else
                        return "";
                }
                set
                {
                    if (i >= this._paginas.Count)
                    {
                        this._paginas.Add(value);
                    }
                    else
                    {
                        this._paginas[i] = value;
                    }
                }
            }
        }
    }
}
