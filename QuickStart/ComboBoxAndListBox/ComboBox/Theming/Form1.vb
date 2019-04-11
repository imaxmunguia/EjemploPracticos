Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.Editors.ComboBox.Theming
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()

			Me.comboBox1.Items.Add("Select DropDown Animation")
			Me.comboBox1.Items.AddRange(System.Enum.GetNames(GetType(RadEasingType)))

			Me.radComboBox1.DropDownAnimationEnabled = True
			Me.radComboBox1.DropDownAnimationFrames = 7
			Me.comboBox1.SelectedIndex = 0

			Me.SelectedControl = Me.radComboBox1
		End Sub

		Private Sub nudMaxFramerate_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles nudFramerate.ValueChanged
			Me.radComboBox1.DropDownAnimationFrames = CInt(Fix(Me.nudFramerate.Value))
		End Sub

		Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox1.SelectedIndexChanged
			Dim easing As String = CStr(Me.comboBox1.SelectedItem)

			If System.Enum.IsDefined(GetType(RadEasingType), easing) Then
				Me.radComboBox1.DropDownAnimationEasing = CType(System.Enum.Parse(GetType(RadEasingType), CStr(Me.comboBox1.SelectedItem)), RadEasingType)
			End If
		End Sub

		Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox1.CheckedChanged
			Me.radComboBox1.DropDownAnimationEnabled = Not Me.radComboBox1.DropDownAnimationEnabled
		End Sub
	End Class
End Namespace