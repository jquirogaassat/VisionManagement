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
        BE.BEgestionbitacora bitacoraBE = new BEgestionbitacora();
        BLL.BLLgestionbitacora bitacoraBLL = new BLL.BLLgestionbitacora();
        BLL.BLLusuario repo;
        BLL.BLLpermiso permisoRepo;
        BEusuario seleccion;
        BEusuario tmp;


        public GestionarPermisosDeUsuarios()
        {
            InitializeComponent();
            repo = new BLL.BLLusuario();
            permisoRepo = new BLL.BLLpermiso();
            this.cboUsuarios.DataSource = repo.Listar();
            this.cboPatentes.DataSource= permisoRepo.GetAllPatentes();
            this.cboFamilias.DataSource = permisoRepo.GetAllFamilias();
        }


        void LlenarTreeView(TreeNode padre, BEcomponente c)
        {
            TreeNode hijo = new TreeNode(c.Nombre);
            hijo.Tag = c;
            padre.Nodes.Add(hijo);

            foreach(var item in c.Hijos)
            {
                LlenarTreeView(hijo, item);
            }
        }

        void MostrarPermsios(BEusuario user)
        {
            treeView1.Nodes.Clear();
            TreeNode root= new TreeNode(user.Nombre);
            foreach( var item in user.Permisos)
            {
                LlenarTreeView(root, item);
            }
            treeView1.Nodes.Add(root);
            treeView1.ExpandAll();
        }

      

        private void btn_agregarPatentes_Click(object sender, EventArgs e)
        {
            if(tmp!=null)
            {
                var patente = (BEpatente)cboPatentes.SelectedItem;
                if(patente!=null)
                {
                    var esta = false;

                    foreach(var item in tmp.Permisos)
                    {
                        if(permisoRepo.Existe(item,patente.Id))
                        {
                            esta = true;
                            break;
                        }
                    }
                    if(esta)
                    {
                        MessageBox.Show("El ususario ya tiene la patente asignada");
                    }
                    else
                    {
                        {
                            tmp.Permisos.Add(patente);
                            MostrarPermsios(tmp);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione el usuario");
            }
        }






        public void ValorizarBitacora(BE.BEgestionbitacora bitacoraBE, int i, string descripcion)
        {
            bitacoraBE.IdUsuario = BE.BEcontroladorsesion.GetInstance.Usuario.IdUsuario;
            bitacoraBE.FechaHora = DateTime.Now;


            bitacoraBE.idPatente = i;
            bitacoraBE.Descripcion = BE.BEcontroladorsesion.GetInstance.Usuario.Nombre + " " + BE.BEcontroladorsesion.GetInstance.Usuario.Apellido + descripcion;
            bitacoraBE.Criticidad = "MEDIO";

        }

      





        public void Actualizar(BEusuario u)
        {
            throw new NotImplementedException();
        }

      


        public void GestionarPermisosDeUsuarios_KeyDown( object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.F1)
            {
                Help ayuda = new Help();
                ayuda.Show(); 
            }
        }

        private void btn_agregarFamilias_Click(object sender, EventArgs e)
        {
            if(tmp!=null)
            {
                var flia=(BEfamilia)cboFamilias.SelectedItem;
                if(flia!=null)
                {
                    var esta = false;

                    foreach(var item in tmp.Permisos)
                    {
                        if(permisoRepo.Existe(item, flia.Id))
                        {
                            esta = true;
                       
                        }    
                    }
                    if(esta)
                    {
                        MessageBox.Show("El ususario ya tiene la familia indicada");
                    }
                    else
                    {
                        {
                            permisoRepo.FillFamilyComponents(flia);
                            tmp.Permisos.Add(flia);
                            MostrarPermsios(tmp);
                        }
                    }
                }

            }
            else
            {
                MessageBox.Show("Seleccione usuario");
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                repo.GuardarPermisos(tmp);
                MessageBox.Show("Usuario guardado correctamente!");
            }
            catch (Exception)
            {
                MessageBox.Show("Error al guardar usuario");                
            }
        }

        private void cmdConfigurar_Click_1(object sender, EventArgs e)
        {
            seleccion = (BEusuario)this.cboUsuarios.SelectedItem;
            tmp = new BEusuario(); // hago una copia para no modificar el que esta en el combo
            tmp.IdUsuario = seleccion.IdUsuario;
            tmp.Nombre = seleccion.Nombre;
            permisoRepo.FillUserComponents(tmp);

            MostrarPermsios(tmp);

        }
    }
}
