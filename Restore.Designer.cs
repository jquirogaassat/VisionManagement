namespace VisionTFI
{
    partial class Restore
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
            this.lbl_listado = new System.Windows.Forms.Label();
            this.dgv_restore = new System.Windows.Forms.DataGridView();
            this.btn_generarRestore = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_restore)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_listado
            // 
            this.lbl_listado.AutoSize = true;
            this.lbl_listado.Location = new System.Drawing.Point(12, 102);
            this.lbl_listado.Name = "lbl_listado";
            this.lbl_listado.Size = new System.Drawing.Size(156, 13);
            this.lbl_listado.TabIndex = 30;
            this.lbl_listado.Text = "Listado de backup disponibles :";
            // 
            // dgv_restore
            // 
            this.dgv_restore.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_restore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_restore.Location = new System.Drawing.Point(12, 133);
            this.dgv_restore.Name = "dgv_restore";
            this.dgv_restore.Size = new System.Drawing.Size(900, 274);
            this.dgv_restore.TabIndex = 31;
            this.dgv_restore.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgv_restore_MouseClick);
            // 
            // btn_generarRestore
            // 
            this.btn_generarRestore.Location = new System.Drawing.Point(983, 151);
            this.btn_generarRestore.Name = "btn_generarRestore";
            this.btn_generarRestore.Size = new System.Drawing.Size(118, 43);
            this.btn_generarRestore.TabIndex = 32;
            this.btn_generarRestore.Text = "Generar restore";
            this.btn_generarRestore.UseVisualStyleBackColor = true;
            this.btn_generarRestore.Click += new System.EventHandler(this.btn_generarRestore_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(983, 232);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(118, 43);
            this.btn_salir.TabIndex = 33;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // Restore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 450);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_generarRestore);
            this.Controls.Add(this.dgv_restore);
            this.Controls.Add(this.lbl_listado);
            this.Name = "Restore";
            this.Text = "Vision Management/ Solicitar restore";
            this.Load += new System.EventHandler(this.Restore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_restore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_listado;
        private System.Windows.Forms.DataGridView dgv_restore;
        private System.Windows.Forms.Button btn_generarRestore;
        private System.Windows.Forms.Button btn_salir;
    }
}