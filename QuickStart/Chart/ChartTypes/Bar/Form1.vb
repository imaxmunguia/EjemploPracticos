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

Namespace Telerik.Examples.WinControls.Chart.ChartTypes.Bar
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()
			'populate datavalues
			Dim ds As DataSet = GetSampleData()

			'set the properties to be used from the datasource to populate the chart
			radChart2.ChartTitle.TextBlock.Text = "Sales by Month"
			radChart2.DataManager.DataSource = ds
			radChart2.DataManager.ValuesYColumns = New String() { "Sales" }
			radChart2.DataManager.LabelsColumn = "Month"
			radChart2.DataManager.DataMember = "Product A"
			radChart2.DataBind()

			Me.EnabledQSFButtons = QSFButtons.None
		End Sub
		''' <summary>
		''' Returns a simple dataset to be bound to the chart
		''' </summary>
		''' <returns></returns>
		Public Function GetSampleData() As DataSet
			Dim dt As New DataTable("Product A")
			dt.Columns.Add("id", GetType(Integer))
			dt.Columns.Add("Sales", GetType(Double))
			dt.Columns.Add("Month", GetType(String))

			Dim drv As DataRow = dt.NewRow()
			drv(0) = 0
			drv(1) = 1000
			drv(2) = "January"
			dt.Rows.Add(drv)

			drv = dt.NewRow()
			drv(0) = 1
			drv(1) = 1200
			drv(2) = "February"
			dt.Rows.Add(drv)

			drv = dt.NewRow()
			drv(0) = 2
			drv(1) = 1200
			drv(2) = "March"
			dt.Rows.Add(drv)

			drv = dt.NewRow()
			drv(0) = 3
			drv(1) = 1240
			drv(2) = "April"
			dt.Rows.Add(drv)

			drv = dt.NewRow()
			drv(0) = 4
			drv(1) = 1249
			drv(2) = "May"
			dt.Rows.Add(drv)

			drv = dt.NewRow()
			drv(0) = 5
			drv(1) = 1320
			drv(2) = "June"
			dt.Rows.Add(drv)

			drv = dt.NewRow()
			drv(0) = 6
			drv(1) = 1410
			drv(2) = "July"
			dt.Rows.Add(drv)

			Dim ds As New DataSet()
			ds.Tables.Add(New DataTable("Books"))
			ds.Tables.Add(dt)

			Return ds
		End Function
	End Class
End Namespace