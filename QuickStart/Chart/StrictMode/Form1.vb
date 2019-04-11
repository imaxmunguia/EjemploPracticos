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

Namespace Telerik.Examples.WinControls.Chart.StrictMode
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()

			radChart1.Series.Clear()

			Dim cs As New ChartSeries()

			cs.Items.Add(New ChartSeriesItem(0, 3))
			cs.Items.Add(New ChartSeriesItem(1, 3))
			cs.Items.Add(New ChartSeriesItem(3, 4))
			cs.Items.Add(New ChartSeriesItem(3, 3))
			cs.Items.Add(New ChartSeriesItem(4, 5))
			cs.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.White
			radChart1.Series.Add(cs)

			radChart1.PlotArea.YAxis.AxisMode = ChartYAxisMode.Extended
			'radChart1.PlotArea.XAxis.LayoutStyle = Telerik.Charting.Styles.ChartAxisLayoutMode.Between;
			radChart1.Update()

			Me.EnabledQSFButtons = QSFButtons.None
		End Sub
	End Class
End Namespace