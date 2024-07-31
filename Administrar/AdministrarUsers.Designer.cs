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
            this.checkActivos = new System.Windows.Forms.CheckBox();
            this.btn_salirAdministrarUsuarios = new System.Windows.Forms.Button();
            this.btn_updateUsuario = new System.Windows.Forms.Button();
            this.btn_deleteUsuario = new System.Windows.Forms.Button();
            this.btn_desbloquearUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_user
            // 
            this.dgv_user.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_user.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_user.Location = new System.Drawing.Point(25, 86);
            this.dgv_user.Name = "dgv_user";
            this.dgv_user.Size = new System.Drawing.Size(953, 426);
            this.dgv_user.TabIndex = 25;
            this.dgv_user.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_user_CellContentClick);
            // 
            // btn_nuevoUser
            // 
            this.btn_nuevoUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevoUser.Location = new System.Drawing.Point(1018, 97);
            this.btn_nuevoUser.Name = "btn_nuevoUser";
            this.btn_nuevoUser.Size = new System.Drawing.Size(114, 28);
            this.btn_nuevoUser.TabIndex = 26;
            this.btn_nuevoUser.Text = "Nuevo usuario";
            this.btn_nuevoUser.UseVisualStyleBackColor = true;
            this.btn_nuevoUser.Click += new System.EventHandler(this.btn_nuevoUser_Click);
            // 
            // checkActivos
            // 
            this.checkActivos.AutoSize = true;
            this.checkActivos.Location = new System.Drawing.Point(1018, 359);
            this.checkActivos.Name = "checkActivos";
            this.checkActivos.Size = new System.Drawing.Size(104, 17);
            this.checkActivos.TabIndex = 29;
            this.checkActivos.Text = "Usuarios activos";
            this.checkActivos.UseVisualStyleBackColor = true;
            this.checkActivos.CheckedChanged += new System.EventHandler(this.checkActivos_CheckedChanged);
            // 
            // btn_salirAdministrarUsuarios
            // 
            this.btn_salirAdministrarUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salirAdministrarUsuarios.Location = new System.Drawing.Point(1018, 395);
            this.btn_salirAdministrarUsuarios.Name = "btn_salirAdministrarUsuarios";
            this.btn_salirAdministrarUsuarios.Size = new System.Drawing.Size(114, 28);
            this.btn_salirAdministrarUsuarios.TabIndex = 30;
            this.btn_salirAdministrarUsuarios.Text = "Salir";
            this.btn_salirAdministrarUsuarios.UseVisualStyleBackColor = true;
            this.btn_salirAdministrarUsuarios.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_updateUsuario
            // 
            this.btn_updateUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updateUsuario.Location = new System.Drawing.Point(1018, 168);
            this.btn_updateUsuario.Name = "btn_updateUsuario";
            this.btn_updateUsuario.Size = new System.Drawing.Size(114, 28);
            this.btn_updateUsuario.TabIndex = 31;
            this.btn_updateUsuario.Text = "Modificar usuario";
            this.btn_updateUsuario.UseVisualStyleBackColor = true;
            // 
            // btn_deleteUsuario
            // 
            this.btn_deleteUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteUsuario.Location = new System.Drawing.Point(1018, 243);
            this.btn_deleteUsuario.Name = "btn_deleteUsuario";
            this.btn_deleteUsuario.Size = new System.Drawing.Size(114, 28);
            this.btn_deleteUsuario.TabIndex = 32;
            this.btn_deleteUsuario.Text = "Eliminar usuario";
            this.btn_deleteUsuario.UseVisualStyleBackColor = true;
            this.btn_deleteUsuario.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_desbloquearUser
            // 
            this.btn_desbloquearUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_desbloquearUser.Location = new System.Drawing.Point(1018, 309);
            this.btn_desbloquearUser.Name = "btn_desbloquearUser";
            this.btn_desbloquearUser.Size = new System.Drawing.Size(114, 28);
            this.btn_desbloquearUser.TabIndex = 33;
            this.btn_desbloquearUser.Text = "Desbloquear usuario";
            this.btn_desbloquearUser.UseVisualStyleBackColor = true;
            this.btn_desbloquearUser.Click += new System.EventHandler(this.btn_desbloquearUser_Click);
            // 
            // AdministrarUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 524);
            this.Controls.Add(this.btn_desbloquearUser);
            this.Controls.Add(this.btn_deleteUsuario);
            this.Controls.Add(this.btn_updateUsuario);
            this.Controls.Add(this.btn_salirAdministrarUsuarios);
            this.Controls.Add(this.checkActivos);
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
        private System.Windows.Forms.CheckBox checkActivos;
        private System.Windows.Forms.Button btn_salirAdministrarUsuarios;
        private System.Windows.Forms.Button btn_updateUsuario;
        private System.Windows.Forms.Button btn_deleteUsuario;
        private System.Windows.Forms.Button btn_desbloquearUser;
    }
}