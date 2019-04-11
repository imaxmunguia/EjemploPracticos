Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.GridView.Tooltips
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()
			Me.SelectedControl = Me.radGridView1
			Me.radGridView1.EnableHotTracking = True
			AddHandler radGridView1.CellBeginEdit, AddressOf radGridView1_CellBeginEdit
		End Sub

		Private Sub radGridView1_CellBeginEdit(ByVal sender As Object, ByVal e As GridViewCellCancelEventArgs)
			If TypeOf Me.radGridView1.ActiveEditor Is RadItem Then
				TryCast(Me.radGridView1.ActiveEditor, RadItem).StretchVertically = False
			End If
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			Me.radGridView1.TableElement.RowHeight = 80
			Me.radGridView1.Columns("HireDate").FormatString = "{0:dd/MM/yyyy}"
			Me.employeesTableAdapter.Fill(Me.northwindDataSet.Employees)

			radGridView1.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill

			MyBase.OnLoad(e)
		End Sub

		Private Sub radGridView1_ToolTipTextNeeded(ByVal sender As Object, ByVal e As ToolTipTextNeededEventArgs) Handles radGridView1.ToolTipTextNeeded
			Dim dataCell As GridDataCellElement = TryCast(sender, GridDataCellElement)
			If dataCell IsNot Nothing Then
				e.ToolTipText = String.Format("Column: {0}, Row: {1}", dataCell.ColumnIndex, dataCell.RowIndex)
			End If
		End Sub

		Protected Overrides Function GetExampleDefaultTheme() As String
			Return "ControlDefault"
		End Function
	End Class
End Namespace
