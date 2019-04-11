Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.Charting
Imports Telerik.QuickStart.WinControls

Namespace Telerik.Examples.WinControls.Chart.ChartTypes.Point
	''' <summary>
	''' ChartType Point Example
	''' </summary>
	Partial Public Class Form1
		Inherits ExamplesForm
		Private rand As System.Random = New Random()
		Public Sub New()
			InitializeComponent()

			radChart1.PlotArea.YAxis.AxisMode = Telerik.Charting.ChartYAxisMode.Extended

			'construct a new series and add items with random data to it
			Dim series As ChartSeries = radChart1.CreateSeries("point", Color.Blue,Color.LightBlue, ChartSeriesType.Point)
			series.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.White
			For i As Integer = 0 To 5
				Dim item As New ChartSeriesItem()
				item.YValue = rand.Next(1,10)
				item.XValue = i

				series.Items.Add(item)
			Next i

			radChart1.Series.Clear()
			'add series to the chart
			radChart1.Series.Add(series)

			radChart1.SkinsOverrideStyles = True
			radChart1.Skin = "Apple"
			radChart1.ChartTitle.TextBlock.Text = "Point"

			Me.EnabledQSFButtons = QSFButtons.None
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

		End Sub
	End Class
End Namespace