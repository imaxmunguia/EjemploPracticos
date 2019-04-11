Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.GridView.CustomFiltering
	Partial Public Class Form1
		Inherits ExamplesForm

		Public Sub New()
			InitializeComponent()

			Me.radGridView.EnableHotTracking = True
			Me.radGridView.ShowFilteringRow = False
			Me.radGridView.EnableFiltering = True
			Me.radGridView.EnableCustomFiltering = True

		End Sub

		Private Sub OnFormLoad(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Me.customersTableAdapter.Fill(Me.nwindRadGridView.Customers)

			Me.SelectedControl = Me.filterTextBox
		End Sub

		Private Sub radGridView1_CustomFiltering(ByVal sender As Object, ByVal e As GridViewCustomFilteringEventArgs) Handles radGridView.CustomFiltering
			If String.IsNullOrEmpty(Me.filterTextBox.Text) Then
				e.Visible = True

				For i As Integer = 0 To Me.radGridView.ColumnCount - 1
					e.Row.Cells(i).Style.Reset()
					e.Row.InvalidateRow()
				Next i
				Return
			End If

			e.Visible = False
			For i As Integer = 0 To Me.radGridView.ColumnCount - 1
				Dim text As String = e.Row.Cells(i).Value.ToString()
				If text.IndexOf(Me.filterTextBox.Text, 0, StringComparison.InvariantCultureIgnoreCase) >= 0 Then
					e.Visible = True
					e.Row.Cells(i).Style.CustomizeFill = True
					e.Row.Cells(i).Style.DrawFill = True
					e.Row.Cells(i).Style.BackColor = Color.FromArgb(201, 252, 254)
				Else
					e.Row.Cells(i).Style.Reset()
					e.Row.InvalidateRow()
				End If
			Next i
		End Sub

		Protected Overrides Function GetExampleDefaultTheme() As String
			Return "ControlDefault"
		End Function

		Private Sub filterTextBox_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles filterTextBox.TextChanged
			Me.radGridView.MasterTemplate.Refresh()
		End Sub
	End Class
End Namespace
