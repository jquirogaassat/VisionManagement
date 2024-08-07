﻿using BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VisionTFI
{
    public partial class GestionarSocio : Form , BE.IObserverForm
    {

        BLL.BLLcliente clienteBLL = new BLL.BLLcliente();
        BE.BEgestionbitacora bitacoraBE = new BEgestionbitacora();
        BLL.BLLgestionbitacora bitacoraBLL = new BLL.BLLgestionbitacora();
        public GestionarSocio()
        {
            InitializeComponent();
        }

        public void Actualizar(BEusuario u)
        {
            throw new NotImplementedException();
        }

        private void ActualizarClientes()
        {
            List<BE.BEcliente> clientes = new List<BE.BEcliente>();

            clientes = clienteBLL.Listar();

            dg_clientes.DataSource = clientes;

            dg_clientes.RowHeadersVisible = false;
            dg_clientes.AllowUserToAddRows = false;
            dg_clientes.AllowUserToDeleteRows = false;
            dg_clientes.EditMode = DataGridViewEditMode.EditProgrammatically;
            dg_clientes.MultiSelect = false;
            dg_clientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg_clientes.Columns[5].Visible = false;
            dg_clientes.Columns[6].Visible = false;



            dg_clientes.Columns[0].HeaderText = "NOMBRE";
            dg_clientes.Columns[1].HeaderText = "APELLIDO";
            dg_clientes.Columns[2].HeaderText = "LOCALIDAD";
            dg_clientes.Columns[3].HeaderText = "DIRECCION";
            dg_clientes.Columns[4].HeaderText = "MAIL";
           // dg_clientes.Columns[5].HeaderText = "DIRECCION";
            //dg_clientes.Columns[6].HeaderText = "LOCALIDAD";
            dg_clientes.Columns[7].HeaderText = "CUIT";
            dg_clientes.Columns[8].HeaderText = "TELEFONO";


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
            //btn_modificar.Enabled = false;
            //btn_quitar.Enabled = false;
            ActualizarClientes();
            ActualizarControles();
            IdiomaManager.IdiomaCambiado += OnIdiomaCambiado;
           
        }
        private void OnIdiomaCambiado()
        {
            ActualizarControles();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btn_quitar_Click(object sender, EventArgs e)
        {
            var row = dg_clientes.SelectedRows[0];
            BE.BEcliente clienteBE = (BE.BEcliente)row.DataBoundItem;
            clienteBLL.Baja(clienteBE);
            ActualizarClientes();
            ValorizarBitacora(bitacoraBE);
            bitacoraBLL.Alta(bitacoraBE);
            MessageBox.Show("Cliente eliminado!");
        }

        public void ValorizarBitacora(BE.BEgestionbitacora bEgestionbitacora)
        {
            BLL.BLLencriptacion encriptadora = new BLL.BLLencriptacion();
            bEgestionbitacora.IdUsuario = BE.BEcontroladorsesion.GetInstance.Usuario.IdUsuario;
            bEgestionbitacora.FechaHora = DateTime.Now;
            bEgestionbitacora.idPatente = 8;
            bEgestionbitacora.Descripcion = BE.BEcontroladorsesion.GetInstance.Usuario.Nombre + " " + BE.BEcontroladorsesion.GetInstance.Usuario.Apellido +
                                            "Elimino un cliente.";
            bEgestionbitacora.Descripcion = encriptadora.encriptarAES(bEgestionbitacora.Descripcion);
            bEgestionbitacora.Criticidad = "Alta";

        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            Hide();
            Globa.tipoProceso = "Modificacion";
            ABMcliente aBMclienteModificar = new ABMcliente();            
            Globa.menuPrincipal.AbrirFormHijo(aBMclienteModificar);
        }

        private void dg_clientes_MouseClick(object sender, MouseEventArgs e)
        {
            var row = dg_clientes.SelectedRows[0];
            Globa.cllienteBE = (BE.BEcliente)row.DataBoundItem;
        }

        void ActualizarControles()
        {
            lbl_apellido.Text = IdiomaManager.info["lbl_apellido"];
            btn_buscar.Text = IdiomaManager.info["btn_buscar"];
            btn_agregar.Text = IdiomaManager.info["btn_agregar"];
            btn_modificar.Text = IdiomaManager.info["btn_modificar"];
            btn_quitar.Text = IdiomaManager.info["btn_quitar"];
            btn_salir.Text = IdiomaManager.info["btn_salir"];
        }
    }
}
