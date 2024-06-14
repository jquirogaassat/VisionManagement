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
    public partial class FrmReporteInteligente : Form
    {   
       
        public FrmReporteInteligente()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this. Close();
        }

        private void btn_buscarProductos_Click(object sender, EventArgs e)
        {            
            BLL.BLLarticulo _blArticulo= new BLL.BLLarticulo();
            DataTable dt = _blArticulo.CargarInforme();
            dgv_Productos.DataSource = dt;
            ActualizarDgvProductos();
        }
        private void btn_buscarClientes_Click(object sender, EventArgs e)
        {
            BLL.BLLcliente _blCliente = new BLL.BLLcliente();
            DataTable dt = _blCliente.CargarInforme();
            dgv_clientes.DataSource = dt;
            ActualizarDgvClientes();
        }

        private void ActualizarDgvProductos()
        {
            dgv_Productos.RowHeadersVisible = false;
            dgv_Productos.AllowUserToAddRows = false;
            dgv_Productos.AllowUserToDeleteRows = false;
            dgv_Productos.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgv_Productos.MultiSelect = false;
            dgv_Productos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgv_Productos.Columns[0].HeaderText = "Nombre de articulo ";
            dgv_Productos.Columns[1].HeaderText = "Cantidad vendida ";
            dgv_Productos.Columns[2].HeaderText = "Ingresos obtenidos";         

        }

        private void ActualizarDgvClientes()
        {
            dgv_clientes.RowHeadersVisible = false;
            dgv_clientes.AllowUserToAddRows = false;
            dgv_clientes.AllowUserToDeleteRows = false;
            dgv_clientes.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgv_clientes.MultiSelect = false;
            dgv_clientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgv_clientes.Columns[0].HeaderText = "Numero de cliente ";
            dgv_clientes.Columns[1].HeaderText = "Nombre de cliente ";
            dgv_clientes.Columns[2].HeaderText = "Numero de compras";
        }

        
    }
}
