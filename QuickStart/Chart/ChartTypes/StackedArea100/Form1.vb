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

Namespace Telerik.Examples.WinControls.Chart.ChartTypes.StackedArea100
	Partial Public Class Form1
		Inherits ExamplesForm
		Private rand As New Random()
		Public Sub New()
			InitializeComponent()

			radChart1.Series.Clear()

			Dim cs As New ChartSeries()
			cs.Items.Add(New ChartSeriesItem(11))
			cs.Items.Add(New ChartSeriesItem(13))
			cs.Items.Add(New ChartSeriesItem(20))
			cs.Items.Add(New ChartSeriesItem(21))
			cs.Items.Add(New ChartSeriesItem(18))
			cs.Items.Add(New ChartSeriesItem(16))
			cs.Items.Add(New ChartSeriesItem(19))
			cs.Items.Add(New ChartSeriesItem(21))
			cs.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.White
			cs.Type = ChartSeriesType.StackedArea100
			radChart1.Series.Add(cs)

			Dim cs1 As New ChartSeries()
			cs1.Items.Add(New ChartSeriesItem(13))
			cs1.Items.Add(New ChartSeriesItem(12))
			cs1.Items.Add(New ChartSeriesItem(16))
			cs1.Items.Add(New ChartSeriesItem(14))
			cs1.Items.Add(New ChartSeriesItem(21))
			cs1.Items.Add(New ChartSeriesItem(25))
			cs1.Items.Add(New ChartSeriesItem(24))
			cs1.Items.Add(New ChartSeriesItem(22))
			cs1.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.White
			cs1.Type = ChartSeriesType.StackedArea100
			radChart1.Series.Add(cs1)
			radChart1.Update()

			Me.EnabledQSFButtons = QSFButtons.None
		End Sub
	End Class
End Namespace