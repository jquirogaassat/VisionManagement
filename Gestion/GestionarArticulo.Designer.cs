namespace VisionTFI
{
    partial class GestionarArticulo
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
            this.btn_buscarArticulo = new System.Windows.Forms.Button();
            this.lbl_nombreArticulo = new System.Windows.Forms.Label();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.dg_articulo = new System.Windows.Forms.DataGridView();
            this.btn_salirArticulo = new System.Windows.Forms.Button();
            this.btn_quitarArticulo = new System.Windows.Forms.Button();
            this.btn_modificarArticulo = new System.Windows.Forms.Button();
            this.btn_agregarArticulo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_articulo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_buscarArticulo
            // 
            this.btn_buscarArticulo.Location = new System.Drawing.Point(237, 100);
            this.btn_buscarArticulo.Name = "btn_buscarArticulo";
            this.btn_buscarArticulo.Size = new System.Drawing.Size(75, 23);
            this.btn_buscarArticulo.TabIndex = 10;
            this.btn_buscarArticulo.Text = "Buscar";
            this.btn_buscarArticulo.UseVisualStyleBackColor = true;
            // 
            // lbl_nombreArticulo
            // 
            this.lbl_nombreArticulo.AutoSize = true;
            this.lbl_nombreArticulo.Location = new System.Drawing.Point(12, 87);
            this.lbl_nombreArticulo.Name = "lbl_nombreArticulo";
            this.lbl_nombreArticulo.Size = new System.Drawing.Size(81, 13);
            this.lbl_nombreArticulo.TabIndex = 9;
            this.lbl_nombreArticulo.Text = "Nombre articulo";
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(12, 103);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(200, 20);
            this.txt_buscar.TabIndex = 8;
            // 
            // dg_articulo
            // 
            this.dg_articulo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_articulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_articulo.Location = new System.Drawing.Point(12, 129);
            this.dg_articulo.Name = "dg_articulo";
            this.dg_articulo.Size = new System.Drawing.Size(763, 291);
            this.dg_articulo.TabIndex = 11;
            this.dg_articulo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dg_articulo_MouseClick_1);
            // 
            // btn_salirArticulo
            // 
            this.btn_salirArticulo.Location = new System.Drawing.Point(821, 313);
            this.btn_salirArticulo.Name = "btn_salirArticulo";
            this.btn_salirArticulo.Size = new System.Drawing.Size(116, 29);
            this.btn_salirArticulo.TabIndex = 15;
            this.btn_salirArticulo.Text = "Cancelar";
            this.btn_salirArticulo.UseVisualStyleBackColor = true;
            this.btn_salirArticulo.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_quitarArticulo
            // 
            this.btn_quitarArticulo.Location = new System.Drawing.Point(821, 242);
            this.btn_quitarArticulo.Name = "btn_quitarArticulo";
            this.btn_quitarArticulo.Size = new System.Drawing.Size(116, 29);
            this.btn_quitarArticulo.TabIndex = 14;
            this.btn_quitarArticulo.Text = "Eliminar articulo";
            this.btn_quitarArticulo.UseVisualStyleBackColor = true;
            this.btn_quitarArticulo.Click += new System.EventHandler(this.btn_quitar_Click);
            // 
            // btn_modificarArticulo
            // 
            this.btn_modificarArticulo.Location = new System.Drawing.Point(821, 183);
            this.btn_modificarArticulo.Name = "btn_modificarArticulo";
            this.btn_modificarArticulo.Size = new System.Drawing.Size(116, 29);
            this.btn_modificarArticulo.TabIndex = 13;
            this.btn_modificarArticulo.Text = "Modificar articulo";
            this.btn_modificarArticulo.UseVisualStyleBackColor = true;
            this.btn_modificarArticulo.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_agregarArticulo
            // 
            this.btn_agregarArticulo.Location = new System.Drawing.Point(821, 129);
            this.btn_agregarArticulo.Name = "btn_agregarArticulo";
            this.btn_agregarArticulo.Size = new System.Drawing.Size(116, 29);
            this.btn_agregarArticulo.TabIndex = 12;
            this.btn_agregarArticulo.Text = "Agregar articulo";
            this.btn_agregarArticulo.UseVisualStyleBackColor = true;
            this.btn_agregarArticulo.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(115, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(500, 69);
            this.label2.TabIndex = 16;
            this.label2.Text = "Gestionar articulo";
            // 
            // GestionarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_salirArticulo);
            this.Controls.Add(this.btn_quitarArticulo);
            this.Controls.Add(this.btn_modificarArticulo);
            this.Controls.Add(this.btn_agregarArticulo);
            this.Controls.Add(this.dg_articulo);
            this.Controls.Add(this.btn_buscarArticulo);
            this.Controls.Add(this.lbl_nombreArticulo);
            this.Controls.Add(this.txt_buscar);
            this.Name = "GestionarArticulo";
            this.Text = "Vision Management/ Gestionar articulo";
            this.Load += new System.EventHandler(this.GestionarArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_articulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_buscarArticulo;
        private System.Windows.Forms.Label lbl_nombreArticulo;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.DataGridView dg_articulo;
        private System.Windows.Forms.Button btn_salirArticulo;
        private System.Windows.Forms.Button btn_quitarArticulo;
        private System.Windows.Forms.Button btn_modificarArticulo;
        private System.Windows.Forms.Button btn_agregarArticulo;
        private System.Windows.Forms.Label label2;
    }
}