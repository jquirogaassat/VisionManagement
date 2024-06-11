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

namespace VisionTFI
{
    public partial class AdministrarPrestamos : Form , BE.IObserverForm
    {
        private BLL.BLprestamo _prestamoBL = new BLL.BLprestamo();
        public AdministrarPrestamos()
        {
            InitializeComponent();
        }
        private void AdministrarPrestamos_Load(object sender, EventArgs e)
        {
            this.Focus();
            BE.BEcontroladorsesion.GetInstance.Usuario.Agregar(this);
            ActualizarGrillaPrestamos();
        }
        public void Actualizar(BEusuario u)
        {
            throw new NotImplementedException();
        }



        #region Grillas y dgv
        private void ActualizarGrillaPrestamos()
        {
            List<BEprestamo> prestamos = _prestamoBL.Consultar();
            dgv_prestamos.Columns.Clear();
            dgv_prestamos.Columns.Add("idPrestamo", "Prestamo");
            dgv_prestamos.Columns.Add("herramienta", "Herramienta");
            dgv_prestamos.Columns.Add("cliente", "Cliente");
            dgv_prestamos.Columns.Add("fechaInicio", "Fecha de inicio");
            dgv_prestamos.Columns.Add("fechaDevolucion", "Fecha de debvolucion");
            dgv_prestamos.Columns.Add("estado", "Estado");
            dgv_prestamos.Columns.Add("observaciones", "Observaciones");

            int i = 0;

            foreach (BEprestamo p in prestamos)
            {
                dgv_prestamos.Rows.Add();
                dgv_prestamos[0, i].Value = p.IdPrestamo;
                dgv_prestamos[1, i].Value = p.Herramienta.Nombre;
                dgv_prestamos[2, i].Value = p.Cliente.Nombre + "," + p.Cliente.Apellido;
                dgv_prestamos[3, i].Value = p.FechaInicio;
                dgv_prestamos[4, i].Value = p.FechaDevolucion;
                dgv_prestamos[5, i].Value = p.Estado;
                dgv_prestamos[6, i].Value = p.Observaciones;
                i++;

            }

            dgv_prestamos.RowHeadersVisible = false;
            dgv_prestamos.AllowUserToAddRows = false;
            dgv_prestamos.AllowUserToDeleteRows = false;
            dgv_prestamos.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgv_prestamos.MultiSelect = false;
            dgv_prestamos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void dgv_prestamos_MouseClick(object sender, MouseEventArgs e)
        {
            btn_consultar.Enabled = true;
            btn_devolucion.Enabled = true;

            if (dgv_prestamos.SelectedRows.Count > 0)
            {
                var row = dgv_prestamos.SelectedRows[0];
                int id = Int32.Parse(dgv_prestamos.SelectedRows[0].Cells["idPrestamo"].Value.ToString());

                Globa.prestamoBe = _prestamoBL.ConsultarPrestamo(id);
            }
        }
        #endregion


        #region Botones y funcionalidades
        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Hide();
            Globa.tipoProceso = "ALTA";
            NuevoPrestamo nuevoPrestamo = new NuevoPrestamo();
            Globa.menuPrincipal.AbrirFormHijo(nuevoPrestamo);
        }

        private void btn_reporteP_Click(object sender, EventArgs e)
        {
            FrmReportePrestamos reporte = new FrmReportePrestamos();
            Globa.menuPrincipal.AbrirFormHijoMenu(reporte);
        }

        private void btn_serializar_Click(object sender, EventArgs e)
        {
            XmlSerializator.Serializar(_prestamoBL.Consultar(), "Prestamos.xml");
            MessageBox.Show("Serializacion ok!!");
        }

        private void btn_deserializar_Click(object sender, EventArgs e)
        {
            //XmlSerializator.Deserializar(_prestamoBL.Consultar(), "Prestamos.xml");
            //MessageBox.Show("Deserealizacion ok!!");
        }
        #endregion




    }
}
