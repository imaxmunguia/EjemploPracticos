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

Namespace Telerik.Examples.WinControls.Chart.ChartTypes.StackedArea
	Partial Public Class Form1
		Inherits ExamplesForm
		Private rand As New Random()
		Public Sub New()
			InitializeComponent()

			radChart1.ChartTitle.TextBlock.Text = "Stacked Area"

			radChart1.Series.Clear()

			Dim cs As New ChartSeries()
			cs.Items.Add(New ChartSeriesItem(1))
			cs.Items.Add(New ChartSeriesItem(3))
			cs.Items.Add(New ChartSeriesItem(3))
			cs.Items.Add(New ChartSeriesItem(4))
			cs.Items.Add(New ChartSeriesItem(7))
			cs.Items.Add(New ChartSeriesItem(4))
			cs.Items.Add(New ChartSeriesItem(5))
			cs.Items.Add(New ChartSeriesItem(5))
			cs.Type = ChartSeriesType.StackedArea
			radChart1.Series.Add(cs)

			Dim cs1 As New ChartSeries()
			cs1.Items.Add(New ChartSeriesItem(3))
			cs1.Items.Add(New ChartSeriesItem(2))
			cs1.Items.Add(New ChartSeriesItem(6))
			cs1.Items.Add(New ChartSeriesItem(4))
			cs1.Items.Add(New ChartSeriesItem(6))
			cs1.Items.Add(New ChartSeriesItem(5))
			cs1.Items.Add(New ChartSeriesItem(4))
			cs1.Items.Add(New ChartSeriesItem(5))
			cs1.Type = ChartSeriesType.StackedArea
			radChart1.Series.Add(cs1)
			radChart1.Update()

			Me.EnabledQSFButtons = QSFButtons.None
		End Sub
	End Class
End Namespace