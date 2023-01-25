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
    public partial class ABMusuarios : Form , BE.IObserverForm
    {
        BLL.BLLusuario usuarioBLL = new BLL.BLLusuario();
        BLL.BLLgestionbitacora bitacoraBLL = new BLL.BLLgestionbitacora();
        BE.BEgestionbitacora bitacoraBE = new BEgestionbitacora();
        BE.BEusuario usuarioBE = new BEusuario();
        BLL.BLLencriptacion encriptadora = new BLL.BLLencriptacion();


        public ABMusuarios()
        {
            InitializeComponent();
            btn_permisos.Enabled = false;   
        }

        public void Actualizar(BEusuario u)
        {
            throw new NotImplementedException();
        }

        private void btn_permisos_Click(object sender, EventArgs e)
        {
            GestionarPermisosDeUsuarios gestionarPermisos = new GestionarPermisosDeUsuarios();
            Globa.menuPrincipal.AbrirFormHijoMenu(gestionarPermisos);
        }


        //private void LlenarCombos()
        //{
        //    BLL.BLLidioma idioma = new BLL.BLLidioma();
        //    cmb_idioma.DataSource = idioma.Consulta();
        //    cmb_idioma.DisplayMember = "nombreIdioma";
        //}

        public void ValorizarEntidad(BE.BEusuario usuario)
        {
            usuario.usuario = txt_usuario.Text;
           // usuario.Idioma = (BE.BEidioma)cmb_idioma.SelectedItem;
            usuario.Nombre = txt_nombre.Text;
            usuario.Apellido = txt_apellido.Text;
            usuario.Direccion = txt_direccion.Text;
            usuario.NumeroDocumento = Int32.Parse(txt_dni.Text);
            usuario.Mail = txt_mail.Text;
            //string pass = txt_pass.Text;
            usuario.UserPass = encriptadora.encriptarAES(txt_pass.Text);
            usuario.Telefono= Int32.Parse(txt_telefono.Text);
            usuario.FechaNacimiento = dateTimePicker1.Value;


            
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {   
                
                ValorizarEntidad(usuarioBE);
                BLL.BLLusuario usuarioBLL = new BLL.BLLusuario();
                usuarioBLL.Alta(usuarioBE);
                //AltaUsuario();
                btn_permisos.Enabled = true;
                MessageBox.Show("Usuario creado exitosamente");
                
            }
            catch (Exception)
            {

                MessageBox.Show("Error, no se puede crear el usuario");
                this.Close();
            }

        }

        private void AltaUsuario()
        {
                       
            //bool resultado = usuarioBLL.Alta(usuarioBE);

            //if(resultado)
            //{
            //    MessageBox.Show("Usuario dado de alta");
            //    Globa.gestionarUsuarios = new GestionarUsuarios();
            //    Globa.usuarioBE = usuarioBE;
            //}
            //else
            //{
            //    MessageBox.Show("Error");
            //    this.Close();
            //}
        }

        private void ABMusuarios_Load(object sender, EventArgs e)
        {
            this.Focus();
            //BE.BEcontroladorsesion.GetInstance.Usuario.Agregar(this);
            //Actualizar(BE.BEcontroladorsesion.GetInstance.Usuario);
           // LlenarCombos();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {

        }
    }
}
