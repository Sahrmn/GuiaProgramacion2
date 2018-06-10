using System;
using System.Collections.Generic;
using System.Text;

namespace CentralitaHerencia
{
    public class Centralita
    {
        private  List<Llamada> _listaDeLlamadas;
        protected string _razonSocial;
        
        public float GananciaPorLocal
        {
            get { return this.CalcularGanancia(TipoLlamada.Local); }
        }

        public float GananciaPorProvincial
        {
            get { return this.CalcularGanancia(TipoLlamada.Provincial); }
        }

        public float GananciaTotal
        {
            get { return this.CalcularGanancia(TipoLlamada.Todas); }
        }

        public List<Llamada> Llamadas
        {
            get { return this._listaDeLlamadas; }
        }

        //------------------------------------------------

        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            if (nuevaLlamada != null)
            {
                this._listaDeLlamadas.Add(nuevaLlamada);
            }
        }

        private float CalcularGanancia(TipoLlamada tipo)
        {
            float retValue = 0;
            switch (tipo)
            {
                case TipoLlamada.Local:
                    foreach (Llamada item in this._listaDeLlamadas)
                    {
                        if (item is Local)
                        {
                            retValue += item.CostoLlamada;
                        }
                    }
                    break;
                case TipoLlamada.Provincial:
                    foreach (Llamada item in this._listaDeLlamadas)
                    {
                        if (item is Provincial)
                        {
                            retValue += item.CostoLlamada;
                        }
                    }
                    break;
                case TipoLlamada.Todas:
                    foreach (Llamada item in this._listaDeLlamadas)
                    {
                        retValue += item.CostoLlamada;
                    }
                    break;
                default:
                    break;
            }
            return retValue;
        }

        public Centralita()
        {
            this._razonSocial = "Sin nombre";
            this._listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa):this()
        {
            this._razonSocial = nombreEmpresa;
        }

        //public void Mostrar()
        //{
        //    Console.WriteLine("Razon social: {0}", this._razonSocial);
        //    Console.WriteLine("Ganancia Total: {0}", this.GananciaTotal);
        //    Console.WriteLine("Ganancia Llamadas Locales: {0} \nGanancia Llamadas Provinciales: {1}", this.GananciaPorLocal, this.GananciaPorProvincial);
        //    foreach (Llamada item in this._listaDeLlamadas)
        //    {
        //       // Console.WriteLine(item.Mostrar());
        //    }
        //}

        public void OrdenarLlamadas()
        {
            Llamada aux;
            for (int i = 1; i < this._listaDeLlamadas.Count; i++)
            {
                for (int j = 0; j < this._listaDeLlamadas.Count; j++)
                {
                    if (this._listaDeLlamadas[i].CostoLlamada > this._listaDeLlamadas[j].CostoLlamada)
                    {
                        aux = this._listaDeLlamadas[i];
                        this._listaDeLlamadas[i] = this._listaDeLlamadas[j];
                        this._listaDeLlamadas[j] = aux;
                    }
                }
            }
        }

        public override string ToString()
        {
            string retValue = "---------------------- "+ this._razonSocial +" --------------------\n";
            //retValue += "Razon social: " + this._razonSocial + "\n";
            retValue += "Ganancia Total: " + this.GananciaTotal + "\n";
            //double gLocal = Math.(this.GananciaPorLocal);
            retValue += "Ganancia Llamadas Locales: " + this.GananciaPorLocal + "\nGanancia Llamadas Provinciales: " +  this.GananciaPorProvincial + "\n";
            retValue += "\nLLAMADAS\n";
            foreach (Llamada item in this._listaDeLlamadas)
            {
                retValue += item.ToString();
                retValue += "\n";
            }
            retValue += "\n--------------------------------------------------------\n";
            return retValue;
        }

        public static bool operator ==(Centralita central, Llamada nuevaLlamada)
        {
            bool retValue = false;
            foreach (Llamada item in central._listaDeLlamadas)
            {
                if (nuevaLlamada == item)
                {
                    retValue = true;
                }
            }
            return retValue;
        }

        public static bool operator !=(Centralita central, Llamada nuevaLlamada)
        {
            return !(central == nuevaLlamada);
        }

        public static Centralita operator +(Centralita central, Llamada nuevaLlamada)
        {
            if (central != nuevaLlamada)
            {
                central.AgregarLlamada(nuevaLlamada);
            }
            else
                Console.WriteLine("No se puede agregar. Ya existe en la central...\n");
            return central;
        }

    }
}
