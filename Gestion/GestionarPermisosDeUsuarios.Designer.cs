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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grpPatentes = new System.Windows.Forms.GroupBox();
            this.btn_agregarFamilias = new System.Windows.Forms.Button();
            this.cboFamilias = new System.Windows.Forms.ComboBox();
            this.lbl_agregarFamilias = new System.Windows.Forms.Label();
            this.btn_agregarPatentes = new System.Windows.Forms.Button();
            this.cboPatentes = new System.Windows.Forms.ComboBox();
            this.lbl_agregarPatentes = new System.Windows.Forms.Label();
            this.cmdConfigurar = new System.Windows.Forms.Button();
            this.cboUsuarios = new System.Windows.Forms.ComboBox();
            this.lbl_todosUsuarios = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btn_guardarPermisos = new System.Windows.Forms.Button();
            this.btn_salirGestionarPermisos = new System.Windows.Forms.Button();
            this.grpPatentes.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPatentes
            // 
            this.grpPatentes.Controls.Add(this.btn_agregarFamilias);
            this.grpPatentes.Controls.Add(this.cboFamilias);
            this.grpPatentes.Controls.Add(this.lbl_agregarFamilias);
            this.grpPatentes.Controls.Add(this.btn_agregarPatentes);
            this.grpPatentes.Controls.Add(this.cboPatentes);
            this.grpPatentes.Controls.Add(this.lbl_agregarPatentes);
            this.grpPatentes.Controls.Add(this.cmdConfigurar);
            this.grpPatentes.Controls.Add(this.cboUsuarios);
            this.grpPatentes.Controls.Add(this.lbl_todosUsuarios);
            this.grpPatentes.Location = new System.Drawing.Point(11, 67);
            this.grpPatentes.Margin = new System.Windows.Forms.Padding(2);
            this.grpPatentes.Name = "grpPatentes";
            this.grpPatentes.Padding = new System.Windows.Forms.Padding(2);
            this.grpPatentes.Size = new System.Drawing.Size(288, 303);
            this.grpPatentes.TabIndex = 6;
            this.grpPatentes.TabStop = false;
            this.grpPatentes.Text = "Usuarios";
            // 
            // btn_agregarFamilias
            // 
            this.btn_agregarFamilias.Location = new System.Drawing.Point(11, 219);
            this.btn_agregarFamilias.Margin = new System.Windows.Forms.Padding(2);
            this.btn_agregarFamilias.Name = "btn_agregarFamilias";
            this.btn_agregarFamilias.Size = new System.Drawing.Size(83, 19);
            this.btn_agregarFamilias.TabIndex = 13;
            this.btn_agregarFamilias.Text = "Agregar >>";
            this.btn_agregarFamilias.UseVisualStyleBackColor = true;
            this.btn_agregarFamilias.Click += new System.EventHandler(this.btn_agregarFamilias_Click);
            // 
            // cboFamilias
            // 
            this.cboFamilias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFamilias.FormattingEnabled = true;
            this.cboFamilias.Location = new System.Drawing.Point(11, 194);
            this.cboFamilias.Margin = new System.Windows.Forms.Padding(2);
            this.cboFamilias.Name = "cboFamilias";
            this.cboFamilias.Size = new System.Drawing.Size(234, 21);
            this.cboFamilias.TabIndex = 12;
            // 
            // lbl_agregarFamilias
            // 
            this.lbl_agregarFamilias.AutoSize = true;
            this.lbl_agregarFamilias.Location = new System.Drawing.Point(9, 178);
            this.lbl_agregarFamilias.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_agregarFamilias.Name = "lbl_agregarFamilias";
            this.lbl_agregarFamilias.Size = new System.Drawing.Size(84, 13);
            this.lbl_agregarFamilias.TabIndex = 11;
            this.lbl_agregarFamilias.Text = "Agregar Familias";
            // 
            // btn_agregarPatentes
            // 
            this.btn_agregarPatentes.Location = new System.Drawing.Point(11, 151);
            this.btn_agregarPatentes.Margin = new System.Windows.Forms.Padding(2);
            this.btn_agregarPatentes.Name = "btn_agregarPatentes";
            this.btn_agregarPatentes.Size = new System.Drawing.Size(83, 19);
            this.btn_agregarPatentes.TabIndex = 10;
            this.btn_agregarPatentes.Text = "Agregar >>";
            this.btn_agregarPatentes.UseVisualStyleBackColor = true;
            this.btn_agregarPatentes.Click += new System.EventHandler(this.btn_agregarPatentes_Click);
            // 
            // cboPatentes
            // 
            this.cboPatentes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPatentes.FormattingEnabled = true;
            this.cboPatentes.Location = new System.Drawing.Point(11, 127);
            this.cboPatentes.Margin = new System.Windows.Forms.Padding(2);
            this.cboPatentes.Name = "cboPatentes";
            this.cboPatentes.Size = new System.Drawing.Size(234, 21);
            this.cboPatentes.TabIndex = 9;
            // 
            // lbl_agregarPatentes
            // 
            this.lbl_agregarPatentes.AutoSize = true;
            this.lbl_agregarPatentes.Location = new System.Drawing.Point(9, 110);
            this.lbl_agregarPatentes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_agregarPatentes.Name = "lbl_agregarPatentes";
            this.lbl_agregarPatentes.Size = new System.Drawing.Size(88, 13);
            this.lbl_agregarPatentes.TabIndex = 8;
            this.lbl_agregarPatentes.Text = "Agregar patentes";
            // 
            // cmdConfigurar
            // 
            this.cmdConfigurar.Location = new System.Drawing.Point(11, 63);
            this.cmdConfigurar.Margin = new System.Windows.Forms.Padding(2);
            this.cmdConfigurar.Name = "cmdConfigurar";
            this.cmdConfigurar.Size = new System.Drawing.Size(83, 19);
            this.cmdConfigurar.TabIndex = 7;
            this.cmdConfigurar.Text = "Configurar";
            this.cmdConfigurar.UseVisualStyleBackColor = true;
            this.cmdConfigurar.Click += new System.EventHandler(this.cmdConfigurar_Click_1);
            // 
            // cboUsuarios
            // 
            this.cboUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUsuarios.FormattingEnabled = true;
            this.cboUsuarios.Location = new System.Drawing.Point(11, 39);
            this.cboUsuarios.Margin = new System.Windows.Forms.Padding(2);
            this.cboUsuarios.Name = "cboUsuarios";
            this.cboUsuarios.Size = new System.Drawing.Size(234, 21);
            this.cboUsuarios.TabIndex = 6;
            // 
            // lbl_todosUsuarios
            // 
            this.lbl_todosUsuarios.AutoSize = true;
            this.lbl_todosUsuarios.Location = new System.Drawing.Point(9, 23);
            this.lbl_todosUsuarios.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_todosUsuarios.Name = "lbl_todosUsuarios";
            this.lbl_todosUsuarios.Size = new System.Drawing.Size(95, 13);
            this.lbl_todosUsuarios.TabIndex = 5;
            this.lbl_todosUsuarios.Text = "Todos los usuarios";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(336, 69);
            this.treeView1.Margin = new System.Windows.Forms.Padding(2);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(325, 301);
            this.treeView1.TabIndex = 7;
            // 
            // btn_guardarPermisos
            // 
            this.btn_guardarPermisos.Location = new System.Drawing.Point(678, 351);
            this.btn_guardarPermisos.Margin = new System.Windows.Forms.Padding(2);
            this.btn_guardarPermisos.Name = "btn_guardarPermisos";
            this.btn_guardarPermisos.Size = new System.Drawing.Size(110, 19);
            this.btn_guardarPermisos.TabIndex = 8;
            this.btn_guardarPermisos.Text = "Guardar cambios";
            this.btn_guardarPermisos.UseVisualStyleBackColor = true;
            this.btn_guardarPermisos.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_salirGestionarPermisos
            // 
            this.btn_salirGestionarPermisos.Location = new System.Drawing.Point(808, 351);
            this.btn_salirGestionarPermisos.Margin = new System.Windows.Forms.Padding(2);
            this.btn_salirGestionarPermisos.Name = "btn_salirGestionarPermisos";
            this.btn_salirGestionarPermisos.Size = new System.Drawing.Size(110, 19);
            this.btn_salirGestionarPermisos.TabIndex = 9;
            this.btn_salirGestionarPermisos.Text = "Salir";
            this.btn_salirGestionarPermisos.UseVisualStyleBackColor = true;
            this.btn_salirGestionarPermisos.Click += new System.EventHandler(this.btn_salirGestionarPermisos_Click);
            // 
            // GestionarPermisosDeUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 749);
            this.Controls.Add(this.btn_salirGestionarPermisos);
            this.Controls.Add(this.btn_guardarPermisos);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.grpPatentes);
            this.Name = "GestionarPermisosDeUsuarios";
            this.Text = "Vision Management/ Gestionar Permisos de Usuarios";
            this.grpPatentes.ResumeLayout(false);
            this.grpPatentes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grpPatentes;
        private System.Windows.Forms.Button btn_agregarFamilias;
        private System.Windows.Forms.ComboBox cboFamilias;
        private System.Windows.Forms.Label lbl_agregarFamilias;
        private System.Windows.Forms.Button btn_agregarPatentes;
        private System.Windows.Forms.ComboBox cboPatentes;
        private System.Windows.Forms.Label lbl_agregarPatentes;
        private System.Windows.Forms.Button cmdConfigurar;
        private System.Windows.Forms.ComboBox cboUsuarios;
        private System.Windows.Forms.Label lbl_todosUsuarios;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btn_guardarPermisos;
        private System.Windows.Forms.Button btn_salirGestionarPermisos;
    }
}