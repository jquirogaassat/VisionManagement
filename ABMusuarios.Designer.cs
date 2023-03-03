namespace VisionTFI
{
    partial class ABMusuarios
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
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.lbl_usuarios = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.gb_abmusuarios = new System.Windows.Forms.GroupBox();
            this.btn_permisos = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbl_fnacimiento = new System.Windows.Forms.Label();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.lbl_mail = new System.Windows.Forms.Label();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.txt_dni = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.lbl_dni = new System.Windows.Forms.Label();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.gb_abmusuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(25, 82);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_nombre.TabIndex = 17;
            this.lbl_nombre.Text = "Nombre";
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(75, 42);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(200, 20);
            this.txt_usuario.TabIndex = 18;
            // 
            // lbl_usuarios
            // 
            this.lbl_usuarios.AutoSize = true;
            this.lbl_usuarios.Location = new System.Drawing.Point(25, 49);
            this.lbl_usuarios.Name = "lbl_usuarios";
            this.lbl_usuarios.Size = new System.Drawing.Size(43, 13);
            this.lbl_usuarios.TabIndex = 19;
            this.lbl_usuarios.Text = "Usuario";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(75, 79);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(200, 20);
            this.txt_nombre.TabIndex = 20;
            // 
            // gb_abmusuarios
            // 
            this.gb_abmusuarios.Controls.Add(this.btn_permisos);
            this.gb_abmusuarios.Controls.Add(this.btn_salir);
            this.gb_abmusuarios.Controls.Add(this.btn_guardar);
            this.gb_abmusuarios.Controls.Add(this.dateTimePicker1);
            this.gb_abmusuarios.Controls.Add(this.lbl_fnacimiento);
            this.gb_abmusuarios.Controls.Add(this.txt_telefono);
            this.gb_abmusuarios.Controls.Add(this.txt_pass);
            this.gb_abmusuarios.Controls.Add(this.lbl_telefono);
            this.gb_abmusuarios.Controls.Add(this.lbl_pass);
            this.gb_abmusuarios.Controls.Add(this.txt_direccion);
            this.gb_abmusuarios.Controls.Add(this.txt_mail);
            this.gb_abmusuarios.Controls.Add(this.lbl_mail);
            this.gb_abmusuarios.Controls.Add(this.lbl_direccion);
            this.gb_abmusuarios.Controls.Add(this.txt_dni);
            this.gb_abmusuarios.Controls.Add(this.txt_apellido);
            this.gb_abmusuarios.Controls.Add(this.lbl_dni);
            this.gb_abmusuarios.Controls.Add(this.lbl_apellido);
            this.gb_abmusuarios.Controls.Add(this.txt_usuario);
            this.gb_abmusuarios.Controls.Add(this.txt_nombre);
            this.gb_abmusuarios.Controls.Add(this.lbl_nombre);
            this.gb_abmusuarios.Controls.Add(this.lbl_usuarios);
            this.gb_abmusuarios.Location = new System.Drawing.Point(0, 90);
            this.gb_abmusuarios.Name = "gb_abmusuarios";
            this.gb_abmusuarios.Size = new System.Drawing.Size(874, 382);
            this.gb_abmusuarios.TabIndex = 21;
            this.gb_abmusuarios.TabStop = false;
            this.gb_abmusuarios.Text = "Datos del usuario";
            // 
            // btn_permisos
            // 
            this.btn_permisos.Location = new System.Drawing.Point(492, 225);
            this.btn_permisos.Name = "btn_permisos";
            this.btn_permisos.Size = new System.Drawing.Size(180, 23);
            this.btn_permisos.TabIndex = 40;
            this.btn_permisos.Text = "Asignar permisos";
            this.btn_permisos.UseVisualStyleBackColor = true;
            this.btn_permisos.Click += new System.EventHandler(this.btn_permisos_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(611, 163);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 39;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(480, 163);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 38;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(552, 80);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 37;
            // 
            // lbl_fnacimiento
            // 
            this.lbl_fnacimiento.AutoSize = true;
            this.lbl_fnacimiento.Location = new System.Drawing.Point(453, 86);
            this.lbl_fnacimiento.Name = "lbl_fnacimiento";
            this.lbl_fnacimiento.Size = new System.Drawing.Size(93, 13);
            this.lbl_fnacimiento.TabIndex = 36;
            this.lbl_fnacimiento.Text = "Fecha Nacimiento";
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(75, 313);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(200, 20);
            this.txt_telefono.TabIndex = 32;
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(75, 273);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(200, 20);
            this.txt_pass.TabIndex = 30;
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.Location = new System.Drawing.Point(25, 316);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(49, 13);
            this.lbl_telefono.TabIndex = 29;
            this.lbl_telefono.Text = "Telefono";
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Location = new System.Drawing.Point(12, 280);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(61, 13);
            this.lbl_pass.TabIndex = 31;
            this.lbl_pass.Text = "Contraseña";
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(75, 195);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(200, 20);
            this.txt_direccion.TabIndex = 26;
            // 
            // txt_mail
            // 
            this.txt_mail.Location = new System.Drawing.Point(75, 232);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(200, 20);
            this.txt_mail.TabIndex = 28;
            // 
            // lbl_mail
            // 
            this.lbl_mail.AutoSize = true;
            this.lbl_mail.Location = new System.Drawing.Point(25, 235);
            this.lbl_mail.Name = "lbl_mail";
            this.lbl_mail.Size = new System.Drawing.Size(26, 13);
            this.lbl_mail.TabIndex = 25;
            this.lbl_mail.Text = "Mail";
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.Location = new System.Drawing.Point(25, 202);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(52, 13);
            this.lbl_direccion.TabIndex = 27;
            this.lbl_direccion.Text = "Direccion";
            // 
            // txt_dni
            // 
            this.txt_dni.Location = new System.Drawing.Point(75, 160);
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.Size = new System.Drawing.Size(200, 20);
            this.txt_dni.TabIndex = 24;
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(75, 120);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(200, 20);
            this.txt_apellido.TabIndex = 22;
            // 
            // lbl_dni
            // 
            this.lbl_dni.AutoSize = true;
            this.lbl_dni.Location = new System.Drawing.Point(25, 163);
            this.lbl_dni.Name = "lbl_dni";
            this.lbl_dni.Size = new System.Drawing.Size(26, 13);
            this.lbl_dni.TabIndex = 21;
            this.lbl_dni.Text = "DNI";
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Location = new System.Drawing.Point(24, 123);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(44, 13);
            this.lbl_apellido.TabIndex = 23;
            this.lbl_apellido.Text = "Apellido";
            // 
            // ABMusuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 512);
            this.Controls.Add(this.gb_abmusuarios);
            this.Name = "ABMusuarios";
            this.Text = "Vision Management/ ABM usuarios";
            this.Load += new System.EventHandler(this.ABMusuarios_Load);
            this.gb_abmusuarios.ResumeLayout(false);
            this.gb_abmusuarios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Label lbl_usuarios;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.GroupBox gb_abmusuarios;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.Label lbl_mail;
        private System.Windows.Forms.Label lbl_direccion;
        private System.Windows.Forms.TextBox txt_dni;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.Label lbl_dni;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.Button btn_permisos;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbl_fnacimiento;
    }
}