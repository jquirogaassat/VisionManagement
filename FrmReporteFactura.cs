using BE;
using Microsoft.Reporting.WinForms;
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
    public partial class FrmReporteFactura : Form
    {
        public FrmReporteFactura()
        {
            InitializeComponent();
        }

        private void FrmReporteFactura_Load(object sender, EventArgs e)
        {
            BLL.BLLfactura _blfactu = new BLL.BLLfactura();
            DataTable dt = _blfactu.CargarReporte();

            this.reportViewer1.LocalReport.ReportPath = "ReporteFactu.rdlc";
            ReportDataSource rds = new ReportDataSource("DataSet1", dt);

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
       

    }
}
