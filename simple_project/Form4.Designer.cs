namespace simple_project
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label saleDetailIDLabel;
            System.Windows.Forms.Label saleIDLabel;
            System.Windows.Forms.Label productIDLabel;
            System.Windows.Forms.Label saleQtyLabel;
            System.Windows.Forms.Label priceOUTLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.sample_ProjectsDataSet = new simple_project.Sample_ProjectsDataSet();
            this.tblSaleDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblSaleDetailTableAdapter = new simple_project.Sample_ProjectsDataSetTableAdapters.tblSaleDetailTableAdapter();
            this.tableAdapterManager = new simple_project.Sample_ProjectsDataSetTableAdapters.TableAdapterManager();
            this.tblSaleDetailBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.saleDetailIDTextBox = new System.Windows.Forms.TextBox();
            this.saleIDTextBox = new System.Windows.Forms.TextBox();
            this.productIDTextBox = new System.Windows.Forms.TextBox();
            this.saleQtyTextBox = new System.Windows.Forms.TextBox();
            this.priceOUTTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.tblSaleDetailBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            saleDetailIDLabel = new System.Windows.Forms.Label();
            saleIDLabel = new System.Windows.Forms.Label();
            productIDLabel = new System.Windows.Forms.Label();
            saleQtyLabel = new System.Windows.Forms.Label();
            priceOUTLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sample_ProjectsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSaleDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSaleDetailBindingNavigator)).BeginInit();
            this.tblSaleDetailBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // sample_ProjectsDataSet
            // 
            this.sample_ProjectsDataSet.DataSetName = "Sample_ProjectsDataSet";
            this.sample_ProjectsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblSaleDetailBindingSource
            // 
            this.tblSaleDetailBindingSource.DataMember = "tblSaleDetail";
            this.tblSaleDetailBindingSource.DataSource = this.sample_ProjectsDataSet;
            // 
            // tblSaleDetailTableAdapter
            // 
            this.tblSaleDetailTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblGenderTableAdapter = null;
            this.tableAdapterManager.tblProductTableAdapter = null;
            this.tableAdapterManager.tblSaleDetailTableAdapter = this.tblSaleDetailTableAdapter;
            this.tableAdapterManager.tblSaleTableAdapter = null;
            this.tableAdapterManager.tblStockTableAdapter = null;
            this.tableAdapterManager.tblSupplierTableAdapter = null;
            this.tableAdapterManager.tblUserTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = simple_project.Sample_ProjectsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblSaleDetailBindingNavigator
            // 
            this.tblSaleDetailBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblSaleDetailBindingNavigator.BindingSource = this.tblSaleDetailBindingSource;
            this.tblSaleDetailBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblSaleDetailBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblSaleDetailBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tblSaleDetailBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tblSaleDetailBindingNavigatorSaveItem});
            this.tblSaleDetailBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tblSaleDetailBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblSaleDetailBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblSaleDetailBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblSaleDetailBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblSaleDetailBindingNavigator.Name = "tblSaleDetailBindingNavigator";
            this.tblSaleDetailBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblSaleDetailBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.tblSaleDetailBindingNavigator.TabIndex = 0;
            this.tblSaleDetailBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // saleDetailIDLabel
            // 
            saleDetailIDLabel.AutoSize = true;
            saleDetailIDLabel.Location = new System.Drawing.Point(128, 91);
            saleDetailIDLabel.Name = "saleDetailIDLabel";
            saleDetailIDLabel.Size = new System.Drawing.Size(92, 16);
            saleDetailIDLabel.TabIndex = 1;
            saleDetailIDLabel.Text = "Sale Detail ID:";
            // 
            // saleDetailIDTextBox
            // 
            this.saleDetailIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblSaleDetailBindingSource, "SaleDetailID", true));
            this.saleDetailIDTextBox.Location = new System.Drawing.Point(226, 88);
            this.saleDetailIDTextBox.Name = "saleDetailIDTextBox";
            this.saleDetailIDTextBox.Size = new System.Drawing.Size(100, 22);
            this.saleDetailIDTextBox.TabIndex = 2;
            // 
            // saleIDLabel
            // 
            saleIDLabel.AutoSize = true;
            saleIDLabel.Location = new System.Drawing.Point(128, 119);
            saleIDLabel.Name = "saleIDLabel";
            saleIDLabel.Size = new System.Drawing.Size(54, 16);
            saleIDLabel.TabIndex = 3;
            saleIDLabel.Text = "Sale ID:";
            // 
            // saleIDTextBox
            // 
            this.saleIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblSaleDetailBindingSource, "SaleID", true));
            this.saleIDTextBox.Location = new System.Drawing.Point(226, 116);
            this.saleIDTextBox.Name = "saleIDTextBox";
            this.saleIDTextBox.Size = new System.Drawing.Size(100, 22);
            this.saleIDTextBox.TabIndex = 4;
            // 
            // productIDLabel
            // 
            productIDLabel.AutoSize = true;
            productIDLabel.Location = new System.Drawing.Point(128, 147);
            productIDLabel.Name = "productIDLabel";
            productIDLabel.Size = new System.Drawing.Size(72, 16);
            productIDLabel.TabIndex = 5;
            productIDLabel.Text = "Product ID:";
            // 
            // productIDTextBox
            // 
            this.productIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblSaleDetailBindingSource, "ProductID", true));
            this.productIDTextBox.Location = new System.Drawing.Point(226, 144);
            this.productIDTextBox.Name = "productIDTextBox";
            this.productIDTextBox.Size = new System.Drawing.Size(100, 22);
            this.productIDTextBox.TabIndex = 6;
            // 
            // saleQtyLabel
            // 
            saleQtyLabel.AutoSize = true;
            saleQtyLabel.Location = new System.Drawing.Point(128, 175);
            saleQtyLabel.Name = "saleQtyLabel";
            saleQtyLabel.Size = new System.Drawing.Size(61, 16);
            saleQtyLabel.TabIndex = 7;
            saleQtyLabel.Text = "Sale Qty:";
            // 
            // saleQtyTextBox
            // 
            this.saleQtyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblSaleDetailBindingSource, "SaleQty", true));
            this.saleQtyTextBox.Location = new System.Drawing.Point(226, 172);
            this.saleQtyTextBox.Name = "saleQtyTextBox";
            this.saleQtyTextBox.Size = new System.Drawing.Size(100, 22);
            this.saleQtyTextBox.TabIndex = 8;
            // 
            // priceOUTLabel
            // 
            priceOUTLabel.AutoSize = true;
            priceOUTLabel.Location = new System.Drawing.Point(128, 203);
            priceOUTLabel.Name = "priceOUTLabel";
            priceOUTLabel.Size = new System.Drawing.Size(73, 16);
            priceOUTLabel.TabIndex = 9;
            priceOUTLabel.Text = "Price OUT:";
            // 
            // priceOUTTextBox
            // 
            this.priceOUTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblSaleDetailBindingSource, "PriceOUT", true));
            this.priceOUTTextBox.Location = new System.Drawing.Point(226, 200);
            this.priceOUTTextBox.Name = "priceOUTTextBox";
            this.priceOUTTextBox.Size = new System.Drawing.Size(100, 22);
            this.priceOUTTextBox.TabIndex = 10;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // tblSaleDetailBindingNavigatorSaveItem
            // 
            this.tblSaleDetailBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblSaleDetailBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblSaleDetailBindingNavigatorSaveItem.Image")));
            this.tblSaleDetailBindingNavigatorSaveItem.Name = "tblSaleDetailBindingNavigatorSaveItem";
            this.tblSaleDetailBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.tblSaleDetailBindingNavigatorSaveItem.Text = "Save Data";
            this.tblSaleDetailBindingNavigatorSaveItem.Click += new System.EventHandler(this.tblSaleDetailBindingNavigatorSaveItem_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(saleDetailIDLabel);
            this.Controls.Add(this.saleDetailIDTextBox);
            this.Controls.Add(saleIDLabel);
            this.Controls.Add(this.saleIDTextBox);
            this.Controls.Add(productIDLabel);
            this.Controls.Add(this.productIDTextBox);
            this.Controls.Add(saleQtyLabel);
            this.Controls.Add(this.saleQtyTextBox);
            this.Controls.Add(priceOUTLabel);
            this.Controls.Add(this.priceOUTTextBox);
            this.Controls.Add(this.tblSaleDetailBindingNavigator);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sample_ProjectsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSaleDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSaleDetailBindingNavigator)).EndInit();
            this.tblSaleDetailBindingNavigator.ResumeLayout(false);
            this.tblSaleDetailBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sample_ProjectsDataSet sample_ProjectsDataSet;
        private System.Windows.Forms.BindingSource tblSaleDetailBindingSource;
        private Sample_ProjectsDataSetTableAdapters.tblSaleDetailTableAdapter tblSaleDetailTableAdapter;
        private Sample_ProjectsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tblSaleDetailBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tblSaleDetailBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox saleDetailIDTextBox;
        private System.Windows.Forms.TextBox saleIDTextBox;
        private System.Windows.Forms.TextBox productIDTextBox;
        private System.Windows.Forms.TextBox saleQtyTextBox;
        private System.Windows.Forms.TextBox priceOUTTextBox;
    }
}