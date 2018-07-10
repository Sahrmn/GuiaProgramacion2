using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    [Serializable]
    public class Manzana: Fruta, ISerializable
    {
        public string distribuidora;
        private string _rutaArchivo;

        public override bool TieneCarozo
        {
            get { return false; }
        }

        public string Tipo
        {
            get { return "Platano"; }
        }

        public string RutaArchivo
        {
            get { return this._rutaArchivo; }
            set { this._rutaArchivo = value; }
        }

        protected override string FrutaToString()
        {
            return base.FrutaToString() + "-" + this.distribuidora;
        }

        public Manzana():base(0,ConsoleColor.Gray)
        {
        }

        public Manzana(float peso, ConsoleColor color, string distribuidora): base(peso, color)
        {
            this.distribuidora = distribuidora;
            this.RutaArchivo = "ManzanaSerializable.xml";
        }

        public override string ToString()
        {
            return FrutaToString();
        }

        public bool DeserializarXML()
        {
            bool retValue = true;
            Manzana obj = null;//verificar si devuelve el objeto correctamente
            try
            {
                XmlTextReader leer = new XmlTextReader(this.RutaArchivo); 
                XmlSerializer ser = new XmlSerializer(typeof(Manzana));
                obj = (Manzana)ser.Deserialize(leer); 
                leer.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                retValue = false;
            }
            return retValue;
        }

        public bool SerializarXML()
        {
            bool retValue = true;
            try
            {
                XmlTextWriter escribir = new XmlTextWriter(this.RutaArchivo, Encoding.UTF8); 
                XmlSerializer ser = new XmlSerializer(typeof(Manzana));
                ser.Serialize(escribir, this);
                escribir.Close();
            }
            catch 
            {
                retValue = false;
                //Console.WriteLine(e.Message);
            }
            return retValue;
        }
    }
}
