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
    public partial class GestionarPermisosDeUsuarios : Form , BE.IObserverForm
    {
        BLL.BLLusuario usuarioBLL = new BLL.BLLusuario();
        BLL.BLLencriptacion encriptadora = new BLL.BLLencriptacion();
        BE.BEgestionbitacora bitacoraBE = new BEgestionbitacora();
        BLL.BLLgestionbitacora bitacoraBLL = new BLL.BLLgestionbitacora();
        BLL.BLLpermiso permisoBll = new BLL.BLLpermiso();

        public GestionarPermisosDeUsuarios()
        {
            InitializeComponent();
        }

        public void ActualizarPermisos(BEusuario u)
        {
            List<BE.BEpermiso> permisosAsignados = usuarioBLL.ObtenerPermisoRecursivo(u).Where(p => p.tipoFamilia != "usuarios").ToList();
            dg_PermisosAsignados.DataSource = permisosAsignados;


            dg_PermisosAsignados.Columns[2].Visible = false;
            dg_PermisosAsignados.Columns[3].Visible = false;
            dg_PermisosAsignados.RowHeadersVisible = false;
            dg_PermisosAsignados.AllowUserToAddRows = false;
            dg_PermisosAsignados.AllowUserToDeleteRows = false;
            dg_PermisosAsignados.EditMode = DataGridViewEditMode.EditProgrammatically;
            dg_PermisosAsignados.MultiSelect = false;
            dg_PermisosAsignados.SelectionMode= DataGridViewSelectionMode.FullRowSelect;


            List<BE.BEpermiso> permisosNoAsignados = usuarioBLL.PermisosNoAsignados(u).Where(p => p.tipoFamilia != "usuarios").ToList();

            dg_PermisosDisponibles.Columns[2].Visible = false;
            dg_PermisosDisponibles.Columns[3].Visible = false;
            dg_PermisosDisponibles.RowHeadersVisible=false;
            dg_PermisosDisponibles.AllowUserToAddRows = false;
            dg_PermisosDisponibles.AllowUserToDeleteRows=false;
            dg_PermisosDisponibles.EditMode = DataGridViewEditMode.EditProgrammatically;
            dg_PermisosDisponibles.MultiSelect = false;
            dg_PermisosDisponibles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }


        public void ValidarPermisos()
        {
            BLL.BLLusuario usuarioBLL = new BLL.BLLusuario();
            BLL.BLLpermiso permisoBLL = new BLL.BLLpermiso();

            ValidarPermiso("Asignar Permiso", btn_asignarPermisos);
            ValidarPermiso("Quitar Permiso", btn_quitarPermiso);
        }

        public bool ValidarPermiso(string permiso, Button boton)
        {
            BLL.BLLencriptacion encriptadora = new BLL.BLLencriptacion();
            BLL.BLLusuario usuarioBLL = new BLL.BLLusuario();
            BLL.BLLpermiso permisoBLL = new BLL.BLLpermiso();
            List<BE.BEpermiso> permisos = new List<BEpermiso>();
            bool validacion = false;



            permiso = encriptadora.encriptarAES(permiso);


            permisos = usuarioBLL.ObtenerPermisoRecursivo(BE.BEcontroladorsesion.GetInstance.Usuario).ToList();
            if(permisos!= null)
            {
                BE.BEcontroladorsesion.GetInstance.Usuario.Permisos = permisos;
                if (usuarioBLL.TienePermiso(BE.BEcontroladorsesion.GetInstance.Usuario, permisoBLL.Consultar(permiso)))
                {
                    boton.Enabled = true;
                    validacion = true;
                }
                else
                {
                    boton.Enabled = false;

                }

            }
            return validacion;
        }




        private void GestionarPermisosDeUsuarios_Load(object sender, EventArgs e)
        {
            this.Focus();
            BE.BEcontroladorsesion.GetInstance.Usuario.Agregar(this);
            ValidarPermisos();
            txt_usuario.Text = Globa.usuarioBE.Apellido + "," + Globa.usuarioBE.Nombre;
            ActualizarPermisos(Globa.usuarioBE);
        }


        public void ValorizarBitacora(BE.BEgestionbitacora bitacoraBE, int i, string descripcion)
        {
            bitacoraBE.IdUsuario = BE.BEcontroladorsesion.GetInstance.Usuario.IdUsuario;
            bitacoraBE.FechaHora = DateTime.Now;


            bitacoraBE.idPatente = i;
            bitacoraBE.Descripcion = BE.BEcontroladorsesion.GetInstance.Usuario.Nombre + " " + BE.BEcontroladorsesion.GetInstance.Usuario.Apellido + descripcion;
            bitacoraBE.Criticidad = "MEDIO";

        }

        private void btn_asignarPermisos_Click(object sender, EventArgs e)
        {
            var row = dg_PermisosDisponibles.SelectedRows[0];
            BE.BEpermiso permisoBE = (BE.BEpermiso)row.DataBoundItem;


            usuarioBLL.Asignar(Globa.usuarioBE, permisoBE);
            ActualizarPermisos(Globa.usuarioBE);
            ValorizarBitacora(bitacoraBE, 14, "Se asigno un permiso");
            bitacoraBLL.Alta(bitacoraBE);
        }

        private bool ValidarQuitarPermiso(BE.BEusuario usuarioBE, BE.BEpermiso permiso)
        {
            BLL.BLLusuario usuarioBLL= new BLL.BLLusuario();
            BLL.BLLpermiso permisoBLL = new BLL.BLLpermiso();

            bool validacion = false;
            List<BE.BEusuario> usuarios = usuarioBLL.Consulta().Where(us => us.IsBlocked == "NO").ToList();
            int contadorUsuarios = 0;
            int u = 0;
            int p = 0;



            if( permiso.esFamilia== false)
            {
                while (validacion&& u < usuarios.Count()&& contadorUsuarios<2)
                {
                    if (usuarioBLL.TienePermiso(usuarios[u],permiso))
                    {
                        contadorUsuarios++;
                    }
                    u++;
                }
                if(contadorUsuarios<2)
                {
                    if(!usuarioBLL.TienePermisoPorFamilia(usuarioBE, permiso))
                    {
                        validacion = false;
                        MessageBox.Show(" No se puede eliminar, quedaria la patente sin asignar", "Operacion Invalida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                if(permisoBLL.ObtenerHijos(permiso).Count==0)
                {
                    validacion = true;

                }
                else
                {
                    contadorUsuarios = 0;
                    u = 0;
                    p = 0;
                    List<BE.BEpermiso> patentes = permisoBLL.ObtenerPermisoRecursivo(permiso).Where(a => a.esFamilia == false).ToList();
                    while(validacion&& p < patentes.Count)
                    {
                        while(validacion && u< usuarios.Count && contadorUsuarios <1)
                        {
                            if (usuarioBLL.AsignacionDirecta(usuarios[u],patentes[p]))
                            {
                                contadorUsuarios++;

                            }
                            else
                            {
                                if(u == usuarios.Count-1)
                                {
                                    validacion =false;
                                    {
                                        MessageBox.Show(" no se puede borrar la familia");
                                    }
                                }
                                else
                                {
                                    u++;
                                }
                            }
                        }
                        p++;
                        u = 0;
                        contadorUsuarios=0;
                    }
                }
            }
            return validacion;
        }

        private void btn_quitarPermiso_Click(object sender, EventArgs e)
        {
            if(dg_PermisosAsignados.SelectedRows.Count>0)
            {
                var row = dg_PermisosAsignados.SelectedRows[0];
                BE.BEpermiso permisoHijo = (BE.BEpermiso)row.DataBoundItem;

                if(ValidarQuitarPermiso(Globa.usuarioBE, permisoHijo))
                {
                    usuarioBLL.QuitarPermiso(Globa.usuarioBE, permisoHijo);
                    ActualizarPermisos(Globa.usuarioBE);
                    ValorizarBitacora(bitacoraBE, 13, "Se quito el permiso");
                    bitacoraBLL.Alta(bitacoraBE);
                }
            }
        }





        public void Actualizar(BEusuario u)
        {
            throw new NotImplementedException();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }


        public void GestionarPermisosDeUsuarios_KeyDown( object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.F1)
            {
                Help ayuda = new Help();
                ayuda.Show(); 
            }
        }
    }
}
