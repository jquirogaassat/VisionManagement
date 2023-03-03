namespace VisionTFI
{
    partial class Backup
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
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_destino = new System.Windows.Forms.Button();
            this.txt_ruta = new System.Windows.Forms.TextBox();
            this.gb_tamanio = new System.Windows.Forms.GroupBox();
            this.rb_1 = new System.Windows.Forms.RadioButton();
            this.rb_2 = new System.Windows.Forms.RadioButton();
            this.rb_3 = new System.Windows.Forms.RadioButton();
            this.rb_4 = new System.Windows.Forms.RadioButton();
            this.gb_tamanio.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(119, 263);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(91, 36);
            this.btn_guardar.TabIndex = 29;
            this.btn_guardar.Text = "Guardar como";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(264, 263);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(91, 36);
            this.btn_salir.TabIndex = 30;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_destino
            // 
            this.btn_destino.Location = new System.Drawing.Point(12, 201);
            this.btn_destino.Name = "btn_destino";
            this.btn_destino.Size = new System.Drawing.Size(39, 23);
            this.btn_destino.TabIndex = 31;
            this.btn_destino.Text = "...";
            this.btn_destino.UseVisualStyleBackColor = true;
            this.btn_destino.Click += new System.EventHandler(this.btn_destino_Click);
            // 
            // txt_ruta
            // 
            this.txt_ruta.Location = new System.Drawing.Point(71, 204);
            this.txt_ruta.Name = "txt_ruta";
            this.txt_ruta.Size = new System.Drawing.Size(511, 20);
            this.txt_ruta.TabIndex = 32;
            // 
            // gb_tamanio
            // 
            this.gb_tamanio.Controls.Add(this.rb_4);
            this.gb_tamanio.Controls.Add(this.rb_3);
            this.gb_tamanio.Controls.Add(this.rb_2);
            this.gb_tamanio.Controls.Add(this.rb_1);
            this.gb_tamanio.Location = new System.Drawing.Point(12, 48);
            this.gb_tamanio.Name = "gb_tamanio";
            this.gb_tamanio.Size = new System.Drawing.Size(273, 147);
            this.gb_tamanio.TabIndex = 33;
            this.gb_tamanio.TabStop = false;
            this.gb_tamanio.Text = "Seleccione el tamaño";
            // 
            // rb_1
            // 
            this.rb_1.AutoSize = true;
            this.rb_1.Location = new System.Drawing.Point(21, 30);
            this.rb_1.Name = "rb_1";
            this.rb_1.Size = new System.Drawing.Size(31, 17);
            this.rb_1.TabIndex = 0;
            this.rb_1.TabStop = true;
            this.rb_1.Text = "1";
            this.rb_1.UseVisualStyleBackColor = true;
            this.rb_1.CheckedChanged += new System.EventHandler(this.rb_1_CheckedChanged);
            // 
            // rb_2
            // 
            this.rb_2.AutoSize = true;
            this.rb_2.Location = new System.Drawing.Point(21, 53);
            this.rb_2.Name = "rb_2";
            this.rb_2.Size = new System.Drawing.Size(31, 17);
            this.rb_2.TabIndex = 1;
            this.rb_2.TabStop = true;
            this.rb_2.Text = "2";
            this.rb_2.UseVisualStyleBackColor = true;
            this.rb_2.CheckedChanged += new System.EventHandler(this.rb_2_CheckedChanged);
            // 
            // rb_3
            // 
            this.rb_3.AutoSize = true;
            this.rb_3.Location = new System.Drawing.Point(21, 76);
            this.rb_3.Name = "rb_3";
            this.rb_3.Size = new System.Drawing.Size(31, 17);
            this.rb_3.TabIndex = 2;
            this.rb_3.TabStop = true;
            this.rb_3.Text = "3";
            this.rb_3.UseVisualStyleBackColor = true;
            this.rb_3.CheckedChanged += new System.EventHandler(this.rb_3_CheckedChanged);
            // 
            // rb_4
            // 
            this.rb_4.AutoSize = true;
            this.rb_4.Location = new System.Drawing.Point(21, 99);
            this.rb_4.Name = "rb_4";
            this.rb_4.Size = new System.Drawing.Size(31, 17);
            this.rb_4.TabIndex = 3;
            this.rb_4.TabStop = true;
            this.rb_4.Text = "4";
            this.rb_4.UseVisualStyleBackColor = true;
            this.rb_4.CheckedChanged += new System.EventHandler(this.rb_4_CheckedChanged);
            // 
            // Backup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 537);
            this.Controls.Add(this.gb_tamanio);
            this.Controls.Add(this.txt_ruta);
            this.Controls.Add(this.btn_destino);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_guardar);
            this.Name = "Backup";
            this.Text = "Vision Management/ Backup";
            this.gb_tamanio.ResumeLayout(false);
            this.gb_tamanio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_destino;
        private System.Windows.Forms.TextBox txt_ruta;
        private System.Windows.Forms.GroupBox gb_tamanio;
        private System.Windows.Forms.RadioButton rb_4;
        private System.Windows.Forms.RadioButton rb_3;
        private System.Windows.Forms.RadioButton rb_2;
        private System.Windows.Forms.RadioButton rb_1;
    }
}