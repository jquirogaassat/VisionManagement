namespace VisionTFI
{
    partial class BitacoraC
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
            this.dgv_bitacora = new System.Windows.Forms.DataGridView();
            this.btn_consultarBitacoraCambios = new System.Windows.Forms.Button();
            this.btn_activarBitacoraCambios = new System.Windows.Forms.Button();
            this.lbl_bitacoraCambios = new System.Windows.Forms.Label();
            this.lbl_codigoProducto = new System.Windows.Forms.Label();
            this.lbl_hastaBitacoraCambios = new System.Windows.Forms.Label();
            this.dt_hasta = new System.Windows.Forms.DateTimePicker();
            this.lba_desdeBitacoraCambios = new System.Windows.Forms.Label();
            this.dt_desde = new System.Windows.Forms.DateTimePicker();
            this.cmb_producto = new System.Windows.Forms.ComboBox();
            this.btn_cerrarBitacoraCambios = new System.Windows.Forms.Button();
            this.cmb_usuario = new System.Windows.Forms.ComboBox();
            this.lbl_usuarioBitacoraCambios = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bitacora)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_bitacora
            // 
            this.dgv_bitacora.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_bitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bitacora.Location = new System.Drawing.Point(12, 102);
            this.dgv_bitacora.Name = "dgv_bitacora";
            this.dgv_bitacora.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_bitacora.Size = new System.Drawing.Size(740, 353);
            this.dgv_bitacora.TabIndex = 46;
            // 
            // btn_consultarBitacoraCambios
            // 
            this.btn_consultarBitacoraCambios.Location = new System.Drawing.Point(810, 240);
            this.btn_consultarBitacoraCambios.Name = "btn_consultarBitacoraCambios";
            this.btn_consultarBitacoraCambios.Size = new System.Drawing.Size(75, 23);
            this.btn_consultarBitacoraCambios.TabIndex = 47;
            this.btn_consultarBitacoraCambios.Text = "Consultar";
            this.btn_consultarBitacoraCambios.UseVisualStyleBackColor = true;
            this.btn_consultarBitacoraCambios.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // btn_activarBitacoraCambios
            // 
            this.btn_activarBitacoraCambios.Location = new System.Drawing.Point(891, 240);
            this.btn_activarBitacoraCambios.Name = "btn_activarBitacoraCambios";
            this.btn_activarBitacoraCambios.Size = new System.Drawing.Size(75, 23);
            this.btn_activarBitacoraCambios.TabIndex = 48;
            this.btn_activarBitacoraCambios.Text = "Activar";
            this.btn_activarBitacoraCambios.UseVisualStyleBackColor = true;
            this.btn_activarBitacoraCambios.Click += new System.EventHandler(this.btn_activar_Click);
            // 
            // lbl_bitacoraCambios
            // 
            this.lbl_bitacoraCambios.AutoSize = true;
            this.lbl_bitacoraCambios.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bitacoraCambios.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_bitacoraCambios.Location = new System.Drawing.Point(-1, 9);
            this.lbl_bitacoraCambios.Name = "lbl_bitacoraCambios";
            this.lbl_bitacoraCambios.Size = new System.Drawing.Size(459, 55);
            this.lbl_bitacoraCambios.TabIndex = 49;
            this.lbl_bitacoraCambios.Text = "Bitacora de cambios";
            // 
            // lbl_codigoProducto
            // 
            this.lbl_codigoProducto.AutoSize = true;
            this.lbl_codigoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigoProducto.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_codigoProducto.Location = new System.Drawing.Point(806, 74);
            this.lbl_codigoProducto.Name = "lbl_codigoProducto";
            this.lbl_codigoProducto.Size = new System.Drawing.Size(166, 20);
            this.lbl_codigoProducto.TabIndex = 51;
            this.lbl_codigoProducto.Text = "Codigo de producto";
            // 
            // lbl_hastaBitacoraCambios
            // 
            this.lbl_hastaBitacoraCambios.AutoSize = true;
            this.lbl_hastaBitacoraCambios.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_hastaBitacoraCambios.Location = new System.Drawing.Point(758, 209);
            this.lbl_hastaBitacoraCambios.Name = "lbl_hastaBitacoraCambios";
            this.lbl_hastaBitacoraCambios.Size = new System.Drawing.Size(41, 13);
            this.lbl_hastaBitacoraCambios.TabIndex = 55;
            this.lbl_hastaBitacoraCambios.Text = "Hasta :";
            // 
            // dt_hasta
            // 
            this.dt_hasta.Location = new System.Drawing.Point(810, 203);
            this.dt_hasta.Name = "dt_hasta";
            this.dt_hasta.Size = new System.Drawing.Size(200, 20);
            this.dt_hasta.TabIndex = 54;
            // 
            // lba_desdeBitacoraCambios
            // 
            this.lba_desdeBitacoraCambios.AutoSize = true;
            this.lba_desdeBitacoraCambios.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lba_desdeBitacoraCambios.Location = new System.Drawing.Point(758, 183);
            this.lba_desdeBitacoraCambios.Name = "lba_desdeBitacoraCambios";
            this.lba_desdeBitacoraCambios.Size = new System.Drawing.Size(44, 13);
            this.lba_desdeBitacoraCambios.TabIndex = 53;
            this.lba_desdeBitacoraCambios.Text = "Desde :";
            // 
            // dt_desde
            // 
            this.dt_desde.Location = new System.Drawing.Point(810, 177);
            this.dt_desde.Name = "dt_desde";
            this.dt_desde.Size = new System.Drawing.Size(200, 20);
            this.dt_desde.TabIndex = 52;
            // 
            // cmb_producto
            // 
            this.cmb_producto.FormattingEnabled = true;
            this.cmb_producto.Location = new System.Drawing.Point(810, 97);
            this.cmb_producto.Name = "cmb_producto";
            this.cmb_producto.Size = new System.Drawing.Size(75, 21);
            this.cmb_producto.TabIndex = 56;
            // 
            // btn_cerrarBitacoraCambios
            // 
            this.btn_cerrarBitacoraCambios.Location = new System.Drawing.Point(850, 293);
            this.btn_cerrarBitacoraCambios.Name = "btn_cerrarBitacoraCambios";
            this.btn_cerrarBitacoraCambios.Size = new System.Drawing.Size(75, 23);
            this.btn_cerrarBitacoraCambios.TabIndex = 57;
            this.btn_cerrarBitacoraCambios.Text = "Cerrar";
            this.btn_cerrarBitacoraCambios.UseVisualStyleBackColor = true;
            this.btn_cerrarBitacoraCambios.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // cmb_usuario
            // 
            this.cmb_usuario.FormattingEnabled = true;
            this.cmb_usuario.Location = new System.Drawing.Point(810, 144);
            this.cmb_usuario.Name = "cmb_usuario";
            this.cmb_usuario.Size = new System.Drawing.Size(200, 21);
            this.cmb_usuario.TabIndex = 59;
            // 
            // lbl_usuarioBitacoraCambios
            // 
            this.lbl_usuarioBitacoraCambios.AutoSize = true;
            this.lbl_usuarioBitacoraCambios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuarioBitacoraCambios.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_usuarioBitacoraCambios.Location = new System.Drawing.Point(806, 121);
            this.lbl_usuarioBitacoraCambios.Name = "lbl_usuarioBitacoraCambios";
            this.lbl_usuarioBitacoraCambios.Size = new System.Drawing.Size(71, 20);
            this.lbl_usuarioBitacoraCambios.TabIndex = 58;
            this.lbl_usuarioBitacoraCambios.Text = "Usuario";
            // 
            // BitacoraC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 495);
            this.Controls.Add(this.cmb_usuario);
            this.Controls.Add(this.lbl_usuarioBitacoraCambios);
            this.Controls.Add(this.btn_cerrarBitacoraCambios);
            this.Controls.Add(this.cmb_producto);
            this.Controls.Add(this.lbl_hastaBitacoraCambios);
            this.Controls.Add(this.dt_hasta);
            this.Controls.Add(this.lba_desdeBitacoraCambios);
            this.Controls.Add(this.dt_desde);
            this.Controls.Add(this.lbl_codigoProducto);
            this.Controls.Add(this.lbl_bitacoraCambios);
            this.Controls.Add(this.btn_activarBitacoraCambios);
            this.Controls.Add(this.btn_consultarBitacoraCambios);
            this.Controls.Add(this.dgv_bitacora);
            this.Name = "BitacoraC";
            this.Text = "Bitacora de cambios";
            this.Load += new System.EventHandler(this.BitacoraC_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bitacora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_bitacora;
        private System.Windows.Forms.Button btn_consultarBitacoraCambios;
        private System.Windows.Forms.Button btn_activarBitacoraCambios;
        private System.Windows.Forms.Label lbl_bitacoraCambios;
        private System.Windows.Forms.Label lbl_codigoProducto;
        private System.Windows.Forms.Label lbl_hastaBitacoraCambios;
        private System.Windows.Forms.DateTimePicker dt_hasta;
        private System.Windows.Forms.Label lba_desdeBitacoraCambios;
        private System.Windows.Forms.DateTimePicker dt_desde;
        private System.Windows.Forms.ComboBox cmb_producto;
        private System.Windows.Forms.Button btn_cerrarBitacoraCambios;
        private System.Windows.Forms.ComboBox cmb_usuario;
        private System.Windows.Forms.Label lbl_usuarioBitacoraCambios;
    }
}