using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BLL;

namespace VisionTFI
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string archivos = new Properties.Settings().lang;
            string[] listaArchivos = archivos.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string archivo in listaArchivos)
            {
                // Quitar posibles espacios extra y cambiar el idioma por archivo
                IdiomaManager.CambiarIdioma(archivo.Trim());
            }

           // IdiomaManager.CambiarIdioma(new Properties.Settings().lang);
            IdiomaManager.CargarIdiomaInicial();
            Application.Run(new Ingreso());
        }
    }
}
