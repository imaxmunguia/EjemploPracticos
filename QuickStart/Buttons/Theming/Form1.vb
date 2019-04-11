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

Namespace Telerik.Examples.WinControls.Buttons.Theming
	''' <summary>
	''' updated the path
	''' </summary>
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub textBox1_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			'radTextBox1.NullText = textBox1.Text;
		End Sub

		Private Sub radTextBox2_TextChanging(ByVal sender As Object, ByVal e As Telerik.WinControls.TextChangingEventArgs)

		End Sub

		Private Sub label9_Click(ByVal sender As Object, ByVal e As EventArgs) Handles label9.Click

		End Sub

		Private Sub label11_Click(ByVal sender As Object, ByVal e As EventArgs) Handles label11.Click

		End Sub

		Private Sub radRepeatButton1_ButtonClick(ByVal sender As Object, ByVal e As EventArgs) Handles radRepeatButton1.ButtonClick
			If progressBar1.Value < progressBar1.Maximum Then
				progressBar1.Increment(1)
			Else
				progressBar1.Value = progressBar1.Minimum
			End If
		End Sub

		Private Sub radMenuItem1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radMenuItem1.Click
			radButton2.RootElement.Children(0).AngleTransform += 10f
			SetDefaultItem(radMenuItem1)
		End Sub

		Private Sub SetDefaultItem(ByVal item As RadMenuItem)
			radSplitButton1.DefaultItem = item
			radSplitButton1.ImageIndex = item.ImageIndex
			radSplitButton1.Text = item.Text
		End Sub

		Private Sub radMenuItem2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radMenuItem2.Click
			radButton2.RootElement.Children(0).AngleTransform -= 10f
			SetDefaultItem(radMenuItem2)
		End Sub
	End Class
End Namespace