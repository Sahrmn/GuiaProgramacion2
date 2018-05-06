using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrestamosPersonales;

namespace EntidadFinanciera
{
    public class Financiera
    {
        private List<Prestamo> _listaDePrestamos;
        private string _razonSocial;

        public float InteresesEnDolares
        {
            get {
                return this.CalcularInteresGanado(TipoDePrestamo.Dolares); }
        }

        public float InteresesEnPesos
        {
            get { return this.CalcularInteresGanado(TipoDePrestamo.Pesos); }
        }

        public float InteresesTotales
        {
            get { return this.CalcularInteresGanado(TipoDePrestamo.Todos); }
        }

        public List<Prestamo> ListaDePrestamos
        {
            get { return this._listaDePrestamos; }
        }

        public string RazonSocial
        {
            get { return this._razonSocial; }
        }

        private float CalcularInteresGanado(TipoDePrestamo tipoPrestamo)
        {
            float retValue = 0;
            switch (tipoPrestamo)
            { 
                case TipoDePrestamo.Todos:
                    foreach (Prestamo item in this._listaDePrestamos)
                    {
                        if (item is PrestamoDolar)
                        {
                            retValue += ((PrestamoDolar)item).Interes;
                        }
                        else
                            retValue += ((PrestamoPesos)item).Interes;
                    }
                    break;
                case TipoDePrestamo.Dolares:
                    foreach (Prestamo item in this._listaDePrestamos)
                    {
                        if (item is PrestamoDolar)
                        {
                            retValue += ((PrestamoDolar)item).Interes;
                        }
                    }
                    break;
                case TipoDePrestamo.Pesos:
                    foreach (Prestamo item in this._listaDePrestamos)
                    {
                        if (item is PrestamoPesos)
                        {
                            retValue += ((PrestamoPesos)item).Interes;
                        }
                    }
                    break;
            }
            return retValue;
        }

        public static explicit operator string(Financiera financiera)
        {
            string retValue = "Razon Social: " + financiera._razonSocial;
            retValue += "-- Intereses Totales Ganados: " + financiera.InteresesTotales;
            retValue += "-- Intereses Prestamos En Pesos: " + financiera.InteresesEnPesos;
            retValue += "-- Intereses Prestamos En Dolares: " + financiera.InteresesEnDolares;
            retValue += "--\n PRESTAMOS\n";
            //financiera.OrdenarPrestamos();
            foreach (Prestamo item in financiera._listaDePrestamos)
            {
                retValue += item.Mostrar();
                retValue += "\n";
            }
            return retValue;
        }

        private Financiera()
        {
            this._listaDePrestamos = new List<Prestamo>();
        }

        public Financiera(string razonSocial):this()
        {
            this._razonSocial = razonSocial;
        }

        public static string Mostrar(Financiera financiera)
        {
            return (string)financiera;
        }

        public void OrdenarPrestamos()
        {
            Prestamo a;

            for (int i = 1; i < this._listaDePrestamos.Count; i++)
            {
                for (int j = 0; j < this._listaDePrestamos.Count; j++)
                {
                    if (DateTime.Compare(this._listaDePrestamos[i].Vencimiento,this._listaDePrestamos[j].Vencimiento) > 0)
                    {
                        a = this._listaDePrestamos[i];
                        this._listaDePrestamos[i] = this._listaDePrestamos[j];
                        this._listaDePrestamos[j] = a;
                    }
                }
            }
        }

        /// <summary>
        /// Devuelve true si el prestamo ya existe en la financiera
        /// </summary>
        /// <param name="financiera"></param>
        /// <param name="prestamo"></param>
        /// <returns></returns>
        public static bool operator ==(Financiera financiera, Prestamo prestamo)
        {
            bool retValue = false;
            for (int i = 0; i < financiera._listaDePrestamos.Count; i++)
            {
                if (financiera._listaDePrestamos[i] == prestamo)
                {
                    retValue = true;
                    break;
                }
            }
            return retValue;
        }

        public static bool operator !=(Financiera financiera, Prestamo prestamo)
        {
            return !(financiera == prestamo);
        }

        public static Financiera operator +(Financiera financiera, Prestamo prestamoNuevo)
        {
            if (!(financiera == prestamoNuevo))
            {
                financiera._listaDePrestamos.Add(prestamoNuevo);
            }
            return financiera;
        }
    }
}
