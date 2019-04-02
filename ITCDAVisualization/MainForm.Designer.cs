namespace ITCDAVisualization
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.leftSplitContainer = new System.Windows.Forms.SplitContainer();
            this.docTreeView = new System.Windows.Forms.TreeView();
            this.docTreeViewMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.collapseAllButton = new System.Windows.Forms.ToolStripMenuItem();
            this.dumpTextButton = new System.Windows.Forms.ToolStripMenuItem();
            this.rightSplitContainer = new System.Windows.Forms.SplitContainer();
            this.testCaseListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.testCaseListMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.resizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.uIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caseIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subSysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkPtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.batchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.precondToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requirementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailListView = new System.Windows.Forms.ListView();
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.detailMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.resizeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.openButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.leftSplitContainer)).BeginInit();
            this.leftSplitContainer.Panel1.SuspendLayout();
            this.leftSplitContainer.Panel2.SuspendLayout();
            this.leftSplitContainer.SuspendLayout();
            this.docTreeViewMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rightSplitContainer)).BeginInit();
            this.rightSplitContainer.Panel1.SuspendLayout();
            this.rightSplitContainer.Panel2.SuspendLayout();
            this.rightSplitContainer.SuspendLayout();
            this.testCaseListMenu.SuspendLayout();
            this.detailMenu.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftSplitContainer
            // 
            this.leftSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftSplitContainer.Location = new System.Drawing.Point(0, 25);
            this.leftSplitContainer.Name = "leftSplitContainer";
            // 
            // leftSplitContainer.Panel1
            // 
            this.leftSplitContainer.Panel1.Controls.Add(this.docTreeView);
            // 
            // leftSplitContainer.Panel2
            // 
            this.leftSplitContainer.Panel2.Controls.Add(this.rightSplitContainer);
            this.leftSplitContainer.Size = new System.Drawing.Size(800, 425);
            this.leftSplitContainer.SplitterDistance = 266;
            this.leftSplitContainer.TabIndex = 1;
            // 
            // docTreeView
            // 
            this.docTreeView.ContextMenuStrip = this.docTreeViewMenu;
            this.docTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.docTreeView.Location = new System.Drawing.Point(0, 0);
            this.docTreeView.Name = "docTreeView";
            this.docTreeView.Size = new System.Drawing.Size(266, 425);
            this.docTreeView.TabIndex = 0;
            this.docTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.docTreeView_NodeMouseClick);
            // 
            // docTreeViewMenu
            // 
            this.docTreeViewMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.collapseAllButton,
            this.dumpTextButton});
            this.docTreeViewMenu.Name = "docTreeViewMenu";
            this.docTreeViewMenu.Size = new System.Drawing.Size(145, 48);
            // 
            // collapseAllButton
            // 
            this.collapseAllButton.Name = "collapseAllButton";
            this.collapseAllButton.Size = new System.Drawing.Size(144, 22);
            this.collapseAllButton.Text = "&Collapse All";
            this.collapseAllButton.Click += new System.EventHandler(this.collapseAllButton_Click);
            // 
            // dumpTextButton
            // 
            this.dumpTextButton.Name = "dumpTextButton";
            this.dumpTextButton.Size = new System.Drawing.Size(144, 22);
            this.dumpTextButton.Text = "&Dump Text";
            this.dumpTextButton.Click += new System.EventHandler(this.dumpTextButton_Click);
            // 
            // rightSplitContainer
            // 
            this.rightSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.rightSplitContainer.Name = "rightSplitContainer";
            this.rightSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // rightSplitContainer.Panel1
            // 
            this.rightSplitContainer.Panel1.Controls.Add(this.testCaseListView);
            // 
            // rightSplitContainer.Panel2
            // 
            this.rightSplitContainer.Panel2.Controls.Add(this.detailListView);
            this.rightSplitContainer.Size = new System.Drawing.Size(530, 425);
            this.rightSplitContainer.SplitterDistance = 212;
            this.rightSplitContainer.TabIndex = 1;
            // 
            // testCaseListView
            // 
            this.testCaseListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15});
            this.testCaseListView.ContextMenuStrip = this.testCaseListMenu;
            this.testCaseListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testCaseListView.FullRowSelect = true;
            this.testCaseListView.Location = new System.Drawing.Point(0, 0);
            this.testCaseListView.Name = "testCaseListView";
            this.testCaseListView.Size = new System.Drawing.Size(530, 212);
            this.testCaseListView.TabIndex = 0;
            this.testCaseListView.UseCompatibleStateImageBehavior = false;
            this.testCaseListView.View = System.Windows.Forms.View.Details;
            this.testCaseListView.SelectedIndexChanged += new System.EventHandler(this.testCaseListView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No.";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "UID";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Case ID";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Sys.";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Sub Sys.";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Trans.";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Func.";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Type";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Check Pt.";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Batch";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Precond.";
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Input";
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Proc.";
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Result";
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Requirement";
            // 
            // testCaseListMenu
            // 
            this.testCaseListMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resizeToolStripMenuItem,
            this.toolStripSeparator1,
            this.uIDToolStripMenuItem,
            this.caseIDToolStripMenuItem,
            this.sysToolStripMenuItem,
            this.subSysToolStripMenuItem,
            this.transToolStripMenuItem,
            this.funcToolStripMenuItem,
            this.typeToolStripMenuItem,
            this.checkPtToolStripMenuItem,
            this.batchToolStripMenuItem,
            this.precondToolStripMenuItem,
            this.inputToolStripMenuItem,
            this.procToolStripMenuItem,
            this.resultToolStripMenuItem,
            this.requirementToolStripMenuItem});
            this.testCaseListMenu.Name = "testCaseListMenu";
            this.testCaseListMenu.Size = new System.Drawing.Size(151, 340);
            // 
            // resizeToolStripMenuItem
            // 
            this.resizeToolStripMenuItem.Name = "resizeToolStripMenuItem";
            this.resizeToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.resizeToolStripMenuItem.Text = "&Resize";
            this.resizeToolStripMenuItem.Click += new System.EventHandler(this.resizeToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(147, 6);
            // 
            // uIDToolStripMenuItem
            // 
            this.uIDToolStripMenuItem.Checked = true;
            this.uIDToolStripMenuItem.CheckOnClick = true;
            this.uIDToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.uIDToolStripMenuItem.Name = "uIDToolStripMenuItem";
            this.uIDToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.uIDToolStripMenuItem.Text = "UID";
            this.uIDToolStripMenuItem.Click += new System.EventHandler(this.headerToolStripMenuItem_Click);
            // 
            // caseIDToolStripMenuItem
            // 
            this.caseIDToolStripMenuItem.Checked = true;
            this.caseIDToolStripMenuItem.CheckOnClick = true;
            this.caseIDToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.caseIDToolStripMenuItem.Name = "caseIDToolStripMenuItem";
            this.caseIDToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.caseIDToolStripMenuItem.Text = "Case ID";
            this.caseIDToolStripMenuItem.Click += new System.EventHandler(this.headerToolStripMenuItem_Click);
            // 
            // sysToolStripMenuItem
            // 
            this.sysToolStripMenuItem.Checked = true;
            this.sysToolStripMenuItem.CheckOnClick = true;
            this.sysToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sysToolStripMenuItem.Name = "sysToolStripMenuItem";
            this.sysToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.sysToolStripMenuItem.Text = "Sys.";
            this.sysToolStripMenuItem.Click += new System.EventHandler(this.headerToolStripMenuItem_Click);
            // 
            // subSysToolStripMenuItem
            // 
            this.subSysToolStripMenuItem.Checked = true;
            this.subSysToolStripMenuItem.CheckOnClick = true;
            this.subSysToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.subSysToolStripMenuItem.Name = "subSysToolStripMenuItem";
            this.subSysToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.subSysToolStripMenuItem.Text = "Sub Sys.";
            this.subSysToolStripMenuItem.Click += new System.EventHandler(this.headerToolStripMenuItem_Click);
            // 
            // transToolStripMenuItem
            // 
            this.transToolStripMenuItem.Checked = true;
            this.transToolStripMenuItem.CheckOnClick = true;
            this.transToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.transToolStripMenuItem.Name = "transToolStripMenuItem";
            this.transToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.transToolStripMenuItem.Text = "Trans.";
            this.transToolStripMenuItem.Click += new System.EventHandler(this.headerToolStripMenuItem_Click);
            // 
            // funcToolStripMenuItem
            // 
            this.funcToolStripMenuItem.Checked = true;
            this.funcToolStripMenuItem.CheckOnClick = true;
            this.funcToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.funcToolStripMenuItem.Name = "funcToolStripMenuItem";
            this.funcToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.funcToolStripMenuItem.Text = "Func.";
            this.funcToolStripMenuItem.Click += new System.EventHandler(this.headerToolStripMenuItem_Click);
            // 
            // typeToolStripMenuItem
            // 
            this.typeToolStripMenuItem.Checked = true;
            this.typeToolStripMenuItem.CheckOnClick = true;
            this.typeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.typeToolStripMenuItem.Name = "typeToolStripMenuItem";
            this.typeToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.typeToolStripMenuItem.Text = "Type";
            this.typeToolStripMenuItem.Click += new System.EventHandler(this.headerToolStripMenuItem_Click);
            // 
            // checkPtToolStripMenuItem
            // 
            this.checkPtToolStripMenuItem.Checked = true;
            this.checkPtToolStripMenuItem.CheckOnClick = true;
            this.checkPtToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkPtToolStripMenuItem.Name = "checkPtToolStripMenuItem";
            this.checkPtToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.checkPtToolStripMenuItem.Text = "Check Pt.";
            this.checkPtToolStripMenuItem.Click += new System.EventHandler(this.headerToolStripMenuItem_Click);
            // 
            // batchToolStripMenuItem
            // 
            this.batchToolStripMenuItem.Checked = true;
            this.batchToolStripMenuItem.CheckOnClick = true;
            this.batchToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.batchToolStripMenuItem.Name = "batchToolStripMenuItem";
            this.batchToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.batchToolStripMenuItem.Text = "Batch";
            this.batchToolStripMenuItem.Click += new System.EventHandler(this.headerToolStripMenuItem_Click);
            // 
            // precondToolStripMenuItem
            // 
            this.precondToolStripMenuItem.Checked = true;
            this.precondToolStripMenuItem.CheckOnClick = true;
            this.precondToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.precondToolStripMenuItem.Name = "precondToolStripMenuItem";
            this.precondToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.precondToolStripMenuItem.Text = "Precond.";
            this.precondToolStripMenuItem.Click += new System.EventHandler(this.headerToolStripMenuItem_Click);
            // 
            // inputToolStripMenuItem
            // 
            this.inputToolStripMenuItem.Checked = true;
            this.inputToolStripMenuItem.CheckOnClick = true;
            this.inputToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.inputToolStripMenuItem.Name = "inputToolStripMenuItem";
            this.inputToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.inputToolStripMenuItem.Text = "Input";
            this.inputToolStripMenuItem.Click += new System.EventHandler(this.headerToolStripMenuItem_Click);
            // 
            // procToolStripMenuItem
            // 
            this.procToolStripMenuItem.Checked = true;
            this.procToolStripMenuItem.CheckOnClick = true;
            this.procToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.procToolStripMenuItem.Name = "procToolStripMenuItem";
            this.procToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.procToolStripMenuItem.Text = "Proc.";
            this.procToolStripMenuItem.Click += new System.EventHandler(this.headerToolStripMenuItem_Click);
            // 
            // resultToolStripMenuItem
            // 
            this.resultToolStripMenuItem.Checked = true;
            this.resultToolStripMenuItem.CheckOnClick = true;
            this.resultToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.resultToolStripMenuItem.Name = "resultToolStripMenuItem";
            this.resultToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.resultToolStripMenuItem.Text = "Result";
            this.resultToolStripMenuItem.Click += new System.EventHandler(this.headerToolStripMenuItem_Click);
            // 
            // requirementToolStripMenuItem
            // 
            this.requirementToolStripMenuItem.Checked = true;
            this.requirementToolStripMenuItem.CheckOnClick = true;
            this.requirementToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.requirementToolStripMenuItem.Name = "requirementToolStripMenuItem";
            this.requirementToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.requirementToolStripMenuItem.Text = "Requirement";
            this.requirementToolStripMenuItem.Click += new System.EventHandler(this.headerToolStripMenuItem_Click);
            // 
            // detailListView
            // 
            this.detailListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19,
            this.columnHeader20,
            this.columnHeader21,
            this.columnHeader22});
            this.detailListView.ContextMenuStrip = this.detailMenu;
            this.detailListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailListView.Location = new System.Drawing.Point(0, 0);
            this.detailListView.Name = "detailListView";
            this.detailListView.Size = new System.Drawing.Size(530, 209);
            this.detailListView.TabIndex = 0;
            this.detailListView.UseCompatibleStateImageBehavior = false;
            this.detailListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "No.";
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Feature";
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "UID";
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "Req.";
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "Chk. Pt.";
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "Proc.";
            // 
            // columnHeader22
            // 
            this.columnHeader22.Text = "Result";
            // 
            // detailMenu
            // 
            this.detailMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resizeToolStripMenuItem1});
            this.detailMenu.Name = "detailMenu";
            this.detailMenu.Size = new System.Drawing.Size(114, 26);
            // 
            // resizeToolStripMenuItem1
            // 
            this.resizeToolStripMenuItem1.Name = "resizeToolStripMenuItem1";
            this.resizeToolStripMenuItem1.Size = new System.Drawing.Size(113, 22);
            this.resizeToolStripMenuItem1.Text = "&Resize";
            this.resizeToolStripMenuItem1.Click += new System.EventHandler(this.resizeToolStripMenuItem1_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(800, 25);
            this.toolStrip.TabIndex = 2;
            this.toolStrip.Text = "toolStrip1";
            // 
            // openButton
            // 
            this.openButton.Image = ((System.Drawing.Image)(resources.GetObject("openButton.Image")));
            this.openButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(60, 22);
            this.openButton.Text = "&Open";
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.leftSplitContainer);
            this.Controls.Add(this.toolStrip);
            this.DoubleBuffered = true;
            this.Name = "MainForm";
            this.Text = "Chinasoft";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.leftSplitContainer.Panel1.ResumeLayout(false);
            this.leftSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.leftSplitContainer)).EndInit();
            this.leftSplitContainer.ResumeLayout(false);
            this.docTreeViewMenu.ResumeLayout(false);
            this.rightSplitContainer.Panel1.ResumeLayout(false);
            this.rightSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rightSplitContainer)).EndInit();
            this.rightSplitContainer.ResumeLayout(false);
            this.testCaseListMenu.ResumeLayout(false);
            this.detailMenu.ResumeLayout(false);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SplitContainer leftSplitContainer;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton openButton;
        private System.Windows.Forms.TreeView docTreeView;
        private System.Windows.Forms.ContextMenuStrip docTreeViewMenu;
        private System.Windows.Forms.ToolStripMenuItem collapseAllButton;
        private System.Windows.Forms.ToolStripMenuItem dumpTextButton;
        private System.Windows.Forms.ListView testCaseListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ContextMenuStrip testCaseListMenu;
        private System.Windows.Forms.ToolStripMenuItem uIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caseIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subSysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem typeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkPtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem batchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem precondToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem requirementToolStripMenuItem;
        private System.Windows.Forms.SplitContainer rightSplitContainer;
        private System.Windows.Forms.ToolStripMenuItem resizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ListView detailListView;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.ColumnHeader columnHeader21;
        private System.Windows.Forms.ColumnHeader columnHeader22;
        private System.Windows.Forms.ContextMenuStrip detailMenu;
        private System.Windows.Forms.ToolStripMenuItem resizeToolStripMenuItem1;
    }
}

