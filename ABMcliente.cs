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
            btn_salir.Visible = false;
            btn_guardar.Visible = true;
            btn_baja.Visible = false;

        }

        public void AdaptarFormularioToModificacion()
        {

        }

        public void Actualizar(BEusuario u)
        {
            throw new NotImplementedException();
        }
    }
}
