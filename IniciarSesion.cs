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
using DAL;

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
        int fallo = 0;

        public void ActualizarControles()
        {
           Idioma.controles(this);
        }
        public IniciarSesion()
        {
            InitializeComponent();
            ActualizarControles();
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

            txt_usuario.Text = "admin";
            txt_pass.Text = "admin123";


            inicioToolStripMenuItem.Visible = true;
            seguridadToolStripMenuItem.Visible = false;
            idiomaToolStripMenuItem.Visible = false;
            ayudaToolStripMenuItem.Visible = true;
            sesionToolStripMenuItem.Visible = true;

        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {           
            BLL.BLLusuario usuarioBLL = new BLL.BLLusuario();
            BE.BEusuario usuarioLog = new BE.BEusuario();
            usuarioLog.usuario = txt_usuario.Text;
            usuarioLog.UserPass = txt_pass.Text;

            usuarioLog = usuarioBLL.Encriptar(usuarioLog);

            string pass = usuarioLog.UserPass;
            resultado = usuarioBLL.Login(usuarioLog);

            if (resultado == BE.BEreusltadoLog.LoginCorrecto)
            {
                MessageBox.Show("Login correcto");
                if (txt_usuario.Text == txt_pass.Text)
                {
                    MessageBox.Show("Usted debe cambiar su contraseña!");
                    CambiarContraseña cambiarPass = new CambiarContraseña();
                    cambiarPass.Show();                  
                    LimpiarCombos();
                    ValorizarBitacora(bitacoraBE, "Medio", "Se cambio contraseña", BE.BEcontroladorsesion.GetInstance.Usuario.IdUsuario);
                    bitacoraBLL.Alta(bitacoraBE);

                }
                BLL.BLLconexion conexion = new BLL.BLLconexion();

                if (conexion.ComprobarConexion())
                {

                    BLL.BLLdigitoverificador dv = new BLL.BLLdigitoverificador();
                    Globa.errores = dv.ComprobarIntegridad();
                    if (Globa.errores.Count > 0)
                    {
                        if (txt_usuario.Text != "admin")
                        {
                            MessageBox.Show("¡Sistema inhabilitado, por favor comuniquese con su administrador!");
                            usuarioBLL.Logout(usuarioLog);
                            this.Focus();
                        }
                        else
                        {
                            Inicio inicio = new Inicio();
                            inicio.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        Globa.menuPrincipal = new MenuPrincipal();
                        Globa.menuPrincipal.Show();
                        this.Hide();
                        LimpiarCombos();
                        ValorizarBitacora(bitacoraBE, "BAJO", "Se inicio sesion", BE.BEcontroladorsesion.GetInstance.Usuario.IdUsuario);
                        bitacoraBLL.Alta(bitacoraBE);
                        
                    }
                }


            }
            else
            {

                if (resultado == BE.BEreusltadoLog.SesionActiva)
                {
                    MessageBox.Show("Hay una sesion activa para este usuario");
                    ValorizarBitacora(bitacoraBE, "MEDIO", "Intento de inicio de una sesion activa.");
                    bitacoraBLL.Alta(bitacoraBE);
                }
                else
                {
                    if (resultado == BE.BEreusltadoLog.UsuarioInexistente)
                    {
                        MessageBox.Show(" El usuario no existe.");
                        ValorizarBitacora(bitacoraBE, "MEDIO", "Intento de login con usuario inexistente.");
                        bitacoraBLL.Alta(bitacoraBE);
                    }
                    else
                    {

                        if (resultado == BE.BEreusltadoLog.PasswordIncorrecta && fallo <= 3)
                        {
                            MessageBox.Show("Los datos ingresados son incorrectos.");
                            ValorizarBitacora(bitacoraBE, "MEDIO", "Intento de login con contraseña erronea.");
                            bitacoraBLL.Alta(bitacoraBE);
                            fallo++;
                        }
                        else
                        {
                            usuarioLog.IsBlocked = "SI";
                            MessageBox.Show("Los datos ingresados son erroneos, supero el limite de intentos. Por favor comuniquese con el administrdor!");
                            ValorizarBitacora(bitacoraBE, "ALTO", "Intento de login incorrecto 3 veces");
                            bitacoraBLL.Alta(bitacoraBE);
                        }

                    }
                }
            }
            fallo = 0;

        }

        private void españolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // BLL.BLLidioma.CambiarIdioma("es.txt");
            Idioma.CambiarIdioma("es.txt");
            ActualizarControles();
        }

        private void inglesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // BLL.BLLidioma.CambiarIdioma("en.txt");
            Idioma.CambiarIdioma("en.txt");
            ActualizarControles();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LimpiarCombos()
        {
            txt_usuario.Text = "";
            txt_pass.Text = "";
        }
    }
}
