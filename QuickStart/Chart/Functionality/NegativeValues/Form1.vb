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

Namespace Telerik.Examples.WinControls.Chart.Functionality.NegativeValues
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()

			radChart1.Series.Clear()

			'initialize the two series to be displayed in the chart
			Dim cs As New ChartSeries()
			cs.Items.Add(New ChartSeriesItem(-1))
			cs.Items.Add(New ChartSeriesItem(4))
			cs.Items.Add(New ChartSeriesItem(2))
			cs.Items.Add(New ChartSeriesItem(-3))
			cs.Items.Add(New ChartSeriesItem(-2))
			cs.Items.Add(New ChartSeriesItem(0))
			cs.Items.Add(New ChartSeriesItem(2))

			cs.Type = ChartSeriesType.Bar

			radChart1.Series.Add(cs)
			radChart1.Update()

			Me.EnabledQSFButtons = QSFButtons.None
		End Sub
	End Class
End Namespace