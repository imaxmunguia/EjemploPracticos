Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.Enumerations

Namespace Telerik.Examples.WinControls.Editors.RadColorSelector.FirstLook
	''' <summary>
	''' Color selector example form
	''' </summary>
	Partial Public Class Form1
		Inherits ExamplesForm
		Private Const THEME As String = "ControlDefault"

		Public Sub New()
			InitializeComponent()

			radColorSelector1.SelectedColor = Color.Red
			AddHandler radColorSelector1.OkButtonClicked, AddressOf radColorSelector1_OkButtonClicked
			AddHandler radColorSelector1.CancelButtonClicked, AddressOf radColorSelector1_CancelButtonClicked

			radCheckBox1.ToggleState = If(radColorSelector1.ShowBasicColors, ToggleState.On, ToggleState.Off)
			radCheckBox2.ToggleState = If(radColorSelector1.ShowSystemColors, ToggleState.On, ToggleState.Off)
			radCheckBox3.ToggleState = If(radColorSelector1.ShowWebColors, ToggleState.On, ToggleState.Off)
			radCheckBox4.ToggleState = If(radColorSelector1.ShowProfessionalColors, ToggleState.On, ToggleState.Off)

			radCheckBox5.ToggleState = If(radColorSelector1.ShowHEXColorValue, ToggleState.On, ToggleState.Off)
			radCheckBox6.ToggleState = If(radColorSelector1.ShowCustomColors, ToggleState.On, ToggleState.Off)
			radCheckBox7.ToggleState = If(radColorSelector1.AllowColorSaving, ToggleState.On, ToggleState.Off)
			radCheckBox8.ToggleState = If(radColorSelector1.AllowEditHEXValue, ToggleState.On, ToggleState.Off)
			radCheckBox9.ToggleState = If(radColorSelector1.AllowColorPickFromScreen, ToggleState.On, ToggleState.Off)

			radTextBox1.Text = radColorSelector1.SelectedColorLabelHeading
			radTextBox2.Text = radColorSelector1.OldColorLabelHeading
			radTextBox3.Text = radColorSelector1.AddNewColorButtonText

			Me.EnabledQSFButtons = QSFButtons.None

			ThemeResolutionService.ApplyThemeToControlTree(Me.radColorSelector1, THEME)
		End Sub

		Private Sub SetTheme()
			For i As Integer = 0 To Me.settingsPanel.Controls.Count - 1
				Dim currentControl As RadControl = TryCast(Me.settingsPanel.Controls(i), RadControl)

				If currentControl IsNot Nothing Then
					currentControl.ThemeName = THEME

					Me.SetTheme(currentControl)
				End If
			Next i
		End Sub

		Private Sub SetTheme(ByVal control As RadControl)
			control.ThemeName = THEME

			For i As Integer = 0 To control.Controls.Count - 1
				Dim currentControl As RadControl = TryCast(control.Controls(i), RadControl)

				If currentControl IsNot Nothing Then
					currentControl.ThemeName = THEME

					Me.SetTheme(currentControl)
				End If
			Next i
		End Sub


		Protected Overrides Sub OnLoad(ByVal e As EventArgs)

			Me.SetTheme()
			MyBase.OnLoad(e)
		End Sub

		Private Sub radColorSelector1_CancelButtonClicked(ByVal sender As Object, ByVal args As ColorChangedEventArgs)

		End Sub

		Private Sub radColorSelector1_OkButtonClicked(ByVal sender As Object, ByVal args As ColorChangedEventArgs)

		End Sub

		Private Sub radColorSelector1_ColorChanged(ByVal sender As Object, ByVal args As ColorChangedEventArgs) Handles radColorSelector1.ColorChanged

		End Sub

		Private Sub radTextBox1_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radTextBox1.TextChanged
			radColorSelector1.SelectedColorLabelHeading = radTextBox1.Text
			radColorSelector1.Refresh()
		End Sub

		Private Sub radTextBox2_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radTextBox2.TextChanged
			radColorSelector1.OldColorLabelHeading = radTextBox2.Text
			radColorSelector1.Refresh()
		End Sub

		Private Sub radTextBox3_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radTextBox3.TextChanged
			radColorSelector1.AddNewColorButtonText = radTextBox3.Text
			radColorSelector1.Refresh()
		End Sub

		Private Sub radCheckBox1_Click(ByVal sender As Object, ByVal e As StateChangedEventArgs) Handles radCheckBox1.ToggleStateChanged
			If (Not radColorSelector1.ShowWebColors) AndAlso (Not radColorSelector1.ShowSystemColors) AndAlso (Not radColorSelector1.ShowProfessionalColors) Then
				radCheckBox1.ToggleState = ToggleState.On
				Return
			End If
			radColorSelector1.ShowBasicColors = e.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			radColorSelector1.Refresh()
		End Sub

		Private Sub radCheckBox2_Click(ByVal sender As Object, ByVal e As StateChangedEventArgs) Handles radCheckBox2.ToggleStateChanged
			If (Not radColorSelector1.ShowWebColors) AndAlso (Not radColorSelector1.ShowBasicColors) AndAlso (Not radColorSelector1.ShowProfessionalColors) Then
				radCheckBox2.ToggleState = ToggleState.On
				Return
			End If

			radColorSelector1.ShowSystemColors = e.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			radColorSelector1.Refresh()
		End Sub

		Private Sub radCheckBox3_Click(ByVal sender As Object, ByVal e As StateChangedEventArgs) Handles radCheckBox3.ToggleStateChanged
			If (Not radColorSelector1.ShowSystemColors) AndAlso (Not radColorSelector1.ShowBasicColors) AndAlso (Not radColorSelector1.ShowProfessionalColors) Then
				radCheckBox3.ToggleState = ToggleState.On
				Return
			End If

			radColorSelector1.ShowWebColors = e.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			radColorSelector1.Refresh()
		End Sub

		Private Sub radCheckBox4_Click(ByVal sender As Object, ByVal e As StateChangedEventArgs) Handles radCheckBox4.ToggleStateChanged
			If (Not radColorSelector1.ShowWebColors) AndAlso (Not radColorSelector1.ShowBasicColors) AndAlso (Not radColorSelector1.ShowSystemColors) Then
				radCheckBox4.ToggleState = ToggleState.On
				Return
			End If

			radColorSelector1.ShowProfessionalColors = e.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			radColorSelector1.Refresh()
		End Sub

		Private Sub radCheckBox6_Click(ByVal sender As Object, ByVal e As StateChangedEventArgs) Handles radCheckBox6.ToggleStateChanged
			radColorSelector1.ShowCustomColors = e.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			'when the custom colors are not shown, the user cannot add to them
			If (Not radColorSelector1.ShowCustomColors) Then
				radCheckBox7.Enabled = False
				radCheckBox7.ToggleState = ToggleState.Off
				radColorSelector1.AllowColorSaving = False
			Else
				radCheckBox7.Enabled = True
				radCheckBox7.ToggleState = ToggleState.On
				radColorSelector1.AllowColorSaving = True
			End If
			radColorSelector1.Refresh()
		End Sub

		Private Sub radCheckBox7_Click(ByVal sender As Object, ByVal e As StateChangedEventArgs) Handles radCheckBox7.ToggleStateChanged
			radColorSelector1.AllowColorSaving = e.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			radColorSelector1.Refresh()
		End Sub

		Private Sub radCheckBox5_Click(ByVal sender As Object, ByVal e As StateChangedEventArgs) Handles radCheckBox5.ToggleStateChanged
			radColorSelector1.ShowHEXColorValue = e.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			radColorSelector1.Refresh()
		End Sub

		Private Sub radCheckBox8_Click(ByVal sender As Object, ByVal e As StateChangedEventArgs) Handles radCheckBox8.ToggleStateChanged
			radColorSelector1.AllowEditHEXValue = e.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			radColorSelector1.Refresh()
		End Sub

		Private Sub radCheckBox9_Click(ByVal sender As Object, ByVal e As StateChangedEventArgs) Handles radCheckBox9.ToggleStateChanged
			radColorSelector1.AllowColorPickFromScreen = e.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			radColorSelector1.Refresh()
		End Sub

		Private Sub groupBox3_Enter(ByVal sender As Object, ByVal e As EventArgs)

		End Sub
	End Class
End Namespace