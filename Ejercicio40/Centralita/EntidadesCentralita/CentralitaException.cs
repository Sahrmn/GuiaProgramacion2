using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesCentralita
{
    public class CentralitaException:Exception
    {
        private string _nombreClase;
        private string _nombreMetodo;

        public string NombreClase
        {
            get { return this._nombreClase; }
        }

        public string NombreMetodo
        {
            get { return this._nombreMetodo; }
        }

        public CentralitaException(string mensaje, string clase, string metodo)
        {
            this._nombreClase = clase;
            this._nombreMetodo = metodo;
        }

        public CentralitaException(string mensaje, string clase, string metodo, Exception innerException)
        {

        }

        
    }
}
