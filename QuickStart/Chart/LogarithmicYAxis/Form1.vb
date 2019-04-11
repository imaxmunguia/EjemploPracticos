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

Namespace Telerik.Examples.WinControls.Chart.LogarithmicYAxis
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()

			radChart1.Series.Clear()

			Dim cs As New ChartSeries()
			cs.Items.Add(New ChartSeriesItem(5))
			cs.Items.Add(New ChartSeriesItem(50))
			cs.Items.Add(New ChartSeriesItem(500))
			cs.Items.Add(New ChartSeriesItem(5000))

			radChart1.PlotArea.YAxis.IsLogarithmic = True

			radChart1.Series.Add(cs)

			radChart1.Update()
			Me.EnabledQSFButtons = QSFButtons.None
		End Sub
	End Class
End Namespace