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
    public partial class GestionarSocio : Form , BE.IObserverForm
    {

        BLL.BLLcliente clienteBLL = new BLL.BLLcliente();
        public GestionarSocio()
        {
            InitializeComponent();
        }

        public void Actualizar(BEusuario u)
        {
            throw new NotImplementedException();
        }

        public void ActualizarClientes()
        {
            IList<BE.BEcliente> clientes = new List<BE.BEcliente>();

            clientes = clienteBLL.Listar();

            dg_clientes.DataSource = clientes;

            dg_clientes.RowHeadersVisible = false;
            dg_clientes.AllowUserToAddRows = false;
            dg_clientes.AllowUserToDeleteRows = false;
            dg_clientes.EditMode = DataGridViewEditMode.EditProgrammatically;
            dg_clientes.MultiSelect = false;
            dg_clientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            Globa.tipoProceso = "Alta";
            ABMcliente aBMclienteAlta= new ABMcliente();
            Hide();
            Globa.menuPrincipal.AbrirFormHijoMenu(aBMclienteAlta);
        }

        private void GestionarSocio_Load(object sender, EventArgs e)
        {
            this.Focus();
            BE.BEcontroladorsesion.GetInstance.Usuario.Agregar(this);
            btn_modificar.Enabled = false;
            btn_quitar.Enabled = false;

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
