Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports Telerik.QuickStart.WinControls
Imports System.Data.SqlClient

Namespace Telerik.Examples.WinControls.Calendar.SpecialDays
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()

			Me.radCalendar1.SpecialDays(0).Image = Me.imageList1.Images(0)
			Me.radCalendar1.SpecialDays(1).Image = Me.imageList1.Images(1)
			Me.radCalendar1.ShowFastNavigationButtons = False
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			ThemeResolutionService.ApplyThemeToControlTree(Me.settingsPanel, MainForm.DefaultTheme)
		End Sub
	End Class
End Namespace