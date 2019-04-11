Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.Calendar.MultiMonthView
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()
			Me.SelectedControl = Me.radCalendar1

			Me.radCalendar1.HeaderWidth = 17
			Me.radCalendar1.HeaderHeight = 17
			Me.radRadioRows.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
		End Sub

		#Region "Event Handlers"
		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)
			Me.radCalendar1.AllowMultipleView = True
			Me.radCalendar1.MultiViewRows = 2
            Me.radCalendar1.MultiViewColumns = 2
            Me.radCalendar1.FocusedDate = DateTime.Now
		End Sub

		Private Sub radRadioRows_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles radRadioRows.ToggleStateChanged, radRadioCols.ToggleStateChanged
			If Me.radRadioRows.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radCalendar1.Orientation = Orientation.Horizontal
			End If

			If Me.radRadioCols.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radCalendar1.Orientation = Orientation.Vertical
			End If
		End Sub

		#End Region
	End Class
End Namespace