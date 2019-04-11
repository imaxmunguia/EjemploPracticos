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

Namespace Telerik.Examples.WinControls.Chart.ChartTypes.Bubble
	Partial Public Class Form1
		Inherits ExamplesForm
		Private ds As New DataSet()
		Public Sub New()
			InitializeComponent()

			'populate datavalues
			ds = GetSampleData()

			'set the properties to be used from the datasource to populate the chart
			radChart1.PlotArea.YAxis.AxisMode = Telerik.Charting.ChartYAxisMode.Extended
			radChart1.ChartTitle.TextBlock.Text = "Bubble"
			radChart1.DataManager.DataSource = ds
			radChart1.DataManager.DataMember = "Data"
			radChart1.DataBind()

			Me.EnabledQSFButtons = QSFButtons.None
		End Sub
		''' <summary>
		''' Returns a simple dataset to be bound to the chart
		''' </summary>
		''' <returns></returns>
		Public Function GetSampleData() As DataSet
			Dim dt As New DataTable("Data")
			dt.Columns.Add("X", GetType(Integer))
			dt.Columns.Add("Y", GetType(Integer))
			dt.Columns.Add("X2", GetType(Integer))
			dt.Columns.Add("Y2", GetType(Integer))

			Dim drv As DataRow = dt.NewRow()
			drv(0) = -20
			drv(1) = -10
			drv(2) = 10
			drv(3) = 5
			dt.Rows.Add(drv)

			drv = dt.NewRow()
			drv(0) = 10
			drv(1) = 20
			drv(2) = 5
			drv(3) = 10
			dt.Rows.Add(drv)

			drv = dt.NewRow()
			drv(0) = -30
			drv(1) = 40
			drv(2) = 5
			drv(3) = 10
			dt.Rows.Add(drv)

			drv = dt.NewRow()
			drv(0) = 40
			drv(1) = -30
			drv(2) = 15
			drv(3) = 15
			dt.Rows.Add(drv)

			drv = dt.NewRow()
			drv(0) = 20
			drv(1) = -50
			drv(2) = 5
			drv(3) = 20
			dt.Rows.Add(drv)

			drv = dt.NewRow()
			drv(0) = 0
			drv(1) = 0
			drv(2) = 5
			drv(3) = 10
			dt.Rows.Add(drv)

			ds = New DataSet()
			ds.Tables.Add(dt)

			Return ds
		End Function
	End Class
End Namespace