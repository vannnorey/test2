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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void tblSaleDetailBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblSaleDetailBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sample_ProjectsDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sample_ProjectsDataSet.tblSaleDetail' table. You can move, or remove it, as needed.
            this.tblSaleDetailTableAdapter.Fill(this.sample_ProjectsDataSet.tblSaleDetail);

        }
    }
}
