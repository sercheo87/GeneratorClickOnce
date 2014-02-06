namespace UtilVersioningCO.UI.forms
{
    partial class fr_preferences
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
            System.Windows.Forms.Label pathInstallerLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fr_preferences));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpGeneral = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txTemplateSql = new System.Windows.Forms.TextBox();
            this.gbGeneral = new System.Windows.Forms.GroupBox();
            this.cbVersionDll = new System.Windows.Forms.CheckBox();
            this.txFolderInstaller = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txFolderProjects = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbZip = new System.Windows.Forms.CheckBox();
            this.txFolderSql = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txFolderClickOnce = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txFolderOut = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tpProjects = new System.Windows.Forms.TabPage();
            this.tbProjInstallerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.tbProjInstallerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectsDs = new UtilVersioningCO.UI.ProjectsDs();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbProjInstallerBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.pathInstallerTextBox = new System.Windows.Forms.TextBox();
            this.tbProjInstallerDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbProjectName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.fbdGetFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.fdFindProjectsInstallers = new System.Windows.Forms.OpenFileDialog();
            this.cbVersionIncrement = new System.Windows.Forms.CheckBox();
            pathInstallerLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tpGeneral.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbGeneral.SuspendLayout();
            this.tpProjects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbProjInstallerBindingNavigator)).BeginInit();
            this.tbProjInstallerBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbProjInstallerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsDs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProjInstallerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pathInstallerLabel
            // 
            pathInstallerLabel.AutoSize = true;
            pathInstallerLabel.Location = new System.Drawing.Point(6, 71);
            pathInstallerLabel.Name = "pathInstallerLabel";
            pathInstallerLabel.Size = new System.Drawing.Size(71, 13);
            pathInstallerLabel.TabIndex = 5;
            pathInstallerLabel.Text = "Path Installer:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpGeneral);
            this.tabControl1.Controls.Add(this.tpProjects);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(432, 377);
            this.tabControl1.TabIndex = 0;
            // 
            // tpGeneral
            // 
            this.tpGeneral.Controls.Add(this.groupBox1);
            this.tpGeneral.Controls.Add(this.gbGeneral);
            this.tpGeneral.Location = new System.Drawing.Point(4, 22);
            this.tpGeneral.Name = "tpGeneral";
            this.tpGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tpGeneral.Size = new System.Drawing.Size(424, 351);
            this.tpGeneral.TabIndex = 0;
            this.tpGeneral.Text = "General";
            this.tpGeneral.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btSave);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txTemplateSql);
            this.groupBox1.Location = new System.Drawing.Point(9, 223);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 120);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Templates";
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(325, 88);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 8;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Templates SQL Scripts for update version";
            // 
            // txTemplateSql
            // 
            this.txTemplateSql.Location = new System.Drawing.Point(8, 32);
            this.txTemplateSql.Multiline = true;
            this.txTemplateSql.Name = "txTemplateSql";
            this.txTemplateSql.Size = new System.Drawing.Size(393, 49);
            this.txTemplateSql.TabIndex = 0;
            // 
            // gbGeneral
            // 
            this.gbGeneral.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbGeneral.Controls.Add(this.cbVersionIncrement);
            this.gbGeneral.Controls.Add(this.cbVersionDll);
            this.gbGeneral.Controls.Add(this.txFolderInstaller);
            this.gbGeneral.Controls.Add(this.label8);
            this.gbGeneral.Controls.Add(this.txFolderProjects);
            this.gbGeneral.Controls.Add(this.label7);
            this.gbGeneral.Controls.Add(this.cbZip);
            this.gbGeneral.Controls.Add(this.txFolderSql);
            this.gbGeneral.Controls.Add(this.label3);
            this.gbGeneral.Controls.Add(this.txFolderClickOnce);
            this.gbGeneral.Controls.Add(this.label2);
            this.gbGeneral.Controls.Add(this.txFolderOut);
            this.gbGeneral.Controls.Add(this.label1);
            this.gbGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbGeneral.Location = new System.Drawing.Point(7, 7);
            this.gbGeneral.Name = "gbGeneral";
            this.gbGeneral.Size = new System.Drawing.Size(409, 185);
            this.gbGeneral.TabIndex = 0;
            this.gbGeneral.TabStop = false;
            this.gbGeneral.Text = "General";
            // 
            // cbVersionDll
            // 
            this.cbVersionDll.AutoSize = true;
            this.cbVersionDll.Location = new System.Drawing.Point(104, 160);
            this.cbVersionDll.Name = "cbVersionDll";
            this.cbVersionDll.Size = new System.Drawing.Size(114, 17);
            this.cbVersionDll.TabIndex = 11;
            this.cbVersionDll.Text = "Update Version Dll";
            this.cbVersionDll.UseVisualStyleBackColor = true;
            // 
            // txFolderInstaller
            // 
            this.txFolderInstaller.Location = new System.Drawing.Point(104, 50);
            this.txFolderInstaller.Name = "txFolderInstaller";
            this.txFolderInstaller.Size = new System.Drawing.Size(299, 20);
            this.txFolderInstaller.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Folder Installer";
            // 
            // txFolderProjects
            // 
            this.txFolderProjects.Location = new System.Drawing.Point(104, 24);
            this.txFolderProjects.Name = "txFolderProjects";
            this.txFolderProjects.Size = new System.Drawing.Size(299, 20);
            this.txFolderProjects.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Folder Projects";
            // 
            // cbZip
            // 
            this.cbZip.AutoSize = true;
            this.cbZip.Location = new System.Drawing.Point(11, 160);
            this.cbZip.Name = "cbZip";
            this.cbZip.Size = new System.Drawing.Size(88, 17);
            this.cbZip.TabIndex = 6;
            this.cbZip.Text = "Generate Zip";
            this.cbZip.UseVisualStyleBackColor = true;
            // 
            // txFolderSql
            // 
            this.txFolderSql.Location = new System.Drawing.Point(116, 128);
            this.txFolderSql.Name = "txFolderSql";
            this.txFolderSql.Size = new System.Drawing.Size(288, 20);
            this.txFolderSql.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name Folder Scripts";
            // 
            // txFolderClickOnce
            // 
            this.txFolderClickOnce.Location = new System.Drawing.Point(136, 102);
            this.txFolderClickOnce.Name = "txFolderClickOnce";
            this.txFolderClickOnce.Size = new System.Drawing.Size(268, 20);
            this.txFolderClickOnce.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name Folder Click Once";
            // 
            // txFolderOut
            // 
            this.txFolderOut.Location = new System.Drawing.Point(71, 76);
            this.txFolderOut.Name = "txFolderOut";
            this.txFolderOut.Size = new System.Drawing.Size(291, 20);
            this.txFolderOut.TabIndex = 1;
            this.txFolderOut.DoubleClick += new System.EventHandler(this.txFolderOut_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Folder Out";
            // 
            // tpProjects
            // 
            this.tpProjects.AutoScroll = true;
            this.tpProjects.Controls.Add(this.tbProjInstallerBindingNavigator);
            this.tpProjects.Controls.Add(pathInstallerLabel);
            this.tpProjects.Controls.Add(this.pathInstallerTextBox);
            this.tpProjects.Controls.Add(this.tbProjInstallerDataGridView);
            this.tpProjects.Controls.Add(this.cbProjectName);
            this.tpProjects.Controls.Add(this.label5);
            this.tpProjects.Location = new System.Drawing.Point(4, 22);
            this.tpProjects.Name = "tpProjects";
            this.tpProjects.Padding = new System.Windows.Forms.Padding(3);
            this.tpProjects.Size = new System.Drawing.Size(424, 351);
            this.tpProjects.TabIndex = 1;
            this.tpProjects.Text = "Projects";
            this.tpProjects.UseVisualStyleBackColor = true;
            // 
            // tbProjInstallerBindingNavigator
            // 
            this.tbProjInstallerBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tbProjInstallerBindingNavigator.BindingSource = this.tbProjInstallerBindingSource;
            this.tbProjInstallerBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tbProjInstallerBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tbProjInstallerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tbProjInstallerBindingNavigatorSaveItem});
            this.tbProjInstallerBindingNavigator.Location = new System.Drawing.Point(3, 3);
            this.tbProjInstallerBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tbProjInstallerBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tbProjInstallerBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tbProjInstallerBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tbProjInstallerBindingNavigator.Name = "tbProjInstallerBindingNavigator";
            this.tbProjInstallerBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tbProjInstallerBindingNavigator.Size = new System.Drawing.Size(418, 25);
            this.tbProjInstallerBindingNavigator.TabIndex = 1;
            this.tbProjInstallerBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // tbProjInstallerBindingSource
            // 
            this.tbProjInstallerBindingSource.DataMember = "tbProjInstaller";
            this.tbProjInstallerBindingSource.DataSource = this.projectsDs;
            // 
            // projectsDs
            // 
            this.projectsDs.DataSetName = "ProjectsDs";
            this.projectsDs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tbProjInstallerBindingNavigatorSaveItem
            // 
            this.tbProjInstallerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbProjInstallerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tbProjInstallerBindingNavigatorSaveItem.Image")));
            this.tbProjInstallerBindingNavigatorSaveItem.Name = "tbProjInstallerBindingNavigatorSaveItem";
            this.tbProjInstallerBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tbProjInstallerBindingNavigatorSaveItem.Text = "Save Data";
            this.tbProjInstallerBindingNavigatorSaveItem.Click += new System.EventHandler(this.tbProjInstallerBindingNavigatorSaveItem_Click);
            // 
            // pathInstallerTextBox
            // 
            this.pathInstallerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbProjInstallerBindingSource, "PathInstaller", true));
            this.pathInstallerTextBox.Location = new System.Drawing.Point(83, 68);
            this.pathInstallerTextBox.Name = "pathInstallerTextBox";
            this.pathInstallerTextBox.Size = new System.Drawing.Size(333, 20);
            this.pathInstallerTextBox.TabIndex = 6;
            this.pathInstallerTextBox.DoubleClick += new System.EventHandler(this.pathInstallerTextBox_DoubleClick);
            // 
            // tbProjInstallerDataGridView
            // 
            this.tbProjInstallerDataGridView.AllowUserToAddRows = false;
            this.tbProjInstallerDataGridView.AutoGenerateColumns = false;
            this.tbProjInstallerDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.tbProjInstallerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbProjInstallerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.tbProjInstallerDataGridView.DataSource = this.tbProjInstallerBindingSource;
            this.tbProjInstallerDataGridView.Location = new System.Drawing.Point(12, 94);
            this.tbProjInstallerDataGridView.Name = "tbProjInstallerDataGridView";
            this.tbProjInstallerDataGridView.Size = new System.Drawing.Size(404, 249);
            this.tbProjInstallerDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ProjectName";
            this.dataGridViewTextBoxColumn2.HeaderText = "ProjectName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 93;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PathInstaller";
            this.dataGridViewTextBoxColumn3.HeaderText = "PathInstaller";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 90;
            // 
            // cbProjectName
            // 
            this.cbProjectName.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.tbProjInstallerBindingSource, "ProjectName", true));
            this.cbProjectName.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tbProjInstallerBindingSource, "ProjectName", true));
            this.cbProjectName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbProjInstallerBindingSource, "ProjectName", true));
            this.cbProjectName.DisplayMember = "ProjectName";
            this.cbProjectName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProjectName.FormattingEnabled = true;
            this.cbProjectName.Location = new System.Drawing.Point(67, 41);
            this.cbProjectName.Name = "cbProjectName";
            this.cbProjectName.Size = new System.Drawing.Size(349, 21);
            this.cbProjectName.TabIndex = 4;
            this.cbProjectName.ValueMember = "ProjectName";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Project:";
            // 
            // fdFindProjectsInstallers
            // 
            this.fdFindProjectsInstallers.FileName = "openFileDialog1";
            // 
            // cbVersionIncrement
            // 
            this.cbVersionIncrement.AutoSize = true;
            this.cbVersionIncrement.Location = new System.Drawing.Point(224, 160);
            this.cbVersionIncrement.Name = "cbVersionIncrement";
            this.cbVersionIncrement.Size = new System.Drawing.Size(161, 17);
            this.cbVersionIncrement.TabIndex = 12;
            this.cbVersionIncrement.Text = "Automatic Version Increment";
            this.cbVersionIncrement.UseVisualStyleBackColor = true;
            // 
            // fr_preferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 377);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "fr_preferences";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preferences";
            this.tabControl1.ResumeLayout(false);
            this.tpGeneral.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbGeneral.ResumeLayout(false);
            this.gbGeneral.PerformLayout();
            this.tpProjects.ResumeLayout(false);
            this.tpProjects.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbProjInstallerBindingNavigator)).EndInit();
            this.tbProjInstallerBindingNavigator.ResumeLayout(false);
            this.tbProjInstallerBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbProjInstallerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsDs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProjInstallerDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpGeneral;
        private System.Windows.Forms.TabPage tpProjects;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txTemplateSql;
        private System.Windows.Forms.GroupBox gbGeneral;
        private System.Windows.Forms.CheckBox cbZip;
        private System.Windows.Forms.TextBox txFolderSql;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txFolderClickOnce;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txFolderOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog fbdGetFolder;
        private System.Windows.Forms.ComboBox cbProjectName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txFolderProjects;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txFolderInstaller;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox pathInstallerTextBox;
        private System.Windows.Forms.BindingSource tbProjInstallerBindingSource;
        private ProjectsDs projectsDs;
        private System.Windows.Forms.DataGridView tbProjInstallerDataGridView;
        private System.Windows.Forms.BindingNavigator tbProjInstallerBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tbProjInstallerBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.OpenFileDialog fdFindProjectsInstallers;
        private System.Windows.Forms.CheckBox cbVersionDll;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.CheckBox cbVersionIncrement;

    }
}