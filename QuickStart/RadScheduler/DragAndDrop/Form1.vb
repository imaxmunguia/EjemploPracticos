Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.RadScheduler.DragAndDrop
	Partial Public Class Form1
		Inherits ExamplesForm
		Private Enum AppointmentFields
			Row
			Summary
			Location
			Description
			Start
			[End]
			Background
			Status
		End Enum

		#Region "private classes"
		Private Class DragObject
			Private status_Renamed As AppointmentFields
			Private values_Renamed As Dictionary(Of AppointmentFields, Object) = New Dictionary(Of AppointmentFields, Object)()

			Public Property Status() As AppointmentFields
				Get
					Return Me.status_Renamed
				End Get
				Set(ByVal value As AppointmentFields)
					Me.status_Renamed = value
				End Set
			End Property

			Public ReadOnly Property Values() As Dictionary(Of AppointmentFields, Object)
				Get
					Return Me.values_Renamed
				End Get
			End Property
		End Class

		Private Class MyGridBehavior
			Inherits BaseGridBehavior
			Private mouseDownPoint As Point = Point.Empty

			Public Overrides Function OnMouseDown(ByVal e As MouseEventArgs) As Boolean
				If e.Button = MouseButtons.Left Then
					mouseDownPoint = e.Location
				End If

				Return MyBase.OnMouseDown(e)
			End Function

			Public Overrides Function OnMouseMove(ByVal e As MouseEventArgs) As Boolean
				If e.Button <> MouseButtons.Left Then
					Me.mouseDownPoint = Point.Empty
					Return MyBase.OnMouseMove(e)
				End If

				If (Not Me.GridViewElement.IsInEditMode) AndAlso Me.ShouldBeginDrag(Me.mouseDownPoint, e.Location) Then
					Dim element As RadElement = Me.GridControl.ElementTree.GetElementAtPoint(e.Location)

					Dim cell As GridCellElement = TryCast(element, GridCellElement)

					If cell IsNot Nothing AndAlso cell Is Me.GridViewElement.CurrentCell Then
						Dim dragObject As New DragObject()

						dragObject.Values.Add(AppointmentFields.Summary, cell.RowInfo.Cells("Summary").Value)
						dragObject.Values.Add(AppointmentFields.Start, cell.RowInfo.Cells("Start").Value)
						dragObject.Values.Add(AppointmentFields.End, cell.RowInfo.Cells("End").Value)
						dragObject.Values.Add(AppointmentFields.Description, cell.RowInfo.Cells("Description").Value)
						dragObject.Values.Add(AppointmentFields.Background, cell.RowInfo.Cells("BackgroundID").Value)
						dragObject.Values.Add(AppointmentFields.Status, cell.RowInfo.Cells("StatusID").Value)
						dragObject.Values.Add(AppointmentFields.Location, cell.RowInfo.Cells("Location").Value)

						dragObject.Status = AppointmentFields.Row

						Me.GridViewElement.ElementTree.Control.DoDragDrop(dragObject, DragDropEffects.Copy)
						Return True
					End If
				End If

				Return MyBase.OnMouseMove(e)
			End Function


			Private Function ShouldBeginDrag(ByVal current As Point, ByVal capture As Point) As Boolean
				Dim dragSize As Size = SystemInformation.DragSize
				Dim dragRect As New Rectangle(capture.X - dragSize.Width / 2, capture.Y - dragSize.Height / 2, dragSize.Width, dragSize.Height)
				Return Not dragRect.Contains(current)
			End Function
		End Class
		#End Region

		#Region "Fields"
		Private mouseDownPosition As Point
		Private isDragging As Boolean
		#End Region

		Public Sub New()
			InitializeComponent()
		End Sub

		Protected Overrides Function GetExampleDefaultTheme() As String
			Return ""
		End Function

		Private Sub InitListBoxStyle()
			Me.radListBox1.Font = Me.radGridView1.RootElement.FindDescendant(Of GridDataCellElement)().Font

			Me.radListBox1.RootElement.InvalidateMeasure()
			Me.radListBox1.RootElement.UpdateLayout()
		End Sub

		Private Sub radGridView1_CellBeginEdit(ByVal sender As Object, ByVal e As GridViewCellCancelEventArgs)
			Dim radeditor As RadDateTimeEditor = TryCast(Me.radGridView1.ActiveEditor, RadDateTimeEditor)
			If radeditor IsNot Nothing Then
				radeditor.CustomFormat = "F"
			End If
		End Sub

		Private Sub radGridView1_CellValidating(ByVal sender As Object, ByVal e As CellValidatingEventArgs)
			Dim column As GridViewDataColumn = CType(e.Column, GridViewDataColumn)

			If column IsNot Nothing AndAlso column.Name = "End" Then
				Dim [date] As DateTime = CDate(e.Row.Cells("Start").Value)
				Dim newDate As DateTime = CDate(e.Value)

				If newDate < [date] Then
					e.Cancel = True
				End If
			End If
		End Sub

		#Region "Events"
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            Me.radSchedulerNavigator1.AssociatedScheduler = Me.radScheduler1

            FillDataTableByEnum(Me.schedulerDragAndDropDataDataSet.AppointmentStatuses, GetType(AppointmentStatus))

			FillDataTableByEnum(Me.schedulerDragAndDropDataDataSet.AppointmentBackgrounds, GetType(AppointmentBackground))

			Me.radGridView1.GridBehavior = New MyGridBehavior()
			Me.radGridView1.CloseEditorWhenValidationFails = False
			AddHandler radGridView1.CellValidating, AddressOf radGridView1_CellValidating
			AddHandler radGridView1.CellBeginEdit, AddressOf radGridView1_CellBeginEdit

			AddHandler radListBox1.MouseMove, AddressOf radListBox1_MouseMove
			AddHandler radListBox1.MouseUp, AddressOf radListBox1_MouseUp

			Me.radScheduler1.ActiveView.StartDate = New DateTime(2010, 1, 25)

			Me.radSchedulerNavigator1.TimelineViewButtonVisible = False
			Me.radSchedulerNavigator1.MonthViewButtonVisible = False

			Me.appointmentsTableAdapter.Fill(Me.schedulerDragAndDropDataDataSet.Appointments)
			Me.radGridView1.MasterTemplate.BestFitColumns()

			InitListBoxStyle()
		End Sub

		Private Sub radScheduler1_DragDrop(ByVal sender As Object, ByVal e As DragEventArgs) Handles radScheduler1.DragDrop
			Dim point As Point = Me.radScheduler1.PointToClient(New Point(e.X, e.Y))

			Dim table As DayViewAppointmentsTable = (TryCast(Me.radScheduler1.SchedulerElement.ViewElement, SchedulerDayViewElement)).DataAreaElement.Table
			Dim schedulerCell As SchedulerCellElement = SchedulerUIHelper.GetCellAtPoint(point, table.Children)
			If schedulerCell Is Nothing Then
				Dim allDay As DayViewAllDayHeader = (TryCast(Me.radScheduler1.SchedulerElement.ViewElement, SchedulerDayViewElement)).AllDayHeaderElement
				schedulerCell = SchedulerUIHelper.GetCellAtPoint(point, allDay.Children)
			End If

			If schedulerCell Is Nothing Then
				Return
			End If

			Dim dragObject As DragObject = TryCast(e.Data.GetData(GetType(DragObject)), DragObject)
			If dragObject IsNot Nothing Then
				Me.radScheduler1.Appointments.BeginUpdate()
				Dim appointment As Appointment = CreateAppointment(schedulerCell.Date, dragObject)
				Me.radScheduler1.Appointments.Add(appointment)
				Me.radScheduler1.Appointments.EndUpdate()
			End If
		End Sub

		Private Sub radScheduler1_DragEnter(ByVal sender As Object, ByVal e As DragEventArgs) Handles radScheduler1.DragEnter
			Dim dragObject As DragObject = TryCast(e.Data.GetData(GetType(DragObject)), DragObject)

			e.Effect = If(dragObject Is Nothing, DragDropEffects.None, DragDropEffects.Copy)
		End Sub

		Private Sub radListBox1_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
			Me.mouseDownPosition = Point.Empty
			Me.isDragging = False
		End Sub

		Private Sub radListBox1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
			If e.Button <> MouseButtons.Left Then
				Return
			End If

			If Me.isDragging Then
				Return
			End If

			Dim currentPosition As Point = e.Location
			If (Math.Abs(currentPosition.X - Me.mouseDownPosition.X) >= SystemInformation.DragSize.Width) OrElse (Math.Abs(currentPosition.Y - Me.mouseDownPosition.Y) >= SystemInformation.DragSize.Height) Then
				Me.isDragging = True
				Dim dragObject As New DragObject()
				Dim item As RadListVisualItem = TryCast(Me.radListBox1.ElementTree.GetElementAtPoint(e.Location), RadListVisualItem)

				If item IsNot Nothing Then
					dragObject.Values.Add(AppointmentFields.Summary, item.Text)
					dragObject.Status = AppointmentFields.Summary

					TryCast(sender, RadListControl).DoDragDrop(dragObject, DragDropEffects.Copy)
				End If
			End If
		End Sub

		Private Sub radListBox1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles radListBox1.MouseDown
			Me.mouseDownPosition = e.Location
			MyBase.OnMouseDown(e)
		End Sub
		#End Region

		#Region "Methods"
		Private Sub FillDataTableByEnum(ByVal dt As DataTable, ByVal enumType As Type)
			Dim lstNames As List(Of String) = New List(Of String)(System.Enum.GetNames(enumType))
			Dim arrlstValues As New ArrayList(System.Enum.GetValues(enumType))

			For i As Integer = 0 To lstNames.Count - 1
				dt.Rows.Add(New Object() { arrlstValues(i), lstNames(i) })
			Next i
		End Sub

		Private Function CreateAppointment(ByVal currentDate As DateTime, ByVal dragObject As DragObject) As Appointment
			Dim appointment As New Appointment()
			Dim startDate As DateTime = currentDate
			Dim endDate As DateTime = currentDate.AddHours(1)
			Select Case dragObject.Status
				Case AppointmentFields.Summary
					appointment.Summary = TryCast(dragObject.Values(dragObject.Status), String)
				Case AppointmentFields.Row
					appointment.Summary = TryCast(dragObject.Values(AppointmentFields.Summary), String)
					appointment.Description = TryCast(dragObject.Values(AppointmentFields.Description), String)
					appointment.BackgroundId = CInt(Fix(dragObject.Values(AppointmentFields.Background)))
					appointment.StatusId = CInt(Fix(dragObject.Values(AppointmentFields.Status)))
					appointment.Location = TryCast(dragObject.Values(AppointmentFields.Location), String)

					startDate = CDate(dragObject.Values(AppointmentFields.Start))
					endDate = CDate(dragObject.Values(AppointmentFields.End))
					If Me.radRadioButtonAnywhere.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
						Dim range As TimeSpan = endDate.Subtract(startDate)
						endDate = currentDate.Add(range)
						startDate = currentDate
					End If
			End Select
			appointment.Start = startDate
			appointment.End = endDate
			Return appointment
		End Function
		#End Region
	End Class
End Namespace
