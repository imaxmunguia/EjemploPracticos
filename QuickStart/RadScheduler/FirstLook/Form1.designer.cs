namespace Telerik.Examples.WinControls.RadScheduler.FirstLook
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		
		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Telerik.WinControls.UI.DateTimeInterval dateTimeInterval1 = new Telerik.WinControls.UI.DateTimeInterval();
            this.radLblTheme = new Telerik.WinControls.UI.RadLabel();
            this.radCalendar1 = new Telerik.WinControls.UI.RadCalendar();
            this.cmbTheme = new Telerik.WinControls.UI.RadDropDownList();
            this.object_a65e45d6_6d0c_4754_ac40_31a6d96432e9 = new Telerik.WinControls.RootRadElement();
            this.radSchedulerNavigator1 = new Telerik.WinControls.UI.RadSchedulerNavigator();
            this.radSchedulerDemo = new Telerik.WinControls.UI.RadScheduler();
            this.radPageView1 = new Telerik.WinControls.UI.RadPageView();
            this.radPageViewPage1 = new Telerik.WinControls.UI.RadPageViewPage();
            this.radPageViewPage2 = new Telerik.WinControls.UI.RadPageViewPage();
            this.radPageViewPage3 = new Telerik.WinControls.UI.RadPageViewPage();
            this.radPageViewPage4 = new Telerik.WinControls.UI.RadPageViewPage();
            this.radPageViewPage5 = new Telerik.WinControls.UI.RadPageViewPage();
            this.radDesktopAlert1 = new Telerik.WinControls.UI.RadDesktopAlert(this.components);
            this.radSchedulerReminder1 = new Telerik.WinControls.UI.RadSchedulerReminder(this.components);
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radDropDownList1 = new Telerik.WinControls.UI.RadDropDownList();
            ((System.ComponentModel.ISupportInitialize)(this.radLblTheme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCalendar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTheme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSchedulerNavigator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSchedulerDemo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).BeginInit();
            this.radPageView1.SuspendLayout();
            this.radPageViewPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radLblTheme
            // 
            this.radLblTheme.BackColor = System.Drawing.Color.Transparent;
            this.radLblTheme.ForeColor = System.Drawing.Color.Black;
            this.radLblTheme.Location = new System.Drawing.Point(4, 12);
            this.radLblTheme.Name = "radLblTheme";
            // 
            // 
            // 
            this.radLblTheme.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radLblTheme.Size = new System.Drawing.Size(80, 19);
            this.radLblTheme.TabIndex = 10;
            this.radLblTheme.Text = "Select theme:";
            this.radLblTheme.Visible = false;
            // 
            // radCalendar1
            // 
            this.radCalendar1.AllowMultipleView = true;
            this.radCalendar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.radCalendar1.CellAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radCalendar1.FastNavigationNextImage = ((System.Drawing.Image)(resources.GetObject("radCalendar1.FastNavigationNextImage")));
            this.radCalendar1.FastNavigationPrevImage = ((System.Drawing.Image)(resources.GetObject("radCalendar1.FastNavigationPrevImage")));
            this.radCalendar1.HeaderHeight = 17;
            this.radCalendar1.HeaderWidth = 17;
            this.radCalendar1.Location = new System.Drawing.Point(0, 0);
            this.radCalendar1.Margin = new System.Windows.Forms.Padding(0);
            this.radCalendar1.MultiViewRows = 3;
            this.radCalendar1.Name = "radCalendar1";
            this.radCalendar1.NavigationNextImage = ((System.Drawing.Image)(resources.GetObject("radCalendar1.NavigationNextImage")));
            this.radCalendar1.NavigationPrevImage = ((System.Drawing.Image)(resources.GetObject("radCalendar1.NavigationPrevImage")));
            this.radCalendar1.RangeMaxDate = new System.DateTime(2099, 12, 30, 0, 0, 0, 0);
            this.radCalendar1.SelectedDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.radCalendar1.Size = new System.Drawing.Size(252, 530);
            this.radCalendar1.TabIndex = 1;
            this.radCalendar1.Text = "radCalendar1";
            this.radCalendar1.ThemeName = "ControlDefault";
            this.radCalendar1.TitleAlign = System.Windows.Forms.VisualStyles.ContentAlignment.Center;
            this.radCalendar1.ZoomFactor = 1.2F;
            // 
            // cmbTheme
            // 
            this.cmbTheme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTheme.DropDownSizingMode = ((Telerik.WinControls.UI.SizingMode)((Telerik.WinControls.UI.SizingMode.RightBottom | Telerik.WinControls.UI.SizingMode.UpDown)));
            this.cmbTheme.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.cmbTheme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.cmbTheme.FormatString = "{0}";
            this.cmbTheme.Location = new System.Drawing.Point(90, 10);
            this.cmbTheme.Name = "cmbTheme";
            // 
            // 
            // 
            this.cmbTheme.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.cmbTheme.RootElement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.cmbTheme.Size = new System.Drawing.Size(198, 21);
            this.cmbTheme.TabIndex = 6;
            this.cmbTheme.Visible = false;
            // 
            // object_a65e45d6_6d0c_4754_ac40_31a6d96432e9
            // 
            this.object_a65e45d6_6d0c_4754_ac40_31a6d96432e9.MinSize = new System.Drawing.Size(400, 74);
            this.object_a65e45d6_6d0c_4754_ac40_31a6d96432e9.Name = "object_a65e45d6_6d0c_4754_ac40_31a6d96432e9";
            this.object_a65e45d6_6d0c_4754_ac40_31a6d96432e9.StretchHorizontally = true;
            this.object_a65e45d6_6d0c_4754_ac40_31a6d96432e9.StretchVertically = true;
            // 
            // radSchedulerNavigator1
            // 
            this.radSchedulerNavigator1.AssociatedScheduler = this.radSchedulerDemo;
            this.radSchedulerNavigator1.DateFormat = "MM/dd/yyyy";
            this.radSchedulerNavigator1.Location = new System.Drawing.Point(272, 43);
            this.radSchedulerNavigator1.MinimumSize = new System.Drawing.Size(400, 74);
            this.radSchedulerNavigator1.Name = "radSchedulerNavigator1";
            this.radSchedulerNavigator1.NavigationStepType = Telerik.WinControls.UI.NavigationStepTypes.Day;
            // 
            // 
            // 
            this.radSchedulerNavigator1.RootElement.MinSize = new System.Drawing.Size(400, 74);
            this.radSchedulerNavigator1.RootElement.StretchVertically = false;
            this.radSchedulerNavigator1.Size = new System.Drawing.Size(723, 77);
            this.radSchedulerNavigator1.TabIndex = 8;
            this.radSchedulerNavigator1.ThemeName = "ControlDefault";
            ((Telerik.WinControls.UI.RadToggleButtonElement)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(2).GetChildAt(0))).ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            ((Telerik.WinControls.UI.RadLabelElement)(this.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2).GetChildAt(2))).Text = "11/02/2009 - 11/04/2009";
            // 
            // radSchedulerDemo
            // 
            dateTimeInterval1.End = new System.DateTime(((long)(0)));
            this.radSchedulerDemo.AccessibleInterval = dateTimeInterval1;
            this.radSchedulerDemo.AppointmentTitleFormat = null;
            this.radSchedulerDemo.Culture = new System.Globalization.CultureInfo("en-US");
            this.radSchedulerDemo.DataSource = null;
            this.radSchedulerDemo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.radSchedulerDemo.GroupType = Telerik.WinControls.UI.GroupType.None;
            this.radSchedulerDemo.HeaderFormat = "dd (ddd)";
            this.radSchedulerDemo.Location = new System.Drawing.Point(272, 117);
            this.radSchedulerDemo.Name = "radSchedulerDemo";
            // 
            // 
            // 
            this.radSchedulerDemo.Size = new System.Drawing.Size(723, 522);
            this.radSchedulerDemo.TabIndex = 0;
            // 
            // radPageView1
            // 
            this.radPageView1.Controls.Add(this.radPageViewPage1);
            this.radPageView1.Controls.Add(this.radPageViewPage2);
            this.radPageView1.Controls.Add(this.radPageViewPage3);
            this.radPageView1.Controls.Add(this.radPageViewPage4);
            this.radPageView1.Controls.Add(this.radPageViewPage5);
            this.radPageView1.Location = new System.Drawing.Point(4, 43);
            this.radPageView1.Name = "radPageView1";
            this.radPageView1.SelectedPage = this.radPageViewPage1;
            this.radPageView1.Size = new System.Drawing.Size(262, 596);
            this.radPageView1.TabIndex = 11;
            this.radPageView1.Text = "radPageView1";
            this.radPageView1.ViewMode = Telerik.WinControls.UI.PageViewMode.Outlook;
            // 
            // radPageViewPage1
            // 
            this.radPageViewPage1.Controls.Add(this.radCalendar1);
            this.radPageViewPage1.Image = global::Telerik.Examples.WinControls.Properties.Resources.OutlookViewCalendar;
            this.radPageViewPage1.Location = new System.Drawing.Point(5, 31);
            this.radPageViewPage1.Name = "radPageViewPage1";
            this.radPageViewPage1.Size = new System.Drawing.Size(252, 331);
            this.radPageViewPage1.Text = "Calendar";
            // 
            // radPageViewPage2
            // 
            this.radPageViewPage2.BackgroundImage = global::Telerik.Examples.WinControls.Properties.Resources.Notes;
            this.radPageViewPage2.Image = global::Telerik.Examples.WinControls.Properties.Resources.OutlookViewNotes;
            this.radPageViewPage2.Location = new System.Drawing.Point(5, 31);
            this.radPageViewPage2.Name = "radPageViewPage2";
            this.radPageViewPage2.Size = new System.Drawing.Size(252, 331);
            this.radPageViewPage2.Text = "Notes";
            // 
            // radPageViewPage3
            // 
            this.radPageViewPage3.BackgroundImage = global::Telerik.Examples.WinControls.Properties.Resources.Tasks;
            this.radPageViewPage3.Image = global::Telerik.Examples.WinControls.Properties.Resources.OutlookViewTasks;
            this.radPageViewPage3.Location = new System.Drawing.Point(5, 31);
            this.radPageViewPage3.Name = "radPageViewPage3";
            this.radPageViewPage3.Size = new System.Drawing.Size(252, 331);
            this.radPageViewPage3.Text = "Tasks";
            // 
            // radPageViewPage4
            // 
            this.radPageViewPage4.BackgroundImage = global::Telerik.Examples.WinControls.Properties.Resources.Contacts;
            this.radPageViewPage4.Image = global::Telerik.Examples.WinControls.Properties.Resources.OutlookViewContacts;
            this.radPageViewPage4.Location = new System.Drawing.Point(5, 31);
            this.radPageViewPage4.Name = "radPageViewPage4";
            this.radPageViewPage4.Size = new System.Drawing.Size(252, 331);
            this.radPageViewPage4.Text = "Contacts";
            // 
            // radPageViewPage5
            // 
            this.radPageViewPage5.BackgroundImage = global::Telerik.Examples.WinControls.Properties.Resources.Mail;
            this.radPageViewPage5.Image = global::Telerik.Examples.WinControls.Properties.Resources.OutlookViewMail;
            this.radPageViewPage5.Location = new System.Drawing.Point(5, 31);
            this.radPageViewPage5.Name = "radPageViewPage5";
            this.radPageViewPage5.Size = new System.Drawing.Size(252, 331);
            this.radPageViewPage5.Text = "Mail";
            // 
            // radDesktopAlert1
            // 
            this.radDesktopAlert1.ContentImage = null;
            this.radDesktopAlert1.PlaySound = false;
            this.radDesktopAlert1.SoundToPlay = null;
            this.radDesktopAlert1.ThemeName = null;
            // 
            // radSchedulerReminder1
            // 
            this.radSchedulerReminder1.AssociatedScheduler = null;
            this.radSchedulerReminder1.StartNotification = System.TimeSpan.Parse("00:15:00");
            this.radSchedulerReminder1.ThemeName = null;
            this.radSchedulerReminder1.TimeInterval = 60000;
            // 
            // radLabel1
            // 
            this.radLabel1.BackColor = System.Drawing.Color.Transparent;
            this.radLabel1.ForeColor = System.Drawing.Color.Black;
            this.radLabel1.Location = new System.Drawing.Point(740, 14);
            this.radLabel1.Name = "radLabel1";
            // 
            // 
            // 
            this.radLabel1.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radLabel1.Size = new System.Drawing.Size(78, 19);
            this.radLabel1.TabIndex = 13;
            this.radLabel1.Text = "Active editor:";
            // 
            // radDropDownList1
            // 
            this.radDropDownList1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radDropDownList1.DropDownSizingMode = ((Telerik.WinControls.UI.SizingMode)((Telerik.WinControls.UI.SizingMode.RightBottom | Telerik.WinControls.UI.SizingMode.UpDown)));
            this.radDropDownList1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.radDropDownList1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.radDropDownList1.FormatString = "{0}";
            this.radDropDownList1.Location = new System.Drawing.Point(824, 12);
            this.radDropDownList1.Name = "radDropDownList1";
            // 
            // 
            // 
            this.radDropDownList1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radDropDownList1.RootElement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.radDropDownList1.Size = new System.Drawing.Size(171, 21);
            this.radDropDownList1.TabIndex = 12;
            this.radDropDownList1.SelectedValueChanged += new System.EventHandler(this.radDropDownList1_SelectedValueChanged);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1011, 665);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.radDropDownList1);
            this.Controls.Add(this.radPageView1);
            this.Controls.Add(this.radSchedulerNavigator1);
            this.Controls.Add(this.radSchedulerDemo);
            this.Controls.Add(this.radLblTheme);
            this.Controls.Add(this.cmbTheme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MinSize = new System.Drawing.Size(150, 36);
            this.Text = "RadScheduler Outlook Demo";
            ((System.ComponentModel.ISupportInitialize)(this.radLblTheme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCalendar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTheme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSchedulerNavigator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSchedulerDemo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).EndInit();
            this.radPageView1.ResumeLayout(false);
            this.radPageViewPage1.ResumeLayout(false);
            this.radPageViewPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Telerik.WinControls.UI.RadScheduler radSchedulerDemo;
        private Telerik.WinControls.UI.RadCalendar radCalendar1;
        private Telerik.WinControls.UI.RadDropDownList cmbTheme;
        private Telerik.WinControls.UI.RadSchedulerNavigator radSchedulerNavigator1;
        private Telerik.WinControls.UI.RadLabel radLblTheme;
        private Telerik.WinControls.RootRadElement object_a65e45d6_6d0c_4754_ac40_31a6d96432e9;
        private Telerik.WinControls.UI.RadPageView radPageView1;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage1;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage2;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage3;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage4;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage5;
        private Telerik.WinControls.UI.RadDesktopAlert radDesktopAlert1;
        private Telerik.WinControls.UI.RadSchedulerReminder radSchedulerReminder1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadDropDownList radDropDownList1;
	}
}