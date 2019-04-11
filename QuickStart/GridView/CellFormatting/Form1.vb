Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports Telerik.WinControls.Data

Namespace Telerik.Examples.WinControls.GridView.CellFormatting
	Partial Public Class Form1
		Inherits ExamplesForm
        Private _font As Font

		Public Sub New()
			InitializeComponent()
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			Me.radButtonForeColor.ButtonElement.ButtonFillElement.GradientStyle = GradientStyles.Solid
			Me.radButtonForeColor.ButtonElement.ButtonFillElement.BackColor = Color.Yellow

			Me.radButtonBackColor.ButtonElement.ButtonFillElement.GradientStyle = GradientStyles.Solid
			Me.radButtonBackColor.ButtonElement.ButtonFillElement.BackColor = Color.Red

			employeeOrdersTableAdapter.Fill(northwindDataSet.EmployeeOrders)

			Me.radGridView1.MasterTemplate.AutoExpandGroups = True
			Me.radGridView1.GroupDescriptors.Add(New GridGroupByExpression("Title GroupBy Title"))
		End Sub

		Private Sub radGridView1_CellFormatting(ByVal sender As Object, ByVal e As CellFormattingEventArgs) Handles radGridView1.CellFormatting
			If e.CellElement.ColumnInfo.Name = "FirstName" AndAlso TypeOf e.CellElement.RowInfo Is GridViewDataRowInfo Then
				Dim quantity As Integer = -1
				Dim quantityValue As Object = e.CellElement.RowInfo.Cells("Quantity").Value

				If quantityValue IsNot Nothing AndAlso (Not Convert.IsDBNull(quantityValue)) Then
					quantity = CInt(Fix(CShort(Fix(quantityValue))))
				End If

				If quantity >= CInt(Fix(Me.radSpinEditorGreater.Value)) AndAlso quantity <= CInt(Fix(Me.radSpinEditorLess.Value)) Then
					e.CellElement.DrawFill = True
					e.CellElement.GradientStyle = GradientStyles.Solid
					e.CellElement.ForeColor = Me.radButtonForeColor.ButtonElement.ButtonFillElement.BackColor
					e.CellElement.BackColor = Me.radButtonBackColor.ButtonElement.ButtonFillElement.BackColor
				Else
					e.CellElement.ResetValue(LightVisualElement.DrawFillProperty, ValueResetFlags.Local)
					e.CellElement.ResetValue(LightVisualElement.GradientStyleProperty, ValueResetFlags.Local)
					e.CellElement.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local)
					e.CellElement.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local)
				End If
            Else
                e.CellElement.ResetValue(LightVisualElement.DrawFillProperty, ValueResetFlags.Local)
                e.CellElement.ResetValue(LightVisualElement.GradientStyleProperty, ValueResetFlags.Local)
                e.CellElement.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local)
                e.CellElement.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local)
            End If
		End Sub

		Private Sub radGridView1_RowFormatting(ByVal sender As Object, ByVal e As RowFormattingEventArgs) Handles radGridView1.RowFormatting
            If _font Is Nothing Then
                _font = New Font(e.RowElement.Font, FontStyle.Bold)
            End If

			Dim quantity As Integer = -1

			Dim quantityValue As Object = e.RowElement.RowInfo.Cells("Quantity").Value

			If quantityValue IsNot Nothing AndAlso (Not Convert.IsDBNull(quantityValue)) Then
				quantity = CInt(Fix(CShort(Fix(quantityValue))))
			End If

			If quantity >= CInt(Fix(Me.radSpinEditorGreater.Value)) AndAlso quantity <= CInt(Fix(Me.radSpinEditorLess.Value)) Then
                e.RowElement.Font = _font
				e.RowElement.BackColor = Color.Beige
				e.RowElement.DrawFill = True
			Else
				e.RowElement.ResetValue(LightVisualElement.FontProperty, ValueResetFlags.Local)
				e.RowElement.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local)
				e.RowElement.ResetValue(LightVisualElement.DrawFillProperty, ValueResetFlags.Local)
			End If
		End Sub

		Private Sub radButtonForeColor_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButtonForeColor.Click
			Dim dialog As New RadColorDialog()
			dialog.SelectedColor = Me.radButtonForeColor.ButtonElement.ButtonFillElement.BackColor
			If dialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
				Me.radButtonForeColor.ButtonElement.ButtonFillElement.BackColor = dialog.SelectedColor
				Me.radGridView1.TableElement.Update(GridUINotifyAction.StateChanged)
			End If
		End Sub

		Private Sub radButtonBackColor_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButtonBackColor.Click
			Dim dialog As New RadColorDialog()
			dialog.SelectedColor = Me.radButtonBackColor.ButtonElement.ButtonFillElement.BackColor
			If dialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
				Me.radButtonBackColor.ButtonElement.ButtonFillElement.BackColor = dialog.SelectedColor
				Me.radGridView1.TableElement.Update(GridUINotifyAction.StateChanged)
			End If
		End Sub

		Private Sub radSpinEditorGreater_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radSpinEditorGreater.ValueChanged
			Me.radGridView1.TableElement.Update(GridUINotifyAction.StateChanged)
		End Sub

		Private Sub radSpinEditorLess_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radSpinEditorLess.ValueChanged
			Me.radGridView1.TableElement.Update(GridUINotifyAction.StateChanged)
		End Sub

		Protected Overrides Function GetExampleDefaultTheme() As String
			Return "ControlDefault"
		End Function
	End Class
End Namespace
