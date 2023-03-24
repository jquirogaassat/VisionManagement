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
        BE.BEarticulo articuloBE = new BE.BEarticulo();
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
    }
}
