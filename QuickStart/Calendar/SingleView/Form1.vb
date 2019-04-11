Imports Microsoft.VisualBasic
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.Calendar.SingleView
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()
			SetTheme()
			Me.SelectedControl = Me.radCalendar1
			Me.radRadioRows.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
		End Sub

		Private Sub SetTheme()
			ThemeResolutionService.ApplyThemeToControlTree(Me, "ControlDefault")
		End Sub

		Private Sub radRadioRows_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles radRadioRows.ToggleStateChanged, radRadioCols.ToggleStateChanged
			If Me.radRadioRows.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radCalendar1.Orientation = Orientation.Horizontal
			End If

			If Me.radRadioCols.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radCalendar1.Orientation = Orientation.Vertical
			End If
		End Sub
	End Class
End Namespace