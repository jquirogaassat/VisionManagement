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

namespace VisionTFI
{
    public partial class ReportePrestamo : Form
    {
        BLL.BLprestamo _prestamoBL = new BLL.BLprestamo();
        public ReportePrestamo()
        {
            InitializeComponent();
        }

        private void ReportePrestamo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'visionManagementDataSet.Prestamo' Puede moverla o quitarla según sea necesario.
            this.prestamoTableAdapter.Fill(this.visionManagementDataSet.Prestamo);

            //List<BEprestamo> prestamos = _prestamoBL.Consultar();
            //this.reportViewer1.LocalReport.ReportPath = "ReporteFactura.rdlc";           
            //ReportDataSource rds1 = new ReportDataSource("Prestamo",prestamos);
            //this.reportViewer1.LocalReport.DataSources.Clear();
            //this.reportViewer1.LocalReport.DataSources.Add(rds1);
            this.reportViewer1.RefreshReport();

           // this.reportViewer1.RefreshReport();
        }
    }
}
