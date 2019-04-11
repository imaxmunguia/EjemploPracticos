Imports Microsoft.VisualBasic
Imports System
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.RadScheduler.Events
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Protected Overrides Function GetExampleDefaultTheme() As String
			Return "ControlDefault"
		End Function

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			Dim baseDate As DateTime = DateTime.Today
			Dim start() As DateTime = { baseDate.AddHours(14.0), baseDate.AddDays(1.0).AddHours(9.0), baseDate.AddDays(2.0).AddHours(13.0) }
			Dim [end]() As DateTime = { baseDate.AddHours(16.0), baseDate.AddDays(1.0).AddHours(15.0), baseDate.AddDays(2.0).AddHours(17.0) }
			Dim summaries() As String = { "Mr. Brown", "Mr. White", "Mrs. Green" }
			Dim descriptions() As String = { "", "", "" }
			Dim locations() As String = { "City", "Out of town", "Service Center" }
			Dim backgrounds() As AppointmentBackground = { AppointmentBackground.Business, AppointmentBackground.MustAttend, AppointmentBackground.Personal }

			Me.radSchedulerDemo.Appointments.BeginUpdate()
			Dim appointment As Appointment = Nothing
			For i As Integer = 0 To summaries.Length - 1
				appointment = New Appointment(start(i), [end](i), summaries(i), descriptions(i), locations(i))
				appointment.BackgroundId = CInt(Fix(backgrounds(i)))
				Me.radSchedulerDemo.Appointments.Add(appointment)
			Next i

			appointment = New Appointment(baseDate.AddHours(11.0), baseDate.AddHours(12.0), "Wash the car", "", "Garage")
			appointment.RecurrenceRule = New DailyRecurrenceRule(baseDate.AddHours(11.0), 2)
			Me.radSchedulerDemo.Appointments.Add(appointment)
			Me.radSchedulerDemo.Appointments.EndUpdate()

			Me.radSchedulerDemo.Resources.Add(New Resource(1, "Dell Laptop"))
			Me.radSchedulerDemo.Resources.Add(New Resource(2, "Lenovo Laptop"))
			Me.radSchedulerDemo.Resources.Add(New Resource(3, "Toshiba Laptop"))
			TryCast(Me.radSchedulerDemo.ActiveView, SchedulerDayView).DayCount = 1
			Me.radTxtEventList.ReadOnly = True
		End Sub

		Private Sub radScheduler1_AppointmentMouseDown(ByVal sender As Object, ByVal e As SchedulerAppointmentMouseEventArgs) Handles radSchedulerDemo.AppointmentMouseDown
			Me.radTxtEventList.Text &= "AppointmentMouseDown" & Constants.vbCrLf
			Me.radTxtEventList.SelectionStart = Me.radTxtEventList.TextLength
			Me.radTxtEventList.ScrollToCaret()
		End Sub

		Private Sub radScheduler1_AppointmentMouseUp(ByVal sender As Object, ByVal e As SchedulerAppointmentMouseEventArgs) Handles radSchedulerDemo.AppointmentMouseUp
			Me.radTxtEventList.Text &= "AppointmentMouseUp" & Constants.vbCrLf
			Me.radTxtEventList.SelectionStart = Me.radTxtEventList.TextLength
			Me.radTxtEventList.ScrollToCaret()
		End Sub

		Private Sub radScheduler1_AppointmentEditDialogShowing(ByVal sender As Object, ByVal e As AppointmentEditDialogShowingEventArgs) Handles radSchedulerDemo.AppointmentEditDialogShowing
			Me.radTxtEventList.Text &= "AppointmentEditDialogShowing" & Constants.vbCrLf
			Me.radTxtEventList.SelectionStart = Me.radTxtEventList.TextLength
			Me.radTxtEventList.ScrollToCaret()
		End Sub

		Private Sub radScheduler1_AppointmentSelected(ByVal sender As Object, ByVal e As SchedulerAppointmentEventArgs) Handles radSchedulerDemo.AppointmentSelected
			Me.radTxtEventList.Text &= "AppointmentSelected" & Constants.vbCrLf
			Me.radTxtEventList.SelectionStart = Me.radTxtEventList.TextLength
			Me.radTxtEventList.ScrollToCaret()
		End Sub

		Private Sub radScheduler1_AppointmentSelecting(ByVal sender As Object, ByVal e As SchedulerAppointmentCancelEventArgs) Handles radSchedulerDemo.AppointmentSelecting
			Me.radTxtEventList.Text &= "AppointmentSelecting" & Constants.vbCrLf
			Me.radTxtEventList.SelectionStart = Me.radTxtEventList.TextLength
			Me.radTxtEventList.ScrollToCaret()
		End Sub

		Private Sub radScheduler1_CellClick(ByVal sender As Object, ByVal e As SchedulerCellEventArgs) Handles radSchedulerDemo.CellClick
			Me.radTxtEventList.Text &= "CellClick" & Constants.vbCrLf
			Me.radTxtEventList.SelectionStart = Me.radTxtEventList.TextLength
			Me.radTxtEventList.ScrollToCaret()
		End Sub

		Private Sub radScheduler1_ActiveViewChanging(ByVal sender As Object, ByVal e As SchedulerViewChangingEventArgs) Handles radSchedulerDemo.ActiveViewChanging
			Me.radTxtEventList.Text &= "ActiveViewChanging" & Constants.vbCrLf
			Me.radTxtEventList.SelectionStart = Me.radTxtEventList.TextLength
			Me.radTxtEventList.ScrollToCaret()
		End Sub

		Private Sub radScheduler1_ActiveViewChanged(ByVal sender As Object, ByVal e As SchedulerViewChangedEventArgs) Handles radSchedulerDemo.ActiveViewChanged
			Me.radTxtEventList.Text &= "ActiveViewChanged" & Constants.vbCrLf
			Me.radTxtEventList.SelectionStart = Me.radTxtEventList.TextLength
			Me.radTxtEventList.ScrollToCaret()
		End Sub

		Private Sub radSchedulerDemo_RecurrenceEditDialogShowing(ByVal sender As Object, ByVal e As RecurrenceEditDialogShowingEventArgs) Handles radSchedulerDemo.RecurrenceEditDialogShowing
			Me.radTxtEventList.Text &= "RecurrenceEditDialogShowing" & Constants.vbCrLf
			Me.radTxtEventList.SelectionStart = Me.radTxtEventList.TextLength
			Me.radTxtEventList.ScrollToCaret()
		End Sub
	End Class
End Namespace
