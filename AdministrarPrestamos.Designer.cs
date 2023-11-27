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
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_prestamos = new System.Windows.Forms.DataGridView();
            this.txt_herramienta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_devolucion = new System.Windows.Forms.Button();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_reporteP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_prestamos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(494, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestionar Prestamos";
            // 
            // dgv_prestamos
            // 
            this.dgv_prestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_prestamos.Location = new System.Drawing.Point(12, 133);
            this.dgv_prestamos.Name = "dgv_prestamos";
            this.dgv_prestamos.Size = new System.Drawing.Size(739, 331);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Herramienta";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(140, 104);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 4;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Location = new System.Drawing.Point(777, 149);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(122, 23);
            this.btn_nuevo.TabIndex = 5;
            this.btn_nuevo.Text = "Nuevo prestamo";
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // btn_devolucion
            // 
            this.btn_devolucion.Location = new System.Drawing.Point(777, 199);
            this.btn_devolucion.Name = "btn_devolucion";
            this.btn_devolucion.Size = new System.Drawing.Size(122, 23);
            this.btn_devolucion.TabIndex = 6;
            this.btn_devolucion.Text = "Registrar devolucion";
            this.btn_devolucion.UseVisualStyleBackColor = true;
            // 
            // btn_consultar
            // 
            this.btn_consultar.Location = new System.Drawing.Point(777, 248);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(122, 23);
            this.btn_consultar.TabIndex = 7;
            this.btn_consultar.Text = "Consultar prestamo";
            this.btn_consultar.UseVisualStyleBackColor = true;
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(930, 27);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 8;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_reporteP
            // 
            this.btn_reporteP.Location = new System.Drawing.Point(777, 348);
            this.btn_reporteP.Name = "btn_reporteP";
            this.btn_reporteP.Size = new System.Drawing.Size(122, 52);
            this.btn_reporteP.TabIndex = 9;
            this.btn_reporteP.Text = "Ver reporte";
            this.btn_reporteP.UseVisualStyleBackColor = true;
            this.btn_reporteP.Click += new System.EventHandler(this.btn_reporteP_Click);
            // 
            // AdministrarPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 539);
            this.Controls.Add(this.btn_reporteP);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.btn_devolucion);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_herramienta);
            this.Controls.Add(this.dgv_prestamos);
            this.Controls.Add(this.label1);
            this.Name = "AdministrarPrestamos";
            this.Text = "AdministrarPrestamos";
            this.Load += new System.EventHandler(this.AdministrarPrestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_prestamos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_prestamos;
        private System.Windows.Forms.TextBox txt_herramienta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_devolucion;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_reporteP;
    }
}