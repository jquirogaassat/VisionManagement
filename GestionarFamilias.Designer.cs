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
            this.grpPatentes = new System.Windows.Forms.GroupBox();
            this.btn_addPatente = new System.Windows.Forms.Button();
            this.cmb_patentes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_GuardarPermiso = new System.Windows.Forms.Button();
            this.txtNombrePatente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_permisos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_seleccionar = new System.Windows.Forms.Button();
            this.btn_agregarFamilia = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_guardarFamilia = new System.Windows.Forms.Button();
            this.txtNombreFamilia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_familias = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.treeConfigurarFamilia = new System.Windows.Forms.TreeView();
            this.btn_salir = new System.Windows.Forms.Button();
            this.grpPatentes.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPatentes
            // 
            this.grpPatentes.Controls.Add(this.btn_addPatente);
            this.grpPatentes.Controls.Add(this.cmb_patentes);
            this.grpPatentes.Controls.Add(this.label2);
            this.grpPatentes.Controls.Add(this.groupBox1);
            this.grpPatentes.Location = new System.Drawing.Point(11, 78);
            this.grpPatentes.Margin = new System.Windows.Forms.Padding(2);
            this.grpPatentes.Name = "grpPatentes";
            this.grpPatentes.Padding = new System.Windows.Forms.Padding(2);
            this.grpPatentes.Size = new System.Drawing.Size(256, 249);
            this.grpPatentes.TabIndex = 5;
            this.grpPatentes.TabStop = false;
            this.grpPatentes.Text = "Patentes";
            // 
            // btn_addPatente
            // 
            this.btn_addPatente.Location = new System.Drawing.Point(13, 63);
            this.btn_addPatente.Margin = new System.Windows.Forms.Padding(2);
            this.btn_addPatente.Name = "btn_addPatente";
            this.btn_addPatente.Size = new System.Drawing.Size(98, 19);
            this.btn_addPatente.TabIndex = 8;
            this.btn_addPatente.Text = "Agregar >> ";
            this.btn_addPatente.UseVisualStyleBackColor = true;
            this.btn_addPatente.Click += new System.EventHandler(this.btn_addPatente_Click);
            // 
            // cmb_patentes
            // 
            this.cmb_patentes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_patentes.FormattingEnabled = true;
            this.cmb_patentes.Location = new System.Drawing.Point(11, 39);
            this.cmb_patentes.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_patentes.Name = "cmb_patentes";
            this.cmb_patentes.Size = new System.Drawing.Size(234, 21);
            this.cmb_patentes.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Todas las patentes";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_GuardarPermiso);
            this.groupBox1.Controls.Add(this.txtNombrePatente);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmb_permisos);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 99);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(232, 138);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nueva";
            // 
            // btn_GuardarPermiso
            // 
            this.btn_GuardarPermiso.Location = new System.Drawing.Point(16, 108);
            this.btn_GuardarPermiso.Margin = new System.Windows.Forms.Padding(2);
            this.btn_GuardarPermiso.Name = "btn_GuardarPermiso";
            this.btn_GuardarPermiso.Size = new System.Drawing.Size(56, 19);
            this.btn_GuardarPermiso.TabIndex = 4;
            this.btn_GuardarPermiso.Text = "Guardar";
            this.btn_GuardarPermiso.UseVisualStyleBackColor = true;
            this.btn_GuardarPermiso.Click += new System.EventHandler(this.btn_GuardarPermiso_Click);
            // 
            // txtNombrePatente
            // 
            this.txtNombrePatente.Location = new System.Drawing.Point(16, 84);
            this.txtNombrePatente.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombrePatente.Name = "txtNombrePatente";
            this.txtNombrePatente.Size = new System.Drawing.Size(174, 20);
            this.txtNombrePatente.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            // 
            // cmb_permisos
            // 
            this.cmb_permisos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_permisos.FormattingEnabled = true;
            this.cmb_permisos.Location = new System.Drawing.Point(17, 35);
            this.cmb_permisos.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_permisos.Name = "cmb_permisos";
            this.cmb_permisos.Size = new System.Drawing.Size(174, 21);
            this.cmb_permisos.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Permiso";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_seleccionar);
            this.groupBox2.Controls.Add(this.btn_agregarFamilia);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.cmb_familias);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(317, 78);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(258, 249);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Familias";
            // 
            // btn_seleccionar
            // 
            this.btn_seleccionar.Location = new System.Drawing.Point(14, 63);
            this.btn_seleccionar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_seleccionar.Name = "btn_seleccionar";
            this.btn_seleccionar.Size = new System.Drawing.Size(98, 19);
            this.btn_seleccionar.TabIndex = 11;
            this.btn_seleccionar.Text = "Configurar";
            this.btn_seleccionar.UseVisualStyleBackColor = true;
            this.btn_seleccionar.Click += new System.EventHandler(this.btn_seleccionar_Click);
            // 
            // btn_agregarFamilia
            // 
            this.btn_agregarFamilia.Location = new System.Drawing.Point(117, 63);
            this.btn_agregarFamilia.Margin = new System.Windows.Forms.Padding(2);
            this.btn_agregarFamilia.Name = "btn_agregarFamilia";
            this.btn_agregarFamilia.Size = new System.Drawing.Size(98, 19);
            this.btn_agregarFamilia.TabIndex = 10;
            this.btn_agregarFamilia.Text = "Agregar >> ";
            this.btn_agregarFamilia.UseVisualStyleBackColor = true;
            this.btn_agregarFamilia.Click += new System.EventHandler(this.btn_agregarFamilia_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_guardarFamilia);
            this.groupBox3.Controls.Add(this.txtNombreFamilia);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(15, 99);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(232, 93);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nueva";
            // 
            // btn_guardarFamilia
            // 
            this.btn_guardarFamilia.Location = new System.Drawing.Point(11, 61);
            this.btn_guardarFamilia.Margin = new System.Windows.Forms.Padding(2);
            this.btn_guardarFamilia.Name = "btn_guardarFamilia";
            this.btn_guardarFamilia.Size = new System.Drawing.Size(56, 19);
            this.btn_guardarFamilia.TabIndex = 4;
            this.btn_guardarFamilia.Text = "Guardar";
            this.btn_guardarFamilia.UseVisualStyleBackColor = true;
            this.btn_guardarFamilia.Click += new System.EventHandler(this.btn_guardarFamilia_Click);
            // 
            // txtNombreFamilia
            // 
            this.txtNombreFamilia.Location = new System.Drawing.Point(11, 37);
            this.txtNombreFamilia.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreFamilia.Name = "txtNombreFamilia";
            this.txtNombreFamilia.Size = new System.Drawing.Size(174, 20);
            this.txtNombreFamilia.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nombre";
            // 
            // cmb_familias
            // 
            this.cmb_familias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_familias.FormattingEnabled = true;
            this.cmb_familias.Location = new System.Drawing.Point(15, 39);
            this.cmb_familias.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_familias.Name = "cmb_familias";
            this.cmb_familias.Size = new System.Drawing.Size(234, 21);
            this.cmb_familias.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Todas las familias";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_guardar);
            this.groupBox4.Controls.Add(this.treeConfigurarFamilia);
            this.groupBox4.Location = new System.Drawing.Point(622, 78);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(290, 249);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Configurar Familia";
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(11, 219);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(110, 19);
            this.btn_guardar.TabIndex = 1;
            this.btn_guardar.Text = "Guardar familia";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // treeConfigurarFamilia
            // 
            this.treeConfigurarFamilia.Location = new System.Drawing.Point(11, 23);
            this.treeConfigurarFamilia.Margin = new System.Windows.Forms.Padding(2);
            this.treeConfigurarFamilia.Name = "treeConfigurarFamilia";
            this.treeConfigurarFamilia.Size = new System.Drawing.Size(262, 192);
            this.treeConfigurarFamilia.TabIndex = 0;
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(997, 344);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 8;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // GestionarFamilias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 450);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpPatentes);
            this.Name = "GestionarFamilias";
            this.Text = "Vision Management-Configuracion de seguridad";
            this.Load += new System.EventHandler(this.GestionarFamilias_Load);
            this.grpPatentes.ResumeLayout(false);
            this.grpPatentes.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPatentes;
        private System.Windows.Forms.Button btn_addPatente;
        private System.Windows.Forms.ComboBox cmb_patentes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_GuardarPermiso;
        private System.Windows.Forms.TextBox txtNombrePatente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_permisos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_seleccionar;
        private System.Windows.Forms.Button btn_agregarFamilia;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_guardarFamilia;
        private System.Windows.Forms.TextBox txtNombreFamilia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_familias;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.TreeView treeConfigurarFamilia;
        private System.Windows.Forms.Button btn_salir;
    }
}