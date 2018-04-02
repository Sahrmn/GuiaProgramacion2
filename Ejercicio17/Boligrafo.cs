using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio17
{
    class Boligrafo
    {
        public static short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public ConsoleColor GetColor()
        {
            return this.color;
        }
        public short GetTinta()
        {
            return tinta;
        }
        public void Recargar()
        {
            this.tinta = 100;
        }
        /// <summary>
        /// Devuelve false si no hay tinta y true si hay por lo menos 1 de tinta
        /// </summary>
        /// <param name="tint"></param>
        /// <returns></returns>
        private bool SetTinta(short tint)
        {
            bool resp = true;
            if (tint <= 0)
            {
                resp = false;
            }
            return resp;
        }
        
        /// <summary>
        /// Resta la tinta gastada y devuelve un string con la cantidad de tinta que se pudo usar
        /// </summary>
        /// <param name="gasto"></param>
        /// <param name="dibujo"></param>
        /// <returns></returns>
        public bool Pintar(short gasto, out string dibujo)
        {
            bool resp = true;
            Console.ForegroundColor = color;
            dibujo = "";

            for (int i = 0; i < gasto; i++)
            {
                if (SetTinta(GetTinta()) == false)
                {
                    Console.WriteLine("Tinta insuficiente");
                    resp = false;
                    break;
                }
                else
                {
                    dibujo += "*";
                }
                this.tinta--;
            }
            return resp;
        }

        // CONSTRUCTORES
        public Boligrafo()
        {
            this.tinta = 100;
        }
        public Boligrafo(short cantidadTinta)
        {
            this.tinta = cantidadTinta;
            if (cantidadTinta > Boligrafo.cantidadTintaMaxima)
            {
                this.tinta = 100;
            }
        }
        public Boligrafo(short cantidadTinta, ConsoleColor color1):this(cantidadTinta)
        {
            this.color = color1;
        }
    }
}
