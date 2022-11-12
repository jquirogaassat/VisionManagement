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
    public partial class AdministrarUsers : Form
    {
        BLL.BLLusuario usuarioBLL = new BLL.BLLusuario();


        public AdministrarUsers()
        {
            InitializeComponent();
        }


        public void ActualizarUsuarios()
        {
            List<BE.BEusuario> usuarios;

            if(checkActivos.Checked)
            {
                usuarios = (usuarioBLL.Consulta().Where(u=> u.IsBlocked=="NO")).ToList();   
            }
            else
            {
                usuarios= usuarioBLL.Consulta();
            }


            dgv_user.DataSource = usuarios;

            dgv_user.Columns[0].Visible = false;
            dgv_user.Columns[1].Visible = false;
            dgv_user.Columns[2].Visible = false;
            dgv_user.Columns[3].Visible = false;
            dgv_user.Columns[4].Visible = false;
            dgv_user.Columns[16].Visible = false;
            dgv_user.Columns[17].Visible = false;


            dgv_user.Columns[5].HeaderText = "Nombre";
            dgv_user.Columns[6].HeaderText = "Apelido";
            dgv_user.Columns[7].HeaderText = "Fecha Nacimiento";
            dgv_user.Columns[8].HeaderText = "Tipo de documento";
            dgv_user.Columns[9].HeaderText = "Numero de documento";
            dgv_user.Columns[10].HeaderText = "Telefono";
            dgv_user.Columns[11].HeaderText = "Direccion";
            dgv_user.Columns[12].HeaderText = "Mail";
            dgv_user.Columns[13].HeaderText = " Fecha de alta";
        }
    }
}
