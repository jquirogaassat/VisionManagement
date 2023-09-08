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
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            this.btn_nuevoUser.Location = new System.Drawing.Point(1018, 97);
            this.btn_nuevoUser.Name = "btn_nuevoUser";
            this.btn_nuevoUser.Size = new System.Drawing.Size(136, 28);
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
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(1018, 395);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(136, 28);
            this.btn_salir.TabIndex = 30;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(1018, 168);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(136, 28);
            this.btn_update.TabIndex = 31;
            this.btn_update.Text = "Modificar usuario";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1018, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 28);
            this.button1.TabIndex = 32;
            this.button1.Text = "Eliminar usuario";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdministrarUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 524);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_salir);
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
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button button1;
    }
}