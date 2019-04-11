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

Namespace Telerik.Examples.WinControls.Chart.EmptyValues
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()

			radChart1.Series.Clear()
			radChart1.Skin = "LightBlue"
			Dim cs As New ChartSeries()
			cs.Items.Add(New ChartSeriesItem(0,3))

			Dim csi As New ChartSeriesItem(1, 6)
			cs.Items.Add(csi)

			Dim csi1 As New ChartSeriesItem(2, 4)
			csi1.Empty = True
			cs.Items.Add(csi1)

			cs.Items.Add(New ChartSeriesItem(3, 3))
			cs.Items.Add(New ChartSeriesItem(4, 8))
			cs.Type = ChartSeriesType.SplineArea


			radChart1.Series.Add(cs)

			radChart1.PlotArea.XAxis.LayoutMode = Global.Telerik.Charting.Styles.ChartAxisLayoutMode.Normal
			radChart1.PlotArea.XAxis.AutoScale = False
			radChart1.PlotArea.XAxis.MaxValue = 4
			radChart1.PlotArea.XAxis.MinValue = 0
			radChart1.PlotArea.XAxis.Step = 1

			cs.Appearance.Border.Width = 5
			radChart1.Update()

			Me.EnabledQSFButtons = QSFButtons.None

		End Sub
	End Class
End Namespace