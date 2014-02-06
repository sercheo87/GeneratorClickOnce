namespace UtilVersioningCO.UI
{
    partial class frm_VersioningCO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_VersioningCO));
            this.button1 = new System.Windows.Forms.Button();
            this.dgProjectsGen = new System.Windows.Forms.DataGridView();
            this.tbProjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bsProjects = new System.Windows.Forms.BindingSource(this.components);
            this.projectsDs = new UtilVersioningCO.UI.ProjectsDs();
            this.ctnParent = new System.Windows.Forms.SplitContainer();
            this.tvProjects = new System.Windows.Forms.TreeView();
            this.icons = new System.Windows.Forms.ImageList(this.components);
            this.bnProjectsGenerate = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btExecute = new System.Windows.Forms.ToolStripButton();
            this.tsMaster = new System.Windows.Forms.ToolStrip();
            this.btPreferences = new System.Windows.Forms.ToolStripButton();
            this.btClean = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cbListFilePrj = new System.Windows.Forms.ToolStripComboBox();
            this.btLoadPrjConf = new System.Windows.Forms.ToolStripButton();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsProjectsCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.pbProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.msNodeChild = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.openFolderContainerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.niNotify = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgProjectsGen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProjectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsDs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctnParent)).BeginInit();
            this.ctnParent.Panel1.SuspendLayout();
            this.ctnParent.Panel2.SuspendLayout();
            this.ctnParent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnProjectsGenerate)).BeginInit();
            this.bnProjectsGenerate.SuspendLayout();
            this.tsMaster.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.msNodeChild.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            // 
            // dgProjectsGen
            // 
            this.dgProjectsGen.AllowUserToAddRows = false;
            this.dgProjectsGen.AllowUserToOrderColumns = true;
            this.dgProjectsGen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgProjectsGen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProjectsGen.Location = new System.Drawing.Point(3, 28);
            this.dgProjectsGen.Name = "dgProjectsGen";
            this.dgProjectsGen.Size = new System.Drawing.Size(548, 345);
            this.dgProjectsGen.TabIndex = 1;
            this.dgProjectsGen.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProjectsGen_CellEndEdit);
            // 
            // tbProjectsBindingSource
            // 
            this.tbProjectsBindingSource.DataMember = "tbProjects";
            this.tbProjectsBindingSource.DataSource = this.bsProjects;
            // 
            // bsProjects
            // 
            this.bsProjects.AllowNew = true;
            this.bsProjects.DataSource = this.projectsDs;
            this.bsProjects.Position = 0;
            // 
            // projectsDs
            // 
            this.projectsDs.DataSetName = "ProjectsDs";
            this.projectsDs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ctnParent
            // 
            this.ctnParent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctnParent.Location = new System.Drawing.Point(0, 29);
            this.ctnParent.Name = "ctnParent";
            // 
            // ctnParent.Panel1
            // 
            this.ctnParent.Panel1.Controls.Add(this.tvProjects);
            // 
            // ctnParent.Panel2
            // 
            this.ctnParent.Panel2.Controls.Add(this.bnProjectsGenerate);
            this.ctnParent.Panel2.Controls.Add(this.dgProjectsGen);
            this.ctnParent.Size = new System.Drawing.Size(834, 376);
            this.ctnParent.SplitterDistance = 276;
            this.ctnParent.TabIndex = 2;
            // 
            // tvProjects
            // 
            this.tvProjects.CheckBoxes = true;
            this.tvProjects.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tvProjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvProjects.ImageIndex = 0;
            this.tvProjects.ImageList = this.icons;
            this.tvProjects.Location = new System.Drawing.Point(0, 0);
            this.tvProjects.Name = "tvProjects";
            this.tvProjects.SelectedImageIndex = 0;
            this.tvProjects.Size = new System.Drawing.Size(276, 376);
            this.tvProjects.TabIndex = 0;
            this.tvProjects.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvProjects_NodeMouseClick);
            // 
            // icons
            // 
            this.icons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("icons.ImageStream")));
            this.icons.TransparentColor = System.Drawing.Color.Transparent;
            this.icons.Images.SetKeyName(0, "ico_project");
            // 
            // bnProjectsGenerate
            // 
            this.bnProjectsGenerate.AddNewItem = this.bindingNavigatorCountItem;
            this.bnProjectsGenerate.CountItem = this.bindingNavigatorCountItem;
            this.bnProjectsGenerate.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bnProjectsGenerate.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorDeleteItem,
            this.toolStripSeparator2,
            this.btExecute});
            this.bnProjectsGenerate.Location = new System.Drawing.Point(0, 0);
            this.bnProjectsGenerate.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnProjectsGenerate.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnProjectsGenerate.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnProjectsGenerate.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnProjectsGenerate.Name = "bnProjectsGenerate";
            this.bnProjectsGenerate.PositionItem = this.bindingNavigatorPositionItem;
            this.bnProjectsGenerate.Size = new System.Drawing.Size(554, 25);
            this.bnProjectsGenerate.TabIndex = 3;
            this.bnProjectsGenerate.Text = "bindingNavigator1";
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btExecute
            // 
            this.btExecute.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btExecute.Image = ((System.Drawing.Image)(resources.GetObject("btExecute.Image")));
            this.btExecute.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btExecute.Name = "btExecute";
            this.btExecute.Size = new System.Drawing.Size(51, 22);
            this.btExecute.Text = "Execute";
            this.btExecute.Click += new System.EventHandler(this.btExecute_Click_1);
            // 
            // tsMaster
            // 
            this.tsMaster.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btPreferences,
            this.btClean,
            this.toolStripSeparator3,
            this.toolStripLabel1,
            this.cbListFilePrj,
            this.btLoadPrjConf});
            this.tsMaster.Location = new System.Drawing.Point(0, 0);
            this.tsMaster.Name = "tsMaster";
            this.tsMaster.Size = new System.Drawing.Size(834, 25);
            this.tsMaster.TabIndex = 3;
            this.tsMaster.Text = "toolStrip1";
            // 
            // btPreferences
            // 
            this.btPreferences.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btPreferences.Image = ((System.Drawing.Image)(resources.GetObject("btPreferences.Image")));
            this.btPreferences.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btPreferences.Name = "btPreferences";
            this.btPreferences.Size = new System.Drawing.Size(72, 22);
            this.btPreferences.Text = "Preferences";
            this.btPreferences.Click += new System.EventHandler(this.btPreferences_Click);
            // 
            // btClean
            // 
            this.btClean.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btClean.Image = ((System.Drawing.Image)(resources.GetObject("btClean.Image")));
            this.btClean.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btClean.Name = "btClean";
            this.btClean.Size = new System.Drawing.Size(41, 22);
            this.btClean.Text = "Clean";
            this.btClean.Click += new System.EventHandler(this.btClean_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(44, 22);
            this.toolStripLabel1.Text = "Project";
            // 
            // cbListFilePrj
            // 
            this.cbListFilePrj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbListFilePrj.Name = "cbListFilePrj";
            this.cbListFilePrj.Size = new System.Drawing.Size(121, 25);
            // 
            // btLoadPrjConf
            // 
            this.btLoadPrjConf.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btLoadPrjConf.Image = ((System.Drawing.Image)(resources.GetObject("btLoadPrjConf.Image")));
            this.btLoadPrjConf.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btLoadPrjConf.Name = "btLoadPrjConf";
            this.btLoadPrjConf.Size = new System.Drawing.Size(37, 22);
            this.btLoadPrjConf.Text = "Load";
            this.btLoadPrjConf.Click += new System.EventHandler(this.btLoadPrjConf_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsProjectsCount,
            this.pbProgress});
            this.statusStrip1.Location = new System.Drawing.Point(0, 408);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(834, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsProjectsCount
            // 
            this.tsProjectsCount.Name = "tsProjectsCount";
            this.tsProjectsCount.Size = new System.Drawing.Size(118, 17);
            this.tsProjectsCount.Text = "toolStripStatusLabel1";
            // 
            // pbProgress
            // 
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(100, 16);
            this.pbProgress.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            // 
            // msNodeChild
            // 
            this.msNodeChild.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAllToolStripMenuItem,
            this.toolStripSeparator1,
            this.openFolderContainerToolStripMenuItem});
            this.msNodeChild.Name = "msTreeView";
            this.msNodeChild.Size = new System.Drawing.Size(195, 54);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.selectAllToolStripMenuItem.Text = "Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(191, 6);
            // 
            // openFolderContainerToolStripMenuItem
            // 
            this.openFolderContainerToolStripMenuItem.Name = "openFolderContainerToolStripMenuItem";
            this.openFolderContainerToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.openFolderContainerToolStripMenuItem.Text = "Open Folder Container";
            this.openFolderContainerToolStripMenuItem.Click += new System.EventHandler(this.openFolderContainerToolStripMenuItem_Click);
            // 
            // niNotify
            // 
            this.niNotify.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.niNotify.Icon = ((System.Drawing.Icon)(resources.GetObject("niNotify.Icon")));
            this.niNotify.Text = "notifyIcon2";
            this.niNotify.Visible = true;
            // 
            // frm_VersioningCO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 430);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tsMaster);
            this.Controls.Add(this.ctnParent);
            this.Controls.Add(this.button1);
            this.Name = "frm_VersioningCO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generate Click Once with Versioning";
            ((System.ComponentModel.ISupportInitialize)(this.dgProjectsGen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProjectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsDs)).EndInit();
            this.ctnParent.Panel1.ResumeLayout(false);
            this.ctnParent.Panel2.ResumeLayout(false);
            this.ctnParent.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctnParent)).EndInit();
            this.ctnParent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bnProjectsGenerate)).EndInit();
            this.bnProjectsGenerate.ResumeLayout(false);
            this.bnProjectsGenerate.PerformLayout();
            this.tsMaster.ResumeLayout(false);
            this.tsMaster.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.msNodeChild.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgProjectsGen;
        private System.Windows.Forms.SplitContainer ctnParent;
        private System.Windows.Forms.TreeView tvProjects;
        private System.Windows.Forms.ImageList icons;
        private System.Windows.Forms.ToolStrip tsMaster;
        private System.Windows.Forms.BindingSource bsProjects;
        private ProjectsDs projectsDs;
        private System.Windows.Forms.BindingSource tbProjectsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullPathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn versionDataGridViewTextBoxColumn;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsProjectsCount;
        private System.Windows.Forms.ContextMenuStrip msNodeChild;
        private System.Windows.Forms.ToolStripMenuItem openFolderContainerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btPreferences;
        private System.Windows.Forms.BindingNavigator bnProjectsGenerate;
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
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btExecute;
        private System.Windows.Forms.ToolStripProgressBar pbProgress;
        private System.Windows.Forms.ToolStripButton btClean;
        private System.Windows.Forms.NotifyIcon niNotify;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox cbListFilePrj;
        private System.Windows.Forms.ToolStripButton btLoadPrjConf;
    }
}

