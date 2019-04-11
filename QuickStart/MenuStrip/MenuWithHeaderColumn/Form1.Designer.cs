namespace Telerik.Examples.WinControls.MenuStrip.MenuWithHeaderColumn
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
            this.radMenuDemo = new Telerik.WinControls.UI.RadMenu();
            this.radMenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem2 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem3 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem4 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem5 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuSeparatorItem1 = new Telerik.WinControls.UI.RadMenuSeparatorItem();
            this.radMenuItem6 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuSeparatorItem2 = new Telerik.WinControls.UI.RadMenuSeparatorItem();
            this.radMenuItem10 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem7 = new Telerik.WinControls.UI.RadMenuItem();
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
            this.radMenuDemo.ForeColor = System.Drawing.Color.Black;
            this.radMenuDemo.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem1,
            this.radMenuItem7});
            this.radMenuDemo.Location = new System.Drawing.Point(1, 1);
            this.radMenuDemo.Name = "radMenuDemo";
            // 
            // 
            // 
            this.radMenuDemo.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radMenuDemo.Size = new System.Drawing.Size(499, 27);
            this.radMenuDemo.TabIndex = 0;
            this.radMenuDemo.Text = "radMenu1";
            // 
            // radMenuItem1
            // 
            this.radMenuItem1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem2,
            this.radMenuItem3,
            this.radMenuItem4,
            this.radMenuItem5,
            this.radMenuSeparatorItem1,
            this.radMenuItem6,
            this.radMenuSeparatorItem2,
            this.radMenuItem10});
            this.radMenuItem1.Name = "radMenuItem1";
            this.radMenuItem1.ShowArrow = false;
            this.radMenuItem1.Text = "File";
            // 
            // radMenuItem2
            // 
            this.radMenuItem2.Image = global::Telerik.Examples.WinControls.Properties.Resources.RibbonMenuNewMagenta;
            this.radMenuItem2.Name = "radMenuItem2";
            this.radMenuItem2.Padding = new System.Windows.Forms.Padding(-3);
            this.radMenuItem2.Text = "New";
            // 
            // radMenuItem3
            // 
            this.radMenuItem3.Image = global::Telerik.Examples.WinControls.Properties.Resources.RibbonMenuOpenMagenta;
            this.radMenuItem3.Name = "radMenuItem3";
            this.radMenuItem3.Padding = new System.Windows.Forms.Padding(-3);
            this.radMenuItem3.Text = "Open";
            // 
            // radMenuItem4
            // 
            this.radMenuItem4.Image = global::Telerik.Examples.WinControls.Properties.Resources.RibbonMenuSaveMagenta;
            this.radMenuItem4.Name = "radMenuItem4";
            this.radMenuItem4.Padding = new System.Windows.Forms.Padding(-3);
            this.radMenuItem4.Text = "Save";
            // 
            // radMenuItem5
            // 
            this.radMenuItem5.Image = global::Telerik.Examples.WinControls.Properties.Resources.RibbonMenuSaveAsMagenta;
            this.radMenuItem5.Name = "radMenuItem5";
            this.radMenuItem5.Padding = new System.Windows.Forms.Padding(-3);
            this.radMenuItem5.Text = "Save As";
            // 
            // radMenuSeparatorItem1
            // 
            this.radMenuSeparatorItem1.Name = "radMenuSeparatorItem1";
            this.radMenuSeparatorItem1.Text = "New item";
            // 
            // radMenuItem6
            // 
            this.radMenuItem6.Image = global::Telerik.Examples.WinControls.Properties.Resources._5RibbonbarMenuPrintMagenta;
            this.radMenuItem6.Name = "radMenuItem6";
            this.radMenuItem6.Padding = new System.Windows.Forms.Padding(-3);
            this.radMenuItem6.Text = "Print";
            // 
            // radMenuSeparatorItem2
            // 
            this.radMenuSeparatorItem2.Name = "radMenuSeparatorItem2";
            this.radMenuSeparatorItem2.Text = "New item";
            // 
            // radMenuItem10
            // 
            this.radMenuItem10.Image = global::Telerik.Examples.WinControls.Properties.Resources._9RibbonMenuCloseMagenta;
            this.radMenuItem10.Name = "radMenuItem10";
            this.radMenuItem10.Padding = new System.Windows.Forms.Padding(-3);
            this.radMenuItem10.Text = "Exit";
            // 
            // radMenuItem7
            // 
            this.radMenuItem7.Name = "radMenuItem7";
            this.radMenuItem7.ShowArrow = false;
            this.radMenuItem7.Text = "Edit";
            // 
            // radPanel1
            // 
            this.radPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radPanel1.BackColor = System.Drawing.Color.White;
            this.radPanel1.Controls.Add(this.radMenuDemo);
            this.radPanel1.Location = new System.Drawing.Point(362, 235);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Padding = new System.Windows.Forms.Padding(1, 1, 0, 0);
            // 
            // 
            // 
            this.radPanel1.RootElement.Padding = new System.Windows.Forms.Padding(1, 1, 0, 0);
            this.radPanel1.Size = new System.Drawing.Size(500, 350);
            this.radPanel1.TabIndex = 1;
            // 
            // Form1
            // 
            this.Controls.Add(this.radPanel1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1224, 820);
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private Telerik.WinControls.UI.RadMenuSeparatorItem radMenuSeparatorItem1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem6;
        private Telerik.WinControls.UI.RadMenuSeparatorItem radMenuSeparatorItem2;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem10;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem7;
        private Telerik.WinControls.UI.RadPanel radPanel1;
    }
}
