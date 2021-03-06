namespace Telerik.Examples.WinControls.Calendar.DayRenderEvent
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
            this.DatesList = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.ColorList = new Telerik.WinControls.UI.RadDropDownList();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radTextBox1 = new Telerik.WinControls.UI.RadTextBox();
            this.radGroupRenderOpts = new Telerik.WinControls.UI.RadGroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCalendar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatesList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupRenderOpts)).BeginInit();
            this.radGroupRenderOpts.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radGroupRenderOpts);
            this.settingsPanel.ForeColor = System.Drawing.Color.Black;
            this.settingsPanel.Location = new System.Drawing.Point(1023, 1);
            // 
            // 
            // 
            this.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black;
            this.settingsPanel.Size = new System.Drawing.Size(200, 818);
            this.settingsPanel.ThemeName = "ControlDefault";
            this.settingsPanel.Controls.SetChildIndex(this.radGroupRenderOpts, 0);
            // 
            // radCalendar1
            // 
            this.radCalendar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radCalendar1.CellAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radCalendar1.DayNameFormat = Telerik.WinControls.UI.DayNameFormat.Full;
            this.radCalendar1.FocusedDate = new System.DateTime(2009, 3, 13, 0, 0, 0, 0);
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
            this.radCalendar1.Size = new System.Drawing.Size(496, 246);
            this.radCalendar1.TabIndex = 0;
            this.radCalendar1.Text = "radCalendar1";
            this.radCalendar1.TitleAlign = System.Windows.Forms.VisualStyles.ContentAlignment.Center;
            this.radCalendar1.ZoomFactor = 1.2F;
            this.radCalendar1.ElementRender += new Telerik.WinControls.UI.RenderElementEventHandler(this.radCalendar1_ElementRender);
            // 
            // DatesList
            // 
            this.DatesList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.DatesList.DropDownSizingMode = ((Telerik.WinControls.UI.SizingMode)((Telerik.WinControls.UI.SizingMode.RightBottom | Telerik.WinControls.UI.SizingMode.UpDown)));
            this.DatesList.Location = new System.Drawing.Point(21, 37);
            this.DatesList.MaxDropDownItems = 6;
            this.DatesList.Name = "DatesList";
            // 
            // 
            // 
            this.DatesList.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.DatesList.RootElement.ForeColor = System.Drawing.Color.Black;
            this.DatesList.Size = new System.Drawing.Size(139, 20);
            this.DatesList.TabIndex = 1;
            this.DatesList.TabStop = false;
            // 
            // radLabel2
            // 
            this.radLabel2.BackColor = System.Drawing.Color.Transparent;
            this.radLabel2.ForeColor = System.Drawing.Color.Black;
            this.radLabel2.Location = new System.Drawing.Point(21, 17);
            this.radLabel2.Name = "radLabel2";
            // 
            // 
            // 
            this.radLabel2.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radLabel2.Size = new System.Drawing.Size(80, 16);
            this.radLabel2.TabIndex = 6;
            this.radLabel2.Text = "Selected Date:";
            this.radLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radLabel3
            // 
            this.radLabel3.BackColor = System.Drawing.Color.Transparent;
            this.radLabel3.ForeColor = System.Drawing.Color.Black;
            this.radLabel3.Location = new System.Drawing.Point(21, 62);
            this.radLabel3.Name = "radLabel3";
            // 
            // 
            // 
            this.radLabel3.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radLabel3.Size = new System.Drawing.Size(107, 16);
            this.radLabel3.TabIndex = 7;
            this.radLabel3.Text = "Selected Day Color:";
            this.radLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radLabel4
            // 
            this.radLabel4.BackColor = System.Drawing.Color.Transparent;
            this.radLabel4.ForeColor = System.Drawing.Color.Black;
            this.radLabel4.Location = new System.Drawing.Point(21, 107);
            this.radLabel4.Name = "radLabel4";
            // 
            // 
            // 
            this.radLabel4.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radLabel4.Size = new System.Drawing.Size(102, 16);
            this.radLabel4.TabIndex = 8;
            this.radLabel4.Text = "Selected Day Text:";
            this.radLabel4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ColorList
            // 
            this.ColorList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ColorList.DropDownSizingMode = ((Telerik.WinControls.UI.SizingMode)((Telerik.WinControls.UI.SizingMode.RightBottom | Telerik.WinControls.UI.SizingMode.UpDown)));
            this.ColorList.Location = new System.Drawing.Point(21, 82);
            this.ColorList.MaxDropDownItems = 6;
            this.ColorList.Name = "ColorList";
            // 
            // 
            // 
            this.ColorList.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.ColorList.RootElement.ForeColor = System.Drawing.Color.Black;
            this.ColorList.Size = new System.Drawing.Size(139, 20);
            this.ColorList.TabIndex = 7;
            this.ColorList.TabStop = false;
            // 
            // radButton1
            // 
            this.radButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.radButton1.Location = new System.Drawing.Point(21, 153);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(139, 23);
            this.radButton1.TabIndex = 8;
            this.radButton1.Text = "Apply Changes";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // radTextBox1
            // 
            this.radTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.radTextBox1.ForeColor = System.Drawing.Color.Black;
            this.radTextBox1.Location = new System.Drawing.Point(21, 127);
            this.radTextBox1.Name = "radTextBox1";
            // 
            // 
            // 
            this.radTextBox1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radTextBox1.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radTextBox1.Size = new System.Drawing.Size(139, 20);
            this.radTextBox1.TabIndex = 7;
            this.radTextBox1.TabStop = false;
            this.radTextBox1.Text = "MyDay";
            // 
            // radGroupRenderOpts
            // 
            this.radGroupRenderOpts.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupRenderOpts.Controls.Add(this.radLabel2);
            this.radGroupRenderOpts.Controls.Add(this.radLabel3);
            this.radGroupRenderOpts.Controls.Add(this.DatesList);
            this.radGroupRenderOpts.Controls.Add(this.radLabel4);
            this.radGroupRenderOpts.Controls.Add(this.radTextBox1);
            this.radGroupRenderOpts.Controls.Add(this.ColorList);
            this.radGroupRenderOpts.Controls.Add(this.radButton1);
            this.radGroupRenderOpts.FooterImageIndex = -1;
            this.radGroupRenderOpts.FooterImageKey = "";
            this.radGroupRenderOpts.ForeColor = System.Drawing.Color.Black;
            this.radGroupRenderOpts.HeaderImageIndex = -1;
            this.radGroupRenderOpts.HeaderImageKey = "";
            this.radGroupRenderOpts.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupRenderOpts.HeaderText = "Rendering Options";
            this.radGroupRenderOpts.Location = new System.Drawing.Point(10, 6);
            this.radGroupRenderOpts.Name = "radGroupRenderOpts";
            this.radGroupRenderOpts.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            // 
            // 
            // 
            this.radGroupRenderOpts.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radGroupRenderOpts.RootElement.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.radGroupRenderOpts.Size = new System.Drawing.Size(180, 192);
            this.radGroupRenderOpts.TabIndex = 1;
            this.radGroupRenderOpts.Text = "Rendering Options";
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
            ((System.ComponentModel.ISupportInitialize)(this.DatesList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupRenderOpts)).EndInit();
            this.radGroupRenderOpts.ResumeLayout(false);
            this.radGroupRenderOpts.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Telerik.WinControls.UI.RadCalendar radCalendar1;
        private Telerik.WinControls.UI.RadDropDownList DatesList;
        private Telerik.WinControls.UI.RadButton radButton1;
		private Telerik.WinControls.UI.RadTextBox radTextBox1;
        private Telerik.WinControls.UI.RadDropDownList ColorList;
		private Telerik.WinControls.UI.RadLabel radLabel2;
		private Telerik.WinControls.UI.RadLabel radLabel3;
		private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadGroupBox radGroupRenderOpts;
	}
}