namespace simple_project
{
    partial class frmProduct
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
            System.Windows.Forms.Label productIDLabel;
            System.Windows.Forms.Label productCodeLabel;
            System.Windows.Forms.Label productNameLabel;
            System.Windows.Forms.Label stockQtyLabel;
            System.Windows.Forms.Label last_PriceINLabel;
            System.Windows.Forms.Label last_PriceOUTLabel;
            System.Windows.Forms.Label disabledLabel;
            System.Windows.Forms.Label userIDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduct));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbSearch = new System.Windows.Forms.ToolStripButton();
            this.tsbTextSearch = new System.Windows.Forms.ToolStripTextBox();
            this.tsbNew = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.productIDTextBox = new System.Windows.Forms.TextBox();
            this.tblProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sample_ProjectsDataSet = new simple_project.Sample_ProjectsDataSet();
            this.productCodeTextBox = new System.Windows.Forms.TextBox();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.stockQtyTextBox = new System.Windows.Forms.TextBox();
            this.last_PriceINTextBox = new System.Windows.Forms.TextBox();
            this.last_PriceOUTTextBox = new System.Windows.Forms.TextBox();
            this.disabledCheckBox = new System.Windows.Forms.CheckBox();
            this.userIDComboBox = new System.Windows.Forms.ComboBox();
            this.tblProductBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblProductDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblProductTableAdapter = new simple_project.Sample_ProjectsDataSetTableAdapters.tblProductTableAdapter();
            this.tableAdapterManager = new simple_project.Sample_ProjectsDataSetTableAdapters.TableAdapterManager();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tblUserTableAdapter = new simple_project.Sample_ProjectsDataSetTableAdapters.tblUserTableAdapter();
            productIDLabel = new System.Windows.Forms.Label();
            productCodeLabel = new System.Windows.Forms.Label();
            productNameLabel = new System.Windows.Forms.Label();
            stockQtyLabel = new System.Windows.Forms.Label();
            last_PriceINLabel = new System.Windows.Forms.Label();
            last_PriceOUTLabel = new System.Windows.Forms.Label();
            disabledLabel = new System.Windows.Forms.Label();
            userIDLabel = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sample_ProjectsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // productIDLabel
            // 
            productIDLabel.AutoSize = true;
            productIDLabel.Font = new System.Drawing.Font("Khmer OS Content", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            productIDLabel.ForeColor = System.Drawing.Color.SteelBlue;
            productIDLabel.Location = new System.Drawing.Point(12, 38);
            productIDLabel.Name = "productIDLabel";
            productIDLabel.Size = new System.Drawing.Size(127, 36);
            productIDLabel.TabIndex = 0;
            productIDLabel.Text = "Product ID:";
            // 
            // productCodeLabel
            // 
            productCodeLabel.AutoSize = true;
            productCodeLabel.Font = new System.Drawing.Font("Khmer OS Content", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            productCodeLabel.ForeColor = System.Drawing.Color.SteelBlue;
            productCodeLabel.Location = new System.Drawing.Point(12, 83);
            productCodeLabel.Name = "productCodeLabel";
            productCodeLabel.Size = new System.Drawing.Size(156, 36);
            productCodeLabel.TabIndex = 2;
            productCodeLabel.Text = "Product Code:";
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Font = new System.Drawing.Font("Khmer OS Content", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            productNameLabel.ForeColor = System.Drawing.Color.SteelBlue;
            productNameLabel.Location = new System.Drawing.Point(12, 128);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new System.Drawing.Size(161, 36);
            productNameLabel.TabIndex = 4;
            productNameLabel.Text = "Product Name:";
            // 
            // stockQtyLabel
            // 
            stockQtyLabel.AutoSize = true;
            stockQtyLabel.Font = new System.Drawing.Font("Khmer OS Content", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            stockQtyLabel.ForeColor = System.Drawing.Color.SteelBlue;
            stockQtyLabel.Location = new System.Drawing.Point(12, 173);
            stockQtyLabel.Name = "stockQtyLabel";
            stockQtyLabel.Size = new System.Drawing.Size(119, 36);
            stockQtyLabel.TabIndex = 6;
            stockQtyLabel.Text = "Stock Qty:";
            // 
            // last_PriceINLabel
            // 
            last_PriceINLabel.AutoSize = true;
            last_PriceINLabel.Font = new System.Drawing.Font("Khmer OS Content", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            last_PriceINLabel.ForeColor = System.Drawing.Color.SteelBlue;
            last_PriceINLabel.Location = new System.Drawing.Point(529, 38);
            last_PriceINLabel.Name = "last_PriceINLabel";
            last_PriceINLabel.Size = new System.Drawing.Size(150, 36);
            last_PriceINLabel.TabIndex = 8;
            last_PriceINLabel.Text = "Last Price IN:";
            // 
            // last_PriceOUTLabel
            // 
            last_PriceOUTLabel.AutoSize = true;
            last_PriceOUTLabel.Font = new System.Drawing.Font("Khmer OS Content", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            last_PriceOUTLabel.ForeColor = System.Drawing.Color.SteelBlue;
            last_PriceOUTLabel.Location = new System.Drawing.Point(529, 83);
            last_PriceOUTLabel.Name = "last_PriceOUTLabel";
            last_PriceOUTLabel.Size = new System.Drawing.Size(173, 36);
            last_PriceOUTLabel.TabIndex = 10;
            last_PriceOUTLabel.Text = "Last Price OUT:";
            // 
            // disabledLabel
            // 
            disabledLabel.AutoSize = true;
            disabledLabel.Font = new System.Drawing.Font("Khmer OS Content", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            disabledLabel.ForeColor = System.Drawing.Color.SteelBlue;
            disabledLabel.Location = new System.Drawing.Point(529, 130);
            disabledLabel.Name = "disabledLabel";
            disabledLabel.Size = new System.Drawing.Size(106, 36);
            disabledLabel.TabIndex = 12;
            disabledLabel.Text = "Disabled:";
            // 
            // userIDLabel
            // 
            userIDLabel.AutoSize = true;
            userIDLabel.Font = new System.Drawing.Font("Khmer OS Content", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            userIDLabel.ForeColor = System.Drawing.Color.SteelBlue;
            userIDLabel.Location = new System.Drawing.Point(529, 170);
            userIDLabel.Name = "userIDLabel";
            userIDLabel.Size = new System.Drawing.Size(97, 36);
            userIDLabel.TabIndex = 14;
            userIDLabel.Text = "User ID:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSearch,
            this.tsbTextSearch,
            this.tsbNew,
            this.tsbSave,
            this.tsbDelete,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(182, 710);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbSearch
            // 
            this.tsbSearch.Font = new System.Drawing.Font("Khmer OS Content", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbSearch.Image = ((System.Drawing.Image)(resources.GetObject("tsbSearch.Image")));
            this.tsbSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSearch.Name = "tsbSearch";
            this.tsbSearch.Size = new System.Drawing.Size(180, 40);
            this.tsbSearch.Text = "Search";
            this.tsbSearch.Click += new System.EventHandler(this.tsbSearch_Click);
            // 
            // tsbTextSearch
            // 
            this.tsbTextSearch.Font = new System.Drawing.Font("Khmer OS Content", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbTextSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tsbTextSearch.Name = "tsbTextSearch";
            this.tsbTextSearch.Size = new System.Drawing.Size(178, 39);
            this.tsbTextSearch.Tag = "";
            this.tsbTextSearch.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tsbTextSearch.ToolTipText = "search";
            this.tsbTextSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tsbTextSearch_KeyDown);
            this.tsbTextSearch.Click += new System.EventHandler(this.tsbTextSearch_Click);
            // 
            // tsbNew
            // 
            this.tsbNew.Font = new System.Drawing.Font("Khmer OS Content", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbNew.Image = global::simple_project.Properties.Resources.duplicate_11872293;
            this.tsbNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNew.Name = "tsbNew";
            this.tsbNew.Size = new System.Drawing.Size(180, 40);
            this.tsbNew.Text = "New";
            this.tsbNew.Click += new System.EventHandler(this.tsbNew_Click);
            // 
            // tsbSave
            // 
            this.tsbSave.Font = new System.Drawing.Font("Khmer OS Content", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbSave.Image = global::simple_project.Properties.Resources.disk_4072513;
            this.tsbSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(180, 40);
            this.tsbSave.Text = "Save";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.Font = new System.Drawing.Font("Khmer OS Content", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbDelete.Image = global::simple_project.Properties.Resources.bin_3389034;
            this.tsbDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(180, 40);
            this.tsbDelete.Text = "Delete";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Font = new System.Drawing.Font("Khmer OS Content", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(180, 40);
            this.toolStripButton1.Text = "Stock";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(productIDLabel);
            this.groupBox1.Controls.Add(this.productIDTextBox);
            this.groupBox1.Controls.Add(productCodeLabel);
            this.groupBox1.Controls.Add(this.productCodeTextBox);
            this.groupBox1.Controls.Add(productNameLabel);
            this.groupBox1.Controls.Add(this.productNameTextBox);
            this.groupBox1.Controls.Add(stockQtyLabel);
            this.groupBox1.Controls.Add(this.stockQtyTextBox);
            this.groupBox1.Controls.Add(last_PriceINLabel);
            this.groupBox1.Controls.Add(this.last_PriceINTextBox);
            this.groupBox1.Controls.Add(last_PriceOUTLabel);
            this.groupBox1.Controls.Add(this.last_PriceOUTTextBox);
            this.groupBox1.Controls.Add(disabledLabel);
            this.groupBox1.Controls.Add(this.disabledCheckBox);
            this.groupBox1.Controls.Add(userIDLabel);
            this.groupBox1.Controls.Add(this.userIDComboBox);
            this.groupBox1.Location = new System.Drawing.Point(207, 442);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1025, 256);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // productIDTextBox
            // 
            this.productIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblProductBindingSource, "ProductID", true));
            this.productIDTextBox.Location = new System.Drawing.Point(185, 35);
            this.productIDTextBox.Name = "productIDTextBox";
            this.productIDTextBox.ReadOnly = true;
            this.productIDTextBox.Size = new System.Drawing.Size(267, 39);
            this.productIDTextBox.TabIndex = 1;
            // 
            // tblProductBindingSource
            // 
            this.tblProductBindingSource.DataMember = "tblProduct";
            this.tblProductBindingSource.DataSource = this.sample_ProjectsDataSet;
            // 
            // sample_ProjectsDataSet
            // 
            this.sample_ProjectsDataSet.DataSetName = "Sample_ProjectsDataSet";
            this.sample_ProjectsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productCodeTextBox
            // 
            this.productCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblProductBindingSource, "ProductCode", true));
            this.productCodeTextBox.Location = new System.Drawing.Point(185, 80);
            this.productCodeTextBox.Name = "productCodeTextBox";
            this.productCodeTextBox.Size = new System.Drawing.Size(267, 39);
            this.productCodeTextBox.TabIndex = 3;
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblProductBindingSource, "ProductName", true));
            this.productNameTextBox.Location = new System.Drawing.Point(185, 125);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(267, 39);
            this.productNameTextBox.TabIndex = 5;
            // 
            // stockQtyTextBox
            // 
            this.stockQtyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblProductBindingSource, "StockQty", true));
            this.stockQtyTextBox.Location = new System.Drawing.Point(185, 170);
            this.stockQtyTextBox.Name = "stockQtyTextBox";
            this.stockQtyTextBox.Size = new System.Drawing.Size(267, 39);
            this.stockQtyTextBox.TabIndex = 7;
            // 
            // last_PriceINTextBox
            // 
            this.last_PriceINTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblProductBindingSource, "Last_PriceIN", true));
            this.last_PriceINTextBox.Location = new System.Drawing.Point(707, 35);
            this.last_PriceINTextBox.Name = "last_PriceINTextBox";
            this.last_PriceINTextBox.Size = new System.Drawing.Size(264, 39);
            this.last_PriceINTextBox.TabIndex = 9;
            // 
            // last_PriceOUTTextBox
            // 
            this.last_PriceOUTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblProductBindingSource, "Last_PriceOUT", true));
            this.last_PriceOUTTextBox.Location = new System.Drawing.Point(707, 80);
            this.last_PriceOUTTextBox.Name = "last_PriceOUTTextBox";
            this.last_PriceOUTTextBox.Size = new System.Drawing.Size(264, 39);
            this.last_PriceOUTTextBox.TabIndex = 11;
            // 
            // disabledCheckBox
            // 
            this.disabledCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tblProductBindingSource, "Disabled", true));
            this.disabledCheckBox.Location = new System.Drawing.Point(707, 130);
            this.disabledCheckBox.Name = "disabledCheckBox";
            this.disabledCheckBox.Size = new System.Drawing.Size(264, 24);
            this.disabledCheckBox.TabIndex = 13;
            this.disabledCheckBox.UseVisualStyleBackColor = true;
            // 
            // userIDComboBox
            // 
            this.userIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblProductBindingSource, "UserID", true));
            this.userIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tblProductBindingSource1, "UserID", true));
            this.userIDComboBox.FormattingEnabled = true;
            this.userIDComboBox.Location = new System.Drawing.Point(707, 172);
            this.userIDComboBox.Name = "userIDComboBox";
            this.userIDComboBox.Size = new System.Drawing.Size(118, 39);
            this.userIDComboBox.TabIndex = 15;
            // 
            // tblProductBindingSource1
            // 
            this.tblProductBindingSource1.DataMember = "tblProduct";
            this.tblProductBindingSource1.DataSource = this.sample_ProjectsDataSet;
            // 
            // tblUserBindingSource
            // 
            this.tblUserBindingSource.DataMember = "tblUser";
            this.tblUserBindingSource.DataSource = this.sample_ProjectsDataSet;
            // 
            // tblProductDataGridView
            // 
            this.tblProductDataGridView.AllowUserToAddRows = false;
            this.tblProductDataGridView.AllowUserToDeleteRows = false;
            this.tblProductDataGridView.AutoGenerateColumns = false;
            this.tblProductDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tblProductDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblProductDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn7});
            this.tblProductDataGridView.DataSource = this.tblProductBindingSource;
            this.tblProductDataGridView.Location = new System.Drawing.Point(207, 151);
            this.tblProductDataGridView.Name = "tblProductDataGridView";
            this.tblProductDataGridView.ReadOnly = true;
            this.tblProductDataGridView.RowHeadersWidth = 51;
            this.tblProductDataGridView.RowTemplate.Height = 35;
            this.tblProductDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblProductDataGridView.Size = new System.Drawing.Size(1025, 285);
            this.tblProductDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ProductID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ProductID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ProductCode";
            this.dataGridViewTextBoxColumn2.HeaderText = "ProductCode";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ProductName";
            this.dataGridViewTextBoxColumn3.HeaderText = "ProductName";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "StockQty";
            this.dataGridViewTextBoxColumn4.HeaderText = "StockQty";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Last_PriceIN";
            this.dataGridViewTextBoxColumn5.HeaderText = "Last_PriceIN";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Last_PriceOUT";
            this.dataGridViewTextBoxColumn6.HeaderText = "Last_PriceOUT";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 130;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Disabled";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Disabled";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "UserID";
            this.dataGridViewTextBoxColumn7.HeaderText = "UserID";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 90;
            // 
            // tblProductTableAdapter
            // 
            this.tblProductTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblGenderTableAdapter = null;
            this.tableAdapterManager.tblProductTableAdapter = this.tblProductTableAdapter;
            this.tableAdapterManager.tblStockTableAdapter = null;
            this.tableAdapterManager.tblSupplierTableAdapter = null;
            this.tableAdapterManager.tblUserTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = simple_project.Sample_ProjectsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Khmer OS Content", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(457, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(492, 80);
            this.label2.TabIndex = 8;
            this.label2.Text = "Products Management";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pictureBox1.Image = global::simple_project.Properties.Resources.Screenshot_2024_07_19_153403_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(12, 638);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tblUserTableAdapter
            // 
            this.tblUserTableAdapter.ClearBeforeFill = true;
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1244, 710);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tblProductDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Khmer OS Content", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "frmProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProduct";
            this.Load += new System.EventHandler(this.frmProduct_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sample_ProjectsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNew;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripTextBox tsbTextSearch;
        private System.Windows.Forms.ToolStripButton tsbSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private Sample_ProjectsDataSet sample_ProjectsDataSet;
        private System.Windows.Forms.BindingSource tblProductBindingSource;
        private Sample_ProjectsDataSetTableAdapters.tblProductTableAdapter tblProductTableAdapter;
        private Sample_ProjectsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox productIDTextBox;
        private System.Windows.Forms.TextBox productCodeTextBox;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.TextBox stockQtyTextBox;
        private System.Windows.Forms.TextBox last_PriceINTextBox;
        private System.Windows.Forms.TextBox last_PriceOUTTextBox;
        private System.Windows.Forms.CheckBox disabledCheckBox;
        private System.Windows.Forms.ComboBox userIDComboBox;
        private System.Windows.Forms.DataGridView tblProductDataGridView;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.BindingSource tblUserBindingSource;
        private Sample_ProjectsDataSetTableAdapters.tblUserTableAdapter tblUserTableAdapter;
        private System.Windows.Forms.BindingSource tblProductBindingSource1;
    }
}