namespace VisionTFI
{
    partial class Conexion
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
            this.lbl_servidor = new System.Windows.Forms.Label();
            this.lbl_base = new System.Windows.Forms.Label();
            this.txt_servidor = new System.Windows.Forms.TextBox();
            this.txt_base = new System.Windows.Forms.TextBox();
            this.btn_conectar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_servidor
            // 
            this.lbl_servidor.AutoSize = true;
            this.lbl_servidor.Location = new System.Drawing.Point(57, 54);
            this.lbl_servidor.Name = "lbl_servidor";
            this.lbl_servidor.Size = new System.Drawing.Size(46, 13);
            this.lbl_servidor.TabIndex = 0;
            this.lbl_servidor.Text = "Servidor";
            // 
            // lbl_base
            // 
            this.lbl_base.AutoSize = true;
            this.lbl_base.Location = new System.Drawing.Point(57, 99);
            this.lbl_base.Name = "lbl_base";
            this.lbl_base.Size = new System.Drawing.Size(75, 13);
            this.lbl_base.TabIndex = 1;
            this.lbl_base.Text = "Base de datos";
            // 
            // txt_servidor
            // 
            this.txt_servidor.Location = new System.Drawing.Point(156, 51);
            this.txt_servidor.Name = "txt_servidor";
            this.txt_servidor.Size = new System.Drawing.Size(228, 20);
            this.txt_servidor.TabIndex = 2;
            // 
            // txt_base
            // 
            this.txt_base.Location = new System.Drawing.Point(156, 92);
            this.txt_base.Name = "txt_base";
            this.txt_base.Size = new System.Drawing.Size(228, 20);
            this.txt_base.TabIndex = 3;
            // 
            // btn_conectar
            // 
            this.btn_conectar.Location = new System.Drawing.Point(204, 143);
            this.btn_conectar.Name = "btn_conectar";
            this.btn_conectar.Size = new System.Drawing.Size(129, 23);
            this.btn_conectar.TabIndex = 4;
            this.btn_conectar.Text = "Conectar";
            this.btn_conectar.UseVisualStyleBackColor = true;
            // 
            // Conexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 231);
            this.Controls.Add(this.btn_conectar);
            this.Controls.Add(this.txt_base);
            this.Controls.Add(this.txt_servidor);
            this.Controls.Add(this.lbl_base);
            this.Controls.Add(this.lbl_servidor);
            this.Name = "Conexion";
            this.Text = "Conexion";
            this.Load += new System.EventHandler(this.Conexion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_servidor;
        private System.Windows.Forms.Label lbl_base;
        private System.Windows.Forms.TextBox txt_servidor;
        private System.Windows.Forms.TextBox txt_base;
        private System.Windows.Forms.Button btn_conectar;
    }
}