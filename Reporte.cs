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
    public partial class Reporte : Form
    {
        BLL.BLLgestionbitacora bitacorabll = new BLL.BLLgestionbitacora();
        public DateTime Desde { get; set; }
        public DateTime Hasta { get; set; }
        public string Usuario { get; set; }
        public string Criticidad { get; set; }
        public bool OrdenarFecha { get; set; }
        public bool OrdernarUsuario { get; set; }
        public bool OrdenarCriticidad { get; set; }
        public bool FechaDesc { get; set; }
        public bool UsuariosDesc { get; set; }
        public bool CriticidadDesc { get; set; }
        
        public Reporte(DateTime desde, DateTime hasta, string usuario, string criticidad, bool ordenarFecha, bool ordernarUsuario, bool ordenarCriticidad, bool fechaDesc, bool usuariosDesc, bool criticidadDesc)
        {
            this.KeyPreview = true;
            InitializeComponent();
            Desde = desde;
            Hasta = hasta;
            Usuario = usuario;
            Criticidad = criticidad;
            OrdenarFecha = ordenarFecha;
            OrdernarUsuario = ordernarUsuario;
            OrdenarCriticidad = ordenarCriticidad;
            FechaDesc = fechaDesc;
            UsuariosDesc = usuariosDesc;
            CriticidadDesc = criticidadDesc;
        }

        private void Reporte_Load(object sender, EventArgs e)
        {
            List<BE.BEgestionbitacora> bitacoras = bitacorabll.Consulta();
            this.reportViewer1.LocalReport.ReportPath = "ReporteBitacora.rdlc";            
            ReportDataSource rds1 = new ReportDataSource("DataSetBitacora", bitacoras);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds1);
            this.reportViewer1.RefreshReport();

        }
    }
}
