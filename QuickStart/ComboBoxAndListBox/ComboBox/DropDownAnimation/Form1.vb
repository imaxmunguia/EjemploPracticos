Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.Examples.WinControls.Editors.ComboBox

Namespace Telerik.Examples.WinControls.ComboBoxAndListBox.ComboBox.DropDownAnimation
	Partial Public Class Form1
		Inherits EditorExampleBaseForm
		Private Const THEME As String = "ControlDefault"
		Private showDropDownTimeout As Timer

		Public Sub New()
			InitializeComponent()

            Me.radSpinFrames.Value = Me.radComboDemo.DropDownAnimationFrames
            Me.radSpinFrames.Minimum = Me.radComboDemo.DropDownAnimationFrames
			Me.radComboAnimType.Items.Add(New RadListDataItem("Select Animation:"))

			Dim easingTypes As Array = System.Enum.GetValues(GetType(RadEasingType))

			For i As Integer = 0 To easingTypes.Length - 1
				Me.radComboAnimType.Items.Add(New RadListDataItem(easingTypes.GetValue(i).ToString()))
			Next i

			Me.radComboDemo.DropDownAnimationEnabled = True
			Me.radCheckEnableAnim.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			Me.radComboDemo.DropDownAnimationFrames = 7
			Me.radComboAnimType.SelectedIndex = 0

			Me.SetTheme()

			Me.SelectedControl = Me.radComboDemo

			Me.showDropDownTimeout = New Timer(Me.components)
			AddHandler showDropDownTimeout.Tick, AddressOf showDropDownTimeout_Tick
			Me.showDropDownTimeout.Interval = 1000
			Me.showDropDownTimeout.Start()

		End Sub


		Private Sub SetTheme()
			Me.radComboAnimType.ThemeName = THEME
			Me.radGroupAnimSettings.ThemeName = THEME
			Me.radLblDropDownAnim.ThemeName = THEME
			Me.radLblFrames.ThemeName = THEME
			Me.radComboDemo.ThemeName = THEME
			Me.radCheckEnableAnim.ThemeName = THEME
			Me.radSpinFrames.ThemeName = THEME
		End Sub

		Private Sub showDropDownTimeout_Tick(ByVal sender As Object, ByVal e As EventArgs)

			Me.showDropDownTimeout.Stop()
			Me.radComboDemo.Focus()
			Me.radComboDemo.ShowDropDown()
		End Sub

		Private Sub OnRadSpinFrames_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radSpinFrames.ValueChanged
			Me.radComboDemo.DropDownAnimationFrames = CInt(Fix(Me.radSpinFrames.Value))
		End Sub

		Private Sub radComboAnimType_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles radComboAnimType.SelectedIndexChanged
			Dim easing As String = Me.radComboAnimType.SelectedText

			If System.Enum.IsDefined(GetType(RadEasingType), easing) Then
				Me.radComboDemo.DropDownAnimationEasing = CType(System.Enum.Parse(GetType(RadEasingType), Me.radComboAnimType.SelectedText), RadEasingType)
			End If
		End Sub

		Private Sub OnEnableAnimation_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles radCheckEnableAnim.ToggleStateChanged
			Me.radComboDemo.DropDownAnimationEnabled = Me.radCheckEnableAnim.Checked

		End Sub

	End Class
End Namespace