namespace VisionTFI
{
    partial class GestionarFamilias
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
            this.p1_panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idiomaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dg_gestionarFamilias = new System.Windows.Forms.DataGridView();
            this.idfamilia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_nuevaflia = new System.Windows.Forms.Button();
            this.bt_modificarflia = new System.Windows.Forms.Button();
            this.btn_eliminarflia = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.p1_panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_gestionarFamilias)).BeginInit();
            this.SuspendLayout();
            // 
            // p1_panel1
            // 
            this.p1_panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.p1_panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.p1_panel1.Controls.Add(this.label2);
            this.p1_panel1.Location = new System.Drawing.Point(0, 27);
            this.p1_panel1.Name = "p1_panel1";
            this.p1_panel1.Size = new System.Drawing.Size(800, 71);
            this.p1_panel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(442, 61);
            this.label2.TabIndex = 2;
            this.label2.Text = "VISION MANAGEMENT";
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
            this.menuStrip1.TabIndex = 7;
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
            this.cambiarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cambiarUsuarioToolStripMenuItem.Text = "Cambiar Usuario";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            // 
            // dg_gestionarFamilias
            // 
            this.dg_gestionarFamilias.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dg_gestionarFamilias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_gestionarFamilias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idfamilia,
            this.familia});
            this.dg_gestionarFamilias.Location = new System.Drawing.Point(0, 145);
            this.dg_gestionarFamilias.Name = "dg_gestionarFamilias";
            this.dg_gestionarFamilias.Size = new System.Drawing.Size(243, 148);
            this.dg_gestionarFamilias.TabIndex = 15;
            // 
            // idfamilia
            // 
            this.idfamilia.HeaderText = "id_familia";
            this.idfamilia.Name = "idfamilia";
            // 
            // familia
            // 
            this.familia.HeaderText = "familia";
            this.familia.Name = "familia";
            // 
            // btn_nuevaflia
            // 
            this.btn_nuevaflia.Location = new System.Drawing.Point(325, 145);
            this.btn_nuevaflia.Name = "btn_nuevaflia";
            this.btn_nuevaflia.Size = new System.Drawing.Size(94, 23);
            this.btn_nuevaflia.TabIndex = 16;
            this.btn_nuevaflia.Text = "Nueva familia";
            this.btn_nuevaflia.UseVisualStyleBackColor = true;
            // 
            // bt_modificarflia
            // 
            this.bt_modificarflia.Location = new System.Drawing.Point(325, 207);
            this.bt_modificarflia.Name = "bt_modificarflia";
            this.bt_modificarflia.Size = new System.Drawing.Size(94, 23);
            this.bt_modificarflia.TabIndex = 17;
            this.bt_modificarflia.Text = "Modifica familia";
            this.bt_modificarflia.UseVisualStyleBackColor = true;
            // 
            // btn_eliminarflia
            // 
            this.btn_eliminarflia.Location = new System.Drawing.Point(325, 270);
            this.btn_eliminarflia.Name = "btn_eliminarflia";
            this.btn_eliminarflia.Size = new System.Drawing.Size(94, 23);
            this.btn_eliminarflia.TabIndex = 18;
            this.btn_eliminarflia.Text = "Elminar familia";
            this.btn_eliminarflia.UseVisualStyleBackColor = true;
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(325, 330);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(94, 23);
            this.btn_salir.TabIndex = 19;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            // 
            // GestionarFamilias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_eliminarflia);
            this.Controls.Add(this.bt_modificarflia);
            this.Controls.Add(this.btn_nuevaflia);
            this.Controls.Add(this.dg_gestionarFamilias);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.p1_panel1);
            this.Name = "GestionarFamilias";
            this.Text = "Vision Management-GestionarFamilias";
            this.p1_panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_gestionarFamilias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel p1_panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem idiomaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.DataGridView dg_gestionarFamilias;
        private System.Windows.Forms.DataGridViewTextBoxColumn idfamilia;
        private System.Windows.Forms.DataGridViewTextBoxColumn familia;
        private System.Windows.Forms.Button btn_nuevaflia;
        private System.Windows.Forms.Button bt_modificarflia;
        private System.Windows.Forms.Button btn_eliminarflia;
        private System.Windows.Forms.Button btn_salir;
    }
}