using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace VisionTFI
{
    public static class Idioma
    {
        public static Dictionary<string, string> info = new Dictionary<string, string>();

        public static void Cargar(string archivo)
        {
            foreach (string linea in File.ReadLines("lang//" + archivo))
            {
               info.Clear();
                if (linea.Contains("="))
                {
                    string[] parts = linea.Split(new char[] { '=' });
                    info.Add(parts[0], parts[1]);
                }
            }
        }
        public static void CambiarIdioma(string archivo)
        {
            Properties.Settings config = new Properties.Settings();
            config.lang = archivo;
            config.Save();
            Cargar(archivo);
        }

        public static void controles(Form f)
        {
             foreach (string c in info.Keys)
            {
                try
                {
                    f.Controls[c].Text = info[c];
                }
                catch (Exception e)
                {


                }

            }

        }
    }
}
