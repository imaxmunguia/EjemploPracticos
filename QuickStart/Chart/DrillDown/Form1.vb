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
Imports System.Data.OleDb
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.Chart.DrillDown
	''' <summary>
	''' Main form for the drill down example
	''' </summary>
	Partial Public Class Form1
		Inherits ExamplesForm
		Private rta As ChartDataSetTableAdapters.RevenueTableAdapter

		'stores the currently selected year
		Private year As Integer

		Public Sub New()
			InitializeComponent()

			Me.EnabledQSFButtons = QSFButtons.None
			'populate the datasource from the database
			rta = New ChartDataSetTableAdapters.RevenueTableAdapter()
			'fill the revenue by years
			rta.FillByYear(Me.chartDataSet.Revenue)

			'setup the chart X axis properties
			radChart1.PlotArea.XAxis.IsZeroBased = False
			radChart1.PlotArea.XAxis.AutoScale = False
			radChart1.PlotArea.XAxis.MinValue = 2003
			radChart1.PlotArea.XAxis.MaxValue = 2005

			'attach the datasource to the chart
			radChart1.DataManager.DataSource = Me.chartDataSet.Revenue
			radChart1.Series(0).DataYColumn = "Revenue"
			radChart1.Series(0).DataXColumn = "Year"
			radChart1.Series(0).Name = "Years"
			radChart1.DataBind()
			radChart1.Update()
		End Sub

		Private Sub radChart1_Click(ByVal sender As Object, ByVal args As ChartClickEventArgs) Handles radChart1.Click
			If TypeOf args.Element.ActiveRegion.Parent Is ChartSeriesItem AndAlso (TryCast(args.Element.ActiveRegion.Parent, ChartSeriesItem)).Parent.Name = "Years" Then
				'a bar representing the revenue for a year was clicked
				year = (TryCast(args.Element, ChartSeriesItem)).Index + 2003
				'fill revenue values for the year whose bar was clicked
				rta.FillByQuarter(Me.chartDataSet.Revenue, year)

				'setup chart properties with appopriate axis labels
				radChart1.PlotArea.XAxis.DataLabelsColumn = "Quarter"
				radChart1.Series(0).Clear()
				radChart1.Series(0).DataYColumn = "Revenue"
				radChart1.Series(0).Name = "Quarters"
				radChart1.DataBind()
			ElseIf TypeOf args.Element Is ChartSeriesItem AndAlso (TryCast(args.Element, ChartSeriesItem)).Parent.Name = "Quarters" Then
				'a bar representing the revenue for a year was clicked
				Dim quarter As Integer = (TryCast(args.Element, ChartSeriesItem)).Index + 1

				'fill revenue values for the year whose bar was clicked
				rta.FillByMonth(Me.chartDataSet.Revenue, year, quarter)

				'setup chart properties with appopriate axis labels
				radChart1.PlotArea.XAxis.DataLabelsColumn = "Month"
				radChart1.Series(0).Clear()
				radChart1.Series(0).DataYColumn = "Revenue"
				radChart1.Series(0).Name = "Months"
				radChart1.DataBind()

				'Detach Click event handler for the innermost chart
				RemoveHandler radChart1.Click, AddressOf radChart1_Click
			End If
		End Sub
	End Class
End Namespace