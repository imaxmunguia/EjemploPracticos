namespace Telerik.Examples.WinControls.ListView.Settings
{
    partial class Form1
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
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn1 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 0", "File Name");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn2 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 1", "Total Size");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn3 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 2", "Type");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn4 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 3", "Free Space");
            Telerik.WinControls.UI.ListViewDataItemGroup listViewDataItemGroup1 = new Telerik.WinControls.UI.ListViewDataItemGroup("Files Stored on This Computer");
            Telerik.WinControls.UI.ListViewDataItemGroup listViewDataItemGroup2 = new Telerik.WinControls.UI.ListViewDataItemGroup("Hard Disk Drives");
            Telerik.WinControls.UI.ListViewDataItemGroup listViewDataItemGroup3 = new Telerik.WinControls.UI.ListViewDataItemGroup("Devices with Removable Storage");
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem1 = new Telerik.WinControls.UI.ListViewDataItem("Shared Documents", new string[] {
            "Shared Documents",
            "",
            "File Folder"});
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem2 = new Telerik.WinControls.UI.ListViewDataItem("Administrator\'s Documents", new string[] {
            "Administrator\'s Documents",
            "",
            "File Folder"});
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem3 = new Telerik.WinControls.UI.ListViewDataItem("3.5 Floppy (A:)", new string[] {
            "3.5 Floppy (A:)",
            "1.44 MB",
            "Floppy Drive",
            "203 KB"});
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem4 = new Telerik.WinControls.UI.ListViewDataItem("Local Disk (C:)", new string[] {
            "Local Disk (C:)",
            "160.4 GB",
            "Local Disk",
            "31.02 GB"});
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem5 = new Telerik.WinControls.UI.ListViewDataItem("Local Disk (D:)", new string[] {
            "Local Disk (D:)",
            "136.2 GB",
            "Local Disk",
            "57.52 GB"});
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem6 = new Telerik.WinControls.UI.ListViewDataItem("Local Disk (E:)", new string[] {
            "Local Disk (E:)",
            "40.00 GB",
            "Local Disk",
            "13.37 GB"});
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem7 = new Telerik.WinControls.UI.ListViewDataItem("Local Disk (F:)", new string[] {
            "Local Disk (F:)",
            "0.99 TB",
            "Local Disk",
            "357.37 GB"});
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem8 = new Telerik.WinControls.UI.ListViewDataItem("DVD/CD-RW Drive (G:)", new string[] {
            "DVD/CD-RW (G:)",
            "4.7 GB",
            "DVD Drive",
            "0 KB"});
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem9 = new Telerik.WinControls.UI.ListViewDataItem("CD-RW Drive (H:)", new string[] {
            "CD-RW (G:)",
            "",
            "CD Drive"});
            Telerik.WinControls.UI.RadListDataItem radListDataItem4 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem5 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem1 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem2 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem3 = new Telerik.WinControls.UI.RadListDataItem();
            this.radListView1 = new Telerik.WinControls.UI.RadListView();
            this.radCheckBoxShowCheckboxes = new Telerik.WinControls.UI.RadCheckBox();
            this.radCheckBoxGroups = new Telerik.WinControls.UI.RadCheckBox();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radCheckBoxFullRowSelect = new Telerik.WinControls.UI.RadCheckBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.radCheckBox4 = new Telerik.WinControls.UI.RadCheckBox();
            this.radCheckBoxArbWidth = new Telerik.WinControls.UI.RadCheckBox();
            this.radCheckBoxArbHeight = new Telerik.WinControls.UI.RadCheckBox();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.radSpinEditorGroupHeight = new Telerik.WinControls.UI.RadSpinEditor();
            this.radSpinEditorItemHeight = new Telerik.WinControls.UI.RadSpinEditor();
            this.radSpinEditorItemWidth = new Telerik.WinControls.UI.RadSpinEditor();
            this.radSpinEditorGroupIndent = new Telerik.WinControls.UI.RadSpinEditor();
            this.radSpinEditorItemSpacing = new Telerik.WinControls.UI.RadSpinEditor();
            this.radGroupBoxDetailView = new Telerik.WinControls.UI.RadGroupBox();
            this.radSpinEditorHeaderHeight = new Telerik.WinControls.UI.RadSpinEditor();
            this.radCheckBoxColHeaders = new Telerik.WinControls.UI.RadCheckBox();
            this.radCheckBoxColSort = new Telerik.WinControls.UI.RadCheckBox();
            this.radCheckBoxColReorder = new Telerik.WinControls.UI.RadCheckBox();
            this.radCheckBoxColResize = new Telerik.WinControls.UI.RadCheckBox();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.radGroupBoxIconView = new Telerik.WinControls.UI.RadGroupBox();
            this.radDropDownList2 = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel7 = new Telerik.WinControls.UI.RadLabel();
            this.radGroupBox5 = new Telerik.WinControls.UI.RadGroupBox();
            this.radDropDownListViewType = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel8 = new Telerik.WinControls.UI.RadLabel();
            this.radPanel1 = new Telerik.Examples.TreeExampleHeaderPanel();
            this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radListView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxShowCheckboxes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxFullRowSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            this.radLabel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxArbWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxArbHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorGroupHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorItemHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorItemWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorGroupIndent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorItemSpacing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBoxDetailView)).BeginInit();
            this.radGroupBoxDetailView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorHeaderHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxColHeaders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxColSort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxColReorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxColResize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBoxIconView)).BeginInit();
            this.radGroupBoxIconView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox5)).BeginInit();
            this.radGroupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownListViewType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
            this.radPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radGroupBox5);
            this.settingsPanel.Controls.Add(this.radGroupBox2);
            this.settingsPanel.Controls.Add(this.radGroupBox1);
            this.settingsPanel.Controls.Add(this.radGroupBoxIconView);
            this.settingsPanel.Controls.Add(this.radGroupBoxDetailView);
            this.settingsPanel.Location = new System.Drawing.Point(1032, 1);
            this.settingsPanel.Size = new System.Drawing.Size(200, 830);
            this.settingsPanel.ThemeName = "ControlDefault";
            this.settingsPanel.Controls.SetChildIndex(this.radGroupBoxDetailView, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radGroupBoxIconView, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radGroupBox1, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radGroupBox2, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radGroupBox5, 0);
            // 
            // radListView1
            // 
            listViewDetailColumn1.HeaderText = "File Name";
            listViewDetailColumn2.HeaderText = "Total Size";
            listViewDetailColumn3.HeaderText = "Type";
            listViewDetailColumn4.HeaderText = "Free Space";
            this.radListView1.Columns.AddRange(new Telerik.WinControls.UI.ListViewDetailColumn[] {
            listViewDetailColumn1,
            listViewDetailColumn2,
            listViewDetailColumn3,
            listViewDetailColumn4});
            this.radListView1.CurrentColumn = null;
            this.radListView1.CurrentItem = null;
            this.radListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radListView1.EnableCustomGrouping = true;
            this.radListView1.EnableSorting = true;
            this.radListView1.GroupItemSize = new System.Drawing.Size(200, 20);
            listViewDataItemGroup1.Text = "Files Stored on This Computer";
            listViewDataItemGroup1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            listViewDataItemGroup2.Text = "Hard Disk Drives";
            listViewDataItemGroup2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            listViewDataItemGroup3.Text = "Devices with Removable Storage";
            listViewDataItemGroup3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radListView1.Groups.AddRange(new Telerik.WinControls.UI.ListViewDataItemGroup[] {
            listViewDataItemGroup1,
            listViewDataItemGroup2,
            listViewDataItemGroup3});
            listViewDataItem1.Group = listViewDataItemGroup1;
            listViewDataItem1.Image = global::Telerik.Examples.WinControls.Properties.Resources.folder_xp;
            listViewDataItem1.Text = "Shared Documents";
            listViewDataItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            listViewDataItem2.Group = listViewDataItemGroup1;
            listViewDataItem2.Image = global::Telerik.Examples.WinControls.Properties.Resources.folder_xp;
            listViewDataItem2.Text = "Administrator\'s Documents";
            listViewDataItem2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            listViewDataItem3.Group = listViewDataItemGroup3;
            listViewDataItem3.Image = global::Telerik.Examples.WinControls.Properties.Resources.floppy_drive;
            listViewDataItem3.Text = "3.5 Floppy (A:)";
            listViewDataItem3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            listViewDataItem4.Group = listViewDataItemGroup2;
            listViewDataItem4.Image = global::Telerik.Examples.WinControls.Properties.Resources.hard_drive;
            listViewDataItem4.Text = "Local Disk (C:)";
            listViewDataItem4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            listViewDataItem5.Group = listViewDataItemGroup2;
            listViewDataItem5.Image = global::Telerik.Examples.WinControls.Properties.Resources.hard_drive;
            listViewDataItem5.Text = "Local Disk (D:)";
            listViewDataItem5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            listViewDataItem6.Group = listViewDataItemGroup2;
            listViewDataItem6.Image = global::Telerik.Examples.WinControls.Properties.Resources.hard_drive;
            listViewDataItem6.Text = "Local Disk (E:)";
            listViewDataItem6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            listViewDataItem7.Group = listViewDataItemGroup2;
            listViewDataItem7.Image = global::Telerik.Examples.WinControls.Properties.Resources.hard_drive;
            listViewDataItem7.Text = "Local Disk (F:)";
            listViewDataItem7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            listViewDataItem8.Group = listViewDataItemGroup3;
            listViewDataItem8.Image = global::Telerik.Examples.WinControls.Properties.Resources.cd_drive;
            listViewDataItem8.Text = "DVD/CD-RW Drive (G:)";
            listViewDataItem8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            listViewDataItem9.Group = listViewDataItemGroup3;
            listViewDataItem9.Image = global::Telerik.Examples.WinControls.Properties.Resources.cd_drive;
            listViewDataItem9.Text = "CD-RW Drive (H:)";
            listViewDataItem9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radListView1.Items.AddRange(new Telerik.WinControls.UI.ListViewDataItem[] {
            listViewDataItem1,
            listViewDataItem2,
            listViewDataItem3,
            listViewDataItem4,
            listViewDataItem5,
            listViewDataItem6,
            listViewDataItem7,
            listViewDataItem8,
            listViewDataItem9});
            this.radListView1.ItemSize = new System.Drawing.Size(200, 32);
            this.radListView1.Location = new System.Drawing.Point(0, 30);
            this.radListView1.Name = "radListView1";
            this.radListView1.SelectedIndex = -1;
            this.radListView1.SelectedItem = null;
            this.radListView1.Size = new System.Drawing.Size(561, 380);
            this.radListView1.TabIndex = 1;
            this.radListView1.Text = "radListView1";
            this.radListView1.ViewTypeChanged += new System.EventHandler(this.radListView1_ViewTypeChanged);
            // 
            // radCheckBoxShowCheckboxes
            // 
            this.radCheckBoxShowCheckboxes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radCheckBoxShowCheckboxes.Location = new System.Drawing.Point(5, 19);
            this.radCheckBoxShowCheckboxes.Name = "radCheckBoxShowCheckboxes";
            this.radCheckBoxShowCheckboxes.Size = new System.Drawing.Size(113, 18);
            this.radCheckBoxShowCheckboxes.TabIndex = 2;
            this.radCheckBoxShowCheckboxes.Text = "Show Check Boxes";
            this.radCheckBoxShowCheckboxes.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBoxShowCheckboxes_ToggleStateChanged);
            // 
            // radCheckBoxGroups
            // 
            this.radCheckBoxGroups.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radCheckBoxGroups.Location = new System.Drawing.Point(5, 57);
            this.radCheckBoxGroups.Name = "radCheckBoxGroups";
            this.radCheckBoxGroups.Size = new System.Drawing.Size(87, 18);
            this.radCheckBoxGroups.TabIndex = 4;
            this.radCheckBoxGroups.Text = "Show Groups";
            this.radCheckBoxGroups.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBoxGroups_ToggleStateChanged);
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupBox1.Controls.Add(this.radCheckBoxShowCheckboxes);
            this.radGroupBox1.Controls.Add(this.radCheckBoxGroups);
            this.radGroupBox1.Controls.Add(this.radCheckBoxFullRowSelect);
            this.radGroupBox1.FooterImageIndex = -1;
            this.radGroupBox1.FooterImageKey = "";
            this.radGroupBox1.HeaderImageIndex = -1;
            this.radGroupBox1.HeaderImageKey = "";
            this.radGroupBox1.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBox1.HeaderText = "General Settings";
            this.radGroupBox1.Location = new System.Drawing.Point(10, 85);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            // 
            // 
            // 
            this.radGroupBox1.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.radGroupBox1.Size = new System.Drawing.Size(180, 78);
            this.radGroupBox1.TabIndex = 7;
            this.radGroupBox1.Text = "General Settings";
            // 
            // radCheckBoxFullRowSelect
            // 
            this.radCheckBoxFullRowSelect.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radCheckBoxFullRowSelect.Location = new System.Drawing.Point(5, 38);
            this.radCheckBoxFullRowSelect.Name = "radCheckBoxFullRowSelect";
            this.radCheckBoxFullRowSelect.Size = new System.Drawing.Size(125, 18);
            this.radCheckBoxFullRowSelect.TabIndex = 14;
            this.radCheckBoxFullRowSelect.Text = "Enable FullRowSelect";
            this.radCheckBoxFullRowSelect.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBoxFullRowSelect_ToggleStateChanged);
            // 
            // radLabel2
            // 
            this.radLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radLabel2.Location = new System.Drawing.Point(5, 21);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(62, 18);
            this.radLabel2.TabIndex = 8;
            this.radLabel2.Text = "Item Width";
            // 
            // radLabel3
            // 
            this.radLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radLabel3.Location = new System.Drawing.Point(5, 65);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(71, 18);
            this.radLabel3.TabIndex = 9;
            this.radLabel3.Text = "Item Spacing";
            // 
            // radLabel4
            // 
            this.radLabel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radLabel4.Location = new System.Drawing.Point(5, 87);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(74, 18);
            this.radLabel4.TabIndex = 10;
            this.radLabel4.Text = "Group Height";
            // 
            // radLabel5
            // 
            this.radLabel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radLabel5.Controls.Add(this.radCheckBox4);
            this.radLabel5.Location = new System.Drawing.Point(5, 109);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(73, 18);
            this.radLabel5.TabIndex = 11;
            this.radLabel5.Text = "Group Indent";
            // 
            // radCheckBox4
            // 
            this.radCheckBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radCheckBox4.Location = new System.Drawing.Point(0, 22);
            this.radCheckBox4.Name = "radCheckBox4";
            this.radCheckBox4.Size = new System.Drawing.Size(154, 18);
            this.radCheckBox4.TabIndex = 12;
            this.radCheckBox4.Text = "Allow Arbitrary Item Width";
            // 
            // radCheckBoxArbWidth
            // 
            this.radCheckBoxArbWidth.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radCheckBoxArbWidth.Location = new System.Drawing.Point(5, 131);
            this.radCheckBoxArbWidth.Name = "radCheckBoxArbWidth";
            this.radCheckBoxArbWidth.Size = new System.Drawing.Size(154, 18);
            this.radCheckBoxArbWidth.TabIndex = 12;
            this.radCheckBoxArbWidth.Text = "Allow Arbitrary Item Width";
            this.radCheckBoxArbWidth.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBoxArbWidth_ToggleStateChanged);
            // 
            // radCheckBoxArbHeight
            // 
            this.radCheckBoxArbHeight.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radCheckBoxArbHeight.Location = new System.Drawing.Point(5, 149);
            this.radCheckBoxArbHeight.Name = "radCheckBoxArbHeight";
            this.radCheckBoxArbHeight.Size = new System.Drawing.Size(157, 18);
            this.radCheckBoxArbHeight.TabIndex = 13;
            this.radCheckBoxArbHeight.Text = "Allow Arbitrary Item Height";
            this.radCheckBoxArbHeight.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBoxArbHeight_ToggleStateChanged);
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupBox2.Controls.Add(this.radLabel8);
            this.radGroupBox2.Controls.Add(this.radSpinEditorGroupHeight);
            this.radGroupBox2.Controls.Add(this.radSpinEditorItemHeight);
            this.radGroupBox2.Controls.Add(this.radSpinEditorItemWidth);
            this.radGroupBox2.Controls.Add(this.radSpinEditorGroupIndent);
            this.radGroupBox2.Controls.Add(this.radSpinEditorItemSpacing);
            this.radGroupBox2.Controls.Add(this.radLabel2);
            this.radGroupBox2.Controls.Add(this.radLabel3);
            this.radGroupBox2.Controls.Add(this.radCheckBoxArbHeight);
            this.radGroupBox2.Controls.Add(this.radLabel4);
            this.radGroupBox2.Controls.Add(this.radCheckBoxArbWidth);
            this.radGroupBox2.Controls.Add(this.radLabel5);
            this.radGroupBox2.FooterImageIndex = -1;
            this.radGroupBox2.FooterImageKey = "";
            this.radGroupBox2.HeaderImageIndex = -1;
            this.radGroupBox2.HeaderImageKey = "";
            this.radGroupBox2.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBox2.HeaderText = "Sizing Settings";
            this.radGroupBox2.Location = new System.Drawing.Point(10, 166);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            // 
            // 
            // 
            this.radGroupBox2.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.radGroupBox2.Size = new System.Drawing.Size(180, 169);
            this.radGroupBox2.TabIndex = 15;
            this.radGroupBox2.Text = "Sizing Settings";
            // 
            // radSpinEditorGroupHeight
            // 
            this.radSpinEditorGroupHeight.Location = new System.Drawing.Point(90, 85);
            this.radSpinEditorGroupHeight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.radSpinEditorGroupHeight.Name = "radSpinEditorGroupHeight";
            // 
            // 
            // 
            this.radSpinEditorGroupHeight.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radSpinEditorGroupHeight.ShowBorder = true;
            this.radSpinEditorGroupHeight.Size = new System.Drawing.Size(85, 20);
            this.radSpinEditorGroupHeight.TabIndex = 23;
            this.radSpinEditorGroupHeight.TabStop = false;
            this.radSpinEditorGroupHeight.ValueChanged += new System.EventHandler(this.radSpinEditorGroupHeight_ValueChanged);
            // 
            // radSpinEditorItemHeight
            // 
            this.radSpinEditorItemHeight.Location = new System.Drawing.Point(90, 41);
            this.radSpinEditorItemHeight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.radSpinEditorItemHeight.Name = "radSpinEditorItemHeight";
            // 
            // 
            // 
            this.radSpinEditorItemHeight.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radSpinEditorItemHeight.ShowBorder = true;
            this.radSpinEditorItemHeight.Size = new System.Drawing.Size(85, 20);
            this.radSpinEditorItemHeight.TabIndex = 21;
            this.radSpinEditorItemHeight.TabStop = false;
            this.radSpinEditorItemHeight.ValueChanged += new System.EventHandler(this.radSpinEditorItemHeight_ValueChanged);
            // 
            // radSpinEditorItemWidth
            // 
            this.radSpinEditorItemWidth.Location = new System.Drawing.Point(90, 19);
            this.radSpinEditorItemWidth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.radSpinEditorItemWidth.Name = "radSpinEditorItemWidth";
            // 
            // 
            // 
            this.radSpinEditorItemWidth.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radSpinEditorItemWidth.ShowBorder = true;
            this.radSpinEditorItemWidth.Size = new System.Drawing.Size(85, 20);
            this.radSpinEditorItemWidth.TabIndex = 20;
            this.radSpinEditorItemWidth.TabStop = false;
            this.radSpinEditorItemWidth.ValueChanged += new System.EventHandler(this.radSpinEditorItemWidth_ValueChanged);
            // 
            // radSpinEditorGroupIndent
            // 
            this.radSpinEditorGroupIndent.Location = new System.Drawing.Point(90, 108);
            this.radSpinEditorGroupIndent.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.radSpinEditorGroupIndent.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.radSpinEditorGroupIndent.Name = "radSpinEditorGroupIndent";
            // 
            // 
            // 
            this.radSpinEditorGroupIndent.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radSpinEditorGroupIndent.ShowBorder = true;
            this.radSpinEditorGroupIndent.Size = new System.Drawing.Size(85, 20);
            this.radSpinEditorGroupIndent.TabIndex = 19;
            this.radSpinEditorGroupIndent.TabStop = false;
            this.radSpinEditorGroupIndent.ValueChanged += new System.EventHandler(this.radSpinEditorGroupIndent_ValueChanged);
            // 
            // radSpinEditorItemSpacing
            // 
            this.radSpinEditorItemSpacing.Location = new System.Drawing.Point(90, 63);
            this.radSpinEditorItemSpacing.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.radSpinEditorItemSpacing.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.radSpinEditorItemSpacing.Name = "radSpinEditorItemSpacing";
            // 
            // 
            // 
            this.radSpinEditorItemSpacing.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radSpinEditorItemSpacing.ShowBorder = true;
            this.radSpinEditorItemSpacing.Size = new System.Drawing.Size(85, 20);
            this.radSpinEditorItemSpacing.TabIndex = 18;
            this.radSpinEditorItemSpacing.TabStop = false;
            this.radSpinEditorItemSpacing.ValueChanged += new System.EventHandler(this.radSpinEditorItemSpacing_ValueChanged);
            // 
            // radGroupBoxDetailView
            // 
            this.radGroupBoxDetailView.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBoxDetailView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupBoxDetailView.Controls.Add(this.radSpinEditorHeaderHeight);
            this.radGroupBoxDetailView.Controls.Add(this.radCheckBoxColHeaders);
            this.radGroupBoxDetailView.Controls.Add(this.radCheckBoxColSort);
            this.radGroupBoxDetailView.Controls.Add(this.radCheckBoxColReorder);
            this.radGroupBoxDetailView.Controls.Add(this.radCheckBoxColResize);
            this.radGroupBoxDetailView.Controls.Add(this.radLabel6);
            this.radGroupBoxDetailView.FooterImageIndex = -1;
            this.radGroupBoxDetailView.FooterImageKey = "";
            this.radGroupBoxDetailView.HeaderImageIndex = -1;
            this.radGroupBoxDetailView.HeaderImageKey = "";
            this.radGroupBoxDetailView.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBoxDetailView.HeaderText = "Detail View Settings";
            this.radGroupBoxDetailView.Location = new System.Drawing.Point(10, 338);
            this.radGroupBoxDetailView.Name = "radGroupBoxDetailView";
            this.radGroupBoxDetailView.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            // 
            // 
            // 
            this.radGroupBoxDetailView.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.radGroupBoxDetailView.Size = new System.Drawing.Size(180, 131);
            this.radGroupBoxDetailView.TabIndex = 16;
            this.radGroupBoxDetailView.Text = "Detail View Settings";
            // 
            // radSpinEditorHeaderHeight
            // 
            this.radSpinEditorHeaderHeight.Location = new System.Drawing.Point(90, 21);
            this.radSpinEditorHeaderHeight.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.radSpinEditorHeaderHeight.Name = "radSpinEditorHeaderHeight";
            // 
            // 
            // 
            this.radSpinEditorHeaderHeight.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radSpinEditorHeaderHeight.ShowBorder = true;
            this.radSpinEditorHeaderHeight.Size = new System.Drawing.Size(85, 20);
            this.radSpinEditorHeaderHeight.TabIndex = 19;
            this.radSpinEditorHeaderHeight.TabStop = false;
            this.radSpinEditorHeaderHeight.Value = new decimal(new int[] {
            35,
            0,
            0,
            0});
            this.radSpinEditorHeaderHeight.ValueChanged += new System.EventHandler(this.radSpinEditorHeaderHeight_ValueChanged);
            // 
            // radCheckBoxColHeaders
            // 
            this.radCheckBoxColHeaders.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radCheckBoxColHeaders.Location = new System.Drawing.Point(5, 45);
            this.radCheckBoxColHeaders.Name = "radCheckBoxColHeaders";
            this.radCheckBoxColHeaders.Size = new System.Drawing.Size(134, 18);
            this.radCheckBoxColHeaders.TabIndex = 16;
            this.radCheckBoxColHeaders.Text = "Show Column Headers";
            this.radCheckBoxColHeaders.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.radCheckBoxColHeaders.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBoxColHeaders_ToggleStateChanged);
            // 
            // radCheckBoxColSort
            // 
            this.radCheckBoxColSort.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radCheckBoxColSort.Location = new System.Drawing.Point(5, 108);
            this.radCheckBoxColSort.Name = "radCheckBoxColSort";
            this.radCheckBoxColSort.Size = new System.Drawing.Size(119, 18);
            this.radCheckBoxColSort.TabIndex = 15;
            this.radCheckBoxColSort.Text = "Enable Column Sort";
            this.radCheckBoxColSort.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBoxColSort_ToggleStateChanged);
            // 
            // radCheckBoxColReorder
            // 
            this.radCheckBoxColReorder.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radCheckBoxColReorder.Location = new System.Drawing.Point(5, 87);
            this.radCheckBoxColReorder.Name = "radCheckBoxColReorder";
            this.radCheckBoxColReorder.Size = new System.Drawing.Size(138, 18);
            this.radCheckBoxColReorder.TabIndex = 14;
            this.radCheckBoxColReorder.Text = "Enable Column Reorder";
            this.radCheckBoxColReorder.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.radCheckBoxColReorder.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBoxColReorder_ToggleStateChanged);
            // 
            // radCheckBoxColResize
            // 
            this.radCheckBoxColResize.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radCheckBoxColResize.Location = new System.Drawing.Point(5, 66);
            this.radCheckBoxColResize.Name = "radCheckBoxColResize";
            this.radCheckBoxColResize.Size = new System.Drawing.Size(130, 18);
            this.radCheckBoxColResize.TabIndex = 13;
            this.radCheckBoxColResize.Text = "Enable Column Resize";
            this.radCheckBoxColResize.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.radCheckBoxColResize.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBoxColResize_ToggleStateChanged);
            // 
            // radLabel6
            // 
            this.radLabel6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radLabel6.Location = new System.Drawing.Point(5, 21);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(79, 18);
            this.radLabel6.TabIndex = 9;
            this.radLabel6.Text = "Header Height";
            // 
            // radGroupBoxIconView
            // 
            this.radGroupBoxIconView.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBoxIconView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupBoxIconView.Controls.Add(this.radDropDownList2);
            this.radGroupBoxIconView.Controls.Add(this.radLabel7);
            this.radGroupBoxIconView.FooterImageIndex = -1;
            this.radGroupBoxIconView.FooterImageKey = "";
            this.radGroupBoxIconView.HeaderImageIndex = -1;
            this.radGroupBoxIconView.HeaderImageKey = "";
            this.radGroupBoxIconView.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBoxIconView.HeaderText = "Icon View Settings";
            this.radGroupBoxIconView.Location = new System.Drawing.Point(10, 472);
            this.radGroupBoxIconView.Name = "radGroupBoxIconView";
            this.radGroupBoxIconView.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            // 
            // 
            // 
            this.radGroupBoxIconView.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.radGroupBoxIconView.Size = new System.Drawing.Size(180, 48);
            this.radGroupBoxIconView.TabIndex = 17;
            this.radGroupBoxIconView.Text = "Icon View Settings";
            // 
            // radDropDownList2
            // 
            this.radDropDownList2.DropDownAnimationEnabled = true;
            radListDataItem4.Text = "Vertical";
            radListDataItem4.TextWrap = true;
            radListDataItem5.Text = "Horizontal";
            radListDataItem5.TextWrap = true;
            this.radDropDownList2.Items.Add(radListDataItem4);
            this.radDropDownList2.Items.Add(radListDataItem5);
            this.radDropDownList2.Location = new System.Drawing.Point(69, 21);
            this.radDropDownList2.Name = "radDropDownList2";
            this.radDropDownList2.ShowImageInEditorArea = true;
            this.radDropDownList2.Size = new System.Drawing.Size(106, 20);
            this.radDropDownList2.TabIndex = 11;
            this.radDropDownList2.Text = "Vertical";
            this.radDropDownList2.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.radDropDownList2_SelectedIndexChanged);
            // 
            // radLabel7
            // 
            this.radLabel7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radLabel7.Location = new System.Drawing.Point(5, 22);
            this.radLabel7.Name = "radLabel7";
            this.radLabel7.Size = new System.Drawing.Size(63, 18);
            this.radLabel7.TabIndex = 10;
            this.radLabel7.Text = "Orientation";
            // 
            // radGroupBox5
            // 
            this.radGroupBox5.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupBox5.Controls.Add(this.radDropDownListViewType);
            this.radGroupBox5.Controls.Add(this.radLabel1);
            this.radGroupBox5.FooterImageIndex = -1;
            this.radGroupBox5.FooterImageKey = "";
            this.radGroupBox5.HeaderImageIndex = -1;
            this.radGroupBox5.HeaderImageKey = "";
            this.radGroupBox5.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBox5.HeaderText = "View Type";
            this.radGroupBox5.Location = new System.Drawing.Point(10, 35);
            this.radGroupBox5.Name = "radGroupBox5";
            this.radGroupBox5.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            // 
            // 
            // 
            this.radGroupBox5.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.radGroupBox5.Size = new System.Drawing.Size(180, 47);
            this.radGroupBox5.TabIndex = 18;
            this.radGroupBox5.Text = "View Type";
            // 
            // radDropDownListViewType
            // 
            this.radDropDownListViewType.DropDownAnimationEnabled = true;
            this.radDropDownListViewType.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            radListDataItem1.Text = "List View";
            radListDataItem1.TextWrap = true;
            radListDataItem2.Text = "Icon View";
            radListDataItem2.TextWrap = true;
            radListDataItem3.Text = "Detail View";
            radListDataItem3.TextWrap = true;
            this.radDropDownListViewType.Items.Add(radListDataItem1);
            this.radDropDownListViewType.Items.Add(radListDataItem2);
            this.radDropDownListViewType.Items.Add(radListDataItem3);
            this.radDropDownListViewType.Location = new System.Drawing.Point(69, 19);
            this.radDropDownListViewType.Name = "radDropDownListViewType";
            this.radDropDownListViewType.ShowImageInEditorArea = true;
            this.radDropDownListViewType.Size = new System.Drawing.Size(106, 20);
            this.radDropDownListViewType.TabIndex = 3;
            this.radDropDownListViewType.Text = "List View";
            this.radDropDownListViewType.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.radDropDownListViewType_SelectedIndexChanged);
            // 
            // radLabel1
            // 
            this.radLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radLabel1.Location = new System.Drawing.Point(5, 21);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(33, 18);
            this.radLabel1.TabIndex = 2;
            this.radLabel1.Text = "View:";
            // 
            // radLabel8
            // 
            this.radLabel8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radLabel8.Location = new System.Drawing.Point(5, 43);
            this.radLabel8.Name = "radLabel8";
            this.radLabel8.Size = new System.Drawing.Size(65, 18);
            this.radLabel8.TabIndex = 24;
            this.radLabel8.Text = "Item Height";
            // 
            // radPanel1
            // 
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(561, 30);
            this.radPanel1.TabIndex = 2;
            this.radPanel1.Text = "My Computer";
            // 
            // radPanel2
            // 
            this.radPanel2.Controls.Add(this.radListView1);
            this.radPanel2.Controls.Add(this.radPanel1);
            this.radPanel2.Location = new System.Drawing.Point(3, 72);
            this.radPanel2.Name = "radPanel2";
            this.radPanel2.Size = new System.Drawing.Size(561, 372);
            this.radPanel2.TabIndex = 3;
            this.radPanel2.Text = "radPanel2";
            // 
            // Form1
            // 
            this.AutoScroll = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radPanel2);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1233, 832);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            this.Controls.SetChildIndex(this.radPanel2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radListView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxShowCheckboxes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxFullRowSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            this.radLabel5.ResumeLayout(false);
            this.radLabel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxArbWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxArbHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            this.radGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorGroupHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorItemHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorItemWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorGroupIndent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorItemSpacing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBoxDetailView)).EndInit();
            this.radGroupBoxDetailView.ResumeLayout(false);
            this.radGroupBoxDetailView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorHeaderHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxColHeaders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxColSort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxColReorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxColResize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBoxIconView)).EndInit();
            this.radGroupBoxIconView.ResumeLayout(false);
            this.radGroupBoxIconView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox5)).EndInit();
            this.radGroupBox5.ResumeLayout(false);
            this.radGroupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownListViewType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
            this.radPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadListView radListView1;
        private Telerik.WinControls.UI.RadCheckBox radCheckBoxShowCheckboxes;
        private Telerik.WinControls.UI.RadCheckBox radCheckBoxGroups;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadCheckBox radCheckBox4;
        private Telerik.WinControls.UI.RadCheckBox radCheckBoxArbWidth;
        private Telerik.WinControls.UI.RadCheckBox radCheckBoxArbHeight;
        private Telerik.WinControls.UI.RadCheckBox radCheckBoxFullRowSelect;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private Telerik.WinControls.UI.RadGroupBox radGroupBoxDetailView;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Telerik.WinControls.UI.RadCheckBox radCheckBoxColResize;
        private Telerik.WinControls.UI.RadCheckBox radCheckBoxColReorder;
        private Telerik.WinControls.UI.RadCheckBox radCheckBoxColSort;
        private Telerik.WinControls.UI.RadCheckBox radCheckBoxColHeaders;
        private Telerik.WinControls.UI.RadGroupBox radGroupBoxIconView;
        private Telerik.WinControls.UI.RadLabel radLabel7;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox5;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadDropDownList radDropDownListViewType;
        private Telerik.WinControls.UI.RadSpinEditor radSpinEditorItemSpacing;
        private Telerik.WinControls.UI.RadSpinEditor radSpinEditorGroupIndent;
        private Telerik.WinControls.UI.RadDropDownList radDropDownList2;
        private Telerik.WinControls.UI.RadSpinEditor radSpinEditorHeaderHeight;
        private Telerik.WinControls.UI.RadSpinEditor radSpinEditorItemWidth;
        private Telerik.WinControls.UI.RadSpinEditor radSpinEditorItemHeight;
        private Telerik.WinControls.UI.RadSpinEditor radSpinEditorGroupHeight;
        private Telerik.WinControls.UI.RadLabel radLabel8;
        private TreeExampleHeaderPanel radPanel1;
        private Telerik.WinControls.UI.RadPanel radPanel2;
    }
}