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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void tblUserBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblUserBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sample_ProjectsDataSet);

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sample_ProjectsDataSet.tblUser' table. You can move, or remove it, as needed.
            this.tblUserTableAdapter.Fill(this.sample_ProjectsDataSet.tblUser);

        }

        private void btnok_Click(object sender, EventArgs e)
        {
            try
            {
                    if (txtusername.Text == "" || txtpass.Text == "")
                    {
                        MessageBox.Show("Please input Username and Password", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        this.tblUserBindingSource.Filter = "Username + Password LIkE '%" + txtusername.Text.Replace("'", "''") + txtpass.Text.Replace("'", "''") + "%'";
                        if (tblUserDataGridView.Rows.Count == 1)
                        {
                        MessageBox.Show("Success!!");
                        foreach(DataGridViewRow dr in tblUserDataGridView.SelectedRows)
                        {
                            GBclass.logUser = new string[]
                            {
                                dr.Cells[0].Value.ToString(),
                                dr.Cells[1].Value.ToString(),
                                dr.Cells[7].Value.ToString()
                            };
                        }
                        this.Hide();
                        new frmMainScreen().ShowDialog();
                        this.Show();
                        txtpass.Text = "";
                        txtusername.Text = "";
                        txtusername.Focus();
                        }
                        else
                        {
                        MessageBox.Show("Please check Username and Password again!!");
                        }
                    }
                }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new frmUser().ShowDialog();
        }
    }
}
