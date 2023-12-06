using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace VisionTFI
{
    public class XmlSerializator
    {
        public static void Serializar(object serializator, string directorio)
        {
            XmlSerializer serializar= new XmlSerializer(serializator.GetType());
            FileStream fstream = File.Open(directorio,FileMode.Create,FileAccess.Write);
            serializar.Serialize(fstream, serializator);
            fstream.Close();
            fstream.Dispose();

        }
        //public static object Deserializar(object serializator, string directorio)
        //{
        //    XmlSerializer serializar = new XmlSerializer(serializator.GetType());
        //    FileStream fstream = File.Open(directorio, FileMode.Create, FileAccess.Read);
        //    serializar.Deserialize(fstream);
        //    fstream.Close();
        //    fstream.Dispose();
        //    return serializar;

        //}

        public static object Deserializar(object serializator, string directorio)
        {
            XmlSerializer serializar = new XmlSerializer(serializator.GetType());
            using (FileStream fstream = File.Open(directorio, FileMode.Open, FileAccess.Read))
            {
                object objetoDeserializado = serializar.Deserialize(fstream);
                return objetoDeserializado;
            }
            
        }

    }
}
