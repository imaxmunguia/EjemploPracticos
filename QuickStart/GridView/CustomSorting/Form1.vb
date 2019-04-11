Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.GridView.CustomSorting
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()

			Me.radGridView.EnableCustomSorting = True
		End Sub

		Private Sub OnFormLoad(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Me.customersTableAdapter.Fill(Me.nwindRadGridView.Customers)
			Me.SelectedControl = Me.radGridView
		End Sub

		Private Sub radGridView1_CustomSorting(ByVal sender As Object, ByVal e As GridViewCustomSortingEventArgs) Handles radGridView.CustomSorting
			If Me.radGridView.SortDescriptors.Count = 0 Then
				Return
			End If

			Dim result As Integer = 0
			For i As Integer = 0 To Me.radGridView.SortDescriptors.Count - 1
				Dim cellValue1 As String = e.Row1.Cells(Me.radGridView.SortDescriptors(i).PropertyName).Value.ToString()
				Dim cellValue2 As String = e.Row2.Cells(Me.radGridView.SortDescriptors(i).PropertyName).Value.ToString()

				result = cellValue1.Length - cellValue2.Length
				If result <> 0 Then
					If Me.radGridView.SortDescriptors(i).Direction = ListSortDirection.Descending Then
						result *= -1
					End If
					Exit For
				End If
			Next i

			e.SortResult = result
		End Sub

		Protected Overrides Function GetExampleDefaultTheme() As String
			Return "ControlDefault"
		End Function
	End Class
End Namespace
