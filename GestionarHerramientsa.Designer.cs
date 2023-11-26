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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_quitar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.dg_herramienta = new System.Windows.Forms.DataGridView();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg_herramienta)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(665, 69);
            this.label1.TabIndex = 17;
            this.label1.Text = "Gestionar Herramientas";
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(821, 331);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(116, 29);
            this.btn_salir.TabIndex = 25;
            this.btn_salir.Text = "Cancelar";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_quitar
            // 
            this.btn_quitar.Location = new System.Drawing.Point(821, 260);
            this.btn_quitar.Name = "btn_quitar";
            this.btn_quitar.Size = new System.Drawing.Size(116, 29);
            this.btn_quitar.TabIndex = 24;
            this.btn_quitar.Text = "Eliminar herramienta";
            this.btn_quitar.UseVisualStyleBackColor = true;
            this.btn_quitar.Click += new System.EventHandler(this.btn_quitar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(821, 201);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(116, 29);
            this.btn_modificar.TabIndex = 23;
            this.btn_modificar.Text = "Modificar herramienta";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(821, 147);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(116, 29);
            this.btn_agregar.TabIndex = 22;
            this.btn_agregar.Text = "Agregar herramienta";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
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
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(237, 118);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 20;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(12, 105);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(40, 13);
            this.lbl_nombre.TabIndex = 19;
            this.lbl_nombre.Text = "Codigo";
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
            this.ClientSize = new System.Drawing.Size(1065, 450);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_quitar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.dg_herramienta);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.label1);
            this.Name = "GestionarHerramientsa";
            this.Text = "GestionarHerramientsa";
            this.Load += new System.EventHandler(this.GestionarHerramientsa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_herramienta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_quitar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.DataGridView dg_herramienta;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox txt_buscar;
    }
}