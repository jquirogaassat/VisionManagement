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
    public partial class Restore : Form
    {
        private BLL.BLLbackup bLLbackup = new BLL.BLLbackup();
        private BLL.BLLencriptacion encriptadora = new BLL.BLLencriptacion();
        private BLL.BLLgestionbitacora BLLgestionbitacora = new BLL.BLLgestionbitacora();
        private BE.BEgestionbitacora BEgestionbitacora = new BE.BEgestionbitacora();

        public Restore()
        {
            InitializeComponent();
        }

        private void Restore_Load(object sender, EventArgs e)
        {
            this.Focus();
            ActualizarGrilla();
            btn_generarRestore.Enabled = false;
            ActualizarControles();
            IdiomaManager.IdiomaCambiado += OnIdiomaCambiado;
        }

        private void OnIdiomaCambiado()
        {
            ActualizarControles();
        }

        void ActualizarControles()
        {
            lbl_listado.Text = IdiomaManager.info["lbl_listado"];
            btn_generarRestore.Text = IdiomaManager.info["btn_generarRestore"];
            btn_salirRestore.Text = IdiomaManager.info["btn_salirRestore"];

        }

        private void  ActualizarGrilla()
        {
            dgv_restore.DataSource = bLLbackup.Consulta();
            dgv_restore.RowHeadersVisible = false;
            dgv_restore.AllowUserToAddRows = false;
            dgv_restore.AllowUserToDeleteRows = false;
            dgv_restore.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgv_restore.MultiSelect = false;
            dgv_restore.SelectionMode= DataGridViewSelectionMode.FullRowSelect;
            dgv_restore.Columns[1].Visible = false;
            dgv_restore.Columns[2].Visible = false;

            dgv_restore.Columns[0].HeaderText = "Ubicación";
            //dgv_restore.Columns[1].HeaderText = "Usuario";
            //dgv_restore.Columns[2].HeaderText = "Fecha de creación";
            dgv_restore.Columns[3].HeaderText = "Id Backup";
            dgv_restore.Columns[4].HeaderText = "Fecha de creación";


        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void ValorizarBitacora(BE.BEgestionbitacora bEgestionbitacora)
        {
            bEgestionbitacora.IdUsuario = BE.BEcontroladorsesion.GetInstance.Usuario.IdUsuario;
            bEgestionbitacora.FechaHora = DateTime.Now;
            bEgestionbitacora.idPatente = 2;
            bEgestionbitacora.Descripcion = BE.BEcontroladorsesion.GetInstance.Usuario.Nombre + " " + BE.BEcontroladorsesion.GetInstance.Usuario.Apellido + " realizo un restore";
            bEgestionbitacora.Descripcion = encriptadora.encriptarAES(bEgestionbitacora.Descripcion);
            bEgestionbitacora.Criticidad = "ALTA";

        }

        private void btn_generarRestore_Click(object sender, EventArgs e)
        {
            try
            {
                string qwery = bLLbackup.Restore(Globa.backupBE);
                ValorizarBitacora(BEgestionbitacora);
                MessageBox.Show("Restore generado con exito!");
                Globa.menuPrincipal.Show();
                this.Hide();
                
            }
            catch (Exception)
            {
                MessageBox.Show("Error, no se puede generar el restore.");
                //throw;
            }
        }

        private void dgv_restore_MouseClick(object sender, MouseEventArgs e)
        {
            btn_generarRestore.Enabled = true;
            var row = dgv_restore.SelectedRows[0];
            Globa.backupBE = (BE.BEbackup)row.DataBoundItem;
        }
    }
}
