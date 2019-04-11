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
Imports Telerik.WinControls.Enumerations

Namespace Telerik.Examples.WinControls.Buttons.ToggleButton
	''' <summary>
	''' Main class for the toggle button example
	''' </summary>
	Partial Public Class Form1
		Inherits EditorExampleBaseForm
		Public Sub New()
			InitializeComponent()
			SetTheme()
		End Sub

		Private Sub SetTheme()
			Me.radToggleButton6.ThemeName = "ControlDefault"
		End Sub

		Private Sub radToggleButton6_ToggleStateChanging(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangingEventArgs) Handles radToggleButton6.ToggleStateChanging
			If Not(radToggleButton6.ToggleState = ToggleState.On) Then
				radToggleButton6.ImageIndex = 4
				label1.Text = "Button Toggled On"
			Else
				radToggleButton6.ImageIndex = 3
				label1.Text = "Button Toggled Off"
			End If
		End Sub
	End Class
End Namespace