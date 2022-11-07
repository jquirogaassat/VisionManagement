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
    public partial class IniciarSistema : Form
    {
        public IniciarSistema()
        {
            InitializeComponent();
        }

        private void pb_iniciarSistema_Click(object sender, EventArgs e)
        {

        }

        private  void Iniciar_sistema_Load(object sender,EventArgs e)
        {
            timer1.Start();
            timer1.Interval=1000;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pb_iniciarSistema.Increment(30);
        }
    }
}
