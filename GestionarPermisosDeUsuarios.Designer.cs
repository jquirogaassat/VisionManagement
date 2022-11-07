namespace VisionTFI
{
    partial class GestionarPermisosDeUsuarios
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
            this.panel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.gb_permisos = new System.Windows.Forms.GroupBox();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lbl_permisosdisponibles = new System.Windows.Forms.Label();
            this.dg_PermisosDisponibles = new System.Windows.Forms.DataGridView();
            this.btn_asignarPermisos = new System.Windows.Forms.Button();
            this.btn_quitarPermiso = new System.Windows.Forms.Button();
            this.dg_PermisosAsignados = new System.Windows.Forms.DataGridView();
            this.lbl_permisosAsignados = new System.Windows.Forms.Label();
            this.lbl_familiasDsiponibles = new System.Windows.Forms.Label();
            this.dg_familiasDisponibles = new System.Windows.Forms.DataGridView();
            this.btn_asignarFamilia = new System.Windows.Forms.Button();
            this.btn_quitarFamilia = new System.Windows.Forms.Button();
            this.dg_familiasAsignadas = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.panel.SuspendLayout();
            this.gb_permisos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_PermisosDisponibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_PermisosAsignados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_familiasDisponibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_familiasAsignadas)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(1207, 24);
            this.menuStrip1.TabIndex = 23;
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
            // panel
            // 
            this.panel.AutoSize = true;
            this.panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel.Controls.Add(this.label2);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 24);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1207, 65);
            this.panel.TabIndex = 24;
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
            // gb_permisos
            // 
            this.gb_permisos.Controls.Add(this.dg_familiasAsignadas);
            this.gb_permisos.Controls.Add(this.btn_quitarFamilia);
            this.gb_permisos.Controls.Add(this.btn_asignarFamilia);
            this.gb_permisos.Controls.Add(this.dg_familiasDisponibles);
            this.gb_permisos.Controls.Add(this.lbl_familiasDsiponibles);
            this.gb_permisos.Controls.Add(this.lbl_permisosAsignados);
            this.gb_permisos.Controls.Add(this.dg_PermisosAsignados);
            this.gb_permisos.Controls.Add(this.btn_quitarPermiso);
            this.gb_permisos.Controls.Add(this.btn_asignarPermisos);
            this.gb_permisos.Controls.Add(this.dg_PermisosDisponibles);
            this.gb_permisos.Controls.Add(this.lbl_permisosdisponibles);
            this.gb_permisos.Controls.Add(this.txt_usuario);
            this.gb_permisos.Controls.Add(this.lbl_usuario);
            this.gb_permisos.Location = new System.Drawing.Point(0, 90);
            this.gb_permisos.Name = "gb_permisos";
            this.gb_permisos.Size = new System.Drawing.Size(1163, 647);
            this.gb_permisos.TabIndex = 25;
            this.gb_permisos.TabStop = false;
            this.gb_permisos.Text = "Gestionar permisos de usuario";
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(108, 25);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(189, 20);
            this.txt_usuario.TabIndex = 1;
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Location = new System.Drawing.Point(6, 28);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(96, 13);
            this.lbl_usuario.TabIndex = 0;
            this.lbl_usuario.Text = "Nombre de usuario";
            // 
            // lbl_permisosdisponibles
            // 
            this.lbl_permisosdisponibles.AutoSize = true;
            this.lbl_permisosdisponibles.Location = new System.Drawing.Point(8, 103);
            this.lbl_permisosdisponibles.Name = "lbl_permisosdisponibles";
            this.lbl_permisosdisponibles.Size = new System.Drawing.Size(104, 13);
            this.lbl_permisosdisponibles.TabIndex = 2;
            this.lbl_permisosdisponibles.Text = "Permisos disponibles";
            // 
            // dg_PermisosDisponibles
            // 
            this.dg_PermisosDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_PermisosDisponibles.Location = new System.Drawing.Point(6, 133);
            this.dg_PermisosDisponibles.Name = "dg_PermisosDisponibles";
            this.dg_PermisosDisponibles.RowHeadersWidth = 62;
            this.dg_PermisosDisponibles.Size = new System.Drawing.Size(341, 145);
            this.dg_PermisosDisponibles.TabIndex = 133;
            // 
            // btn_asignarPermisos
            // 
            this.btn_asignarPermisos.Location = new System.Drawing.Point(466, 152);
            this.btn_asignarPermisos.Name = "btn_asignarPermisos";
            this.btn_asignarPermisos.Size = new System.Drawing.Size(200, 23);
            this.btn_asignarPermisos.TabIndex = 134;
            this.btn_asignarPermisos.Text = "Asignar permiso >";
            this.btn_asignarPermisos.UseVisualStyleBackColor = true;
            // 
            // btn_quitarPermiso
            // 
            this.btn_quitarPermiso.Location = new System.Drawing.Point(466, 209);
            this.btn_quitarPermiso.Name = "btn_quitarPermiso";
            this.btn_quitarPermiso.Size = new System.Drawing.Size(200, 23);
            this.btn_quitarPermiso.TabIndex = 135;
            this.btn_quitarPermiso.Text = "<  Quitar permiso ";
            this.btn_quitarPermiso.UseVisualStyleBackColor = true;
            // 
            // dg_PermisosAsignados
            // 
            this.dg_PermisosAsignados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_PermisosAsignados.Location = new System.Drawing.Point(789, 133);
            this.dg_PermisosAsignados.Name = "dg_PermisosAsignados";
            this.dg_PermisosAsignados.RowHeadersWidth = 62;
            this.dg_PermisosAsignados.Size = new System.Drawing.Size(341, 145);
            this.dg_PermisosAsignados.TabIndex = 136;
            // 
            // lbl_permisosAsignados
            // 
            this.lbl_permisosAsignados.AutoSize = true;
            this.lbl_permisosAsignados.Location = new System.Drawing.Point(786, 103);
            this.lbl_permisosAsignados.Name = "lbl_permisosAsignados";
            this.lbl_permisosAsignados.Size = new System.Drawing.Size(100, 13);
            this.lbl_permisosAsignados.TabIndex = 137;
            this.lbl_permisosAsignados.Text = "Permisos asignados";
            // 
            // lbl_familiasDsiponibles
            // 
            this.lbl_familiasDsiponibles.AutoSize = true;
            this.lbl_familiasDsiponibles.Location = new System.Drawing.Point(6, 336);
            this.lbl_familiasDsiponibles.Name = "lbl_familiasDsiponibles";
            this.lbl_familiasDsiponibles.Size = new System.Drawing.Size(99, 13);
            this.lbl_familiasDsiponibles.TabIndex = 138;
            this.lbl_familiasDsiponibles.Text = "Familias disponibles";
            // 
            // dg_familiasDisponibles
            // 
            this.dg_familiasDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_familiasDisponibles.Location = new System.Drawing.Point(6, 378);
            this.dg_familiasDisponibles.Name = "dg_familiasDisponibles";
            this.dg_familiasDisponibles.RowHeadersWidth = 62;
            this.dg_familiasDisponibles.Size = new System.Drawing.Size(341, 145);
            this.dg_familiasDisponibles.TabIndex = 139;
            // 
            // btn_asignarFamilia
            // 
            this.btn_asignarFamilia.Location = new System.Drawing.Point(466, 399);
            this.btn_asignarFamilia.Name = "btn_asignarFamilia";
            this.btn_asignarFamilia.Size = new System.Drawing.Size(200, 23);
            this.btn_asignarFamilia.TabIndex = 140;
            this.btn_asignarFamilia.Text = "Asignar familia >";
            this.btn_asignarFamilia.UseVisualStyleBackColor = true;
            // 
            // btn_quitarFamilia
            // 
            this.btn_quitarFamilia.Location = new System.Drawing.Point(466, 472);
            this.btn_quitarFamilia.Name = "btn_quitarFamilia";
            this.btn_quitarFamilia.Size = new System.Drawing.Size(200, 23);
            this.btn_quitarFamilia.TabIndex = 141;
            this.btn_quitarFamilia.Text = "<  Quitar familia";
            this.btn_quitarFamilia.UseVisualStyleBackColor = true;
            // 
            // dg_familiasAsignadas
            // 
            this.dg_familiasAsignadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_familiasAsignadas.Location = new System.Drawing.Point(789, 378);
            this.dg_familiasAsignadas.Name = "dg_familiasAsignadas";
            this.dg_familiasAsignadas.RowHeadersWidth = 62;
            this.dg_familiasAsignadas.Size = new System.Drawing.Size(341, 145);
            this.dg_familiasAsignadas.TabIndex = 142;
            // 
            // GestionarPermisosDeUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 749);
            this.Controls.Add(this.gb_permisos);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.menuStrip1);
            this.Name = "GestionarPermisosDeUsuarios";
            this.Text = "Vision Management/ Gestionar Permisos de Usuarios";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel.ResumeLayout(false);
            this.gb_permisos.ResumeLayout(false);
            this.gb_permisos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_PermisosDisponibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_PermisosAsignados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_familiasDisponibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_familiasAsignadas)).EndInit();
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
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gb_permisos;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.DataGridView dg_PermisosDisponibles;
        private System.Windows.Forms.Label lbl_permisosdisponibles;
        private System.Windows.Forms.Button btn_asignarPermisos;
        private System.Windows.Forms.DataGridView dg_familiasDisponibles;
        private System.Windows.Forms.Label lbl_familiasDsiponibles;
        private System.Windows.Forms.Label lbl_permisosAsignados;
        private System.Windows.Forms.DataGridView dg_PermisosAsignados;
        private System.Windows.Forms.Button btn_quitarPermiso;
        private System.Windows.Forms.DataGridView dg_familiasAsignadas;
        private System.Windows.Forms.Button btn_quitarFamilia;
        private System.Windows.Forms.Button btn_asignarFamilia;
    }
}