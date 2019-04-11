Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.Examples.WinControls.Editors.ComboBox
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.RadDesktopAlert.FirstLook
	Partial Public Class Form1
		Inherits EditorExampleBaseForm
		Public Sub New()
			InitializeComponent()
		End Sub

		#Region "Overrides"

		Protected Overrides Function IsFadeAnimationEnabled() As Boolean
			Return False
		End Function

		Protected Overrides Function GetExampleDefaultTheme() As String
			Return "ControlDefault"
		End Function

		#End Region

		#Region "Event handling"

		Private Sub OnThemesList_IndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles ddThemeName.SelectedIndexChanged
			Me.radDesktopAlert1.ThemeName = Me.ddThemeName.SelectedItem.Text
		End Sub

		Private Sub OnPositionList_IndexChaned(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles ddScreenPosition.SelectedIndexChanged
			Me.radDesktopAlert1.ScreenPosition = CType(System.Enum.Parse(GetType(AlertScreenPosition), Me.ddScreenPosition.SelectedItem.Text), AlertScreenPosition)
		End Sub

		Private Sub SpinEditorWidth_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles spinEditorWidth.ValueChanged
			Me.radDesktopAlert1.FixedSize = New Size(CInt(Fix(Me.spinEditorWidth.Value)), CInt(Fix(Me.spinEditorHeight.Value)))
		End Sub
		Private Sub SpinEditorHeight_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles spinEditorHeight.ValueChanged
			Me.radDesktopAlert1.FixedSize = New Size(CInt(Fix(Me.spinEditorWidth.Value)), CInt(Fix(Me.spinEditorHeight.Value)))
		End Sub

		Private Sub fadeInCheck_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles fadeInCheck.ToggleStateChanged
			If Me.fadeInCheck.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radDesktopAlert1.FadeAnimationType = Me.radDesktopAlert1.FadeAnimationType Or FadeAnimationType.FadeIn
			Else
				Me.radDesktopAlert1.FadeAnimationType = Me.radDesktopAlert1.FadeAnimationType And Not FadeAnimationType.FadeIn
			End If
		End Sub

		Private Sub fadeOutCheck_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles fadeOutCheck.ToggleStateChanged
			If Me.fadeOutCheck.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radDesktopAlert1.FadeAnimationType = Me.radDesktopAlert1.FadeAnimationType Or FadeAnimationType.FadeOut
			Else
				Me.radDesktopAlert1.FadeAnimationType = (Me.radDesktopAlert1.FadeAnimationType And (Not FadeAnimationType.FadeOut))
			End If
		End Sub

		Private Sub spinFadeDuration_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles spinFadeDuration.ValueChanged
			Me.radDesktopAlert1.FadeAnimationFrames = CInt(Fix(Me.spinFadeDuration.Value))
		End Sub

		Private Sub autoCloseCheck_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles autoCloseCheck.ToggleStateChanged
			Me.radDesktopAlert1.AutoClose = Me.autoCloseCheck.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
		End Sub

		Private Sub closeButtonCheck_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles closeButtonCheck.ToggleStateChanged
			Me.radDesktopAlert1.ShowCloseButton = args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
		End Sub

		Private Sub pinButtonCheck_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles pinButtonCheck.ToggleStateChanged
			Me.radDesktopAlert1.ShowPinButton = args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
		End Sub

		Private Sub optionsButtonCheck_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles optionsButtonCheck.ToggleStateChanged
			Me.radDesktopAlert1.ShowOptionsButton = args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
		End Sub

		Private Sub checkPopupAnimation_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles checkPopupAnimation.ToggleStateChanged
			Me.radDesktopAlert1.PopupAnimation = args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
		End Sub

		Private Sub ddAnimationDirection_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles ddAnimationDirection.SelectedIndexChanged
			Me.radDesktopAlert1.PopupAnimationDirection = CType(System.Enum.Parse(GetType(RadDirection), Me.ddAnimationDirection.SelectedItem.Text), RadDirection)
		End Sub

		Private Sub spinPopupAnimationFrames_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles spinPopupAnimationFrames.ValueChanged
			Me.radDesktopAlert1.PopupAnimationFrames = CInt(Fix(Me.spinPopupAnimationFrames.Value))
		End Sub

		Private Sub btnPreview_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPreview.Click
			Me.radDesktopAlert1.CaptionText = Me.txtCaption.Text
			Me.radDesktopAlert1.ContentText = Me.txtContent.Text
			Me.radDesktopAlert1.Show()
		End Sub

		Private Sub SpinOpacity_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles spinOpacity.ValueChanged
			Me.radDesktopAlert1.Opacity = CSng(Me.spinOpacity.Value)
		End Sub

		Private Sub autoCloseDelaySpin_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles autoCloseDelaySpin.ValueChanged
			Me.radDesktopAlert1.AutoCloseDelay = CInt(Fix(Me.autoCloseDelaySpin.Value))
		End Sub

		#End Region
	End Class
End Namespace
