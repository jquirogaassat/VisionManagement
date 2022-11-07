using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Configuration;

namespace DAL
{
    public class DALconexion
    {
        public bool Comprobar()
        {
            SqlHelper sqlHelper= new SqlHelper();
            return sqlHelper.comprobarConexion();
        }

        public void cambiar (string cadena)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);    

            foreach(XmlElement elemento in xmlDoc.DocumentElement )
            {
                if(elemento.Name.Equals("connectionStrings"))
                {
                    foreach(XmlNode node in elemento.ChildNodes)
                    {
                        if (node.Attributes[0].Value == "local")
                            node.Attributes[1].Value = cadena;
                    }
                }
            }
            xmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            ConfigurationManager.RefreshSection("connectionStrings");
        }
    }
}
