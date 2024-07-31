namespace VisionTFI
{
    partial class AdministrarPrestamos
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
            this.lbl_gestionaPrestamos = new System.Windows.Forms.Label();
            this.dgv_prestamos = new System.Windows.Forms.DataGridView();
            this.txt_herramienta = new System.Windows.Forms.TextBox();
            this.lbl_herramientaM = new System.Windows.Forms.Label();
            this.btn_buscarHerramientaM = new System.Windows.Forms.Button();
            this.btn_nuevoPrestamo = new System.Windows.Forms.Button();
            this.btn_devolucionPrestamo = new System.Windows.Forms.Button();
            this.btn_consultarPrestamo = new System.Windows.Forms.Button();
            this.btn_salirGestionarP = new System.Windows.Forms.Button();
            this.btn_reporteP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_prestamos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_gestionaPrestamos
            // 
            this.lbl_gestionaPrestamos.AutoSize = true;
            this.lbl_gestionaPrestamos.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gestionaPrestamos.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_gestionaPrestamos.Location = new System.Drawing.Point(12, 9);
            this.lbl_gestionaPrestamos.Name = "lbl_gestionaPrestamos";
            this.lbl_gestionaPrestamos.Size = new System.Drawing.Size(494, 55);
            this.lbl_gestionaPrestamos.TabIndex = 0;
            this.lbl_gestionaPrestamos.Text = "Gestionar Prestamos";
            // 
            // dgv_prestamos
            // 
            this.dgv_prestamos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_prestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_prestamos.Location = new System.Drawing.Point(12, 133);
            this.dgv_prestamos.Name = "dgv_prestamos";
            this.dgv_prestamos.Size = new System.Drawing.Size(703, 331);
            this.dgv_prestamos.TabIndex = 1;
            this.dgv_prestamos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgv_prestamos_MouseClick);
            // 
            // txt_herramienta
            // 
            this.txt_herramienta.Location = new System.Drawing.Point(12, 107);
            this.txt_herramienta.Name = "txt_herramienta";
            this.txt_herramienta.Size = new System.Drawing.Size(121, 20);
            this.txt_herramienta.TabIndex = 2;
            // 
            // lbl_herramientaM
            // 
            this.lbl_herramientaM.AutoSize = true;
            this.lbl_herramientaM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_herramientaM.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_herramientaM.Location = new System.Drawing.Point(12, 84);
            this.lbl_herramientaM.Name = "lbl_herramientaM";
            this.lbl_herramientaM.Size = new System.Drawing.Size(108, 20);
            this.lbl_herramientaM.TabIndex = 3;
            this.lbl_herramientaM.Text = "Herramienta";
            // 
            // btn_buscarHerramientaM
            // 
            this.btn_buscarHerramientaM.Location = new System.Drawing.Point(140, 104);
            this.btn_buscarHerramientaM.Name = "btn_buscarHerramientaM";
            this.btn_buscarHerramientaM.Size = new System.Drawing.Size(75, 23);
            this.btn_buscarHerramientaM.TabIndex = 4;
            this.btn_buscarHerramientaM.Text = "Buscar";
            this.btn_buscarHerramientaM.UseVisualStyleBackColor = true;
            // 
            // btn_nuevoPrestamo
            // 
            this.btn_nuevoPrestamo.Location = new System.Drawing.Point(777, 149);
            this.btn_nuevoPrestamo.Name = "btn_nuevoPrestamo";
            this.btn_nuevoPrestamo.Size = new System.Drawing.Size(122, 23);
            this.btn_nuevoPrestamo.TabIndex = 5;
            this.btn_nuevoPrestamo.Text = "Nuevo prestamo";
            this.btn_nuevoPrestamo.UseVisualStyleBackColor = true;
            this.btn_nuevoPrestamo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // btn_devolucionPrestamo
            // 
            this.btn_devolucionPrestamo.Location = new System.Drawing.Point(777, 199);
            this.btn_devolucionPrestamo.Name = "btn_devolucionPrestamo";
            this.btn_devolucionPrestamo.Size = new System.Drawing.Size(122, 23);
            this.btn_devolucionPrestamo.TabIndex = 6;
            this.btn_devolucionPrestamo.Text = "Registrar devolucion";
            this.btn_devolucionPrestamo.UseVisualStyleBackColor = true;
            // 
            // btn_consultarPrestamo
            // 
            this.btn_consultarPrestamo.Location = new System.Drawing.Point(777, 248);
            this.btn_consultarPrestamo.Name = "btn_consultarPrestamo";
            this.btn_consultarPrestamo.Size = new System.Drawing.Size(122, 23);
            this.btn_consultarPrestamo.TabIndex = 7;
            this.btn_consultarPrestamo.Text = "Consultar prestamo";
            this.btn_consultarPrestamo.UseVisualStyleBackColor = true;
            // 
            // btn_salirGestionarP
            // 
            this.btn_salirGestionarP.Location = new System.Drawing.Point(989, 26);
            this.btn_salirGestionarP.Name = "btn_salirGestionarP";
            this.btn_salirGestionarP.Size = new System.Drawing.Size(75, 23);
            this.btn_salirGestionarP.TabIndex = 8;
            this.btn_salirGestionarP.Text = "Salir";
            this.btn_salirGestionarP.UseVisualStyleBackColor = true;
            this.btn_salirGestionarP.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_reporteP
            // 
            this.btn_reporteP.Location = new System.Drawing.Point(777, 326);
            this.btn_reporteP.Name = "btn_reporteP";
            this.btn_reporteP.Size = new System.Drawing.Size(122, 52);
            this.btn_reporteP.TabIndex = 9;
            this.btn_reporteP.Text = "Ver y guardar reporte";
            this.btn_reporteP.UseVisualStyleBackColor = true;
            this.btn_reporteP.Click += new System.EventHandler(this.btn_reporteP_Click);
            // 
            // AdministrarPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 570);
            this.Controls.Add(this.btn_reporteP);
            this.Controls.Add(this.btn_salirGestionarP);
            this.Controls.Add(this.btn_consultarPrestamo);
            this.Controls.Add(this.btn_devolucionPrestamo);
            this.Controls.Add(this.btn_nuevoPrestamo);
            this.Controls.Add(this.btn_buscarHerramientaM);
            this.Controls.Add(this.lbl_herramientaM);
            this.Controls.Add(this.txt_herramienta);
            this.Controls.Add(this.dgv_prestamos);
            this.Controls.Add(this.lbl_gestionaPrestamos);
            this.Name = "AdministrarPrestamos";
            this.Text = "AdministrarPrestamos";
            this.Load += new System.EventHandler(this.AdministrarPrestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_prestamos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_gestionaPrestamos;
        private System.Windows.Forms.DataGridView dgv_prestamos;
        private System.Windows.Forms.TextBox txt_herramienta;
        private System.Windows.Forms.Label lbl_herramientaM;
        private System.Windows.Forms.Button btn_buscarHerramientaM;
        private System.Windows.Forms.Button btn_nuevoPrestamo;
        private System.Windows.Forms.Button btn_devolucionPrestamo;
        private System.Windows.Forms.Button btn_consultarPrestamo;
        private System.Windows.Forms.Button btn_salirGestionarP;
        private System.Windows.Forms.Button btn_reporteP;
    }
}