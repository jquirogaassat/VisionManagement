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


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity += 0.05;
            }
            circularProgressBar1.Value += 1;
            circularProgressBar1.Text = circularProgressBar1.Value.ToString();
            if (circularProgressBar1.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity == 0)
            {
                timer2.Stop();
                this.Hide();
                BLL.BLLconexion conexion = new BLL.BLLconexion();
                if (conexion.ComprobarConexion())
                {
                    BLL.BLLdigitoverificador DV = new BLL.BLLdigitoverificador();
                    Globa.errores = DV.ComprobarIntegridad();
                    if (Globa.errores.Count > 0)
                    {
                        Inicio inicio = new Inicio();
                        inicio.Show();
                    }
                    else
                    {
                        Globa.IniciarSesion.ShowDialog();
                    }
                }
                else
                {
                    Conexion _conexion = new Conexion();
                    _conexion.Show();
                }
                
                
          
            }
        }

        private void Ingreso_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
            circularProgressBar1.Value = 0;

            circularProgressBar1.Minimum = 0;
            circularProgressBar1.Maximum = 100;
            timer1.Start();



        }

    }
    }

