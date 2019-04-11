namespace Telerik.Examples.WinControls.Calendar.Globalization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.radCalendar1 = new Telerik.WinControls.UI.RadCalendar();
            this.radComboCultureList = new Telerik.WinControls.UI.RadDropDownList();
            this.lbRenderingDirection = new Telerik.WinControls.UI.RadLabel();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radTextBox1 = new Telerik.WinControls.UI.RadTextBox();
            this.lbTitleFormat = new Telerik.WinControls.UI.RadLabel();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCalendar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radComboCultureList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbRenderingDirection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbTitleFormat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radGroupBox1);
            this.settingsPanel.ForeColor = System.Drawing.Color.Black;
            this.settingsPanel.Location = new System.Drawing.Point(1023, 1);
            // 
            // 
            // 
            this.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black;
            this.settingsPanel.Size = new System.Drawing.Size(200, 818);
            this.settingsPanel.ThemeName = "ControlDefault";
            this.settingsPanel.Controls.SetChildIndex(this.radGroupBox1, 0);
            // 
            // radCalendar1
            // 
            this.radCalendar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radCalendar1.CellAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radCalendar1.DayNameFormat = Telerik.WinControls.UI.DayNameFormat.Full;
            this.radCalendar1.FocusedDate = new System.DateTime(2009, 3, 18, 0, 0, 0, 0);
            this.radCalendar1.ForeColor = System.Drawing.Color.Black;
            this.radCalendar1.HeaderHeight = 17;
            this.radCalendar1.HeaderWidth = 17;
            this.radCalendar1.Location = new System.Drawing.Point(364, 287);
            this.radCalendar1.Name = "radCalendar1";
            this.radCalendar1.RangeMaxDate = new System.DateTime(2099, 12, 30, 0, 0, 0, 0);
            // 
            // 
            // 
            this.radCalendar1.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radCalendar1.SelectedDate = new System.DateTime(((long)(0)));
            this.radCalendar1.SelectedDates.AddRange(new System.DateTime[] {
            new System.DateTime(((long)(0)))});
            this.radCalendar1.Size = new System.Drawing.Size(496, 246);
            this.radCalendar1.TabIndex = 0;
            this.radCalendar1.Text = "radCalendar1";
            this.radCalendar1.TitleAlign = System.Windows.Forms.VisualStyles.ContentAlignment.Center;
            this.radCalendar1.ZoomFactor = 1.2F;
            // 
            // radComboCultureList
            // 
            this.radComboCultureList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.radComboCultureList.DropDownSizingMode = ((Telerik.WinControls.UI.SizingMode)((Telerik.WinControls.UI.SizingMode.RightBottom | Telerik.WinControls.UI.SizingMode.UpDown)));
            this.radComboCultureList.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.radComboCultureList.Location = new System.Drawing.Point(24, 55);
            this.radComboCultureList.MaxDropDownItems = 6;
            this.radComboCultureList.Name = "radComboCultureList";
            // 
            // 
            // 
            this.radComboCultureList.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radComboCultureList.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radComboCultureList.Size = new System.Drawing.Size(132, 20);
            this.radComboCultureList.TabIndex = 1;
            this.radComboCultureList.TabStop = false;
            this.radComboCultureList.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(radComboCultureList_SelectedIndexChanged);
            // 
            // lbRenderingDirection
            // 
            this.lbRenderingDirection.AutoSize = false;
            this.lbRenderingDirection.BackColor = System.Drawing.Color.Transparent;
            this.lbRenderingDirection.ForeColor = System.Drawing.Color.Black;
            this.lbRenderingDirection.Location = new System.Drawing.Point(24, 89);
            this.lbRenderingDirection.Name = "lbRenderingDirection";
            // 
            // 
            // 
            this.lbRenderingDirection.RootElement.ForeColor = System.Drawing.Color.Black;
            this.lbRenderingDirection.Size = new System.Drawing.Size(132, 36);
            this.lbRenderingDirection.TabIndex = 4;
            this.lbRenderingDirection.Text = "Type text to set the \r\n navigation bar: ";
            // 
            // radButton1
            // 
            this.radButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.radButton1.Location = new System.Drawing.Point(24, 161);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(132, 23);
            this.radButton1.TabIndex = 8;
            this.radButton1.Text = "Change Texts";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // radTextBox1
            // 
            this.radTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.radTextBox1.ForeColor = System.Drawing.Color.Black;
            this.radTextBox1.Location = new System.Drawing.Point(24, 128);
            this.radTextBox1.Name = "radTextBox1";
            // 
            // 
            // 
            this.radTextBox1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radTextBox1.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radTextBox1.Size = new System.Drawing.Size(132, 20);
            this.radTextBox1.TabIndex = 7;
            this.radTextBox1.TabStop = false;
            // 
            // lbTitleFormat
            // 
            this.lbTitleFormat.BackColor = System.Drawing.Color.Transparent;
            this.lbTitleFormat.ForeColor = System.Drawing.Color.Black;
            this.lbTitleFormat.Location = new System.Drawing.Point(24, 28);
            this.lbTitleFormat.Name = "lbTitleFormat";
            // 
            // 
            // 
            this.lbTitleFormat.RootElement.ForeColor = System.Drawing.Color.Black;
            this.lbTitleFormat.Size = new System.Drawing.Size(85, 16);
            this.lbTitleFormat.TabIndex = 6;
            this.lbTitleFormat.Text = "Choose culture:";
            this.lbTitleFormat.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupBox1.Controls.Add(this.radButton1);
            this.radGroupBox1.Controls.Add(this.lbTitleFormat);
            this.radGroupBox1.Controls.Add(this.radTextBox1);
            this.radGroupBox1.Controls.Add(this.lbRenderingDirection);
            this.radGroupBox1.Controls.Add(this.radComboCultureList);
            this.radGroupBox1.FooterImageIndex = -1;
            this.radGroupBox1.FooterImageKey = "";
            this.radGroupBox1.ForeColor = System.Drawing.Color.Black;
            this.radGroupBox1.HeaderImageIndex = -1;
            this.radGroupBox1.HeaderImageKey = "";
            this.radGroupBox1.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBox1.HeaderText = "Globalization Options";
            this.radGroupBox1.Location = new System.Drawing.Point(10, 6);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            // 
            // 
            // 
            this.radGroupBox1.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radGroupBox1.RootElement.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.radGroupBox1.Size = new System.Drawing.Size(180, 197);
            this.radGroupBox1.TabIndex = 1;
            this.radGroupBox1.Text = "Globalization Options";
            // 
            // Form1
            // 
            this.Controls.Add(this.radCalendar1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1224, 820);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Controls.SetChildIndex(this.radCalendar1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radCalendar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radComboCultureList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbRenderingDirection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbTitleFormat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private Telerik.WinControls.UI.RadCalendar radCalendar1;
        private Telerik.WinControls.UI.RadDropDownList radComboCultureList;
        private Telerik.WinControls.UI.RadLabel lbRenderingDirection;
        private Telerik.WinControls.UI.RadLabel lbTitleFormat;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadTextBox radTextBox1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
	}
}