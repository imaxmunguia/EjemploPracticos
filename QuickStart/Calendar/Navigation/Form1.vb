Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.Calendar.Navigation
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()
			SetTheme()
			Me.radCalendar1.MultiViewColumns = 1
			Me.radCalendar1.MultiViewColumns = 2

			Me.SelectedControl = Me.radCalendar1

			Me.radCalendar1.RangeMinDate = Me.radDateTimePicker1.Value
            Me.radCalendar1.RangeMaxDate = Me.radDateTimePicker2.Value
            Me.radDateTimePicker3.Value = DateTime.Now
		End Sub

		Private Sub SetTheme()
			ThemeResolutionService.ApplyThemeToControlTree(Me, "ControlDefault")
			Me.radSpinNavigationStep.ForeColor = Color.Black
		End Sub

		Private Sub radCheckBox1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radCheckBox1.Click
			Me.radCalendar1.ShowNavigationButtons = Not(Me.radCheckBox1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On)
		End Sub

		Private Sub radCheckBox2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radCheckBox2.Click
			Me.radCalendar1.ShowFastNavigationButtons = Not(Me.radCheckBox2.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On)
		End Sub

		Private Sub radCheckBox3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radCheckBox3.Click
			Me.radCalendar1.ShowHeader = Not(Me.radCheckBox3.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On)
		End Sub

		Private Sub radDateTimePicker1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radDateTimePicker1.ValueChanged
			Me.radCalendar1.RangeMinDate = Me.radDateTimePicker1.Value
		End Sub

		Private Sub radDateTimePicker2_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radDateTimePicker2.ValueChanged
			Me.radCalendar1.RangeMaxDate = Me.radDateTimePicker2.Value
		End Sub

		Private Sub radDateTimePicker3_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radDateTimePicker3.ValueChanged
			Me.radCalendar1.FocusedDate = Me.radDateTimePicker3.Value
		End Sub

		Private Sub radSpinNavigationStep_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radSpinNavigationStep.ValueChanged
			Me.radCalendar1.FastNavigationStep = CInt(Fix(Me.radSpinNavigationStep.Value))
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Me.radCalendar1.RangeMinDate = Me.radDateTimePicker1.Value
			Me.radCalendar1.RangeMaxDate = Me.radDateTimePicker2.Value
		End Sub
	End Class
End Namespace