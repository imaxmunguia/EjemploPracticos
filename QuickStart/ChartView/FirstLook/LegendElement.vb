Imports System
Imports Telerik.WinControls.UI
Imports System.Windows.Forms
Imports System.Drawing
Imports Telerik.WinControls
Imports Telerik.Charting

Namespace Telerik.Examples.WinControls.ChartView.FirstLook
	Public Class LegendElement
		Inherits LightVisualElement
		Private layout As StackLayoutElement

		Protected Overrides Sub InitializeFields()
			MyBase.InitializeFields()

			Me.Alignment = ContentAlignment.MiddleCenter
			Me.DrawFill = True
			Me.BackColor = Color.White
			Me.GradientStyle = GradientStyles.Solid
			Me.Padding = New Padding(5, 5, 5, 0)
			Me.Margin = New Padding(0)
			Me.MinSize = New Size(100, 0)
			Me.StretchVertically = False
			Me.StretchHorizontally = True
			Me.ShouldHandleMouseInput = False
			Me.NotifyParentOnMouseInput = True
		End Sub

		Protected Overrides Sub CreateChildElements()
			MyBase.CreateChildElements()

			layout = New StackLayoutElement()
			layout.Orientation = Orientation.Vertical
			layout.FitInAvailableSize = True
			layout.StretchVertically = True
			layout.StretchHorizontally = True
			Me.Children.Add(layout)
		End Sub

		Public Sub BuildLegend(ByVal element As RadChartElement)
			Dim view As Telerik.WinControls.UI.ChartView = element.View
			BuildLegendCore(view)
		End Sub

		Private Sub BuildLegendCore(ByVal view As Telerik.WinControls.UI.ChartView)
			layout.Children.Clear()
			If view.AreaType = ChartAreaType.Cartesian Then
				For Each series As Telerik.WinControls.UI.ChartSeries In view.Series
					Dim color As Color
					If TypeOf series Is LineSeries Then
						color = series.BorderColor
					Else
						color = series.Children(0).BackColor
					End If
					layout.Children.Add(New LegendItemElement(series.Name, color))
				Next series
			End If
			If view.AreaType = ChartAreaType.Pie AndAlso view.Series.Count > 0 Then
				For i As Integer = 0 To view.Series(0).DataPoints.Count - 1
					Dim color As Color = view.Series(0).Children(i).BackColor
					Dim point As PieDataPoint = TryCast(view.Series(0).DataPoints(i), PieDataPoint)
					layout.Children.Add(New LegendItemElement(point.Name, color))
				Next i
			End If
		End Sub

		Protected Overrides Function MeasureOverride(ByVal availableSize As SizeF) As SizeF
			Dim size As SizeF = MyBase.MeasureOverride(availableSize)
			Return size
		End Function
	End Class
End Namespace
