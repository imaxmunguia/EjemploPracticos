Imports Microsoft.VisualBasic
Imports System
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.Themes

Namespace Telerik.Examples.WinControls.Forms.RadAboutBox
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()
			AddHandler radButton1.Click, AddressOf radButton1_Click
		End Sub

		Private Sub radButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim aboutBox As New RadAboutBox1()

			Dim selectedTheme As String = "ControlDefault"
			If Me.radRadioButton2.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
                Dim TempOffice2007SilverTheme As Office2010SilverTheme = New Office2010SilverTheme()
                selectedTheme = "Office2010Silver"
			ElseIf Me.radRadioButton3.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
                Dim TempOffice2007BlackTheme As Office2010BlackTheme = New Office2010BlackTheme()
                selectedTheme = "Office2010Black"
			ElseIf Me.radRadioButton4.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
                Dim TempAquaTheme As Office2010BlueTheme = New Office2010BlueTheme()
                selectedTheme = "Office2010Blue"
			ElseIf Me.radRadioButton5.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				selectedTheme = "Desert"
			End If

			aboutBox.ThemeName = selectedTheme
			aboutBox.ShowDialog(Me)
		End Sub
	End Class
End Namespace
