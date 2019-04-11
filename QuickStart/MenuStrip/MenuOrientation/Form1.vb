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
Imports Telerik.WinControls
Imports Telerik.QuickStart.WinControls

Namespace Telerik.Examples.WinControls.MenuStrip.MenuOrientation
	Partial Public Class Form1
		Inherits ExamplesForm
		Private oldSize As Size = Size.Empty
		Private oldLocation As New Point(26, 27)

		Public Sub New()
			InitializeComponent()

            Me.radButton1.ButtonElement.Padding = new Padding(4, 4, 4, 3)
            Me.radButton2.ButtonElement.Padding = new Padding(4, 4, 6, 4)

			MyBase.SetEnabledQsfbButton(QSFButtons.ChangeTheme, False)

			Me.SelectedControl = Me.radMenu1
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			Me.radMenu1.BackColor = Color.Transparent
			ThemeResolutionService.ApplyThemeToControlTree(Me.settingsPanel, MainForm.DefaultTheme)
		End Sub

		Private Sub radButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButton1.Click
			If Me.radMenu1.MenuElement.Orientation = Orientation.Horizontal Then
				oldSize = Me.radMenu1.Size
				'this.radMenu1.MenuElement.MinSize = Size.Empty;
				Me.radMenu1.MenuElement.MinSize = Size.Empty
				Me.radMenu1.Orientation = System.Windows.Forms.Orientation.Vertical
				Me.radMenu1.Location = New Point(3, 108)
				Me.radButton1.ButtonElement.ImagePrimitiveAngleTransform = 90
			Else
				Me.radMenu1.Location = Me.oldLocation
				Me.radMenu1.MenuElement.MinSize = oldSize
				Me.radMenu1.Orientation = System.Windows.Forms.Orientation.Horizontal
				Me.radButton1.ButtonElement.ImagePrimitiveAngleTransform = 0
			End If
		End Sub

		Private Sub radButton2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButton2.Click
			If Me.radMenu1.MenuElement.TextOrientation = Orientation.Horizontal Then
				Me.radMenu1.MenuElement.FlipText = True
				Me.radMenu1.MenuElement.TextOrientation = Orientation.Vertical
				Me.radButton2.ButtonElement.ImagePrimitiveAngleTransform = 90
			Else
				Me.radMenu1.MenuElement.FlipText = False

				Me.radMenu1.MenuElement.TextOrientation = Orientation.Horizontal
				Me.radButton2.ButtonElement.ImagePrimitiveAngleTransform = 0
			End If
		End Sub
	End Class
End Namespace