using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clase08
{
    public class Jugador
    {
        private long _dni;
        private string _nombre;
        private int _partidosJugados;
        private float _promedioGoles;
        private int _totalGoles;

        public float GetPromedioGoles()
        {
            this._promedioGoles = ((float)this._totalGoles / (float)this._partidosJugados);
            this._promedioGoles = (float)Math.Round((double)this._promedioGoles, 2);
            return (float)this._promedioGoles;
        }

        #region Constructores

        private Jugador()
        {
            this._partidosJugados = 0;
            this._promedioGoles = 0;
            this._totalGoles = 0;
            this._nombre = "sin nombre";
            this._dni = 1;
        }

        public Jugador(string nombre)
            : this()
        {
            this._nombre = nombre;
        }

        public Jugador(string nombre, long dni):this(nombre)
        {
            this._dni = dni;
        }

        public Jugador(string nombre, long dni, int totalGoles, int totalPartidos):this(nombre,dni)
        {
            this._totalGoles = totalGoles;
            this._partidosJugados = totalPartidos;
            this.GetPromedioGoles();
        }

        #endregion

        #region Propiedades

        public long Dni 
        { 
            get { return _dni; }
        }

        public string Nombre 
        {
            get { return _nombre; }
            set { _nombre = value; } 
        }

        public int PartidosJugados 
        {
            get { return _partidosJugados; }
            set { _partidosJugados = value; } 
        }

        public int TotalGoles 
        {
            get { return _totalGoles; }
            set { _totalGoles = value; } 
        }

        #endregion

        public string MostrarDatos()
        {
            string retValue = "DNI: " + this._dni + " \nNombre: " + this._nombre + " \nCantidad de partidos jugados: " + this._partidosJugados + " \nPromedio de goles: " + this._promedioGoles + " \nCantidad total de goles: " + this._totalGoles + "\n";
            return retValue;
        }

        #region Sobrecargas

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            bool retValue = false;
            if ((object)j1 != null && (object)j2 != null)
            {
                if (j1._dni == j2._dni)
                {
                    retValue = true;
                }
            }
            return retValue;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1==j2);
        }
        #endregion

    }

    public class Equipo
    {
        private short _cantidadDeJugadores;
        private List<Jugador> _jugadores;
        private string _nombre;

        #region Constructores

        private Equipo()
        {
            _jugadores = new List<Jugador>();
            _cantidadDeJugadores = 5;
            _nombre = "equipo sin nombre";
        }

        public Equipo(short cantJugadores, string nombre):this()
        {
            this._cantidadDeJugadores = cantJugadores;
            this._nombre = nombre;
        }

        #endregion

        #region Sobrecargas

        /// <summary>
        /// Returna false si el jugador ya se encuentra en el equipo, y true si no esta y se agrega
        /// </summary>
        /// <param name="e"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        public static bool operator +(Equipo e, Jugador j)
        {
            bool flag = true;
            int cont = 0;
            if (e._jugadores.Count < e._cantidadDeJugadores)
            {
                cont = e._jugadores.Count;
                for (int i = 0; i < cont; i++)
                {
                    if (e._jugadores[i].Dni == j.Dni)// si flag es false quiere decir que ya esta en el equipo
                    {
                        flag = false;
                        break;
                    }
                }
            }
            else
            {
                flag = false;
            }
            if (flag == true)
            {
                e._jugadores.Add(j);
            }
            return flag;
        }

        public static bool operator -(Equipo e, Jugador j)
        {
            bool flag = false;
            int cont = 0;
            if (e._jugadores.Count > 0)
            {
                cont = e._jugadores.Count;
                for (int i = 0; i < cont; i++)
                {
                    if (e._jugadores[i].Dni == j.Dni)// si flag es false quiere decir que esta en el equipo y puedo eliminarlo
                    {
                        flag = true;
                        break;
                    }
                }
            }
            else
            {
                flag = false;
            }
            if (flag == true)
            {
                e._jugadores.Remove(j);
            }
            return flag;
        }

        #endregion

        public List<Jugador> GetJugadores()
        {
            return this._jugadores;
        }

    }
}
