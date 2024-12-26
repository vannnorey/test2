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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tblSupplierBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblSupplierBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sample_ProjectsDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sample_ProjectsDataSet.tblSupplier' table. You can move, or remove it, as needed.
            this.tblSupplierTableAdapter.Fill(this.sample_ProjectsDataSet.tblSupplier);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.tblSupplierBindingSource.AddNew();
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblSupplierBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sample_ProjectsDataSet);
            MessageBox.Show("Saved");
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            var mres = MessageBox.Show(" Are you sure to delete?", "Confimation",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (mres == DialogResult.Yes)

            {
                this.tblSupplierBindingSource.RemoveCurrent();
                this.Validate();
                this.tblSupplierBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.sample_ProjectsDataSet);
                MessageBox.Show("Deleted");
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.tblSupplierBindingSource.Filter = "SupplierName + Phone LIKE'%"+tsbTextSearch.Text+"%'"; // '%"++"%'
        }

        private void tsbTextSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                toolStripButton4_Click(sender, e);
            }
        }

        private void tsbTextSearch_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
