namespace Telerik.Examples.WinControls.TrackStatusControls.TrackBar.FirstLook
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
            this.radHorizontalTrackBar = new Telerik.WinControls.UI.RadTrackBar();
            this.radVerticalTrackbar = new Telerik.WinControls.UI.RadTrackBar();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelDemoHolder)).BeginInit();
            this.radPanelDemoHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radHorizontalTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radVerticalTrackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanelDemoHolder
            // 
            this.radPanelDemoHolder.Controls.Add(this.radVerticalTrackbar);
            this.radPanelDemoHolder.Controls.Add(this.radLabel2);
            this.radPanelDemoHolder.Controls.Add(this.radLabel1);
            this.radPanelDemoHolder.Controls.Add(this.radHorizontalTrackBar);
            this.radPanelDemoHolder.Location = new System.Drawing.Point(396, 123);
            // 
            // 
            // 
            this.radPanelDemoHolder.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radPanelDemoHolder.Size = new System.Drawing.Size(432, 290);
            // 
            // settingsPanel
            // 
            this.settingsPanel.Location = new System.Drawing.Point(973, 1);
            // 
            // 
            // 
            this.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black;
            this.settingsPanel.Size = new System.Drawing.Size(250, 534);
            // 
            // radHorizontalTrackBar
            // 
            this.radHorizontalTrackBar.BackColor = System.Drawing.Color.Transparent;
            this.radHorizontalTrackBar.ForeColor = System.Drawing.Color.Black;
            this.radHorizontalTrackBar.Location = new System.Drawing.Point(182, 140);
            this.radHorizontalTrackBar.Name = "radHorizontalTrackBar";
            // 
            // 
            // 
            this.radHorizontalTrackBar.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radHorizontalTrackBar.RootElement.ToolTipText = null;
            this.radHorizontalTrackBar.Size = new System.Drawing.Size(217, 30);
            this.radHorizontalTrackBar.SlideAreaWidth = 2;
            this.radHorizontalTrackBar.SliderAreaColor1 = System.Drawing.Color.WhiteSmoke;
            this.radHorizontalTrackBar.SliderAreaColor2 = System.Drawing.Color.DarkGray;
            this.radHorizontalTrackBar.TabIndex = 0;
            this.radHorizontalTrackBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.OnHorizontalTrackBar_Scroll);
            // 
            // radVerticalTrackbar
            // 
            this.radVerticalTrackbar.BackColor = System.Drawing.Color.Transparent;
            this.radVerticalTrackbar.ForeColor = System.Drawing.Color.Black;
            this.radVerticalTrackbar.Location = new System.Drawing.Point(62, 63);
            this.radVerticalTrackbar.Maximum = 50;
            this.radVerticalTrackbar.Name = "radVerticalTrackbar";
            this.radVerticalTrackbar.Orientation = System.Windows.Forms.Orientation.Vertical;
            // 
            // 
            // 
            this.radVerticalTrackbar.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radVerticalTrackbar.RootElement.ToolTipText = null;
            this.radVerticalTrackbar.Size = new System.Drawing.Size(30, 201);
            this.radVerticalTrackbar.SlideAreaWidth = 2;
            this.radVerticalTrackbar.SliderAreaColor1 = System.Drawing.Color.WhiteSmoke;
            this.radVerticalTrackbar.SliderAreaColor2 = System.Drawing.Color.DarkGray;
            this.radVerticalTrackbar.TabIndex = 2;
            this.radVerticalTrackbar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.OnVerticalTrackBar_Scroll);
            // 
            // radLabel1
            // 
            this.radLabel1.ForeColor = System.Drawing.Color.Black;
            this.radLabel1.Location = new System.Drawing.Point(34, 26);
            this.radLabel1.Name = "radLabel1";
            // 
            // 
            // 
            this.radLabel1.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radLabel1.Size = new System.Drawing.Size(91, 14);
            this.radLabel1.TabIndex = 6;
            this.radLabel1.Text = "Vertical TrackBar";
            // 
            // radLabel2
            // 
            this.radLabel2.ForeColor = System.Drawing.Color.Black;
            this.radLabel2.Location = new System.Drawing.Point(182, 104);
            this.radLabel2.Name = "radLabel2";
            // 
            // 
            // 
            this.radLabel2.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radLabel2.Size = new System.Drawing.Size(104, 14);
            this.radLabel2.TabIndex = 6;
            this.radLabel2.Text = "Horizontal TrackBar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1224, 536);
            ((System.ComponentModel.ISupportInitialize)(this.radPanelDemoHolder)).EndInit();
            this.radPanelDemoHolder.ResumeLayout(false);
            this.radPanelDemoHolder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radHorizontalTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radVerticalTrackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private Telerik.WinControls.UI.RadTrackBar radHorizontalTrackBar;
        private Telerik.WinControls.UI.RadTrackBar radVerticalTrackbar;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
	}
}