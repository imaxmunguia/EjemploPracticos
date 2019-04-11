Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.QuickStart.WinControls
Imports Telerik.Examples.WinControls.Editors.ComboBox

Namespace Telerik.Examples.WinControls.Buttons.SplitButton
	''' <summary>
	''' Main class for the split button example
	''' </summary>
	Partial Public Class Form1
		Inherits EditorExampleBaseForm
		Public Sub New()
			InitializeComponent()
			SetTheme()
			Me.SelectedControl = radSplitButton3
		End Sub

		Private Sub SetTheme()
			Me.radButton1.ThemeName = "ControlDefault"
			Me.radSplitButton3.ThemeName = "ControlDefault"
		End Sub

		Private rotatedElement As RadElement

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			rotatedElement = radButton1.RootElement.Children(0)
			Me.radButton1.AutoSize = True
			SetDefaultItem(radMenuItem1)
		End Sub

		Private Sub radMenuItem1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radMenuItem1.Click
			rotatedElement.AngleTransform += 10f
			SetDefaultItem(radMenuItem1)
		End Sub

		Private Sub radMenuItem2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radMenuItem2.Click
			rotatedElement.AngleTransform -= 10f
			SetDefaultItem(radMenuItem2)
		End Sub

		Private Sub radButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
			rotatedElement.AngleTransform = 0f
		End Sub

		Private Sub SetDefaultItem(ByVal item As RadMenuItem)
			radSplitButton3.DefaultItem = item
			radSplitButton3.ImageIndex = item.ImageIndex
			radSplitButton3.Text = item.Text
		End Sub
	End Class
End Namespace