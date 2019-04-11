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

Namespace Telerik.Examples.WinControls.Chart.SplineAreas
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()

			radChart1.Series.Clear()

			Dim cs1 As New ChartSeries()

			cs1.Items.Add(New ChartSeriesItem(0, 3))
			cs1.Items.Add(New ChartSeriesItem(1, 3))
			cs1.Items.Add(New ChartSeriesItem(2, 4))
			cs1.Items.Add(New ChartSeriesItem(3, 3))
			cs1.Items.Add(New ChartSeriesItem(4, 8))
			cs1.Type = ChartSeriesType.SplineArea
			radChart1.Series.Add(cs1)

			Dim cs2 As New ChartSeries()

			cs2.Items.Add(New ChartSeriesItem(0, 3))
			cs2.Items.Add(New ChartSeriesItem(1, 2))
			cs2.Items.Add(New ChartSeriesItem(2, 4))
			cs2.Items.Add(New ChartSeriesItem(3, 3))
			cs2.Items.Add(New ChartSeriesItem(4, 7))
			cs2.Type = ChartSeriesType.SplineArea
			radChart1.Series.Add(cs2)

			radChart1.PlotArea.XAxis.LayoutMode = Telerik.Charting.Styles.ChartAxisLayoutMode.Normal
			radChart1.PlotArea.XAxis.AutoScale = False
			radChart1.PlotArea.XAxis.MaxValue = 4
			radChart1.PlotArea.XAxis.MinValue = 0
			radChart1.PlotArea.XAxis.Step = 1
			radChart1.Update()

			Me.EnabledQSFButtons = QSFButtons.None
		End Sub
	End Class
End Namespace