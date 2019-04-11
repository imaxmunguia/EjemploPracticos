Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.GridView.ErrorInfo
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub UpdateState(ByVal row As GridViewRowInfo, ByVal column As GridViewColumn)
			If row IsNot Nothing AndAlso column IsNot Nothing Then
				Me.radTextBoxRowError.Text = row.ErrorText
				Me.radTextBoxCellError.Text = row.Cells(column.Name).ErrorText

				Dim isEnabled As Boolean = (Not String.IsNullOrEmpty(row.ErrorText)) OrElse Not String.IsNullOrEmpty(row.Cells(column.Name).ErrorText)

				Dim dataErrorInfo As IDataErrorInfo = TryCast(row.DataBoundItem, IDataErrorInfo)

				If dataErrorInfo IsNot Nothing AndAlso isEnabled Then
					Dim [error] As String = dataErrorInfo(column.Name)
					isEnabled = String.IsNullOrEmpty([error])
				End If

				Me.radButtonClear.Enabled = isEnabled
				Me.UpdateSetButtonState()

				Me.radTextBoxRowError.Enabled = True
				Me.radTextBoxCellError.Enabled = True
			Else
				Me.radButtonClear.Enabled = False
				Me.radButtonSet.Enabled = False
				Me.radTextBoxCellError.Enabled = False
				Me.radTextBoxRowError.Enabled = False
			End If
		End Sub

		Private Sub UpdateSetButtonState()
			Me.radButtonSet.Enabled = (Not String.IsNullOrEmpty(Me.radTextBoxCellError.Text)) OrElse Not String.IsNullOrEmpty(Me.radTextBoxRowError.Text)
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			AddHandler radGridView1.CellFormatting, AddressOf radGridView1_CellFormatting
			AddHandler radGridView1.CurrentCellChanged, AddressOf radGridView1_CurrentCellChanged
			AddHandler radTextBoxCellError.TextChanged, AddressOf radTextBoxCellError_TextChanged
			AddHandler radTextBoxRowError.TextChanged, AddressOf radTextBoxRowError_TextChanged

			Dim employees As BindingList(Of Employee) = New BindingList(Of Employee)()
			employees.Add(New Employee(1, "Fuller, Andrew", "London", "andrew@gmail.com", "555-235-2359", EmployeePosition.VicePresident))
			employees.Add(New Employee(2, "Davolio, Nancy", "London", "nancy.davoilo@gmail.com", "555-435-1265", EmployeePosition.SalesManager))
			employees.Add(New Employee(3, "Peacock, Margaret", "London", "peacock@gmail.com", "555-645-5513", EmployeePosition.SalesRepresentative))
			employees.Add(New Employee(4, "King, Robert", "Seattle", "king", "555-331-6578", EmployeePosition.SalesRepresentative))
            employees.Add(New Employee(5, "Dodsworth, Anne", "Tacoma", "anne@gmail.com", "555-236-6845", EmployeePosition.SalesRepresentative))
            employees.Add(New Employee(6, "Callahan, Laura", "Seattle", "laura@gmail.com", "555-875-343", EmployeePosition.SalesRepresentative))
			employees.Add(New Employee(7, "Steven, Buchanan", "London", "steven@gmail.com", "555-348-8267", EmployeePosition.Coordinator))

			Me.radGridView1.MasterTemplate.AutoExpandGroups = True
			Me.radGridView1.ShowGroupedColumns = True
			Me.radGridView1.EnableGrouping = False
			Me.radGridView1.AllowDeleteRow = False
			Me.radGridView1.AllowAddNewRow = False
			Me.radGridView1.TableElement.RowHeight = 40
			Me.radGridView1.DataSource = employees

			Me.radGridView1.Columns("Name").Width = 180
			Me.radGridView1.Columns("EMail").Width = 180
			Me.radGridView1.Columns("Phone").Width = 100
			Me.radGridView1.Columns("City").Width = 80
			Me.radGridView1.Columns("Position").Width = 150

			Me.radSpinEditorRow.Maximum = Me.radGridView1.Rows.Count - 1
			Me.radSpinEditorColumn.Maximum = Me.radGridView1.Columns.Count - 1
		End Sub

		Private Sub radTextBoxRowError_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			UpdateSetButtonState()
		End Sub

		Private Sub radTextBoxCellError_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			UpdateSetButtonState()
		End Sub

		Private Sub radSpinEditorRow_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radSpinEditorRow.ValueChanged
			Me.radGridView1.Rows(CInt(Fix(Me.radSpinEditorRow.Value))).IsCurrent = True
		End Sub

		Private Sub radSpinEditorColumn_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radSpinEditorColumn.ValueChanged
			Me.radGridView1.Columns(CInt(Fix(Me.radSpinEditorColumn.Value))).IsCurrent = True
		End Sub

		Private Sub radGridView1_CurrentCellChanged(ByVal sender As Object, ByVal e As CurrentCellChangedEventArgs)
			If e.NewCell IsNot Nothing Then
				Me.radSpinEditorRow.Value = Me.radGridView1.Rows.IndexOf(e.NewCell.RowInfo)
				Me.radSpinEditorColumn.Value = Me.radGridView1.Columns.IndexOf(CType(e.NewCell.ColumnInfo, GridViewDataColumn))
			End If
			UpdateState(If(e.NewCell IsNot Nothing, e.NewCell.RowInfo, Nothing),If(e.NewCell IsNot Nothing, e.NewCell.ColumnInfo, Nothing))
		End Sub

		Private Sub radGridView1_CellFormatting(ByVal sender As Object, ByVal e As CellFormattingEventArgs)
			Dim cell As GridDataCellElement = TryCast(e.CellElement, GridDataCellElement)
			If cell IsNot Nothing Then
				If cell.ContainsErrors Then
					cell.DrawBorder = True
                    cell.BorderBoxStyle = BorderBoxStyle.FourBorders
                    cell.BorderBottomColor = Color.Transparent
                    cell.BorderTopColor = Color.Transparent
                    cell.BorderRightShadowColor = Color.Transparent
                    cell.BorderLeftShadowColor = Color.Transparent
                    cell.BorderBottomShadowColor = Color.Red
                    cell.BorderTopShadowColor = Color.Red
                    cell.BorderRightColor = Color.Red
                    cell.BorderLeftColor = Color.Red
                    cell.BorderBottomWidth = 1
                    cell.BorderTopWidth = 1
                    cell.BorderRightWidth = 1
                    cell.BorderLeftWidth = 1

                    cell.BorderDrawMode = BorderDrawModes.HorizontalOverVertical
                    cell.ZIndex = 2
				Else
					cell.ResetValue(LightVisualElement.DrawBorderProperty, ValueResetFlags.Local)
					cell.ResetValue(LightVisualElement.BorderBoxStyleProperty, ValueResetFlags.Local)
                    cell.ResetValue(LightVisualElement.BorderDrawModeProperty, ValueResetFlags.Local)
                    cell.ResetValue(LightVisualElement.ZIndexProperty, ValueResetFlags.Local)
				End If
			End If
		End Sub

		Private Sub radButtonSet_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButtonSet.Click
			Dim row As Integer = CInt(Fix(radSpinEditorRow.Value))
			Dim column As Integer = CInt(Fix(radSpinEditorColumn.Value))

			Dim columnError As String = radTextBoxCellError.Text
			Dim rowError As String = radTextBoxRowError.Text
			Dim dataErrorInfo As IDataErrorInfo = TryCast(Me.radGridView1.Rows(row).DataBoundItem, IDataErrorInfo)

			If dataErrorInfo IsNot Nothing Then
				Dim propertyError As String = dataErrorInfo(Me.radGridView1.Columns(column).Name)
				Dim dataError As String = dataErrorInfo.Error

				Dim showMessage As Boolean = False

				If String.IsNullOrEmpty(columnError) AndAlso (Not String.IsNullOrEmpty(propertyError)) Then
					columnError = propertyError
					radTextBoxCellError.Text = columnError
					showMessage = True
				End If

				If String.IsNullOrEmpty(rowError) AndAlso (Not String.IsNullOrEmpty(dataError)) Then
					rowError = dataError
					radTextBoxRowError.Text = rowError
					showMessage = True
				End If

				If showMessage Then
					RadMessageBox.Show("You cannot set error text to String.Empty, because IDataErrorInfo interface has errors.", "Information", MessageBoxButtons.OK, RadMessageIcon.Info)
				End If
			End If

			Me.radGridView1.Rows(row).ErrorText = rowError
			Me.radGridView1.Rows(row).Cells(column).ErrorText = columnError
			Me.UpdateState(Me.radGridView1.CurrentRow, Me.radGridView1.CurrentColumn)
		End Sub

		Private Sub radButtonClear_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButtonClear.Click
			Dim row As Integer = CInt(Fix(radSpinEditorRow.Value))
			Dim column As Integer = CInt(Fix(radSpinEditorColumn.Value))
			Me.radGridView1.Rows(row).ErrorText = String.Empty
			Me.radGridView1.Rows(row).Cells(column).ErrorText = String.Empty
			Me.radTextBoxCellError.Text = String.Empty
			Me.radTextBoxRowError.Text = String.Empty
			Me.radButtonClear.Enabled = False
			Me.radButtonSet.Enabled = False
		End Sub

		Protected Overrides Function GetExampleDefaultTheme() As String
			Return "ControlDefault"
		End Function
	End Class
End Namespace
