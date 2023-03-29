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
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_clientes
            // 
            this.dg_clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_clientes.Location = new System.Drawing.Point(0, 91);
            this.dg_clientes.Name = "dg_clientes";
            this.dg_clientes.Size = new System.Drawing.Size(763, 291);
            this.dg_clientes.TabIndex = 0;
            this.dg_clientes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dg_clientes_MouseClick);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(785, 97);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(116, 29);
            this.btn_agregar.TabIndex = 1;
            this.btn_agregar.Text = "Agregar cliente";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(785, 151);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(116, 29);
            this.btn_modificar.TabIndex = 2;
            this.btn_modificar.Text = "Modificar cliente";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_quitar
            // 
            this.btn_quitar.Location = new System.Drawing.Point(785, 210);
            this.btn_quitar.Name = "btn_quitar";
            this.btn_quitar.Size = new System.Drawing.Size(116, 29);
            this.btn_quitar.TabIndex = 3;
            this.btn_quitar.Text = "Eliminar cliente";
            this.btn_quitar.UseVisualStyleBackColor = true;
            this.btn_quitar.Click += new System.EventHandler(this.btn_quitar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(785, 281);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(116, 29);
            this.btn_salir.TabIndex = 4;
            this.btn_salir.Text = "Cancelar";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(12, 56);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(200, 20);
            this.txt_buscar.TabIndex = 5;
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Location = new System.Drawing.Point(12, 40);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(44, 13);
            this.lbl_apellido.TabIndex = 6;
            this.lbl_apellido.Text = "Apellido";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(237, 53);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 7;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            // 
            // GestionarSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 450);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.lbl_apellido);
            this.Controls.Add(this.txt_buscar);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_clientes;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_quitar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.Button btn_buscar;
    }
}