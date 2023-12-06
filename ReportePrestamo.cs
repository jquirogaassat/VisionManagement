using BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.IO;

namespace VisionTFI
{
    public partial class ReportePrestamo : Form
    {
       
        public ReportePrestamo()
        {
            InitializeComponent();
        }

        //private void ReportePrestamo_Load(object sender, EventArgs e)
        //{
        //    // TODO: esta línea de código carga datos en la tabla 'visionManagementDataSet.Prestamo' Puede moverla o quitarla según sea necesario.
        //    this.prestamoTableAdapter.Fill(this.visionManagementDataSet.Prestamo);

           
        //    this.reportViewer1.RefreshReport();

           
        //}


        private void ReportePrestamo_Load(object sender, EventArgs e)
        {
            // TODO: Carga de datos en el reporte
            this.prestamoTableAdapter.Fill(this.visionManagementDataSet.Prestamo);

            // Refrescar el reporte
            this.reportViewer1.RefreshReport();

            // Exportar el reporte a formato PDF
            Warning[] warnings;
            string[] streamIds;
            string mimeType;
            string encoding;
            string filenameExtension;

            byte[] bytes = reportViewer1.LocalReport.Render(
                "PDF", null, out mimeType, out encoding, out filenameExtension,
                out streamIds, out warnings);

            var fechaYhora = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            // Ruta donde se guardará el archivo PDF
            string rutaGuardado = @"C:\Users\jair\Desktop\Reportes VM\ReportePrestamo"+fechaYhora+".pdf";

            // Guardar el archivo PDF en la ruta especificada
            using (FileStream fs = new FileStream(rutaGuardado, FileMode.Create))
            {
                fs.Write(bytes, 0, bytes.Length);
            }
        }


       


    }
}
