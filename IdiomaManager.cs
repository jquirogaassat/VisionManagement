using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;
using System.ComponentModel;
using System.Windows.Forms;
using System.Resources;
using System.IO;

namespace VisionTFI
{
    public static class IdiomaManager
    {

        public static Dictionary<string, string> info = new Dictionary<string, string>();
        public static event Action IdiomaCambiado;
        private static void Cargar(string archivo)
        {
            info.Clear();
            foreach(string linea in File.ReadLines("lang\\"+archivo))
            {
               // info.Clear();
                if (linea.Contains("="))
                {
                    string[] s= linea.Split(new char[] {'='});
                    info.Add(s[0], s[1]);
                }
            }
        }
        public static void CambiarIdioma(string archivo)
        {
            Properties.Settings config= new Properties.Settings();
            config.lang = archivo;
            config.Save();
            Cargar(archivo);
            IdiomaCambiado?.Invoke();
        }
        public static void CargarIdiomaInicial()
        {
            Properties.Settings config = new Properties.Settings();
            string idioma = string.IsNullOrEmpty(config.lang) ? "es.txt" : config.lang;
            Cargar(idioma);
        }

        public static void Controles(Form f)
        {            
            foreach(string control in info.Keys) 
            {
                try
                {
                    f.Controls[control].Text = info[control];   
                }
                catch (Exception)
                {

                    throw;
                }
                
            }
        }
    }
}
