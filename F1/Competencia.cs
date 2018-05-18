using System;
using System.Collections.Generic;
using System.Text;

namespace F1
{
    public class Competencia
    {
        private short _cantidadCompetidores;
        private short _cantidadVueltas;
        private List<AutoF1> _competidores;

        private Competencia()
        {
            this._competidores = new List<AutoF1>();
        }

        public Competencia(short cantidadVueltas, short cantidadCompetidores):this()
        {
            this._cantidadCompetidores = cantidadCompetidores;
            this._cantidadVueltas = cantidadVueltas;
        }

        public string MostrarDatos()
        {
            string retValue = "CANT. DE COMPETIDORES: " + this._cantidadCompetidores;
            retValue += "CANT. DE VUELTAS: " + this._cantidadVueltas + "\n";
            foreach (AutoF1 item in this._competidores)
            {
                retValue += item.MostrarDatos();
                retValue += "\n";
            }
            return retValue;
        }

        public static bool operator -(Competencia c, AutoF1 a)
        {
            return false;
        }

        public static bool operator +(Competencia c, AutoF1 a)
        {
            bool retValue = false;
            if (c._competidores.Count < c._cantidadCompetidores && c != a)
            {
                a.EnCompetencia = true;
                a.VueltasRestantes = c._cantidadVueltas;
                Random ran = new Random();
                a.CantidadDeCombustible = short.Parse(ran.Next(15, 100).ToString());
                c._competidores.Add(a);
                retValue = true;
            }
            return retValue;
        }

        public static bool operator ==(Competencia c, AutoF1 a)
        {
            bool retValue = false;
            foreach (AutoF1 item in c._competidores)
            {
                if (item == a)
                {
                    retValue = true;
                    break;
                }
            }
            return retValue;
        }

        public static bool operator !=(Competencia c, AutoF1 a)
        {
            return !(c == a);
        }

    }
}
