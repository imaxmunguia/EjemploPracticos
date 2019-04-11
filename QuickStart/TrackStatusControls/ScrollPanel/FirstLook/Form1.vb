Imports Microsoft.VisualBasic
Imports System
Imports Telerik.WinControls.UI
Imports Telerik.QuickStart.WinControls

Namespace Telerik.Examples.WinControls.TrackStatusControls.ScrollPanel.FirstLook
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()

			Me.SelectedControl = Me.radScrollPanelDemo
			Me.EnabledQSFButtons = QSFButtons.LoadTheme Or QSFButtons.ControlSpy
		End Sub

		Private Sub SetHorizontalState(ByVal newState As ScrollState)
			radScrollPanelDemo.SetHorizontalState(newState)
		End Sub

		Private Sub SetVerticalState(ByVal newState As ScrollState)
			radScrollPanelDemo.SetVerticalState(newState)
		End Sub

		Private Sub radComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles radComboBox1.SelectedIndexChanged
			Me.radScrollPanelDemo.UsePhysicalScrolling = Me.radComboBox1.SelectedIndex = 1
		End Sub

		Private Sub radButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButton1.Click
			radScrollPanelDemo.ManageSquare()
		End Sub

		Private Sub radButton2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButton2.Click
			radScrollPanelDemo.ManageTriangle()
		End Sub

		Private Sub radButton3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButton3.Click
			radScrollPanelDemo.ManageBackground()
		End Sub

		Private Sub radButton4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButton4.Click
			radScrollPanelDemo.ScrollToSquare()
		End Sub

		Private Sub radButton5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButton5.Click
			radScrollPanelDemo.ScrollToTriangle()
		End Sub

		Private Sub OnHorizontalRadioOption_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles radRadioHAutoHide.ToggleStateChanged, radRadioHAlwaysHide.ToggleStateChanged, radRadioHAlwaysShow.ToggleStateChanged
			If Me.radRadioHAlwaysHide.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				SetHorizontalState(ScrollState.AlwaysHide)
			ElseIf Me.radRadioHAlwaysShow.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				SetHorizontalState(ScrollState.AlwaysShow)
			ElseIf Me.radRadioHAutoHide.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				SetHorizontalState(ScrollState.AutoHide)
			End If
		End Sub

		Private Sub OnVerticalRadioOption_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles radRadioVAutoHide.ToggleStateChanged, radRadioVAlwaysHide.ToggleStateChanged, radRadioVAlwaysShow.ToggleStateChanged
			If Me.radRadioVAlwaysHide.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				SetVerticalState(ScrollState.AlwaysHide)
			ElseIf Me.radRadioVAlwaysShow.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				SetVerticalState(ScrollState.AlwaysShow)
			ElseIf Me.radRadioVAutoHide.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				SetVerticalState(ScrollState.AutoHide)
			End If
		End Sub
	End Class
End Namespace