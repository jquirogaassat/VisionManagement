using BE;
using BLL;
using DAL;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisionTFI
{
    public partial class FrmReportePrestamos : Form
    {
        public FrmReportePrestamos()
        {
            InitializeComponent();
            
        }

    
        private void FrmReportePrestamos_Load(object sender, EventArgs e)
        {
            List<BEprestamo> prestamos = CargarReporte();
            this.reportViewer1.LocalReport.ReportPath = "ReportPrestamo.rdlc";            
            ReportDataSource rds1 = new ReportDataSource("DataSet1",prestamos);
            //this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds1);
            this.reportViewer1.RefreshReport();
        }


        private List<BEprestamo> CargarReporte()
        {
            List<BEprestamo> prestamos = new DAL.DALprestamo().CargarReporte();
            List<BEprestamo> prestamosAcargar = new List<BEprestamo>();

            foreach (BEprestamo p in prestamos)
            {              
                BEprestamo prestamo = new BEprestamo
                {
                    IdPrestamo = p.IdPrestamo,
                    Herramienta = p.Herramienta,
                    Cliente = p.Cliente,
                    FechaInicio = p.FechaInicio,
                    FechaDevolucion = p.FechaDevolucion,
                    Estado = p.Estado,
                    Observaciones = p.Observaciones,
                };
                prestamosAcargar.Add(prestamo);
            }

            return prestamos;
        }

       
    }
}
