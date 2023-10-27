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
    public partial class DetalleFactura : Form
    {
        private BLLcliente _clienteBll = new BLLcliente();
        private BLLarticulo _articulo = new BLLarticulo();
        private BLLfactura _factura = new BLLfactura();
        public DetalleFactura()
        {
            InitializeComponent();
        }

        private void DetalleFactura_Load(object sender, EventArgs e)
        {
            dg_cliente.DataSource = _clienteBll.Listar();
            dg_articulo.DataSource= _articulo.Listar();
        }

        private void btn_cargarArticulo_Click(object sender, EventArgs e)
        {
            try
            {
                decimal a, b, subtotal;

                decimal acumulador;
                string aux = "0";

                a = decimal.Parse(txt_cantidad.Text);
                b= decimal.Parse(Convert.ToString(dg_articulo[1,dg_articulo.CurrentRow.Index].Value));

                subtotal = a * b;


                dg_detalleFac.Rows.Add(new string[]
                {
                    Convert.ToString(dg_articulo[3,dg_articulo.CurrentRow.Index].Value), // articulo
                    Convert.ToString(txt_cantidad.Text), // aca paso la cantidad
                    Convert.ToString(dg_articulo[1,dg_articulo.CurrentRow.Index].Value), // precio
                    Convert.ToString(a*b),//subtotal
                });

                aux = lbl_total.Text;
                acumulador= Convert.ToDecimal(aux)+subtotal;
                lbl_total.Text= Convert.ToString(acumulador);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                
            }
        }

        private void btn_generarFactura_Click(object sender, EventArgs e)
        {
            try
            {
                BEfactura factura = new BEfactura
                {
                    IdCliente = Convert.ToInt32(dg_cliente.CurrentRow.Cells[0].Value),
                    Fecha = DateTime.Now,
                };

                List<BEdetallefactura> detalle = new List<BEdetallefactura>();


                foreach(DataGridViewRow row in dg_detalleFac.Rows) 
                {
                    BEdetallefactura detalleFactu= new BEdetallefactura();
                    detalleFactu.IdArticulo= Convert.ToInt32(row.Cells[0].Value);
                    detalleFactu.Cantidad= Convert.ToInt32(row.Cells[0].Value);
                    detalle.Add(detalleFactu);
                }

                foreach(BEdetallefactura det in detalle)
                {
                    factura.Detalles = detalle;
                }

                if(_factura.Add(factura))
                {
                    MessageBox.Show("Factura exitosa");
                    dg_detalleFac.DataSource = "";
                    txt_cantidad.Clear();
                }
                else
                {
                    MessageBox.Show("Error al generar la factura");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);              
            }
        }
    }
}
