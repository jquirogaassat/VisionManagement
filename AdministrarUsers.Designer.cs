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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idiomaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.p1_panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_user = new System.Windows.Forms.DataGridView();
            this.btn_nuevoUser = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_eliminarUser = new System.Windows.Forms.Button();
            this.checkActivos = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.p1_panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.seguridadToolStripMenuItem,
            this.idiomaToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.sesionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.seguridadToolStripMenuItem.Text = "Seguridad";
            // 
            // idiomaToolStripMenuItem
            // 
            this.idiomaToolStripMenuItem.Name = "idiomaToolStripMenuItem";
            this.idiomaToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.idiomaToolStripMenuItem.Text = "Idioma";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // sesionToolStripMenuItem
            // 
            this.sesionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambiarUsuarioToolStripMenuItem,
            this.cerrarSesionToolStripMenuItem});
            this.sesionToolStripMenuItem.Name = "sesionToolStripMenuItem";
            this.sesionToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.sesionToolStripMenuItem.Text = "Sesion";
            // 
            // cambiarUsuarioToolStripMenuItem
            // 
            this.cambiarUsuarioToolStripMenuItem.Name = "cambiarUsuarioToolStripMenuItem";
            this.cambiarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.cambiarUsuarioToolStripMenuItem.Text = "Cambiar Usuario";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            // 
            // p1_panel1
            // 
            this.p1_panel1.AutoSize = true;
            this.p1_panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.p1_panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.p1_panel1.Controls.Add(this.label2);
            this.p1_panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.p1_panel1.Location = new System.Drawing.Point(0, 24);
            this.p1_panel1.Name = "p1_panel1";
            this.p1_panel1.Size = new System.Drawing.Size(800, 65);
            this.p1_panel1.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(536, 61);
            this.label2.TabIndex = 2;
            this.label2.Text = "VISION MANAGEMENT";
            // 
            // dgv_user
            // 
            this.dgv_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_user.Location = new System.Drawing.Point(0, 115);
            this.dgv_user.Name = "dgv_user";
            this.dgv_user.Size = new System.Drawing.Size(525, 310);
            this.dgv_user.TabIndex = 25;
            // 
            // btn_nuevoUser
            // 
            this.btn_nuevoUser.Location = new System.Drawing.Point(583, 115);
            this.btn_nuevoUser.Name = "btn_nuevoUser";
            this.btn_nuevoUser.Size = new System.Drawing.Size(136, 28);
            this.btn_nuevoUser.TabIndex = 26;
            this.btn_nuevoUser.Text = "Nuevo usuario";
            this.btn_nuevoUser.UseVisualStyleBackColor = true;
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(583, 168);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(136, 28);
            this.btn_modificar.TabIndex = 27;
            this.btn_modificar.Text = "Modificar usuario";
            this.btn_modificar.UseVisualStyleBackColor = true;
            // 
            // btn_eliminarUser
            // 
            this.btn_eliminarUser.Location = new System.Drawing.Point(583, 225);
            this.btn_eliminarUser.Name = "btn_eliminarUser";
            this.btn_eliminarUser.Size = new System.Drawing.Size(136, 28);
            this.btn_eliminarUser.TabIndex = 28;
            this.btn_eliminarUser.Text = "Eliminar usuario";
            this.btn_eliminarUser.UseVisualStyleBackColor = true;
            // 
            // checkActivos
            // 
            this.checkActivos.AutoSize = true;
            this.checkActivos.Location = new System.Drawing.Point(552, 418);
            this.checkActivos.Name = "checkActivos";
            this.checkActivos.Size = new System.Drawing.Size(104, 17);
            this.checkActivos.TabIndex = 29;
            this.checkActivos.Text = "Usuarios activos";
            this.checkActivos.UseVisualStyleBackColor = true;
            // 
            // AdministrarUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkActivos);
            this.Controls.Add(this.btn_eliminarUser);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_nuevoUser);
            this.Controls.Add(this.dgv_user);
            this.Controls.Add(this.p1_panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "AdministrarUsers";
            this.Text = "Vision Management/Administrar usuarios";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.p1_panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem idiomaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.Panel p1_panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_user;
        private System.Windows.Forms.Button btn_nuevoUser;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_eliminarUser;
        private System.Windows.Forms.CheckBox checkActivos;
    }
}