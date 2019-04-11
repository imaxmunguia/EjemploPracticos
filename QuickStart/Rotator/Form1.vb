Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports System.Globalization
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.Rotator
	''' <summary>
	''' RadRotator example
	''' </summary>
	Partial Public Class Form1
		Inherits ExamplesForm
		Private Shared telerikUrl As New Uri("http://www.telerik.com/products/winforms/overview.aspx")
		Private Const THEME As String = "ControlDefault"
		Public Sub New()
			InitializeComponent()

			Me.SelectedControl = Me.radRotator1
			ThemeResolutionService.ApplyThemeToControlTree(Me, THEME)
			ThemeResolutionService.ApplyThemeToControlTree(Me.settingsPanel, THEME)
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			AddHandler radRotator1.StartRotation, AddressOf radRotator1_StartRotation
			Me.locationAnimationTextBox.Text = SizeFToString(radRotator1.LocationAnimation)

			AddHandler radTextBoxElement1.TextBoxItem.GotFocus, AddressOf TextBoxItem_GotFocus

			radRotator1.Start()
		End Sub

		Private Sub TextBoxItem_GotFocus(ByVal sender As Object, ByVal e As EventArgs)
			radRotator1.Stop()
		End Sub

		Private Sub radButtonElement1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButtonElement1.Click
			Me.radRotator1.Previous()
		End Sub

		Private Sub locationAnimationTextBox_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radStartStopButton.Click
			Me.radRotator1.Running = Not Me.radRotator1.Running
		End Sub

		Private Sub radRotator1_BeginRotate(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.BeginRotateEventArgs) Handles radRotator1.BeginRotate
			Me.currentFrameTextBox.Text = e.To.ToString()
		End Sub

		Private Sub radRotator1_StartRotation(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
			Me.radStartStopButton.Text = "||"

			Dim newURL As String = Me.radTextBoxElement1.Text
			Dim newUri As Uri = Nothing

			If (Not String.IsNullOrEmpty(newURL)) AndAlso (Not Uri.TryCreate(newURL, UriKind.Absolute, newUri)) Then
				Uri.TryCreate(String.Format("http://{0}", newURL), UriKind.Absolute, newUri)
			End If

			If newUri Is Nothing Then
				Me.radWebBrowserItem1.Url = telerikUrl
			Else
				Me.radWebBrowserItem1.Url = newUri
			End If
		End Sub

		Private Sub radRotator1_StopRotation(ByVal sender As Object, ByVal e As EventArgs) Handles radRotator1.StopRotation
			Me.radStartStopButton.Text = ">"
		End Sub

		Private Sub radCheckBoxOpacity_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles radCheckBoxOpacity.ToggleStateChanged
			Me.radRotator1.OpacityAnimation = radCheckBoxOpacity.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
		End Sub

		Private Sub radButtonApply_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButtonApply.Click

			Dim newFramesValue As String = SetFramesInterval(intervalTextBox.Text)
			Dim newLocationValue As String = SetLocationAnimation(locationAnimationTextBox.Text)

			If newFramesValue IsNot Nothing Then
				Me.intervalTextBox.Text = newFramesValue
			End If

			If newLocationValue IsNot Nothing Then
				Me.locationAnimationTextBox.Text = newLocationValue
			End If
		End Sub

		Private Function SetFramesInterval(ByVal value As String) As String
			Dim interval As Integer = 0

			Try
				interval = Convert.ToInt32(value)
			Catch e1 As Exception
				Return "500"
			End Try

			Dim result As String = Nothing

			If interval < 500 Then
				result = "500"
				interval = 500
			End If

			radRotator1.Interval = interval

			Return result
		End Function

		Private Function SetLocationAnimation(ByVal value As String) As String
			Dim values() As String = value.Split(","c)

			If values.Length <> 2 Then
				Return SizeFToString(radRotator1.LocationAnimation)
			End If


			Dim newValue As New SizeF(0, 0)

			Try
				newValue.Width = Single.Parse(values(0), CultureInfo.InvariantCulture)
				newValue.Height = Single.Parse(values(1), CultureInfo.InvariantCulture)
			Catch e1 As Exception
				Return SizeFToString(radRotator1.LocationAnimation)
			End Try

			radRotator1.LocationAnimation = newValue

			Return Nothing
		End Function

		Private Function SizeFToString(ByVal value As SizeF) As String
			Return String.Format("{0}, {1}", value.Width, value.Height)
		End Function

		Private Sub currentFrameTextBox_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles currentFrameTextBox.TextChanged
			'int frame;
			'try
			'{
			'    frame = Convert.ToInt32(radTextBox1.Text);
			'}
			'catch(Exception)
			'{
			'    return;
			'}

			'if (frame != this.radRotator1.CurrentIndex)
			'{
			'    this.radRotator1.CurrentIndex = frame;
			'}
		End Sub

		Private Sub radButtonPrevious_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButtonPrevious.Click
			Me.radRotator1.Previous()
		End Sub

		Private Sub radButtonNext_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButtonNext.Click
			Me.radRotator1.Next()
		End Sub


	End Class
End Namespace