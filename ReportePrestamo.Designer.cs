namespace VisionTFI
{
    partial class ReportePrestamo
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.visionManagementDataSet = new VisionTFI.VisionManagementDataSet();
            this.prestamoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prestamoTableAdapter = new VisionTFI.VisionManagementDataSetTableAdapters.PrestamoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.visionManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.prestamoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "VisionTFI.ReporteFactura.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1065, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // visionManagementDataSet
            // 
            this.visionManagementDataSet.DataSetName = "VisionManagementDataSet";
            this.visionManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prestamoBindingSource
            // 
            this.prestamoBindingSource.DataMember = "Prestamo";
            this.prestamoBindingSource.DataSource = this.visionManagementDataSet;
            // 
            // prestamoTableAdapter
            // 
            this.prestamoTableAdapter.ClearBeforeFill = true;
            // 
            // ReportePrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportePrestamo";
            this.Text = "ReportePrestamo";
            this.Load += new System.EventHandler(this.ReportePrestamo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.visionManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private VisionManagementDataSet visionManagementDataSet;
        private System.Windows.Forms.BindingSource prestamoBindingSource;
        private VisionManagementDataSetTableAdapters.PrestamoTableAdapter prestamoTableAdapter;
    }
}