namespace simple_project
{
    partial class frmStock
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
            System.Windows.Forms.Label stockIDLabel;
            System.Windows.Forms.Label productIDLabel;
            System.Windows.Forms.Label stockDateLabel;
            System.Windows.Forms.Label qtyLabel;
            System.Windows.Forms.Label priceINLabel;
            System.Windows.Forms.Label priceOUTLabel;
            System.Windows.Forms.Label supplierIDLabel;
            System.Windows.Forms.Label userIDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStock));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNew = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.userIDComboBox = new System.Windows.Forms.ComboBox();
            this.tblStockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sample_ProjectsDataSet = new simple_project.Sample_ProjectsDataSet();
            this.tblStockBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.stockIDTextBox = new System.Windows.Forms.TextBox();
            this.productIDComboBox = new System.Windows.Forms.ComboBox();
            this.tblProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.qtyTextBox = new System.Windows.Forms.TextBox();
            this.priceINTextBox = new System.Windows.Forms.TextBox();
            this.priceOUTTextBox = new System.Windows.Forms.TextBox();
            this.supplierIDComboBox = new System.Windows.Forms.ComboBox();
            this.tblSupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblStockTableAdapter = new simple_project.Sample_ProjectsDataSetTableAdapters.tblStockTableAdapter();
            this.tableAdapterManager = new simple_project.Sample_ProjectsDataSetTableAdapters.TableAdapterManager();
            this.tblStockDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblProductTableAdapter = new simple_project.Sample_ProjectsDataSetTableAdapters.tblProductTableAdapter();
            this.tblSupplierTableAdapter = new simple_project.Sample_ProjectsDataSetTableAdapters.tblSupplierTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            stockIDLabel = new System.Windows.Forms.Label();
            productIDLabel = new System.Windows.Forms.Label();
            stockDateLabel = new System.Windows.Forms.Label();
            qtyLabel = new System.Windows.Forms.Label();
            priceINLabel = new System.Windows.Forms.Label();
            priceOUTLabel = new System.Windows.Forms.Label();
            supplierIDLabel = new System.Windows.Forms.Label();
            userIDLabel = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblStockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sample_ProjectsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStockBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSupplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStockDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // stockIDLabel
            // 
            stockIDLabel.AutoSize = true;
            stockIDLabel.Font = new System.Drawing.Font("Khmer OS Content", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            stockIDLabel.ForeColor = System.Drawing.Color.SteelBlue;
            stockIDLabel.Location = new System.Drawing.Point(17, 48);
            stockIDLabel.Name = "stockIDLabel";
            stockIDLabel.Size = new System.Drawing.Size(106, 36);
            stockIDLabel.TabIndex = 0;
            stockIDLabel.Text = "Stock ID:";
            // 
            // productIDLabel
            // 
            productIDLabel.AutoSize = true;
            productIDLabel.Font = new System.Drawing.Font("Khmer OS Content", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            productIDLabel.ForeColor = System.Drawing.Color.SteelBlue;
            productIDLabel.Location = new System.Drawing.Point(17, 93);
            productIDLabel.Name = "productIDLabel";
            productIDLabel.Size = new System.Drawing.Size(127, 36);
            productIDLabel.TabIndex = 2;
            productIDLabel.Text = "Product ID:";
            // 
            // stockDateLabel
            // 
            stockDateLabel.AutoSize = true;
            stockDateLabel.Font = new System.Drawing.Font("Khmer OS Content", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            stockDateLabel.ForeColor = System.Drawing.Color.SteelBlue;
            stockDateLabel.Location = new System.Drawing.Point(17, 139);
            stockDateLabel.Name = "stockDateLabel";
            stockDateLabel.Size = new System.Drawing.Size(130, 36);
            stockDateLabel.TabIndex = 4;
            stockDateLabel.Text = "Stock Date:";
            // 
            // qtyLabel
            // 
            qtyLabel.AutoSize = true;
            qtyLabel.Font = new System.Drawing.Font("Khmer OS Content", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            qtyLabel.ForeColor = System.Drawing.Color.SteelBlue;
            qtyLabel.Location = new System.Drawing.Point(17, 183);
            qtyLabel.Name = "qtyLabel";
            qtyLabel.Size = new System.Drawing.Size(57, 36);
            qtyLabel.TabIndex = 6;
            qtyLabel.Text = "Qty:";
            // 
            // priceINLabel
            // 
            priceINLabel.AutoSize = true;
            priceINLabel.Font = new System.Drawing.Font("Khmer OS Content", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            priceINLabel.ForeColor = System.Drawing.Color.SteelBlue;
            priceINLabel.Location = new System.Drawing.Point(462, 52);
            priceINLabel.Name = "priceINLabel";
            priceINLabel.Size = new System.Drawing.Size(101, 36);
            priceINLabel.TabIndex = 8;
            priceINLabel.Text = "Price IN:";
            // 
            // priceOUTLabel
            // 
            priceOUTLabel.AutoSize = true;
            priceOUTLabel.Font = new System.Drawing.Font("Khmer OS Content", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            priceOUTLabel.ForeColor = System.Drawing.Color.SteelBlue;
            priceOUTLabel.Location = new System.Drawing.Point(462, 97);
            priceOUTLabel.Name = "priceOUTLabel";
            priceOUTLabel.Size = new System.Drawing.Size(124, 36);
            priceOUTLabel.TabIndex = 10;
            priceOUTLabel.Text = "Price OUT:";
            // 
            // supplierIDLabel
            // 
            supplierIDLabel.AutoSize = true;
            supplierIDLabel.Font = new System.Drawing.Font("Khmer OS Content", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            supplierIDLabel.ForeColor = System.Drawing.Color.SteelBlue;
            supplierIDLabel.Location = new System.Drawing.Point(462, 142);
            supplierIDLabel.Name = "supplierIDLabel";
            supplierIDLabel.Size = new System.Drawing.Size(131, 36);
            supplierIDLabel.TabIndex = 12;
            supplierIDLabel.Text = "Supplier ID:";
            // 
            // userIDLabel
            // 
            userIDLabel.AutoSize = true;
            userIDLabel.Font = new System.Drawing.Font("Khmer OS Content", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            userIDLabel.ForeColor = System.Drawing.Color.SteelBlue;
            userIDLabel.Location = new System.Drawing.Point(462, 187);
            userIDLabel.Name = "userIDLabel";
            userIDLabel.Size = new System.Drawing.Size(97, 36);
            userIDLabel.TabIndex = 14;
            userIDLabel.Text = "User ID:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.Font = new System.Drawing.Font("Khmer OS Content", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNew,
            this.tsbSave,
            this.tsbDelete,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(199, 699);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbNew
            // 
            this.tsbNew.Font = new System.Drawing.Font("Khmer OS Content", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbNew.Image = ((System.Drawing.Image)(resources.GetObject("tsbNew.Image")));
            this.tsbNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNew.Name = "tsbNew";
            this.tsbNew.Size = new System.Drawing.Size(197, 45);
            this.tsbNew.Text = "New";
            this.tsbNew.Click += new System.EventHandler(this.tsbNew_Click);
            // 
            // tsbSave
            // 
            this.tsbSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tsbSave.Font = new System.Drawing.Font("Khmer OS Content", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(197, 45);
            this.tsbSave.Text = "Save";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tsbDelete.Font = new System.Drawing.Font("Khmer OS Content", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelete.Image")));
            this.tsbDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(197, 45);
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
            this.toolStripButton1.Size = new System.Drawing.Size(197, 40);
            this.toolStripButton1.Text = "ReportStock";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.userIDComboBox);
            this.groupBox1.Controls.Add(stockIDLabel);
            this.groupBox1.Controls.Add(this.stockIDTextBox);
            this.groupBox1.Controls.Add(productIDLabel);
            this.groupBox1.Controls.Add(this.productIDComboBox);
            this.groupBox1.Controls.Add(stockDateLabel);
            this.groupBox1.Controls.Add(this.stockDateDateTimePicker);
            this.groupBox1.Controls.Add(qtyLabel);
            this.groupBox1.Controls.Add(this.qtyTextBox);
            this.groupBox1.Controls.Add(priceINLabel);
            this.groupBox1.Controls.Add(this.priceINTextBox);
            this.groupBox1.Controls.Add(priceOUTLabel);
            this.groupBox1.Controls.Add(this.priceOUTTextBox);
            this.groupBox1.Controls.Add(supplierIDLabel);
            this.groupBox1.Controls.Add(this.supplierIDComboBox);
            this.groupBox1.Controls.Add(userIDLabel);
            this.groupBox1.Location = new System.Drawing.Point(227, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(926, 262);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // userIDComboBox
            // 
            this.userIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tblStockBindingSource, "UserID", true));
            this.userIDComboBox.FormattingEnabled = true;
            this.userIDComboBox.Location = new System.Drawing.Point(600, 187);
            this.userIDComboBox.Name = "userIDComboBox";
            this.userIDComboBox.Size = new System.Drawing.Size(284, 39);
            this.userIDComboBox.TabIndex = 15;
            // 
            // tblStockBindingSource
            // 
            this.tblStockBindingSource.DataMember = "tblStock";
            this.tblStockBindingSource.DataSource = this.sample_ProjectsDataSet;
            // 
            // sample_ProjectsDataSet
            // 
            this.sample_ProjectsDataSet.DataSetName = "Sample_ProjectsDataSet";
            this.sample_ProjectsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblStockBindingSource1
            // 
            this.tblStockBindingSource1.DataMember = "tblStock";
            this.tblStockBindingSource1.DataSource = this.sample_ProjectsDataSet;
            // 
            // stockIDTextBox
            // 
            this.stockIDTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.stockIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblStockBindingSource, "StockID", true));
            this.stockIDTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.stockIDTextBox.Location = new System.Drawing.Point(155, 46);
            this.stockIDTextBox.Name = "stockIDTextBox";
            this.stockIDTextBox.ReadOnly = true;
            this.stockIDTextBox.Size = new System.Drawing.Size(283, 39);
            this.stockIDTextBox.TabIndex = 1;
            // 
            // productIDComboBox
            // 
            this.productIDComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.productIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tblStockBindingSource, "ProductID", true));
            this.productIDComboBox.DataSource = this.tblProductBindingSource;
            this.productIDComboBox.DisplayMember = "ProductName";
            this.productIDComboBox.Enabled = false;
            this.productIDComboBox.ForeColor = System.Drawing.SystemColors.Window;
            this.productIDComboBox.FormattingEnabled = true;
            this.productIDComboBox.Location = new System.Drawing.Point(155, 91);
            this.productIDComboBox.Name = "productIDComboBox";
            this.productIDComboBox.Size = new System.Drawing.Size(283, 39);
            this.productIDComboBox.TabIndex = 3;
            this.productIDComboBox.ValueMember = "ProductID";
            // 
            // tblProductBindingSource
            // 
            this.tblProductBindingSource.DataMember = "tblProduct";
            this.tblProductBindingSource.DataSource = this.sample_ProjectsDataSet;
            // 
            // stockDateDateTimePicker
            // 
            this.stockDateDateTimePicker.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.stockDateDateTimePicker.CustomFormat = "dd-MMMM-yyyy";
            this.stockDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblStockBindingSource, "StockDate", true));
            this.stockDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.stockDateDateTimePicker.Location = new System.Drawing.Point(155, 136);
            this.stockDateDateTimePicker.Name = "stockDateDateTimePicker";
            this.stockDateDateTimePicker.Size = new System.Drawing.Size(283, 39);
            this.stockDateDateTimePicker.TabIndex = 5;
            // 
            // qtyTextBox
            // 
            this.qtyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblStockBindingSource, "Qty", true));
            this.qtyTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.qtyTextBox.Location = new System.Drawing.Point(155, 181);
            this.qtyTextBox.Name = "qtyTextBox";
            this.qtyTextBox.Size = new System.Drawing.Size(283, 39);
            this.qtyTextBox.TabIndex = 7;
            // 
            // priceINTextBox
            // 
            this.priceINTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblStockBindingSource, "PriceIN", true));
            this.priceINTextBox.Location = new System.Drawing.Point(600, 49);
            this.priceINTextBox.Name = "priceINTextBox";
            this.priceINTextBox.Size = new System.Drawing.Size(284, 39);
            this.priceINTextBox.TabIndex = 9;
            // 
            // priceOUTTextBox
            // 
            this.priceOUTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblStockBindingSource, "PriceOUT", true));
            this.priceOUTTextBox.Location = new System.Drawing.Point(600, 94);
            this.priceOUTTextBox.Name = "priceOUTTextBox";
            this.priceOUTTextBox.Size = new System.Drawing.Size(284, 39);
            this.priceOUTTextBox.TabIndex = 11;
            // 
            // supplierIDComboBox
            // 
            this.supplierIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tblStockBindingSource, "SupplierID", true));
            this.supplierIDComboBox.DataSource = this.tblSupplierBindingSource;
            this.supplierIDComboBox.DisplayMember = "SupplierName";
            this.supplierIDComboBox.FormattingEnabled = true;
            this.supplierIDComboBox.Location = new System.Drawing.Point(600, 139);
            this.supplierIDComboBox.Name = "supplierIDComboBox";
            this.supplierIDComboBox.Size = new System.Drawing.Size(284, 39);
            this.supplierIDComboBox.TabIndex = 13;
            this.supplierIDComboBox.ValueMember = "SupplierID";
            this.supplierIDComboBox.SelectedIndexChanged += new System.EventHandler(this.supplierIDComboBox_SelectedIndexChanged);
            // 
            // tblSupplierBindingSource
            // 
            this.tblSupplierBindingSource.DataMember = "tblSupplier";
            this.tblSupplierBindingSource.DataSource = this.sample_ProjectsDataSet;
            // 
            // tblStockTableAdapter
            // 
            this.tblStockTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblGenderTableAdapter = null;
            this.tableAdapterManager.tblProductTableAdapter = null;
            this.tableAdapterManager.tblStockTableAdapter = this.tblStockTableAdapter;
            this.tableAdapterManager.tblSupplierTableAdapter = null;
            this.tableAdapterManager.tblUserTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = simple_project.Sample_ProjectsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblStockDataGridView
            // 
            this.tblStockDataGridView.AllowUserToAddRows = false;
            this.tblStockDataGridView.AllowUserToDeleteRows = false;
            this.tblStockDataGridView.AutoGenerateColumns = false;
            this.tblStockDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tblStockDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblStockDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.tblStockDataGridView.DataSource = this.tblStockBindingSource;
            this.tblStockDataGridView.Location = new System.Drawing.Point(227, 381);
            this.tblStockDataGridView.Name = "tblStockDataGridView";
            this.tblStockDataGridView.ReadOnly = true;
            this.tblStockDataGridView.RowHeadersWidth = 51;
            this.tblStockDataGridView.RowTemplate.Height = 32;
            this.tblStockDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblStockDataGridView.Size = new System.Drawing.Size(926, 318);
            this.tblStockDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "StockID";
            this.dataGridViewTextBoxColumn1.HeaderText = "StockID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "StockDate";
            this.dataGridViewTextBoxColumn3.HeaderText = "StockDate";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Qty";
            this.dataGridViewTextBoxColumn4.HeaderText = "Qty";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PriceIN";
            this.dataGridViewTextBoxColumn5.HeaderText = "PriceIN";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "PriceOUT";
            this.dataGridViewTextBoxColumn6.HeaderText = "PriceOUT";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "SupplierID";
            this.dataGridViewTextBoxColumn7.HeaderText = "SupplierID";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "UserID";
            this.dataGridViewTextBoxColumn8.HeaderText = "UserID";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // tblProductTableAdapter
            // 
            this.tblProductTableAdapter.ClearBeforeFill = true;
            // 
            // tblSupplierTableAdapter
            // 
            this.tblSupplierTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Khmer OS Content", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(450, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(450, 80);
            this.label2.TabIndex = 7;
            this.label2.Text = "Stock Management";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pictureBox1.Image = global::simple_project.Properties.Resources.Screenshot_2024_07_19_153403_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(12, 657);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1193, 699);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tblStockDataGridView);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Khmer OS Content", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "frmStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmStock";
            this.Load += new System.EventHandler(this.frmStock_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblStockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sample_ProjectsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStockBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSupplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStockDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripButton tsbNew;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private Sample_ProjectsDataSet sample_ProjectsDataSet;
        private System.Windows.Forms.BindingSource tblStockBindingSource;
        private Sample_ProjectsDataSetTableAdapters.tblStockTableAdapter tblStockTableAdapter;
        private Sample_ProjectsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox stockIDTextBox;
        private System.Windows.Forms.ComboBox productIDComboBox;
        private System.Windows.Forms.DateTimePicker stockDateDateTimePicker;
        private System.Windows.Forms.TextBox qtyTextBox;
        private System.Windows.Forms.TextBox priceINTextBox;
        private System.Windows.Forms.TextBox priceOUTTextBox;
        private System.Windows.Forms.ComboBox supplierIDComboBox;
        private System.Windows.Forms.DataGridView tblStockDataGridView;
        private System.Windows.Forms.BindingSource tblProductBindingSource;
        private Sample_ProjectsDataSetTableAdapters.tblProductTableAdapter tblProductTableAdapter;
        private System.Windows.Forms.BindingSource tblSupplierBindingSource;
        private Sample_ProjectsDataSetTableAdapters.tblSupplierTableAdapter tblSupplierTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ComboBox userIDComboBox;
        private System.Windows.Forms.BindingSource tblStockBindingSource1;
    }
}