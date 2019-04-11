Imports Microsoft.VisualBasic
Imports System
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.MenuStrip.Office2007
	Partial Public Class Form1
		Inherits ExamplesForm
		Private Const THEME As String = "ControlDefault"

		Public Sub New()
			InitializeComponent()

			Me.radMenuItem4.ShowArrow = True
			Me.radMenuItem5.ShowArrow = True
			Me.radMenuItem6.ShowArrow = True
			Me.radMenuItem7.ShowArrow = True
			Me.radMenuItem8.ShowArrow = True

			ThemeResolutionService.ApplyThemeToControlTree(Me, THEME)
			Me.SetEnabledQsfbButton(QSFButtons.ChangeTheme, False)
		End Sub
	End Class
End Namespace