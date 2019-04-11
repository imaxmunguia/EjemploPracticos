Imports Microsoft.VisualBasic
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports System.Data.OleDb

Namespace Telerik.Examples.WinControls.GridView.CreateRowInfo
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()

			AddHandler radGridView1.CreateCell, AddressOf radGridView1_CreateCell
			Me.radGridView1.EnableFiltering = True
			Me.radGridView1.EnableCustomFiltering = True

			AddHandler radGridView1.CustomFiltering, AddressOf radGridView1_CustomFiltering
		End Sub

		Private Sub radGridView1_CustomFiltering(ByVal sender As Object, ByVal e As GridViewCustomFilteringEventArgs)

		End Sub

		Protected Overrides Function GetExampleDefaultTheme() As String
			Return "ControlDefault"
		End Function

		Private Sub radGridView1_CreateCell(ByVal sender As Object, ByVal e As GridViewCreateCellEventArgs)
			If e.CellType Is GetType(GridRowHeaderCellElement) AndAlso TypeOf e.Row.RowInfo Is ExpandableGridViewFilteringRowInfo Then
				e.CellType = GetType(GridFilterExpandableCellElement)
			End If
		End Sub

		Private Sub MasterTemplate_CreateRowInfo(ByVal sender As Object, ByVal e As GridViewCreateRowInfoEventArgs) Handles radGridView1.CreateRowInfo
			If TypeOf e.RowInfo Is GridViewFilteringRowInfo Then
				e.RowInfo = New ExpandableGridViewFilteringRowInfo(e.ViewInfo)
			End If
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As System.EventArgs)
			MyBase.OnLoad(e)

			Me.radGridView1.MasterTemplate.AllowAddNewRow = False
			Me.radGridView1.MasterTemplate.AutoGenerateColumns = True
			Me.radGridView1.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill

			Me.radGridView1.TableElement.BeginUpdate()

			Using command As New OleDbCommand("SELECT CompanyName, ContactName, ContactTitle, Address, PostalCode FROM Customers")
				command.Connection = New OleDbConnection(My.Settings.Default.NwindConnectionString)
				command.Connection.Open()
				Me.radGridView1.MasterTemplate.LoadFrom(command.ExecuteReader())
				command.Connection.Close()
			End Using

			Me.radGridView1.Columns("ContactName").HeaderText = "Contact Name"
			Me.radGridView1.Columns("CompanyName").HeaderText = "Company Name"
			Me.radGridView1.Columns("ContactTitle").HeaderText = "Contact Title"
			Me.radGridView1.Columns("PostalCode").HeaderText = "Postal Code"

			Me.radGridView1.TableElement.EndUpdate()
			Me.radGridView1.CurrentRow = Me.radGridView1.Rows(0)
			Me.radGridView1.Rows(0).IsSelected = True
		End Sub
	End Class
End Namespace
