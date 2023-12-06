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
        BLLencriptacion _blEncriptacion= null;
        BLLusuario _usuarioBLL = null;
        BEusuario usuarioBE = null;
        internal bool hayFiltro { get; set; }
        public BitacoraC()
        {
            InitializeComponent();
            _blBitacora = new BLLbitacoraC();
            _table = new DataTable();
            _usuarioBLL = new BLLusuario();
            usuarioBE= new BEusuario();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    


        private void ActualizarTabla(List<BEbitacoraC> listaBitacora)
        {
            _blEncriptacion= new BLLencriptacion();
            dgv_bitacora.DataSource = null;
            _table = new DataTable();

            _table.Columns.Add("ID BITACORA CAMBIO", typeof(int));
            _table.Columns.Add("ULTIMA MODIFICACION", typeof(string));
            _table.Columns.Add("USUARIO", typeof(string));
            _table.Columns.Add("ACTIVO", typeof(int));
            _table.Columns.Add("CODIGO", typeof(int));
            _table.Columns.Add("NOMBRE", typeof(string));
           // _table.Columns.Add("ESTADO", typeof(string));
            _table.Columns.Add("TIPO", typeof(string));
            _table.Columns.Add("COLOR", typeof(string));
            _table.Columns.Add("PRECIO", typeof(int));


            foreach (BEbitacoraC bitacora in listaBitacora)
            {
                _table.Rows.Add(bitacora.Id, bitacora.UltimaModificacion,bitacora.Usuario, bitacora.Activo, bitacora.IdHerramienta.Codigo, bitacora.IdHerramienta.Nombre, bitacora.Tipo, bitacora.IdHerramienta.Color, bitacora.IdHerramienta.Precio);

            }
            dgv_bitacora.DataSource = _table;
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            
            ActualizarTabla(_blBitacora.FiltrarBitacora(cmb_producto.Text,DateTime.Parse(dt_desde.Text).ToString("yyyy-MM-dd HH:mm:ss"),DateTime.Parse(dt_hasta.Text).ToString("yyyy-MM-dd HH:mm:ss"),cmb_usuario.Text));
            hayFiltro = true;
        }

        private void BitacoraC_Load_1(object sender, EventArgs e)
        {
            hayFiltro = false;
            ActualizarTabla(_blBitacora.Listar());
            RellenarCombos();
            dgv_bitacora.RowHeadersVisible = false;
            dgv_bitacora.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgv_bitacora.MultiSelect = false;
            dgv_bitacora.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_bitacora.AutoGenerateColumns = false;
        }

        private void RellenarCombos()
        {            
            List<BE.BEusuario> usuarios = _usuarioBLL.Consulta().Where(u => u.IsBlocked == "NO").ToList();
            //foreach(var item in usuarios)
            //{
            //    _blEncriptacion.desencriptarAes(item.usuario);
            //}
            cmb_usuario.DataSource = usuarios;
            cmb_usuario.DisplayMember = "Usuario";
            List<string> codigo = _blBitacora.ListarCodigo();
            cmb_producto.DataSource = codigo;
        }

        private void btn_activar_Click(object sender, EventArgs e)
        {

        }
    }
}
