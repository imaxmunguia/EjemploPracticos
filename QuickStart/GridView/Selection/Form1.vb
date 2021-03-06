Imports Microsoft.VisualBasic
Imports System
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.GridView.Selection
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()

			Me.SelectedControl = Me.radGridView1
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Me.BindGrid()

			Me.radGridView1.MultiSelect = True
			Me.radGridView1.EnableHotTracking = True
			Me.radGridView1.SelectionMode = GridViewSelectionMode.FullRowSelect
			Me.radComboSelectionMode.SelectedIndex = 0

			Me.LoadInitialSelection()
		End Sub

		Private Sub LoadInitialSelection()
			For rowsCount As Integer = 0 To 9
				Me.radGridView1.Rows(rowsCount).IsSelected = True
			Next rowsCount
		End Sub

		Private Sub BindGrid()
			aggregatesSampleTableTableAdapter.Fill(nwindRadGridView.EmployeeOrders)
			Me.radGridView1.DataSource = Me.aggregatesSampleTableBindingSource

			Me.radGridView1.Columns("UnitPrice").FormatString = "${0:F2}"
		End Sub

		Private Sub radComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles radComboSelectionMode.SelectedIndexChanged
			If Me.radComboSelectionMode.SelectedIndex = 0 Then
				Me.radGridView1.SelectionMode = Telerik.WinControls.UI.GridViewSelectionMode.FullRowSelect
			Else
				Me.radGridView1.SelectionMode = Telerik.WinControls.UI.GridViewSelectionMode.CellSelect
			End If
		End Sub

		Private Sub radCheckBox1_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles radCheckMulti.ToggleStateChanged
			Me.radGridView1.MultiSelect = Me.radCheckMulti.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
		End Sub

		Private Sub radCheckBox2_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles radCheckTranslucent.ToggleStateChanged
			Me.radGridView1.TableElement.ShowTranslucentSelectionRectangle = Me.radCheckTranslucent.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
		End Sub

		Private Sub radCheckBox3_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles radCheckHideSel.ToggleStateChanged
			Me.radGridView1.HideSelection = Me.radCheckHideSel.Checked
		End Sub

		Private Sub radButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButton1.Click
			Me.radGridView1.SelectAll()
		End Sub

		Private Sub radButton2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButton2.Click
			Me.radGridView1.ClearSelection()
		End Sub

		Protected Overrides Function GetExampleDefaultTheme() As String
			Return "ControlDefault"
		End Function
	End Class
End Namespace