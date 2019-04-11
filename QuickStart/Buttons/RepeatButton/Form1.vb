Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.Examples.WinControls.Editors.ComboBox

Namespace Telerik.Examples.WinControls.Buttons.RepeatButton
	''' <summary>
	''' Main class for the repeat button example
	''' </summary>
	Partial Public Class Form1
		Inherits EditorExampleBaseForm
		Public Sub New()
			InitializeComponent()
			SetTheme()
			Me.radProgressBar1.Text = ""
		End Sub

		Private Sub SetTheme()
			Me.radProgressBar1.ThemeName = "ControlDefault"
			Me.radRepeatButton3.ThemeName = "ControlDefault"
		End Sub

		Private Sub radRepeatButton3_ButtonClick(ByVal sender As Object, ByVal e As EventArgs) Handles radRepeatButton3.ButtonClick
			If Me.radProgressBar1.Value1 < Me.radProgressBar1.Maximum Then
				Me.radProgressBar1.Value1 += 1
			Else
				Me.radProgressBar1.Value1 = Me.radProgressBar1.Minimum
			End If
		End Sub
	End Class
End Namespace