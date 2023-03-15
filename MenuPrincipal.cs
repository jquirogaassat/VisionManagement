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

        }
    }
}
