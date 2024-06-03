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
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_herramientas = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_seleccionarH = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_herramienta = new System.Windows.Forms.TextBox();
            this.txt_clienteSeleccionado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_seleccionaC = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_clientes = new System.Windows.Forms.DataGridView();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.txt_buscarH = new System.Windows.Forms.TextBox();
            this.btn_buscarH = new System.Windows.Forms.Button();
            this.btn_buscarC = new System.Windows.Forms.Button();
            this.txt_buscarC = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_herramientas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nuevo prestamo";
            // 
            // dgv_herramientas
            // 
            this.dgv_herramientas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Herramientas";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(13, 414);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Herramienta seleccionada";
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
            this.txt_clienteSeleccionado.Location = new System.Drawing.Point(587, 448);
            this.txt_clienteSeleccionado.Name = "txt_clienteSeleccionado";
            this.txt_clienteSeleccionado.Size = new System.Drawing.Size(350, 20);
            this.txt_clienteSeleccionado.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(587, 414);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Cliente seleccionado";
            // 
            // btn_seleccionaC
            // 
            this.btn_seleccionaC.Location = new System.Drawing.Point(817, 344);
            this.btn_seleccionaC.Name = "btn_seleccionaC";
            this.btn_seleccionaC.Size = new System.Drawing.Size(120, 23);
            this.btn_seleccionaC.TabIndex = 10;
            this.btn_seleccionaC.Text = "Seleccionar";
            this.btn_seleccionaC.UseVisualStyleBackColor = true;
            this.btn_seleccionaC.Click += new System.EventHandler(this.btn_seleccionaC_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(663, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cliente";
            // 
            // dgv_clientes
            // 
            this.dgv_clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgv_clientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_clientes.EnableHeadersVisualStyles = false;
            this.dgv_clientes.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgv_clientes.Location = new System.Drawing.Point(667, 134);
            this.dgv_clientes.Name = "dgv_clientes";
            this.dgv_clientes.Size = new System.Drawing.Size(460, 204);
            this.dgv_clientes.TabIndex = 7;
            this.dgv_clientes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgv_clientes_MouseClick);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(619, 516);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(106, 36);
            this.btn_salir.TabIndex = 13;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(772, 516);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(136, 36);
            this.btn_aceptar.TabIndex = 14;
            this.btn_aceptar.Text = "Efectuar prestamo";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
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
            this.ClientSize = new System.Drawing.Size(1139, 581);
            this.Controls.Add(this.btn_buscarC);
            this.Controls.Add(this.txt_buscarC);
            this.Controls.Add(this.btn_buscarH);
            this.Controls.Add(this.txt_buscarH);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.txt_clienteSeleccionado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_seleccionaC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgv_clientes);
            this.Controls.Add(this.txt_herramienta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_seleccionarH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_herramientas);
            this.Controls.Add(this.label1);
            this.Name = "NuevoPrestamo";
            this.Text = "NuevoPrestamo";
            this.Load += new System.EventHandler(this.NuevoPrestamo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_herramientas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_herramientas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_seleccionarH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_herramienta;
        private System.Windows.Forms.TextBox txt_clienteSeleccionado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_seleccionaC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_clientes;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.TextBox txt_buscarH;
        private System.Windows.Forms.Button btn_buscarH;
        private System.Windows.Forms.Button btn_buscarC;
        private System.Windows.Forms.TextBox txt_buscarC;
    }
}