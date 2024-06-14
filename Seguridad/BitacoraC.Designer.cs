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
            this.btn_consultar = new System.Windows.Forms.Button();
            this.btn_activar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.lbl_hasta = new System.Windows.Forms.Label();
            this.dt_hasta = new System.Windows.Forms.DateTimePicker();
            this.lba_desde = new System.Windows.Forms.Label();
            this.dt_desde = new System.Windows.Forms.DateTimePicker();
            this.cmb_producto = new System.Windows.Forms.ComboBox();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.cmb_usuario = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
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
            // btn_consultar
            // 
            this.btn_consultar.Location = new System.Drawing.Point(810, 240);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(75, 23);
            this.btn_consultar.TabIndex = 47;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // btn_activar
            // 
            this.btn_activar.Location = new System.Drawing.Point(891, 240);
            this.btn_activar.Name = "btn_activar";
            this.btn_activar.Size = new System.Drawing.Size(75, 23);
            this.btn_activar.TabIndex = 48;
            this.btn_activar.Text = "Activar";
            this.btn_activar.UseVisualStyleBackColor = true;
            this.btn_activar.Click += new System.EventHandler(this.btn_activar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(-1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(459, 55);
            this.label1.TabIndex = 49;
            this.label1.Text = "Bitacora de cambios";
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_codigo.Location = new System.Drawing.Point(806, 74);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(166, 20);
            this.lbl_codigo.TabIndex = 51;
            this.lbl_codigo.Text = "Codigo de producto";
            // 
            // lbl_hasta
            // 
            this.lbl_hasta.AutoSize = true;
            this.lbl_hasta.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_hasta.Location = new System.Drawing.Point(758, 209);
            this.lbl_hasta.Name = "lbl_hasta";
            this.lbl_hasta.Size = new System.Drawing.Size(41, 13);
            this.lbl_hasta.TabIndex = 55;
            this.lbl_hasta.Text = "Hasta :";
            // 
            // dt_hasta
            // 
            this.dt_hasta.Location = new System.Drawing.Point(810, 203);
            this.dt_hasta.Name = "dt_hasta";
            this.dt_hasta.Size = new System.Drawing.Size(200, 20);
            this.dt_hasta.TabIndex = 54;
            // 
            // lba_desde
            // 
            this.lba_desde.AutoSize = true;
            this.lba_desde.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lba_desde.Location = new System.Drawing.Point(758, 183);
            this.lba_desde.Name = "lba_desde";
            this.lba_desde.Size = new System.Drawing.Size(44, 13);
            this.lba_desde.TabIndex = 53;
            this.lba_desde.Text = "Desde :";
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
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(850, 293);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(75, 23);
            this.btn_cerrar.TabIndex = 57;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // cmb_usuario
            // 
            this.cmb_usuario.FormattingEnabled = true;
            this.cmb_usuario.Location = new System.Drawing.Point(810, 144);
            this.cmb_usuario.Name = "cmb_usuario";
            this.cmb_usuario.Size = new System.Drawing.Size(200, 21);
            this.cmb_usuario.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(806, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 58;
            this.label2.Text = "Usuario";
            // 
            // BitacoraC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 495);
            this.Controls.Add(this.cmb_usuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.cmb_producto);
            this.Controls.Add(this.lbl_hasta);
            this.Controls.Add(this.dt_hasta);
            this.Controls.Add(this.lba_desde);
            this.Controls.Add(this.dt_desde);
            this.Controls.Add(this.lbl_codigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_activar);
            this.Controls.Add(this.btn_consultar);
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
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.Button btn_activar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.Label lbl_hasta;
        private System.Windows.Forms.DateTimePicker dt_hasta;
        private System.Windows.Forms.Label lba_desde;
        private System.Windows.Forms.DateTimePicker dt_desde;
        private System.Windows.Forms.ComboBox cmb_producto;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.ComboBox cmb_usuario;
        private System.Windows.Forms.Label label2;
    }
}