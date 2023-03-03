namespace VisionTFI
{
    partial class GestionarSocio
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
            this.dg_clientes = new System.Windows.Forms.DataGridView();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_quitar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_clientes
            // 
            this.dg_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_clientes.Location = new System.Drawing.Point(0, 91);
            this.dg_clientes.Name = "dg_clientes";
            this.dg_clientes.Size = new System.Drawing.Size(501, 291);
            this.dg_clientes.TabIndex = 0;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(605, 91);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(116, 29);
            this.btn_agregar.TabIndex = 1;
            this.btn_agregar.Text = "Agregar cliente";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(605, 145);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(116, 29);
            this.btn_modificar.TabIndex = 2;
            this.btn_modificar.Text = "Modificar cliente";
            this.btn_modificar.UseVisualStyleBackColor = true;
            // 
            // btn_quitar
            // 
            this.btn_quitar.Location = new System.Drawing.Point(605, 204);
            this.btn_quitar.Name = "btn_quitar";
            this.btn_quitar.Size = new System.Drawing.Size(116, 29);
            this.btn_quitar.TabIndex = 3;
            this.btn_quitar.Text = "Eliminar cliente";
            this.btn_quitar.UseVisualStyleBackColor = true;
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(605, 275);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(116, 29);
            this.btn_salir.TabIndex = 4;
            this.btn_salir.Text = "Cancelar";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // GestionarSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 450);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_quitar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.dg_clientes);
            this.Name = "GestionarSocio";
            this.Text = "Vision Management / Gestionar Cliente";
            this.Load += new System.EventHandler(this.GestionarSocio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_clientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_clientes;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_quitar;
        private System.Windows.Forms.Button btn_salir;
    }
}