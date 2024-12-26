using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
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
    public partial class frmStock : Form
    {
        String UserID;
        public frmStock()
        {
            InitializeComponent();
        }

        private void tblStockBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblStockBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sample_ProjectsDataSet);

        }

        private void frmStock_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sample_ProjectsDataSet.tblSupplier' table. You can move, or remove it, as needed.
            this.tblSupplierTableAdapter.Fill(this.sample_ProjectsDataSet.tblSupplier);
            // TODO: This line of code loads data into the 'sample_ProjectsDataSet.tblProduct' table. You can move, or remove it, as needed.
            this.tblProductTableAdapter.Fill(this.sample_ProjectsDataSet.tblProduct);
            // TODO: This line of code loads data into the 'sample_ProjectsDataSet.tblStock' table. You can move, or remove it, as needed.
            this.tblStockTableAdapter.Fill(this.sample_ProjectsDataSet.tblStock, Convert.ToInt32(GBclass.gb_ProductID));
            UserID = GBclass.logUser[0];
            userIDComboBox.Items.Add(UserID);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tsbNew_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblStockBindingSource.AddNew();
                productIDComboBox.SelectedValue = GBclass.gb_ProductID;
                stockDateDateTimePicker.Text = "01-01-01";
                stockDateDateTimePicker.Value = DateTime.Today;
                userIDComboBox.SelectedValue = UserID;
                userIDComboBox.Text = UserID;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblStockBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sample_ProjectsDataSet);
            MessageBox.Show("Save");
            this.tblSupplierTableAdapter.Fill(this.sample_ProjectsDataSet.tblSupplier);
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            var mres = MessageBox.Show(" Are you sure to delete?", "Confimation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (mres == DialogResult.Yes)

            {
                this.tblStockBindingSource.RemoveCurrent();
                this.Validate();
                this.tblStockBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.sample_ProjectsDataSet);
                MessageBox.Show("Deleted");
                this.tblSupplierTableAdapter.Fill(this.sample_ProjectsDataSet.tblSupplier);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmProduct().ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmReportStock().ShowDialog();
        }

        private void supplierIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
