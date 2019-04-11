Imports Microsoft.VisualBasic
Imports System.Drawing
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.Calendar.LayoutCustomization
	Partial Public Class Form1
		Inherits ExamplesForm
		Private defaultSize As Size

		Public Sub New()
			InitializeComponent()
			SetTheme()
			Me.defaultSize = Me.radCalendar1.Size
			Me.radRadio7Cols.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
		End Sub

		Private Sub SetTheme()
			ThemeResolutionService.ApplyThemeToControlTree(Me, "ControlDefault")
		End Sub

		Private Sub CenterCalendar()
			Me.radCalendar1.Location = New Point(Me.Width \ 2 - Me.radCalendar1.Width / 2, Me.Height \ 2 - Me.radCalendar1.Height / 2)
		End Sub

		#Region "Event Handlers"
		Private Sub radRadioButton1_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles radRadio7Cols.ToggleStateChanged, radRadio21Cols.ToggleStateChanged, radRadio14Cols.ToggleStateChanged
			If Me.radRadio7Cols.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radCalendar1.MonthLayout = Telerik.WinControls.UI.MonthLayout.Layout_7columns_x_6rows
				Me.radCalendar1.Size = Me.defaultSize
			End If

			If Me.radRadio14Cols.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radCalendar1.MonthLayout = Telerik.WinControls.UI.MonthLayout.Layout_14columns_x_3rows
				Me.radCalendar1.Size = New Size(Me.defaultSize.Width * 2, Me.defaultSize.Height / 2 + 20)
			End If

			If Me.radRadio21Cols.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radCalendar1.MonthLayout = Telerik.WinControls.UI.MonthLayout.Layout_21columns_x_2rows
				Me.radCalendar1.Size = New Size(Me.defaultSize.Width * 3, Me.defaultSize.Height / 2 + 10)
			End If

			CenterCalendar()
		End Sub
		#End Region
	End Class
End Namespace