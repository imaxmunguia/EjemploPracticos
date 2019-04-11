Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.WinControls.UI
Imports Telerik.QuickStart.WinControls
Imports Telerik.Examples.WinControls.Editors.ComboBox

Namespace Telerik.Examples.WinControls.Buttons.FirstLook
	Partial Public Class Form1
		Inherits EditorExampleBaseForm
		Public Sub New()
			InitializeComponent()
			SetTheme()
			Me.radRadioImgBeforeTxt.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			Me.radButton1.DisplayStyle = Telerik.WinControls.DisplayStyle.Text
		End Sub

		Private Sub SetTheme()
			Me.radButton1.ThemeName = "ControlDefault"
			Me.radButton2.ThemeName = "ControlDefault"
			Me.radButton3.ThemeName = "ControlDefault"
			Me.groupBox1.ThemeName = "ControlDefault"

			Me.radRadioImgAboveTxt.ThemeName = "ControlDefault"
			Me.radRadioImgBeforeTxt.ThemeName = "ControlDefault"
			Me.radRadioOverlay.ThemeName = "ControlDefault"
			Me.radRadioTxtAboveImg.ThemeName = "ControlDefault"
			Me.radRadioTxtBeforeImg.ThemeName = "ControlDefault"
		End Sub

		Private Sub radRadioImgAboveTxt_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles radRadioOverlay.ToggleStateChanged, radRadioTxtBeforeImg.ToggleStateChanged, radRadioTxtAboveImg.ToggleStateChanged, radRadioImgBeforeTxt.ToggleStateChanged
			If Me.radRadioImgAboveTxt.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				radButton3.TextImageRelation = TextImageRelation.ImageAboveText
			End If

			If Me.radRadioImgBeforeTxt.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				radButton3.TextImageRelation = TextImageRelation.ImageBeforeText
			End If

			If Me.radRadioTxtAboveImg.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				radButton3.TextImageRelation = TextImageRelation.TextAboveImage
			End If

			If Me.radRadioTxtBeforeImg.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				radButton3.TextImageRelation = TextImageRelation.TextBeforeImage
			End If

			If Me.radRadioOverlay.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				radButton3.TextImageRelation = TextImageRelation.Overlay
			End If
		End Sub

		Private Sub groupBox1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles groupBox1.Click

		End Sub
	End Class
End Namespace