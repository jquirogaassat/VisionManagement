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
    public partial class ABMarticulos : Form , BE.IObserverForm
    {
        BE.BEgestionbitacora bitacoraBE = new BEgestionbitacora();
        BLL.BLLgestionbitacora bitacoraBLL = new BLL.BLLgestionbitacora();
        BLL.BLLarticulo articuloBLL = new BLL.BLLarticulo();
        BLL.BLLencriptacion encriptadora = new BLL.BLLencriptacion();
        BE.BEarticulo articuloBE = new BE.BEarticulo();
        public ABMarticulos()
        {
            InitializeComponent();
        }

        public void Actualizar(BEusuario u)
        {
            throw new NotImplementedException();
        }

        private void ABMarticulos_Load(object sender, EventArgs e)
        {
            Focus();
            txt_nombre.Clear();
            txt_cantidad.Clear();
            txt_color.Clear();
            txt_origen.Clear();
            txt_precio.Clear();
            

            BE.BEcontroladorsesion.GetInstance.Usuario.Agregar(this);

            if(Globa.tipoProceso== "ALTA")
            {
                AdaptarFormularioAlta();
            }
            if(Globa.tipoProceso== "MODIFICACION")
            {
                AdaptarFormularioModificacion();
            }
        }


        private void AdaptarFormularioAlta()
        {
            btn_salir.Visible = true;
        }

        private void AdaptarFormularioModificacion()
        {
            txt_nombre.Text = Globa.articuloBE.Nombre.ToString();
            txt_color.Text = Globa.articuloBE.Color.ToString();
            txt_cantidad.Text = Globa.articuloBE.Cantidad.ToString();
            txt_origen.Text = Globa.articuloBE.Origen.ToString();
            txt_precio.Text = Globa.articuloBE.precio.ToString();
        }

        private void AltaArticulo()
        {
            try
            {
                articuloBE.Nombre = txt_nombre.Text;
                articuloBE.Color = txt_color.Text;
                articuloBE.precio = txt_precio.Text;
                articuloBE.Cantidad = Int32.Parse(txt_cantidad.Text);
                articuloBE.Origen = txt_origen.Text;


                articuloBLL.Alta(articuloBE);

                MessageBox.Show("Articulo dado de alta.");
                Hide();
                Globa.GestionarArticulo = new GestionarArticulo();
                Globa.menuPrincipal.AbrirFormHijoMenu(Globa.GestionarArticulo);

            }
            catch (Exception )
            {
                MessageBox.Show("Error el articulo no se pudo dar de alta");
                this.Hide();
                //throw;
            }

            //Globa.articuloBE = null;
            //Globa.articuloBE = new BE.BEarticulo();
            //Globa.articuloBE.Nombre = txt_nombre.Text;
            //Globa.articuloBE.Color = txt_color.Text;
            //Globa.articuloBE.Cantidad = Int32.Parse(txt_cantidad.Text);
            //Globa.articuloBE.precio = txt_precio.Text;
            //Globa.articuloBE.Origen = txt_origen.Text;

            //bool resultado = articuloBLL.Alta(Globa.articuloBE);

            //if(resultado)
            //{
            //    MessageBox.Show("Articulo dado de alta!");
            //    Hide();
            //    Globa.GestionarArticulo = new GestionarArticulo();
            //    Globa.menuPrincipal.AbrirFormHijoMenu(Globa.GestionarArticulo);                
            //}
            //else
            //{
            //    MessageBox.Show("No se pudo crear el articulo.");
            //    this.Close();
            //}


        }

        private void ModificarArticulo()
        {

            try
            {
                Globa.articuloBE.Nombre = txt_nombre.Text;
                Globa.articuloBE.Cantidad = Int32.Parse(txt_cantidad.Text);
                Globa.articuloBE.Origen = txt_origen.Text;
                Globa.articuloBE.precio = txt_precio.Text;
                Globa.articuloBE.Color = txt_color.Text;

                articuloBLL.Modificar(Globa.articuloBE);
                MessageBox.Show("El articulo ha sido modificado!");
                Hide();
                Globa.GestionarArticulo = new GestionarArticulo();
                Globa.menuPrincipal.AbrirFormHijoMenu(Globa.GestionarArticulo);
            }
            catch (Exception)
            {
                MessageBox.Show("Error, no se pudo modificar el articulo seleccionado.");
                this.Close();                
            }
          

            //bool resultado = articuloBLL.Modificar(Globa.articuloBE);
            //if (resultado)
            //{
                
            //}
            //else
            //{
            //    MessageBox.Show("Error, no se pudo modificar el articulo seleccionado.");
            //    this.Close();

            //}


        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if(Globa.tipoProceso=="ALTA")
            {
                AltaArticulo();
            }
            if(Globa.tipoProceso=="MODIFICACION")
            {
                ModificarArticulo();
            }

            ValorizarBitacora(bitacoraBE);
            bitacoraBLL.Alta(bitacoraBE);

        }

        private void ValorizarBitacora(BE.BEgestionbitacora bEgestionbitacora)
        {
            bEgestionbitacora.IdUsuario = BE.BEcontroladorsesion.GetInstance.Usuario.IdUsuario;
            bEgestionbitacora.FechaHora = DateTime.Now;

            if(Globa.tipoProceso== "ALTA")
            {
                bEgestionbitacora.idPatente = 1;
                bEgestionbitacora.Descripcion = BE.BEcontroladorsesion.GetInstance.Usuario.Nombre + " " + BE.BEcontroladorsesion.GetInstance.Usuario.Apellido + "dio de alta un nuevo producto.";        
            }
            else
            {
                bEgestionbitacora.idPatente = 2;
                bEgestionbitacora.Descripcion = BE.BEcontroladorsesion.GetInstance.Usuario.Nombre + " " + BE.BEcontroladorsesion.GetInstance.Usuario.Apellido + "modifico un producto.";
            }

            bEgestionbitacora.Descripcion = encriptadora.encriptarAES(bEgestionbitacora.Descripcion);
            bEgestionbitacora.Criticidad = "MEDIO";

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Globa.GestionarArticulo.Show();
            Hide();
        }


    }
}
