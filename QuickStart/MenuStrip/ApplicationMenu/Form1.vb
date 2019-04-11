Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.MenuStrip.ApplicationMenu
	Partial Public Class Form1
		Inherits ExamplesForm
		Private Const THEME As String = "ControlDefault"
		Private showDropDownTimeout As Timer

		Public Sub New()
			InitializeComponent()
			Me.SelectedControl = Me.radAppMenuDemo
			ThemeResolutionService.ApplyThemeToControlTree(Me, THEME)
			Me.showDropDownTimeout = New Timer()
			AddHandler showDropDownTimeout.Tick, AddressOf showDropDownTimeout_Tick
			Me.showDropDownTimeout.Interval = 1000
			Me.SetEnabledQsfbButton(QSFButtons.ChangeTheme, False)
		End Sub

		Private Sub showDropDownTimeout_Tick(ByVal sender As Object, ByVal e As EventArgs)
			If (Not Me.IsDisposed) AndAlso (Not Me.radAppMenuDemo.IsDisposed) Then
				Me.showDropDownTimeout.Stop()
				Me.radAppMenuDemo.Focus()
				Me.radAppMenuDemo.ShowDropDown()

			Else
				Me.showDropDownTimeout.Stop()
			End If
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)
			Me.showDropDownTimeout.Start()
			For Each item As RadMenuItemBase In Me.radAppMenuDemo.Items
				If TypeOf item Is RadMenuItem Then
					CType(item, RadMenuItem).Layout.Margin = New Padding(-3)
				End If
			Next item

		End Sub
	End Class
End Namespace
