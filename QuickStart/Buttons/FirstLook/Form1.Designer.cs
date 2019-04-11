using System.Drawing;

namespace Telerik.Examples.WinControls.Buttons.FirstLook
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
            this.radButton3 = new Telerik.WinControls.UI.RadButton();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            this.groupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radRadioOverlay = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioTxtBeforeImg = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioTxtAboveImg = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioImgBeforeTxt = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioImgAboveTxt = new Telerik.WinControls.UI.RadRadioButton();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelDemoHolder)).BeginInit();
            this.radPanelDemoHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioOverlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioTxtBeforeImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioTxtAboveImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioImgBeforeTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioImgAboveTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanelDemoHolder
            // 
            this.radPanelDemoHolder.Controls.Add(this.radLabel1);
            this.radPanelDemoHolder.Controls.Add(this.radLabel3);
            this.radPanelDemoHolder.Controls.Add(this.radButton3);
            this.radPanelDemoHolder.Controls.Add(this.radLabel2);
            this.radPanelDemoHolder.Controls.Add(this.radButton1);
            this.radPanelDemoHolder.Controls.Add(this.radButton2);
            this.radPanelDemoHolder.Location = new System.Drawing.Point(414, 276);
            // 
            // 
            // 
            this.radPanelDemoHolder.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radPanelDemoHolder.Size = new System.Drawing.Size(396, 185);
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.groupBox1);
            this.settingsPanel.Location = new System.Drawing.Point(1023, 1);
            // 
            // 
            // 
            this.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black;
            this.settingsPanel.Size = new System.Drawing.Size(200, 386);
            this.settingsPanel.Controls.SetChildIndex(this.groupBox1, 0);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Fuchsia;
            this.imageList1.Images.SetKeyName(0, "print.gif");
            this.imageList1.Images.SetKeyName(1, "bulb_on.GIF");
            this.imageList1.Images.SetKeyName(2, "bulb_off.GIF");
            this.imageList1.Images.SetKeyName(3, "iconDropDown.bmp");
            this.imageList1.Images.SetKeyName(4, "iconMoveToFolder.bmp");
            // 
            // radButton3
            // 
            this.radButton3.AutoSize = true;
            this.radButton3.BackColor = System.Drawing.Color.Transparent;
            this.radButton3.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radButton3.ImageIndex = 3;
            this.radButton3.ImageList = this.imageList1;
            this.radButton3.Location = new System.Drawing.Point(225, 109);
            this.radButton3.Name = "radButton3";
            // 
            // 
            // 
            this.radButton3.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radButton3.RootElement.ToolTipText = null;
            this.radButton3.Size = new System.Drawing.Size(96, 29);
            this.radButton3.TabIndex = 5;
            this.radButton3.Text = "Check Mail";
            this.radButton3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton3.GetChildAt(0))).Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton3.GetChildAt(0))).ImageIndex = 3;
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton3.GetChildAt(0))).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton3.GetChildAt(0))).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton3.GetChildAt(0))).TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton3.GetChildAt(0))).Text = "Check Mail";
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton3.GetChildAt(0))).Padding = new System.Windows.Forms.Padding(4);
            // 
            // radButton1
            // 
            this.radButton1.BackColor = System.Drawing.Color.Transparent;
            this.radButton1.Location = new System.Drawing.Point(225, 47);
            this.radButton1.Name = "radButton1";
            // 
            // 
            // 
            this.radButton1.RootElement.ToolTipText = null;
            this.radButton1.Size = new System.Drawing.Size(96, 25);
            this.radButton1.TabIndex = 3;
            this.radButton1.Text = "Check Mail";
            // 
            // radButton2
            // 
            this.radButton2.BackColor = System.Drawing.Color.Transparent;
            this.radButton2.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.radButton2.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radButton2.ImageIndex = 3;
            this.radButton2.ImageList = this.imageList1;
            this.radButton2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.radButton2.Location = new System.Drawing.Point(225, 78);
            this.radButton2.Name = "radButton2";
            // 
            // 
            // 
            this.radButton2.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radButton2.RootElement.ToolTipText = null;
            this.radButton2.Size = new System.Drawing.Size(96, 25);
            this.radButton2.TabIndex = 3;
            this.radButton2.Text = "radButton2";
            this.radButton2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.radRadioOverlay);
            this.groupBox1.Controls.Add(this.radRadioTxtBeforeImg);
            this.groupBox1.Controls.Add(this.radRadioTxtAboveImg);
            this.groupBox1.Controls.Add(this.radRadioImgBeforeTxt);
            this.groupBox1.Controls.Add(this.radRadioImgAboveTxt);
            this.groupBox1.FooterImageIndex = -1;
            this.groupBox1.FooterImageKey = "";
            this.groupBox1.FooterText = "";
            this.groupBox1.HeaderImageIndex = -1;
            this.groupBox1.HeaderImageKey = "";
            this.groupBox1.HeaderMargin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.groupBox1.HeaderText = "Text Image Relation";
            this.groupBox1.Location = new System.Drawing.Point(10, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            // 
            // 
            // 
            this.groupBox1.RootElement.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.groupBox1.Size = new System.Drawing.Size(180, 152);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Text Image Relation";
            this.groupBox1.ThemeName = "ControlDefault";
            this.groupBox1.Click += new System.EventHandler(this.groupBox1_Click);
            ((Telerik.WinControls.UI.GroupBoxContent)(this.groupBox1.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.SystemColors.Control;
            // 
            // radRadioOverlay
            // 
            this.radRadioOverlay.ForeColor = System.Drawing.Color.Black;
            this.radRadioOverlay.Location = new System.Drawing.Point(12, 122);
            this.radRadioOverlay.Name = "radRadioOverlay";
            // 
            // 
            // 
            this.radRadioOverlay.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radRadioOverlay.Size = new System.Drawing.Size(59, 16);
            this.radRadioOverlay.TabIndex = 0;
            this.radRadioOverlay.Text = "Overlay";
            this.radRadioOverlay.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioImgAboveTxt_ToggleStateChanged);
            // 
            // radRadioTxtBeforeImg
            // 
            this.radRadioTxtBeforeImg.ForeColor = System.Drawing.Color.Black;
            this.radRadioTxtBeforeImg.Location = new System.Drawing.Point(12, 100);
            this.radRadioTxtBeforeImg.Name = "radRadioTxtBeforeImg";
            // 
            // 
            // 
            this.radRadioTxtBeforeImg.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radRadioTxtBeforeImg.Size = new System.Drawing.Size(113, 16);
            this.radRadioTxtBeforeImg.TabIndex = 0;
            this.radRadioTxtBeforeImg.Text = "Text Before Image";
            this.radRadioTxtBeforeImg.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioImgAboveTxt_ToggleStateChanged);
            // 
            // radRadioTxtAboveImg
            // 
            this.radRadioTxtAboveImg.ForeColor = System.Drawing.Color.Black;
            this.radRadioTxtAboveImg.Location = new System.Drawing.Point(12, 78);
            this.radRadioTxtAboveImg.Name = "radRadioTxtAboveImg";
            // 
            // 
            // 
            this.radRadioTxtAboveImg.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radRadioTxtAboveImg.Size = new System.Drawing.Size(112, 16);
            this.radRadioTxtAboveImg.TabIndex = 0;
            this.radRadioTxtAboveImg.Text = "Text Above Image";
            this.radRadioTxtAboveImg.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioImgAboveTxt_ToggleStateChanged);
            // 
            // radRadioImgBeforeTxt
            // 
            this.radRadioImgBeforeTxt.ForeColor = System.Drawing.Color.Black;
            this.radRadioImgBeforeTxt.Location = new System.Drawing.Point(12, 56);
            this.radRadioImgBeforeTxt.Name = "radRadioImgBeforeTxt";
            // 
            // 
            // 
            this.radRadioImgBeforeTxt.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radRadioImgBeforeTxt.Size = new System.Drawing.Size(113, 16);
            this.radRadioImgBeforeTxt.TabIndex = 0;
            this.radRadioImgBeforeTxt.Text = "Image Before Text";
            this.radRadioImgBeforeTxt.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioImgAboveTxt_ToggleStateChanged);
            // 
            // radRadioImgAboveTxt
            // 
            this.radRadioImgAboveTxt.ForeColor = System.Drawing.Color.Black;
            this.radRadioImgAboveTxt.Location = new System.Drawing.Point(12, 34);
            this.radRadioImgAboveTxt.Name = "radRadioImgAboveTxt";
            // 
            // 
            // 
            this.radRadioImgAboveTxt.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radRadioImgAboveTxt.Size = new System.Drawing.Size(112, 16);
            this.radRadioImgAboveTxt.TabIndex = 0;
            this.radRadioImgAboveTxt.Text = "Image Above Text";
            // 
            // radLabel3
            // 
            this.radLabel3.ForeColor = System.Drawing.Color.Black;
            this.radLabel3.Location = new System.Drawing.Point(75, 118);
            this.radLabel3.Name = "radLabel3";
            // 
            // 
            // 
            this.radLabel3.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radLabel3.Size = new System.Drawing.Size(122, 16);
            this.radLabel3.TabIndex = 6;
            this.radLabel3.Text = "Text And Image Button";
            // 
            // radLabel2
            // 
            this.radLabel2.ForeColor = System.Drawing.Color.Black;
            this.radLabel2.Location = new System.Drawing.Point(75, 85);
            this.radLabel2.Name = "radLabel2";
            // 
            // 
            // 
            this.radLabel2.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radLabel2.Size = new System.Drawing.Size(73, 16);
            this.radLabel2.TabIndex = 6;
            this.radLabel2.Text = "Image Button";
            // 
            // radLabel1
            // 
            this.radLabel1.ForeColor = System.Drawing.Color.Black;
            this.radLabel1.Location = new System.Drawing.Point(75, 51);
            this.radLabel1.Name = "radLabel1";
            // 
            // 
            // 
            this.radLabel1.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radLabel1.Size = new System.Drawing.Size(64, 16);
            this.radLabel1.TabIndex = 6;
            this.radLabel1.Text = "Text Button";
            // 
            // Form1
            // 
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(2, 35, 2, 4);
            this.Size = new System.Drawing.Size(1224, 737);
            ((System.ComponentModel.ISupportInitialize)(this.radPanelDemoHolder)).EndInit();
            this.radPanelDemoHolder.ResumeLayout(false);
            this.radPanelDemoHolder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radRadioOverlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioTxtBeforeImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioTxtAboveImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioImgBeforeTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioImgAboveTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

        private Telerik.WinControls.UI.RadButton radButton1;
		private Telerik.WinControls.UI.RadButton radButton2;
        private System.Windows.Forms.ImageList imageList1;
        private Telerik.WinControls.UI.RadButton radButton3;
        private Telerik.WinControls.UI.RadGroupBox groupBox1;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadRadioButton radRadioOverlay;
        private Telerik.WinControls.UI.RadRadioButton radRadioTxtBeforeImg;
        private Telerik.WinControls.UI.RadRadioButton radRadioTxtAboveImg;
        private Telerik.WinControls.UI.RadRadioButton radRadioImgBeforeTxt;
        private Telerik.WinControls.UI.RadRadioButton radRadioImgAboveTxt;
	}
}
