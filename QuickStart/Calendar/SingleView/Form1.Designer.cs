namespace Telerik.Examples.WinControls.Calendar.SingleView
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
            this.radRadioRows = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioCols = new Telerik.WinControls.UI.RadRadioButton();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCalendar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioCols)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radGroupBox1);
            this.settingsPanel.Location = new System.Drawing.Point(729, 1);
            // 
            // 
            // 
            this.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black;
            this.settingsPanel.Size = new System.Drawing.Size(250, 867);
            this.settingsPanel.ThemeName = "ControlDefault";
            this.settingsPanel.Controls.SetChildIndex(this.radGroupBox1, 0);
            // 
            // radCalendar1
            // 
            this.radCalendar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radCalendar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.radCalendar1.CellAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radCalendar1.FocusedDate = System.DateTime.Now;
            this.radCalendar1.ForeColor = System.Drawing.Color.Black;
            this.radCalendar1.HeaderHeight = 17;
            this.radCalendar1.HeaderWidth = 17;
            this.radCalendar1.Location = new System.Drawing.Point(346, 320);
            this.radCalendar1.Name = "radCalendar1";
            this.radCalendar1.RangeMaxDate = new System.DateTime(2099, 12, 30, 0, 0, 0, 0);
            // 
            // 
            // 
            this.radCalendar1.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radCalendar1.SelectedDate = new System.DateTime(((long)(0)));
            this.radCalendar1.SelectedDates.AddRange(new System.DateTime[] {
            new System.DateTime(((long)(0)))});
            this.radCalendar1.Size = new System.Drawing.Size(288, 229);
            this.radCalendar1.TabIndex = 0;
            this.radCalendar1.Text = "radCalendar1";
            this.radCalendar1.TitleAlign = System.Windows.Forms.VisualStyles.ContentAlignment.Center;
            this.radCalendar1.ZoomFactor = 1.2F;
            // 
            // radRadioRows
            // 
            this.radRadioRows.ForeColor = System.Drawing.Color.Black;
            this.radRadioRows.Location = new System.Drawing.Point(22, 28);
            this.radRadioRows.Name = "radRadioRows";
            this.radRadioRows.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // 
            // 
            this.radRadioRows.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radRadioRows.Size = new System.Drawing.Size(101, 16);
            this.radRadioRows.TabIndex = 2;
            this.radRadioRows.Text = "Render In Rows";
            this.radRadioRows.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioRows_ToggleStateChanged);
            // 
            // radRadioCols
            // 
            this.radRadioCols.ForeColor = System.Drawing.Color.Black;
            this.radRadioCols.Location = new System.Drawing.Point(22, 50);
            this.radRadioCols.Name = "radRadioCols";
            this.radRadioCols.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // 
            // 
            this.radRadioCols.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radRadioCols.Size = new System.Drawing.Size(118, 16);
            this.radRadioCols.TabIndex = 2;
            this.radRadioCols.Text = "Render In Columns";
            this.radRadioCols.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioRows_ToggleStateChanged);
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.Controls.Add(this.radRadioRows);
            this.radGroupBox1.Controls.Add(this.radRadioCols);
            this.radGroupBox1.FooterImageIndex = -1;
            this.radGroupBox1.FooterImageKey = "";
            this.radGroupBox1.ForeColor = System.Drawing.Color.Black;
            this.radGroupBox1.HeaderImageIndex = -1;
            this.radGroupBox1.HeaderImageKey = "";
            this.radGroupBox1.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBox1.HeaderText = "Rendering Options";
            this.radGroupBox1.Location = new System.Drawing.Point(15, 6);
            this.radGroupBox1.Name = "radGroupBox1";
            // 
            // 
            // 
            this.radGroupBox1.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radGroupBox1.Size = new System.Drawing.Size(162, 84);
            this.radGroupBox1.TabIndex = 3;
            this.radGroupBox1.Text = "Rendering Options";
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
            ((System.ComponentModel.ISupportInitialize)(this.radRadioRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioCols)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

        private Telerik.WinControls.UI.RadCalendar radCalendar1;
        private Telerik.WinControls.UI.RadRadioButton radRadioRows;
        private Telerik.WinControls.UI.RadRadioButton radRadioCols;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
	}
}