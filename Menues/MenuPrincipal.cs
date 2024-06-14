using BE;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using iText.Kernel.Pdf;
using System.Globalization;
using Microsoft.Reporting.WinForms;

using DAL;

namespace VisionTFI
{
    public partial class MenuPrincipal : Form , BE.IObserverForm
    {
        BE.BEgestionbitacora bitacoraBe = new BE.BEgestionbitacora();
       

        void ActualizarControles()
        {
            //IdiomaManager.Controles(this);
            //this.Text = IdiomaManager.info["Text3"];
            inicioToolStripMenuItem.Text = IdiomaManager.info["inicioToolStripMenuItem"]; 
            gestionarToolStripMenuItem.Text = IdiomaManager.info["gestionarToolStripMenuItem"];
            clienteToolStripMenuItem.Text = IdiomaManager.info["clienteToolStripMenuItem"];
            articuloToolStripMenuItem.Text = IdiomaManager.info["articuloToolStripMenuItem"];
            maquinariasYHerramientasToolStripMenuItem.Text = IdiomaManager.info["maquinariasYHerramientasToolStripMenuItem"];
            aBMToolStripMenuItem.Text = IdiomaManager.info["aBMToolStripMenuItem"];
            seguridadToolStripMenuItem.Text = IdiomaManager.info["seguridadToolStripMenuItem"];
            comprobarIntegridadToolStripMenuItem.Text = IdiomaManager.info["comprobarIntegridadToolStripMenuItem"];
            restoreToolStripMenuItem.Text = IdiomaManager.info["restoreToolStripMenuItem"];
            bitacoraToolStripMenuItem.Text = IdiomaManager.info["bitacoraToolStripMenuItem"];
            bitacoraDeCambiosToolStripMenuItem.Text      = IdiomaManager.info["bitacoraDeCambiosToolStripMenuItem"];
            familiasToolStripMenuItem.Text = IdiomaManager.info["familiasToolStripMenuItem"];
            usuariosToolStripMenuItem.Text = IdiomaManager.info["usuariosToolStripMenuItem"];
            gestionarPermisosToolStripMenuItem.Text = IdiomaManager.info["gestionarPermisosToolStripMenuItem"];
            reportesToolStripMenuItem.Text = IdiomaManager.info["reportesToolStripMenuItem"];            
            reporteFacturaToolStripMenuItem.Text = IdiomaManager.info["reporteBitacoraDeCambiosToolStripMenuItem"];
            reporteDePrestamosToolStripMenuItem.Text = IdiomaManager.info["reporteDePrestamosToolStripMenuItem"];
            idiomaToolStripMenuItem.Text = IdiomaManager.info["idiomaToolStripMenuItem"];
            cambiarIdiomaToolStripMenuItem.Text = IdiomaManager.info["cambiarIdiomaToolStripMenuItem"];
            inglesToolStripMenuItem.Text = IdiomaManager.info["inglesToolStripMenuItem"];
            ayudaToolStripMenuItem.Text = IdiomaManager.info["ayudaToolStripMenuItem"];
            primerosPasosToolStripMenuItem.Text = IdiomaManager.info["primerosPasosToolStripMenuItem"];
            manualDeUsuarioToolStripMenuItem.Text = IdiomaManager.info["manualDeUsuarioToolStripMenuItem"];
            manualDeAToolStripMenuItem.Text = IdiomaManager.info["manualDeAToolStripMenuItem"];
            negocioToolStripMenuItem.Text = IdiomaManager.info["negocioToolStripMenuItem"];
            ventaToolStripMenuItem.Text = IdiomaManager.info["ventaToolStripMenuItem"];
            facturaToolStripMenuItem.Text = IdiomaManager.info["facturaToolStripMenuItem"];
            prestamoToolStripMenuItem.Text = IdiomaManager.info["prestamoToolStripMenuItem"];
            administrarToolStripMenuItem.Text = IdiomaManager.info["administrarToolStripMenuItem"];
            sesionToolStripMenuItem.Text = IdiomaManager.info["sesionToolStripMenuItem"];
            cambiarUsuarioToolStripMenuItem.Text = IdiomaManager.info["cambiarUsuarioToolStripMenuItem"];
            cerrarSesionToolStripMenuItem.Text = IdiomaManager.info["cerrarSesionToolStripMenuItem"];
        }
 
        public MenuPrincipal()
        {
            InitializeComponent();        
        }

        public void Actualizar(BEusuario u)
        {
            throw new NotImplementedException();
        }

        public void AbrirFormHijoMenu(object frmHijo)
        {
            if(this.panelFill.Controls.Count >0)
            {
                this.panelFill.Controls.RemoveAt(0);
            }

            Form form = frmHijo as Form;
            form.TopLevel = false;
            form.Dock= DockStyle.Fill;
            this.panelFill.Controls.Add(form);
            this.panelFill.Tag = form;
            form.Show();
        }

        public void AbrirFormHijo(object frmHIjo)
        {
            if(this.panelFill.Controls.Count > 1)
            {
                this.panelFill.Controls.RemoveAt(0);
            }
            Form form= frmHIjo as Form;
            form.TopLevel = false;
            form.Dock=DockStyle.Fill;
            this.panelFill.Controls.Add(form);
            this.panelFill.Tag= form;
            form.Show();
        }
        //inicio
        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }
        //administracion de usuarios
        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            Globa.menuPrincipal.AbrirFormHijoMenu(Globa.administrarUsers);
        }
        //backup
        private void realizarBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Globa.menuPrincipal.AbrirFormHijo(Globa.Backup);
        }
        //gestionar clientes
        private void aBMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Globa.menuPrincipal.AbrirFormHijo(Globa.GestionarCliente);
        }
        //cerrar la sesion
        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BLL.BLLusuario usuarioBLL = new BLL.BLLusuario();
            BE.BEusuario usuarioBE = new BEusuario();
            DAL.DALdigitoverificador dvdal= new DALdigitoverificador();

            if (usuarioBLL.Logout(usuarioBE))
            {
                MessageBox.Show("Sesion finalizada!");
                Close();
                dvdal.ComprobarIntegridad();
                Globa.IniciarSesion.Show();
            }
            else
            {
                MessageBox.Show("No se puede cerrar sesion!.");
            }
        }
        //gestionar articulos
        private void aBMToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Globa.menuPrincipal.AbrirFormHijo(Globa.GestionarArticulo);
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            this.Focus();
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            Globa.nivelCriticidad.Add("ALTO");
            Globa.nivelCriticidad.Add("MEDIO");
            Globa.nivelCriticidad.Add("BAJO");
            ValorizarBitacora(bitacoraBe); 
            ValidarPermisos();

        }
        //comprobar integridad de la base de datos
        private void comprobarIntegridadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BLL.BLLdigitoverificador dvbll = new BLL.BLLdigitoverificador();
            Globa.errores = dvbll.ComprobarIntegridad();


            if(Globa.errores.Count >0)
            {
                Inicio inicio = new Inicio();
                inicio.Show();
            }
            else
            {
                MessageBox.Show("Comprobacion de integridad correcta!.");

            }
        }
        //restore
        private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Globa.menuPrincipal.AbrirFormHijoMenu(Globa.restore);
        }
        //bitacora de eventos
        private void bitacoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Globa.menuPrincipal.AbrirFormHijoMenu(new GestionarBitacora());
        }
        //gestionar familias 
        private void familiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Globa.menuPrincipal.AbrirFormHijoMenu(new GestionarFamilias());
        }
        //cambiar contraseña
        private void cambiarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            CambiarContraseña cambiarPass = new CambiarContraseña();
            cambiarPass.Show();
        }
        // aca en este metodo valorizo los datos que voy a grabar en la bitacora de eventos
        private void ValorizarBitacora(BE.BEgestionbitacora bitacoraBe)
        {
            BLL.BLLencriptacion encriptadora = new BLL.BLLencriptacion();

            bitacoraBe.IdUsuario = BE.BEcontroladorsesion.GetInstance.Usuario.IdUsuario;
            bitacoraBe.FechaHora = DateTime.Now;
            bitacoraBe.idPatente = 17;
            bitacoraBe.Descripcion = BE.BEcontroladorsesion.GetInstance.Usuario.Nombre + " " + BE.BEcontroladorsesion.GetInstance.Usuario.Apellido + "cambio la contraseña!";
            bitacoraBe.Descripcion = encriptadora.encriptarAES(bitacoraBe.Descripcion);
            bitacoraBe.Criticidad = "BAJO";

        }
        // valido los permisos de usuario
        void ValidarPermisos()
        {
            (new PermisosRepository()).FillUserComponents(BE.BEcontroladorsesion.GetInstance.Usuario);
            try
            {
               if(BEcontroladorsesion.GetInstance.IsLoggedIn(BE.BEcontroladorsesion.GetInstance.Usuario))          
                {
                    this.seguridadToolStripMenuItem.Enabled = BEcontroladorsesion.GetInstance.IsInRole(BE.BEcontroladorsesion.GetInstance.Usuario,BEtipoPermiso.PuedeHacerA);
                    this.gestionarToolStripMenuItem.Enabled = BEcontroladorsesion.GetInstance.IsInRole(BE.BEcontroladorsesion.GetInstance.Usuario,BEtipoPermiso.PuedeHacerB);
                    this.negocioToolStripMenuItem.Enabled = BEcontroladorsesion.GetInstance.IsInRole(BE.BEcontroladorsesion.GetInstance.Usuario,BEtipoPermiso.PuedeHacerC);                  
                }
                else
                {
                    this.seguridadToolStripMenuItem.Enabled = false;
                    this.gestionarToolStripMenuItem.Enabled = false;
                    this.negocioToolStripMenuItem.Enabled = false;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("El usuario no tiene permisos");
            }
        }
        //gestionar los permisos de usuario
        private void gestionarPermisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionarPermisosDeUsuarios gestionarPermisos = new GestionarPermisosDeUsuarios();
            Globa.menuPrincipal.AbrirFormHijoMenu(gestionarPermisos);
        }
        // bitacora de cambios
        private void bitacoraDeCambiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Globa.menuPrincipal.AbrirFormHijoMenu(new BitacoraC());
        }
        // generar una factura
        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Globa.menuPrincipal.AbrirFormHijoMenu(new DetalleFactura());
        }
        // gestionar herramientas
        private void aBMToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Globa.menuPrincipal.AbrirFormHijoMenu(new GestionarHerramientsa());
        }
        //administrar los prestamos
        private void administrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Globa.menuPrincipal.AbrirFormHijo(new AdministrarPrestamos());
        }
        // ayuda primeros pasos
        private void primerosPasosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Globa.menuPrincipal.AbrirFormHijoMenu(new FrmPrimerosPasos());
        }
        // ayuda usuarios
        private void manualDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Globa.menuPrincipal.AbrirFormHijoMenu(new FrmMenuUsuarios1());
        }
        // ayuda administrador
        private void manualDeAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Globa.menuPrincipal.AbrirFormHijoMenu(new FrmMenuAdministrador());
        }
        // cambiar idioma ingles
        private void inglesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IdiomaManager.CambiarIdioma("en.txt");
            ActualizarControles();
        }
        //cambiar idioma español
        private void cambiarIdiomaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IdiomaManager.CambiarIdioma("es.txt");
            ActualizarControles();
        }
        //btn para imprimir reporte de todos los prestamos 
        private void reporteDePrestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReportePrestamos reporte = new FrmReportePrestamos();
            Globa.menuPrincipal.AbrirFormHijoMenu(reporte);
        }

        private void reporteFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReporteFactura reporteFactura= new FrmReporteFactura();
            Globa.menuPrincipal.AbrirFormHijoMenu(reporteFactura);
        }

        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReporteInteligente reporteInteligente = new FrmReporteInteligente();
            Globa.menuPrincipal.AbrirFormHijoMenu(reporteInteligente);
        }
    }
}
