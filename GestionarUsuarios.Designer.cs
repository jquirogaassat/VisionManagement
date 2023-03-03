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
            this.btn_agregaruser = new System.Windows.Forms.Button();
            this.btn_modificaruser = new System.Windows.Forms.Button();
            this.btn_quitaruser = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.legajoEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(582, 307);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(125, 23);
            this.btn_salir.TabIndex = 20;
            this.btn_salir.Text = "Cancelar";
            this.btn_salir.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_quitaruser);
            this.Controls.Add(this.btn_modificaruser);
            this.Controls.Add(this.btn_agregaruser);
            this.Name = "GestionarUsuarios";
            this.Text = "Vision Management/ GestionarUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_agregaruser;
        private System.Windows.Forms.Button btn_modificaruser;
        private System.Windows.Forms.Button btn_quitaruser;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn legajoEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreUsuario;
    }
}