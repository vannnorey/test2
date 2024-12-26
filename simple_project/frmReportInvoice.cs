using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simple_project
{
    public partial class frmReportInvoice : Form
    {
        public frmReportInvoice()
        {
            InitializeComponent();
        }

        private void frmReportInvoice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sample_ProjectsDataSet.View_InvoiceReport' table. You can move, or remove it, as needed.
            this.view_InvoiceReportTableAdapter.FillByInvoiceID(this.sample_ProjectsDataSet.View_InvoiceReport, Convert.ToInt32(GBclass.sale_ID));

            this.reportViewer1.RefreshReport();
            this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            this.reportViewer1.ZoomPercent = 100;
        }
    }
}
