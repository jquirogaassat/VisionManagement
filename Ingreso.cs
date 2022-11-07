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
    public partial class Ingreso : Form
    {
        public Ingreso()
        {
            InitializeComponent();
        }


        private void timer1_Tick (object sender, EventArgs e)
        {
            if (this .Opacity<1)
            {
                this.Opacity += 0.05;

            }

        progressBar1.Value += 1;
        

        if(progressBar1.Value==100)
            {
                timer1.Stop();
                timer2.Start();
            }
        }


        private void timer2_Pick (object sender, EventArgs e)
        {
            this.Opacity -= 1;
            if(this.Opacity==0)
            {
                timer2.Stop();
                this.Hide();
                BLL.BLLconexion conexion = new BLL.BLLconexion();
                if(conexion.ComprobarConexion())
                {
                    BLL.BLLdigitoverificador dv = new BLL.BLLdigitoverificador();
                    
                }

            }
        }
    }
}
