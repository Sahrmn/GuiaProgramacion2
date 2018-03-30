using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio18
{
    class Punto
    {
        private int x;
        private int y;

        public Punto(int a, int b)
        {
            x = a;
            y = b;
        }
        //GETTERS
        public int GetX()
        {
            return this.x;
        }
        public int GetY()
        {
            return this.y;
        }
    }
    class Rectangulo
    {
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;
        private float area;
        private float perimetro;
         

        public float CalculoArea()
        {
            this.area = (Math.Abs) * (); // base * altura
        }

        public float CalculoPerimetro()
        { 
        }

        public void CalculoRectangulo(Punto vert1, Punto vert3)
        {
            this.vertice1 = vert1;
            this.vertice3 = vert3;
            this.vertice2 = new Punto(this.vertice1.GetX(), this.vertice3.GetY());
            this.vertice3 = new Punto(this.vertice3.GetX(), this.vertice1.GetY());
        }

        //GETTERS
        public float GetArea()
        {
            return this.area;
        }
        public float GetPerimetro()
        {
            return this.perimetro;
        }

    }
}
