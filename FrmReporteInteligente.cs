using DAL;
using iText.IO.Image;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;


namespace VisionTFI
{
    public partial class FrmReporteInteligente : Form
    {   
       
        public FrmReporteInteligente()
        {
            InitializeComponent();
        }
        //boton de salida 
        private void btn_salir_Click(object sender, EventArgs e)
        {
            this. Close();
        }

        #region Botonoes de busqueda
        private void btn_buscarProductos_Click(object sender, EventArgs e)
        {
            BLL.BLLarticulo _blArticulo = new BLL.BLLarticulo();
            DataTable dt = _blArticulo.CargarInforme();
            dgv_Productos.DataSource = dt;
            ActualizarDgvProductos();
        }
        private void btn_buscarClientes_Click(object sender, EventArgs e)
        {
            BLL.BLLcliente _blCliente = new BLL.BLLcliente();
            DataTable dt = _blCliente.CargarInforme();
            dgv_clientes.DataSource = dt;
            ActualizarDgvClientes();
        }

        #endregion

        #region Actualizar las grillas
        private void ActualizarDgvProductos()
        {
            dgv_Productos.RowHeadersVisible = false;
            dgv_Productos.AllowUserToAddRows = false;
            dgv_Productos.AllowUserToDeleteRows = false;
            dgv_Productos.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgv_Productos.MultiSelect = false;
            dgv_Productos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgv_Productos.Columns[0].HeaderText = "Nombre de articulo ";
            dgv_Productos.Columns[1].HeaderText = "Cantidad vendida ";
            dgv_Productos.Columns[2].HeaderText = "Ingresos obtenidos";

        }

        private void ActualizarDgvClientes()
        {
            dgv_clientes.RowHeadersVisible = false;
            dgv_clientes.AllowUserToAddRows = false;
            dgv_clientes.AllowUserToDeleteRows = false;
            dgv_clientes.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgv_clientes.MultiSelect = false;
            dgv_clientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgv_clientes.Columns[0].HeaderText = "Numero de cliente ";
            dgv_clientes.Columns[1].HeaderText = "Nombre ";
            dgv_clientes.Columns[2].HeaderText = "Apellido";
            dgv_clientes.Columns[3].HeaderText = "Cantidad de compras ";
        }


        #endregion

        #region Imprimir informe  productos
        private void btn_imprimirProductos_Click(object sender, EventArgs e)
        {
            GenerarPDFProductos();
        }

        private void GenerarPDFProductos()
        {
            try
            {
                // Generar el PDF
                string directorioInforme = @"C:\Users\gozli\OneDrive\Desktop\Informes VM";
                //string nombreCliente = dg_cliente.CurrentRow.Cells[0].Value.ToString();
                DateTime fecha = DateTime.Now;
                string nombreArchivo = $"Informe_{fecha:yyyyMMdd_HHmmss}.pdf";

                // string rutaArchivoPDF = Path.Combine(directorioFacturas, "Factura_" +nombreCliente+".pdf");
                string rutaArchivoPDF = Path.Combine(directorioInforme, nombreArchivo);

                GenerarInformeProductos(rutaArchivoPDF);
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


        private void GenerarInformeProductos(string rutaGuardado)
        {
            try
            {
                //Creo el documento pdf
                PdfWriter pdfwriter = new PdfWriter(rutaGuardado);
                PdfDocument pdf = new PdfDocument(pdfwriter);
                Document documento = new Document(pdf);

                //agrego el logo
                string logoPath = @"C:\Users\gozli\OneDrive\Desktop\Jair\V.png"; // Ruta al logo de la empresa
                if (!File.Exists(logoPath))
                {
                    throw new FileNotFoundException("El archivo no se encontro!");
                }

                ImageData imageData = ImageDataFactory.Create(logoPath);
                iText.Layout.Element.Image logo = new iText.Layout.Element.Image(imageData).ScaleToFit(100, 100).SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.LEFT);
                documento.Add(logo);


                //obtengo los datos de la factura
                string nombreEmpresa = "VisionManagement SRL";
                string domicilio = " Tacuari 1353 - 1103 - Ciudad Autonoma de Buenos Aires ";
                DateTime fechaFactu = DateTime.Now;
               

                //pongo los encabezados
                Table encabezado1 = new Table(1).SetVerticalAlignment(iText.Layout.Properties.VerticalAlignment.TOP).SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);
                Cell tipo = new Cell().Add(new Paragraph("Informe de productos mas comprados")).SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER).SetBold().SetFontSize(15);
                encabezado1.AddCell(tipo);
                documento.Add(encabezado1);
                documento.Add(new Paragraph("\n"));

                // encabezado info de la empresa y el cliente
                Table encabezado = new Table(1).UseAllAvailableWidth().SetBorder(iText.Layout.Borders.Border.NO_BORDER);
                Cell infoEmpresa = new Cell().
                    Add(new Paragraph(nombreEmpresa.ToUpper()).SetBold().SetFontSize(20))
                   .Add(new Paragraph("Domicilio fiscal" + domicilio).SetFontSize(10))
                   .Add(new Paragraph("Fecha :" + fechaFactu.ToString("dd/MM/yyyy")).SetFontSize(10))
                   .SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT);
                encabezado.AddCell(infoEmpresa);
                documento.Add(encabezado);

                //agrego el detalle de la factura
                documento.Add(new Paragraph("\nDetalle"));

                Table table = new Table(3).UseAllAvailableWidth();

                table.AddCell("Producto");
                table.AddCell("Cantidad vendida ");
                table.AddCell("Ingreso generado");



                foreach (DataGridViewRow row in dgv_Productos.Rows)
                {
                    string nombreProducto = row.Cells[0].Value.ToString();//nombre del producto
                    int cantidad = Convert.ToInt32(row.Cells[1].Value);//cantidad
                    decimal ingresoGenerado = Convert.ToDecimal(row.Cells[2].Value);//ingreso 

                    table.AddCell(nombreProducto);
                    table.AddCell(cantidad.ToString());
                    table.AddCell(ingresoGenerado.ToString());
                }
                documento.Add(table);
                //documento.Add(new Paragraph("Total $: " + total.ToString()).SetBold().SetFontSize(20).SetTextAlignment(iText.Layout.Properties.TextAlignment.RIGHT));

                documento.Close();



            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al generar el pdf :" + ex.Message);
            }
        }
        #endregion

        #region Imprimir informe clientes
        private void btn_imprimirClientes_Click(object sender, EventArgs e)
        {
            GenerarPDFClientes();
        }

        private void GenerarPDFClientes()
        {
            try
            {
                // Generar el PDF
                string directorioInforme = @"C:\Users\gozli\OneDrive\Desktop\Informes VM";
                //string nombreCliente = dg_cliente.CurrentRow.Cells[0].Value.ToString();
                DateTime fecha = DateTime.Now;
                string nombreArchivo = $"Informe_{fecha:yyyyMMdd_HHmmss}.pdf";

                // string rutaArchivoPDF = Path.Combine(directorioFacturas, "Factura_" +nombreCliente+".pdf");
                string rutaArchivoPDF = Path.Combine(directorioInforme, nombreArchivo);

                GenerarInformeClientes(rutaArchivoPDF);
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

        private void GenerarInformeClientes(string rutaGuardado)
        {
            try
            {
                //Creo el documento pdf
                PdfWriter pdfwriter = new PdfWriter(rutaGuardado);
                PdfDocument pdf = new PdfDocument(pdfwriter);
                Document documento = new Document(pdf);

                //agrego el logo
                string logoPath = @"C:\Users\gozli\OneDrive\Desktop\Jair\V.png"; // Ruta al logo de la empresa
                if (!File.Exists(logoPath))
                {
                    throw new FileNotFoundException("El archivo no se encontro!");
                }

                ImageData imageData = ImageDataFactory.Create(logoPath);
                iText.Layout.Element.Image logo = new iText.Layout.Element.Image(imageData).ScaleToFit(100, 100).SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.LEFT);
                documento.Add(logo);


                //obtengo los datos de la factura
                string nombreEmpresa = "VisionManagement SRL";
                string domicilio = " Tacuari 1353 - 1103 - Ciudad Autonoma de Buenos Aires ";
                DateTime fechaFactu = DateTime.Now;
                // string nombreCliente = dg_cliente.CurrentRow.Cells[0].Value.ToString();
                // string apellidoCliente = dg_cliente.CurrentRow.Cells[1].Value.ToString();

                //pongo los encabezados
                Table encabezado1 = new Table(1).SetVerticalAlignment(iText.Layout.Properties.VerticalAlignment.TOP).SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);
                Cell tipo = new Cell().Add(new Paragraph("Informe")).SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER).SetBold().SetFontSize(15);
                encabezado1.AddCell(tipo);
                documento.Add(encabezado1);
                documento.Add(new Paragraph("\n"));

                // encabezado info de la empresa y el cliente
                Table encabezado = new Table(1).UseAllAvailableWidth().SetBorder(iText.Layout.Borders.Border.NO_BORDER);
                Cell infoEmpresa = new Cell().
                    Add(new Paragraph(nombreEmpresa.ToUpper()).SetBold().SetFontSize(20))
                   .Add(new Paragraph("Domicilio fiscal" + domicilio).SetFontSize(10))
                   .Add(new Paragraph("Fecha :" + fechaFactu.ToString("dd/MM/yyyy")).SetFontSize(10))
                   .SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT);
                encabezado.AddCell(infoEmpresa);
                documento.Add(encabezado);

                //agrego el detalle de la factura
                documento.Add(new Paragraph("\nDetalle"));

                Table table = new Table(4).UseAllAvailableWidth();

                table.AddCell("Numero de cliente");
                table.AddCell("Nombre");
                table.AddCell("Apellido");
                table.AddCell("Numero de compras");



                foreach (DataGridViewRow row in dgv_clientes.Rows)
                {
                    int numeroCliente = Convert.ToInt32(row.Cells[0].Value);// numero de cliente
                    string nombreCliente = row.Cells[1].Value.ToString();//nombre de cliente
                    string apellidoCliente = row.Cells[2].Value.ToString();//apellido de cliente
                    int numeroCompras = Convert.ToInt32(row.Cells[3].Value);//numero de compras

                    table.AddCell(numeroCliente.ToString());
                    table.AddCell(nombreCliente.ToString());
                    table.AddCell(apellidoCliente.ToString());
                    table.AddCell(numeroCompras.ToString());
                }
                documento.Add(table);
                //documento.Add(new Paragraph("Total $: " + total.ToString()).SetBold().SetFontSize(20).SetTextAlignment(iText.Layout.Properties.TextAlignment.RIGHT));

                documento.Close();



            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al generar el pdf :" + ex.Message);
            }
        }
        #endregion

        private void FrmReporteInteligente_Load(object sender, EventArgs e)
        {
            ActualizarControles();
            IdiomaManager.IdiomaCambiado += OnIdiomaCambiado;
        }

        private void OnIdiomaCambiado()
        {
            ActualizarControles();
        }

        void ActualizarControles()
        {
            lbl_buscarFechaReporte.Text = IdiomaManager.info["lbl_buscarFechaReporte"];
            lba_desdeReporte.Text = IdiomaManager.info["lba_desdeReporte"];
            lbl_hastaReporte.Text = IdiomaManager.info["lbl_hastaReporte"];
            lbl_productoMasVendido.Text = IdiomaManager.info["lbl_productoMasVendido"];
            lbl_clientesMasCompras.Text = IdiomaManager.info["lbl_clientesMasCompras"];
            btn_buscarProductos.Text = IdiomaManager.info["btn_buscarProductos"];
            btn_buscarClientes.Text = IdiomaManager.info["btn_buscarClientes"];
            btn_salirReporte.Text = IdiomaManager.info["btn_salirReporte"];
            btn_imprimirProductos.Text = IdiomaManager.info["btn_imprimirProductos"];
            btn_imprimirClientes.Text = IdiomaManager.info["btn_imprimirClientes"];
        }
    }
}
