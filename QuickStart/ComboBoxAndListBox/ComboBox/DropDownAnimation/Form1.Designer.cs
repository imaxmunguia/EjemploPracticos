using Telerik.WinControls.UI;
namespace Telerik.Examples.WinControls.ComboBoxAndListBox.ComboBox.DropDownAnimation
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (this.components != null)
                {
                    this.components.Dispose();
                }
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
            this.radGroupAnimSettings = new Telerik.WinControls.UI.RadGroupBox();
            this.radSpinFrames = new Telerik.WinControls.UI.RadSpinEditor();
            this.radCheckEnableAnim = new Telerik.WinControls.UI.RadCheckBox();
            this.radComboAnimType = new Telerik.WinControls.UI.RadDropDownList();
            this.radLblFrames = new Telerik.WinControls.UI.RadLabel();
            this.radLblDropDownAnim = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelDemoHolder)).BeginInit();
            this.radPanelDemoHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radComboDemo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupAnimSettings)).BeginInit();
            this.radGroupAnimSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinFrames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckEnableAnim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radComboAnimType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLblFrames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLblDropDownAnim)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanelDemoHolder
            // 
            this.radPanelDemoHolder.Controls.Add(this.radComboDemo);
            this.radPanelDemoHolder.Location = new System.Drawing.Point(431, 218);
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
            this.settingsPanel.Controls.Add(this.radGroupAnimSettings);
            this.settingsPanel.Location = new System.Drawing.Point(973, 1);
            // 
            // 
            // 
            this.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black;
            this.settingsPanel.Size = new System.Drawing.Size(250, 534);
            this.settingsPanel.Controls.SetChildIndex(this.radGroupAnimSettings, 0);
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
            this.radComboDemo.ForeColor = System.Drawing.Color.Black;
            this.radComboDemo.ImageList = this.imageList1;            
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
            this.radComboDemo.Name = "radComboDemo";
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
            // radGroupAnimSettings
            // 
            this.radGroupAnimSettings.Controls.Add(this.radSpinFrames);
            this.radGroupAnimSettings.Controls.Add(this.radCheckEnableAnim);
            this.radGroupAnimSettings.Controls.Add(this.radComboAnimType);
            this.radGroupAnimSettings.Controls.Add(this.radLblFrames);
            this.radGroupAnimSettings.Controls.Add(this.radLblDropDownAnim);
            this.radGroupAnimSettings.FooterImageIndex = -1;
            this.radGroupAnimSettings.FooterImageKey = "";
            this.radGroupAnimSettings.FooterText = "";
            this.radGroupAnimSettings.ForeColor = System.Drawing.Color.Black;
            this.radGroupAnimSettings.HeaderImageIndex = -1;
            this.radGroupAnimSettings.HeaderImageKey = "";
            this.radGroupAnimSettings.HeaderMargin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.radGroupAnimSettings.HeaderText = " Animation settings ";
            this.radGroupAnimSettings.Location = new System.Drawing.Point(15, 6);
            this.radGroupAnimSettings.Name = "radGroupAnimSettings";
            // 
            // 
            // 
            this.radGroupAnimSettings.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radGroupAnimSettings.Size = new System.Drawing.Size(162, 156);
            this.radGroupAnimSettings.TabIndex = 0;
            this.radGroupAnimSettings.Text = " Animation settings ";
            // 
            // radSpinFrames
            // 
            this.radSpinFrames.BackColor = System.Drawing.Color.White;
            this.radSpinFrames.ForeColor = System.Drawing.Color.Black;
            this.radSpinFrames.Location = new System.Drawing.Point(64, 119);
            this.radSpinFrames.Name = "radSpinFrames";
            // 
            // 
            // 
            this.radSpinFrames.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radSpinFrames.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radSpinFrames.ShowBorder = true;
            this.radSpinFrames.Size = new System.Drawing.Size(80, 20);
            this.radSpinFrames.TabIndex = 3;
            this.radSpinFrames.ValueChanged += new System.EventHandler(this.OnRadSpinFrames_ValueChanged);
            // 
            // radCheckEnableAnim
            // 
            this.radCheckEnableAnim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.radCheckEnableAnim.Location = new System.Drawing.Point(12, 39);
            this.radCheckEnableAnim.Name = "radCheckEnableAnim";
            this.radCheckEnableAnim.Size = new System.Drawing.Size(111, 17);
            this.radCheckEnableAnim.TabIndex = 2;
            this.radCheckEnableAnim.Text = "Enable Animation";
            this.radCheckEnableAnim.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.OnEnableAnimation_ToggleStateChanged);
            // 
            // radComboAnimType
            // 
            this.radComboAnimType.ForeColor = System.Drawing.Color.Black;
            this.radComboAnimType.Location = new System.Drawing.Point(12, 90);
            this.radComboAnimType.Name = "radComboAnimType";
            // 
            // 
            // 
            this.radComboAnimType.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radComboAnimType.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radComboAnimType.Size = new System.Drawing.Size(132, 20);
            this.radComboAnimType.TabIndex = 1;
            this.radComboAnimType.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(radComboAnimType_SelectedIndexChanged);
            // 
            // radLblFrames
            // 
            this.radLblFrames.ForeColor = System.Drawing.Color.Black;
            this.radLblFrames.Location = new System.Drawing.Point(12, 121);
            this.radLblFrames.Name = "radLblFrames";
            // 
            // 
            // 
            this.radLblFrames.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radLblFrames.Size = new System.Drawing.Size(46, 14);
            this.radLblFrames.TabIndex = 0;
            this.radLblFrames.Text = "Frames:";
            // 
            // radLblDropDownAnim
            // 
            this.radLblDropDownAnim.ForeColor = System.Drawing.Color.Black;
            this.radLblDropDownAnim.Location = new System.Drawing.Point(12, 66);
            this.radLblDropDownAnim.Name = "radLblDropDownAnim";
            // 
            // 
            // 
            this.radLblDropDownAnim.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radLblDropDownAnim.Size = new System.Drawing.Size(82, 14);
            this.radLblDropDownAnim.TabIndex = 0;
            this.radLblDropDownAnim.Text = "Animation type:";
            // 
            // Form1
            // 
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1224, 536);
            ((System.ComponentModel.ISupportInitialize)(this.radPanelDemoHolder)).EndInit();
            this.radPanelDemoHolder.ResumeLayout(false);
            this.radPanelDemoHolder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radComboDemo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupAnimSettings)).EndInit();
            this.radGroupAnimSettings.ResumeLayout(false);
            this.radGroupAnimSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinFrames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckEnableAnim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radComboAnimType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLblFrames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLblDropDownAnim)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ImageList imageList1;
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
        private Telerik.WinControls.UI.RadGroupBox radGroupAnimSettings;
        private Telerik.WinControls.UI.RadLabel radLblDropDownAnim;
        private Telerik.WinControls.UI.RadDropDownList radComboAnimType;
        private Telerik.WinControls.UI.RadSpinEditor radSpinFrames;
        private Telerik.WinControls.UI.RadCheckBox radCheckEnableAnim;
        private Telerik.WinControls.UI.RadLabel radLblFrames;
	}
}