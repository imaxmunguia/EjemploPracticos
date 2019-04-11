namespace Telerik.Examples.WinControls.Docking.CustomDockTabStrip
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radDock1 = new Telerik.WinControls.UI.Docking.RadDock();
            this.documentWindow2 = new Telerik.WinControls.UI.Docking.DocumentWindow();
            this.radSplitContainer2 = new Telerik.WinControls.UI.RadSplitContainer();
            this.radSplitContainer1 = new Telerik.WinControls.UI.RadSplitContainer();
            this.toolTabStrip1 = new Telerik.WinControls.UI.Docking.ToolTabStrip();
            this.toolWindow1 = new Telerik.WinControls.UI.Docking.ToolWindow();
            this.documentContainer1 = new Telerik.WinControls.UI.Docking.DocumentContainer();
            this.documentTabStrip1 = new Telerik.WinControls.UI.Docking.DocumentTabStrip();
            this.documentWindow1 = new Telerik.WinControls.UI.Docking.DocumentWindow();
            this.toolTabStrip2 = new Telerik.WinControls.UI.Docking.ToolTabStrip();
            this.toolWindow2 = new Telerik.WinControls.UI.Docking.ToolWindow();
            this.toolTabStrip3 = new Telerik.WinControls.UI.Docking.ToolTabStrip();
            this.toolWindow3 = new Telerik.WinControls.UI.Docking.ToolWindow();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.docTabAlignCombo = new Telerik.WinControls.UI.RadDropDownList();
            this.toolTabAlignCombo = new Telerik.WinControls.UI.RadDropDownList();
            this.docTabsVisibleCheck = new Telerik.WinControls.UI.RadCheckBox();
            this.toolTabsVisibleCheck = new Telerik.WinControls.UI.RadCheckBox();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.docCloseButtonCheck = new Telerik.WinControls.UI.RadCheckBox();
            this.docTextOrientationCombo = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.toolCloseButtonCheck = new Telerik.WinControls.UI.RadCheckBox();
            this.toolTextOrientationCombo = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radDock1)).BeginInit();
            this.radDock1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer2)).BeginInit();
            this.radSplitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).BeginInit();
            this.radSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip1)).BeginInit();
            this.toolTabStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentContainer1)).BeginInit();
            this.documentContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentTabStrip1)).BeginInit();
            this.documentTabStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip2)).BeginInit();
            this.toolTabStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip3)).BeginInit();
            this.toolTabStrip3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docTabAlignCombo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolTabAlignCombo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docTabsVisibleCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolTabsVisibleCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.docCloseButtonCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docTextOrientationCombo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toolCloseButtonCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolTextOrientationCombo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radGroupBox2);
            this.settingsPanel.Controls.Add(this.radGroupBox1);
            this.settingsPanel.Location = new System.Drawing.Point(552, 1);
            this.settingsPanel.Size = new System.Drawing.Size(200, 806);
            this.settingsPanel.ThemeName = "ControlDefault";
            this.settingsPanel.Controls.SetChildIndex(this.radGroupBox1, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radGroupBox2, 0);
            // 
            // radDock1
            // 
            this.radDock1.ActiveWindow = this.documentWindow2;
            this.radDock1.Controls.Add(this.radSplitContainer2);
            this.radDock1.Controls.Add(this.toolTabStrip3);
            this.radDock1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.radDock1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radDock1.DocumentManager.DocumentInsertOrder = Telerik.WinControls.UI.Docking.DockWindowInsertOrder.InFront;
            this.radDock1.Location = new System.Drawing.Point(0, 0);
            this.radDock1.MainDocumentContainer = this.documentContainer1;
            this.radDock1.Name = "radDock1";
            // 
            // 
            // 
            this.radDock1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.radDock1.Size = new System.Drawing.Size(753, 808);
            this.radDock1.TabIndex = 1;
            this.radDock1.TabStop = false;
            this.radDock1.Text = "radDock1";
            // 
            // documentWindow2
            // 
            this.documentWindow2.Location = new System.Drawing.Point(5, 27);
            this.documentWindow2.Name = "documentWindow2";
            this.documentWindow2.Size = new System.Drawing.Size(337, 573);
            this.documentWindow2.Text = "documentWindow2";
            // 
            // radSplitContainer2
            // 
            this.radSplitContainer2.Controls.Add(this.radSplitContainer1);
            this.radSplitContainer2.Controls.Add(this.toolTabStrip2);
            this.radSplitContainer2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.radSplitContainer2.IsCleanUpTarget = true;
            this.radSplitContainer2.Location = new System.Drawing.Point(0, 0);
            this.radSplitContainer2.Name = "radSplitContainer2";
            this.radSplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // 
            // 
            this.radSplitContainer2.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.radSplitContainer2.Size = new System.Drawing.Size(550, 808);
            this.radSplitContainer2.TabIndex = 0;
            this.radSplitContainer2.TabStop = false;
            // 
            // radSplitContainer1
            // 
            this.radSplitContainer1.Controls.Add(this.toolTabStrip1);
            this.radSplitContainer1.Controls.Add(this.documentContainer1);
            this.radSplitContainer1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.radSplitContainer1.IsCleanUpTarget = true;
            this.radSplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.radSplitContainer1.Name = "radSplitContainer1";
            // 
            // 
            // 
            this.radSplitContainer1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.radSplitContainer1.Size = new System.Drawing.Size(550, 605);
            this.radSplitContainer1.TabIndex = 0;
            this.radSplitContainer1.TabStop = false;
            // 
            // toolTabStrip1
            // 
            this.toolTabStrip1.Controls.Add(this.toolWindow1);
            this.toolTabStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolTabStrip1.Name = "toolTabStrip1";
            // 
            // 
            // 
            this.toolTabStrip1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.toolTabStrip1.SelectedIndex = 0;
            this.toolTabStrip1.Size = new System.Drawing.Size(200, 605);
            this.toolTabStrip1.TabIndex = 1;
            this.toolTabStrip1.TabStop = false;
            // 
            // toolWindow1
            // 
            this.toolWindow1.Location = new System.Drawing.Point(1, 26);
            this.toolWindow1.Name = "toolWindow1";
            this.toolWindow1.Size = new System.Drawing.Size(198, 578);
            this.toolWindow1.Text = "toolWindow1";
            // 
            // documentContainer1
            // 
            this.documentContainer1.Controls.Add(this.documentTabStrip1);
            this.documentContainer1.Location = new System.Drawing.Point(203, 0);
            this.documentContainer1.Name = "documentContainer1";
            // 
            // 
            // 
            this.documentContainer1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.documentContainer1.Size = new System.Drawing.Size(347, 605);
            this.documentContainer1.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill;
            this.documentContainer1.TabIndex = 0;
            this.documentContainer1.TabStop = false;
            // 
            // documentTabStrip1
            // 
            this.documentTabStrip1.Controls.Add(this.documentWindow2);
            this.documentTabStrip1.Controls.Add(this.documentWindow1);
            this.documentTabStrip1.Location = new System.Drawing.Point(0, 0);
            this.documentTabStrip1.Name = "documentTabStrip1";
            // 
            // 
            // 
            this.documentTabStrip1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.documentTabStrip1.SelectedIndex = 0;
            this.documentTabStrip1.Size = new System.Drawing.Size(347, 605);
            this.documentTabStrip1.TabIndex = 0;
            this.documentTabStrip1.TabStop = false;
            // 
            // documentWindow1
            // 
            this.documentWindow1.Location = new System.Drawing.Point(5, 27);
            this.documentWindow1.Name = "documentWindow1";
            this.documentWindow1.Size = new System.Drawing.Size(549, 296);
            this.documentWindow1.Text = "documentWindow1";
            // 
            // toolTabStrip2
            // 
            this.toolTabStrip2.Controls.Add(this.toolWindow2);
            this.toolTabStrip2.Location = new System.Drawing.Point(0, 608);
            this.toolTabStrip2.Name = "toolTabStrip2";
            // 
            // 
            // 
            this.toolTabStrip2.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.toolTabStrip2.SelectedIndex = 0;
            this.toolTabStrip2.Size = new System.Drawing.Size(550, 200);
            this.toolTabStrip2.TabIndex = 1;
            this.toolTabStrip2.TabStop = false;
            // 
            // toolWindow2
            // 
            this.toolWindow2.Location = new System.Drawing.Point(1, 26);
            this.toolWindow2.Name = "toolWindow2";
            this.toolWindow2.Size = new System.Drawing.Size(548, 173);
            this.toolWindow2.Text = "toolWindow2";
            // 
            // toolTabStrip3
            // 
            this.toolTabStrip3.Controls.Add(this.toolWindow3);
            this.toolTabStrip3.Location = new System.Drawing.Point(553, 0);
            this.toolTabStrip3.Name = "toolTabStrip3";
            // 
            // 
            // 
            this.toolTabStrip3.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.toolTabStrip3.SelectedIndex = 0;
            this.toolTabStrip3.Size = new System.Drawing.Size(200, 808);
            this.toolTabStrip3.TabIndex = 1;
            this.toolTabStrip3.TabStop = false;
            // 
            // toolWindow3
            // 
            this.toolWindow3.Location = new System.Drawing.Point(1, 26);
            this.toolWindow3.Name = "toolWindow3";
            this.toolWindow3.Size = new System.Drawing.Size(198, 781);
            this.toolWindow3.Text = "toolWindow3";
            // 
            // radLabel1
            // 
            this.radLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radLabel1.Location = new System.Drawing.Point(13, 23);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(60, 16);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "Alignment:";
            // 
            // docTabAlignCombo
            // 
            this.docTabAlignCombo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.docTabAlignCombo.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.docTabAlignCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.docTabAlignCombo.FormatString = "{0}";
            this.docTabAlignCombo.Location = new System.Drawing.Point(13, 43);
            this.docTabAlignCombo.Name = "docTabAlignCombo";
            // 
            // 
            // 
            this.docTabAlignCombo.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.docTabAlignCombo.RootElement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.docTabAlignCombo.Size = new System.Drawing.Size(154, 20);
            this.docTabAlignCombo.TabIndex = 2;
            this.docTabAlignCombo.TabStop = false;
            this.docTabAlignCombo.Text = "radComboBox1";
            this.docTabAlignCombo.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(docTabAlignCombo_SelectedIndexChanged);
            // 
            // toolTabAlignCombo
            // 
            this.toolTabAlignCombo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.toolTabAlignCombo.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.toolTabAlignCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.toolTabAlignCombo.FormatString = "{0}";
            this.toolTabAlignCombo.Location = new System.Drawing.Point(13, 43);
            this.toolTabAlignCombo.Name = "toolTabAlignCombo";
            // 
            // 
            // 
            this.toolTabAlignCombo.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.toolTabAlignCombo.RootElement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.toolTabAlignCombo.Size = new System.Drawing.Size(154, 20);
            this.toolTabAlignCombo.TabIndex = 4;
            this.toolTabAlignCombo.TabStop = false;
            this.toolTabAlignCombo.Text = "radComboBox1";
            this.toolTabAlignCombo.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.toolTabAlignCombo_SelectedIndexChanged);
            // 
            // docTabsVisibleCheck
            // 
            this.docTabsVisibleCheck.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.docTabsVisibleCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.docTabsVisibleCheck.Location = new System.Drawing.Point(13, 139);
            this.docTabsVisibleCheck.Name = "docTabsVisibleCheck";
            // 
            // 
            // 
            this.docTabsVisibleCheck.RootElement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.docTabsVisibleCheck.Size = new System.Drawing.Size(154, 18);
            this.docTabsVisibleCheck.TabIndex = 5;
            this.docTabsVisibleCheck.Text = "Visible";
            this.docTabsVisibleCheck.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.docTabsVisibleCheck_ToggleStateChanged);
            // 
            // toolTabsVisibleCheck
            // 
            this.toolTabsVisibleCheck.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.toolTabsVisibleCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.toolTabsVisibleCheck.Location = new System.Drawing.Point(13, 139);
            this.toolTabsVisibleCheck.Name = "toolTabsVisibleCheck";
            // 
            // 
            // 
            this.toolTabsVisibleCheck.RootElement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.toolTabsVisibleCheck.Size = new System.Drawing.Size(154, 18);
            this.toolTabsVisibleCheck.TabIndex = 6;
            this.toolTabsVisibleCheck.Text = "Visible";
            this.toolTabsVisibleCheck.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.toolTabsVisibleCheck_ToggleStateChanged);
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupBox1.Controls.Add(this.docCloseButtonCheck);
            this.radGroupBox1.Controls.Add(this.docTextOrientationCombo);
            this.radGroupBox1.Controls.Add(this.radLabel3);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.Controls.Add(this.docTabAlignCombo);
            this.radGroupBox1.Controls.Add(this.docTabsVisibleCheck);
            this.radGroupBox1.FooterImageIndex = -1;
            this.radGroupBox1.FooterImageKey = "";
            this.radGroupBox1.HeaderImageIndex = -1;
            this.radGroupBox1.HeaderImageKey = "";
            this.radGroupBox1.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBox1.HeaderText = "Document Tabs";
            this.radGroupBox1.Location = new System.Drawing.Point(10, 37);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            // 
            // 
            // 
            this.radGroupBox1.RootElement.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.radGroupBox1.Size = new System.Drawing.Size(180, 167);
            this.radGroupBox1.TabIndex = 7;
            this.radGroupBox1.Text = "Document Tabs";
            // 
            // docCloseButtonCheck
            // 
            this.docCloseButtonCheck.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.docCloseButtonCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.docCloseButtonCheck.Location = new System.Drawing.Point(13, 115);
            this.docCloseButtonCheck.Name = "docCloseButtonCheck";
            // 
            // 
            // 
            this.docCloseButtonCheck.RootElement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.docCloseButtonCheck.Size = new System.Drawing.Size(154, 18);
            this.docCloseButtonCheck.TabIndex = 8;
            this.docCloseButtonCheck.Text = "Show Close Button";
            this.docCloseButtonCheck.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.docCloseButtonCheck_ToggleStateChanged);
            // 
            // docTextOrientationCombo
            // 
            this.docTextOrientationCombo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.docTextOrientationCombo.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.docTextOrientationCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.docTextOrientationCombo.FormatString = "{0}";
            this.docTextOrientationCombo.Location = new System.Drawing.Point(13, 89);
            this.docTextOrientationCombo.Name = "docTextOrientationCombo";
            // 
            // 
            // 
            this.docTextOrientationCombo.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.docTextOrientationCombo.RootElement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.docTextOrientationCombo.Size = new System.Drawing.Size(154, 20);
            this.docTextOrientationCombo.TabIndex = 7;
            this.docTextOrientationCombo.TabStop = false;
            this.docTextOrientationCombo.Text = "radComboBox1";
            this.docTextOrientationCombo.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.docTextOrientationCombo_SelectedIndexChanged);
            // 
            // radLabel3
            // 
            this.radLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radLabel3.Location = new System.Drawing.Point(13, 69);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(90, 16);
            this.radLabel3.TabIndex = 6;
            this.radLabel3.Text = "Text Orientation:";
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupBox2.Controls.Add(this.toolCloseButtonCheck);
            this.radGroupBox2.Controls.Add(this.toolTextOrientationCombo);
            this.radGroupBox2.Controls.Add(this.radLabel4);
            this.radGroupBox2.Controls.Add(this.toolTabsVisibleCheck);
            this.radGroupBox2.Controls.Add(this.radLabel5);
            this.radGroupBox2.Controls.Add(this.toolTabAlignCombo);
            this.radGroupBox2.FooterImageIndex = -1;
            this.radGroupBox2.FooterImageKey = "";
            this.radGroupBox2.HeaderImageIndex = -1;
            this.radGroupBox2.HeaderImageKey = "";
            this.radGroupBox2.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBox2.HeaderText = "Tool Tabs";
            this.radGroupBox2.Location = new System.Drawing.Point(10, 210);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            // 
            // 
            // 
            this.radGroupBox2.RootElement.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.radGroupBox2.Size = new System.Drawing.Size(180, 167);
            this.radGroupBox2.TabIndex = 8;
            this.radGroupBox2.Text = "Tool Tabs";
            // 
            // toolCloseButtonCheck
            // 
            this.toolCloseButtonCheck.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.toolCloseButtonCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.toolCloseButtonCheck.Location = new System.Drawing.Point(13, 115);
            this.toolCloseButtonCheck.Name = "toolCloseButtonCheck";
            // 
            // 
            // 
            this.toolCloseButtonCheck.RootElement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.toolCloseButtonCheck.Size = new System.Drawing.Size(154, 18);
            this.toolCloseButtonCheck.TabIndex = 8;
            this.toolCloseButtonCheck.Text = "Show Close Button";
            this.toolCloseButtonCheck.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.toolCloseButtonCheck_ToggleStateChanged);
            // 
            // toolTextOrientationCombo
            // 
            this.toolTextOrientationCombo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.toolTextOrientationCombo.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.toolTextOrientationCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.toolTextOrientationCombo.FormatString = "{0}";
            this.toolTextOrientationCombo.Location = new System.Drawing.Point(13, 89);
            this.toolTextOrientationCombo.Name = "toolTextOrientationCombo";
            // 
            // 
            // 
            this.toolTextOrientationCombo.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.toolTextOrientationCombo.RootElement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.toolTextOrientationCombo.Size = new System.Drawing.Size(154, 20);
            this.toolTextOrientationCombo.TabIndex = 7;
            this.toolTextOrientationCombo.TabStop = false;
            this.toolTextOrientationCombo.Text = "radComboBox1";
            this.toolTextOrientationCombo.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.toolTextOrientationCombo_SelectedIndexChanged);
            // 
            // radLabel4
            // 
            this.radLabel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radLabel4.Location = new System.Drawing.Point(13, 69);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(90, 16);
            this.radLabel4.TabIndex = 6;
            this.radLabel4.Text = "Text Orientation:";
            // 
            // radLabel5
            // 
            this.radLabel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radLabel5.Location = new System.Drawing.Point(13, 23);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(60, 16);
            this.radLabel5.TabIndex = 1;
            this.radLabel5.Text = "Alignment:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radDock1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(753, 808);
            this.Controls.SetChildIndex(this.radDock1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radDock1)).EndInit();
            this.radDock1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer2)).EndInit();
            this.radSplitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).EndInit();
            this.radSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip1)).EndInit();
            this.toolTabStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.documentContainer1)).EndInit();
            this.documentContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.documentTabStrip1)).EndInit();
            this.documentTabStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip2)).EndInit();
            this.toolTabStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip3)).EndInit();
            this.toolTabStrip3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docTabAlignCombo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolTabAlignCombo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docTabsVisibleCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolTabsVisibleCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.docCloseButtonCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docTextOrientationCombo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            this.radGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toolCloseButtonCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolTextOrientationCombo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.Docking.RadDock radDock1;
        private Telerik.WinControls.UI.Docking.DocumentContainer documentContainer1;
        private Telerik.WinControls.UI.RadDropDownList docTabAlignCombo;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadCheckBox toolTabsVisibleCheck;
        private Telerik.WinControls.UI.RadCheckBox docTabsVisibleCheck;
        private Telerik.WinControls.UI.RadDropDownList toolTabAlignCombo;
        private Telerik.WinControls.UI.Docking.DocumentWindow documentWindow2;
        private Telerik.WinControls.UI.RadSplitContainer radSplitContainer2;
        private Telerik.WinControls.UI.RadSplitContainer radSplitContainer1;
        private Telerik.WinControls.UI.Docking.ToolTabStrip toolTabStrip1;
        private Telerik.WinControls.UI.Docking.ToolWindow toolWindow1;
        private Telerik.WinControls.UI.Docking.DocumentTabStrip documentTabStrip1;
        private Telerik.WinControls.UI.Docking.DocumentWindow documentWindow1;
        private Telerik.WinControls.UI.Docking.ToolTabStrip toolTabStrip2;
        private Telerik.WinControls.UI.Docking.ToolWindow toolWindow2;
        private Telerik.WinControls.UI.Docking.ToolTabStrip toolTabStrip3;
        private Telerik.WinControls.UI.Docking.ToolWindow toolWindow3;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadDropDownList docTextOrientationCombo;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private Telerik.WinControls.UI.RadDropDownList toolTextOrientationCombo;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadCheckBox docCloseButtonCheck;
        private Telerik.WinControls.UI.RadCheckBox toolCloseButtonCheck;
    }
}
