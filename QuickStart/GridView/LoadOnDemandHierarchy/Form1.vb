Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports System.Data

Namespace Telerik.Examples.WinControls.GridView.LoadOnDemandHierarchy
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Me.productModelTableAdapter.Fill(Me.adventureLT2008DataSet.ProductModel)
			Me.productTableAdapter.Fill(Me.adventureLT2008DataSet.Product)

			Me.radGridView1.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
			Me.radGridView1.Templates(0).AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
			Me.radGridView1.Templates(0).AllowAddNewRow = False

			Me.radGridView1.Templates(0).HierarchyDataProvider = New GridViewEventDataProvider(Me.radGridView1.Templates(0))
			AddHandler radGridView1.RowSourceNeeded, AddressOf radGridView1_RowSourceNeeded
		End Sub

		Private Sub radGridView1_RowSourceNeeded(ByVal sender As Object, ByVal e As GridViewRowSourceNeededEventArgs)
			Dim rowView As DataRowView = TryCast(e.ParentRow.DataBoundItem, DataRowView)
			Dim rows() As DataRow = rowView.Row.GetChildRows("ProductModel_Product")

			For Each dataRow As DataRow In rows
				Dim row As GridViewRowInfo = e.Template.Rows.NewRow()
				row.Cells("Name").Value = dataRow("Name")
				row.Cells("ProductNumber").Value = dataRow("ProductNumber")
				row.Cells("Color").Value = dataRow("Color")
				row.Cells("ListPrice").Value = dataRow("ListPrice")
				row.Cells("Size").Value = dataRow("Size")
				row.Cells("Weight").Value = dataRow("Weight")
				row.Cells("DiscontinuedDate").Value = dataRow("DiscontinuedDate")

				e.SourceCollection.Add(row)
			Next dataRow
		End Sub

		Protected Overrides Function GetExampleDefaultTheme() As String
			Return "ControlDefault"
		End Function
	End Class
End Namespace
