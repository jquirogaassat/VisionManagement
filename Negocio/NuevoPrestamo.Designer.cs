namespace VisionTFI
{
    partial class NuevoPrestamo
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
            this.lbl_nuevoPrestamo = new System.Windows.Forms.Label();
            this.dgv_herramientas = new System.Windows.Forms.DataGridView();
            this.lbl_herramientaPrestamo = new System.Windows.Forms.Label();
            this.btn_seleccionarH = new System.Windows.Forms.Button();
            this.lbl_herramientaSeleccionada = new System.Windows.Forms.Label();
            this.txt_herramienta = new System.Windows.Forms.TextBox();
            this.txt_clienteSeleccionado = new System.Windows.Forms.TextBox();
            this.lbl_clienteSeleccionado = new System.Windows.Forms.Label();
            this.btn_seleccionaC = new System.Windows.Forms.Button();
            this.lbl_clientePrestamo = new System.Windows.Forms.Label();
            this.dgv_clientes = new System.Windows.Forms.DataGridView();
            this.btn_salirPrestamo = new System.Windows.Forms.Button();
            this.btn_aceptarPrestamo = new System.Windows.Forms.Button();
            this.txt_buscarH = new System.Windows.Forms.TextBox();
            this.btn_buscarH = new System.Windows.Forms.Button();
            this.btn_buscarC = new System.Windows.Forms.Button();
            this.txt_buscarC = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_herramientas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nuevoPrestamo
            // 
            this.lbl_nuevoPrestamo.AutoSize = true;
            this.lbl_nuevoPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nuevoPrestamo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_nuevoPrestamo.Location = new System.Drawing.Point(3, 9);
            this.lbl_nuevoPrestamo.Name = "lbl_nuevoPrestamo";
            this.lbl_nuevoPrestamo.Size = new System.Drawing.Size(392, 55);
            this.lbl_nuevoPrestamo.TabIndex = 0;
            this.lbl_nuevoPrestamo.Text = "Nuevo prestamo";
            // 
            // dgv_herramientas
            // 
            this.dgv_herramientas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_herramientas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgv_herramientas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_herramientas.EnableHeadersVisualStyles = false;
            this.dgv_herramientas.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgv_herramientas.Location = new System.Drawing.Point(12, 134);
            this.dgv_herramientas.Name = "dgv_herramientas";
            this.dgv_herramientas.Size = new System.Drawing.Size(522, 204);
            this.dgv_herramientas.TabIndex = 1;
            this.dgv_herramientas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgv_herramientas_MouseClick);
            // 
            // lbl_herramientaPrestamo
            // 
            this.lbl_herramientaPrestamo.AutoSize = true;
            this.lbl_herramientaPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_herramientaPrestamo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_herramientaPrestamo.Location = new System.Drawing.Point(12, 96);
            this.lbl_herramientaPrestamo.Name = "lbl_herramientaPrestamo";
            this.lbl_herramientaPrestamo.Size = new System.Drawing.Size(134, 24);
            this.lbl_herramientaPrestamo.TabIndex = 2;
            this.lbl_herramientaPrestamo.Text = "Herramientas";
            // 
            // btn_seleccionarH
            // 
            this.btn_seleccionarH.Location = new System.Drawing.Point(414, 344);
            this.btn_seleccionarH.Name = "btn_seleccionarH";
            this.btn_seleccionarH.Size = new System.Drawing.Size(120, 23);
            this.btn_seleccionarH.TabIndex = 4;
            this.btn_seleccionarH.Text = "Seleccionar";
            this.btn_seleccionarH.UseVisualStyleBackColor = true;
            this.btn_seleccionarH.Click += new System.EventHandler(this.btn_seleccionarH_Click);
            // 
            // lbl_herramientaSeleccionada
            // 
            this.lbl_herramientaSeleccionada.AutoSize = true;
            this.lbl_herramientaSeleccionada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_herramientaSeleccionada.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_herramientaSeleccionada.Location = new System.Drawing.Point(13, 414);
            this.lbl_herramientaSeleccionada.Name = "lbl_herramientaSeleccionada";
            this.lbl_herramientaSeleccionada.Size = new System.Drawing.Size(254, 24);
            this.lbl_herramientaSeleccionada.TabIndex = 5;
            this.lbl_herramientaSeleccionada.Text = "Herramienta seleccionada";
            // 
            // txt_herramienta
            // 
            this.txt_herramienta.Location = new System.Drawing.Point(13, 448);
            this.txt_herramienta.Name = "txt_herramienta";
            this.txt_herramienta.Size = new System.Drawing.Size(350, 20);
            this.txt_herramienta.TabIndex = 6;
            // 
            // txt_clienteSeleccionado
            // 
            this.txt_clienteSeleccionado.Location = new System.Drawing.Point(667, 448);
            this.txt_clienteSeleccionado.Name = "txt_clienteSeleccionado";
            this.txt_clienteSeleccionado.Size = new System.Drawing.Size(350, 20);
            this.txt_clienteSeleccionado.TabIndex = 12;
            // 
            // lbl_clienteSeleccionado
            // 
            this.lbl_clienteSeleccionado.AutoSize = true;
            this.lbl_clienteSeleccionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_clienteSeleccionado.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_clienteSeleccionado.Location = new System.Drawing.Point(667, 414);
            this.lbl_clienteSeleccionado.Name = "lbl_clienteSeleccionado";
            this.lbl_clienteSeleccionado.Size = new System.Drawing.Size(206, 24);
            this.lbl_clienteSeleccionado.TabIndex = 11;
            this.lbl_clienteSeleccionado.Text = "Cliente seleccionado";
            // 
            // btn_seleccionaC
            // 
            this.btn_seleccionaC.Location = new System.Drawing.Point(1069, 344);
            this.btn_seleccionaC.Name = "btn_seleccionaC";
            this.btn_seleccionaC.Size = new System.Drawing.Size(120, 23);
            this.btn_seleccionaC.TabIndex = 10;
            this.btn_seleccionaC.Text = "Seleccionar";
            this.btn_seleccionaC.UseVisualStyleBackColor = true;
            this.btn_seleccionaC.Click += new System.EventHandler(this.btn_seleccionaC_Click);
            // 
            // lbl_clientePrestamo
            // 
            this.lbl_clientePrestamo.AutoSize = true;
            this.lbl_clientePrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_clientePrestamo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_clientePrestamo.Location = new System.Drawing.Point(663, 98);
            this.lbl_clientePrestamo.Name = "lbl_clientePrestamo";
            this.lbl_clientePrestamo.Size = new System.Drawing.Size(75, 24);
            this.lbl_clientePrestamo.TabIndex = 8;
            this.lbl_clientePrestamo.Text = "Cliente";
            // 
            // dgv_clientes
            // 
            this.dgv_clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_clientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_clientes.EnableHeadersVisualStyles = false;
            this.dgv_clientes.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgv_clientes.Location = new System.Drawing.Point(667, 134);
            this.dgv_clientes.Name = "dgv_clientes";
            this.dgv_clientes.Size = new System.Drawing.Size(522, 204);
            this.dgv_clientes.TabIndex = 7;
            this.dgv_clientes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgv_clientes_MouseClick);
            // 
            // btn_salirPrestamo
            // 
            this.btn_salirPrestamo.Location = new System.Drawing.Point(885, 517);
            this.btn_salirPrestamo.Name = "btn_salirPrestamo";
            this.btn_salirPrestamo.Size = new System.Drawing.Size(106, 36);
            this.btn_salirPrestamo.TabIndex = 13;
            this.btn_salirPrestamo.Text = "Salir";
            this.btn_salirPrestamo.UseVisualStyleBackColor = true;
            this.btn_salirPrestamo.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_aceptarPrestamo
            // 
            this.btn_aceptarPrestamo.Location = new System.Drawing.Point(1038, 517);
            this.btn_aceptarPrestamo.Name = "btn_aceptarPrestamo";
            this.btn_aceptarPrestamo.Size = new System.Drawing.Size(136, 36);
            this.btn_aceptarPrestamo.TabIndex = 14;
            this.btn_aceptarPrestamo.Text = "Efectuar prestamo";
            this.btn_aceptarPrestamo.UseVisualStyleBackColor = true;
            this.btn_aceptarPrestamo.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // txt_buscarH
            // 
            this.txt_buscarH.Location = new System.Drawing.Point(152, 100);
            this.txt_buscarH.Name = "txt_buscarH";
            this.txt_buscarH.Size = new System.Drawing.Size(167, 20);
            this.txt_buscarH.TabIndex = 15;
            // 
            // btn_buscarH
            // 
            this.btn_buscarH.Location = new System.Drawing.Point(325, 98);
            this.btn_buscarH.Name = "btn_buscarH";
            this.btn_buscarH.Size = new System.Drawing.Size(70, 23);
            this.btn_buscarH.TabIndex = 16;
            this.btn_buscarH.Text = "Buscar";
            this.btn_buscarH.UseVisualStyleBackColor = true;
            // 
            // btn_buscarC
            // 
            this.btn_buscarC.Location = new System.Drawing.Point(917, 98);
            this.btn_buscarC.Name = "btn_buscarC";
            this.btn_buscarC.Size = new System.Drawing.Size(70, 23);
            this.btn_buscarC.TabIndex = 18;
            this.btn_buscarC.Text = "Buscar";
            this.btn_buscarC.UseVisualStyleBackColor = true;
            // 
            // txt_buscarC
            // 
            this.txt_buscarC.Location = new System.Drawing.Point(744, 100);
            this.txt_buscarC.Name = "txt_buscarC";
            this.txt_buscarC.Size = new System.Drawing.Size(167, 20);
            this.txt_buscarC.TabIndex = 17;
            // 
            // NuevoPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 581);
            this.Controls.Add(this.btn_buscarC);
            this.Controls.Add(this.txt_buscarC);
            this.Controls.Add(this.btn_buscarH);
            this.Controls.Add(this.txt_buscarH);
            this.Controls.Add(this.btn_aceptarPrestamo);
            this.Controls.Add(this.btn_salirPrestamo);
            this.Controls.Add(this.txt_clienteSeleccionado);
            this.Controls.Add(this.lbl_clienteSeleccionado);
            this.Controls.Add(this.btn_seleccionaC);
            this.Controls.Add(this.lbl_clientePrestamo);
            this.Controls.Add(this.dgv_clientes);
            this.Controls.Add(this.txt_herramienta);
            this.Controls.Add(this.lbl_herramientaSeleccionada);
            this.Controls.Add(this.btn_seleccionarH);
            this.Controls.Add(this.lbl_herramientaPrestamo);
            this.Controls.Add(this.dgv_herramientas);
            this.Controls.Add(this.lbl_nuevoPrestamo);
            this.Name = "NuevoPrestamo";
            this.Text = "NuevoPrestamo";
            this.Load += new System.EventHandler(this.NuevoPrestamo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_herramientas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nuevoPrestamo;
        private System.Windows.Forms.DataGridView dgv_herramientas;
        private System.Windows.Forms.Label lbl_herramientaPrestamo;
        private System.Windows.Forms.Button btn_seleccionarH;
        private System.Windows.Forms.Label lbl_herramientaSeleccionada;
        private System.Windows.Forms.TextBox txt_herramienta;
        private System.Windows.Forms.TextBox txt_clienteSeleccionado;
        private System.Windows.Forms.Label lbl_clienteSeleccionado;
        private System.Windows.Forms.Button btn_seleccionaC;
        private System.Windows.Forms.Label lbl_clientePrestamo;
        private System.Windows.Forms.DataGridView dgv_clientes;
        private System.Windows.Forms.Button btn_salirPrestamo;
        private System.Windows.Forms.Button btn_aceptarPrestamo;
        private System.Windows.Forms.TextBox txt_buscarH;
        private System.Windows.Forms.Button btn_buscarH;
        private System.Windows.Forms.Button btn_buscarC;
        private System.Windows.Forms.TextBox txt_buscarC;
    }
}