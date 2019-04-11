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

Namespace Telerik.Examples.WinControls.CommandBar.TextPad
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)
			Me.radCommandBar1.ThemeName = "ControlDefault"

			Dim parent As Control = If( not Me.Parent is Nothing, Me.Parent, Me)
			Me.panel1.Location = New Point((parent.Width - Me.panel1.Width) /2, (parent.Height - Me.panel1.Height)/2)

		End Sub

		Private Sub alignment_ToggleStateChanging(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangingEventArgs) Handles radCommandBarToggleButtonItem4.ToggleStateChanging, radCommandBarToggleButtonItem5.ToggleStateChanging, radCommandBarToggleButtonItem6.ToggleStateChanging, radCommandBarToggleButtonItem7.ToggleStateChanging
			Dim senderButton As CommandBarToggleButton = (TryCast(sender, CommandBarToggleButton))

			If args.NewValue = Telerik.WinControls.Enumerations.ToggleState.Off Then
				Return
			End If

			If senderButton IsNot radCommandBarToggleButtonItem4 Then
				radCommandBarToggleButtonItem4.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			End If

			If senderButton IsNot radCommandBarToggleButtonItem5 Then
				radCommandBarToggleButtonItem5.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			End If

			If senderButton IsNot radCommandBarToggleButtonItem6 Then
				radCommandBarToggleButtonItem6.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			End If

			If senderButton IsNot radCommandBarToggleButtonItem7 Then
				radCommandBarToggleButtonItem7.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			End If
		End Sub
	End Class
End Namespace
