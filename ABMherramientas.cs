using BE;
using BLL;
using DAL;
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
    public partial class ABMherramientas : Form , BE.IObserverForm
    {
        BLLencriptacion _encriptadora = new BLLencriptacion();
        BEbitacoraC _bitacoraC = new BEbitacoraC();
        BLLbitacoraC _bitacoraCb = new BLLbitacoraC();
        BEherramientas _herramientas= new BEherramientas();
        BLLherramientas _herramientasBL = new BLLherramientas();
        public ABMherramientas()
        {
            InitializeComponent();
        }

        public void Actualizar(BEusuario u)
        {
            throw new NotImplementedException();
        }

        private void ABMherramientas_Load(object sender, EventArgs e)
        {
            Focus();
            LimpiarTxt();

            BE.BEcontroladorsesion.GetInstance.Usuario.Agregar(this);

            if (Globa.tipoProceso == "ALTA")
            {
                AdaptarFormularioAlta();
            }
            if (Globa.tipoProceso == "MODIFICACION")
            {
                AdaptarFormularioModificacion();
            }
        }
        private void LimpiarTxt()
        {
            txt_nombre.Clear();
            txt_color.Clear();
            txt_codigo.Clear();
            txt_origen.Clear();
            txt_precio.Clear();
            txt_estado.Clear();
            txt_disponible.Clear();
        }

        private void AdaptarFormularioAlta()
        {
            btn_salir.Visible = true;
        }

        private void AdaptarFormularioModificacion()
        {
            txt_nombre.Text = Globa.herramientaBE.Nombre.ToString();
            txt_color.Text = Globa.herramientaBE.Color.ToString();
            txt_origen.Text= Globa.herramientaBE.Origen.ToString();
            txt_codigo.Text = Globa.herramientaBE.Codigo.ToString();
            txt_precio.Text = Globa.herramientaBE.Precio.ToString();
            txt_estado.Text = Globa.herramientaBE.Estado.ToString();
            txt_disponible.Text = Globa.herramientaBE.Disponible.ToString();
        }

        private void AltaHerramienta()
        {
            try
            {
                _herramientas.Nombre = txt_nombre.Text;
                _herramientas.Color = txt_color.Text;
                _herramientas.Origen = txt_origen.Text;
                _herramientas.Codigo = Int32.Parse(txt_codigo.Text);
                _herramientas.Precio = Int32.Parse(txt_precio.Text);
                _herramientas.Estado = Int32.Parse(txt_estado.Text);
                _herramientas.Disponible = txt_disponible.Text;
                _herramientas.UltimaModificacion= DateTime.Now;

                _herramientasBL.Alta(_herramientas,BEcontroladorsesion.GetInstance.Usuario.usuario.ToString());
                _bitacoraC.UltimaModificacion = DateTime.Now;
               // _bitacoraC.Usuario = BEcontroladorsesion.GetInstance.Usuario.usuario.ToString();
                _bitacoraC.Usuario = _encriptadora.desencriptarAes(BEcontroladorsesion.GetInstance.Usuario.usuario);
                _bitacoraC.Activo = 1;
                _bitacoraC.Tipo = "AGREGADO";
                _bitacoraC.IdHerramienta = DALherramientas.Obtener(_herramientas.Codigo);
                _bitacoraCb.ReportarBitacora(_bitacoraC);

                MessageBox.Show("Herramienta dada de alta");
                Hide();
                Globa.GestionarHerramienta = new GestionarHerramientsa();
                Globa.menuPrincipal.AbrirFormHijoMenu(Globa.GestionarHerramienta);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede dar de alta la herramienta" + ex);
                Hide();
            }
        }

        private void ModificarHerramienta()
        {
            try
            {
                Globa.herramientaBE.Nombre = txt_nombre.Text;
                Globa.herramientaBE.Color = txt_color.Text;
                Globa.herramientaBE.Origen = txt_origen.Text;
                Globa.herramientaBE.Codigo = Int32.Parse(txt_codigo.Text);
                Globa.herramientaBE.Precio = Int32.Parse(txt_precio.Text);
                Globa.herramientaBE.Estado = Int32.Parse(txt_estado.Text);
                Globa.herramientaBE.Disponible = txt_disponible.Text;
                Globa.herramientaBE.UltimaModificacion= DateTime.Now;

                _herramientasBL.Modificar(Globa.herramientaBE);
                _bitacoraC.UltimaModificacion= DateTime.Now;
                _bitacoraC.Usuario = _encriptadora.desencriptarAes(BEcontroladorsesion.GetInstance.Usuario.usuario);
                _bitacoraC.Activo = 1;
                _bitacoraC.Tipo = "MODIFICADO";
                _bitacoraC.IdHerramienta= Globa.herramientaBE;
                _bitacoraCb.ReportarBitacora(_bitacoraC);
                MessageBox.Show("Herramienta modificada");
                Hide();
                Globa.GestionarHerramienta = new GestionarHerramientsa();
                Globa.menuPrincipal.AbrirFormHijoMenu(Globa.GestionarHerramienta);
            }
            catch(Exception ex) 
            {
                MessageBox.Show("No se puede modificar la herramienta" + ex);
                Hide();
            }
        }
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if(Globa.tipoProceso=="ALTA")
            {
                AltaHerramienta();
            }
            if(Globa.tipoProceso=="MODIFICACION")
            {
                ModificarHerramienta();
            }

           // ValorizarBitC();
        }

        private void btn_serializar_Click(object sender, EventArgs e)
        {
            BEherramientas herramienta = new BEherramientas()
            {
                Nombre = txt_nombre.Text,
                Color = txt_color.Text,
                Origen = txt_origen.Text,
                Codigo = int.Parse(txt_codigo.Text),
                Precio = int.Parse(txt_precio.Text),
                Estado = int.Parse(txt_estado.Text),
                Disponible = txt_disponible.Text,
            };
            XmlSerializator.Serializar(herramienta, "Herramienta.xml");
            MessageBox.Show("Serializacion ok!");
            LimpiarTxt();
        }

        private void btn_deserializar_Click(object sender, EventArgs e)
        {
            BEherramientas herramienta = new BEherramientas();
            herramienta = (BEherramientas)XmlSerializator.Deserializar<BEherramientas>("Herramienta.xml");
            txt_nombre.Text= herramienta.Nombre.ToString();
            txt_color.Text= herramienta.Color.ToString();
            txt_codigo.Text = herramienta.Codigo.ToString();
            txt_origen.Text=herramienta.Origen.ToString();
            txt_precio.Text=herramienta.Precio.ToString();
            txt_estado.Text=herramienta.Estado.ToString();
            txt_disponible.Text = herramienta.Disponible.ToString();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //private void ValorizarBitacoraC(BE.BEbitacoraC bitacoraC)
        //{
        //    bitacoraC.
        //}


    }
}
