namespace Telerik.Examples.WinControls.MenuStrip.BasicStates
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
            this.radMenuDemo = new Telerik.WinControls.UI.RadMenu();
            this.radMenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem4 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem5 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem6 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem7 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuSeparatorItem1 = new Telerik.WinControls.UI.RadMenuSeparatorItem();
            this.radMenuItem2 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem8 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem9 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem10 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem11 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem3 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem12 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem13 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem14 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem15 = new Telerik.WinControls.UI.RadMenuItem();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMenuDemo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.ForeColor = System.Drawing.Color.Black;
            this.settingsPanel.Location = new System.Drawing.Point(1023, 1);
            // 
            // 
            // 
            this.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black;
            this.settingsPanel.Size = new System.Drawing.Size(200, 818);
            this.settingsPanel.ThemeName = "ControlDefault";
            // 
            // radMenuDemo
            // 
            this.radMenuDemo.AllowMerge = false;
            this.radMenuDemo.BackColor = System.Drawing.Color.Transparent;
            this.radMenuDemo.ForeColor = System.Drawing.Color.Black;
            this.radMenuDemo.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem1,
            this.radMenuItem2,
            this.radMenuItem3});
            this.radMenuDemo.Location = new System.Drawing.Point(1, 1);
            this.radMenuDemo.Name = "radMenuDemo";
            // 
            // 
            // 
            this.radMenuDemo.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radMenuDemo.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radMenuDemo.RootElement.ToolTipText = null;
            this.radMenuDemo.Size = new System.Drawing.Size(499, 27);
            this.radMenuDemo.TabIndex = 0;
            this.radMenuDemo.Text = "radMenu1";
            // 
            // radMenuItem1
            // 
            this.radMenuItem1.ClickMode = Telerik.WinControls.ClickMode.Press;
            this.radMenuItem1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem4,
            this.radMenuItem5,
            this.radMenuItem6,
            this.radMenuItem7,
            this.radMenuSeparatorItem1});
            this.radMenuItem1.Name = "radMenuItem1";
            this.radMenuItem1.ShowArrow = false;
            this.radMenuItem1.Text = "Add items at runtime";
            this.radMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radMenuItem1.ToolTipText = null;
            // 
            // radMenuItem4
            // 
            this.radMenuItem4.Name = "radMenuItem4";
            this.radMenuItem4.Text = "Add a new Text file";
            this.radMenuItem4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radMenuItem4.ToolTipText = null;
            this.radMenuItem4.Click += new System.EventHandler(this.addItem_Click);
            // 
            // radMenuItem5
            // 
            this.radMenuItem5.Name = "radMenuItem5";
            this.radMenuItem5.Text = "Add a new XML file";
            this.radMenuItem5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radMenuItem5.ToolTipText = null;
            this.radMenuItem5.Click += new System.EventHandler(this.addItem_Click);
            // 
            // radMenuItem6
            // 
            this.radMenuItem6.Name = "radMenuItem6";
            this.radMenuItem6.Text = "Add a new Project";
            this.radMenuItem6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radMenuItem6.ToolTipText = null;
            this.radMenuItem6.Click += new System.EventHandler(this.addItem_Click);
            // 
            // radMenuItem7
            // 
            this.radMenuItem7.Name = "radMenuItem7";
            this.radMenuItem7.Text = "Add a new Solution";
            this.radMenuItem7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radMenuItem7.ToolTipText = null;
            this.radMenuItem7.Click += new System.EventHandler(this.addItem_Click);
            // 
            // radMenuSeparatorItem1
            // 
            this.radMenuSeparatorItem1.Name = "radMenuSeparatorItem1";
            this.radMenuSeparatorItem1.Text = "radMenuSeparatorItem1";
            // 
            // radMenuItem2
            // 
            this.radMenuItem2.ClickMode = Telerik.WinControls.ClickMode.Press;
            this.radMenuItem2.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem8,
            this.radMenuItem9,
            this.radMenuItem10,
            this.radMenuItem11});
            this.radMenuItem2.Name = "radMenuItem2";
            this.radMenuItem2.ShowArrow = false;
            this.radMenuItem2.Text = "Remove items at runtime";
            this.radMenuItem2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radMenuItem2.ToolTipText = null;
            // 
            // radMenuItem8
            // 
            this.radMenuItem8.Name = "radMenuItem8";
            this.radMenuItem8.Text = "Remove this Text file";
            this.radMenuItem8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radMenuItem8.ToolTipText = null;
            this.radMenuItem8.Click += new System.EventHandler(this.removeItem_Click);
            // 
            // radMenuItem9
            // 
            this.radMenuItem9.Name = "radMenuItem9";
            this.radMenuItem9.Text = "Remove this XML file";
            this.radMenuItem9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radMenuItem9.ToolTipText = null;
            this.radMenuItem9.Click += new System.EventHandler(this.removeItem_Click);
            // 
            // radMenuItem10
            // 
            this.radMenuItem10.Name = "radMenuItem10";
            this.radMenuItem10.Text = "Remove this Project";
            this.radMenuItem10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radMenuItem10.ToolTipText = null;
            this.radMenuItem10.Click += new System.EventHandler(this.removeItem_Click);
            // 
            // radMenuItem11
            // 
            this.radMenuItem11.Name = "radMenuItem11";
            this.radMenuItem11.Text = "Remove this Solution";
            this.radMenuItem11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radMenuItem11.ToolTipText = null;
            this.radMenuItem11.Click += new System.EventHandler(this.removeItem_Click);
            // 
            // radMenuItem3
            // 
            this.radMenuItem3.ClickMode = Telerik.WinControls.ClickMode.Press;
            this.radMenuItem3.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem12,
            this.radMenuItem13,
            this.radMenuItem14,
            this.radMenuItem15});
            this.radMenuItem3.Name = "radMenuItem3";
            this.radMenuItem3.ShowArrow = false;
            this.radMenuItem3.Text = "Disable items at runtime";
            this.radMenuItem3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radMenuItem3.ToolTipText = null;
            // 
            // radMenuItem12
            // 
            this.radMenuItem12.Name = "radMenuItem12";
            this.radMenuItem12.Text = "Disable this Text file";
            this.radMenuItem12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radMenuItem12.ToolTipText = null;
            this.radMenuItem12.Click += new System.EventHandler(this.disableItem_Click);
            // 
            // radMenuItem13
            // 
            this.radMenuItem13.Name = "radMenuItem13";
            this.radMenuItem13.Text = "Disable this XML file";
            this.radMenuItem13.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radMenuItem13.ToolTipText = null;
            this.radMenuItem13.Click += new System.EventHandler(this.disableItem_Click);
            // 
            // radMenuItem14
            // 
            this.radMenuItem14.Name = "radMenuItem14";
            this.radMenuItem14.Text = "Disable this Project";
            this.radMenuItem14.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radMenuItem14.ToolTipText = null;
            this.radMenuItem14.Click += new System.EventHandler(this.disableItem_Click);
            // 
            // radMenuItem15
            // 
            this.radMenuItem15.Name = "radMenuItem15";
            this.radMenuItem15.Text = "Disable this Solution";
            this.radMenuItem15.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radMenuItem15.ToolTipText = null;
            this.radMenuItem15.Click += new System.EventHandler(this.disableItem_Click);
            // 
            // radPanel1
            // 
            this.radPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radPanel1.BackColor = System.Drawing.Color.White;
            this.radPanel1.Controls.Add(this.radMenuDemo);
            this.radPanel1.ForeColor = System.Drawing.Color.Black;
            this.radPanel1.Location = new System.Drawing.Point(370, 236);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Padding = new System.Windows.Forms.Padding(1, 1, 0, 0);
            // 
            // 
            // 
            this.radPanel1.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radPanel1.RootElement.Padding = new System.Windows.Forms.Padding(1, 1, 0, 0);
            this.radPanel1.Size = new System.Drawing.Size(500, 350);
            this.radPanel1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoSize = true;
            this.Controls.Add(this.radPanel1);
            this.MaximumSize = new System.Drawing.Size(1280, 994);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(2, 35, 2, 4);
            this.Size = new System.Drawing.Size(1224, 820);
            this.Controls.SetChildIndex(this.radPanel1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMenuDemo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

		private Telerik.WinControls.UI.RadMenu radMenuDemo;
		private Telerik.WinControls.UI.RadMenuItem radMenuItem1;
		private Telerik.WinControls.UI.RadMenuItem radMenuItem2;
		private Telerik.WinControls.UI.RadMenuItem radMenuItem3;
		private Telerik.WinControls.UI.RadMenuItem radMenuItem4;
		private Telerik.WinControls.UI.RadMenuItem radMenuItem5;
		private Telerik.WinControls.UI.RadMenuItem radMenuItem6;
		private Telerik.WinControls.UI.RadMenuItem radMenuItem7;
		private Telerik.WinControls.UI.RadMenuItem radMenuItem8;
		private Telerik.WinControls.UI.RadMenuItem radMenuItem9;
		private Telerik.WinControls.UI.RadMenuItem radMenuItem10;
		private Telerik.WinControls.UI.RadMenuItem radMenuItem11;
		private Telerik.WinControls.UI.RadMenuItem radMenuItem12;
		private Telerik.WinControls.UI.RadMenuItem radMenuItem13;
		private Telerik.WinControls.UI.RadMenuItem radMenuItem14;
		private Telerik.WinControls.UI.RadMenuItem radMenuItem15;
        private Telerik.WinControls.UI.RadMenuSeparatorItem radMenuSeparatorItem1;
        private Telerik.WinControls.UI.RadPanel radPanel1;
    }
}