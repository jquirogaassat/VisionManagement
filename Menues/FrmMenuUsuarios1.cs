﻿using System;
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
    public partial class FrmMenuUsuarios1 : Form
    {
        public FrmMenuUsuarios1()
        {
            InitializeComponent();
        }

        private void FrmMenuUsuarios1_Load(object sender, EventArgs e)
        {
            Focus();
            MostrarAyuda();
        }
        private void MostrarAyuda()
        {

            //C:\Users\Usuario\source\repos\VisionManagement\bin\Debug
            string ruta = @"C:\Users\gozli\source\repos\VisionManagement\bin\Debug\VisionManagement- Ayuda en línea- Manual de usuario.pdf";
            try
            {
                string rutaCompleta = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ruta);
                if (System.IO.File.Exists(rutaCompleta))
                {
                    axAcroPDF1.src = rutaCompleta;
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
