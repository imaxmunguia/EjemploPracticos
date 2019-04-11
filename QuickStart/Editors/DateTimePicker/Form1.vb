Imports Microsoft.VisualBasic
Imports System
Imports Telerik.Examples.WinControls.Editors.ComboBox

Namespace Telerik.Examples.WinControls.Editors.DateTimePicker

	Partial Public Class Form1
		Inherits EditorExampleBaseForm
		Private Const THEME As String = "ControlDefault"

		''' <summary>
		''' 
		''' </summary>
		Public Sub New()
			InitializeComponent()
			Me.SelectedControl = Me.radDateTimePicker1
			Me.radDateTimePicker3.DateTimePickerElement.ShowCurrentTime = False
            Me.radDateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom
			me.radDateTimePicker3.Culture = new System.Globalization.CultureInfo("en-US")
			Me.radDateTimePicker3.DateTimePickerElement.CustomFormat = "hh:mm:ss tt"
			Me.radRadio12Hours.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			Me.SetTheme()
		End Sub

		Private Sub SetTheme()
			Me.radBtnClearAll.ThemeName = THEME
			Me.radRadio12Hours.ThemeName = THEME
			Me.radRadio24Hours.ThemeName = THEME
			Me.radDateTimePicker1.ThemeName = THEME
			Me.radDateTimePicker2.ThemeName = THEME
			Me.radDateTimePicker3.ThemeName = THEME
			Me.radGroupExampleSettings.ThemeName = THEME
			Me.radLblLongDateFormat.ThemeName = THEME
			Me.radLblShortDateFormat.ThemeName = THEME
			Me.radLblTimeFormat.ThemeName = THEME

			Me.radDateTimePicker1.DateTimePickerElement.TextBoxElement.TextBoxItem.HostedControl.Enabled = True
			Me.radDateTimePicker2.DateTimePickerElement.TextBoxElement.TextBoxItem.HostedControl.Enabled = True
			Me.radDateTimePicker3.DateTimePickerElement.TextBoxElement.TextBoxItem.HostedControl.Enabled = True
		End Sub

		Private Sub radButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radBtnClearAll.Click
			Me.radDateTimePicker1.DateTimePickerElement.SetToNullValue()
			Me.radDateTimePicker2.DateTimePickerElement.SetToNullValue()
			Me.radDateTimePicker3.DateTimePickerElement.SetToNullValue()

		End Sub

        Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
            Me.radDateTimePicker1.Value = DateTime.Now
            Me.radDateTimePicker2.Value = DateTime.Now
            Me.radDateTimePicker3.Value = DateTime.Now
        End Sub

		Private Sub OnRadRadioHourFormat_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles radRadio24Hours.ToggleStateChanged, radRadio12Hours.ToggleStateChanged
			If Me.radRadio12Hours.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radDateTimePicker3.DateTimePickerElement.CustomFormat = "hh:mm:ss  tt"
			Else
				Me.radDateTimePicker3.DateTimePickerElement.CustomFormat = "HH:mm:ss"
			End If
		End Sub
	End Class
End Namespace