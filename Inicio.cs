using SpreadsheetLight;
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
using DocumentFormat.OpenXml.Spreadsheet;
//using ClosedXML.Excel;


namespace VisionTFI
{
    public partial class Inicio : Form
    {
      
        public Inicio()
        {
            InitializeComponent();

            int i = 0;
            while (i< 3000)
            {
                i++;
            }

            i = 3000;

            while (i<6000)
            {
                i++;
            }

            i = 6000;

            while(i<10000)
            {
                i++;
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {              
            MessageBox.Show(" Digitos arreglados!");
            Globa.menuPrincipal.Show();
            this.Hide();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            this.Focus();
            dgv_errores.DataSource = Globa.errores;
            dgv_errores.RowHeadersVisible = false;
            dgv_errores.AllowUserToAddRows = false;
            dgv_errores.AllowUserToDeleteRows = false;
            dgv_errores.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgv_errores.MultiSelect = false;
            dgv_errores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgv_errores.Columns[0].HeaderText = "ID ERROR";
            dgv_errores.Columns[0].Visible = false;
            dgv_errores.Columns[1].HeaderText = "TABLA";
            dgv_errores.Columns[2].HeaderText = "TIPO DE ERROR";
            dgv_errores.Columns[3].HeaderText = "ID DEL ERROR";

            dgv_errores.Show();

        
        }       

        private void btn_restore_Click(object sender, EventArgs e)
        {
            Globa.restore.Show();
            this.Hide();

        }
    }
}
