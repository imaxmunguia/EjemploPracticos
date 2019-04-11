namespace Telerik.Examples.WinControls.Calendar.Events
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
            this.radListBoxEvents = new Telerik.WinControls.UI.RadListControl();
            this.radButtonClear = new Telerik.WinControls.UI.RadButton();
            this.radGroupEvents = new Telerik.WinControls.UI.RadGroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCalendar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radListBoxEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupEvents)).BeginInit();
            this.radGroupEvents.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radGroupEvents);
            this.settingsPanel.ForeColor = System.Drawing.Color.Black;
            this.settingsPanel.Location = new System.Drawing.Point(1023, 1);
            // 
            // 
            // 
            this.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black;
            this.settingsPanel.Size = new System.Drawing.Size(200, 818);
            this.settingsPanel.ThemeName = "ControlDefault";
            this.settingsPanel.Controls.SetChildIndex(this.radGroupEvents, 0);
            // 
            // radCalendar1
            // 
            this.radCalendar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radCalendar1.CellAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radCalendar1.DayNameFormat = Telerik.WinControls.UI.DayNameFormat.Full;
            this.radCalendar1.FocusedDate = new System.DateTime(2009, 3, 15, 0, 0, 0, 0);
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
            // radListBoxEvents
            // 
            this.radListBoxEvents.AutoScroll = true;
            this.radListBoxEvents.BackColor = System.Drawing.Color.White;
            this.radListBoxEvents.Font = new System.Drawing.Font("Verdana", 8F);
            this.radListBoxEvents.ForeColor = System.Drawing.Color.Black;
            this.radListBoxEvents.Location = new System.Drawing.Point(23, 21);
            this.radListBoxEvents.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radListBoxEvents.Name = "radListBoxEvents";
            // 
            // 
            // 
            this.radListBoxEvents.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radListBoxEvents.Size = new System.Drawing.Size(135, 200);
            this.radListBoxEvents.TabIndex = 6;
            // 
            // radButtonClear
            // 
            this.radButtonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.radButtonClear.Location = new System.Drawing.Point(23, 227);
            this.radButtonClear.Name = "radButtonClear";
            this.radButtonClear.Size = new System.Drawing.Size(135, 23);
            this.radButtonClear.TabIndex = 8;
            this.radButtonClear.Text = "Clear";
            this.radButtonClear.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // radGroupEvents
            // 
            this.radGroupEvents.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupEvents.Controls.Add(this.radButtonClear);
            this.radGroupEvents.Controls.Add(this.radListBoxEvents);
            this.radGroupEvents.FooterImageIndex = -1;
            this.radGroupEvents.FooterImageKey = "";
            this.radGroupEvents.ForeColor = System.Drawing.Color.Black;
            this.radGroupEvents.HeaderImageIndex = -1;
            this.radGroupEvents.HeaderImageKey = "";
            this.radGroupEvents.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupEvents.HeaderText = "Events";
            this.radGroupEvents.Location = new System.Drawing.Point(10, 6);
            this.radGroupEvents.Name = "radGroupEvents";
            this.radGroupEvents.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            // 
            // 
            // 
            this.radGroupEvents.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radGroupEvents.RootElement.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.radGroupEvents.Size = new System.Drawing.Size(180, 263);
            this.radGroupEvents.TabIndex = 6;
            this.radGroupEvents.Text = "Events";
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
            ((System.ComponentModel.ISupportInitialize)(this.radListBoxEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupEvents)).EndInit();
            this.radGroupEvents.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

        private Telerik.WinControls.UI.RadCalendar radCalendar1;
        private Telerik.WinControls.UI.RadButton radButtonClear;
        private Telerik.WinControls.UI.RadListControl radListBoxEvents;
        private Telerik.WinControls.UI.RadGroupBox radGroupEvents;
	}
}