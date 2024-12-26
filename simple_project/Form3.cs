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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void tblSaleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblSaleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sample_ProjectsDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sample_ProjectsDataSet.tblSaleDetail' table. You can move, or remove it, as needed.
            this.tblSaleDetailTableAdapter.Fill(this.sample_ProjectsDataSet.tblSaleDetail);
            // TODO: This line of code loads data into the 'sample_ProjectsDataSet.tblSale' table. You can move, or remove it, as needed.
            this.tblSaleTableAdapter.Fill(this.sample_ProjectsDataSet.tblSale);

        }
    }
}
