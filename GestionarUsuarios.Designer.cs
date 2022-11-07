namespace VisionTFI
{
    partial class GestionarUsuarios
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
            this.btn_agregaruser = new System.Windows.Forms.Button();
            this.btn_modificaruser = new System.Windows.Forms.Button();
            this.btn_quitaruser = new System.Windows.Forms.Button();
            this.btn_listaruser = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.legajoEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.p1_panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(1244, 24);
            this.menuStrip1.TabIndex = 9;
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
            this.p1_panel1.Size = new System.Drawing.Size(1244, 65);
            this.p1_panel1.TabIndex = 15;
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
            // btn_agregaruser
            // 
            this.btn_agregaruser.Location = new System.Drawing.Point(582, 192);
            this.btn_agregaruser.Name = "btn_agregaruser";
            this.btn_agregaruser.Size = new System.Drawing.Size(125, 23);
            this.btn_agregaruser.TabIndex = 17;
            this.btn_agregaruser.Text = "Agregar usuario";
            this.btn_agregaruser.UseVisualStyleBackColor = true;
            // 
            // btn_modificaruser
            // 
            this.btn_modificaruser.Location = new System.Drawing.Point(582, 231);
            this.btn_modificaruser.Name = "btn_modificaruser";
            this.btn_modificaruser.Size = new System.Drawing.Size(125, 23);
            this.btn_modificaruser.TabIndex = 18;
            this.btn_modificaruser.Text = "Modificar usuario";
            this.btn_modificaruser.UseVisualStyleBackColor = true;
            // 
            // btn_quitaruser
            // 
            this.btn_quitaruser.Location = new System.Drawing.Point(582, 269);
            this.btn_quitaruser.Name = "btn_quitaruser";
            this.btn_quitaruser.Size = new System.Drawing.Size(125, 23);
            this.btn_quitaruser.TabIndex = 19;
            this.btn_quitaruser.Text = "Quitar usuario";
            this.btn_quitaruser.UseVisualStyleBackColor = true;
            // 
            // btn_listaruser
            // 
            this.btn_listaruser.Location = new System.Drawing.Point(582, 307);
            this.btn_listaruser.Name = "btn_listaruser";
            this.btn_listaruser.Size = new System.Drawing.Size(125, 23);
            this.btn_listaruser.TabIndex = 20;
            this.btn_listaruser.Text = "Listar usuario";
            this.btn_listaruser.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUsuario,
            this.legajoEmpleado,
            this.empleado,
            this.nombreUsuario});
            this.dataGridView1.Location = new System.Drawing.Point(0, 192);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(447, 150);
            this.dataGridView1.TabIndex = 21;
            // 
            // idUsuario
            // 
            this.idUsuario.HeaderText = "IdUsuario";
            this.idUsuario.Name = "idUsuario";
            this.idUsuario.ToolTipText = "1";
            // 
            // legajoEmpleado
            // 
            this.legajoEmpleado.HeaderText = "LegajoEmpleado";
            this.legajoEmpleado.Name = "legajoEmpleado";
            // 
            // empleado
            // 
            this.empleado.HeaderText = "Empleado";
            this.empleado.Name = "empleado";
            // 
            // nombreUsuario
            // 
            this.nombreUsuario.HeaderText = "NombreUsuario";
            this.nombreUsuario.Name = "nombreUsuario";
            // 
            // GestionarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_listaruser);
            this.Controls.Add(this.btn_quitaruser);
            this.Controls.Add(this.btn_modificaruser);
            this.Controls.Add(this.btn_agregaruser);
            this.Controls.Add(this.p1_panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "GestionarUsuarios";
            this.Text = "Vision Management/ GestionarUsuarios";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.p1_panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Button btn_agregaruser;
        private System.Windows.Forms.Button btn_modificaruser;
        private System.Windows.Forms.Button btn_quitaruser;
        private System.Windows.Forms.Button btn_listaruser;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn legajoEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreUsuario;
    }
}