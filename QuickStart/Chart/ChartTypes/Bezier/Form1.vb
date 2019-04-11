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

Namespace Telerik.Examples.WinControls.Chart.ChartTypes.Bezier
	Partial Public Class Form1
		Inherits ExamplesForm
		Private ds As New DataSet()
		Public Sub New()
			InitializeComponent()
			'populate datavalues
			ds = GetSampleData()

			'set the properties to be used from the datasource to populate the chart
			radChart1.ChartTitle.TextBlock.Text = "Bezier"
			radChart1.DataManager.DataSource = ds
			radChart1.DataManager.ValuesYColumns = New String() { "Y" }
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
			dt.Columns.Add("Y", GetType(Double))

			Dim drv As DataRow = dt.NewRow()
			drv(0) = 10
			drv(1) = 20
			dt.Rows.Add(drv)

			drv = dt.NewRow()
			drv(0) = 140
			drv(1) = 100
			dt.Rows.Add(drv)

			drv = dt.NewRow()
			drv(0) = -40
			drv(1) = 100
			dt.Rows.Add(drv)

			drv = dt.NewRow()
			drv(0) = 90
			drv(1) = 20
			dt.Rows.Add(drv)

			ds = New DataSet()
			ds.Tables.Add(dt)

			Return ds
		End Function
	End Class
End Namespace