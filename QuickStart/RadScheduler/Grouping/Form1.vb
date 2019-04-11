Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.RadScheduler.Grouping
	Partial Public Class Form1
		Inherits ExamplesForm
		Private Const THEME As String = "ControlDefault"

		Public Sub New()
			InitializeComponent()
		End Sub

		Protected Overrides Function GetExampleDefaultTheme() As String
			Return ""
		End Function

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

            Me.radSchedulerNavigator1.AssociatedScheduler = Me.radSchedulerDemo

			Dim baseDate As DateTime = DateTime.Today
			Dim start() As DateTime = { baseDate.AddHours(14.0), baseDate.AddDays(1.0).AddHours(9.0), baseDate.AddDays(2.0).AddHours(13.0) }
			Dim [end]() As DateTime = { baseDate.AddHours(16.0), baseDate.AddDays(1.0).AddHours(15.0), baseDate.AddDays(2.0).AddHours(17.0) }
			Dim summaries() As String = { "Mr. Brown", "Mr. White", "Mrs. Green" }
			Dim descriptions() As String = { "", "", "" }
			Dim locations() As String = { "City", "Out of town", "Service Center" }
			Dim backgrounds() As AppointmentBackground = { AppointmentBackground.Business, AppointmentBackground.MustAttend, AppointmentBackground.Personal }

			Me.radSchedulerDemo.Appointments.BeginUpdate()
			Dim appointment As Appointment = Nothing

			appointment = New Appointment(baseDate.AddHours(11.0), baseDate.AddHours(12.0), "Wash the car", "", "Garage")
			appointment.RecurrenceRule = New DailyRecurrenceRule(baseDate.AddHours(11.0), 2)
			Me.radSchedulerDemo.Appointments.Add(appointment)
			Me.radSchedulerDemo.Appointments.EndUpdate()

			Dim colors() As Color = {Color.LightBlue, Color.LightGreen, Color.LightYellow, Color.Red, Color.Orange, Color.Pink, Color.Purple, Color.Peru, Color.PowderBlue}

			Dim names() As String = {"Alan Smith", "Anne Dodsworth", "Boyan Mastoni", "Richard Duncan", "Maria Shnaider"}

			For i As Integer = 0 To names.Length - 1
				Dim resource As New Resource()
				resource.Id = New EventId(i)
				resource.Name = names(i)
				resource.Color = colors(i)

				resource.Image = Me.imageList1.Images(i)
				Me.radSchedulerDemo.Resources.Add(resource)
			Next i

			'this.radSchedulerDemo.GetDayView().DayCount = 1;
			Me.radSchedulerDemo.GetDayView().ResourcesPerView = 2
			Me.radSchedulerDemo.GroupType = GroupType.Resource
			Dim headerElement As SchedulerDayViewGroupedByResourceElement = TryCast(Me.radSchedulerDemo.SchedulerElement.ViewElement, SchedulerDayViewGroupedByResourceElement)
			headerElement.ResourceHeaderHeight = 135

			For i As Integer = 0 To summaries.Length - 1
				appointment = New Appointment(start(i), [end](i), summaries(i), descriptions(i), locations(i))
				appointment.ResourceId = Me.radSchedulerDemo.Resources(0).Id
				appointment.BackgroundId = CInt(Fix(backgrounds(i)))
				Me.radSchedulerDemo.Appointments.Add(appointment)
			Next i

			Dim dayView As SchedulerDayViewGroupedByResourceElement = TryCast(Me.radSchedulerDemo.SchedulerElement.ViewElement, SchedulerDayViewGroupedByResourceElement)
			dayView.ScrollToWorkHours()

			AddHandler radSchedulerDemo.ActiveViewChanged, AddressOf radSchedulerDemo_ActiveViewChanged
			AddHandler radSchedulerDemo.PropertyChanged, AddressOf radSchedulerDemo_PropertyChanged
			AddHandler radSchedulerDemo.MouseDown, AddressOf radSchedulerDemo_MouseDown

			Me.radSchedulerDemo.SchedulerElement.SetResourceHeaderAngleTransform(SchedulerViewType.Timeline, 0)
		End Sub

		Private Sub radSchedulerDemo_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
			If Me.isSwitchedMonthToWeek Then
				InvalidateScheduler()
				Me.isSwitchedMonthToWeek = False
			End If
		End Sub

		Private Sub radSchedulerDemo_PropertyChanged(ByVal sender As Object, ByVal e As PropertyChangedEventArgs)
			InvalidateScheduler()
		End Sub

		Private Sub radSchedulerDemo_ActiveViewChanged(ByVal sender As Object, ByVal e As SchedulerViewChangedEventArgs)
			If e.OldView.ViewType <> e.NewView.ViewType Then
				Select Case e.NewView.ViewType
					Case SchedulerViewType.Month
						Me.radSchedulerDemo.GetMonthView().WeekCount = 5
					Case SchedulerViewType.Day
						Me.radSchedulerDemo.GetDayView().DayCount = 1
				End Select
			End If

			If e.OldView.ViewType = SchedulerViewType.Month AndAlso e.NewView.ViewType = SchedulerViewType.Week Then
				Me.isSwitchedMonthToWeek = True
			End If

			InvalidateScheduler()
		End Sub

		Private isSwitchedMonthToWeek As Boolean = False

		Private Sub InvalidateScheduler()
			Dim dayView As SchedulerDayViewGroupedByResourceElement = TryCast(Me.radSchedulerDemo.SchedulerElement.ViewElement, SchedulerDayViewGroupedByResourceElement)
			Dim monthView As SchedulerMonthViewGroupedByResourceElement = TryCast(Me.radSchedulerDemo.SchedulerElement.ViewElement, SchedulerMonthViewGroupedByResourceElement)
			Dim timelineElement As TimelineGroupingByResourcesElement = TryCast(Me.radSchedulerDemo.SchedulerElement.ViewElement, TimelineGroupingByResourcesElement)

			If dayView Is Nothing AndAlso monthView Is Nothing AndAlso timelineElement Is Nothing Then
				Return
			End If

			Dim headerHeight As Integer = 135

			If dayView IsNot Nothing Then
				dayView.ResourceHeaderHeight = headerHeight
				dayView.InvalidateMeasure(True)
			ElseIf monthView IsNot Nothing Then
				monthView.ResourceHeaderHeight = headerHeight
			ElseIf timelineElement IsNot Nothing Then
				timelineElement.ResourceHeaderWidth = headerHeight
			End If

			Me.radSchedulerDemo.PerformLayout()
		End Sub

		Private Sub radButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.radSchedulerDemo.GetDayView().DayCount = 1
			Me.radSchedulerDemo.GetDayView().StartDate = Me.radSchedulerDemo.GetDayView().StartDate.AddDays(1)
		End Sub
	End Class
End Namespace