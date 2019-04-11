Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.WinControls.UI
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.WinControls.Tests

Namespace Telerik.Examples.WinControls.UIElements.ShapedForm.FirstLook
	Partial Public Class Form1
		Inherits ExamplesForm
		Private shape As Telerik.WinControls.CustomShape

		Public Sub New()
			InitializeComponent()

			radComboBox1.Items.Add(New RadListDataItem("RoundRectShape", GetType(RoundRectShape)))
			radComboBox1.Items.Add(New RadListDataItem("EllipseShape", GetType(EllipseShape)))
			radComboBox1.Items.Add(New RadListDataItem("DonutShape", GetType(DonutShape)))
			radComboBox1.Items.Add(New RadListDataItem("TabOffice12Shape", GetType(TabOffice12Shape)))
			radComboBox1.Items.Add(New RadListDataItem("TabVsShape", GetType(TabVsShape)))

			Me.EnabledQSFButtons = QSFButtons.ControlSpy
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)
			radComboBox1.SelectedIndex = 0
		End Sub

		Private Sub radButton2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButton2.Click
			Dim shape As ElementShape = Nothing

			If radioButton1.Checked Then
				Dim item As RadListDataItem = radComboBox1.SelectedItem
				shape = CType(Activator.CreateInstance(CType(item.Value, Type)), ElementShape)
			Else
				shape = Me.shape
			End If

			Dim form As New MyShapedForm(shape)
			form.BorderWidth = 2
			form.ShowDialog()
		End Sub

		Private Sub radButton3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles radButton3.Click
			radioButton2.Checked = True

			Dim form As New Telerik.WinControls.CustomShapeEditorForm()

			If shape Is Nothing Then
				shape = New Telerik.WinControls.CustomShape(New Rectangle(0, 0, 320, 180))
			End If

			shape = form.EditShape(shape)

			If form.Result = System.Windows.Forms.DialogResult.OK Then
				radButton1.ButtonElement.Shape = shape
			End If
		End Sub

		Private Sub radComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles radComboBox1.SelectedIndexChanged
			radioButton1.Checked = True
			Dim item As RadListDataItem = radComboBox1.SelectedItem
			radButton1.ButtonElement.Shape = CType(Activator.CreateInstance(CType(item.Value, Type)), ElementShape)
		End Sub

		Private Sub radioButton1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radioButton1.CheckedChanged
			Dim item As RadListDataItem = radComboBox1.SelectedItem
			radButton1.ButtonElement.Shape = CType(Activator.CreateInstance(CType(item.Value, Type)), ElementShape)
		End Sub

		Private Sub radioButton2_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radioButton2.CheckedChanged
			If shape IsNot Nothing Then
				radButton1.ButtonElement.Shape = shape
			End If
		End Sub
	End Class
End Namespace