namespace VisionTFI
{
    partial class IniciarSistema
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
            this.p1_panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pb_iniciarSistema = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lbl_cargar = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.p1_panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // p1_panel1
            // 
            this.p1_panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.p1_panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.p1_panel1.Controls.Add(this.label2);
            this.p1_panel1.Location = new System.Drawing.Point(0, -1);
            this.p1_panel1.Name = "p1_panel1";
            this.p1_panel1.Size = new System.Drawing.Size(800, 83);
            this.p1_panel1.TabIndex = 4;
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
            // pb_iniciarSistema
            // 
            this.pb_iniciarSistema.Location = new System.Drawing.Point(293, 210);
            this.pb_iniciarSistema.Name = "pb_iniciarSistema";
            this.pb_iniciarSistema.Size = new System.Drawing.Size(179, 23);
            this.pb_iniciarSistema.TabIndex = 5;
            this.pb_iniciarSistema.Click += new System.EventHandler(this.pb_iniciarSistema_Click);
            // 
            // lbl_cargar
            // 
            this.lbl_cargar.AutoSize = true;
            this.lbl_cargar.Location = new System.Drawing.Point(343, 194);
            this.lbl_cargar.Name = "lbl_cargar";
            this.lbl_cargar.Size = new System.Drawing.Size(68, 13);
            this.lbl_cargar.TabIndex = 6;
            this.lbl_cargar.Text = "CARGANDO";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // IniciarSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_cargar);
            this.Controls.Add(this.pb_iniciarSistema);
            this.Controls.Add(this.p1_panel1);
            this.Name = "IniciarSistema";
            this.Text = "Vision Management/ Iniciar Sistema";
            this.p1_panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel p1_panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar pb_iniciarSistema;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lbl_cargar;
        private System.Windows.Forms.Timer timer1;
    }
}