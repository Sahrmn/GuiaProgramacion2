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
        private float thebase;
        private float altura;
         
        public float CalculoArea()
        {
            this.area = this.thebase * this.altura;
            return this.area;
        }

        public float CalculoPerimetro()
        {
            this.perimetro = ((this.thebase + this.altura) * 2);
            return this.perimetro;
        }

        public Rectangulo(Punto vert1, Punto vert3)
        {
            this.vertice1 = vert1;
            this.vertice3 = vert3;
            this.vertice2 = new Punto(this.vertice1.GetX(), this.vertice3.GetY());
            this.vertice4 = new Punto(this.vertice3.GetX(), this.vertice1.GetY());
            this.thebase = (vertice4.GetX() - vertice1.GetX());
            this.altura = (vertice3.GetY() - vertice4.GetY());
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
