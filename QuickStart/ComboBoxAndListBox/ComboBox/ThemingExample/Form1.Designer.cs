using Telerik.WinControls.UI;
using System.Collections.Generic;
namespace Telerik.Examples.WinControls.ComboBoxAndListBox.ComboBox.ThemingExample
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
            this.radComboBox1 = new Telerik.WinControls.UI.RadDropDownList();
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
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Location = new System.Drawing.Point(775, 1);
            // 
            // 
            // 
            this.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black;
            this.settingsPanel.Size = new System.Drawing.Size(200, 641);
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
            // radComboBox1
            // 
            this.radComboBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.radComboBox1.DropDownSizingMode = ((Telerik.WinControls.UI.SizingMode)((Telerik.WinControls.UI.SizingMode.RightBottom | Telerik.WinControls.UI.SizingMode.UpDown)));
            this.radComboBox1.ForeColor = System.Drawing.Color.Black;
            this.radComboBox1.ImageList = this.imageList1;
            this.radComboBox1.Items.AddRange(new List<RadListDataItem>( new RadListDataItem[] {
            this.dropDownElement1,
            this.dropDownElement2,
            this.dropDownElement3,
            this.dropDownElement4,
            this.dropDownElement5,
            this.dropDownElement6,
            this.dropDownElement7,
            this.dropDownElement8,
            this.dropDownElement9,
            this.dropDownElement10}));
            this.radComboBox1.Location = new System.Drawing.Point(51, 22);
            this.radComboBox1.MaxDropDownItems = 6;
            this.radComboBox1.Name = "radComboBox1";
            this.radComboBox1.NullText = "Choose City...";
            // 
            // 
            // 
            this.radComboBox1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radComboBox1.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radComboBox1.RootElement.ToolTipText = null;
            this.radComboBox1.Size = new System.Drawing.Size(188, 20);
            this.radComboBox1.TabIndex = 0;
            this.radComboBox1.TabStop = false;
            this.radComboBox1.ThemeName = "ControlDefault";
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
            // radPanel1
            // 
            this.radPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("radPanel1.BackgroundImage")));
            this.radPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radPanel1.Controls.Add(this.radComboBox1);
            this.radPanel1.ForeColor = System.Drawing.Color.Black;
            this.radPanel1.Location = new System.Drawing.Point(16, 19);
            this.radPanel1.Name = "radPanel1";
            // 
            // 
            // 
            this.radPanel1.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radPanel1.Size = new System.Drawing.Size(300, 350);
            this.radPanel1.TabIndex = 4;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel1.GetChildAt(0).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radPanel1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(976, 643);
            this.Controls.SetChildIndex(this.radPanel1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ImageList imageList1;
		private Telerik.WinControls.UI.RadDropDownList radComboBox1;
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
        private Telerik.WinControls.UI.RadPanel radPanel1;
	}
}