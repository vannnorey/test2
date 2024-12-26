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
    public partial class frmSupplier : Form
    {
        String UserID;
        public frmSupplier()
        {
            InitializeComponent();
        }

        private void tsbNew_Click(object sender, EventArgs e)
        {

        }

        private void tblSupplierBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblSupplierBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sample_ProjectsDataSet);

        }

        private void frmSupplier_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sample_ProjectsDataSet.tblUser' table. You can move, or remove it, as needed.
            this.tblUserTableAdapter.Fill(this.sample_ProjectsDataSet.tblUser);
            // TODO: This line of code loads data into the 'sample_ProjectsDataSet.tblSupplier' table. You can move, or remove it, as needed.
            this.tblSupplierTableAdapter.Fill(this.sample_ProjectsDataSet.tblSupplier);
            UserID = GBclass.logUser[0];
            userIDComboBox.Items.Add(UserID);

        }

        private void tsbNew_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.tblSupplierBindingSource.AddNew();
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
            this.tblSupplierBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sample_ProjectsDataSet);
            MessageBox.Show("Saved");
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            var mres = MessageBox.Show(" Are you sure to delete?", "Confimation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (mres == DialogResult.Yes)

            {
                this.tblSupplierBindingSource.RemoveCurrent();
                this.Validate();
                this.tblSupplierBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.sample_ProjectsDataSet);
                MessageBox.Show("Deleted");
            }
        }

        private void tsbSearch_Click(object sender, EventArgs e)
        {
            this.tblSupplierBindingSource.Filter = "SupplierName + Phone LIKE'%" + tsbTextSearch.Text + "%'"; // '%"++"%'
        }

        private void tsbTextSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tsbSearch_Click(sender, e);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmMainScreen().ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmMainScreen().ShowDialog();
        }
    }
}
