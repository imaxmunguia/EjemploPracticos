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

Namespace Telerik.Examples.WinControls.Chart.CandlestickCharts
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()

			radChart1.Series.Clear()

			Dim cs As New ChartSeries()

			Dim csi As New ChartSeriesItem()
			csi.XValue = 0
			csi.YValue = 3
			csi.YValue2 = 4.5
			csi.YValue3 = 1
			csi.YValue4 = 6
			cs.Items.Add(csi)

			Dim csi2 As New ChartSeriesItem()
			csi2.XValue = 1
			csi2.YValue = 5
			csi2.YValue2 = 4
			csi2.YValue3 = 2
			csi2.YValue4 = 8
			cs.Items.Add(csi2)

			Dim csi3 As New ChartSeriesItem()
			csi3.XValue = 2
			csi3.YValue = 5.5
			csi3.YValue2 = 5
			csi3.YValue3 = 3
			csi3.YValue4 = 6
			cs.Items.Add(csi3)

			Dim csi4 As New ChartSeriesItem()
			csi4.XValue = 3
			csi4.YValue = 5
			csi4.YValue2 = 4
			csi4.YValue3 = 3
			csi4.YValue4 = 7
			cs.Items.Add(csi4)

			Dim csi5 As New ChartSeriesItem()
			csi5.XValue = 4
			csi5.YValue = 5
			csi5.YValue2 = 6
			csi5.YValue3 = 4
			csi5.YValue4 = 6.5
			cs.Items.Add(csi5)

			cs.Type = ChartSeriesType.CandleStick
			cs.Appearance.LabelAppearance.Visible = False
			radChart1.Series.Add(cs)

			radChart1.PlotArea.XAxis.AutoScale = False
			radChart1.PlotArea.XAxis.MaxValue = 4
			radChart1.PlotArea.XAxis.MinValue = 0
			radChart1.PlotArea.XAxis.Step = 1

			radChart1.Update()
			Me.EnabledQSFButtons = QSFButtons.None
		End Sub
	End Class
End Namespace