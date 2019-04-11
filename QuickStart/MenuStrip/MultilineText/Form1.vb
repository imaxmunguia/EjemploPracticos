Imports Microsoft.VisualBasic
Imports System.Drawing
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.MenuStrip.MultilineText
	Partial Public Class Form1
		Inherits ExamplesForm
		Private Const THEME As String = "ControlDefault"

		Private oldSize As Size = Size.Empty

		Public Sub New()
			InitializeComponent()
			ThemeResolutionService.ApplyThemeToControlTree(Me, THEME)
			Me.SetEnabledQsfbButton(QSFButtons.ChangeTheme, False)
		End Sub

	End Class
End Namespace