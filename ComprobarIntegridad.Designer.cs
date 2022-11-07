namespace VisionTFI
{
    partial class ComprobarIntegridad
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
            this.components = new System.ComponentModel.Container();
            this.pb_comprobarIntegridad = new System.Windows.Forms.ProgressBar();
            this.lbl_cargar = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pb_comprobarIntegridad
            // 
            this.pb_comprobarIntegridad.Location = new System.Drawing.Point(267, 193);
            this.pb_comprobarIntegridad.Name = "pb_comprobarIntegridad";
            this.pb_comprobarIntegridad.Size = new System.Drawing.Size(260, 23);
            this.pb_comprobarIntegridad.TabIndex = 0;
            // 
            // lbl_cargar
            // 
            this.lbl_cargar.AutoSize = true;
            this.lbl_cargar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cargar.Location = new System.Drawing.Point(286, 172);
            this.lbl_cargar.Name = "lbl_cargar";
            this.lbl_cargar.Size = new System.Drawing.Size(207, 18);
            this.lbl_cargar.TabIndex = 1;
            this.lbl_cargar.Text = "Comprobando Integridad";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ComprobarIntegridad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_cargar);
            this.Controls.Add(this.pb_comprobarIntegridad);
            this.Name = "ComprobarIntegridad";
            this.Text = "Vision Management-ComprobarIntegridad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pb_comprobarIntegridad;
        private System.Windows.Forms.Label lbl_cargar;
        private System.Windows.Forms.Timer timer1;
    }
}