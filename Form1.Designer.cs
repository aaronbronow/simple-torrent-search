namespace torrentsearch {
  partial class Form1 {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.newSiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
      this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
      this.gbNewSite = new System.Windows.Forms.GroupBox();
      this.btnAddNewSite = new System.Windows.Forms.Button();
      this.llblTest = new System.Windows.Forms.LinkLabel();
      this.tbURL = new System.Windows.Forms.TextBox();
      this.lblURL = new System.Windows.Forms.Label();
      this.gbSites = new System.Windows.Forms.GroupBox();
      this.clbSites = new System.Windows.Forms.CheckedListBox();
      this.gbSearch = new System.Windows.Forms.GroupBox();
      this.btnStopSearch = new System.Windows.Forms.Button();
      this.llblTest2 = new System.Windows.Forms.LinkLabel();
      this.btnSearch = new System.Windows.Forms.Button();
      this.tbQuery = new System.Windows.Forms.TextBox();
      this.gbResults = new System.Windows.Forms.GroupBox();
      this.btnStopFilter = new System.Windows.Forms.Button();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.lvResults = new System.Windows.Forms.ListView();
      this.colheaderLink = new System.Windows.Forms.ColumnHeader();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.lvFilteredResults = new System.Windows.Forms.ListView();
      this.colHeaderFilteredLink = new System.Windows.Forms.ColumnHeader();
      this.btnFilter = new System.Windows.Forms.Button();
      this.tbCommonString = new System.Windows.Forms.TextBox();
      this.btnFindLCS = new System.Windows.Forms.Button();
      this.menuStrip1.SuspendLayout();
      this.statusStrip1.SuspendLayout();
      this.gbNewSite.SuspendLayout();
      this.gbSites.SuspendLayout();
      this.gbSearch.SuspendLayout();
      this.gbResults.SuspendLayout();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(709, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newSiteToolStripMenuItem,
            this.exitToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
      this.fileToolStripMenuItem.Text = "&File";
      // 
      // newSiteToolStripMenuItem
      // 
      this.newSiteToolStripMenuItem.Name = "newSiteToolStripMenuItem";
      this.newSiteToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
      this.newSiteToolStripMenuItem.Text = "&New Site";
      // 
      // exitToolStripMenuItem
      // 
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
      this.exitToolStripMenuItem.Text = "&Exit";
      this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
      // 
      // statusStrip1
      // 
      this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
      this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
      this.statusStrip1.Location = new System.Drawing.Point(0, 481);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(709, 22);
      this.statusStrip1.TabIndex = 3;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // toolStripStatusLabel1
      // 
      this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
      this.toolStripStatusLabel1.Size = new System.Drawing.Size(38, 17);
      this.toolStripStatusLabel1.Text = "Status";
      // 
      // toolStripProgressBar1
      // 
      this.toolStripProgressBar1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
      this.toolStripProgressBar1.Name = "toolStripProgressBar1";
      this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
      this.toolStripProgressBar1.Step = 1;
      // 
      // gbNewSite
      // 
      this.gbNewSite.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.gbNewSite.Controls.Add(this.btnAddNewSite);
      this.gbNewSite.Controls.Add(this.llblTest);
      this.gbNewSite.Controls.Add(this.tbURL);
      this.gbNewSite.Controls.Add(this.lblURL);
      this.gbNewSite.Location = new System.Drawing.Point(12, 27);
      this.gbNewSite.Name = "gbNewSite";
      this.gbNewSite.Size = new System.Drawing.Size(685, 54);
      this.gbNewSite.TabIndex = 4;
      this.gbNewSite.TabStop = false;
      this.gbNewSite.Text = "New Site";
      // 
      // btnAddNewSite
      // 
      this.btnAddNewSite.Location = new System.Drawing.Point(430, 17);
      this.btnAddNewSite.Name = "btnAddNewSite";
      this.btnAddNewSite.Size = new System.Drawing.Size(75, 23);
      this.btnAddNewSite.TabIndex = 0;
      this.btnAddNewSite.Text = "Add";
      this.btnAddNewSite.UseVisualStyleBackColor = true;
      this.btnAddNewSite.Click += new System.EventHandler(this.btnAddNewSite_Click);
      // 
      // llblTest
      // 
      this.llblTest.AutoSize = true;
      this.llblTest.Enabled = false;
      this.llblTest.Location = new System.Drawing.Point(396, 20);
      this.llblTest.Name = "llblTest";
      this.llblTest.Size = new System.Drawing.Size(28, 13);
      this.llblTest.TabIndex = 0;
      this.llblTest.TabStop = true;
      this.llblTest.Text = "Test";
      this.llblTest.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblTest_LinkClicked);
      // 
      // tbURL
      // 
      this.tbURL.Location = new System.Drawing.Point(46, 20);
      this.tbURL.Name = "tbURL";
      this.tbURL.Size = new System.Drawing.Size(343, 20);
      this.tbURL.TabIndex = 1;
      this.tbURL.Enter += new System.EventHandler(this.tbURL_Enter);
      this.tbURL.TextChanged += new System.EventHandler(this.tbURL_TextChanged);
      // 
      // lblURL
      // 
      this.lblURL.AutoSize = true;
      this.lblURL.Location = new System.Drawing.Point(10, 20);
      this.lblURL.Name = "lblURL";
      this.lblURL.Size = new System.Drawing.Size(29, 13);
      this.lblURL.TabIndex = 0;
      this.lblURL.Text = "URL";
      // 
      // gbSites
      // 
      this.gbSites.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.gbSites.Controls.Add(this.clbSites);
      this.gbSites.Location = new System.Drawing.Point(13, 88);
      this.gbSites.Name = "gbSites";
      this.gbSites.Size = new System.Drawing.Size(684, 113);
      this.gbSites.TabIndex = 5;
      this.gbSites.TabStop = false;
      this.gbSites.Text = "Sites";
      // 
      // clbSites
      // 
      this.clbSites.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.clbSites.FormattingEnabled = true;
      this.clbSites.Location = new System.Drawing.Point(12, 20);
      this.clbSites.Name = "clbSites";
      this.clbSites.Size = new System.Drawing.Size(655, 79);
      this.clbSites.TabIndex = 1;
      // 
      // gbSearch
      // 
      this.gbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.gbSearch.Controls.Add(this.btnStopSearch);
      this.gbSearch.Controls.Add(this.llblTest2);
      this.gbSearch.Controls.Add(this.btnSearch);
      this.gbSearch.Controls.Add(this.tbQuery);
      this.gbSearch.Location = new System.Drawing.Point(12, 208);
      this.gbSearch.Name = "gbSearch";
      this.gbSearch.Size = new System.Drawing.Size(685, 58);
      this.gbSearch.TabIndex = 6;
      this.gbSearch.TabStop = false;
      this.gbSearch.Text = "Search";
      // 
      // btnStopSearch
      // 
      this.btnStopSearch.Enabled = false;
      this.btnStopSearch.Location = new System.Drawing.Point(511, 16);
      this.btnStopSearch.Name = "btnStopSearch";
      this.btnStopSearch.Size = new System.Drawing.Size(75, 23);
      this.btnStopSearch.TabIndex = 2;
      this.btnStopSearch.Text = "Stop";
      this.btnStopSearch.UseVisualStyleBackColor = true;
      this.btnStopSearch.Click += new System.EventHandler(this.btnStopSearch_Click);
      // 
      // llblTest2
      // 
      this.llblTest2.AutoSize = true;
      this.llblTest2.Location = new System.Drawing.Point(396, 19);
      this.llblTest2.Name = "llblTest2";
      this.llblTest2.Size = new System.Drawing.Size(28, 13);
      this.llblTest2.TabIndex = 3;
      this.llblTest2.TabStop = true;
      this.llblTest2.Text = "Test";
      this.llblTest2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblTest2_LinkClicked);
      // 
      // btnSearch
      // 
      this.btnSearch.Location = new System.Drawing.Point(430, 16);
      this.btnSearch.Name = "btnSearch";
      this.btnSearch.Size = new System.Drawing.Size(75, 23);
      this.btnSearch.TabIndex = 1;
      this.btnSearch.Text = "Search";
      this.btnSearch.UseVisualStyleBackColor = true;
      this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
      // 
      // tbQuery
      // 
      this.tbQuery.Location = new System.Drawing.Point(46, 19);
      this.tbQuery.Name = "tbQuery";
      this.tbQuery.Size = new System.Drawing.Size(343, 20);
      this.tbQuery.TabIndex = 0;
      this.tbQuery.Enter += new System.EventHandler(this.tbQuery_Enter);
      this.tbQuery.TextChanged += new System.EventHandler(this.tbQuery_TextChanged);
      // 
      // gbResults
      // 
      this.gbResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.gbResults.Controls.Add(this.btnStopFilter);
      this.gbResults.Controls.Add(this.tabControl1);
      this.gbResults.Controls.Add(this.btnFilter);
      this.gbResults.Controls.Add(this.tbCommonString);
      this.gbResults.Controls.Add(this.btnFindLCS);
      this.gbResults.Location = new System.Drawing.Point(13, 273);
      this.gbResults.Name = "gbResults";
      this.gbResults.Size = new System.Drawing.Size(684, 196);
      this.gbResults.TabIndex = 7;
      this.gbResults.TabStop = false;
      this.gbResults.Text = "Results";
      // 
      // btnStopFilter
      // 
      this.btnStopFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnStopFilter.Enabled = false;
      this.btnStopFilter.Location = new System.Drawing.Point(591, 157);
      this.btnStopFilter.Name = "btnStopFilter";
      this.btnStopFilter.Size = new System.Drawing.Size(75, 23);
      this.btnStopFilter.TabIndex = 4;
      this.btnStopFilter.Text = "Stop";
      this.btnStopFilter.UseVisualStyleBackColor = true;
      this.btnStopFilter.Click += new System.EventHandler(this.btnStopFilter_Click);
      // 
      // tabControl1
      // 
      this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Location = new System.Drawing.Point(12, 20);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(655, 131);
      this.tabControl1.TabIndex = 4;
      this.tabControl1.TabStop = false;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.lvResults);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(647, 105);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "All Links";
      this.tabPage1.UseVisualStyleBackColor = true;
      this.tabPage1.Enter += new System.EventHandler(this.tabPage1_Enter);
      // 
      // lvResults
      // 
      this.lvResults.CheckBoxes = true;
      this.lvResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colheaderLink});
      this.lvResults.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lvResults.FullRowSelect = true;
      this.lvResults.Location = new System.Drawing.Point(3, 3);
      this.lvResults.Name = "lvResults";
      this.lvResults.Size = new System.Drawing.Size(641, 99);
      this.lvResults.TabIndex = 0;
      this.lvResults.UseCompatibleStateImageBehavior = false;
      this.lvResults.View = System.Windows.Forms.View.Details;
      // 
      // colheaderLink
      // 
      this.colheaderLink.Text = "Link";
      this.colheaderLink.Width = 614;
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.lvFilteredResults);
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(647, 105);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Filtered Links";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // lvFilteredResults
      // 
      this.lvFilteredResults.CheckBoxes = true;
      this.lvFilteredResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHeaderFilteredLink});
      this.lvFilteredResults.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lvFilteredResults.FullRowSelect = true;
      this.lvFilteredResults.Location = new System.Drawing.Point(3, 3);
      this.lvFilteredResults.Name = "lvFilteredResults";
      this.lvFilteredResults.Size = new System.Drawing.Size(641, 99);
      this.lvFilteredResults.TabIndex = 6;
      this.lvFilteredResults.UseCompatibleStateImageBehavior = false;
      this.lvFilteredResults.View = System.Windows.Forms.View.Details;
      // 
      // colHeaderFilteredLink
      // 
      this.colHeaderFilteredLink.Text = "Link";
      this.colHeaderFilteredLink.Width = 614;
      // 
      // btnFilter
      // 
      this.btnFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnFilter.Enabled = false;
      this.btnFilter.Location = new System.Drawing.Point(510, 157);
      this.btnFilter.Name = "btnFilter";
      this.btnFilter.Size = new System.Drawing.Size(75, 23);
      this.btnFilter.TabIndex = 3;
      this.btnFilter.Text = "Filter";
      this.btnFilter.UseVisualStyleBackColor = true;
      this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
      // 
      // tbCommonString
      // 
      this.tbCommonString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.tbCommonString.Location = new System.Drawing.Point(45, 160);
      this.tbCommonString.Name = "tbCommonString";
      this.tbCommonString.Size = new System.Drawing.Size(343, 20);
      this.tbCommonString.TabIndex = 1;
      this.tbCommonString.Enter += new System.EventHandler(this.tbCommonString_Enter);
      this.tbCommonString.TextChanged += new System.EventHandler(this.tbCommonString_TextChanged);
      // 
      // btnFindLCS
      // 
      this.btnFindLCS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnFindLCS.Location = new System.Drawing.Point(429, 157);
      this.btnFindLCS.Name = "btnFindLCS";
      this.btnFindLCS.Size = new System.Drawing.Size(75, 23);
      this.btnFindLCS.TabIndex = 2;
      this.btnFindLCS.Text = "Find LCS";
      this.btnFindLCS.UseVisualStyleBackColor = true;
      this.btnFindLCS.Click += new System.EventHandler(this.btnFindLCS_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(709, 503);
      this.Controls.Add(this.gbResults);
      this.Controls.Add(this.gbSearch);
      this.Controls.Add(this.gbSites);
      this.Controls.Add(this.gbNewSite);
      this.Controls.Add(this.statusStrip1);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "Form1";
      this.Text = "Link Search";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      this.gbNewSite.ResumeLayout(false);
      this.gbNewSite.PerformLayout();
      this.gbSites.ResumeLayout(false);
      this.gbSearch.ResumeLayout(false);
      this.gbSearch.PerformLayout();
      this.gbResults.ResumeLayout(false);
      this.gbResults.PerformLayout();
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage2.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem newSiteToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    private System.Windows.Forms.GroupBox gbNewSite;
    private System.Windows.Forms.LinkLabel llblTest;
    private System.Windows.Forms.TextBox tbURL;
    private System.Windows.Forms.Label lblURL;
    private System.Windows.Forms.Button btnAddNewSite;
    private System.Windows.Forms.GroupBox gbSites;
    private System.Windows.Forms.CheckedListBox clbSites;
    private System.Windows.Forms.GroupBox gbSearch;
    private System.Windows.Forms.Button btnSearch;
    private System.Windows.Forms.TextBox tbQuery;
    private System.Windows.Forms.GroupBox gbResults;
    private System.Windows.Forms.Button btnFindLCS;
    private System.Windows.Forms.TextBox tbCommonString;
    private System.Windows.Forms.Button btnFilter;
    private System.Windows.Forms.LinkLabel llblTest2;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.ListView lvResults;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.ListView lvFilteredResults;
    private System.Windows.Forms.ColumnHeader colheaderLink;
    private System.Windows.Forms.ColumnHeader colHeaderFilteredLink;
    private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
    private System.Windows.Forms.Button btnStopFilter;
    private System.Windows.Forms.Button btnStopSearch;
  }
}

