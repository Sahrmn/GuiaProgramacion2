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
    public delegate void CajonDelegado();

    [Serializable]
    public class Cajon<T>: ISerializable
    {
        private int _capacidad;
        private List<T> _frutas;
        private float _precioUnitario;
        private string _rutaArchivo;

        public event CajonDelegado EventoPrecio;

        public List<T> Frutas
        {
            get { return this._frutas; }
        }

        public float PrecioTotal
        {
            get
            {
                float precioT = this._frutas.Count * this._precioUnitario;
                if (precioT > 25)
                {
                    this.EventoPrecio();//recordar agregar el metodo al evento
                }
                return precioT;
            }
        }

        public string RutaArchivo
        {
            get { return this._rutaArchivo; }
            set { this._rutaArchivo = value; }
        }

        public Cajon()
        {
            this._frutas = new List<T>();
            //this._rutaArchivo = "CajonSerializable.xml";
            //this.EventoPrecio += new CajonDelegado(ImprirmiEnArchivo);
        }

        public Cajon(int capacidad):this()
        {
            this._capacidad = capacidad;
            this.EventoPrecio += new CajonDelegado(ImprirmiEnArchivo);
        }

        public Cajon(int capacidad, float precio):this(capacidad)
        {
            this._precioUnitario = precio;
        }

        public static Cajon<T> operator +(Cajon<T> c, T f)
        {
            if (c != null && f != null)
            {
                if (c._capacidad >= 1)
                {
                    c._frutas.Add(f);
                }
                else
                {
                    CajonLlenoException e = new CajonLlenoException("No hay mas capacidad en el cajon.");
                    throw e;
                }
            }
            return c;
        }

        public override string ToString()
        {
            string retValue = "CAJON\nCapacidad: " + this._capacidad + "\nCantidad de Frutas: " + this._frutas.Count + "\n";
            retValue += "Precio Total: " + this.PrecioTotal + "\n";
            foreach (T item in this._frutas)
            {
                retValue += item.ToString();
                retValue += "\n";
            }
            return retValue;
        }

        public bool DeserializarXML()
        {
            bool retValue = true;
            Cajon<T> obj = null;
            try
            {
                XmlTextReader leer = new XmlTextReader(this.RutaArchivo);
                XmlSerializer ser = new XmlSerializer(typeof(Cajon<T>));
                obj = (Cajon<T>)ser.Deserialize(leer);
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
                XmlSerializer ser = new XmlSerializer(typeof(Cajon<T>));
                ser.Serialize(escribir, this);
                escribir.Close();
            }
            catch(InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
                retValue = false;
            }
            return retValue;
        }

        public void ImprirmiEnArchivo()
        {
            try
            {
                StreamWriter escribe = new StreamWriter("InfoCajon.txt", true);
                string contenido = DateTime.Now.ToString();
                contenido += " Precio Total: " + (this._frutas.Count * this._precioUnitario);
                escribe.WriteLine(contenido);
                escribe.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
