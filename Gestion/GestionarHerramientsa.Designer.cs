namespace VisionTFI
{
    partial class GestionarHerramientsa
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
            this.lbl_gestionarHerramienta = new System.Windows.Forms.Label();
            this.btn_salirHerramienta = new System.Windows.Forms.Button();
            this.btn_quitarHerramienta = new System.Windows.Forms.Button();
            this.btn_modificarHerramienta = new System.Windows.Forms.Button();
            this.btn_agregarHerramienta = new System.Windows.Forms.Button();
            this.dg_herramienta = new System.Windows.Forms.DataGridView();
            this.btn_buscarHerramienta = new System.Windows.Forms.Button();
            this.lbl_nombreHerramienta = new System.Windows.Forms.Label();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg_herramienta)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_gestionarHerramienta
            // 
            this.lbl_gestionarHerramienta.AutoSize = true;
            this.lbl_gestionarHerramienta.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gestionarHerramienta.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_gestionarHerramienta.Location = new System.Drawing.Point(3, 9);
            this.lbl_gestionarHerramienta.Name = "lbl_gestionarHerramienta";
            this.lbl_gestionarHerramienta.Size = new System.Drawing.Size(665, 69);
            this.lbl_gestionarHerramienta.TabIndex = 17;
            this.lbl_gestionarHerramienta.Text = "Gestionar Herramientas";
            // 
            // btn_salirHerramienta
            // 
            this.btn_salirHerramienta.Location = new System.Drawing.Point(821, 331);
            this.btn_salirHerramienta.Name = "btn_salirHerramienta";
            this.btn_salirHerramienta.Size = new System.Drawing.Size(116, 29);
            this.btn_salirHerramienta.TabIndex = 25;
            this.btn_salirHerramienta.Text = "Cancelar";
            this.btn_salirHerramienta.UseVisualStyleBackColor = true;
            this.btn_salirHerramienta.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_quitarHerramienta
            // 
            this.btn_quitarHerramienta.Location = new System.Drawing.Point(821, 260);
            this.btn_quitarHerramienta.Name = "btn_quitarHerramienta";
            this.btn_quitarHerramienta.Size = new System.Drawing.Size(116, 29);
            this.btn_quitarHerramienta.TabIndex = 24;
            this.btn_quitarHerramienta.Text = "Eliminar herramienta";
            this.btn_quitarHerramienta.UseVisualStyleBackColor = true;
            this.btn_quitarHerramienta.Click += new System.EventHandler(this.btn_quitar_Click);
            // 
            // btn_modificarHerramienta
            // 
            this.btn_modificarHerramienta.Location = new System.Drawing.Point(821, 201);
            this.btn_modificarHerramienta.Name = "btn_modificarHerramienta";
            this.btn_modificarHerramienta.Size = new System.Drawing.Size(116, 29);
            this.btn_modificarHerramienta.TabIndex = 23;
            this.btn_modificarHerramienta.Text = "Modificar herramienta";
            this.btn_modificarHerramienta.UseVisualStyleBackColor = true;
            this.btn_modificarHerramienta.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_agregarHerramienta
            // 
            this.btn_agregarHerramienta.Location = new System.Drawing.Point(821, 147);
            this.btn_agregarHerramienta.Name = "btn_agregarHerramienta";
            this.btn_agregarHerramienta.Size = new System.Drawing.Size(116, 29);
            this.btn_agregarHerramienta.TabIndex = 22;
            this.btn_agregarHerramienta.Text = "Agregar herramienta";
            this.btn_agregarHerramienta.UseVisualStyleBackColor = true;
            this.btn_agregarHerramienta.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // dg_herramienta
            // 
            this.dg_herramienta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_herramienta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_herramienta.Location = new System.Drawing.Point(12, 147);
            this.dg_herramienta.Name = "dg_herramienta";
            this.dg_herramienta.Size = new System.Drawing.Size(763, 291);
            this.dg_herramienta.TabIndex = 21;
            this.dg_herramienta.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dg_herramienta_MouseClick_1);
            // 
            // btn_buscarHerramienta
            // 
            this.btn_buscarHerramienta.Location = new System.Drawing.Point(237, 118);
            this.btn_buscarHerramienta.Name = "btn_buscarHerramienta";
            this.btn_buscarHerramienta.Size = new System.Drawing.Size(75, 23);
            this.btn_buscarHerramienta.TabIndex = 20;
            this.btn_buscarHerramienta.Text = "Buscar";
            this.btn_buscarHerramienta.UseVisualStyleBackColor = true;
            // 
            // lbl_nombreHerramienta
            // 
            this.lbl_nombreHerramienta.AutoSize = true;
            this.lbl_nombreHerramienta.Location = new System.Drawing.Point(12, 105);
            this.lbl_nombreHerramienta.Name = "lbl_nombreHerramienta";
            this.lbl_nombreHerramienta.Size = new System.Drawing.Size(40, 13);
            this.lbl_nombreHerramienta.TabIndex = 19;
            this.lbl_nombreHerramienta.Text = "Codigo";
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(12, 121);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(200, 20);
            this.txt_buscar.TabIndex = 18;
            // 
            // GestionarHerramientsa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 539);
            this.Controls.Add(this.btn_salirHerramienta);
            this.Controls.Add(this.btn_quitarHerramienta);
            this.Controls.Add(this.btn_modificarHerramienta);
            this.Controls.Add(this.btn_agregarHerramienta);
            this.Controls.Add(this.dg_herramienta);
            this.Controls.Add(this.btn_buscarHerramienta);
            this.Controls.Add(this.lbl_nombreHerramienta);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.lbl_gestionarHerramienta);
            this.Name = "GestionarHerramientsa";
            this.Text = "GestionarHerramientsa";
            this.Load += new System.EventHandler(this.GestionarHerramientsa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_herramienta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_gestionarHerramienta;
        private System.Windows.Forms.Button btn_salirHerramienta;
        private System.Windows.Forms.Button btn_quitarHerramienta;
        private System.Windows.Forms.Button btn_modificarHerramienta;
        private System.Windows.Forms.Button btn_agregarHerramienta;
        private System.Windows.Forms.DataGridView dg_herramienta;
        private System.Windows.Forms.Button btn_buscarHerramienta;
        private System.Windows.Forms.Label lbl_nombreHerramienta;
        private System.Windows.Forms.TextBox txt_buscar;
    }
}