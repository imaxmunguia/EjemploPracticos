Imports System
Imports Telerik.Charting
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Tests
Imports System.Collections.Generic
Imports System.Drawing

Namespace Telerik.Examples.WinControls.ChartView.Scatter
	''' <summary>
	''' RadChartView example
	''' </summary>
	Partial Public Class Form1
		Inherits ExamplesForm
		Private customShape As CustomShape
		Private shapedForm As New ShapedForm()

		Public Sub New()
			InitializeComponent()

			Me.SelectedControl = Me.radChartView1

            Dim area As CartesianArea = Me.radChartView1.GetArea(Of CartesianArea)()
            area.ShowGrid = True
            Dim grid As CartesianGrid = area.GetGrid(Of CartesianGrid)()
            grid.DrawHorizontalStripes = True
            grid.DrawVerticalStripes = True

			InitializeChartAxes()

			Me.SetEnabledQsfbButton(QSFButtons.ChangeTheme, False)
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			Dim model As New RealEstateViewModel()

			Dim axes() As LinearAxis = Me.radChartView1.Axes.Get(Of LinearAxis)()

			For i As Integer = 0 To 1
				Dim series As New ScatterSeries()
				series.HorizontalAxis = axes(0)
				series.VerticalAxis = axes(1)

				series.DataSource = model.GetData(i)
				series.XValueMember = "SquareFeet"
				series.YValueMember = "PricePerSqFeet"
                series.PointSize = New SizeF(6.0F, 6.0F)
				Me.radChartView1.Series.Add(series)
			Next i

			Me.Initialize()
		End Sub

		Private Function CreateInitialShape(ByVal vertices As Integer, ByVal radius1 As Double, ByVal radius2 As Double) As List(Of PointF)
			Dim pts As New List(Of PointF)()

			If radius1 = 0 Then
				Return Nothing
			End If

			If radius2 = 0 Then
				Return Nothing
			End If

			For i As Integer = 0 To vertices - 1
				Dim angle1 As Double = ((4.0 * i - vertices) * Math.PI) / (2.0f * vertices)
				Dim angle2 As Double = ((4.0 * i - vertices + 2) * Math.PI) / (2.0f * vertices)
				pts.Add(New PointF(CSng(Math.Cos(angle1) * radius1), CSng(Math.Sin(angle1) * radius1)))
				pts.Add(New PointF(CSng(Math.Cos(angle2) * radius2), CSng(Math.Sin(angle2) * radius2)))
			Next i
			Return pts
		End Function

		Private Sub Initialize()
			Me.customShape = New CustomShape()
			Me.customShape.CreateClosedShape(CreateInitialShape(5, 100, 60))

			Dim item As New RadListDataItem("CustomShape")
			item.Value = GetType(CustomShape)
			Me.radDropDownListShapes.Items.Add(item)
			item = New RadListDataItem("RoundRectShape")
			item.Value = GetType(RoundRectShape)
			Me.radDropDownListShapes.Items.Add(item)
			item = New RadListDataItem("EllipseShape")
			item.Value = GetType(EllipseShape)
			Me.radDropDownListShapes.Items.Add(item)
			item = New RadListDataItem("DonutShape")
			item.Value = GetType(DonutShape)
			Me.radDropDownListShapes.Items.Add(item)
			Me.radDropDownListShapes.SelectedIndex = 0

			AddHandler radDropDownListShapes.SelectedIndexChanged, AddressOf radDropDownListShapes_SelectedIndexChanged
			AddHandler radDropDownListSeries.SelectedIndexChanged, AddressOf radDropDownListSeries_SelectedIndexChanged
            AddHandler radSpinEditorPointRadius.ValueChanged, AddressOf radSpinEditor1_ValueChanged

			For i As Integer = 0 To Me.radChartView1.Series.Count - 1
				item = New RadListDataItem("Series " & (i + 1))
				item.Value = Me.radChartView1.Series(i)
				Me.radDropDownListSeries.Items.Add(item)
			Next i

			Me.radDropDownListSeries.SelectedIndex = 0
			Me.radDropDownListShapes.SelectedIndex = 2

			Me.radSpinEditorPointRadius.Value = CDec(Me.radChartView1.Series(0).PointSize.Width)
		End Sub

		Private Sub InitializeChartAxes()
			Dim area As CartesianArea = Me.radChartView1.GetArea(Of CartesianArea)()

			Dim horizontalAxis As New LinearAxis()
			horizontalAxis.LabelFitMode = AxisLabelFitMode.MultiLine
			horizontalAxis.Title = "Property Area (sq.ft.)"
			horizontalAxis.Minimum = 450
			horizontalAxis.Maximum = 2550
			horizontalAxis.MajorStep = 150
			area.Axes.Add(horizontalAxis)

			Dim verticalAxis As New LinearAxis()
			verticalAxis.AxisType = AxisType.Second
			verticalAxis.Title = "Price (USD) per sq. ft."
			verticalAxis.Minimum = 1
			verticalAxis.Maximum = 9
			area.Axes.Add(verticalAxis)
		End Sub

		Private Sub ApplyShapeToPoints(ByVal shape As ElementShape)
			Dim series As ScatterSeries = TryCast(Me.radDropDownListSeries.SelectedValue, ScatterSeries)

			For Each point As ScatterPointElement In series.Children
				point.Shape = shape
			Next point
		End Sub

        Private Sub radButtonEditShape_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButtonEditShape.Click
            If Me.radDropDownListShapes.SelectedIndex = 0 Then
                Dim editor As New CustomShapeEditorForm()
                Me.customShape = editor.EditShape(Me.customShape)
                Me.ApplyShapeToPoints(Me.customShape)
            End If
        End Sub

        Private Sub radSpinEditor1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim series As ScatterSeries = TryCast(Me.radDropDownListSeries.SelectedValue, ScatterSeries)

            series.PointSize = New SizeF(CSng(Me.radSpinEditorPointRadius.Value), CSng(Me.radSpinEditorPointRadius.Value))
        End Sub

		Private Sub radDropDownListSeries_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
			Dim series As ScatterSeries = TryCast(Me.radDropDownListSeries.SelectedValue, ScatterSeries)
			Dim point As ScatterPointElement = TryCast(series.Children(0), ScatterPointElement)
			Me.radSpinEditorPointRadius.Value = CDec(series.PointSize.Width)

			Dim shapeType As Type

			If point.Shape Is Nothing Then
				shapeType = GetType(EllipseShape)
			Else
				shapeType = point.Shape.GetType()
			End If

			Me.radDropDownListShapes.SelectedValue = shapeType
			Me.radGroupBox1.HeaderText = Me.radDropDownListSeries.SelectedItem.Text & " Settings"
		End Sub

		Private Sub radDropDownListShapes_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
			Select Case Me.radDropDownListShapes.SelectedIndex
				Case 0
					Me.ApplyShapeToPoints(Me.customShape)
					Me.radButtonEditShape.Enabled = True
				Case 1
					Me.ApplyShapeToPoints(New RoundRectShape(2))
					Me.radButtonEditShape.Enabled = False
				Case 2
					Me.ApplyShapeToPoints(New EllipseShape())
					Me.radButtonEditShape.Enabled = False
				Case 3
					Me.ApplyShapeToPoints(New DonutShape())
					Me.radButtonEditShape.Enabled = False
				Case 4
					Me.ApplyShapeToPoints(New TabOffice12Shape())
					Me.radButtonEditShape.Enabled = False
				Case 5
					Me.ApplyShapeToPoints(New TabVsShape())
					Me.radButtonEditShape.Enabled = False
			End Select
		End Sub
	End Class
End Namespace

