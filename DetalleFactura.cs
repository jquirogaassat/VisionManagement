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
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System.IO;
using System.Diagnostics;

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
            RellenarDgvCliente();
            RellenarDgvProducto();
        }

        public void RellenarDgvCliente()
        {
            dg_cliente.DataSource = _clienteBll.Listar();
            dg_cliente.RowHeadersVisible = false;
            dg_cliente.AllowUserToAddRows = false;
            dg_cliente.AllowUserToDeleteRows = false;
            dg_cliente.EditMode = DataGridViewEditMode.EditProgrammatically;
            dg_cliente.MultiSelect = false;
            dg_cliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg_cliente.Columns[0].HeaderText = "Nombre";
            dg_cliente.Columns[1].HeaderText = "Apellido";
            dg_cliente.Columns[2].HeaderText = "Localidad";
            dg_cliente.Columns[5].HeaderText = "Id cliente";
            dg_cliente.Columns[3].Visible = false;
            dg_cliente.Columns[4].Visible = false;
            dg_cliente.Columns[6].Visible = false;

        }
        public void RellenarDgvProducto()
        {
            dg_articulo.DataSource = _articulo.Listar();
            dg_articulo.RowHeadersVisible = false;
            dg_articulo.AllowUserToAddRows = false;
            dg_articulo.AllowUserToDeleteRows = false;
            dg_articulo.EditMode = DataGridViewEditMode.EditProgrammatically;
            dg_articulo.MultiSelect = false;
            dg_articulo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg_articulo.Columns[0].HeaderText = "Nombre";
            dg_articulo.Columns[1].HeaderText = "Color";
            dg_articulo.Columns[2].HeaderText = "Origen";
            //dg_articulo.Columns[3].HeaderText = "Cantidad";
            dg_articulo.Columns[4].HeaderText = "Id articulo";
            dg_articulo.Columns[5].HeaderText = "Precio";
            dg_articulo.Columns[3].Visible = false;

        }
        private void btn_cargarArticulo_Click(object sender, EventArgs e)
        {
            try
            {
                decimal a, b, subtotal;

                decimal acumulador;
                string aux = "0";

                a = decimal.Parse(txt_cantidad.Text);
                b = decimal.Parse(Convert.ToString(dg_articulo[5,dg_articulo.CurrentRow.Index].Value));

                subtotal = a * b;


                dg_detalleFac.Rows.Add(new string[]
                {
                    Convert.ToString(dg_articulo[4,dg_articulo.CurrentRow.Index].Value), // articulo
                    Convert.ToString(dg_articulo[0,dg_articulo.CurrentRow.Index].Value),// nombre
                    Convert.ToString(txt_cantidad.Text), // aca paso la cantidad
                    Convert.ToString(dg_articulo[5,dg_articulo.CurrentRow.Index].Value), // precio
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
                    IdCliente = Convert.ToInt32(dg_cliente.CurrentRow.Cells[5].Value),
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
                    //GenerarFactura();
                    GenerarPDFYMostrar();
                    dg_detalleFac.DataSource = "";
                    txt_cantidad.Clear();
                    lbl_total.Text = "0";
                    this.Close();
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

        private void GenerarFactura(string rutaGuardado)
        {
            try
            {
                //Creo el documento pdf
                PdfWriter pdfwriter = new PdfWriter(rutaGuardado);
                PdfDocument pdf= new PdfDocument(pdfwriter);
                Document documento= new Document(pdf);

                //obtengo los datos de la factura
                string nombreEmpresa = "VisionManagement";
                DateTime fechaFactu = DateTime.Now;
                string nombreCliente = dg_cliente.CurrentRow.Cells[0].Value.ToString();
                string apellidoCliente = dg_cliente.CurrentRow.Cells[1].Value.ToString();

                //agrego la info de la factura  al pdf
                documento.Add(new Paragraph("Factura"));
                documento.Add(new Paragraph("Nombre de la empresa: " + nombreEmpresa));
                documento.Add(new Paragraph("Fecha: " + fechaFactu.ToString()));
                documento.Add(new Paragraph("Nombre :"+nombreCliente));
                documento.Add(new Paragraph("Apellido :" + apellidoCliente));

                //agrego el detalle de la factura
                documento.Add(new Paragraph("Detalle"));


                decimal total = 0;
                foreach(DataGridViewRow row  in dg_detalleFac.Rows)
                {
                    string nombreProducto= row.Cells[1].Value.ToString();//nombre del producto
                    int cantidad= Convert.ToInt32(row.Cells[2].Value);//cantidad
                    decimal precio= Convert.ToDecimal(row.Cells[3].Value);//precio
                    decimal subTotal = Convert.ToDecimal(row.Cells[4].Value);// subtotal

                    documento.Add(new Paragraph($"Prducto: {nombreProducto}, Cantidad : {cantidad}, Precio: {precio}, Subtotal :{subTotal}"));

                    total += subTotal;
                }
                documento.Add(new Paragraph("Total :"+ total.ToString()));

                documento.Close();

               

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al generar el pdf :"+ ex.Message);
            }
        }

        private void GenerarPDFYMostrar()
        {
            try
            {
                // Generar el PDF
                

                string directorioFacturas = @"C:\Users\jair\Desktop\Facturas VM";

                string nombreCliente = dg_cliente.CurrentRow.Cells[0].Value.ToString();

                string rutaArchivoPDF = Path.Combine(directorioFacturas, "Factura_" +nombreCliente+".pdf");

                GenerarFactura(rutaArchivoPDF);
                // Verificar si el archivo existe
                if (File.Exists(rutaArchivoPDF))
                {
                    // Abrir el archivo PDF con la aplicación predeterminada del sistema
                    Process.Start(rutaArchivoPDF);
                }
                else
                {
                    MessageBox.Show("El archivo PDF no se ha generado correctamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar o mostrar el PDF: " + ex.Message);
            }
        }
    }
}
