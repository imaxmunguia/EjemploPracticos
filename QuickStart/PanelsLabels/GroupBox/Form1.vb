Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls

Namespace Telerik.Examples.WinControls.PanelsLabels.GroupBox
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()
			Me.SetEnabledQsfbButton(QSFButtons.ChangeTheme, True)
			Me.SetEnabledQsfbButton(QSFButtons.TransparentBackground, True)
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)
			Me.radRadioButton2.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			Me.radRadioButton8.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			Me.radRadioButton3.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
		End Sub

		Private Sub radRadioButton2_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles radRadioButton2.ToggleStateChanged
			If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radGroupBox1.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Standard
			End If
		End Sub

		Private Sub radRadioButton1_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles radRadioButton1.ToggleStateChanged
			If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radGroupBox1.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office
			End If
		End Sub

		Private Sub radRadioButton3_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles radRadioButton3.ToggleStateChanged
			If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radGroupBox1.HeaderPosition = Telerik.WinControls.UI.HeaderPosition.Top
			End If
		End Sub

		Private Sub radRadioButton4_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles radRadioButton4.ToggleStateChanged
			If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radGroupBox1.HeaderPosition = Telerik.WinControls.UI.HeaderPosition.Right
			End If
		End Sub

		Private Sub radRadioButton5_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles radRadioButton5.ToggleStateChanged
			If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radGroupBox1.HeaderPosition = Telerik.WinControls.UI.HeaderPosition.Bottom
			End If
		End Sub

		Private Sub radRadioButton6_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles radRadioButton6.ToggleStateChanged
			If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radGroupBox1.HeaderPosition = Telerik.WinControls.UI.HeaderPosition.Left
			End If
		End Sub

		Private Sub radRadioButton7_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles radRadioButton7.ToggleStateChanged
			If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radGroupBox1.HeaderTextImageRelation = TextImageRelation.ImageAboveText
			End If
		End Sub

		Private Sub radRadioButton8_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles radRadioButton8.ToggleStateChanged
			If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radGroupBox1.HeaderTextImageRelation = TextImageRelation.ImageBeforeText
			End If
		End Sub

		Private Sub radRadioButton9_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles radRadioButton9.ToggleStateChanged
			If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radGroupBox1.HeaderTextImageRelation = TextImageRelation.Overlay
			End If
		End Sub

		Private Sub radRadioButton10_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles radRadioButton10.ToggleStateChanged
			If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radGroupBox1.HeaderTextImageRelation = TextImageRelation.TextAboveImage
			End If
		End Sub

		Private Sub radRadioButton11_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles radRadioButton11.ToggleStateChanged
			If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radGroupBox1.HeaderTextImageRelation = TextImageRelation.TextBeforeImage
			End If
		End Sub 
	End Class
End Namespace
