Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.Calendar.FirstLook
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()
			Me.SelectedControl = Me.radCalendar1
			Me.radioButton16.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			Me.SetEnabledQsfbButton(QSFButtons.ChangeTheme, False)
			Me.radCalendar1.ShowFooter = False
			SetTheme()
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			ThemeResolutionService.ApplyThemeToControlTree(Me.settingsPanel, MainForm.DefaultTheme)
		End Sub

		Private Sub SetTheme()
			Me.radCalendar1.ThemeName = "Scheduler"
			Me.radCalendar1.CellAlign = ContentAlignment.TopLeft
		End Sub

		#Region "Event Handlers"

		Private Sub chRowHeader_Click(ByVal sender As Object, ByVal e As EventArgs) Handles chRowHeader.Click
			Me.radCalendar1.ShowRowHeaders = Not(Me.chRowHeader.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On)
		End Sub

		Private Sub chColumnHeader_Click(ByVal sender As Object, ByVal e As EventArgs) Handles chColumnHeader.Click
			Me.radCalendar1.ShowColumnHeaders = Not(Me.chColumnHeader.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On)
		End Sub

		Private Sub chShowSelector_Click(ByVal sender As Object, ByVal e As EventArgs) Handles chShowSelector.Click
			Me.radCalendar1.ShowViewSelector = Not(Me.chShowSelector.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On)
		End Sub

		Private Sub chNavigationButtons_Click(ByVal sender As Object, ByVal e As EventArgs) Handles chNavigationButtons.Click
			Me.radCalendar1.ShowNavigationButtons = Not(Me.chNavigationButtons.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On)
		End Sub

		Private Sub chFastNavigationButtons_Click(ByVal sender As Object, ByVal e As EventArgs) Handles chFastNavigationButtons.Click
			Me.radCalendar1.ShowFastNavigationButtons = Not(Me.chFastNavigationButtons.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On)
		End Sub

		Private Sub chViewHeader_Click(ByVal sender As Object, ByVal e As EventArgs) Handles chViewHeader.Click
			Me.radCalendar1.ShowViewHeader = Not(Me.chViewHeader.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On)
		End Sub

		Private Sub chAllowFishEye_Click(ByVal sender As Object, ByVal e As EventArgs) Handles chAllowFishEye.Click
			Me.radCalendar1.AllowFishEye = Not(Me.chAllowFishEye.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On)
		End Sub

		Private Sub nudHeaderWidth_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles nudHeaderWidth.ValueChanged
			Me.radCalendar1.HeaderWidth = CInt(Fix(Me.nudHeaderWidth.Value))
		End Sub

		Private Sub nudHeaderHeight_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles nudHeaderHeight.ValueChanged
			Me.radCalendar1.HeaderHeight = CInt(Fix(Me.nudHeaderHeight.Value))
		End Sub

		Private Sub cbTitleFormat_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles cbTitleFormat.SelectedIndexChanged
			Me.radCalendar1.TitleFormat = Me.cbTitleFormat.Items(Me.cbTitleFormat.SelectedIndex).Text
		End Sub

		Private Sub radCheckBox2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radCheckBox2.Click
			Me.radCalendar1.ShowHeader = Not(Me.radCheckBox2.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On)
		End Sub

		Private Sub radCheckBox3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radCheckBox3.Click
			Dim rightToLeft As Boolean = Not(Me.radCheckBox3.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On)

			If rightToLeft Then
				Me.radCalendar1.RightToLeft = Me.RightToLeft.Yes
			Else
				Me.radCalendar1.RightToLeft = Me.RightToLeft.No
			End If
		End Sub

		Private Sub radioButton16_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles radioButton16.ToggleStateChanged
			If Me.radioButton16.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radCalendar1.Orientation = Orientation.Horizontal
			End If
		End Sub

		Private Sub radioButton15_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles radioButton15.ToggleStateChanged
			If Me.radioButton15.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radCalendar1.Orientation = Orientation.Vertical
			End If
		End Sub
		#End Region
	End Class
End Namespace