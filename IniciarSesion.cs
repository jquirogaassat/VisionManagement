using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using BE;

namespace VisionTFI
{
    public partial class IniciarSesion : Form, BE.IObserverForm
    {

        BE.BEusuario usuarioBE = new BEusuario();
        BLL.BLLusuario usuarioBLL= new BLL.BLLusuario();
        BE.BEgestionbitacora bitacoraBE = new BEgestionbitacora();
        BLL.BLLgestionbitacora bitacoraBLL = new BLL.BLLgestionbitacora();
        BLL.BLLencriptacion encriptadora = new BLL.BLLencriptacion();
        BE.BEreusltadoLog resultado;

        public IniciarSesion()
        {
            InitializeComponent();
        }

        public void Actualizar(BEusuario u)
        {
            throw new NotImplementedException();
        }

        private void lnl_olvidoPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BLL.BLLencriptacion encriptadora = new BLL.BLLencriptacion();
            usuarioBE.usuario = encriptadora.encriptarAES(txt_usuario.Text);
            usuarioBE = usuarioBLL.ConsultarUsuario(usuarioBE);
            string pass = usuarioBLL.GenerarPassword();
            usuarioBE.UserPass=encriptadora.encriptarSha256(pass);
            usuarioBE.intentosFallidos = 0;
            if(usuarioBLL.Modificar(usuarioBE))
            {
                string directorio = @"C:\Users\jair\Desktop";
                string nombreArchivo = "pass.txt";
                bool sobreescribir = true;
                bool salida = usuarioBLL.GuardarArchivo(directorio, nombreArchivo, pass, sobreescribir);


                MessageBox.Show("La nueva contraseña se ha generado y guardado correctamente", "recupero su contraseña",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                ValorizarBitacora(bitacoraBE);
                bitacoraBLL.Alta(bitacoraBE);
            }
            
        }

        public void ValorizarBitacora(BE.BEgestionbitacora bitacoraBE, string nivel, string descripcion, int idUsuario=0)
        {
            bitacoraBE.IdUsuario = idUsuario;
            bitacoraBE.FechaHora = DateTime.Now;


            bitacoraBE.idPatente = 1;
            if (idUsuario==0)
            {
                bitacoraBE.Descripcion = descripcion;
            }
            else
            {
                bitacoraBE.Descripcion = BE.BEcontroladorsesion.GetInstance.Usuario.Nombre + " " + BE.BEcontroladorsesion.GetInstance.Usuario.Apellido + descripcion;

            }
            bitacoraBE.Descripcion = encriptadora.encriptarAES(bitacoraBE.Descripcion);
            bitacoraBE.Criticidad = nivel;
        }


        public void ValorizarBitacora(BE.BEgestionbitacora bitacoraBE)
        {
            bitacoraBE.IdUsuario = 0;
            bitacoraBE.FechaHora = DateTime.Now;

            bitacoraBE.idPatente = 15;
            bitacoraBE.Descripcion = BE.BEcontroladorsesion.GetInstance.Usuario.Nombre + " " + BE.BEcontroladorsesion.GetInstance.Usuario.Apellido + " Genero recupero de contraseña";

            bitacoraBE.Descripcion = encriptadora.encriptarAES(bitacoraBE.Descripcion);
            bitacoraBE.Criticidad = "bajo";

        }


        public void LimpiarTxt()
        {
            txt_usuario.Text = "";
            txt_pass.Text = "";
        }

        private void IniciarSesion_Load(object sender, EventArgs e)
        {
            this.Focus();

            txt_usuario.Text = "";
            txt_usuario.Text = "";


        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hola");
            Globa.menuPrincipal = new MenuPrincipal();
            Globa.menuPrincipal.Show();
            this.Hide();
        }
    }
}
