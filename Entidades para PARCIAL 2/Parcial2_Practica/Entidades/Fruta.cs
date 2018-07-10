﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    [Serializable]
    [XmlInclude(typeof(Manzana))]
    [XmlInclude(typeof(Platano))]
    public abstract class Fruta
    {
        private ConsoleColor _color;
        private float _peso;

        public abstract bool TieneCarozo
        {
            get;
        }

        public Fruta(float peso, ConsoleColor color)
        {
            this._color = color;
            this._peso = peso;
        }

        protected virtual string FrutaToString()
        {
            return this._color + "-" + this._peso;
        }
    }
}
