using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.Xml;

namespace SerializacionXml2
{
    class Program
    {
        public const string FILE_NAME="C:\\DatosLista.xml";

        static void Main(string[] args)
        {
            /**************************
             * con Serializador Xml   *
             * para n objetos de tipo *
             * Dato                   *
             * ************************/

            //Creo un objeto de tipo Lista
            Lista listaDato = new Lista();
            
            //Declaro una variable de tipo Lista
            Lista listaDatoXML;

            char rta;

            do
            {
                //Creo un objeto de tipo Dato
                Dato aux = new Dato();
                
                Console.WriteLine("Ingrese Nombre: ");
                aux.nombre = Console.ReadLine();

                Console.WriteLine("Ingrese edad: ");
                aux.edad = int.Parse(Console.ReadLine());

                // Se agrega un item a la lista
                listaDato.Items.Add(aux);

                Console.WriteLine("Continua??: ");
                rta = char.Parse(Console.ReadLine());

            } while (rta == 's');

            Console.WriteLine("Preparado para serializar {0} objetos....",listaDato.Items.Count);
            Console.ReadLine();

            try
            {
                using (XmlTextWriter writer = new XmlTextWriter("C:\\DatosLista.xml", 
                                                                System.Text.Encoding.UTF8))
                {
                    XmlSerializer ser = new XmlSerializer((typeof(Lista)));
                    ser.Serialize(writer, listaDato);
                }

                Console.WriteLine("Objetos serializados con exito en {0}", FILE_NAME);
                Console.ReadLine();

                Console.WriteLine("Deserializando...");
                Console.ReadLine();
                Console.Clear();

                using (XmlTextReader reader = new XmlTextReader(FILE_NAME))
                {
                    XmlSerializer ser = new XmlSerializer((typeof(Lista)));

                    listaDatoXML = (Lista)ser.Deserialize(reader);
                }

                //Se crea un array de tipo Dato con la misma cantidad 
                //de elementos que la lista
                Dato[] vec = new Dato[listaDatoXML.Items.Count];

                //El metodo 'CopyTo()' copia toda la lista en un array  
                listaDatoXML.Items.CopyTo(vec);

                //Muestro los datos contenidos en la lista
                for (int i = 0; i < listaDatoXML.Items.Count; i++)
                {
                    Console.WriteLine(vec[i].ToString());
                }

                Console.WriteLine("Ordeno la lista....");
                Console.ReadLine();

                //Utilizo el m�todo Sort para ordenar la lista gen�rica
                listaDatoXML.Items.Sort();

                //Muestro los datos contenidos en la lista
                foreach (Dato miDato in listaDatoXML.Items)
                {
                    Console.WriteLine(miDato.ToString());
                }

                Console.ReadLine();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Error al Serializar/Deserializar los Datos");
            }

            finally
            {
                Console.WriteLine("Saliendo del programa...");
                Console.ReadLine();
            }
        }
    }
}
