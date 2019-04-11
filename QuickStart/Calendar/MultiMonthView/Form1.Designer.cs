namespace Telerik.Examples.WinControls.Calendar.MultiMonthView
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
            this.radCalendar1 = new Telerik.WinControls.UI.RadCalendar();
            this.radGroupRenderDir = new Telerik.WinControls.UI.RadGroupBox();
            this.radRadioRows = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioCols = new Telerik.WinControls.UI.RadRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCalendar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupRenderDir)).BeginInit();
            this.radGroupRenderDir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioCols)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radGroupRenderDir);
            this.settingsPanel.Location = new System.Drawing.Point(729, 1);
            // 
            // 
            // 
            this.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black;
            this.settingsPanel.Size = new System.Drawing.Size(250, 867);
            this.settingsPanel.ThemeName = "ControlDefault";
            this.settingsPanel.Controls.SetChildIndex(this.radGroupRenderDir, 0);
            // 
            // radCalendar1
            // 
            this.radCalendar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radCalendar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.radCalendar1.CellAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radCalendar1.FocusedDate = new System.DateTime(2009, 3, 9, 0, 0, 0, 0);
            this.radCalendar1.ForeColor = System.Drawing.Color.Black;
            this.radCalendar1.HeaderHeight = 17;
            this.radCalendar1.HeaderWidth = 17;
            this.radCalendar1.Location = new System.Drawing.Point(287, 227);
            this.radCalendar1.Name = "radCalendar1";
            this.radCalendar1.RangeMaxDate = new System.DateTime(2099, 12, 30, 0, 0, 0, 0);
            // 
            // 
            // 
            this.radCalendar1.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radCalendar1.SelectedDate = new System.DateTime(((long)(0)));
            this.radCalendar1.SelectedDates.AddRange(new System.DateTime[] {
            new System.DateTime(((long)(0)))});
            this.radCalendar1.Size = new System.Drawing.Size(407, 415);
            this.radCalendar1.TabIndex = 0;
            this.radCalendar1.Text = "radCalendar1";
            this.radCalendar1.TitleAlign = System.Windows.Forms.VisualStyles.ContentAlignment.Center;
            this.radCalendar1.ZoomFactor = 1.2F;
            // 
            // radGroupRenderDir
            // 
            this.radGroupRenderDir.Controls.Add(this.radRadioRows);
            this.radGroupRenderDir.Controls.Add(this.radRadioCols);
            this.radGroupRenderDir.FooterImageIndex = -1;
            this.radGroupRenderDir.FooterImageKey = "";
            this.radGroupRenderDir.ForeColor = System.Drawing.Color.Black;
            this.radGroupRenderDir.HeaderImageIndex = -1;
            this.radGroupRenderDir.HeaderImageKey = "";
            this.radGroupRenderDir.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupRenderDir.HeaderText = "Rendering Direction";
            this.radGroupRenderDir.Location = new System.Drawing.Point(15, 6);
            this.radGroupRenderDir.Name = "radGroupRenderDir";
            // 
            // 
            // 
            this.radGroupRenderDir.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radGroupRenderDir.Size = new System.Drawing.Size(162, 88);
            this.radGroupRenderDir.TabIndex = 5;
            this.radGroupRenderDir.Text = "Rendering Direction";
            // 
            // radRadioRows
            // 
            this.radRadioRows.ForeColor = System.Drawing.Color.Black;
            this.radRadioRows.Location = new System.Drawing.Point(19, 29);
            this.radRadioRows.Name = "radRadioRows";
            this.radRadioRows.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // 
            // 
            this.radRadioRows.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radRadioRows.Size = new System.Drawing.Size(101, 16);
            this.radRadioRows.TabIndex = 6;
            this.radRadioRows.Text = "Render In Rows";
            this.radRadioRows.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioRows_ToggleStateChanged);
            // 
            // radRadioCols
            // 
            this.radRadioCols.ForeColor = System.Drawing.Color.Black;
            this.radRadioCols.Location = new System.Drawing.Point(19, 51);
            this.radRadioCols.Name = "radRadioCols";
            this.radRadioCols.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // 
            // 
            this.radRadioCols.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radRadioCols.Size = new System.Drawing.Size(118, 16);
            this.radRadioCols.TabIndex = 6;
            this.radRadioCols.Text = "Render In Columns";
            this.radRadioCols.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioRows_ToggleStateChanged);
            // 
            // Form1
            // 
            this.Controls.Add(this.radCalendar1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(980, 869);
            this.Controls.SetChildIndex(this.radCalendar1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCalendar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupRenderDir)).EndInit();
            this.radGroupRenderDir.ResumeLayout(false);
            this.radGroupRenderDir.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioCols)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Telerik.WinControls.UI.RadCalendar radCalendar1;
        private Telerik.WinControls.UI.RadGroupBox radGroupRenderDir;
        private Telerik.WinControls.UI.RadRadioButton radRadioRows;
        private Telerik.WinControls.UI.RadRadioButton radRadioCols;
	}
}