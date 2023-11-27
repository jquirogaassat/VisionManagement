﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisionTFI
{
    public partial class NuevoPrestamo : Form
    {
        BLL.BLLcliente _clienteBl = new BLL.BLLcliente();
        BLL.BLLherramientas _herramientaBl= new BLL.BLLherramientas();
        BLL.BLprestamo _prestamoBl = new BLL.BLprestamo(); 
        BE.BEprestamo _prestamoBe = new BE.BEprestamo();
        BE.BEgestionbitacora _bitacoraBe = new BE.BEgestionbitacora();
        BLL.BLLgestionbitacora _bitacoraBl = new BLL.BLLgestionbitacora();
        public NuevoPrestamo()
        {
            InitializeComponent();
        }

        private void btn_consultarHerramienta_Click(object sender, EventArgs e)
        {
            txt_herramienta.Text = Globa.herramientaBE.Id + "--" + Globa.herramientaBE.Nombre;
        }

        private void ValorizarBitacora(BE.BEgestionbitacora bEgestionbitacora)
        {
            BLL.BLLencriptacion encriptadora= new BLL.BLLencriptacion();

            bEgestionbitacora.IdUsuario = BE.BEcontroladorsesion.GetInstance.Usuario.IdUsuario;
            bEgestionbitacora.FechaHora = DateTime.Now;

            bEgestionbitacora.idPatente = 2;
            bEgestionbitacora.Descripcion = BE.BEcontroladorsesion.GetInstance.Usuario.Nombre + " " + BE.BEcontroladorsesion.GetInstance.Usuario.Apellido + "Efectuo un prestamo";
            bEgestionbitacora.Criticidad = "MEDIA";
        }

        private void ActualizarGrillaHerramientas()
        {
            dgv_herramientas.DataSource = _herramientaBl.Listar();
            dgv_herramientas.RowHeadersVisible = false;
            dgv_herramientas.AllowUserToAddRows = false;
            dgv_herramientas.AllowUserToDeleteRows = false;
            dgv_herramientas.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgv_herramientas.MultiSelect = false;
            dgv_herramientas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void ActualizarGrillaClientes()
        {
            dgv_clientes.DataSource = _clienteBl.Listar();
            dgv_clientes.RowHeadersVisible = false;
            dgv_clientes.AllowUserToAddRows = false;
            dgv_clientes.AllowUserToDeleteRows = false;
            dgv_clientes.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgv_clientes.MultiSelect = false;
            dgv_clientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void NuevoPrestamo_Load(object sender, EventArgs e)
        {
            this.Focus();
            ActualizarGrillaClientes();
            ActualizarGrillaHerramientas();
        }

        private void btn_seleccionaC_Click(object sender, EventArgs e)
        {
            txt_clienteSeleccionado.Text = Globa.cllienteBE.IdCliente + "--" + Globa.cllienteBE.Apellido + "--" + Globa.cllienteBE.Nombre;
        }

        private void dgv_herramientas_MouseClick(object sender, MouseEventArgs e)
        {
            var row = dgv_herramientas.SelectedRows[0];
            Globa.herramientaBE = (BE.BEherramientas)row.DataBoundItem;
        }

        private void dgv_clientes_MouseClick(object sender, MouseEventArgs e)
        {
            var row = dgv_clientes.SelectedRows[0];
            Globa.cllienteBE = (BE.BEcliente)row.DataBoundItem;
        }


        private void ValorizarPrestamo()
        {
            Globa.prestamoBe = new BE.BEprestamo();
            Globa.prestamoBe.Herramienta = Globa.herramientaBE;
            Globa.prestamoBe.Cliente = Globa.cllienteBE;
            Globa.prestamoBe.Observaciones = Globa.herramientaBE.Disponible;
            Globa.prestamoBe.FechaInicio = DateTime.Now;
            Globa.prestamoBe.FechaDevolucion = DateTime.Now.AddDays(7);
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            ValorizarPrestamo();

            bool resultado= _prestamoBl.Alta(Globa.prestamoBe);
            if(resultado) 
            {
                ValorizarBitacora(_bitacoraBe);
                _bitacoraBl.Alta(_bitacoraBe);
                MessageBox.Show("Prestamo exitoso!!");
                this.Close();
                Globa.administrarPrestamos = new AdministrarPrestamos();
                Globa.menuPrincipal.AbrirFormHijoMenu(Globa.administrarPrestamos);
            }
            else
            {
                MessageBox.Show("Prestamo exitoso!!");
                Close();
            }
        }

        private void btn_seleccionarH_Click(object sender, EventArgs e)
        {
            txt_herramienta.Text = Globa.herramientaBE.Id + "--" + Globa.herramientaBE.Nombre;
        }
    }
}
