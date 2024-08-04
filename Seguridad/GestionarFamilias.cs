using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using BE;
using Aspose.Pdf.Operators;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle;
//using static Org.BouncyCastle.Math.EC.ECCurve;

namespace VisionTFI
{
    public partial class GestionarFamilias : Form
    {     
        BLLpermiso repo;
        BEfamilia seleccion;
        public GestionarFamilias()
        {
            InitializeComponent();
            repo = new BLLpermiso();
            // cargo los permisos netos
            this.cmb_permisos.DataSource = repo.GetAllPermission();
        }  //ok

       
        private void LlenarPatentesFamilias()
        {              
            this.cmb_patentes.DataSource= repo.GetAllPatentes();
            this.cmb_familias.DataSource= repo.GetAllFamilias();
        }  //ok

                
        private void btn_GuardarPermiso_Click(object sender, EventArgs e)
        {
            BEpatente p = new BEpatente()
            {
                Nombre = this.txtNombrePatente.Text,
                Permiso = (BEtipoPermiso)this.cmb_permisos.SelectedItem
            };

            repo.GuardarComponente(p, false);
            LlenarPatentesFamilias();
           

            MessageBox.Show("Patente guardada correctamente!!!");
            txtNombrePatente.Clear();
        }    //ok

        private void btn_guardarFamilia_Click(object sender, EventArgs e)
        {
            BEfamilia f = new BEfamilia()
            {
                Nombre = this.txtNombreFamilia.Text
            };


            repo.GuardarComponente(f, true);
            LlenarPatentesFamilias();
            MessageBox.Show("Familia guradada correctamente!!!");
        }    //ok


        void MostrarFamilia (bool init)
        {
            if (seleccion == null) return;
            IList<BEcomponente> flia = null;

            if(init)
            {
                flia = repo.GetAll("=" + seleccion.Id); // traigo los hijos 

                foreach (var i in flia)
                    seleccion.AgregarHijo(i);
            }
            else
            {
                flia = seleccion.Hijos;
            }

            this.treeConfigurarFamilia.Nodes.Clear();

            TreeNode root = new TreeNode(seleccion.Nombre);
            root.Tag = seleccion;
            this.treeConfigurarFamilia.Nodes.Add(root);

            foreach(var item in flia)
            {
                MostrarEnTreeView(root, item);
            }

            treeConfigurarFamilia.ExpandAll();
        }  // ok


        void MostrarEnTreeView(TreeNode tn, BEcomponente c)
        {
            TreeNode n = new TreeNode(c.Nombre);
            tn.Tag = c;
            tn.Nodes.Add(n);    

            if(c.Hijos!=null)
            {
                foreach(var item in c.Hijos)
                {
                    MostrarEnTreeView(n,item);
                }
            }
        } //ok

        private void btn_addPatente_Click(object sender, EventArgs e)
        {
            if(seleccion != null)
            {
                var patente = (BEpatente)cmb_patentes.SelectedItem;
                    if(patente!= null)
                    {
                        var esta = repo.Existe(seleccion, patente.Id);
                    if (esta)
                        MessageBox.Show("Ya existe la patente indicada!");
                    else
                        {
                         {
                            seleccion.AgregarHijo(patente);
                            MostrarFamilia(false);
                         }
                        }
                    }
            }
        }  // ok

        private void btn_seleccionar_Click(object sender, EventArgs e)
        {
            var tmp = (BEfamilia)this.cmb_familias.SelectedItem;
            seleccion = new BEfamilia();
            seleccion.Id = tmp.Id;
            seleccion.Nombre = tmp.Nombre;

            MostrarFamilia(true);
        }  //ok

        private void btn_agregarFamilia_Click(object sender, EventArgs e)
        {
            if(seleccion != null)
            {
                var famlia= (BEfamilia)cmb_familias.SelectedItem;
                if(famlia != null)
                {
                    var esta = repo.Existe(seleccion, famlia.Id);
                    if (esta)
                        MessageBox.Show("La familia ya esxiste!");
                    else
                    {
                        repo.FillFamilyComponents(famlia);
                        seleccion.AgregarHijo(famlia);
                        MostrarFamilia(false);
                    }
                }
            }
        } // ok
         
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                repo.GuardarFamilia(seleccion);
                MessageBox.Show("Familia guardada exitosamente!");
            }
            catch (Exception)
            {
                MessageBox.Show("Error al guardar la familia");               
            }
        }  // ok

        private void GestionarFamilias_Load(object sender, EventArgs e)
        {
            LlenarPatentesFamilias();
            ActualizarControles();
            IdiomaManager.IdiomaCambiado += OnIdiomaCambiado;
        }   //ok

        private void OnIdiomaCambiado()
        {
            ActualizarControles();
        }

        void ActualizarControles()
        {
            grpPatentesF.Text = IdiomaManager.info["grpPatentes"];
            lbl_todasPatentes.Text = IdiomaManager.info["lbl_todasPatentes"];
            btn_addPatente.Text = IdiomaManager.info["btn_addPatente"];
            groupBox1.Text = IdiomaManager.info["groupBox1"];
            lbl_permisoFamilia.Text = IdiomaManager.info["lbl_permisoFamilia"];
            lbl_nombrePermiso.Text = IdiomaManager.info["lbl_nombrePermiso"];
            btn_GuardarPermiso.Text = IdiomaManager.info["btn_GuardarPermiso"];
            groupBox2.Text = IdiomaManager.info["groupBox2"];
            lbl_todasFamilias.Text = IdiomaManager.info["lbl_todasFamilias"];
            btn_seleccionar.Text = IdiomaManager.info["btn_seleccionar"];
            btn_agregarFamilia.Text = IdiomaManager.info["btn_agregarFamilia"];
            groupBox3.Text = IdiomaManager.info["groupBox3"];
            lbl_nombreFamilia.Text = IdiomaManager.info["lbl_nombreFamilia"];
            btn_guardarFamilia.Text = IdiomaManager.info["btn_guardarFamilia"];
            groupBox4.Text = IdiomaManager.info["groupBox4"];
            btn_guardarF.Text = IdiomaManager.info["btn_guardarF"];
            btn_salirGestionarFamilias.Text = IdiomaManager.info["btn_salirGestionarFamilias"];
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Globa.menuPrincipal.Show();
            this.Hide();
        }
    }
}
