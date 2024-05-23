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
    public partial class AdministrarUsers : Form, BE.IObserverForm
    {
        BLL.BLLusuario usuarioBLL = new BLL.BLLusuario();
        BLL.BLLencriptacion encriptadora = new BLL.BLLencriptacion();

        public AdministrarUsers()
        {
            InitializeComponent();
           // ActualizarUsuarios();
      
        }


        public void ActualizarUsuarios()
        {
            List<BE.BEusuario> usuarios;

            if(checkActivos.Checked)
            {
                usuarios = (usuarioBLL.Consulta().Where(u=> u.IsBlocked=="NO")).ToList();
                
            }
            else
            {
                usuarios= usuarioBLL.Consulta();
            }


            dgv_user.DataSource = usuarios;
            

            dgv_user.Columns[0].Visible = false;
            dgv_user.Columns[1].Visible = false;
            dgv_user.Columns[2].Visible = false;
            dgv_user.Columns[3].Visible = true;
            dgv_user.Columns[4].Visible = true;
            dgv_user.Columns[7].Visible = false;
            dgv_user.Columns[16].Visible = false;
            dgv_user.Columns[15].Visible = false;
            dgv_user.Columns[13].Visible = true;
            dgv_user.Columns[8].Visible= false;
            dgv_user.Columns[12].Visible = false;
            dgv_user.Columns[15].Visible = false;

            dgv_user.Columns[4].HeaderText = "Nombre";
            dgv_user.Columns[5].HeaderText = "Apellido";
            dgv_user.Columns[13].HeaderText = "Fecha de alta";
            dgv_user.Columns[3].HeaderText = "Is Blocked";
           // dgv_user.Columns[2].HeaderText = "Usuario";
            dgv_user.Columns[9].HeaderText = "Telefono";
            dgv_user.Columns[10].HeaderText = "Direccion";
            dgv_user.Columns[11].HeaderText = "Mail";
           // dgv_user.Columns[12].HeaderText = "Mail";
            dgv_user.Columns[14].HeaderText = "Intentos fallidos";
            

            dgv_user.RowHeadersVisible = false;
            dgv_user.AllowUserToAddRows = false;
            dgv_user.AllowUserToDeleteRows = false;
            dgv_user.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgv_user.MultiSelect = false;
            dgv_user.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
        }


        public void ValidarPermisos()
        {
            if(dgv_user.SelectedRows.Count >0)
            {
                ValidarPermiso("Eliminar usuario", button1);
                ValidarPermiso("Modificar usuario", btn_update);
            }
        }

        public void ValidarPermiso(string permiso, Button boton)
        {
            //BLL.BLLencriptacion encriptadora = new BLL.BLLencriptacion();
            //BLL.BLLusuario usuarioBLL = new BLL.BLLusuario();
            //BLL.BLLpermiso permisoBLL = new BLL.BLLpermiso();
            //List<BE.BEpermiso> permisos = new List<BE.BEpermiso>();

            //permiso = encriptadora.encriptarAES(permiso);


            //permisos = usuarioBLL.ObtenerPermisoRecursivo(BE.BEcontroladorsesion.GetInstance.Usuario).ToList();

            //if(permisos!=null)
            //{
            //    BE.BEcontroladorsesion.GetInstance.Usuario.Permisos = permisos;

            //    if(!usuarioBLL.TienePermiso(BE.BEcontroladorsesion.GetInstance.Usuario, permisoBLL.Consultar(permiso)))
            //    {
            //        boton.Enabled = false;
            //    }
            //    else
            //    {
            //        boton.Enabled = true;   
            //    }
            //}
        }

        private void AdministrarUsers_Load(object sender, EventArgs e)
        {

            btn_nuevoUser.Enabled = true;
            button1.Enabled = true;
            btn_update.Enabled = true;
            this.Focus();
           // Actualizar(BE.BEcontroladorsesion.GetInstance.Usuario);
            //BE.BEcontroladorsesion.GetInstance.Usuario.Agregar(this);
          
            //ValidarPermiso("Crear Usuario", btn_nuevoUser);

            ActualizarUsuarios();
           // BLL.BLLgestionbitacora bitacora = new BLL.BLLgestionbitacora();
            //ActualizarUsuarios();
        }


        private void dgv_user_MouseClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgv_user.SelectedRows[0];
            Globa.usuarioBE = (BE.BEusuario)row.DataBoundItem;
            if(Globa.usuarioBE.IsBlocked=="NO")
            {
                ValidarPermisos();
            }
        }

        public void Actualizar(BEusuario u)
        {
            //BLL.BLLidioma idiomaBLL = new BLL.BLLidioma();
            //List<Button> botones = this.Controls.OfType<Button>().ToList();

            //foreach(var b in botones)
            //{
            //    b.Text = idiomaBLL.Traducir(BE.BEcontroladorsesion.GetInstance.Usuario.Idioma, b.Text);
            //}
            //checkActivos.Text = idiomaBLL.Traducir(BE.BEcontroladorsesion.GetInstance.Usuario.Idioma, checkActivos.Text);
        
        }

        private void btn_nuevoUser_Click(object sender, EventArgs e)
        {
            Globa.tipoProceso = "alta";
            ABMusuarios aBMusuariosAlta=new ABMusuarios();
            Hide();
            Globa.menuPrincipal.AbrirFormHijoMenu(aBMusuariosAlta);
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            Globa.tipoProceso = "modificar";
            ABMusuarios aBMusuariosModificar= new ABMusuarios();
            Hide();
            Globa.menuPrincipal.AbrirFormHijoMenu(aBMusuariosModificar);
        }

        private bool ValidarEliminarUsuarios(BE.BEusuario usuario)
        {

            return false;
            //List<BE.BEusuario> usuarios = new List<BEusuario>();
            //List<BE.BEpermiso> familias = new List<BEpermiso>();
            //List<BE.BEpermiso> patentes = new List<BEpermiso>();


            //bool validacion = true;
            //usuarios = usuarioBLL.Consulta().Where(us => us.IsBlocked == "NO").ToList();
            //int contadorUser = 0;
            //int p = 0;
            //int u = 0;

            //if(usuario.IdUsuario!=BE.BEcontroladorsesion.GetInstance.Usuario.IdUsuario)
            //{
            ////    BE.BEcontroladorsesion.GetInstance.Usuario.Permisos = usuarioBLL.ObtenerPermisoRecursivo(BE.BEcontroladorsesion.GetInstance.Usuario).ToList();
            ////    patentes = usuarioBLL.ObtenerPermisoRecursivo(usuario).Where(f => f.esFamilia == false).ToList();

            ////    if(patentes.ToList().Count()>0)
            ////    {
            ////        while( validacion && p < patentes.ToList().Count())
            ////        {
            ////            while(u < usuarios.Count()&& contadorUser<2)
            ////            {
            ////                if (usuarioBLL.TienePermiso(usuarios[u], patentes[p]))
            ////                {
            ////                    contadorUser++;
            ////                }
            ////                else
            ////                {

            ////                }
            ////                u++;
            ////            }
            ////            if(contadorUser<2)
            ////            {
            ////                validacion = false;
            ////                MessageBox.Show("No se puede eliminar el usuario ya que quedarian patentes sin asignar","Imposible realizar operacion", MessageBoxButtons.OK , MessageBoxIcon.Warning);
            ////            }

            ////            p++;
            ////            u = 0;
            ////            contadorUser = 0;
            ////        }
            ////    }
            ////}
            ////else
            ////{
            ////    validacion = false;
            ////    MessageBox.Show("No se puede eliminar el usuario ya que tiene la sesion activa", "Imposible realizar operacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            ////}
            ////return validacion;
        }

        //private void btn_eliminarUser_Click(object sender, EventArgs e)
        //{
        //    var row = dgv_user.SelectedRows[0];
        //    BE.BEusuario bEusuario = (BE.BEusuario)row.DataBoundItem;
        //    usuarioBLL.Baja(bEusuario);
        //    ActualizarUsuarios();
        //    MessageBox.Show("Usuario eliminado");
        //    //if(ValidarEliminarUsuarios(Globa.usuarioBE))
        //    //{
        //    //    usuarioBLL.QuitarAsignaciones(Globa.usuarioBE);
        //    //    usuarioBLL.Baja(Globa.usuarioBE);
        //    //    ActualizarUsuarios();
        //    //    MessageBox.Show("El usuario se elimno correctamente", "Usuario eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    //}
        //    //else
        //    //{
        //    //    MessageBox.Show("El usuario no se pudo eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //    //}
        //}

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Globa.menuPrincipal.Show();
            this.Hide();
        }

        private void checkActivos_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarUsuarios();
        }
        //private void AdministrarUsers_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if(e.KeyCode == Keys.F1)
        //    {
        //        Help ayuda = new Help();
        //        ayuda.Show();
        //    }
        //}

        private void dgv_user_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var row = dgv_user.SelectedRows[0];
            BE.BEusuario bEusuario = (BE.BEusuario)row.DataBoundItem;
            usuarioBLL.Baja(bEusuario);
            ActualizarUsuarios();
            MessageBox.Show("Usuario eliminado");

        }

        private void btn_desbloquearUser_Click(object sender, EventArgs e)
        {
            var row = dgv_user.SelectedRows[0];
            BEusuario bEusuario= (BEusuario)row.DataBoundItem;
            usuarioBLL.DesbloquearUsuario(bEusuario);
            ActualizarUsuarios();
            MessageBox.Show("Usuario desbloqueado");
        }
    }
}
