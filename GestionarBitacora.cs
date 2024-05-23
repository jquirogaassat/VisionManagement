﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;

namespace VisionTFI
{
    public partial class GestionarBitacora : Form
    {
         BE.BEusuario usuarioBE = new BE.BEusuario();
         BLL.BLLgestionbitacora BLLgestionbitacora = new BLL.BLLgestionbitacora();
         BLL.BLLusuario usuarioBLL = new BLL.BLLusuario();
         string orden;
        BE.BEgestionbitacora bitacoraBE = new BEgestionbitacora();

        public GestionarBitacora()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void GestionarBitacora_Load(object sender, EventArgs e)
        {
            this.Focus();
            dt_desde.Value = new DateTime(2000, 1, 1);
            cmb_usuario.Items.Clear();
            cmb_nivelCriticidad.Items.Clear();
            RellenarCombos();
            btn_imprimir.Enabled = false;         
            dgv_bitacora.DataSource = BLLgestionbitacora.Listar();
            RellenarDgv();
            //ValorizarBitacora();
        }

        public void RellenarDgv()
        {
            dgv_bitacora.RowHeadersVisible = false;
            dgv_bitacora.AllowUserToAddRows = false;
            dgv_bitacora.AllowUserToDeleteRows = false;
            dgv_bitacora.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgv_bitacora.MultiSelect = false;
            dgv_bitacora.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_bitacora.Columns[0].HeaderText = "Descripcion";
            dgv_bitacora.Columns[1].HeaderText = "Nivel de criticidad";
            dgv_bitacora.Columns[2].HeaderText = "Id Usuario";
            dgv_bitacora.Columns[5].HeaderText = "Fecha y hora";
            dgv_bitacora.Columns[3].Visible = false;
            dgv_bitacora.Columns[4].Visible = false;
            dgv_bitacora.Columns[6].Visible = false;

        }

        private void ValorizarBitacora (BE.BEgestionbitacora bitacoraBE)
        {
            BLL.BLLencriptacion encriptadora = new BLL.BLLencriptacion();
            bitacoraBE.IdUsuario = BE.BEcontroladorsesion.GetInstance.Usuario.IdUsuario;
            bitacoraBE.FechaHora = DateTime.Now;
            bitacoraBE.idPatente = 5;
            bitacoraBE.Descripcion = BE.BEcontroladorsesion.GetInstance.Usuario.Nombre + " " + BE.BEcontroladorsesion.GetInstance.Usuario.Apellido + " " + "Hizo una consulta en bitacora!";
            bitacoraBE.Descripcion = encriptadora.encriptarAES(bitacoraBE.Descripcion);
            bitacoraBE.Criticidad = "Medio";
        }

        private void ActualizarBitacora ()
        {
            if(rdb_asc.Checked)
            {
                orden = "asc";
            }
            else
            {
                orden = "des";
            }

            usuarioBE = (BE.BEusuario)cmb_usuario.SelectedItem;
            DateTime desde = dt_desde.Value;
            DateTime hasta = dt_hasta.Value;
            string criticidad = (string)cmb_nivelCriticidad.SelectedItem;
            dgv_bitacora.RowHeadersVisible = false;
            dgv_bitacora.AllowUserToAddRows = false;
            dgv_bitacora.AllowUserToDeleteRows = false;
            dgv_bitacora.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgv_bitacora.MultiSelect = false;
            dgv_bitacora.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
           


            dgv_bitacora.DataSource = BLLgestionbitacora.Consulta(desde, hasta, usuarioBE, orden, criticidad);

            dgv_bitacora.Columns[0].HeaderText = "Descripcion";
            dgv_bitacora.Columns[1].HeaderText = "Nivel de criticidad";
            dgv_bitacora.Columns[2].HeaderText = "Id Usuario";            
            dgv_bitacora.Columns[5].HeaderText = "Fecha y hora";
            dgv_bitacora.Columns[3].Visible= false;
            dgv_bitacora.Columns[4].Visible = false;
            dgv_bitacora.Columns[6].Visible = false;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

      

        private void RellenarCombos()
        {
            List<BE.BEusuario> usuarios =usuarioBLL.Consulta().Where(u => u.IsBlocked == "NO").ToList();           
            cmb_usuario.DataSource = usuarios;            
            cmb_usuario.DisplayMember = "ApellidoNombre"; 
            cmb_nivelCriticidad.DataSource = Globa.nivelCriticidad;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            ActualizarBitacora();
            if(dgv_bitacora.Rows.Count >0)
            {
                btn_imprimir.Enabled = true;
                
            }
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            
            DateTime Desde = dt_desde.Value;
            DateTime Hasta = dt_hasta.Value;
            usuarioBE = (BE.BEusuario)cmb_usuario.SelectedItem;
            string criticidad = (string)cmb_nivelCriticidad.SelectedItem;
            Reporte reporte= new Reporte(Desde,Hasta,usuarioBE,orden,criticidad);
            //reporte.Show();
            Globa.tipoProceso = "Alta";
            //Reporte reporte = new Reporte();
            ValorizarBitacora(bitacoraBE);
            Hide();
            Globa.menuPrincipal.AbrirFormHijoMenu(reporte);
       
        }
    }
}
