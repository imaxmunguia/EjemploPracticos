Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.WinControls.Themes.Design
Imports Telerik.WinControls.UI
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.WinControls.Primitives

Namespace Telerik.Examples.WinControls.MenuStrip.FirstLook
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()

			MyBase.SetEnabledQsfbButton(QSFButtons.ChangeTheme, False)
			Me.radMenu1.MenuElement.MenuBorder.Visibility = ElementVisibility.Hidden
			Me.SelectedControl = radMenu1
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			ThemeResolutionService.ApplyThemeToControlTree(Me.settingsPanel, MainForm.DefaultTheme)
		End Sub

		Private Sub radMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radMenuItem17.Click, radMenuItem18.Click, radMenuItem22.Click, radMenuItem1_1.Click, radMenuItem2_1.Click, radMenuItem2_2.Click, radMenuItem2_3.Click, radMenuItem2_4.Click, radMenuItem2_5.Click, radMenuItem4_1.Click, radMenuItem4_2.Click, radMenuItem5_1.Click, radMenuItem1_3.Click, radMenuItem1_4.Click, radMenuItem1_5.Click, radMenuItem1_6.Click, radMenuItem1_7.Click, radMenuItem1_8.Click, radMenuItem2_6.Click, radMenuItem2_7.Click, radMenuItem3_1.Click, radMenuItem3_2.Click, radMenuItem3_3.Click, radMenuItem4_3.Click, radMenuItem5_2.Click, radMenuItem6_1.Click, radMenuItem6_2.Click
			MessageBox.Show("The Menu item '" & (TryCast(sender, RadMenuItemBase)).Text & "' is clicked.")
		End Sub

		Private selectedButton As RadButtonElement = Nothing
		Private oldBorderColor As Color = Color.FromArgb(115, 146, 189)

		Private Sub radButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButton1.Click, radButton2.Click, radButton3.Click, radButton4.Click
			Dim selector As New ClassSelector("ButtonBorder")
			Dim border As BorderPrimitive

			If Me.selectedButton IsNot Nothing Then
				border = CType(selector.GetSelectedElements(Me.selectedButton).First.Value, BorderPrimitive)
				border.ForeColor = Me.oldBorderColor
			End If

			Me.selectedButton = (TryCast(sender, RadButton)).ButtonElement

			border = CType(selector.GetSelectedElements(Me.selectedButton).First.Value, BorderPrimitive)
			border.ForeColor = Color.Red

			Me.menuBurn.Enabled = True
			Me.menuEmail.Enabled = True
			Me.menuOpenWidth.Enabled = True
			Me.menuPrint.Enabled = True
		End Sub
	End Class
End Namespace