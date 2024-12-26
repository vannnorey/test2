namespace simple_project
{
    partial class frmReportStock
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
            this.sample_ProjectsDataSet = new simple_project.Sample_ProjectsDataSet();
            this.tblStockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblStockTableAdapter = new simple_project.Sample_ProjectsDataSetTableAdapters.tblStockTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sample_ProjectsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStockBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tblStockBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "simple_project.SelectReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-1, 1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(943, 799);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load_4);
            // 
            // sample_ProjectsDataSet
            // 
            this.sample_ProjectsDataSet.DataSetName = "Sample_ProjectsDataSet";
            this.sample_ProjectsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblStockBindingSource
            // 
            this.tblStockBindingSource.DataMember = "tblStock";
            this.tblStockBindingSource.DataSource = this.sample_ProjectsDataSet;
            // 
            // tblStockTableAdapter
            // 
            this.tblStockTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(941, 812);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Khmer OS Content", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "frmReportStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReportStock";
            this.Load += new System.EventHandler(this.frmReportStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sample_ProjectsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStockBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tblStockBindingSource;
        private Sample_ProjectsDataSet sample_ProjectsDataSet;
        private Sample_ProjectsDataSetTableAdapters.tblStockTableAdapter tblStockTableAdapter;
    }
}