Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.Charting
Imports Telerik.QuickStart.WinControls
Imports Telerik.Charting.Styles

Namespace Telerik.Examples.WinControls.Chart.DataBinding.LiveDataFeed
	Partial Public Class Form1
		Inherits ExamplesForm
		Private ds As New DataSet()
		Public Sub New()
			InitializeComponent()
			'retrieves the XML content from the online datasource
			ds.ReadXml("http://store.rabbitvalley.org/rss_feed.rss")
			Dim s As ChartSeries = radChart1.Series(0)

			s.Appearance.ShowLabels = True
			s.Name = "10 Ten Moving Items"
			'initializes chart properties
			radChart1.Appearance.BarWidthPercent = 60
			radChart1.PlotArea.YAxis.AutoScale = False
			radChart1.PlotArea.YAxis.AddRange(0, 11, 1)
			radChart1.PlotArea.YAxis.AxisLabel.Visible = False
			radChart1.PlotArea.YAxis.Appearance.MajorTick.Visible = False
			radChart1.PlotArea.YAxis.Appearance.LabelAppearance.Visible = False
			radChart1.PlotArea.XAxis.LayoutMode = ChartAxisLayoutMode.Inside

			Dim i As Integer = 10
			'adds series items from the from the data
			For Each dr As DataRow In ds.Tables(2).Rows
				s.Items.Add(New ChartSeriesItem(i, CStr(dr("Title"))))
				i -= 1
			Next dr
			radChart1.ChartTitle.TextBlock.Text = "Rabbit Valley 10 Ten Moving Items"

			Me.EnabledQSFButtons = QSFButtons.None
		End Sub
	End Class
End Namespace