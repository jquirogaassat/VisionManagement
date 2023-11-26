using BE;
using BLL;
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
    public partial class BitacoraC : Form
    {
         BLLbitacoraC _blBitacora= null;
        internal DataTable _table= null;
        public BitacoraC()
        {
            InitializeComponent();
            _blBitacora = new BLLbitacoraC();
            _table = new DataTable();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BitacoraC_Load(object sender, EventArgs e)
        {
            ActualizarTabla(_blBitacora.Listar());
            dgv_bitacora.RowHeadersVisible = false;
            dgv_bitacora.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgv_bitacora.MultiSelect = false;
            dgv_bitacora.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_bitacora.AutoGenerateColumns = false;
        }


        private void ActualizarTabla(List<BEbitacoraC>listaBitacora)
        {
             dgv_bitacora.DataSource = null;
            _table= new DataTable();

            _table.Columns.Add("ID CAMBIO", typeof(int));
            _table.Columns.Add("ULTIMA MODIFICACION", typeof(string));
            _table.Columns.Add("USUARIO",typeof(string));
            _table.Columns.Add("ACTIVO", typeof(int));
            _table.Columns.Add("ID HERRAMIENTA", typeof(int));
            _table.Columns.Add("DISPONIBLE", typeof(string));
            _table.Columns.Add("ESTADO", typeof(string));
            _table.Columns.Add("TIPO", typeof(string));


            foreach(BEbitacoraC bitacora in listaBitacora)
            {
                _table.Rows.Add(bitacora.Id,bitacora.UltimaModificacion,bitacora.Usuario,bitacora.Activo,bitacora.Herramienta.Id,bitacora.Herramienta.Disponible,bitacora.Herramienta.Estado,bitacora.Tipo);
                
            }
            dgv_bitacora.DataSource= _table;
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            ActualizarTabla(_blBitacora.Listar());
        }
    }
}
