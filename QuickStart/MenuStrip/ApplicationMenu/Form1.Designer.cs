using System.ComponentModel;
namespace Telerik.Examples.WinControls.MenuStrip.ApplicationMenu
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
            this.radAppMenuDemo = new Telerik.WinControls.UI.RadApplicationMenu();
            this.radMenuButtonItem1 = new Telerik.WinControls.UI.RadMenuButtonItem();
            this.radMenuButtonItem2 = new Telerik.WinControls.UI.RadMenuButtonItem();
            this.radMenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem2 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem3 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem4 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuHeaderItem2 = new Telerik.WinControls.UI.RadMenuHeaderItem();
            this.radMenuItem13 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem14 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem15 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem16 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuSeparatorItem1 = new Telerik.WinControls.UI.RadMenuSeparatorItem();
            this.radMenuItem5 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuHeaderItem3 = new Telerik.WinControls.UI.RadMenuHeaderItem();
            this.radMenuItem17 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem18 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem19 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuSeparatorItem2 = new Telerik.WinControls.UI.RadMenuSeparatorItem();
            this.radMenuItem9 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuHeaderItem1 = new Telerik.WinControls.UI.RadMenuHeaderItem();
            this.radMenuItem10 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem11 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem12 = new Telerik.WinControls.UI.RadMenuItem();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radAppMenuDemo)).BeginInit();
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
            // radAppMenuDemo
            // 
            this.radAppMenuDemo.ButtonItems.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuButtonItem1,
            this.radMenuButtonItem2});
            this.radAppMenuDemo.ForeColor = System.Drawing.Color.Black;
            this.radAppMenuDemo.Image = global::Telerik.Examples.WinControls.Properties.Resources.telerikLogo1;
            this.radAppMenuDemo.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radAppMenuDemo.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem1,
            this.radMenuItem2,
            this.radMenuItem3,
            this.radMenuItem4,
            this.radMenuSeparatorItem1,
            this.radMenuItem5,
            this.radMenuSeparatorItem2,
            this.radMenuItem9});
            this.radAppMenuDemo.Location = new System.Drawing.Point(2, 2);
            this.radAppMenuDemo.Margin = new System.Windows.Forms.Padding(0);
            this.radAppMenuDemo.Name = "radAppMenuDemo";
            this.radAppMenuDemo.RightColumnItems.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuHeaderItem1,
            this.radMenuItem10,
            this.radMenuItem11,
            this.radMenuItem12});
            // 
            // 
            // 
            this.radAppMenuDemo.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radAppMenuDemo.Size = new System.Drawing.Size(45, 45);
            this.radAppMenuDemo.TabIndex = 0;
            this.radAppMenuDemo.Text = "radApplicationMenu1";
            // 
            // radMenuButtonItem1
            // 
            // 
            // 
            // 
            this.radMenuButtonItem1.ButtonElement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radMenuButtonItem1.Name = "radMenuButtonItem1";
            this.radMenuButtonItem1.Text = "Options";
            // 
            // radMenuButtonItem2
            // 
            // 
            // 
            // 
            this.radMenuButtonItem2.ButtonElement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radMenuButtonItem2.Name = "radMenuButtonItem2";
            this.radMenuButtonItem2.Text = "Exit";
            // 
            // radMenuItem1
            // 
            this.radMenuItem1.Image = global::Telerik.Examples.WinControls.Properties.Resources.RibbonMenuNewMagenta;
            this.radMenuItem1.Name = "radMenuItem1";
            this.radMenuItem1.Text = "New";
            // 
            // radMenuItem2
            // 
            this.radMenuItem2.Image = global::Telerik.Examples.WinControls.Properties.Resources.RibbonMenuOpenMagenta;
            this.radMenuItem2.Name = "radMenuItem2";
            this.radMenuItem2.Text = "Open";
            // 
            // radMenuItem3
            // 
            this.radMenuItem3.Image = global::Telerik.Examples.WinControls.Properties.Resources.RibbonMenuSaveMagenta;
            this.radMenuItem3.Name = "radMenuItem3";
            this.radMenuItem3.Text = "Save";
            // 
            // radMenuItem4
            // 
            this.radMenuItem4.Image = global::Telerik.Examples.WinControls.Properties.Resources.RibbonMenuSaveAsMagenta;
            this.radMenuItem4.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuHeaderItem2,
            this.radMenuItem13,
            this.radMenuItem14,
            this.radMenuItem15,
            this.radMenuItem16});
            this.radMenuItem4.Name = "radMenuItem4";
            this.radMenuItem4.Text = "Save As";
            // 
            // radMenuHeaderItem2
            // 
            this.radMenuHeaderItem2.Name = "radMenuHeaderItem2";
            this.radMenuHeaderItem2.Text = "Save a copy of the document";
            // 
            // radMenuItem13
            // 
            this.radMenuItem13.DescriptionText = "Save the document in the default file format.";
            this.radMenuItem13.Image = global::Telerik.Examples.WinControls.Properties.Resources.RibbonMenuSaveMagenta;
            this.radMenuItem13.Name = "radMenuItem13";
            this.radMenuItem13.Text = "Word Document";
            // 
            // radMenuItem14
            // 
            this.radMenuItem14.DescriptionText = "Save the document as a template that can be\n used to format future documents.";
            this.radMenuItem14.Image = global::Telerik.Examples.WinControls.Properties.Resources.RibbonMenuSaveMagenta;
            this.radMenuItem14.Name = "radMenuItem14";
            this.radMenuItem14.Text = "Word Template";
            // 
            // radMenuItem15
            // 
            this.radMenuItem15.DescriptionText = "Save a copy of the document that is fully\n compatible with Word97-2003";
            this.radMenuItem15.Image = global::Telerik.Examples.WinControls.Properties.Resources.RibbonMenuSaveMagenta;
            this.radMenuItem15.Name = "radMenuItem15";
            this.radMenuItem15.Text = "Word 97-2003 Document";
            // 
            // radMenuItem16
            // 
            this.radMenuItem16.DescriptionText = "Open the Save As dialog box to select from\n all possible file types.";
            this.radMenuItem16.Image = global::Telerik.Examples.WinControls.Properties.Resources.RibbonMenuSaveMagenta;
            this.radMenuItem16.Name = "radMenuItem16";
            this.radMenuItem16.Text = "Other Formats";
            // 
            // radMenuSeparatorItem1
            // 
            this.radMenuSeparatorItem1.Name = "radMenuSeparatorItem1";
            this.radMenuSeparatorItem1.Text = "New item";
            // 
            // radMenuItem5
            // 
            this.radMenuItem5.Image = global::Telerik.Examples.WinControls.Properties.Resources._5RibbonbarMenuPrintMagenta;
            this.radMenuItem5.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuHeaderItem3,
            this.radMenuItem17,
            this.radMenuItem18,
            this.radMenuItem19});
            this.radMenuItem5.Name = "radMenuItem5";
            this.radMenuItem5.Text = "Print";
            // 
            // radMenuHeaderItem3
            // 
            this.radMenuHeaderItem3.Name = "radMenuHeaderItem3";
            this.radMenuHeaderItem3.Text = "Preview and print the document";
            // 
            // radMenuItem17
            // 
            this.radMenuItem17.DescriptionText = "Select a printer, number of copies, and\n other printing options before printing.";
            this.radMenuItem17.Image = global::Telerik.Examples.WinControls.Properties.Resources._5RibbonbarMenuPrintMagenta;
            this.radMenuItem17.Name = "radMenuItem17";
            this.radMenuItem17.Text = "Print";
            // 
            // radMenuItem18
            // 
            this.radMenuItem18.DescriptionText = "Send the document directly to the printer,\n without making changes.";
            this.radMenuItem18.Image = global::Telerik.Examples.WinControls.Properties.Resources._5RibbonbarMenuPrintMagenta;
            this.radMenuItem18.Name = "radMenuItem18";
            this.radMenuItem18.Text = "Quick Print";
            // 
            // radMenuItem19
            // 
            this.radMenuItem19.DescriptionText = "Preview and make changes to pages before\n printing.";
            this.radMenuItem19.Image = global::Telerik.Examples.WinControls.Properties.Resources._5RibbonbarMenuPrintMagenta;
            this.radMenuItem19.Name = "radMenuItem19";
            this.radMenuItem19.Text = "Print Preview";
            // 
            // radMenuSeparatorItem2
            // 
            this.radMenuSeparatorItem2.Name = "radMenuSeparatorItem2";
            this.radMenuSeparatorItem2.Text = "New item";
            // 
            // radMenuItem9
            // 
            this.radMenuItem9.Image = global::Telerik.Examples.WinControls.Properties.Resources._9RibbonMenuCloseMagenta;
            this.radMenuItem9.Name = "radMenuItem9";
            this.radMenuItem9.Text = "Close";
            // 
            // radMenuHeaderItem1
            // 
            this.radMenuHeaderItem1.Name = "radMenuHeaderItem1";
            this.radMenuHeaderItem1.Text = "Recent Documents";
            // 
            // radMenuItem10
            // 
            this.radMenuItem10.Name = "radMenuItem10";
            this.radMenuItem10.Text = "Document 1.txt";
            // 
            // radMenuItem11
            // 
            this.radMenuItem11.Name = "radMenuItem11";
            this.radMenuItem11.Text = "Document 2.txt";
            // 
            // radMenuItem12
            // 
            this.radMenuItem12.Name = "radMenuItem12";
            this.radMenuItem12.Text = "Document 3.txt";
            // 
            // radPanel1
            // 
            this.radPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.radPanel1.Controls.Add(this.radAppMenuDemo);
            this.radPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPanel1.ForeColor = System.Drawing.Color.Black;
            this.radPanel1.Location = new System.Drawing.Point(362, 235);
            this.radPanel1.Name = "radPanel1";
            // 
            // 
            // 
            this.radPanel1.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radPanel1.Size = new System.Drawing.Size(500, 350);
            this.radPanel1.TabIndex = 1;
            // 
            // Form1
            // 
            this.Controls.Add(this.radPanel1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1224, 820);
            this.Controls.SetChildIndex(this.radPanel1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radAppMenuDemo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadApplicationMenu radAppMenuDemo;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem2;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem3;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem4;
        private Telerik.WinControls.UI.RadMenuSeparatorItem radMenuSeparatorItem1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem5;
        private Telerik.WinControls.UI.RadMenuSeparatorItem radMenuSeparatorItem2;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem9;
        private Telerik.WinControls.UI.RadMenuButtonItem radMenuButtonItem1;
        private Telerik.WinControls.UI.RadMenuButtonItem radMenuButtonItem2;
        private Telerik.WinControls.UI.RadMenuHeaderItem radMenuHeaderItem1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem10;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem11;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem12;
        private Telerik.WinControls.UI.RadMenuHeaderItem radMenuHeaderItem2;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem13;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem14;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem15;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem16;
        private Telerik.WinControls.UI.RadMenuHeaderItem radMenuHeaderItem3;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem17;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem18;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem19;
        private Telerik.WinControls.UI.RadPanel radPanel1;
    }
}
