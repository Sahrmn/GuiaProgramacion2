using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador
    {
        protected string _nombre;
        protected string _apellido;
        public enum EPuesto { Arquero, Defensa, Medio, Delantero };
        protected EPuesto _puesto;

        public string Nombre 
        {
            get { return this._nombre; }
        }

        public string Apellido 
        {
            get { return this._apellido; } 
        }

        public EPuesto Puesto
        {
            get { return this._puesto; }
        }

        public Jugador(string nombre, string apellido, EPuesto puesto)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._puesto = puesto;
        }

        public override string ToString()
        {
            string retValue = this._nombre + " - " + this._apellido + " - " + this._puesto;
            return retValue;
        }

        /// <summary>
        /// Verifica que exista el jugador ingresado, si existe devuelve true y en el out el jugador encontrado, si no lo encuentra retorna false y el jugador =  null
        /// </summary>
        /// <param name="path"></param>
        /// <param name="jug"></param>
        /// <param name="jug2"></param>
        /// <returns></returns>
        public static bool TraerUno(string path, Jugador jug, out Jugador jug2)
        {
            bool retValue = false;
            string contenido = "";
            //mi modo
            jug2 = null;
            string j = jug.ToString().Trim();
            if (AdministradorDeArchivos.Leer(path, out contenido))
            {
                string[] vector = contenido.Split('\n');
                foreach (string item in vector)
                {
                    string i = item;
                    string[] x = i.Split('\r');
                    if (x[0] == j)
                    {
                        jug2 = jug;
                        retValue = true;
                        break;
                    }
                }
            }
            //modo rebuscado
            //if (AdministradorDeArchivos.Leer(path, out contenido)) 
            //{
            //    string[] vector = contenido.Split('\n');
            //    foreach (string item in vector)
            //    {
            //        string[] cadenaJug = item.Split('-');
            //        if (jug.Nombre == cadenaJug[0] && jug.Apellido == cadenaJug[1] && jug.Puesto == Enum.Parse(typeof(EPuesto), cadenaJug[2])
            //        {
            //                   jug2 = new Jugador((cadenaJug[0]), (cadenaJug[1]), (Enum.Parse(typeof(EPuesto), cadenaJug[2]));
            //        }
            //    }
            //}
            return retValue;
        }
    }
}
