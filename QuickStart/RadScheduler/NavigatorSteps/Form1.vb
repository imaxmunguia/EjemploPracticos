Imports Microsoft.VisualBasic
Imports System
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.RadScheduler.NavigatorSteps
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Protected Overrides Function GetExampleDefaultTheme() As String
			Return ""
		End Function

		Private Sub radScheduler1_ActiveViewChanged(ByVal sender As Object, ByVal e As SchedulerViewChangedEventArgs)
			If e.NewView.ViewType <> e.OldView.ViewType AndAlso e.NewView.ViewType = SchedulerViewType.Month Then
				Me.radScheduler1.GetMonthView().WeekCount = 5
			End If

			UpdateControlsAndValues()

			Me.radSpinEditor1.Value = Me.radSchedulerNavigator1.NavigationStep
		End Sub

		Private Sub FillNavigationStepTypesCombo()
			Me.radComboBox1.Items.Add(New RadListDataItem("Day", NavigationStepTypes.Day))
			Me.radComboBox1.Items.Add(New RadListDataItem("Week", NavigationStepTypes.Week))
			Me.radComboBox1.Items.Add(New RadListDataItem("Month", NavigationStepTypes.Month))
		End Sub

		Private Sub FillAppointments()
			Me.radScheduler1.Appointments.BeginUpdate()

			Dim dtStart As DateTime = DateTime.Today.AddDays(2).AddHours(10)
			Dim dtEnd As DateTime = DateTime.Today.AddDays(2).AddHours(12)

			Dim appointment As New Appointment(dtStart, dtEnd, "ASP.NET AJAX Or Silverlight Is The Future Of Web Development", "Understanding the future is critical for web developers. Decisions you make today need to be aware of what's coming if you're going to be successful on web. In this session, we'll examine ASP.NET AJAX and Silverlight to gain a deep understanding of how these technologies can help us solve the problems of a rich, ajaxified Internet. From the rich client-side library in ASP.NETAJAX that changes the way you write JavaScript to the power of .NET in the browser with Silverlight, understanding how to leverage these technologies is key for future ASP.NET applications. We'll also examine the future of web browsers and seek to understand how they will affect the applications we build")
			appointment.BackgroundId = CInt(Fix(AppointmentBackground.MustAttend))
			appointment.StatusId = CInt(Fix(AppointmentStatus.Unavailable))
			Me.radScheduler1.Appointments.Add(appointment)

			dtStart = dtStart.AddDays(-1)
			dtEnd = dtEnd.AddDays(-1)

			appointment = New Appointment(dtStart.AddHours(2), dtEnd.AddHours(3), "Silverlight Made Easy", "This session will introduce people to Silverlight with coding in C# and VB.NET to build high quality, robust and elegant web sites.")
			appointment.BackgroundId = CInt(Fix(AppointmentBackground.PhoneCall))
			appointment.StatusId = CInt(Fix(AppointmentStatus.Free))
			Me.radScheduler1.Appointments.Add(appointment)

			dtStart = dtStart.AddDays(-1)
			dtEnd = dtEnd.AddDays(-1)

			appointment = New Appointment(dtStart.AddHours(-2), dtEnd.AddHours(4), "SQL 2008", "SQL Server 2008 introduces support for Microsoft PowerShell. PowerShell is a powerful scripting shell that lets administrators and developers automate server administration and application deployment. It is more powerful than simple T-SQL and provides great features to SQL Server administrator. This session will cover the basics of the SQL Server providers in PowerShell.")
			appointment.BackgroundId = CInt(Fix(AppointmentBackground.NeedsPreparation))
			appointment.StatusId = CInt(Fix(AppointmentStatus.Tentative))
			Me.radScheduler1.Appointments.Add(appointment)

			Me.radScheduler1.Appointments.EndUpdate()
		End Sub

		Private Sub radComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles radComboBox1.SelectedIndexChanged
			UpdateControlsAndValues()
		End Sub

		Private Sub UpdateControlsAndValues()
			Dim selectedItem As RadListDataItem = TryCast(Me.radComboBox1.SelectedItem, RadListDataItem)
			If selectedItem IsNot Nothing Then
				Dim stepType As NavigationStepTypes = CType(selectedItem.Value, NavigationStepTypes)
				Me.radSchedulerNavigator1.NavigationStepType = stepType

				If Me.radScheduler1.ActiveViewType <> SchedulerViewType.Day AndAlso Me.radScheduler1.ActiveViewType <> SchedulerViewType.Timeline AndAlso stepType = NavigationStepTypes.Day Then
					Me.radSpinEditor1.Minimum = 7
				Else
					Me.radSpinEditor1.Minimum = 1
				End If
			End If
		End Sub

		Private Sub radSpinEditor1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radSpinEditor1.ValueChanged
			Me.radSchedulerNavigator1.NavigationStep = CInt(Fix(Me.radSpinEditor1.Value))
		End Sub

		Private Sub radCheckBox1_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles radCheckBox1.ToggleStateChanged
			Me.radSchedulerNavigator1.AutomaticNavigation = Me.radCheckBox1.Checked
			Me.radGroupBox1.Enabled = Not Me.radCheckBox1.Checked
		End Sub

         Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
             Me.radSchedulerNavigator1.AssociatedScheduler = Me.radScheduler1

            Me.radScheduler1.ActiveView.StartDate = DateTime.Today

			FillAppointments()

			FillNavigationStepTypesCombo()

			Me.radComboBox1.SelectedIndex = 0

			Me.radGroupBox1.Enabled = False

			AddHandler radScheduler1.ActiveViewChanged, AddressOf radScheduler1_ActiveViewChanged
        End Sub
	End Class
End Namespace
