using BE;
using DAL;
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
    public partial class GestionarHerramientsa : Form , BE.IObserverForm
    {
       private BLL.BLLherramientas herramientabll= new BLL.BLLherramientas();
       private BE.BEherramientas herramientabe = new BE.BEherramientas();
       private BEbitacoraC BEbitacoraC = new BEbitacoraC();


        public GestionarHerramientsa()
        {
            InitializeComponent();
        }

        public void Actualizar(BEusuario u)
        {
            throw new NotImplementedException();
        }

        private void GestionarHerramientsa_Load(object sender, EventArgs e)
        {
            Focus();
            BE.BEcontroladorsesion.GetInstance.Usuario.Agregar(this);
            ActualizarGrillaHerramientas();
        }

        private void ActualizarGrillaHerramientas()
        {
            List<BEherramientas> herramientas = new List<BEherramientas>();
            herramientas = herramientabll.Listar();

            dg_herramienta.DataSource=herramientas;

            dg_herramienta.RowHeadersVisible = false;
            dg_herramienta.AllowUserToAddRows = false;
            dg_herramienta.AllowUserToDeleteRows = false;
            dg_herramienta.EditMode = DataGridViewEditMode.EditProgrammatically;
            dg_herramienta.MultiSelect = false;
            dg_herramienta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg_herramienta.Columns[4].Visible = false;


            dg_herramienta.Columns[0].HeaderText = "Nombre";
            dg_herramienta.Columns[1].HeaderText = "Color";
            dg_herramienta.Columns[2].HeaderText = "Origen";
            dg_herramienta.Columns[3].HeaderText = "Codigo";
            dg_herramienta.Columns[5].HeaderText = "Precio";
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Globa.tipoProceso = "ALTA";
            ABMherramientas aBMherramientas = new ABMherramientas();
            Globa.menuPrincipal.AbrirFormHijo(aBMherramientas);
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Globa.tipoProceso = "MODIFICACION";
            ABMherramientas aBMherramientas = new ABMherramientas();
            Globa.menuPrincipal.AbrirFormHijo(aBMherramientas);
        }

       private void dg_herramienta_MouseClick_1(object sender, MouseEventArgs e)
        {
            var row = dg_herramienta.SelectedRows[0];
            Globa.herramientaBE = (BE.BEherramientas)row.DataBoundItem;
        }

        private void btn_quitar_Click(object sender, EventArgs e)
        {
            var row = dg_herramienta.SelectedRows[0];
            BE.BEherramientas herramientaBe = (BE.BEherramientas)row.DataBoundItem;
            herramientabll.Baja(herramientaBe);
            ActualizarGrillaHerramientas();
            MessageBox.Show("Herramienta eliminada!");
        }
    }
}
