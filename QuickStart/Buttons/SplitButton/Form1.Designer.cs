namespace Telerik.Examples.WinControls.Buttons.SplitButton
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
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radSplitButton3 = new Telerik.WinControls.UI.RadSplitButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.radMenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem2 = new Telerik.WinControls.UI.RadMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelDemoHolder)).BeginInit();
            this.radPanelDemoHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitButton3)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanelDemoHolder
            // 
            this.radPanelDemoHolder.Controls.Add(this.radSplitButton3);
            this.radPanelDemoHolder.Controls.Add(this.radButton1);
            this.radPanelDemoHolder.Location = new System.Drawing.Point(348, 210);
            // 
            // 
            // 
            this.radPanelDemoHolder.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radPanelDemoHolder.Size = new System.Drawing.Size(527, 316);
            // 
            // settingsPanel
            // 
            this.settingsPanel.Location = new System.Drawing.Point(1023, 1);
            // 
            // 
            // 
            this.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black;
            this.settingsPanel.Size = new System.Drawing.Size(200, 735);
            // 
            // radButton1
            // 
            this.radButton1.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.radButton1.ForeColor = System.Drawing.Color.Black;
            this.radButton1.Image = global::Telerik.Examples.WinControls.Properties.Resources.telerikLogo;
            this.radButton1.Location = new System.Drawing.Point(277, 127);
            this.radButton1.Name = "radButton1";
            // 
            // 
            // 
            this.radButton1.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radButton1.RootElement.StretchHorizontally = false;
            this.radButton1.RootElement.StretchVertically = false;
            this.radButton1.Size = new System.Drawing.Size(171, 62);
            this.radButton1.TabIndex = 8;
            this.radButton1.Text = "radButton2";
            // 
            // radSplitButton3
            // 
            this.radSplitButton3.DefaultItem = null;
            this.radSplitButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.radSplitButton3.ImageList = this.imageList1;
            this.radSplitButton3.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem1,
            this.radMenuItem2});
            this.radSplitButton3.Location = new System.Drawing.Point(78, 134);
            this.radSplitButton3.Name = "radSplitButton3";
            // 
            // 
            // 
            this.radSplitButton3.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radSplitButton3.RootElement.ToolTipText = null;
            this.radSplitButton3.Size = new System.Drawing.Size(161, 48);
            this.radSplitButton3.TabIndex = 6;
            this.radSplitButton3.Text = "Split Button";
            this.radSplitButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Lime;
            this.imageList1.Images.SetKeyName(0, "2_redo.gif");
            this.imageList1.Images.SetKeyName(1, "1_undo.gif");
            // 
            // radMenuItem1
            // 
            this.radMenuItem1.ImageIndex = 0;
            this.radMenuItem1.Name = "radMenuItem1";
            this.radMenuItem1.Text = "Rotate\r\nClockwise";
            this.radMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radMenuItem1.ToolTipText = null;
            this.radMenuItem1.Click += new System.EventHandler(this.radMenuItem1_Click);
            // 
            // radMenuItem2
            // 
            this.radMenuItem2.ImageIndex = 1;
            this.radMenuItem2.Name = "radMenuItem2";
            this.radMenuItem2.Text = "Rotate\r\nCounter-clockwise";
            this.radMenuItem2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radMenuItem2.ToolTipText = null;
            this.radMenuItem2.Click += new System.EventHandler(this.radMenuItem2_Click);
            // 
            // Form1
            // 
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(2, 35, 2, 4);
            this.Size = new System.Drawing.Size(1224, 737);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPanelDemoHolder)).EndInit();
            this.radPanelDemoHolder.ResumeLayout(false);
            this.radPanelDemoHolder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitButton3)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

        private Telerik.WinControls.UI.RadSplitButton radSplitButton3;
		private Telerik.WinControls.UI.RadMenuItem radMenuItem1;
		private Telerik.WinControls.UI.RadMenuItem radMenuItem2;
		private System.Windows.Forms.ImageList imageList1;
        private Telerik.WinControls.UI.RadButton radButton1;
	}
}