using BE;
using BLL;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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

            _table.Columns.Add("ID BITACORA CAMBIO", typeof(int)); //0
            _table.Columns.Add("ULTIMA MODIFICACION", typeof(DateTime));  //1
            _table.Columns.Add("USUARIO", typeof(string));  //2
            _table.Columns.Add("ACTIVO", typeof(int));//3
            _table.Columns.Add("ID HERRAMIENTA", typeof(int));//4
            _table.Columns.Add("CODIGO", typeof(int));//5
            _table.Columns.Add("NOMBRE", typeof(string));//6
            _table.Columns.Add("ORIGEN", typeof(string));//7
            _table.Columns.Add("TIPO", typeof(string));//8
            _table.Columns.Add("COLOR", typeof(string));//9
            _table.Columns.Add("PRECIO", typeof(int));//10
            _table.Columns.Add("DISPONIBLE", typeof(string));//11


            foreach (BEbitacoraC bitacora in listaBitacora)
            {
                _table.Rows.Add(bitacora.Id, bitacora.UltimaModificacion,bitacora.Usuario, bitacora.Activo, bitacora.IdHerramienta.Id,
                    bitacora.IdHerramienta.Codigo, bitacora.IdHerramienta.Nombre, bitacora.IdHerramienta.Origen, bitacora.Tipo, bitacora.IdHerramienta.Color, bitacora.IdHerramienta.Precio, bitacora.IdHerramienta.Disponible);

            }
            dgv_bitacora.DataSource = _table;
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            
            ActualizarTabla(_blBitacora.FiltrarBitacora(cmb_producto.Text,DateTime.Parse(dt_desde.Text).ToString("MM-dd-yyyy HH:mm:ss"),DateTime.Parse(dt_hasta.Text).ToString("MM-dd-yyyy HH:mm:ss"),cmb_usuario.Text));
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
            ActualizarControles();
            IdiomaManager.IdiomaCambiado += OnIdiomaCambiado;
        }

        private void OnIdiomaCambiado()
        {
            ActualizarControles();
        }

        void ActualizarControles()
        {
            lbl_bitacoraCambios.Text = IdiomaManager.info["lbl_bitacoraCambios"];
            lbl_codigoProducto.Text = IdiomaManager.info["lbl_codigoProducto"];
            lbl_usuarioBitacoraCambios.Text = IdiomaManager.info["lbl_usuarioBitacoraCambios"];
            lba_desdeBitacoraCambios.Text = IdiomaManager.info["lba_desdeBitacoraCambios"];
            lbl_hastaBitacoraCambios.Text = IdiomaManager.info["lbl_hastaBitacoraCambios"];
            btn_consultarBitacoraCambios.Text = IdiomaManager.info["btn_consultarBitacoraCambios"];
            btn_activarBitacoraCambios.Text = IdiomaManager.info["btn_activarBitacoraCambios"];
            btn_cerrarBitacoraCambios.Text = IdiomaManager.info["btn_cerrarBitacoraCambios"];
        }

        private void RellenarCombos()
        {            
            List<BE.BEusuario> usuarios = _usuarioBLL.Consulta().Where(u => u.IsBlocked == "NO").ToList();            
            cmb_usuario.DataSource = usuarios;
            cmb_usuario.DisplayMember = "Usuario";
            List<string> codigo = _blBitacora.ListarCodigo();
            cmb_producto.DataSource = codigo;
        }

        private void btn_activar_Click(object sender, EventArgs e)
        {
            if (dgv_bitacora.SelectedRows.Count > 0)
            {
                if (dgv_bitacora.SelectedRows[0].Cells[3].Value.ToString()=="0")
                {
                    BEbitacoraC _bitacoraC = new BEbitacoraC();
                    ValorizarBitacora(_bitacoraC);
                    if (_blBitacora.Activar(_bitacoraC))
                    {
                        MessageBox.Show("¡Estado actualizado en la tabla Herramientas!");
                    }
                    else
                    {
                        ActualizarTabla(_blBitacora.Listar());
                    }                        
                }
                else
                {
                    MessageBox.Show("¡El item ya se encuentra activo!");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro.");
            }
        }

        private void ValorizarBitacora(BEbitacoraC bitacora)
        {
            bitacora.Id = int.Parse(dgv_bitacora.SelectedRows[0].Cells[0].Value.ToString());   //0 id                 
            bitacora.UltimaModificacion =DateTime.Parse(dgv_bitacora.SelectedRows[0].Cells[1].Value.ToString());//1 ultmod
            bitacora.Usuario = dgv_bitacora.SelectedRows[0].Cells[2].Value.ToString();//2 user
            bitacora.Activo = int.Parse(dgv_bitacora.SelectedRows[0].Cells[3].Value.ToString());//3 activo
            bitacora.IdHerramienta = new BEherramientas();
            bitacora.IdHerramienta.Id = int.Parse(dgv_bitacora.SelectedRows[0].Cells[4].Value.ToString());// 4 id herramienta
            bitacora.IdHerramienta.Codigo= int.Parse(dgv_bitacora.SelectedRows[0].Cells[5].Value.ToString());//5 codigo
            bitacora.IdHerramienta.Nombre= dgv_bitacora.SelectedRows[0].Cells[6].Value.ToString();// 6 nombre
            bitacora.IdHerramienta.Origen = dgv_bitacora.SelectedRows[0].Cells[7].Value.ToString();//7 origen
            bitacora.Tipo= dgv_bitacora.SelectedRows[0].Cells[8].Value.ToString();//8 tipo
            bitacora.IdHerramienta.Color = dgv_bitacora.SelectedRows[0].Cells[9].Value.ToString(); // 9 color
            bitacora.IdHerramienta.Precio = int.Parse(dgv_bitacora.SelectedRows[0].Cells[10].Value.ToString());//10 precio
            bitacora.IdHerramienta.Disponible= dgv_bitacora.SelectedRows[0].Cells[11].Value.ToString();
            bitacora.IdHerramienta.UltimaModificacion = DateTime.Parse(dgv_bitacora.SelectedRows[0].Cells[1].Value.ToString());

           
        }
    }
}
