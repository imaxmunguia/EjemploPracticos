Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.RadScheduler.FirstLook
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing


		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Dim dateTimeInterval1 As New Telerik.WinControls.UI.DateTimeInterval()
			Me.radLblTheme = New Telerik.WinControls.UI.RadLabel()
			Me.radCalendar1 = New Telerik.WinControls.UI.RadCalendar()
			Me.cmbTheme = New Telerik.WinControls.UI.RadDropDownList()
			Me.object_a65e45d6_6d0c_4754_ac40_31a6d96432e9 = New Telerik.WinControls.RootRadElement()
			Me.radSchedulerNavigator1 = New Telerik.WinControls.UI.RadSchedulerNavigator()
			Me.radSchedulerDemo = New Telerik.WinControls.UI.RadScheduler()
			Me.radPageView1 = New Telerik.WinControls.UI.RadPageView()
			Me.radPageViewPage1 = New Telerik.WinControls.UI.RadPageViewPage()
			Me.radPageViewPage2 = New Telerik.WinControls.UI.RadPageViewPage()
			Me.radPageViewPage3 = New Telerik.WinControls.UI.RadPageViewPage()
			Me.radPageViewPage4 = New Telerik.WinControls.UI.RadPageViewPage()
			Me.radPageViewPage5 = New Telerik.WinControls.UI.RadPageViewPage()
			Me.radDesktopAlert1 = New Telerik.WinControls.UI.RadDesktopAlert(Me.components)
			Me.radSchedulerReminder1 = New Telerik.WinControls.UI.RadSchedulerReminder(Me.components)
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			Me.radDropDownList1 = New Telerik.WinControls.UI.RadDropDownList()
			CType(Me.radLblTheme, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCalendar1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cmbTheme, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSchedulerNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSchedulerDemo, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPageView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPageView1.SuspendLayout()
			Me.radPageViewPage1.SuspendLayout()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radDropDownList1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radLblTheme
			' 
			Me.radLblTheme.BackColor = System.Drawing.Color.Transparent
			Me.radLblTheme.ForeColor = System.Drawing.Color.Black
			Me.radLblTheme.Location = New System.Drawing.Point(4, 12)
			Me.radLblTheme.Name = "radLblTheme"
			' 
			' 
			' 
			Me.radLblTheme.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radLblTheme.Size = New System.Drawing.Size(80, 19)
			Me.radLblTheme.TabIndex = 10
			Me.radLblTheme.Text = "Select theme:"
			Me.radLblTheme.Visible = False
			' 
			' radCalendar1
			' 
			Me.radCalendar1.AllowMultipleView = True
			Me.radCalendar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
			Me.radCalendar1.CellAlign = System.Drawing.ContentAlignment.MiddleCenter
			Me.radCalendar1.FastNavigationNextImage = (CType(resources.GetObject("radCalendar1.FastNavigationNextImage"), System.Drawing.Image))
			Me.radCalendar1.FastNavigationPrevImage = (CType(resources.GetObject("radCalendar1.FastNavigationPrevImage"), System.Drawing.Image))
			Me.radCalendar1.HeaderHeight = 17
			Me.radCalendar1.HeaderWidth = 17
			Me.radCalendar1.Location = New System.Drawing.Point(0, 0)
			Me.radCalendar1.Margin = New System.Windows.Forms.Padding(0)
			Me.radCalendar1.MultiViewRows = 3
			Me.radCalendar1.Name = "radCalendar1"
			Me.radCalendar1.NavigationNextImage = (CType(resources.GetObject("radCalendar1.NavigationNextImage"), System.Drawing.Image))
			Me.radCalendar1.NavigationPrevImage = (CType(resources.GetObject("radCalendar1.NavigationPrevImage"), System.Drawing.Image))
			Me.radCalendar1.RangeMaxDate = New System.DateTime(2099, 12, 30, 0, 0, 0, 0)
			Me.radCalendar1.SelectedDate = New System.DateTime(1900, 1, 1, 0, 0, 0, 0)
			Me.radCalendar1.Size = New System.Drawing.Size(252, 530)
			Me.radCalendar1.TabIndex = 1
			Me.radCalendar1.Text = "radCalendar1"
			Me.radCalendar1.ThemeName = "ControlDefault"
			Me.radCalendar1.TitleAlign = System.Windows.Forms.VisualStyles.ContentAlignment.Center
			Me.radCalendar1.ZoomFactor = 1.2F
			' 
			' cmbTheme
			' 
			Me.cmbTheme.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.cmbTheme.DropDownSizingMode = (CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode))
			Me.cmbTheme.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.cmbTheme.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(17))))), (CInt(Fix((CByte(17))))), (CInt(Fix((CByte(17))))))
			Me.cmbTheme.FormatString = "{0}"
			Me.cmbTheme.Location = New System.Drawing.Point(90, 10)
			Me.cmbTheme.Name = "cmbTheme"
			' 
			' 
			' 
			Me.cmbTheme.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.cmbTheme.RootElement.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(17))))), (CInt(Fix((CByte(17))))), (CInt(Fix((CByte(17))))))
			Me.cmbTheme.Size = New System.Drawing.Size(198, 21)
			Me.cmbTheme.TabIndex = 6
			Me.cmbTheme.Visible = False
			' 
			' object_a65e45d6_6d0c_4754_ac40_31a6d96432e9
			' 
			Me.object_a65e45d6_6d0c_4754_ac40_31a6d96432e9.MinSize = New System.Drawing.Size(400, 74)
			Me.object_a65e45d6_6d0c_4754_ac40_31a6d96432e9.Name = "object_a65e45d6_6d0c_4754_ac40_31a6d96432e9"
			Me.object_a65e45d6_6d0c_4754_ac40_31a6d96432e9.StretchHorizontally = True
			Me.object_a65e45d6_6d0c_4754_ac40_31a6d96432e9.StretchVertically = True
			' 
			' radSchedulerNavigator1
			' 
			Me.radSchedulerNavigator1.AssociatedScheduler = Me.radSchedulerDemo
			Me.radSchedulerNavigator1.DateFormat = "MM/dd/yyyy"
			Me.radSchedulerNavigator1.Location = New System.Drawing.Point(272, 43)
			Me.radSchedulerNavigator1.MinimumSize = New System.Drawing.Size(400, 74)
			Me.radSchedulerNavigator1.Name = "radSchedulerNavigator1"
			Me.radSchedulerNavigator1.NavigationStepType = Telerik.WinControls.UI.NavigationStepTypes.Day
			' 
			' 
			' 
			Me.radSchedulerNavigator1.RootElement.MinSize = New System.Drawing.Size(400, 74)
			Me.radSchedulerNavigator1.RootElement.StretchVertically = False
			Me.radSchedulerNavigator1.Size = New System.Drawing.Size(723, 77)
			Me.radSchedulerNavigator1.TabIndex = 8
			Me.radSchedulerNavigator1.ThemeName = "ControlDefault"
			CType(Me.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(2).GetChildAt(0), Telerik.WinControls.UI.RadToggleButtonElement).ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			CType(Me.radSchedulerNavigator1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2).GetChildAt(2), Telerik.WinControls.UI.RadLabelElement).Text = "11/02/2009 - 11/04/2009"
			' 
			' radSchedulerDemo
			' 
			dateTimeInterval1.End = New System.DateTime((CLng(Fix(0))))
			Me.radSchedulerDemo.AccessibleInterval = dateTimeInterval1
			Me.radSchedulerDemo.AppointmentTitleFormat = Nothing
			Me.radSchedulerDemo.Culture = New System.Globalization.CultureInfo("en-US")
			Me.radSchedulerDemo.DataSource = Nothing
			Me.radSchedulerDemo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F)
			Me.radSchedulerDemo.GroupType = Telerik.WinControls.UI.GroupType.None
			Me.radSchedulerDemo.HeaderFormat = "dd (ddd)"
			Me.radSchedulerDemo.Location = New System.Drawing.Point(272, 117)
			Me.radSchedulerDemo.Name = "radSchedulerDemo"
			Me.radSchedulerDemo.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
			' 
			' 
			' 
			Me.radSchedulerDemo.RootElement.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
			Me.radSchedulerDemo.Size = New System.Drawing.Size(723, 522)
			Me.radSchedulerDemo.TabIndex = 0
			' 
			' radPageView1
			' 
			Me.radPageView1.Controls.Add(Me.radPageViewPage1)
			Me.radPageView1.Controls.Add(Me.radPageViewPage2)
			Me.radPageView1.Controls.Add(Me.radPageViewPage3)
			Me.radPageView1.Controls.Add(Me.radPageViewPage4)
			Me.radPageView1.Controls.Add(Me.radPageViewPage5)
			Me.radPageView1.Location = New System.Drawing.Point(4, 43)
			Me.radPageView1.Name = "radPageView1"
			Me.radPageView1.SelectedPage = Me.radPageViewPage1
			Me.radPageView1.Size = New System.Drawing.Size(262, 596)
			Me.radPageView1.TabIndex = 11
			Me.radPageView1.Text = "radPageView1"
			Me.radPageView1.ViewMode = Telerik.WinControls.UI.PageViewMode.Outlook
			' 
			' radPageViewPage1
			' 
			Me.radPageViewPage1.Controls.Add(Me.radCalendar1)
			Me.radPageViewPage1.Image = My.Resources.OutlookViewCalendar
			Me.radPageViewPage1.Location = New System.Drawing.Point(5, 31)
			Me.radPageViewPage1.Name = "radPageViewPage1"
			Me.radPageViewPage1.Size = New System.Drawing.Size(252, 331)
			Me.radPageViewPage1.Text = "Calendar"
			' 
			' radPageViewPage2
			' 
			Me.radPageViewPage2.BackgroundImage = My.Resources.Notes
			Me.radPageViewPage2.Image = My.Resources.OutlookViewNotes
			Me.radPageViewPage2.Location = New System.Drawing.Point(5, 31)
			Me.radPageViewPage2.Name = "radPageViewPage2"
			Me.radPageViewPage2.Size = New System.Drawing.Size(252, 331)
			Me.radPageViewPage2.Text = "Notes"
			' 
			' radPageViewPage3
			' 
			Me.radPageViewPage3.BackgroundImage = My.Resources.Tasks
			Me.radPageViewPage3.Image = My.Resources.OutlookViewTasks
			Me.radPageViewPage3.Location = New System.Drawing.Point(5, 31)
			Me.radPageViewPage3.Name = "radPageViewPage3"
			Me.radPageViewPage3.Size = New System.Drawing.Size(252, 331)
			Me.radPageViewPage3.Text = "Tasks"
			' 
			' radPageViewPage4
			' 
			Me.radPageViewPage4.BackgroundImage = My.Resources.Contacts
			Me.radPageViewPage4.Image = My.Resources.OutlookViewContacts
			Me.radPageViewPage4.Location = New System.Drawing.Point(5, 31)
			Me.radPageViewPage4.Name = "radPageViewPage4"
			Me.radPageViewPage4.Size = New System.Drawing.Size(252, 331)
			Me.radPageViewPage4.Text = "Contacts"
			' 
			' radPageViewPage5
			' 
			Me.radPageViewPage5.BackgroundImage = My.Resources.Mail
			Me.radPageViewPage5.Image = My.Resources.OutlookViewMail
			Me.radPageViewPage5.Location = New System.Drawing.Point(5, 31)
			Me.radPageViewPage5.Name = "radPageViewPage5"
			Me.radPageViewPage5.Size = New System.Drawing.Size(252, 331)
			Me.radPageViewPage5.Text = "Mail"
			' 
			' radDesktopAlert1
			' 
			Me.radDesktopAlert1.ContentImage = Nothing
			Me.radDesktopAlert1.PlaySound = False
			Me.radDesktopAlert1.SoundToPlay = Nothing
			Me.radDesktopAlert1.ThemeName = Nothing
			' 
			' radSchedulerReminder1
			' 
			Me.radSchedulerReminder1.AssociatedScheduler = Nothing
			Me.radSchedulerReminder1.StartNotification = System.TimeSpan.Parse("00:15:00")
			Me.radSchedulerReminder1.ThemeName = Nothing
			Me.radSchedulerReminder1.TimeInterval = 60000
			' 
			' radLabel1
			' 
			Me.radLabel1.BackColor = System.Drawing.Color.Transparent
			Me.radLabel1.ForeColor = System.Drawing.Color.Black
			Me.radLabel1.Location = New System.Drawing.Point(740, 14)
			Me.radLabel1.Name = "radLabel1"
			' 
			' 
			' 
			Me.radLabel1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radLabel1.Size = New System.Drawing.Size(78, 19)
			Me.radLabel1.TabIndex = 13
			Me.radLabel1.Text = "Active editor:"
			' 
			' radDropDownList1
			' 
			Me.radDropDownList1.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.radDropDownList1.DropDownSizingMode = (CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode))
			Me.radDropDownList1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.radDropDownList1.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(17))))), (CInt(Fix((CByte(17))))), (CInt(Fix((CByte(17))))))
			Me.radDropDownList1.FormatString = "{0}"
			Me.radDropDownList1.Location = New System.Drawing.Point(824, 12)
			Me.radDropDownList1.Name = "radDropDownList1"
			' 
			' 
			' 
			Me.radDropDownList1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radDropDownList1.RootElement.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(17))))), (CInt(Fix((CByte(17))))), (CInt(Fix((CByte(17))))))
			Me.radDropDownList1.Size = New System.Drawing.Size(171, 21)
			Me.radDropDownList1.TabIndex = 12
'			Me.radDropDownList1.SelectedValueChanged += New System.EventHandler(Me.radDropDownList1_SelectedValueChanged);
			' 
			' Form1
			' 
			Me.ClientSize = New System.Drawing.Size(1011, 665)
			Me.Controls.Add(Me.radLabel1)
			Me.Controls.Add(Me.radDropDownList1)
			Me.Controls.Add(Me.radPageView1)
			Me.Controls.Add(Me.radSchedulerNavigator1)
			Me.Controls.Add(Me.radSchedulerDemo)
			Me.Controls.Add(Me.radLblTheme)
			Me.Controls.Add(Me.cmbTheme)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
			Me.MaximizeBox = False
			Me.Name = "Form1"
			Me.Padding = New System.Windows.Forms.Padding(0, 0, 0, 10)
			' 
			' 
			' 
			Me.RootElement.ApplyShapeToControl = True
			Me.RootElement.MinSize = New System.Drawing.Size(150, 36)
			Me.Text = "RadScheduler Outlook Demo"
			CType(Me.radLblTheme, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCalendar1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cmbTheme, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSchedulerNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSchedulerDemo, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPageView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPageView1.ResumeLayout(False)
			Me.radPageViewPage1.ResumeLayout(False)
			Me.radPageViewPage1.PerformLayout()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radDropDownList1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private radSchedulerDemo As Telerik.WinControls.UI.RadScheduler
		Private radCalendar1 As Telerik.WinControls.UI.RadCalendar
		Private cmbTheme As Telerik.WinControls.UI.RadDropDownList
		Private radSchedulerNavigator1 As Telerik.WinControls.UI.RadSchedulerNavigator
		Private radLblTheme As Telerik.WinControls.UI.RadLabel
		Private object_a65e45d6_6d0c_4754_ac40_31a6d96432e9 As Telerik.WinControls.RootRadElement
		Private radPageView1 As Telerik.WinControls.UI.RadPageView
		Private radPageViewPage1 As Telerik.WinControls.UI.RadPageViewPage
		Private radPageViewPage2 As Telerik.WinControls.UI.RadPageViewPage
		Private radPageViewPage3 As Telerik.WinControls.UI.RadPageViewPage
		Private radPageViewPage4 As Telerik.WinControls.UI.RadPageViewPage
		Private radPageViewPage5 As Telerik.WinControls.UI.RadPageViewPage
		Private radDesktopAlert1 As Telerik.WinControls.UI.RadDesktopAlert
		Private radSchedulerReminder1 As Telerik.WinControls.UI.RadSchedulerReminder
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
		Private WithEvents radDropDownList1 As Telerik.WinControls.UI.RadDropDownList
	End Class
End Namespace