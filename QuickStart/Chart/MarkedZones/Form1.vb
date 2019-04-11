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

Namespace Telerik.Examples.WinControls.Chart.MarkedZones
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()

			radChart1.Series.Clear()

			'adding the series items
			Dim cs As New ChartSeries()

			cs.Items.Add(New ChartSeriesItem(3))
			cs.Items.Add(New ChartSeriesItem(6))
			cs.Items.Add(New ChartSeriesItem(4))
			cs.Items.Add(New ChartSeriesItem(3))
			cs.Items.Add(New ChartSeriesItem(8))

			radChart1.Series.Add(cs)

			'adding the colored zones
			Dim zone1 As New ChartMarkedZone()
			zone1.ValueStartY = 0
			zone1.ValueEndY = 3
			zone1.Appearance.FillStyle.MainColor = Color.LightGreen
			radChart1.PlotArea.MarkedZones.Add(zone1)

			Dim zone2 As New ChartMarkedZone()
			zone2.ValueStartY = 3
			zone2.ValueEndY = 6
			zone2.Appearance.FillStyle.MainColor = Color.LightYellow
			radChart1.PlotArea.MarkedZones.Add(zone2)

			Dim zone3 As New ChartMarkedZone()
			zone3.ValueStartY = 6
			zone3.ValueEndY = 8
			zone3.Appearance.FillStyle.MainColor = Color.PaleVioletRed

			radChart1.PlotArea.MarkedZones.Add(zone3)

			radChart1.Update()

			Me.EnabledQSFButtons = QSFButtons.None
		End Sub
	End Class
End Namespace