Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.Charting
Imports Telerik.QuickStart.WinControls
Imports Telerik.Charting.Styles

Namespace Telerik.Examples.WinControls.Chart.Functionality.NumericalAxis
	''' <summary>
	''' Form demonstrating RadChart's capabilities. Example name: Numerical Axis
	''' </summary>
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()

			Me.EnabledQSFButtons = QSFButtons.None
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			Const hourStep As Double = 1 / 24.0
			'const double minuteStep = hourStep / 60;
			Const fiveMinuteStep As Double = hourStep / 12

			Dim startTime As Double = New DateTime(2008, 1, 1, 8, 0, 0, 0).ToOADate()
			Dim endTime As Double = New DateTime(2008, 1, 1, 17, 0, 0, 0).ToOADate()

			radChart1.PlotArea.XAxis.AddRange(startTime, endTime, hourStep)

			Dim r As New Random()

			Dim series As ChartSeries = radChart1.Series(0)
			series.Items.Clear()


			For currentTime As Double = startTime To endTime - 1 Step fiveMinuteStep
				Dim item As New ChartSeriesItem()
				item.XValue = currentTime + (r.NextDouble() - 0.5) * fiveMinuteStep
				item.YValue = 7065 + (r.NextDouble() - 0.5) * 90
				series.Items.Add(item)
			Next currentTime

			radChart1.Series.Add(series)
		End Sub
	End Class
End Namespace