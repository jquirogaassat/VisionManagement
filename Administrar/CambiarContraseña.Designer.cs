namespace VisionTFI
{
    partial class CambiarContraseña
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CambiarContraseña));
            this.panel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_contraseña = new System.Windows.Forms.Label();
            this.txt_contraseñaActual = new System.Windows.Forms.TextBox();
            this.txt_confirmarContraseña = new System.Windows.Forms.TextBox();
            this.lbl_confirmarContraseña = new System.Windows.Forms.Label();
            this.txt_contraseñaNueva = new System.Windows.Forms.TextBox();
            this.lbl_contraseñaNueva = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            resources.ApplyResources(this.panel, "panel");
            this.panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel.Controls.Add(this.label2);
            this.panel.Name = "panel";
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // lbl_contraseña
            // 
            resources.ApplyResources(this.lbl_contraseña, "lbl_contraseña");
            this.lbl_contraseña.Name = "lbl_contraseña";
            // 
            // txt_contraseñaActual
            // 
            resources.ApplyResources(this.txt_contraseñaActual, "txt_contraseñaActual");
            this.txt_contraseñaActual.Name = "txt_contraseñaActual";
            // 
            // txt_confirmarContraseña
            // 
            resources.ApplyResources(this.txt_confirmarContraseña, "txt_confirmarContraseña");
            this.txt_confirmarContraseña.Name = "txt_confirmarContraseña";
            // 
            // lbl_confirmarContraseña
            // 
            resources.ApplyResources(this.lbl_confirmarContraseña, "lbl_confirmarContraseña");
            this.lbl_confirmarContraseña.Name = "lbl_confirmarContraseña";
            // 
            // txt_contraseñaNueva
            // 
            resources.ApplyResources(this.txt_contraseñaNueva, "txt_contraseñaNueva");
            this.txt_contraseñaNueva.Name = "txt_contraseñaNueva";
            // 
            // lbl_contraseñaNueva
            // 
            resources.ApplyResources(this.lbl_contraseñaNueva, "lbl_contraseñaNueva");
            this.lbl_contraseñaNueva.Name = "lbl_contraseñaNueva";
            // 
            // btn_guardar
            // 
            resources.ApplyResources(this.btn_guardar, "btn_guardar");
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_salir
            // 
            resources.ApplyResources(this.btn_salir, "btn_salir");
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // CambiarContraseña
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.txt_contraseñaNueva);
            this.Controls.Add(this.lbl_contraseñaNueva);
            this.Controls.Add(this.txt_confirmarContraseña);
            this.Controls.Add(this.lbl_confirmarContraseña);
            this.Controls.Add(this.txt_contraseñaActual);
            this.Controls.Add(this.lbl_contraseña);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CambiarContraseña";
            this.Load += new System.EventHandler(this.CambiarContraseña_Load);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_contraseña;
        private System.Windows.Forms.TextBox txt_contraseñaActual;
        private System.Windows.Forms.TextBox txt_confirmarContraseña;
        private System.Windows.Forms.Label lbl_confirmarContraseña;
        private System.Windows.Forms.TextBox txt_contraseñaNueva;
        private System.Windows.Forms.Label lbl_contraseñaNueva;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_salir;
    }
}