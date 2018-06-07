using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public class XML<T>
    {
        public static bool GuardarXML(string path, T lista)// falta serializar lista
        {
            bool retValue = true;
            try
            {
                XmlTextWriter escribir = new XmlTextWriter(path, Encoding.UTF8);
                XmlSerializer seri = new XmlSerializer(lista.GetType());
                seri.Serialize(escribir, lista);
                escribir.Close();
            }
            catch
            {
                retValue = false;
            }
            return retValue;
        }

        public static bool LeerXML(string path, out T coso)
        {
            bool retValue = false;
            coso = default(T);
            try
            {
                XmlTextReader leer = new XmlTextReader(path);
                XmlSerializer seri = new XmlSerializer(typeof(T));
                
                coso = (T)seri.Deserialize(leer);
                leer.Close();
                retValue = true;
            }
            catch
            {
                retValue = false;
            }
            return retValue;
        }

    }
}
