Imports Microsoft.VisualBasic
Imports System
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.RadScheduler.CustomWorkTime
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

            Me.radSchedulerNavigator1.AssociatedScheduler = Me.radScheduler1

            Me.radScheduler1.ActiveView.StartDate = DateTime.Now.Date

			SetDateTimePickersDefaultValues()

			AddHandler radDateTimePicker1.DateTimePickerElement.ValueChanging, AddressOf DateTimePickerElement_ValueChanging1
			AddHandler radDateTimePicker2.DateTimePickerElement.ValueChanging, AddressOf DateTimePickerElement_ValueChanging2

			FillAppointments()

			Me.radSchedulerNavigator1.TimelineViewButtonVisible = False
			Me.radSchedulerNavigator1.MonthViewButtonVisible = False

			ScrollToWorkTime()
		End Sub

		Protected Overrides Function GetExampleDefaultTheme() As String
			Return ""
		End Function

		Private Sub ScrollToWorkTime()
			Dim dayViewElement As SchedulerDayViewElement = (TryCast(Me.radScheduler1.SchedulerElement.ViewElement, SchedulerDayViewElement))
			Dim time As New TimeSpan(Me.radDateTimePicker1.Value.Hour - 1, Me.radDateTimePicker1.Value.Minute, 0)
			dayViewElement.DataAreaElement.Table.ScrollToTime(time)
		End Sub

		Private Sub FillAppointments()
			Me.radScheduler1.Appointments.BeginUpdate()

            Dim dtStart As DateTime = DateTime.Now.[Date].AddDays(2).AddHours(10)
            Dim dtEnd As DateTime = DateTime.Now.[Date].AddDays(2).AddHours(12)

			Dim appointment As New Appointment(dtStart, dtEnd, "ASP.NET AJAX Or Silverlight Is The Future Of Web Development", "Understanding the future is critical for web developers. Decisions you make today need to be aware of what's coming if you're going to be successful on web. In this session, we'll examine ASP.NET AJAX and Silverlight to gain a deep understanding of how these technologies can help us solve the problems of a rich, ajaxified Internet. From the rich client-side library in ASP.NETAJAX that changes the way you write JavaScript to the power of .NET in the browser with Silverlight, understanding how to leverage these technologies is key for future ASP.NET applications. We'll also examine the future of web browsers and seek to understand how they will affect the applications we build")
			appointment.BackgroundId = CInt(Fix(AppointmentBackground.Anniversary))
			appointment.StatusId = CInt(Fix(AppointmentStatus.Unavailable))
			Me.radScheduler1.Appointments.Add(appointment)

			dtStart = dtStart.AddDays(-1)
			dtEnd = dtEnd.AddDays(-1)

			appointment = New Appointment(dtStart.AddHours(2), dtEnd.AddHours(3), "Silverlight Made Easy", "This session will introduce people to Silverlight with coding in C# and VB.NET to build high quality, robust and elegant web sites.")
			appointment.BackgroundId = CInt(Fix(AppointmentBackground.Business))
			appointment.StatusId = CInt(Fix(AppointmentStatus.Free))
			Me.radScheduler1.Appointments.Add(appointment)

			dtStart = dtStart.AddDays(-1)
			dtEnd = dtEnd.AddDays(-1)

			appointment = New Appointment(dtStart.AddHours(4), dtEnd.AddHours(4), "SQL 2008", "SQL Server 2008 introduces support for Microsoft PowerShell. PowerShell is a powerful scripting shell that lets administrators and developers automate server administration and application deployment. It is more powerful than simple T-SQL and provides great features to SQL Server administrator. This session will cover the basics of the SQL Server providers in PowerShell.")
			appointment.BackgroundId = CInt(Fix(AppointmentBackground.Important))
			appointment.StatusId = CInt(Fix(AppointmentStatus.Tentative))
			Me.radScheduler1.Appointments.Add(appointment)

			Me.radScheduler1.Appointments.EndUpdate()
		End Sub

		Private Sub DateTimePickerElement_ValueChanging1(ByVal sender As Object, ByVal e As ValueChangingEventArgs)
			If CDate(e.NewValue) >= Me.radDateTimePicker2.Value Then
				e.Cancel = True
			End If
		End Sub

		Private Sub DateTimePickerElement_ValueChanging2(ByVal sender As Object, ByVal e As ValueChangingEventArgs)
			If CDate(e.NewValue) <= Me.radDateTimePicker1.Value Then
				e.Cancel = True
			End If
		End Sub

		Private Sub SetDateTimePickersDefaultValues()
			Dim dtStart As New DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 9, 0, 0)

			Me.radDateTimePicker1.Value = dtStart

			Dim dtEnd As New DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 14, 0, 0)

			Me.radDateTimePicker2.Value = dtEnd
		End Sub

		Private Sub radDateTimePicker_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radDateTimePicker2.ValueChanged, radDateTimePicker1.ValueChanged
			UpdateWorkTime()
		End Sub

		Private Sub UpdateWorkTime()
			Dim timeInterval As New TimeInterval(Me.radDateTimePicker1.Value.TimeOfDay, Me.radDateTimePicker2.Value.TimeOfDay)
			CType(Me.radScheduler1.ActiveView, SchedulerDayViewBase).WorkTime = timeInterval
		End Sub

		Private Sub radScheduler1_ActiveViewChanged(ByVal sender As Object, ByVal e As SchedulerViewChangedEventArgs) Handles radScheduler1.ActiveViewChanged
			If e.NewView.ViewType = e.OldView.ViewType Then
				Return
			End If

			Select Case Me.radScheduler1.ActiveViewType
				Case SchedulerViewType.Day
					Me.radScheduler1.GetDayView().DayCount = 3
					Me.radGroupBox1.Enabled = True
					UpdateWorkTime()
					ScrollToWorkTime()
				Case SchedulerViewType.Week, SchedulerViewType.WorkWeek
					Me.radGroupBox1.Enabled = True
					UpdateWorkTime()
					ScrollToWorkTime()
				Case Else
					Me.radGroupBox1.Enabled = False
			End Select
		End Sub
	End Class
End Namespace
