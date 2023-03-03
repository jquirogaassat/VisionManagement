namespace VisionTFI
{
    partial class AdministrarUsers
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
            this.dgv_user = new System.Windows.Forms.DataGridView();
            this.btn_nuevoUser = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_eliminarUser = new System.Windows.Forms.Button();
            this.checkActivos = new System.Windows.Forms.CheckBox();
            this.btn_salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_user
            // 
            this.dgv_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_user.Location = new System.Drawing.Point(25, 86);
            this.dgv_user.Name = "dgv_user";
            this.dgv_user.Size = new System.Drawing.Size(843, 426);
            this.dgv_user.TabIndex = 25;
            this.dgv_user.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_user_CellContentClick);
            // 
            // btn_nuevoUser
            // 
            this.btn_nuevoUser.Location = new System.Drawing.Point(961, 125);
            this.btn_nuevoUser.Name = "btn_nuevoUser";
            this.btn_nuevoUser.Size = new System.Drawing.Size(136, 28);
            this.btn_nuevoUser.TabIndex = 26;
            this.btn_nuevoUser.Text = "Nuevo usuario";
            this.btn_nuevoUser.UseVisualStyleBackColor = true;
            this.btn_nuevoUser.Click += new System.EventHandler(this.btn_nuevoUser_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(961, 178);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(136, 28);
            this.btn_modificar.TabIndex = 27;
            this.btn_modificar.Text = "Modificar usuario";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_eliminarUser
            // 
            this.btn_eliminarUser.Location = new System.Drawing.Point(961, 235);
            this.btn_eliminarUser.Name = "btn_eliminarUser";
            this.btn_eliminarUser.Size = new System.Drawing.Size(136, 28);
            this.btn_eliminarUser.TabIndex = 28;
            this.btn_eliminarUser.Text = "Eliminar usuario";
            this.btn_eliminarUser.UseVisualStyleBackColor = true;
            this.btn_eliminarUser.Click += new System.EventHandler(this.btn_eliminarUser_Click);
            // 
            // checkActivos
            // 
            this.checkActivos.AutoSize = true;
            this.checkActivos.Location = new System.Drawing.Point(961, 387);
            this.checkActivos.Name = "checkActivos";
            this.checkActivos.Size = new System.Drawing.Size(104, 17);
            this.checkActivos.TabIndex = 29;
            this.checkActivos.Text = "Usuarios activos";
            this.checkActivos.UseVisualStyleBackColor = true;
            this.checkActivos.CheckedChanged += new System.EventHandler(this.checkActivos_CheckedChanged);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(961, 423);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(136, 28);
            this.btn_salir.TabIndex = 30;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // AdministrarUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 524);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.checkActivos);
            this.Controls.Add(this.btn_eliminarUser);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_nuevoUser);
            this.Controls.Add(this.dgv_user);
            this.Name = "AdministrarUsers";
            this.Text = "Vision Management/Administrar usuarios";
            this.Load += new System.EventHandler(this.AdministrarUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_user;
        private System.Windows.Forms.Button btn_nuevoUser;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_eliminarUser;
        private System.Windows.Forms.CheckBox checkActivos;
        private System.Windows.Forms.Button btn_salir;
    }
}