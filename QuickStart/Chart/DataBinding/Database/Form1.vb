Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.OleDb
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls

Namespace Telerik.Examples.WinControls.Chart.DataBinding.Database
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()
			'gets the data from the database
			Dim dt As DataTable = GetData()

			radChart1.ChartTitle.TextBlock.Text = "Customers by Country"
			radChart1.DataManager.DataSource = dt

			'set the column in the datasource to be used for the labels
			radChart1.DataManager.LabelsColumn = "COUNTRY"

			'sets the labels so that there are no overlaps
			radChart1.IntelligentLabelsEnabled = True
			radChart1.DataBind()
			radChart1.Series(0).Name = "Country"

			'the legend will display the labels of the items, instead of the name of the series
			radChart1.Series(0).Appearance.LegendDisplayMode = Telerik.Charting.ChartSeriesLegendDisplayMode.ItemLabels
			radChart1.Update()

			Me.EnabledQSFButtons = QSFButtons.None
		End Sub
		''' <summary>
		''' Returns a datatable containing data retrieved from the database
		''' </summary>
		''' <returns></returns>
		Private Function GetData() As DataTable
			Dim dt As New DataTable()
			'opens a connection to the northwind database - the file should be placed in the executable directory of the project
			Dim dbConn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\DataSources\Nwind.mdb")
			dbConn.Open()
			'initialize a command returning a list of countries and the number of customers in each one
			Dim da As New OleDbDataAdapter("SELECT TOP 6 COUNTRY, count(*)" & ControlChars.CrLf & "				FROM CUSTOMERS " & ControlChars.CrLf & "				GROUP BY COUNTRY", dbConn)

			'execute the query and close the connection to the database
			Try
				da.Fill(dt)
			Finally
				dbConn.Close()
			End Try
			Return dt
		End Function
	End Class
End Namespace