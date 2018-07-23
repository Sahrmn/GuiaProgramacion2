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
    public class DepositoHeredado : Deposito, ISerializar, IDeserializar
    {
        public DepositoHeredado()
        {
        }

        public bool Xml(string archivo)
        {
            bool retValue = true;
            try
            {
                XmlTextWriter escribir = new XmlTextWriter(archivo, Encoding.UTF8); 
                XmlSerializer ser = new XmlSerializer(typeof(DepositoHeredado));//tipo que se desea serializar
                ser.Serialize(escribir, this);
                escribir.Close();
            }
            catch (Exception e)
            {
                retValue = false;
                Console.WriteLine(e.Message);
            }
            return retValue;
        }

        bool IDeserializar.Xml(string archivo, out DepositoHeredado d)
        {
            bool retValue = true;
            d = null;
            try
            {
                XmlTextReader leer = new XmlTextReader(archivo); 
                XmlSerializer ser = new XmlSerializer(typeof(DepositoHeredado));
                d = (DepositoHeredado)ser.Deserialize(leer); //reemplazo por el objeto a deserializar
                leer.Close();
            }
            catch (Exception e)
            {
                retValue = false;
                Console.WriteLine(e.Message);
            }
            return retValue;
        }
    }
}
