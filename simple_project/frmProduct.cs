using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace simple_project
{
    public partial class frmProduct : Form
    {
        String UserID;
        public frmProduct()
        {
            InitializeComponent();
        }

        private void tblProductBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblProductBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sample_ProjectsDataSet);

        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sample_ProjectsDataSet.tblUser' table. You can move, or remove it, as needed.
            this.tblUserTableAdapter.Fill(this.sample_ProjectsDataSet.tblUser);
            // TODO: This line of code loads data into the 'sample_ProjectsDataSet.tblProduct' table. You can move, or remove it, as needed.
            this.tblProductTableAdapter.Fill(this.sample_ProjectsDataSet.tblProduct);
            UserID = GBclass.logUser[0];
            userIDComboBox.Items.Add(UserID);

        }

        private void tsbNew_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblProductBindingSource.AddNew();
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
            this.tblProductBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sample_ProjectsDataSet);
            MessageBox.Show("Saved");
            this.tblProductTableAdapter.Fill(this.sample_ProjectsDataSet.tblProduct);
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            var mres = MessageBox.Show(" Are you sure to delete?", "Confimation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (mres == DialogResult.Yes)

            {
                this.tblProductBindingSource.RemoveCurrent();
                this.Validate();
                this.tblProductBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.sample_ProjectsDataSet);
                MessageBox.Show("Deleted");
                this.tblProductTableAdapter.Fill(this.sample_ProjectsDataSet.tblProduct);
            }
        }

        private void tsbSearch_Click(object sender, EventArgs e)
        {
            this.tblProductBindingSource.Filter = "ProductCode + ProductName LIKE'%" + tsbTextSearch.Text.Replace("'", "''") + "%'"; // LIKE'%"++"%'
        }

        private void tsbTextSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tsbSearch_Click(sender, e);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            GBclass.gb_ProductID = productIDTextBox.Text;
            this.Hide();
            new frmStock().ShowDialog();
            this.tblProductTableAdapter.Fill(this.sample_ProjectsDataSet.tblProduct);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tsbTextSearch_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmMainScreen().ShowDialog(); 
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
