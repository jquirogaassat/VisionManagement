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
    public partial class Backup : Form
    {

        BLL.BLLencriptacion encriptadora = new BLL.BLLencriptacion();
        BLL.BLLgestionbitacora bitacora = new BLL.BLLgestionbitacora();
        BE.BEgestionbitacora bitacoraBE = new BE.BEgestionbitacora();
        BE.BEbackup backupBE = new BE.BEbackup();
            
      


        int cant = 1;
        
        public Backup()
        {
            InitializeComponent();
            
        }

        private void btn_destino_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog destino= new FolderBrowserDialog();
            destino.Description = "Seleccionar destino de copia de seguridad";

            if(destino.ShowDialog()== DialogResult.OK)
            {
                txt_ruta.Text = destino.SelectedPath.ToString();
            }
        }

        public void ValorizarBitacora(BE.BEgestionbitacora bitacoraBE)
        {
            bitacoraBE.IdUsuario = BE.BEcontroladorsesion.GetInstance.Usuario.IdUsuario;
            bitacoraBE.FechaHora = DateTime.Now;
            bitacoraBE.idPatente = 1;
            bitacoraBE.Descripcion = BE.BEcontroladorsesion.GetInstance.Usuario.Nombre + " " + BE.BEcontroladorsesion.GetInstance.Usuario.Apellido 
                                        + "Genero un nuevo backup";

            bitacoraBE.Descripcion = encriptadora.encriptarAES(bitacoraBE.Descripcion);
            bitacoraBE.Criticidad = "MEDIO";



        }


        public void ValorizarEntidad (int particiones, string rutaDestino)
        {
            DateTime fh= DateTime.Now;
            int dia = fh.Day;
            int mes = fh.Month;
            int anio = fh.Year;
            int min = fh.Minute;
            int hora = fh.Hour;
            int segundo = fh.Second;
            string fechaHora = dia + " " + mes + " " + anio + " " + hora + " " + min + " " + segundo;

            backupBE.Usuario = BE.BEcontroladorsesion.GetInstance.Usuario;
            backupBE.Nombre = fechaHora;
            backupBE.FechaAlta = fh;
            backupBE.Particiones = particiones;
            backupBE.Ubicacion = rutaDestino;
            backupBE.Nombre = @"VisionManagement_" + fechaHora;
            
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Globa.menuPrincipal.Show();
            this.Hide();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            BLL.BLLbackup bLLbackup = new BLL.BLLbackup();

            string rutaDestino = txt_ruta.Text + @"\";

            BLL.BLLconexion conexion = new BLL.BLLconexion();

            if(conexion.ComprobarConexion())
            {
                try
                {                   
                    ValorizarEntidad(cant, rutaDestino);
                    bLLbackup.GenerarBackup(backupBE);

                    ValorizarBitacora(bitacoraBE);
                    bitacora.Alta(bitacoraBE);
                    MessageBox.Show("¡Backup generado exitosamente!");
                }
                catch (Exception)
                {
                    MessageBox.Show("No se pudo generar el backup!");                    
                }
            }
            else
            {
                Conexion con = new Conexion();
                con.Show();
            }
            

        
           
        }

        private void rb_1_CheckedChanged(object sender, EventArgs e)
        {
            cant = 1;
        }

        private void rb_2_CheckedChanged(object sender, EventArgs e)
        {
            cant = 2;
        }

        private void rb_3_CheckedChanged(object sender, EventArgs e)
        {
            cant = 3;
        }

        private void rb_4_CheckedChanged(object sender, EventArgs e)
        {
            cant = 4;
        }
    }
}
