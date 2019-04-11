Imports Microsoft.VisualBasic
Imports System
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.Calendar.ReadOnly
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()
			SetTheme()
			Me.SelectedControl = Me.radCalendar1
			Me.radCheckReadOnly.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
		End Sub

		Private Sub SetTheme()
			ThemeResolutionService.ApplyThemeToControlTree(Me, "ControlDefault")
		End Sub

		Private Sub radCheckReadOnly_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles radCheckReadOnly.ToggleStateChanged
			Me.radCalendar1.ReadOnly = Me.radCheckReadOnly.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
		End Sub
	End Class
End Namespace