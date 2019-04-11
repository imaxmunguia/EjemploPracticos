using Telerik.WinControls.UI;
namespace Telerik.Examples.WinControls.ComboBoxAndListBox.ComboBox.Events
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.radComboDemo = new Telerik.WinControls.UI.RadDropDownList();
            this.dropDownElement1 = new Telerik.WinControls.UI.RadListDataItem();
            this.dropDownElement2 = new Telerik.WinControls.UI.RadListDataItem();
            this.dropDownElement3 = new Telerik.WinControls.UI.RadListDataItem();
            this.dropDownElement4 = new Telerik.WinControls.UI.RadListDataItem();
            this.dropDownElement5 = new Telerik.WinControls.UI.RadListDataItem();
            this.dropDownElement6 = new Telerik.WinControls.UI.RadListDataItem();
            this.dropDownElement7 = new Telerik.WinControls.UI.RadListDataItem();
            this.dropDownElement8 = new Telerik.WinControls.UI.RadListDataItem();
            this.dropDownElement9 = new Telerik.WinControls.UI.RadListDataItem();
            this.dropDownElement10 = new Telerik.WinControls.UI.RadListDataItem();
            this.radGroupSettings = new Telerik.WinControls.UI.RadGroupBox();
            this.radComboSort = new Telerik.WinControls.UI.RadDropDownList();
            this.radComboBoxItem3 = new Telerik.WinControls.UI.RadListDataItem();
            this.radComboBoxItem4 = new Telerik.WinControls.UI.RadListDataItem();
            this.radComboBoxItem5 = new Telerik.WinControls.UI.RadListDataItem();
            this.radCheckCase = new Telerik.WinControls.UI.RadCheckBox();
            this.radLblSort = new Telerik.WinControls.UI.RadLabel();
            this.radLblDropDownStyle = new Telerik.WinControls.UI.RadLabel();
            this.radComboDropDownStyle = new Telerik.WinControls.UI.RadDropDownList();
            this.radComboBoxItem1 = new Telerik.WinControls.UI.RadListDataItem();
            this.radComboBoxItem2 = new Telerik.WinControls.UI.RadListDataItem();
            this.radGroupEvents = new Telerik.WinControls.UI.RadGroupBox();
            this.radTxtEvents = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelDemoHolder)).BeginInit();
            this.radPanelDemoHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radComboDemo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupSettings)).BeginInit();
            this.radGroupSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radComboSort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckCase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLblSort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLblDropDownStyle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radComboDropDownStyle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupEvents)).BeginInit();
            this.radGroupEvents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTxtEvents)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanelDemoHolder
            // 
            this.radPanelDemoHolder.Controls.Add(this.radComboDemo);
            this.radPanelDemoHolder.Location = new System.Drawing.Point(431, 194);
            this.radPanelDemoHolder.MaximumSize = new System.Drawing.Size(362, 100);
            this.radPanelDemoHolder.MinimumSize = new System.Drawing.Size(362, 100);
            // 
            // 
            // 
            this.radPanelDemoHolder.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radPanelDemoHolder.RootElement.MaxSize = new System.Drawing.Size(362, 100);
            this.radPanelDemoHolder.RootElement.MinSize = new System.Drawing.Size(362, 100);
            this.radPanelDemoHolder.Size = new System.Drawing.Size(362, 100);
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radGroupEvents);
            this.settingsPanel.Controls.Add(this.radGroupSettings);
            this.settingsPanel.Location = new System.Drawing.Point(1023, 1);
            // 
            // 
            // 
            this.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black;
            this.settingsPanel.Size = new System.Drawing.Size(200, 486);
            this.settingsPanel.Controls.SetChildIndex(this.radGroupSettings, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radGroupEvents, 0);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "WizardPicture.bmp");
            this.imageList1.Images.SetKeyName(1, "bulb_on.GIF");
            this.imageList1.Images.SetKeyName(2, "CLSDFOLD.BMP");
            this.imageList1.Images.SetKeyName(3, "test.bmp");
            this.imageList1.Images.SetKeyName(4, "untitled.bmp");
            // 
            // radComboDemo
            // 
            this.radComboDemo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radComboDemo.BackColor = System.Drawing.Color.Transparent;
            this.radComboDemo.DropDownSizingMode = ((Telerik.WinControls.UI.SizingMode)((Telerik.WinControls.UI.SizingMode.RightBottom | Telerik.WinControls.UI.SizingMode.UpDown)));
            this.radComboDemo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radComboDemo.ForeColor = System.Drawing.Color.Black;            
            this.radComboDemo.Items.AddRange(new RadListDataItem[] {
            this.dropDownElement1,
            this.dropDownElement2,
            this.dropDownElement3,
            this.dropDownElement4,
            this.dropDownElement5,
            this.dropDownElement6,
            this.dropDownElement7,
            this.dropDownElement8,
            this.dropDownElement9,
            this.dropDownElement10});
            this.radComboDemo.Location = new System.Drawing.Point(28, 40);                        
            this.radComboDemo.NullText = "Choose City...";
            // 
            // 
            // 
            this.radComboDemo.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radComboDemo.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radComboDemo.RootElement.ToolTipText = null;
            this.radComboDemo.Size = new System.Drawing.Size(306, 20);
            this.radComboDemo.TabIndex = 0;
            this.radComboDemo.TabStop = false;
            this.radComboDemo.Text = "";
            this.radComboDemo.ThemeName = "ControlDefault";
            // 
            // dropDownElement1
            // 
            
            this.dropDownElement1.Text = "Amsterdam";
            // 
            // dropDownElement2
            // 
            
            this.dropDownElement2.Text = "Barcelona";
            // 
            // dropDownElement3
            // 
            
            this.dropDownElement3.Text = "Bonn";
            // 
            // dropDownElement4
            // 
            
            this.dropDownElement4.Text = "Brussels";
            // 
            // dropDownElement5
            // 
            
            this.dropDownElement5.Text = "New York";
            // 
            // dropDownElement6
            // 
            
            this.dropDownElement6.Text = "London";
            // 
            // dropDownElement7
            // 
            
            this.dropDownElement7.Text = "Paris";
            // 
            // dropDownElement8
            // 
            
            this.dropDownElement8.Text = "Sofia";
            // 
            // dropDownElement9
            // 
             this.dropDownElement9.Text = "Prague";
           // 
            // dropDownElement10
            // 
            this.dropDownElement10.Text = "Hamburg";
            // 
            // radGroupSettings
            // 
            this.radGroupSettings.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupSettings.Controls.Add(this.radComboSort);
            this.radGroupSettings.Controls.Add(this.radCheckCase);
            this.radGroupSettings.Controls.Add(this.radLblSort);
            this.radGroupSettings.Controls.Add(this.radLblDropDownStyle);
            this.radGroupSettings.Controls.Add(this.radComboDropDownStyle);
            this.radGroupSettings.FooterImageIndex = -1;
            this.radGroupSettings.FooterImageKey = "";
            this.radGroupSettings.FooterText = "";
            this.radGroupSettings.ForeColor = System.Drawing.Color.Black;
            this.radGroupSettings.HeaderImageIndex = -1;
            this.radGroupSettings.HeaderImageKey = "";
            this.radGroupSettings.HeaderMargin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.radGroupSettings.HeaderText = "Settings";
            this.radGroupSettings.Location = new System.Drawing.Point(10, 6);
            this.radGroupSettings.Name = "radGroupSettings";
            this.radGroupSettings.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            // 
            // 
            // 
            this.radGroupSettings.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radGroupSettings.Size = new System.Drawing.Size(163, 160);
            this.radGroupSettings.TabIndex = 0;
            this.radGroupSettings.Text = "Settings";
            // 
            // radComboSort
            // 
            this.radComboSort.DropDownSizingMode = ((Telerik.WinControls.UI.SizingMode)((Telerik.WinControls.UI.SizingMode.RightBottom | Telerik.WinControls.UI.SizingMode.UpDown)));
            this.radComboSort.ForeColor = System.Drawing.Color.Black;
            this.radComboSort.Items.AddRange(new RadListDataItem[] {
            this.radComboBoxItem3,
            this.radComboBoxItem4,
            this.radComboBoxItem5});
            this.radComboSort.Location = new System.Drawing.Point(18, 96);
            this.radComboSort.Name = "radComboSort";
            // 
            // 
            // 
            this.radComboSort.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radComboSort.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radComboSort.Size = new System.Drawing.Size(122, 20);
            this.radComboSort.TabIndex = 1;
            this.radComboSort.Text = "";
            // 
            // radComboBoxItem3
            // 
            
            this.radComboBoxItem3.Text = "Ascending";
            // 
            // radComboBoxItem4
            // 
            
            this.radComboBoxItem4.Text = "Descending";
            // 
            // radComboBoxItem5
            // 
            
            this.radComboBoxItem5.Text = "None";
            // 
            // radCheckCase
            // 
            this.radCheckCase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.radCheckCase.Location = new System.Drawing.Point(18, 125);
            this.radCheckCase.Name = "radCheckCase";
            // 
            // 
            // 
            this.radCheckCase.RootElement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.radCheckCase.Size = new System.Drawing.Size(96, 17);
            this.radCheckCase.TabIndex = 4;
            this.radCheckCase.Text = "Case sensitive";
            this.radCheckCase.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.chBoxCaseSensitive_CheckedChanged);
            // 
            // radLblSort
            // 
            this.radLblSort.ForeColor = System.Drawing.Color.Black;
            this.radLblSort.Location = new System.Drawing.Point(18, 72);
            this.radLblSort.Name = "radLblSort";
            // 
            // 
            // 
            this.radLblSort.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radLblSort.Size = new System.Drawing.Size(74, 14);
            this.radLblSort.TabIndex = 3;
            this.radLblSort.Text = "Sort direction:";
            // 
            // radLblDropDownStyle
            // 
            this.radLblDropDownStyle.ForeColor = System.Drawing.Color.Black;
            this.radLblDropDownStyle.Location = new System.Drawing.Point(18, 19);
            this.radLblDropDownStyle.Name = "radLblDropDownStyle";
            // 
            // 
            // 
            this.radLblDropDownStyle.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radLblDropDownStyle.Size = new System.Drawing.Size(89, 14);
            this.radLblDropDownStyle.TabIndex = 2;
            this.radLblDropDownStyle.Text = "Drop-down style:";
            // 
            // radComboDropDownStyle
            // 
            this.radComboDropDownStyle.DropDownSizingMode = ((Telerik.WinControls.UI.SizingMode)((Telerik.WinControls.UI.SizingMode.RightBottom | Telerik.WinControls.UI.SizingMode.UpDown)));
            this.radComboDropDownStyle.ForeColor = System.Drawing.Color.Black;
            this.radComboDropDownStyle.Items.AddRange(new RadListDataItem[] {
            this.radComboBoxItem1,
            this.radComboBoxItem2});
            this.radComboDropDownStyle.Location = new System.Drawing.Point(18, 43);
            this.radComboDropDownStyle.Name = "radComboDropDownStyle";
            // 
            // 
            // 
            this.radComboDropDownStyle.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radComboDropDownStyle.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radComboDropDownStyle.Size = new System.Drawing.Size(122, 20);
            this.radComboDropDownStyle.TabIndex = 0;
            this.radComboDropDownStyle.Text = "";
            // 
            // radComboBoxItem1
            // 
            
            this.radComboBoxItem1.Text = "DropDown";
            // 
            // radComboBoxItem2
            // 
            
            this.radComboBoxItem2.Text = "DropDownList";
            // 
            // radGroupEvents
            // 
            this.radGroupEvents.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupEvents.Controls.Add(this.radTxtEvents);
            this.radGroupEvents.FooterImageIndex = -1;
            this.radGroupEvents.FooterImageKey = "";
            this.radGroupEvents.FooterText = "";
            this.radGroupEvents.ForeColor = System.Drawing.Color.Black;
            this.radGroupEvents.HeaderImageIndex = -1;
            this.radGroupEvents.HeaderImageKey = "";
            this.radGroupEvents.HeaderMargin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.radGroupEvents.HeaderText = " Events ";
            this.radGroupEvents.Location = new System.Drawing.Point(10, 172);
            this.radGroupEvents.Name = "radGroupEvents";
            this.radGroupEvents.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            // 
            // 
            // 
            this.radGroupEvents.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radGroupEvents.Size = new System.Drawing.Size(163, 322);
            this.radGroupEvents.TabIndex = 1;
            this.radGroupEvents.Text = " Events ";
            // 
            // radTxtEvents
            // 
            this.radTxtEvents.ForeColor = System.Drawing.Color.Black;
            this.radTxtEvents.Location = new System.Drawing.Point(22, 26);
            this.radTxtEvents.Multiline = true;
            this.radTxtEvents.Name = "radTxtEvents";
            // 
            // 
            // 
            this.radTxtEvents.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radTxtEvents.RootElement.StretchVertically = true;
            this.radTxtEvents.Size = new System.Drawing.Size(136, 283);
            this.radTxtEvents.TabIndex = 0;
            // 
            // Form1
            // 
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(2, 35, 2, 4);
            this.Size = new System.Drawing.Size(1224, 488);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPanelDemoHolder)).EndInit();
            this.radPanelDemoHolder.ResumeLayout(false);
            this.radPanelDemoHolder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radComboDemo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupSettings)).EndInit();
            this.radGroupSettings.ResumeLayout(false);
            this.radGroupSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radComboSort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckCase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLblSort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLblDropDownStyle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radComboDropDownStyle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupEvents)).EndInit();
            this.radGroupEvents.ResumeLayout(false);
            this.radGroupEvents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTxtEvents)).EndInit();
            this.ResumeLayout(false);

		}        

		#endregion

        private Telerik.WinControls.UI.RadDropDownList radComboDemo;
		private Telerik.WinControls.UI.RadListDataItem dropDownElement1;
		private Telerik.WinControls.UI.RadListDataItem dropDownElement2;
		private Telerik.WinControls.UI.RadListDataItem dropDownElement3;
		private Telerik.WinControls.UI.RadListDataItem dropDownElement4;
		private Telerik.WinControls.UI.RadListDataItem dropDownElement5;
		private Telerik.WinControls.UI.RadListDataItem dropDownElement6;
		private Telerik.WinControls.UI.RadListDataItem dropDownElement7;
		private Telerik.WinControls.UI.RadListDataItem dropDownElement8;
		private Telerik.WinControls.UI.RadListDataItem dropDownElement9;
		private Telerik.WinControls.UI.RadListDataItem dropDownElement10;
        private System.Windows.Forms.ImageList imageList1;
        private Telerik.WinControls.UI.RadGroupBox radGroupSettings;
        private Telerik.WinControls.UI.RadGroupBox radGroupEvents;
        private Telerik.WinControls.UI.RadCheckBox radCheckCase;
        private Telerik.WinControls.UI.RadLabel radLblSort;
        private Telerik.WinControls.UI.RadLabel radLblDropDownStyle;
        private Telerik.WinControls.UI.RadDropDownList radComboSort;
        private Telerik.WinControls.UI.RadDropDownList radComboDropDownStyle;
        private Telerik.WinControls.UI.RadTextBox radTxtEvents;
        private Telerik.WinControls.UI.RadListDataItem radComboBoxItem3;
        private Telerik.WinControls.UI.RadListDataItem radComboBoxItem4;
        private Telerik.WinControls.UI.RadListDataItem radComboBoxItem5;
        private Telerik.WinControls.UI.RadListDataItem radComboBoxItem1;
        private Telerik.WinControls.UI.RadListDataItem radComboBoxItem2;
	}
}