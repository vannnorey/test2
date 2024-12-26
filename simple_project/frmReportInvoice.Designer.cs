namespace simple_project
{
    partial class frmReportInvoice
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
            this.viewInvoiceReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sample_ProjectsDataSet = new simple_project.Sample_ProjectsDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.view_InvoiceReportTableAdapter = new simple_project.Sample_ProjectsDataSetTableAdapters.View_InvoiceReportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.viewInvoiceReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sample_ProjectsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // viewInvoiceReportBindingSource
            // 
            this.viewInvoiceReportBindingSource.DataMember = "View_InvoiceReport";
            this.viewInvoiceReportBindingSource.DataSource = this.sample_ProjectsDataSet;
            // 
            // sample_ProjectsDataSet
            // 
            this.sample_ProjectsDataSet.DataSetName = "Sample_ProjectsDataSet";
            this.sample_ProjectsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.viewInvoiceReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "simple_project.rp_Invoice.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1182, 1053);
            this.reportViewer1.TabIndex = 0;
            // 
            // view_InvoiceReportTableAdapter
            // 
            this.view_InvoiceReportTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1182, 1053);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReportInvoice";
            this.Text = "frmReportInvoice";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReportInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewInvoiceReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sample_ProjectsDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Sample_ProjectsDataSet sample_ProjectsDataSet;
        private System.Windows.Forms.BindingSource viewInvoiceReportBindingSource;
        private Sample_ProjectsDataSetTableAdapters.View_InvoiceReportTableAdapter view_InvoiceReportTableAdapter;
    }
}