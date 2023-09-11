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
    public partial class CambiarContraseña : Form
    {
        BE.BEgestionbitacora bitacoraBe = new BE.BEgestionbitacora();
        BLL.BLLgestionbitacora bitacoraBll = new BLL.BLLgestionbitacora();
        BLL.BLLencriptacion encriptadora = new BLL.BLLencriptacion();
        public CambiarContraseña()
        {
            InitializeComponent();
        }

        private void CambiarContraseña_Load(object sender, EventArgs e)
        {
            this.Focus();
            //BE.BEcontroladorsesion.GetInstance.Usuario.Agregar(this);
        }


        private void ValorizarBitacora(BE.BEgestionbitacora bitacoraBe)
        {
            
            bitacoraBe.IdUsuario = BE.BEcontroladorsesion.GetInstance.Usuario.IdUsuario;
            bitacoraBe.FechaHora = DateTime.Now;
            bitacoraBe.idPatente = 17;
            bitacoraBe.Descripcion = BE.BEcontroladorsesion.GetInstance.Usuario.Nombre + " " + BE.BEcontroladorsesion.GetInstance.Usuario.Apellido + "cambio la contraseña!";
            bitacoraBe.Descripcion = encriptadora.encriptarAES(bitacoraBe.Descripcion);
            bitacoraBe.Criticidad = "BAJO";

        }
        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            BE.BEusuario usuarioLogueadoBe = BE.BEcontroladorsesion.GetInstance.Usuario;
            BLL.BLLusuario bLLusuario = new BLL.BLLusuario();

            try
            {
                if (usuarioLogueadoBe.UserPass == encriptadora.encriptarSha256(txt_contraseñaActual.Text))
                {
                    if (txt_contraseñaNueva.Text == txt_confirmarContraseña.Text)
                    {
                        usuarioLogueadoBe.UserPass = encriptadora.encriptarSha256(txt_contraseñaNueva.Text);
                        bLLusuario.Modificar(usuarioLogueadoBe);
                        MessageBox.Show("Ha modificado su contraseña con exito.", "Usted ha cambiado su contraseña.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ValorizarBitacora(bitacoraBe);
                        bitacoraBll.Alta(bitacoraBe);
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Error al cambiar la contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Hide();
                    }
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Pongase en contacto con su administrador");
                this.Hide();
            }
            
        }
    }
}
