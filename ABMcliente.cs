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
    public partial class ABMcliente : Form, BE.IObserverForm
    {

        BE.BEcliente clienteBE = new BEcliente();
        BLL.BLLcliente clienteBLL = new BLL.BLLcliente();
        BE.BEgestionbitacora bitacroBE = new BEgestionbitacora();
        BLL.BLLgestionbitacora bitacoraBLL= new BLL.BLLgestionbitacora();  
        BLL.BLLencriptacion encriptadora= new BLL.BLLencriptacion();

        public ABMcliente()
        {
            InitializeComponent();
        }

        


        public void AdaptarFormularioToAlta()
        {
            lbl_tipoproceso.Text = "Alta de cliente";
            btn_salir.Visible = true;
            btn_guardar.Visible = true;
            //btn_baja.Visible = false;

        }

        public void AdaptarFormularioToModificacion()
        {
           // btn_salir.Enabled = false;
           // btn_salir.Visible = false;

            
            txt_nombre.Text= Globa.cllienteBE.Nombre;
            txt_apellido.Text = Globa.cllienteBE.Apellido;
            txt_cuit.Text = Globa.cllienteBE.Cuit;
            txt_mail.Text = Globa.cllienteBE.Email;
            txt_direccion.Text = Globa.cllienteBE.Direccion;
            txt_localidad.Text = Globa.cllienteBE.Localidad;
            txt_telefono.Text = Globa.cllienteBE.Telefono;

        }

        public void Actualizar(BEusuario u)
        {
            throw new NotImplementedException();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if(Globa.tipoProceso == "Alta")
            {
                AltaCliente();
            }
            if(Globa.tipoProceso== "Modificacion")
            {
                ModificarCliente();

            }
        }

        private void ModificarCliente()
        {            
            Globa.cllienteBE.Nombre = txt_nombre.Text;
            Globa.cllienteBE.Apellido = txt_apellido.Text;
            Globa.cllienteBE.Cuit = txt_cuit.Text;
            Globa.cllienteBE.Email = txt_mail.Text;
            Globa.cllienteBE.Direccion = txt_direccion.Text;
            Globa.cllienteBE.Localidad = txt_localidad.Text;
            Globa.cllienteBE.Telefono=txt_telefono.Text;

            bool resultado = clienteBLL.Modificar(Globa.cllienteBE);

            if( resultado)
            {
                MessageBox.Show("Cliente modificado con exito");
                Hide();
                Globa.GestionarCliente = new GestionarSocio();
                Globa.menuPrincipal.AbrirFormHijoMenu(Globa.GestionarCliente);
            }
            else
            {
                MessageBox.Show("Error");
                this.Close();
            }
        }

        private void AltaCliente()
        {

            clienteBE.Nombre = txt_nombre.Text;
            clienteBE.Apellido = txt_apellido.Text;
            clienteBE.Cuit = txt_cuit.Text;
            clienteBE.Email = txt_mail.Text;
            clienteBE.Direccion = txt_direccion.Text;
            clienteBE.Localidad = txt_localidad.Text;
            clienteBE.Telefono = txt_telefono.Text;

            bool resultado = clienteBLL.Alta(clienteBE);

            if (resultado)
            {
                MessageBox.Show("Cliente dado de alta.");
                Hide();
                Globa.GestionarCliente = new GestionarSocio();
                Globa.menuPrincipal.AbrirFormHijoMenu(Globa.GestionarCliente);
            }
            else
            {
                MessageBox.Show("Error, el cliente no se pudo crear.");
                this.Close();
            }

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Globa.GestionarCliente.Show();
            this.Close();
        }

        private void ABMcliente_Load(object sender, EventArgs e)
        {
            //this.Focus();
            //Actualizar(BE.BEcontroladorsesion.GetInstance.Usuario);
            //BE.BEcontroladorsesion.GetInstance.Usuario.Agregar(this);

            if(Globa.tipoProceso == "Alta")
            {
                AdaptarFormularioToAlta();
            }
            if (Globa.tipoProceso == "Modificacion")
            {

                AdaptarFormularioToModificacion();
            }
                
            var s = Enum.GetValues(typeof(BE.Enum.Situacion.Situacion));
            foreach (var item in s )
            {
                cmb_situacion.Items.Add(item);
            }


        }
    }
}
