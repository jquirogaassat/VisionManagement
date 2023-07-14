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
using BE;
using BLL;

namespace VisionTFI
{
    public partial class Reporte : Form
    {
        BLL.BLLgestionbitacora bitacorabll = new BLL.BLLgestionbitacora();
        BLL.BLLencriptacion encriptadora = new BLLencriptacion();
        BE.BEgestionbitacora bitacoraBE = new BEgestionbitacora();
        public DateTime Desde { get; set; }
        public DateTime Hasta { get; set; }
        public BE.BEusuario Usuario { get; set; }
        public string Criticidad { get; set; }
        public string Orden  { get; set; }
        
        
        public  Reporte()
        {

        }
        public Reporte(DateTime desde, DateTime hasta, BE.BEusuario usuario,  string orden ,string criticidad)
        {
            this.KeyPreview = true;
            InitializeComponent();
            Desde = desde;
            Hasta = hasta;
            Usuario = usuario;
            Criticidad = criticidad;           
            Orden = orden;
        }

        private void Reporte_Load(object sender, EventArgs e)
        {
            //List<BE.BEgestionbitacora> bitacoras = new List<BEgestionbitacora>();
            List<BE.BEgestionbitacora> bitacoras = new BLL.BLLgestionbitacora().Consulta(Desde, Hasta, Usuario, Orden,Criticidad);
          
            this.reportViewer1.LocalReport.ReportPath = "ReporteBitacora.rdlc";
            ValorizarBitacora(bitacoraBE);
            ReportDataSource rds1 = new ReportDataSource("Bitacora", bitacoras);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds1);
            this.reportViewer1.RefreshReport();
        }

        public void ValorizarBitacora(BE.BEgestionbitacora bitacoraBE)
        {
            bitacoraBE.Descripcion= encriptadora.desencriptarAes(bitacoraBE.Descripcion);
        }


    
        private void Reporte_keydown (object sender, KeyEventArgs e)
        {
            bool r = false;
            if(e.KeyCode== Keys.F1)
            {
                r = true;
               
            }
        }
    }
}
