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
    public partial class frmInvoice : Form
    {
        public frmInvoice()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
                try
                {
                    if (e.KeyCode == Keys.Enter)
                    {
                        this.tblProductBindingSource.Filter = "ProductCode ='" + txtSearch.Text.Replace("'", "''") + "'";
                        foreach (DataGridViewRow dr in tblProductDataGridView.SelectedRows)
                        {
                            txtProductname.Text = dr.Cells[2].Value.ToString();
                            txtPrice.Text = dr.Cells[5].Value.ToString();

                            if (dgvShow.Rows.Count <= 0)
                            {
                                dgvShow.Rows.Add(dr.Cells[0].Value.ToString(),
                                dr.Cells[2].Value.ToString(),
                                dr.Cells[5].Value.ToString(),
                                1,
                                1 * Convert.ToDouble(dr.Cells[5].Value.ToString()));
                                return;
                            }
                            else
                            {
                                foreach (DataGridViewRow tr in dgvShow.Rows)
                                {
                                    if (tr.Cells[0].Value.ToString() == dr.Cells[0].Value.ToString())
                                    {
                                        //MessageBox.Show("");
                                        tr.Cells[3].Value = Convert.ToInt32(tr.Cells[3].Value.ToString()) + 1;
                                        tr.Cells[4].Value =
                                              Convert.ToInt32(tr.Cells[3].Value.ToString())
                                            * Convert.ToDouble(tr.Cells[2].Value.ToString());
                                        return;
                                    }
                                }
                                dgvShow.Rows.Add(dr.Cells[0].Value.ToString(),
                                dr.Cells[2].Value.ToString(),
                                dr.Cells[5].Value.ToString(),
                                1,
                                1 * Convert.ToDouble(dr.Cells[5].Value.ToString()));
                                return;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            //try
            //{
            //    if (e.KeyCode == Keys.Enter)
            //    {
            //       this.tblProductBindingSource.Filter = "ProductCode + ProductName LIKE'%" + txtSearch.Text.Replace("'", "''") + "%'";
            //        foreach (DataGridViewRow dr in tblProductDataGridView.SelectedRows) 
            //        {
            //            txtProductname.Text = dr.Cells[2].Value.ToString();
            //            txtPrice.Text = dr.Cells[5].Value.ToString();
            //           // numQty.Value = 1;

            //            if (dgvShow.Rows.Count <= 0)
            //            {
            //                dgvShow.Rows.Add(dr.Cells[0].Value.ToString(),
            //                            dr.Cells[2].Value.ToString(),
            //                            dr.Cells[5].Value.ToString(),
            //                            1,
            //                            1 * Convert.ToDouble(dr.Cells[5].Value.ToString()));
            //            }
            //            else
            //            { 
            //                foreach(DataGridViewRow tr in dgvShow.Rows)
            //                {
            //                    if (tr.Cells[0].Value.ToString() == dr.Cells[0].Value.ToString())
            //                    {
            //                        // MessageBox.Show("Exitting");
            //                        tr.Cells[3].Value = Convert.ToInt32(tr.Cells[3].Value.ToString()) + 1;
            //                        tr.Cells[4].Value = Convert.ToInt32(tr.Cells[3].Value.ToString()) * Convert.ToInt32(tr.Cells[2].Value.ToString());
            //                        return;
            //                    }
            //                    {
            //                        dgvShow.Rows.Add(dr.Cells[0].Value.ToString(),
            //                            dr.Cells[2].Value.ToString(),
            //                            dr.Cells[5].Value.ToString (),
            //                            1, 
            //                            1 * Convert.ToDouble(dr.Cells[5].Value.ToString()));
            //                        return;
            //                    }
            //                }
            //            }

            //        }
            //    }
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message);
            //}
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void tsbNew_Click(object sender, EventArgs e)
        {

        }

        private void tblProductBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblProductBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sample_ProjectsDataSet);

        }

        private void frmInvoice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sample_ProjectsDataSet.tblSale' table. You can move, or remove it, as needed.
            this.tblSaleTableAdapter.Fill(this.sample_ProjectsDataSet.tblSale);

            // TODO: This line of code loads data into the 'sample_ProjectsDataSet.tblSaleDetail' table. You can move, or remove it, as needed.
            this.tblSaleDetailTableAdapter.Fill(this.sample_ProjectsDataSet.tblSaleDetail);

            // TODO: This line of code loads data into the 'sample_ProjectsDataSet.tblProduct' table. You can move, or remove it, as needed.
            this.tblProductTableAdapter.Fill(this.sample_ProjectsDataSet.tblProduct);


            tsbNew_Click_1(sender, e);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tsbNew_Click_1(object sender, EventArgs e)
        {
            this.tblSaleBindingSource.AddNew();
            saleDateDateTimePicker.Text = "01-01-01";
            saleDateDateTimePicker.Value = DateTime.Now;
            userIDTextBox.Text = GBclass.logUser[0];

            this.Validate();
            this.tblSaleBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.sample_ProjectsDataSet);
        }

        private void tsbInvoice_Click(object sender, EventArgs e)
        {
            
        }

        private void tsbInvoice_Click_1(object sender, EventArgs e)
        {
            
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            try
            {
                foreach(DataGridViewRow dr in dgvShow.Rows)
                {
                    this.tblSaleDetailBindingSource.AddNew();
                    saleIDTextBox1.Text = saleIDTextBox.Text;
                    productIDTextBox.Text = dr.Cells[0].Value.ToString();
                    saleQtyTextBox.Text = dr.Cells[3].Value.ToString();
                    priceOUTTextBox.Text = dr.Cells[2].Value.ToString();

                    this.Validate();
                    this.tblSaleDetailBindingSource.EndEdit();
                    this.tableAdapterManager2.UpdateAll(this.sample_ProjectsDataSet);

                    txtSearch.Clear();
                    txtProductname.Clear();
                    txtPrice.Clear();
                }
                MessageBox.Show("Save");
                GBclass.sale_ID = saleIDTextBox.Text;
                new frmReportInvoice().ShowDialog();
                this.Dispose();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            new frmInvoice().ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
