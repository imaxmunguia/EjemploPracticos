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

Namespace Telerik.Examples.WinControls.Chart.IntelligentLabels
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()

			radChart1.Series.Clear()

			Dim cs As New ChartSeries()

			cs.Items.Add(New ChartSeriesItem(3))
			cs.Items.Add(New ChartSeriesItem(6))
			cs.Items.Add(New ChartSeriesItem(4))
			cs.Items.Add(New ChartSeriesItem(3))
			cs.Items.Add(New ChartSeriesItem(8))
			cs.Type = ChartSeriesType.SplineArea
			cs.Appearance.TextAppearance.TextProperties.Font = New Font("Arial", 9, FontStyle.Bold, GraphicsUnit.Point)
			Dim cs1 As New ChartSeries()

			cs1.Items.Add(New ChartSeriesItem(3.1))
			cs1.Items.Add(New ChartSeriesItem(6.1))
			cs1.Items.Add(New ChartSeriesItem(4.1))
			cs1.Items.Add(New ChartSeriesItem(3.1))
			cs1.Items.Add(New ChartSeriesItem(8.1))
			cs1.Type = ChartSeriesType.SplineArea
			cs1.Appearance.TextAppearance.TextProperties.Font = New Font("Arial", 9, FontStyle.Bold, GraphicsUnit.Point)
			Dim cs2 As New ChartSeries()

			cs2.Items.Add(New ChartSeriesItem(3.2))
			cs2.Items.Add(New ChartSeriesItem(6.2))
			cs2.Items.Add(New ChartSeriesItem(4.2))
			cs2.Items.Add(New ChartSeriesItem(3.2))
			cs2.Items.Add(New ChartSeriesItem(8.2))
			cs2.Type = ChartSeriesType.SplineArea
			cs2.Appearance.TextAppearance.TextProperties.Font = New Font("Arial", 9, FontStyle.Bold, GraphicsUnit.Point)

			radChart1.Series.Add(cs2)
			radChart1.Series.Add(cs1)
			radChart1.Series.Add(cs)

			radChart1.PlotArea.XAxis.LayoutMode = Global.Telerik.Charting.Styles.ChartAxisLayoutMode.Normal
			radChart1.PlotArea.XAxis.AutoScale = False
			radChart1.PlotArea.XAxis.MaxValue = 4
			radChart1.PlotArea.XAxis.MinValue = 0
			radChart1.PlotArea.XAxis.Step = 1
			radChart1.IntelligentLabelsEnabled = True

			radChart1.Update()

			Me.EnabledQSFButtons = QSFButtons.None
		End Sub
	End Class
End Namespace