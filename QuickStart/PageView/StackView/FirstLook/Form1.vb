Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.PageView.StackView.FirstLook
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()
			Me.SetEnabledQsfbButton(QSFButtons.ChangeTheme Or QSFButtons.TransparentBackground, False)
			Me.radioPositionBottom.Tag = StackViewPosition.Bottom
			Me.radioPositionTop.Tag = StackViewPosition.Top
			Me.radioPositionLeft.Tag = StackViewPosition.Left
			Me.radioPositionRight.Tag = StackViewPosition.Right
			Me.radioContentWithSelected.Tag = StackViewItemSelectionMode.ContentWithSelected
			Me.radioContentAfterSelected.Tag = StackViewItemSelectionMode.ContentAfterSelected
			Me.radioStandard.Tag = StackViewItemSelectionMode.Standard

			Me.radSpinEditor1.Value = 1

			Me.radioPositionBottom.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			Me.radioStandard.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			Me.showHeaderCheck.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
		End Sub

		Protected Overrides Function GetExampleDefaultTheme() As String
			Return "ControlDefault"
		End Function

		Private Sub OnRadioSelectionSetting_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles radioContentAfterSelected.ToggleStateChanged, radioContentWithSelected.ToggleStateChanged, radioStandard.ToggleStateChanged
			Dim radioButton As RadRadioButton = TryCast(sender, RadRadioButton)
			If radioButton.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				TryCast(Me.pageView1.ViewElement, RadPageViewStackElement).ItemSelectionMode = CType(radioButton.Tag, StackViewItemSelectionMode)
			End If
		End Sub

		Private Sub OnRadioStackPositionSetting_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles radioPositionRight.ToggleStateChanged, radioPositionLeft.ToggleStateChanged, radioPositionBottom.ToggleStateChanged, radioPositionTop.ToggleStateChanged
			Dim radioButton As RadRadioButton = TryCast(sender, RadRadioButton)
			If radioButton.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				TryCast(Me.pageView1.ViewElement, RadPageViewStackElement).StackPosition = CType(radioButton.Tag, StackViewPosition)
			End If
		End Sub

		Private Sub OnShowHeader_Checked(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles showHeaderCheck.ToggleStateChanged
			Me.pageView1.ViewElement.Header.Visibility = If(Me.showHeaderCheck.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On, ElementVisibility.Visible, ElementVisibility.Collapsed)
		End Sub

		Private Sub OnShowFooter_Checked(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles showFooterCheck.ToggleStateChanged
			Me.pageView1.ViewElement.Footer.Visibility = If(Me.showFooterCheck.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On, ElementVisibility.Visible, ElementVisibility.Collapsed)
		End Sub

		Private Sub OnItemSpacing_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radSpinEditor1.ValueChanged
			Me.pageView1.ViewElement.ItemSpacing = CInt(Fix(Me.radSpinEditor1.Value))
		End Sub
	End Class
End Namespace
