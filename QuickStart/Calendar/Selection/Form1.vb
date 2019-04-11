Imports Microsoft.VisualBasic
Imports System
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.Calendar.Selection
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()
			SetUpCalendar()
			SetTheme()

			Me.radCalendar1.FocusedDate = DateTime.Now
			Me.radRadioAllowSelectEnable.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			Me.radRadioMultiSelectEnable.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			Me.radRadioEnableAllowViewSelectorEnable.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			Me.radRadioShowRowHeaderEnable.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			Me.radRadioColumnHeaderEnable.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			Me.radRadioAllowRowHeaderEnable.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			Me.radRadioAllowColumnHeaderEnable.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
		End Sub

		Private Sub SetTheme()
			ThemeResolutionService.ApplyThemeToControlTree(Me, "ControlDefault")
		End Sub

		Private Sub SetUpCalendar()
			Me.SelectedControl = Me.radCalendar1
			Me.radCalendar1.AllowColumnHeaderSelectors = True
			Me.radCalendar1.AllowRowHeaderSelectors = True
			Me.radCalendar1.AllowViewSelector = True
			Me.radCalendar1.AllowMultipleSelect = True
		End Sub

		#Region "Event Handlers"

		Private Sub radRadioAllowSelectEnable_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles radRadioAllowSelectEnable.ToggleStateChanged, radRadioAllowSelectDisable.ToggleStateChanged
			If Me.radRadioAllowSelectEnable.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radCalendar1.AllowSelect = True
			End If

			If Me.radRadioAllowSelectDisable.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radCalendar1.AllowSelect = False
			End If
		End Sub

		Private Sub radRadioMultiSelectEnable_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles radRadioMultiSelectEnable.ToggleStateChanged, radRadioMultiSelectDisable.ToggleStateChanged
			If Me.radRadioMultiSelectEnable.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radCalendar1.AllowMultipleSelect = True
			End If

			If Me.radRadioMultiSelectDisable.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radCalendar1.AllowMultipleSelect = False
			End If
		End Sub

		Private Sub radRadioEnableAllowViewSelectorEnable_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles radRadioEnableAllowViewSelectorEnable.ToggleStateChanged, radRadioEnableAllowViewSelectorDisable.ToggleStateChanged
			If Me.radRadioEnableAllowViewSelectorEnable.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radCalendar1.AllowViewSelector = True
			End If

			If Me.radRadioEnableAllowViewSelectorDisable.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radCalendar1.AllowViewSelector = False
			End If
		End Sub

		Private Sub radRadioColumnHeaderEnable_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles radRadioColumnHeaderEnable.ToggleStateChanged, radRadioColumnHeaderDisable.ToggleStateChanged
			If Me.radRadioColumnHeaderEnable.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radCalendar1.ShowColumnHeaders = True
			End If

			If Me.radRadioColumnHeaderDisable.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radCalendar1.ShowColumnHeaders = False
			End If
		End Sub

		Private Sub radRadioRowHeaderEnable_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles radRadioShowRowHeaderEnable.ToggleStateChanged, radRadioShowRowHeaderDisable.ToggleStateChanged
			If Me.radRadioShowRowHeaderEnable.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radCalendar1.ShowRowHeaders = True
			End If

			If Me.radRadioShowRowHeaderDisable.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radCalendar1.ShowRowHeaders = False
			End If
		End Sub

		Private Sub radRadioAllowRowHeader_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles radRadioAllowRowHeaderEnable.ToggleStateChanged, radRadioAllowRowHeaderDisable.ToggleStateChanged
			If Me.radRadioAllowRowHeaderEnable.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radCalendar1.AllowRowHeaderSelectors = True
			End If

			If Me.radRadioAllowRowHeaderDisable.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radCalendar1.AllowRowHeaderSelectors = False
			End If
		End Sub

		Private Sub radRadioAllowColumnHeaderEnable_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles radRadioAllowColumnHeaderEnable.ToggleStateChanged, radRadioAllowColumnHeaderDisable.ToggleStateChanged
			If Me.radRadioAllowColumnHeaderEnable.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radCalendar1.AllowColumnHeaderSelectors = True
			End If

			If Me.radRadioAllowColumnHeaderDisable.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radCalendar1.AllowColumnHeaderSelectors = False
			End If
		End Sub

		Private Sub radButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButton1.Click
			If Me.radCalendar1.SelectedDates.Count > 0 Then
				Me.radCalendar1.SelectedDates.Clear()
			End If
		End Sub
		#End Region


	End Class
End Namespace