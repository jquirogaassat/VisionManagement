namespace VisionTFI
{
    partial class FrmReporteInteligente
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
            this.lbl_hasta = new System.Windows.Forms.Label();
            this.dt_hasta = new System.Windows.Forms.DateTimePicker();
            this.lba_desde = new System.Windows.Forms.Label();
            this.dt_desde = new System.Windows.Forms.DateTimePicker();
            this.lbl_buscarFecha = new System.Windows.Forms.Label();
            this.lbl_producto = new System.Windows.Forms.Label();
            this.btn_buscarProductos = new System.Windows.Forms.Button();
            this.btn_buscarClientes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Productos = new System.Windows.Forms.DataGridView();
            this.dgv_clientes = new System.Windows.Forms.DataGridView();
            this.btn_imprimirProductos = new System.Windows.Forms.Button();
            this.btn_imprimirClientes = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Productos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_hasta
            // 
            this.lbl_hasta.AutoSize = true;
            this.lbl_hasta.Location = new System.Drawing.Point(24, 144);
            this.lbl_hasta.Name = "lbl_hasta";
            this.lbl_hasta.Size = new System.Drawing.Size(41, 13);
            this.lbl_hasta.TabIndex = 41;
            this.lbl_hasta.Text = "Hasta :";
            // 
            // dt_hasta
            // 
            this.dt_hasta.Location = new System.Drawing.Point(76, 138);
            this.dt_hasta.Name = "dt_hasta";
            this.dt_hasta.Size = new System.Drawing.Size(200, 20);
            this.dt_hasta.TabIndex = 40;
            // 
            // lba_desde
            // 
            this.lba_desde.AutoSize = true;
            this.lba_desde.Location = new System.Drawing.Point(24, 97);
            this.lba_desde.Name = "lba_desde";
            this.lba_desde.Size = new System.Drawing.Size(44, 13);
            this.lba_desde.TabIndex = 39;
            this.lba_desde.Text = "Desde :";
            // 
            // dt_desde
            // 
            this.dt_desde.Location = new System.Drawing.Point(76, 91);
            this.dt_desde.Name = "dt_desde";
            this.dt_desde.Size = new System.Drawing.Size(200, 20);
            this.dt_desde.TabIndex = 38;
            // 
            // lbl_buscarFecha
            // 
            this.lbl_buscarFecha.AutoSize = true;
            this.lbl_buscarFecha.Location = new System.Drawing.Point(24, 62);
            this.lbl_buscarFecha.Name = "lbl_buscarFecha";
            this.lbl_buscarFecha.Size = new System.Drawing.Size(88, 13);
            this.lbl_buscarFecha.TabIndex = 37;
            this.lbl_buscarFecha.Text = "Buscar por fecha";
            // 
            // lbl_producto
            // 
            this.lbl_producto.AutoSize = true;
            this.lbl_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_producto.Location = new System.Drawing.Point(356, 91);
            this.lbl_producto.Name = "lbl_producto";
            this.lbl_producto.Size = new System.Drawing.Size(166, 20);
            this.lbl_producto.TabIndex = 42;
            this.lbl_producto.Text = "Producto mas vendido";
            // 
            // btn_buscarProductos
            // 
            this.btn_buscarProductos.Location = new System.Drawing.Point(575, 92);
            this.btn_buscarProductos.Name = "btn_buscarProductos";
            this.btn_buscarProductos.Size = new System.Drawing.Size(88, 23);
            this.btn_buscarProductos.TabIndex = 43;
            this.btn_buscarProductos.Text = "Buscar";
            this.btn_buscarProductos.UseVisualStyleBackColor = true;
            this.btn_buscarProductos.Click += new System.EventHandler(this.btn_buscarProductos_Click);
            // 
            // btn_buscarClientes
            // 
            this.btn_buscarClientes.Location = new System.Drawing.Point(575, 141);
            this.btn_buscarClientes.Name = "btn_buscarClientes";
            this.btn_buscarClientes.Size = new System.Drawing.Size(88, 23);
            this.btn_buscarClientes.TabIndex = 45;
            this.btn_buscarClientes.Text = "Buscar";
            this.btn_buscarClientes.UseVisualStyleBackColor = true;
            this.btn_buscarClientes.Click += new System.EventHandler(this.btn_buscarClientes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(356, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 20);
            this.label1.TabIndex = 44;
            this.label1.Text = "Clientes que mas compraron";
            // 
            // dgv_Productos
            // 
            this.dgv_Productos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Productos.Location = new System.Drawing.Point(10, 217);
            this.dgv_Productos.Name = "dgv_Productos";
            this.dgv_Productos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_Productos.Size = new System.Drawing.Size(592, 262);
            this.dgv_Productos.TabIndex = 46;
            // 
            // dgv_clientes
            // 
            this.dgv_clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_clientes.Location = new System.Drawing.Point(642, 217);
            this.dgv_clientes.Name = "dgv_clientes";
            this.dgv_clientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_clientes.Size = new System.Drawing.Size(592, 262);
            this.dgv_clientes.TabIndex = 47;
            // 
            // btn_imprimirProductos
            // 
            this.btn_imprimirProductos.Location = new System.Drawing.Point(527, 497);
            this.btn_imprimirProductos.Name = "btn_imprimirProductos";
            this.btn_imprimirProductos.Size = new System.Drawing.Size(75, 36);
            this.btn_imprimirProductos.TabIndex = 48;
            this.btn_imprimirProductos.Text = "Imprmir";
            this.btn_imprimirProductos.UseVisualStyleBackColor = true;
            this.btn_imprimirProductos.Click += new System.EventHandler(this.btn_imprimirProductos_Click);
            // 
            // btn_imprimirClientes
            // 
            this.btn_imprimirClientes.Location = new System.Drawing.Point(1159, 497);
            this.btn_imprimirClientes.Name = "btn_imprimirClientes";
            this.btn_imprimirClientes.Size = new System.Drawing.Size(75, 36);
            this.btn_imprimirClientes.TabIndex = 49;
            this.btn_imprimirClientes.Text = "Imprimir";
            this.btn_imprimirClientes.UseVisualStyleBackColor = true;
            this.btn_imprimirClientes.Click += new System.EventHandler(this.btn_imprimirClientes_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(712, 115);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 31);
            this.btn_salir.TabIndex = 50;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // FrmReporteInteligente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 561);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_imprimirClientes);
            this.Controls.Add(this.btn_imprimirProductos);
            this.Controls.Add(this.dgv_clientes);
            this.Controls.Add(this.dgv_Productos);
            this.Controls.Add(this.btn_buscarClientes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_buscarProductos);
            this.Controls.Add(this.lbl_producto);
            this.Controls.Add(this.lbl_hasta);
            this.Controls.Add(this.dt_hasta);
            this.Controls.Add(this.lba_desde);
            this.Controls.Add(this.dt_desde);
            this.Controls.Add(this.lbl_buscarFecha);
            this.Name = "FrmReporteInteligente";
            this.Text = "Reporte Inteligente";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Productos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_hasta;
        private System.Windows.Forms.DateTimePicker dt_hasta;
        private System.Windows.Forms.Label lba_desde;
        private System.Windows.Forms.DateTimePicker dt_desde;
        private System.Windows.Forms.Label lbl_buscarFecha;
        private System.Windows.Forms.Label lbl_producto;
        private System.Windows.Forms.Button btn_buscarProductos;
        private System.Windows.Forms.Button btn_buscarClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Productos;
        private System.Windows.Forms.DataGridView dgv_clientes;
        private System.Windows.Forms.Button btn_imprimirProductos;
        private System.Windows.Forms.Button btn_imprimirClientes;
        private System.Windows.Forms.Button btn_salir;
    }
}