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
    public partial class MenuPrincipal : Form , BE.IObserverForm
    {
        BE.BEgestionbitacora bitacoraBe = new BE.BEgestionbitacora();
        BLL.BLLgestionbitacora bitacoraBll = new BLL.BLLgestionbitacora();
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

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Globa.menuPrincipal.AbrirFormHijoMenu(Globa.administrarUsers);
        }

        private void realizarBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Globa.menuPrincipal.AbrirFormHijo(Globa.Backup);
        }

        private void aBMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Globa.menuPrincipal.AbrirFormHijo(Globa.GestionarCliente);
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BLL.BLLusuario usuarioBLL = new BLL.BLLusuario();
            BE.BEusuario usuarioBE = new BEusuario();

            if (usuarioBLL.Logout(usuarioBE))
            {
                MessageBox.Show("Sesion finalizada!");
                Close();
                Globa.IniciarSesion.Show();
            }
            else
            {
                MessageBox.Show("No se puede cerrar sesion!.");
            }
        }

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
            //ValorizarBitacora();
           // ValidarPermisos();

        }

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

        private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Globa.menuPrincipal.AbrirFormHijoMenu(Globa.restore);
        }

        private void bitacoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Globa.menuPrincipal.AbrirFormHijoMenu(new GestionarBitacora());
        }

        private void familiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Globa.menuPrincipal.AbrirFormHijoMenu(new GestionarFamilias());
        }

        private void cambiarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            CambiarContraseña cambiarPass = new CambiarContraseña();
            cambiarPass.Show();
        }
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


        void ValidarPermisos()
        {
            
            try
            {
                if(BEcontroladorsesion.GetInstance.IsLoggedIn())
                {
                    this.seguridadToolStripMenuItem.Enabled = BEcontroladorsesion.GetInstance.IsInRole(BEtipoPermiso.PuedeHacerA);
                    this.gestionarToolStripMenuItem.Enabled = BEcontroladorsesion.GetInstance.IsInRole(BEtipoPermiso.PuedeHacerB);
                    this.negocioToolStripMenuItem.Enabled = BEcontroladorsesion.GetInstance.IsInRole(BEtipoPermiso.PuedeHacerC);
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

        private void gestionarPermisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionarPermisosDeUsuarios gestionarPermisos = new GestionarPermisosDeUsuarios();
            Globa.menuPrincipal.AbrirFormHijoMenu(gestionarPermisos);
        }
    }
}
