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
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }

        private void tblUserBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblUserBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sample_ProjectsDataSet);

        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sample_ProjectsDataSet.temp_UserGender' table. You can move, or remove it, as needed.
            this.temp_UserGenderTableAdapter.Fill(this.sample_ProjectsDataSet.temp_UserGender);
            // TODO: This line of code loads data into the 'sample_ProjectsDataSet.tblGender' table. You can move, or remove it, as needed.
            this.tblGenderTableAdapter.Fill(this.sample_ProjectsDataSet.tblGender);
            // TODO: This line of code loads data into the 'sample_ProjectsDataSet.tblUser' table. You can move, or remove it, as needed.
            this.tblUserTableAdapter.Fill(this.sample_ProjectsDataSet.tblUser);

        }

        private void tsbNew_Click(object sender, EventArgs e)
        {
            this.tblUserBindingSource.AddNew();
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblUserBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sample_ProjectsDataSet);
            MessageBox.Show("Save");
            this.temp_UserGenderTableAdapter.Fill(this.sample_ProjectsDataSet.temp_UserGender);
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            var mres = MessageBox.Show(" Are you sure to delete?", "Confimation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (mres == DialogResult.Yes)

            {
                this.tblUserBindingSource.RemoveCurrent();
                this.Validate();
                this.tblUserBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.sample_ProjectsDataSet);
                MessageBox.Show("Deleted");
                this.temp_UserGenderTableAdapter.Fill(this.sample_ProjectsDataSet.temp_UserGender);
            }
        }

        private void tsbSearch_Click(object sender, EventArgs e)
        {
            //this.tblUserBindingSource.Filter = "Username + Phone LIKE'%" + tsbTextSearch.Text.Replace("'" , "''") + "%'"; // '%"++"%'
            temp_UserGenderBindingSource.Filter = "UserLabel + Phone LIKE'%" + tsbTextSearch.Text.Replace("'", "''") + "%'"; // '%"++"%'
        }

        private void tsbTextSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tsbSearch_Click(sender, e);
            }
        }

        private void temp_UserGenderDataGridView_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in temp_UserGenderDataGridView.SelectedRows)
            {
                this.tblUserTableAdapter.FillByUserID(this.sample_ProjectsDataSet.tblUser, Convert.ToInt32(dr.Cells[0].Value));
            }
        }

        private void temp_UserGenderDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void tsbTextSearch_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void genderLabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmLogin().ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
