Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports System.Collections
Imports Telerik.Examples.WinControls.Editors.ComboBox
Imports System.Diagnostics

Namespace Telerik.Examples.WinControls.ComboBoxAndListBox.ComboBox.LoadingItems
	''' <summary>
	''' This example demonstrates the capability of <strong>RadComboBox</strong> to handle large numbers of items.
	''' </summary>
	Partial Public Class Form1
		Inherits EditorExampleBaseForm
		Public Sub New()
			InitializeComponent()
			Me.SelectedControl = Me.radComboDemo
			Me.radComboDemo.DropDownMinSize = New Size(Me.radComboDemo.Width, 280)
		End Sub

		Private Sub radBtnLoad_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radBtnLoad.Click
			radComboDemo.ListElement.BeginUpdate()

			radComboDemo.Items.Clear()

			radComboDemo.CloseDropDown()

			radProgressBar.Value1 = 0
			Dim count As Integer = GetItemsCount()
			Dim delta As Integer = count \ 10

			Me.radProgressBar.Maximum = count

			Dim watch As New Stopwatch()

			watch.Start()
			For i As Integer = 0 To count - 1
				radComboDemo.Items.Add(New RadListDataItem("item" & i.ToString()))

				Me.radProgressBar.Value1 += 1

				If (i Mod delta) = 0 Then
					'Causes the app to redraw the progress bar
					Application.DoEvents()
				End If
			Next i

			radComboDemo.ListElement.EndUpdate()

			watch.Stop()
			radLabelElapsed.Size = New Size(100, 20)
			radLabelElapsed.Text = "Time elapsed: " & watch.ElapsedMilliseconds.ToString() & " ms"

			radComboDemo.SelectedIndex = count - 1

			Me.radComboDemo.DropDownListElement.TextBox.TextBoxItem.Focus()
			Me.radComboDemo.ShowDropDown()
		End Sub

		Private Function GetItemsCount() As Integer
			If radRadio500.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Return 500
			ElseIf radRadio1000.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Return 1000
			ElseIf radRadio2000.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Return 2000
			ElseIf radRadio5000.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Return 5000
			End If
			Return 1000
		End Function
	End Class
End Namespace
