namespace ReporteMateriasOfertadas
{
    partial class Reporte
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
            this.spReporteMateriasOfertadasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new ReporteMateriasOfertadas.DataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.spReporteMateriasOfertadasTableAdapter = new ReporteMateriasOfertadas.DataSet1TableAdapters.spReporteMateriasOfertadasTableAdapter();
            this.universidadDBDataSet = new ReporteMateriasOfertadas.UniversidadDBDataSet();
            this.spReporteMateriasOfertadasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.spReporteMateriasOfertadasTableAdapter1 = new ReporteMateriasOfertadas.UniversidadDBDataSetTableAdapters.spReporteMateriasOfertadasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spReporteMateriasOfertadasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universidadDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spReporteMateriasOfertadasBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // spReporteMateriasOfertadasBindingSource
            // 
            this.spReporteMateriasOfertadasBindingSource.DataMember = "spReporteMateriasOfertadas";
            this.spReporteMateriasOfertadasBindingSource.DataSource = this.dataSet1BindingSource;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetMateriasOfertadas";
            reportDataSource1.Value = this.spReporteMateriasOfertadasBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReporteMateriasOfertadas.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 459);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // spReporteMateriasOfertadasTableAdapter
            // 
            this.spReporteMateriasOfertadasTableAdapter.ClearBeforeFill = true;
            // 
            // universidadDBDataSet
            // 
            this.universidadDBDataSet.DataSetName = "UniversidadDBDataSet";
            this.universidadDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spReporteMateriasOfertadasBindingSource1
            // 
            this.spReporteMateriasOfertadasBindingSource1.DataMember = "spReporteMateriasOfertadas";
            this.spReporteMateriasOfertadasBindingSource1.DataSource = this.universidadDBDataSet;
            // 
            // spReporteMateriasOfertadasTableAdapter1
            // 
            this.spReporteMateriasOfertadasTableAdapter1.ClearBeforeFill = true;
            // 
            // Reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 459);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Reporte";
            this.Text = "Reporte";
            this.Load += new System.EventHandler(this.Reporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spReporteMateriasOfertadasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universidadDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spReporteMateriasOfertadasBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spReporteMateriasOfertadasBindingSource;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.spReporteMateriasOfertadasTableAdapter spReporteMateriasOfertadasTableAdapter;
        private System.Windows.Forms.BindingSource spReporteMateriasOfertadasBindingSource1;
        private UniversidadDBDataSet universidadDBDataSet;
        private UniversidadDBDataSetTableAdapters.spReporteMateriasOfertadasTableAdapter spReporteMateriasOfertadasTableAdapter1;
    }
}