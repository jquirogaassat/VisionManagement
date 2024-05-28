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
using iText.IO.Image;
using Aspose.Pdf.Annotations;
using iText.Kernel.Pdf.Canvas;

namespace VisionTFI
{
    public partial class DetalleFactura : Form
    {
        private BLLcliente _clienteBll = new BLLcliente();
        private BLLarticulo _articulo = new BLLarticulo();
        private BLLfactura _factura = new BLLfactura();
        private BLLdetallefactura _detallefactura=new BLLdetallefactura();
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

        //private void btn_generarFactura_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        BEfactura factura = new BEfactura
        //        {
        //            IdCliente = Convert.ToInt32(dg_cliente.CurrentRow.Cells[5].Value),
        //            Fecha = DateTime.Now,
        //        };

        //        List<BEdetallefactura> detalle = new List<BEdetallefactura>();

        //        BEdetallefactura detalleFactu = new BEdetallefactura();
        //        foreach (DataGridViewRow row in dg_detalleFac.Rows)
        //        {
        //            detalleFactu.IdArticulo = Convert.ToInt32(row.Cells[0].Value);
        //            detalleFactu.Cantidad = Convert.ToInt32(row.Cells[0].Value);
        //            detalle.Add(detalleFactu);  
        //        }

        //        foreach (BEdetallefactura det in detalle)
        //        {
        //            factura.Detalles = detalle;
        //        }

        //        if (_factura.Add(factura))
        //        {                    
        //            MessageBox.Show("Factura exitosa");
        //            //GenerarFactura();
        //            GenerarPDFYMostrar();
        //            dg_detalleFac.DataSource = "";
        //            txt_cantidad.Clear();
        //            lbl_total.Text = "0";
        //            this.Close();
        //        }

        //        else
        //        {
        //            MessageBox.Show("Error al generar la factura");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        private void btn_generarFactura_Click(object sender, EventArgs e)
        {
            try
            {
                BEfactura factura = new BEfactura
                {
                    IdCliente = Convert.ToInt32(dg_cliente.CurrentRow.Cells[5].Value),
                    Fecha = DateTime.Now,
                };

                // Insertar factura y obtener el ID generado
                int facturaId = _factura.AddPrueba(factura);
                factura.Id = facturaId;

                List<BEdetallefactura> detalle = new List<BEdetallefactura>();

                foreach (DataGridViewRow row in dg_detalleFac.Rows)
                {
                    BEdetallefactura detalleFactu = new BEdetallefactura
                    {
                        IdFactura = facturaId,
                        IdArticulo = Convert.ToInt32(row.Cells[0].Value),
                        Cantidad = Convert.ToInt32(row.Cells[2].Value) // Cambié esto para que tenga sentido
                    };
                    detalle.Add(detalleFactu);
                }

                bool allDetailsAdded = true;

                foreach (BEdetallefactura det in detalle)
                {
                    if (!_detallefactura.Add(det))
                    {
                        allDetailsAdded = false;
                        break;
                    }
                }

                if (allDetailsAdded)
                {
                    MessageBox.Show("Factura exitosa");
                    // GenerarFactura();
                    GenerarPDFYMostrar();
                    dg_detalleFac.DataSource = null;
                    txt_cantidad.Clear();
                    lbl_total.Text = "0";
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al agregar detalles de la factura");
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

                //agrego el logo
                string logoPath = @"C:\Users\Usuario\Desktop\Jair\Imagenes VisionManagement\V.png"; // Ruta al logo de la empresa
                if (!File.Exists(logoPath))
                {
                    throw new FileNotFoundException("El archivo no se encontro!");
                }
                
                ImageData imageData = ImageDataFactory.Create(logoPath);
                iText.Layout.Element.Image logo = new iText.Layout.Element.Image(imageData).ScaleToFit(100, 100).SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.LEFT);
                documento.Add(logo);

                
                //obtengo los datos de la factura
                string nombreEmpresa = "VisionManagement SRL";
                DateTime fechaFactu = DateTime.Now;
                string nombreCliente = dg_cliente.CurrentRow.Cells[0].Value.ToString();
                string apellidoCliente = dg_cliente.CurrentRow.Cells[1].Value.ToString();

                //pongo los encabezados
                Table encabezado = new Table(1).UseAllAvailableWidth();
                Cell infoEmpresa = new Cell().
                    Add(new Paragraph(nombreEmpresa.ToUpper()).SetBold().SetFontSize(20))
                   .Add(new Paragraph("Fecha :" + fechaFactu.ToString("dd/MM/yyyy")).SetFontSize(10))
                   .Add(new Paragraph("Cliente :" + nombreCliente.ToUpper() + " " + apellidoCliente.ToUpper()).SetFontSize(10))
                   .SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT);
                  
                encabezado.AddCell(infoEmpresa);
                documento.Add(encabezado);

                //agrego la info de la factura  al pdf
                //documento.Add(new Paragraph("Factura").SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER).SetBold().SetFontSize(35)); ;
                //documento.Add(new Paragraph("B").SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER).SetBold().SetFontSize(35));
                //documento.Add(new Paragraph("Razon social: " + nombreEmpresa.ToUpper()));
                //documento.Add(new Paragraph("Fecha: " + fechaFactu.ToString()).SetBold());
                //documento.Add(new Paragraph("Nombre : "+nombreCliente.ToUpper()).SetBold());
                //documento.Add(new Paragraph("Apellido : " + apellidoCliente.ToUpper()).SetBold());

                //agrego el detalle de la factura
                documento.Add(new Paragraph("\nDetalle"));

                Table table = new Table(4).UseAllAvailableWidth();
                
                table.AddCell("Producto");
                table.AddCell("Cantidad");
                table.AddCell("Precio");
                table.AddCell("Subtotal");
                
                decimal total = 0;
                foreach(DataGridViewRow row  in dg_detalleFac.Rows)
                {
                    string nombreProducto= row.Cells[1].Value.ToString();//nombre del producto
                    int cantidad= Convert.ToInt32(row.Cells[2].Value);//cantidad
                    decimal precio= Convert.ToDecimal(row.Cells[3].Value);//precio
                    decimal subTotal = Convert.ToDecimal(row.Cells[4].Value);// subtotal

                    table.AddCell(nombreProducto);
                    table.AddCell(cantidad.ToString());
                    table.AddCell(precio.ToString());
                    table.AddCell(subTotal.ToString());

               

                    total += subTotal;
                }
                documento.Add(table);
                documento.Add(new Paragraph("Total :"+ total.ToString()).SetBold().SetFontSize(20));

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
                

                string directorioFacturas = @"C:\Users\Usuario\Desktop\FacturasVM";

                string nombreCliente = dg_cliente.CurrentRow.Cells[0].Value.ToString();
                DateTime fecha = DateTime.Now;
                string nombreArchivo = $"Factura_{nombreCliente}_{fecha:yyyyMMdd_HHmmss}.pdf";

               // string rutaArchivoPDF = Path.Combine(directorioFacturas, "Factura_" +nombreCliente+".pdf");
                string rutaArchivoPDF = Path.Combine(directorioFacturas, nombreArchivo); 

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
