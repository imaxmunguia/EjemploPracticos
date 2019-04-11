Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.QuickStart.WinControls
Imports Telerik.Examples.WinControls.Editors.ComboBox

Namespace Telerik.Examples.WinControls.Buttons.DropDownButton
	Partial Public Class Form1
		Inherits EditorExampleBaseForm
		Private Const THEME As String = "ControlDefault"

		Public Sub New()
			InitializeComponent()
			SetTheme()
		End Sub

		Private Sub SetTheme()
			ThemeResolutionService.ApplyThemeToControlTree(Me, THEME)
			ThemeResolutionService.ApplyThemeToControlTree(Me.settingsPanel, THEME)
		End Sub
	End Class
End Namespace