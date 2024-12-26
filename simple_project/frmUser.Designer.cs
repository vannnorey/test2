namespace simple_project
{
    partial class frmUser
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
            System.Windows.Forms.Label userIDLabel;
            System.Windows.Forms.Label userLabelLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label doBLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label usernameLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label userLevelLabel;
            System.Windows.Forms.Label disabledLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUser));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbSearch = new System.Windows.Forms.ToolStripButton();
            this.tsbTextSearch = new System.Windows.Forms.ToolStripTextBox();
            this.tsbNew = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.userIDTextBox = new System.Windows.Forms.TextBox();
            this.tblUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sample_ProjectsDataSet = new simple_project.Sample_ProjectsDataSet();
            this.userLabelTextBox = new System.Windows.Forms.TextBox();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.tblGenderBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.doBDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.userLevelComboBox = new System.Windows.Forms.ComboBox();
            this.disabledCheckBox = new System.Windows.Forms.CheckBox();
            this.tblUserTableAdapter = new simple_project.Sample_ProjectsDataSetTableAdapters.tblUserTableAdapter();
            this.tableAdapterManager = new simple_project.Sample_ProjectsDataSetTableAdapters.TableAdapterManager();
            this.tblGenderTableAdapter = new simple_project.Sample_ProjectsDataSetTableAdapters.tblGenderTableAdapter();
            this.tblGenderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.temp_UserGenderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.temp_UserGenderTableAdapter = new simple_project.Sample_ProjectsDataSetTableAdapters.temp_UserGenderTableAdapter();
            this.temp_UserGenderDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            userIDLabel = new System.Windows.Forms.Label();
            userLabelLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            doBLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            usernameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            userLevelLabel = new System.Windows.Forms.Label();
            disabledLabel = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sample_ProjectsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGenderBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGenderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temp_UserGenderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temp_UserGenderDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // userIDLabel
            // 
            userIDLabel.AutoSize = true;
            userIDLabel.Font = new System.Drawing.Font("Khmer OS Content", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            userIDLabel.ForeColor = System.Drawing.Color.Black;
            userIDLabel.Location = new System.Drawing.Point(4, 46);
            userIDLabel.Name = "userIDLabel";
            userIDLabel.Size = new System.Drawing.Size(97, 36);
            userIDLabel.TabIndex = 0;
            userIDLabel.Text = "User ID:";
            // 
            // userLabelLabel
            // 
            userLabelLabel.AutoSize = true;
            userLabelLabel.Font = new System.Drawing.Font("Khmer OS Content", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            userLabelLabel.ForeColor = System.Drawing.Color.Black;
            userLabelLabel.Location = new System.Drawing.Point(4, 97);
            userLabelLabel.Name = "userLabelLabel";
            userLabelLabel.Size = new System.Drawing.Size(128, 36);
            userLabelLabel.TabIndex = 2;
            userLabelLabel.Text = "User Label:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Font = new System.Drawing.Font("Khmer OS Content", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            genderLabel.ForeColor = System.Drawing.Color.Black;
            genderLabel.Location = new System.Drawing.Point(7, 204);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(95, 36);
            genderLabel.TabIndex = 4;
            genderLabel.Text = "Gender:";
            genderLabel.Click += new System.EventHandler(this.genderLabel_Click);
            // 
            // doBLabel
            // 
            doBLabel.AutoSize = true;
            doBLabel.Font = new System.Drawing.Font("Khmer OS Content", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            doBLabel.ForeColor = System.Drawing.Color.Black;
            doBLabel.Location = new System.Drawing.Point(4, 264);
            doBLabel.Name = "doBLabel";
            doBLabel.Size = new System.Drawing.Size(68, 36);
            doBLabel.TabIndex = 6;
            doBLabel.Text = "DOB:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new System.Drawing.Font("Khmer OS Content", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            phoneLabel.ForeColor = System.Drawing.Color.Black;
            phoneLabel.Location = new System.Drawing.Point(4, 323);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(84, 36);
            phoneLabel.TabIndex = 8;
            phoneLabel.Text = "Phone:";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new System.Drawing.Font("Khmer OS Content", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            usernameLabel.ForeColor = System.Drawing.Color.Black;
            usernameLabel.Location = new System.Drawing.Point(4, 148);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(121, 36);
            usernameLabel.TabIndex = 10;
            usernameLabel.Text = "Username:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new System.Drawing.Font("Khmer OS Content", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            passwordLabel.ForeColor = System.Drawing.Color.Black;
            passwordLabel.Location = new System.Drawing.Point(4, 383);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(117, 36);
            passwordLabel.TabIndex = 12;
            passwordLabel.Text = "Password:";
            // 
            // userLevelLabel
            // 
            userLevelLabel.AutoSize = true;
            userLevelLabel.Font = new System.Drawing.Font("Khmer OS Content", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            userLevelLabel.ForeColor = System.Drawing.Color.Black;
            userLevelLabel.Location = new System.Drawing.Point(7, 446);
            userLevelLabel.Name = "userLevelLabel";
            userLevelLabel.Size = new System.Drawing.Size(127, 36);
            userLevelLabel.TabIndex = 14;
            userLevelLabel.Text = "User Level:";
            // 
            // disabledLabel
            // 
            disabledLabel.AutoSize = true;
            disabledLabel.Font = new System.Drawing.Font("Khmer OS Content", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            disabledLabel.ForeColor = System.Drawing.Color.Black;
            disabledLabel.Location = new System.Drawing.Point(7, 488);
            disabledLabel.Name = "disabledLabel";
            disabledLabel.Size = new System.Drawing.Size(106, 36);
            disabledLabel.TabIndex = 16;
            disabledLabel.Text = "Disabled:";
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
            this.tsbDelete});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(185, 719);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // tsbSearch
            // 
            this.tsbSearch.Font = new System.Drawing.Font("Khmer OS Content", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbSearch.Image = ((System.Drawing.Image)(resources.GetObject("tsbSearch.Image")));
            this.tsbSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsbSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSearch.Name = "tsbSearch";
            this.tsbSearch.Size = new System.Drawing.Size(183, 40);
            this.tsbSearch.Text = "Search";
            this.tsbSearch.Click += new System.EventHandler(this.tsbSearch_Click);
            // 
            // tsbTextSearch
            // 
            this.tsbTextSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tsbTextSearch.Font = new System.Drawing.Font("Khmer OS Content", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbTextSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tsbTextSearch.Name = "tsbTextSearch";
            this.tsbTextSearch.Size = new System.Drawing.Size(181, 38);
            this.tsbTextSearch.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tsbTextSearch.ToolTipText = "search";
            this.tsbTextSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tsbTextSearch_KeyDown);
            this.tsbTextSearch.Click += new System.EventHandler(this.tsbTextSearch_Click);
            // 
            // tsbNew
            // 
            this.tsbNew.Font = new System.Drawing.Font("Khmer OS Content", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbNew.Image = ((System.Drawing.Image)(resources.GetObject("tsbNew.Image")));
            this.tsbNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNew.Name = "tsbNew";
            this.tsbNew.Size = new System.Drawing.Size(183, 45);
            this.tsbNew.Text = "New";
            this.tsbNew.Click += new System.EventHandler(this.tsbNew_Click);
            // 
            // tsbSave
            // 
            this.tsbSave.Font = new System.Drawing.Font("Khmer OS Content", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(183, 45);
            this.tsbSave.Text = "Save";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.Font = new System.Drawing.Font("Khmer OS Content", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbDelete.ForeColor = System.Drawing.Color.Black;
            this.tsbDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelete.Image")));
            this.tsbDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(183, 45);
            this.tsbDelete.Text = "Delete";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox1.Controls.Add(userIDLabel);
            this.groupBox1.Controls.Add(this.userIDTextBox);
            this.groupBox1.Controls.Add(userLabelLabel);
            this.groupBox1.Controls.Add(this.userLabelTextBox);
            this.groupBox1.Controls.Add(genderLabel);
            this.groupBox1.Controls.Add(this.genderComboBox);
            this.groupBox1.Controls.Add(doBLabel);
            this.groupBox1.Controls.Add(this.doBDateTimePicker);
            this.groupBox1.Controls.Add(phoneLabel);
            this.groupBox1.Controls.Add(this.phoneTextBox);
            this.groupBox1.Controls.Add(usernameLabel);
            this.groupBox1.Controls.Add(this.usernameTextBox);
            this.groupBox1.Controls.Add(passwordLabel);
            this.groupBox1.Controls.Add(this.passwordTextBox);
            this.groupBox1.Controls.Add(userLevelLabel);
            this.groupBox1.Controls.Add(this.userLevelComboBox);
            this.groupBox1.Controls.Add(disabledLabel);
            this.groupBox1.Controls.Add(this.disabledCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(201, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 532);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // userIDTextBox
            // 
            this.userIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUserBindingSource, "UserID", true));
            this.userIDTextBox.Font = new System.Drawing.Font("Khmer OS Content", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIDTextBox.Location = new System.Drawing.Point(141, 46);
            this.userIDTextBox.Name = "userIDTextBox";
            this.userIDTextBox.Size = new System.Drawing.Size(267, 45);
            this.userIDTextBox.TabIndex = 1;
            // 
            // tblUserBindingSource
            // 
            this.tblUserBindingSource.DataMember = "tblUser";
            this.tblUserBindingSource.DataSource = this.sample_ProjectsDataSet;
            // 
            // sample_ProjectsDataSet
            // 
            this.sample_ProjectsDataSet.DataSetName = "Sample_ProjectsDataSet";
            this.sample_ProjectsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userLabelTextBox
            // 
            this.userLabelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUserBindingSource, "UserLabel", true));
            this.userLabelTextBox.Font = new System.Drawing.Font("Khmer OS Content", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabelTextBox.Location = new System.Drawing.Point(141, 97);
            this.userLabelTextBox.Name = "userLabelTextBox";
            this.userLabelTextBox.Size = new System.Drawing.Size(267, 45);
            this.userLabelTextBox.TabIndex = 3;
            // 
            // genderComboBox
            // 
            this.genderComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tblUserBindingSource, "Gender", true));
            this.genderComboBox.DataSource = this.tblGenderBindingSource1;
            this.genderComboBox.DisplayMember = "Gender_En";
            this.genderComboBox.Font = new System.Drawing.Font("Khmer OS Content", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Location = new System.Drawing.Point(141, 199);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(267, 44);
            this.genderComboBox.TabIndex = 5;
            this.genderComboBox.ValueMember = "GenderID";
            // 
            // tblGenderBindingSource1
            // 
            this.tblGenderBindingSource1.DataMember = "tblGender";
            this.tblGenderBindingSource1.DataSource = this.sample_ProjectsDataSet;
            // 
            // doBDateTimePicker
            // 
            this.doBDateTimePicker.CustomFormat = "dd-MMMM-yyyy";
            this.doBDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUserBindingSource, "DoB", true));
            this.doBDateTimePicker.Font = new System.Drawing.Font("Khmer OS Content", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doBDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.doBDateTimePicker.Location = new System.Drawing.Point(141, 263);
            this.doBDateTimePicker.Name = "doBDateTimePicker";
            this.doBDateTimePicker.Size = new System.Drawing.Size(267, 45);
            this.doBDateTimePicker.TabIndex = 7;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUserBindingSource, "Phone", true));
            this.phoneTextBox.Font = new System.Drawing.Font("Khmer OS Content", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTextBox.Location = new System.Drawing.Point(141, 323);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(267, 45);
            this.phoneTextBox.TabIndex = 9;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUserBindingSource, "Username", true));
            this.usernameTextBox.Font = new System.Drawing.Font("Khmer OS Content", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.Location = new System.Drawing.Point(141, 148);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(267, 45);
            this.usernameTextBox.TabIndex = 11;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUserBindingSource, "Password", true));
            this.passwordTextBox.Font = new System.Drawing.Font("Khmer OS Content", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(141, 383);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(267, 45);
            this.passwordTextBox.TabIndex = 13;
            // 
            // userLevelComboBox
            // 
            this.userLevelComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUserBindingSource, "UserLevel", true));
            this.userLevelComboBox.Font = new System.Drawing.Font("Khmer OS Content", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLevelComboBox.FormattingEnabled = true;
            this.userLevelComboBox.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.userLevelComboBox.Location = new System.Drawing.Point(141, 446);
            this.userLevelComboBox.Name = "userLevelComboBox";
            this.userLevelComboBox.Size = new System.Drawing.Size(130, 44);
            this.userLevelComboBox.TabIndex = 15;
            // 
            // disabledCheckBox
            // 
            this.disabledCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tblUserBindingSource, "Disabled", true));
            this.disabledCheckBox.Font = new System.Drawing.Font("Khmer OS Content", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disabledCheckBox.Location = new System.Drawing.Point(141, 496);
            this.disabledCheckBox.Name = "disabledCheckBox";
            this.disabledCheckBox.Size = new System.Drawing.Size(27, 33);
            this.disabledCheckBox.TabIndex = 17;
            this.disabledCheckBox.UseVisualStyleBackColor = true;
            // 
            // tblUserTableAdapter
            // 
            this.tblUserTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblGenderTableAdapter = this.tblGenderTableAdapter;
            this.tableAdapterManager.tblProductTableAdapter = null;
            this.tableAdapterManager.tblStockTableAdapter = null;
            this.tableAdapterManager.tblSupplierTableAdapter = null;
            this.tableAdapterManager.tblUserTableAdapter = this.tblUserTableAdapter;
            this.tableAdapterManager.UpdateOrder = simple_project.Sample_ProjectsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblGenderTableAdapter
            // 
            this.tblGenderTableAdapter.ClearBeforeFill = true;
            // 
            // tblGenderBindingSource
            // 
            this.tblGenderBindingSource.DataMember = "tblGender";
            this.tblGenderBindingSource.DataSource = this.sample_ProjectsDataSet;
            // 
            // temp_UserGenderBindingSource
            // 
            this.temp_UserGenderBindingSource.DataMember = "temp_UserGender";
            this.temp_UserGenderBindingSource.DataSource = this.sample_ProjectsDataSet;
            // 
            // temp_UserGenderTableAdapter
            // 
            this.temp_UserGenderTableAdapter.ClearBeforeFill = true;
            // 
            // temp_UserGenderDataGridView
            // 
            this.temp_UserGenderDataGridView.AllowUserToAddRows = false;
            this.temp_UserGenderDataGridView.AllowUserToDeleteRows = false;
            this.temp_UserGenderDataGridView.AutoGenerateColumns = false;
            this.temp_UserGenderDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.temp_UserGenderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.temp_UserGenderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewCheckBoxColumn1});
            this.temp_UserGenderDataGridView.DataSource = this.temp_UserGenderBindingSource;
            this.temp_UserGenderDataGridView.Location = new System.Drawing.Point(626, 116);
            this.temp_UserGenderDataGridView.Name = "temp_UserGenderDataGridView";
            this.temp_UserGenderDataGridView.ReadOnly = true;
            this.temp_UserGenderDataGridView.RowHeadersWidth = 10;
            this.temp_UserGenderDataGridView.RowTemplate.Height = 35;
            this.temp_UserGenderDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.temp_UserGenderDataGridView.Size = new System.Drawing.Size(580, 552);
            this.temp_UserGenderDataGridView.TabIndex = 3;
            this.temp_UserGenderDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.temp_UserGenderDataGridView_CellContentClick);
            this.temp_UserGenderDataGridView.Click += new System.EventHandler(this.temp_UserGenderDataGridView_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "UserID";
            this.dataGridViewTextBoxColumn1.HeaderText = "UserID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 65;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "UserLabel";
            this.dataGridViewTextBoxColumn2.HeaderText = "UserLabel";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 90;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Gender_En_Full";
            this.dataGridViewTextBoxColumn3.HeaderText = "Gender_En_Full";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 68;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DoB";
            this.dataGridViewTextBoxColumn4.HeaderText = "DoB";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn5.HeaderText = "Phone";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Username";
            this.dataGridViewTextBoxColumn6.HeaderText = "Username";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 95;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Password";
            this.dataGridViewTextBoxColumn7.HeaderText = "Password";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "UserLevel";
            this.dataGridViewTextBoxColumn8.HeaderText = "UserLevel";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 125;
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
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(53, 672);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(54, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(185, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1027, 719);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1212, 719);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.temp_UserGenderDataGridView);
            this.Font = new System.Drawing.Font("Khmer OS Content", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "frmUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUser";
            this.Load += new System.EventHandler(this.frmUser_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sample_ProjectsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGenderBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGenderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temp_UserGenderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temp_UserGenderDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.BindingSource tblUserBindingSource;
        private Sample_ProjectsDataSetTableAdapters.tblUserTableAdapter tblUserTableAdapter;
        private Sample_ProjectsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox userIDTextBox;
        private System.Windows.Forms.TextBox userLabelTextBox;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.DateTimePicker doBDateTimePicker;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.ComboBox userLevelComboBox;
        private System.Windows.Forms.CheckBox disabledCheckBox;
        private Sample_ProjectsDataSetTableAdapters.tblGenderTableAdapter tblGenderTableAdapter;
        private System.Windows.Forms.BindingSource tblGenderBindingSource;
        private System.Windows.Forms.BindingSource tblGenderBindingSource1;
        private System.Windows.Forms.BindingSource temp_UserGenderBindingSource;
        private Sample_ProjectsDataSetTableAdapters.temp_UserGenderTableAdapter temp_UserGenderTableAdapter;
        private System.Windows.Forms.DataGridView temp_UserGenderDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}