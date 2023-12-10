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
       

        public static Object Deserializar <T>(string directorio)
        {
            XmlSerializer serializar = new XmlSerializer(typeof(T));
            FileStream fStream = File.Open(directorio, FileMode.Open);
            Object objetoDeserializado = serializar.Deserialize(fStream);
            fStream.Close();
            fStream.Dispose();
            return objetoDeserializado;

            //XmlSerializer serializar = new XmlSerializer(serializator.GetType());
            //using (FileStream fstream = File.Open(directorio, FileMode.Open, FileAccess.Read))
            //{
            //    object objetoDeserializado = serializar.Deserialize(fstream);
            //    return objetoDeserializado;
            //}
            
        }

    }
}
