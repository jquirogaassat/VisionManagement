namespace VisionTFI
{
    partial class DetalleFactura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dg_detalleFac = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_articulo = new System.Windows.Forms.DataGridView();
            this.dg_cliente = new System.Windows.Forms.DataGridView();
            this.lbl_totApagar = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.btn_generarFactura = new System.Windows.Forms.Button();
            this.btn_cargarArticulo = new System.Windows.Forms.Button();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lbl_productos = new System.Windows.Forms.Label();
            this.lbl_clientes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_detalleFac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_articulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_cliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_detalleFac
            // 
            this.dg_detalleFac.AllowUserToAddRows = false;
            this.dg_detalleFac.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_detalleFac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_detalleFac.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Cantidad,
            this.PrecioUnitario,
            this.SubTotal});
            this.dg_detalleFac.Location = new System.Drawing.Point(11, 11);
            this.dg_detalleFac.Margin = new System.Windows.Forms.Padding(2);
            this.dg_detalleFac.Name = "dg_detalleFac";
            this.dg_detalleFac.RowHeadersWidth = 51;
            this.dg_detalleFac.RowTemplate.Height = 24;
            this.dg_detalleFac.Size = new System.Drawing.Size(579, 198);
            this.dg_detalleFac.TabIndex = 9;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            // 
            // PrecioUnitario
            // 
            this.PrecioUnitario.HeaderText = "Precio Unitario";
            this.PrecioUnitario.MinimumWidth = 6;
            this.PrecioUnitario.Name = "PrecioUnitario";
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "SubTotal";
            this.SubTotal.MinimumWidth = 6;
            this.SubTotal.Name = "SubTotal";
            // 
            // dg_articulo
            // 
            this.dg_articulo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_articulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dg_articulo.Location = new System.Drawing.Point(11, 292);
            this.dg_articulo.Margin = new System.Windows.Forms.Padding(2);
            this.dg_articulo.Name = "dg_articulo";
            this.dg_articulo.RowHeadersWidth = 51;
            this.dg_articulo.RowTemplate.Height = 24;
            this.dg_articulo.Size = new System.Drawing.Size(611, 230);
            this.dg_articulo.TabIndex = 18;
            // 
            // dg_cliente
            // 
            this.dg_cliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_cliente.Location = new System.Drawing.Point(651, 292);
            this.dg_cliente.Margin = new System.Windows.Forms.Padding(2);
            this.dg_cliente.Name = "dg_cliente";
            this.dg_cliente.RowHeadersWidth = 51;
            this.dg_cliente.RowTemplate.Height = 24;
            this.dg_cliente.Size = new System.Drawing.Size(503, 230);
            this.dg_cliente.TabIndex = 19;
            // 
            // lbl_totApagar
            // 
            this.lbl_totApagar.AutoSize = true;
            this.lbl_totApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totApagar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_totApagar.Location = new System.Drawing.Point(621, 53);
            this.lbl_totApagar.Name = "lbl_totApagar";
            this.lbl_totApagar.Size = new System.Drawing.Size(184, 30);
            this.lbl_totApagar.TabIndex = 26;
            this.lbl_totApagar.Text = "Total a pagar $";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_total.Location = new System.Drawing.Point(802, 54);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(26, 29);
            this.lbl_total.TabIndex = 25;
            this.lbl_total.Text = "0";
            // 
            // btn_generarFactura
            // 
            this.btn_generarFactura.Location = new System.Drawing.Point(805, 189);
            this.btn_generarFactura.Margin = new System.Windows.Forms.Padding(2);
            this.btn_generarFactura.Name = "btn_generarFactura";
            this.btn_generarFactura.Size = new System.Drawing.Size(174, 38);
            this.btn_generarFactura.TabIndex = 30;
            this.btn_generarFactura.Text = "Generar Factura";
            this.btn_generarFactura.UseVisualStyleBackColor = true;
            this.btn_generarFactura.Click += new System.EventHandler(this.btn_generarFactura_Click);
            // 
            // btn_cargarArticulo
            // 
            this.btn_cargarArticulo.Location = new System.Drawing.Point(636, 212);
            this.btn_cargarArticulo.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cargarArticulo.Name = "btn_cargarArticulo";
            this.btn_cargarArticulo.Size = new System.Drawing.Size(116, 29);
            this.btn_cargarArticulo.TabIndex = 29;
            this.btn_cargarArticulo.Text = "Cargar Articulo";
            this.btn_cargarArticulo.UseVisualStyleBackColor = true;
            this.btn_cargarArticulo.Click += new System.EventHandler(this.btn_cargarArticulo_Click);
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(676, 174);
            this.txt_cantidad.Margin = new System.Windows.Forms.Padding(2);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(76, 20);
            this.txt_cantidad.TabIndex = 28;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(623, 177);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 27;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lbl_productos
            // 
            this.lbl_productos.AutoSize = true;
            this.lbl_productos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_productos.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_productos.Location = new System.Drawing.Point(12, 265);
            this.lbl_productos.Name = "lbl_productos";
            this.lbl_productos.Size = new System.Drawing.Size(109, 25);
            this.lbl_productos.TabIndex = 31;
            this.lbl_productos.Text = "Productos";
            // 
            // lbl_clientes
            // 
            this.lbl_clientes.AutoSize = true;
            this.lbl_clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_clientes.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_clientes.Location = new System.Drawing.Point(655, 265);
            this.lbl_clientes.Name = "lbl_clientes";
            this.lbl_clientes.Size = new System.Drawing.Size(90, 25);
            this.lbl_clientes.TabIndex = 32;
            this.lbl_clientes.Text = "Clientes";
            // 
            // DetalleFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 533);
            this.Controls.Add(this.lbl_totApagar);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.lbl_clientes);
            this.Controls.Add(this.lbl_productos);
            this.Controls.Add(this.btn_generarFactura);
            this.Controls.Add(this.btn_cargarArticulo);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.dg_cliente);
            this.Controls.Add(this.dg_articulo);
            this.Controls.Add(this.dg_detalleFac);
            this.Name = "DetalleFactura";
            this.Text = "DetalleFactura";
            this.Load += new System.EventHandler(this.DetalleFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_detalleFac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_articulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_cliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_detalleFac;
        private System.Windows.Forms.DataGridView dg_articulo;
        private System.Windows.Forms.DataGridView dg_cliente;
        private System.Windows.Forms.Label lbl_totApagar;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Button btn_generarFactura;
        private System.Windows.Forms.Button btn_cargarArticulo;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lbl_productos;
        private System.Windows.Forms.Label lbl_clientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
    }
}