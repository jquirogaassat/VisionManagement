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
    public partial class GestionarArticulo : Form , BE.IObserverForm
    {
        BLL.BLLarticulo articuloBLL = new BLL.BLLarticulo();
       // BE.BEarticulo articuloBE = new BE.BEarticulo();
        BE.BEgestionbitacora bitacoraBE = new BEgestionbitacora();

        public GestionarArticulo()
        {
            InitializeComponent();
        }

        public void Actualizar(BEusuario u)
        {
            throw new NotImplementedException();
        }

        private void GestionarArticulo_Load(object sender, EventArgs e)
        {
            Focus();
            BE.BEcontroladorsesion.GetInstance.Usuario.Agregar(this);
            ActualizarGrillaArticulos();

        }

        private void ActualizarGrillaArticulos()
        {
            List<BE.BEarticulo> articulos = new List<BEarticulo>();
            articulos = articuloBLL.Listar();

            dg_articulo.DataSource = articulos;

            dg_articulo.RowHeadersVisible = false;
            dg_articulo.AllowUserToAddRows = false;
            dg_articulo.AllowUserToDeleteRows = false;
            dg_articulo.EditMode = DataGridViewEditMode.EditProgrammatically;
            dg_articulo.MultiSelect = false;
            dg_articulo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg_articulo.Columns[4].Visible = false;

            dg_articulo.Columns[0].HeaderText = "Nombre";
            dg_articulo.Columns[1].HeaderText = "Color";
            dg_articulo.Columns[2].HeaderText= "Origen";
            dg_articulo.Columns[3].HeaderText = "Cantidad";
            dg_articulo.Columns[5].HeaderText = "Precio";
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Globa.tipoProceso = "ALTA";
            ABMarticulos aBMarticulos = new ABMarticulos();
            Globa.menuPrincipal.AbrirFormHijo(aBMarticulos);
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Hide();

        }
      

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Globa.tipoProceso = "MODIFICACION";
            ABMarticulos aBMarticulos =new ABMarticulos();
            Globa.menuPrincipal.AbrirFormHijo(aBMarticulos);
        }

        private void dg_articulo_MouseClick_1(object sender, MouseEventArgs e)
        {
            var row = dg_articulo.SelectedRows[0];
            Globa.articuloBE = (BE.BEarticulo)row.DataBoundItem;
        }

        private void btn_quitar_Click(object sender, EventArgs e)
        {
            var row = dg_articulo.SelectedRows[0];
            BE.BEarticulo articuloBE = (BE.BEarticulo)row.DataBoundItem;
            articuloBLL.Baja(articuloBE);
            ActualizarGrillaArticulos();
            MessageBox.Show("Articulo eliminado!");
        }
    }
}
