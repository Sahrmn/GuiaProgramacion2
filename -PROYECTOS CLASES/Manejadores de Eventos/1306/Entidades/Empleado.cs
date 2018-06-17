using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Entidades
{
    public delegate void DelegadoSueldoCero();
    public delegate void DelegadoLimiteSueldo(double sueldo, Empleado em);

    public class Empleado
    {
        public string nombre;
        public string apellido;
        public int dni;
        private double _sueldo;

        public event DelegadoSueldoCero SueldoCero;//creo un evento
        public event DelegadoLimiteSueldo LimiteDeSueldo;

        public double Sueldo 
        {
            get { return this._sueldo; }
            set 
            {
                if (value < 0)
                {
                    SueldoNegativoException e = new SueldoNegativoException();
                }
                else if (value == 0)
                    this.SueldoCero();
                else if (value > 10000)
                    this.LimiteDeSueldo(10000,this);
                else
                    this._sueldo = value; 
            }
        }

        public Empleado(string nom, string ap, int doc)
        {
            this.nombre = nom;
            this.apellido = ap;
            this.dni = doc;
        }

        public override string ToString()
        {
            return this.nombre + " - " + this.apellido + " - " + this.dni;
        }

        public void ManejadorEvento()
        {
            if (this.Sueldo == 0)
            {
                Console.WriteLine("El sueldo es cero!!!");   
                
            }
        }

        public void LimiteSueldo(double limite, Empleado em)
        {
            //if (em._sueldo > limite)
            //{
                Console.WriteLine("El sueldo sobrepasa el limite dado!");    
            //}
        }    

        
    }
}
