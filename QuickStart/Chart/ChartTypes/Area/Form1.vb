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

Namespace Telerik.Examples.WinControls.Chart.ChartTypes.Area
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()

			radChart1.Series.Clear()

			Dim cs As New ChartSeries()
			cs.Items.Add(New ChartSeriesItem(1))
			cs.Items.Add(New ChartSeriesItem(3))
			cs.Items.Add(New ChartSeriesItem(4))
			cs.Items.Add(New ChartSeriesItem(3))
			cs.Items.Add(New ChartSeriesItem(5))
			cs.Items.Add(New ChartSeriesItem(7))
			cs.Items.Add(New ChartSeriesItem(7))
			cs.Items.Add(New ChartSeriesItem(8))
			cs.Items.Add(New ChartSeriesItem(10))
			cs.Items.Add(New ChartSeriesItem(12))
			cs.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.White
			cs.Type = ChartSeriesType.Area
			radChart1.Series.Add(cs)

			Dim cs1 As New ChartSeries()
			cs1.Items.Add(New ChartSeriesItem(0))
			cs1.Items.Add(New ChartSeriesItem(1))
			cs1.Items.Add(New ChartSeriesItem(2))
			cs1.Items.Add(New ChartSeriesItem(2))
			cs1.Items.Add(New ChartSeriesItem(1))
			cs1.Items.Add(New ChartSeriesItem(5))
			cs1.Items.Add(New ChartSeriesItem(4))
			cs1.Items.Add(New ChartSeriesItem(7))
			cs1.Items.Add(New ChartSeriesItem(11))
			cs1.Items.Add(New ChartSeriesItem(9))
			cs1.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.White
			cs1.Type = ChartSeriesType.Area
			radChart1.Series.Add(cs1)

			radChart1.Update()

			Me.EnabledQSFButtons = QSFButtons.None
		End Sub

	End Class
End Namespace