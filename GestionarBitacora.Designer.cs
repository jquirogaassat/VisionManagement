namespace VisionTFI
{
    partial class GestionarBitacora
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
            this.lbl_buscarFecha = new System.Windows.Forms.Label();
            this.dt_desde = new System.Windows.Forms.DateTimePicker();
            this.lba_desde = new System.Windows.Forms.Label();
            this.lbl_hasta = new System.Windows.Forms.Label();
            this.dt_hasta = new System.Windows.Forms.DateTimePicker();
            this.lbl_user = new System.Windows.Forms.Label();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.cmb_usuario = new System.Windows.Forms.ComboBox();
            this.cmb_nivelCriticidad = new System.Windows.Forms.ComboBox();
            this.lbl_nivel = new System.Windows.Forms.Label();
            this.lbl_nivelCriticidad = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.dgv_bitacora = new System.Windows.Forms.DataGridView();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.lbl_orden = new System.Windows.Forms.Label();
            this.rdb_asc = new System.Windows.Forms.RadioButton();
            this.rdb_desc = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bitacora)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_buscarFecha
            // 
            this.lbl_buscarFecha.AutoSize = true;
            this.lbl_buscarFecha.Location = new System.Drawing.Point(25, 119);
            this.lbl_buscarFecha.Name = "lbl_buscarFecha";
            this.lbl_buscarFecha.Size = new System.Drawing.Size(88, 13);
            this.lbl_buscarFecha.TabIndex = 32;
            this.lbl_buscarFecha.Text = "Buscar por fecha";
            // 
            // dt_desde
            // 
            this.dt_desde.Location = new System.Drawing.Point(77, 148);
            this.dt_desde.Name = "dt_desde";
            this.dt_desde.Size = new System.Drawing.Size(200, 20);
            this.dt_desde.TabIndex = 33;
            // 
            // lba_desde
            // 
            this.lba_desde.AutoSize = true;
            this.lba_desde.Location = new System.Drawing.Point(25, 154);
            this.lba_desde.Name = "lba_desde";
            this.lba_desde.Size = new System.Drawing.Size(44, 13);
            this.lba_desde.TabIndex = 34;
            this.lba_desde.Text = "Desde :";
            // 
            // lbl_hasta
            // 
            this.lbl_hasta.AutoSize = true;
            this.lbl_hasta.Location = new System.Drawing.Point(25, 201);
            this.lbl_hasta.Name = "lbl_hasta";
            this.lbl_hasta.Size = new System.Drawing.Size(41, 13);
            this.lbl_hasta.TabIndex = 36;
            this.lbl_hasta.Text = "Hasta :";
            // 
            // dt_hasta
            // 
            this.dt_hasta.Location = new System.Drawing.Point(77, 195);
            this.dt_hasta.Name = "dt_hasta";
            this.dt_hasta.Size = new System.Drawing.Size(200, 20);
            this.dt_hasta.TabIndex = 35;
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Location = new System.Drawing.Point(503, 119);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(95, 13);
            this.lbl_user.TabIndex = 37;
            this.lbl_user.Text = "Buscar por usuario";
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Location = new System.Drawing.Point(503, 154);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(49, 13);
            this.lbl_usuario.TabIndex = 38;
            this.lbl_usuario.Text = "Usuario :";
            // 
            // cmb_usuario
            // 
            this.cmb_usuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_usuario.FormattingEnabled = true;
            this.cmb_usuario.Location = new System.Drawing.Point(558, 151);
            this.cmb_usuario.Name = "cmb_usuario";
            this.cmb_usuario.Size = new System.Drawing.Size(121, 21);
            this.cmb_usuario.TabIndex = 39;
            // 
            // cmb_nivelCriticidad
            // 
            this.cmb_nivelCriticidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_nivelCriticidad.FormattingEnabled = true;
            this.cmb_nivelCriticidad.Location = new System.Drawing.Point(822, 151);
            this.cmb_nivelCriticidad.Name = "cmb_nivelCriticidad";
            this.cmb_nivelCriticidad.Size = new System.Drawing.Size(121, 21);
            this.cmb_nivelCriticidad.TabIndex = 42;
            // 
            // lbl_nivel
            // 
            this.lbl_nivel.AutoSize = true;
            this.lbl_nivel.Location = new System.Drawing.Point(767, 154);
            this.lbl_nivel.Name = "lbl_nivel";
            this.lbl_nivel.Size = new System.Drawing.Size(37, 13);
            this.lbl_nivel.TabIndex = 41;
            this.lbl_nivel.Text = "Nivel :";
            // 
            // lbl_nivelCriticidad
            // 
            this.lbl_nivelCriticidad.AutoSize = true;
            this.lbl_nivelCriticidad.Location = new System.Drawing.Point(767, 119);
            this.lbl_nivelCriticidad.Name = "lbl_nivelCriticidad";
            this.lbl_nivelCriticidad.Size = new System.Drawing.Size(91, 13);
            this.lbl_nivelCriticidad.TabIndex = 40;
            this.lbl_nivelCriticidad.Text = "Nivel de criticidad";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(1026, 148);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(123, 31);
            this.btn_buscar.TabIndex = 43;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Location = new System.Drawing.Point(957, 513);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(123, 31);
            this.btn_imprimir.TabIndex = 44;
            this.btn_imprimir.Text = "Imprimir";
            this.btn_imprimir.UseVisualStyleBackColor = true;
            // 
            // dgv_bitacora
            // 
            this.dgv_bitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bitacora.Location = new System.Drawing.Point(12, 234);
            this.dgv_bitacora.Name = "dgv_bitacora";
            this.dgv_bitacora.Size = new System.Drawing.Size(1137, 262);
            this.dgv_bitacora.TabIndex = 45;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(1097, 513);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(123, 31);
            this.btn_cancelar.TabIndex = 46;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // lbl_orden
            // 
            this.lbl_orden.AutoSize = true;
            this.lbl_orden.Location = new System.Drawing.Point(344, 119);
            this.lbl_orden.Name = "lbl_orden";
            this.lbl_orden.Size = new System.Drawing.Size(36, 13);
            this.lbl_orden.TabIndex = 47;
            this.lbl_orden.Text = "Orden";
            // 
            // rdb_asc
            // 
            this.rdb_asc.AutoSize = true;
            this.rdb_asc.Checked = true;
            this.rdb_asc.Location = new System.Drawing.Point(321, 148);
            this.rdb_asc.Name = "rdb_asc";
            this.rdb_asc.Size = new System.Drawing.Size(82, 17);
            this.rdb_asc.TabIndex = 48;
            this.rdb_asc.TabStop = true;
            this.rdb_asc.Text = "Ascendente";
            this.rdb_asc.UseVisualStyleBackColor = true;
            // 
            // rdb_desc
            // 
            this.rdb_desc.AutoSize = true;
            this.rdb_desc.Location = new System.Drawing.Point(321, 182);
            this.rdb_desc.Name = "rdb_desc";
            this.rdb_desc.Size = new System.Drawing.Size(89, 17);
            this.rdb_desc.TabIndex = 49;
            this.rdb_desc.Text = "Descendente";
            this.rdb_desc.UseVisualStyleBackColor = true;
            // 
            // GestionarBitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 630);
            this.Controls.Add(this.rdb_desc);
            this.Controls.Add(this.rdb_asc);
            this.Controls.Add(this.lbl_orden);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.dgv_bitacora);
            this.Controls.Add(this.btn_imprimir);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.cmb_nivelCriticidad);
            this.Controls.Add(this.lbl_nivel);
            this.Controls.Add(this.lbl_nivelCriticidad);
            this.Controls.Add(this.cmb_usuario);
            this.Controls.Add(this.lbl_usuario);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.lbl_hasta);
            this.Controls.Add(this.dt_hasta);
            this.Controls.Add(this.lba_desde);
            this.Controls.Add(this.dt_desde);
            this.Controls.Add(this.lbl_buscarFecha);
            this.Name = "GestionarBitacora";
            this.Text = "Vision Management/ Gestionar bitácora";
            this.Load += new System.EventHandler(this.GestionarBitacora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bitacora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_buscarFecha;
        private System.Windows.Forms.DateTimePicker dt_desde;
        private System.Windows.Forms.Label lba_desde;
        private System.Windows.Forms.Label lbl_hasta;
        private System.Windows.Forms.DateTimePicker dt_hasta;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.ComboBox cmb_usuario;
        private System.Windows.Forms.ComboBox cmb_nivelCriticidad;
        private System.Windows.Forms.Label lbl_nivel;
        private System.Windows.Forms.Label lbl_nivelCriticidad;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.DataGridView dgv_bitacora;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label lbl_orden;
        private System.Windows.Forms.RadioButton rdb_asc;
        private System.Windows.Forms.RadioButton rdb_desc;
    }
}