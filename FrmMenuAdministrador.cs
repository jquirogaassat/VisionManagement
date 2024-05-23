using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisionTFI
{
    public partial class FrmMenuAdministrador : Form
    {
        public FrmMenuAdministrador()
        {
            InitializeComponent();
        }

        private void FrmMenuAdministrador_Load(object sender, EventArgs e)
        {
            Focus();
            MostrarAyuda();
        }

        private void MostrarAyuda()
        {

            string ruta = @"C:\Users\Usuario\source\repos\VisionManagement\bin\Debug\VisionManagement- Ayuda en línea- Manual de administrador.pdf";
            try
            {
                string rutaCompleta = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ruta);
                if (System.IO.File.Exists(rutaCompleta))
                {
                    axAcroPDF2.src = rutaCompleta;
                }
                else
                {
                    MessageBox.Show("El pdf no se encuentra");
                    this.Close();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("No se encontro archivo de ayuda. Contactese con el administrador!");
                this.Close();
            }
        }
    }
}
