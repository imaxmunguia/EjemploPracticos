Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.WinControls.UI
Imports Telerik.QuickStart.WinControls
Imports Telerik.Examples.WinControls.Editors.ComboBox

Namespace Telerik.Examples.WinControls.ComboBoxAndListBox.ComboBox.Sorting
	Partial Public Class Form1
		Inherits EditorExampleBaseForm
		Private showDropDownTimeout As Timer

		Public Sub New()
			InitializeComponent()
			Me.showDropDownTimeout = New Timer(Me.components)
			Me.showDropDownTimeout.Interval = 1000
			AddHandler showDropDownTimeout.Tick, AddressOf showDropDownTimeout_Tick
			Me.showDropDownTimeout.Start()
		End Sub

		Private Sub showDropDownTimeout_Tick(ByVal sender As Object, ByVal e As EventArgs)
			Me.radComboDemo.DropDownListElement.TextBox.TextBoxItem.Focus()
			Me.radComboDemo.ShowDropDown()
			Me.showDropDownTimeout.Stop()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Me.radComboSortMode.SelectedIndex = Me.radComboSortMode.ListElement.FindString("None")

			Me.SelectedControl = Me.radComboDemo
		End Sub

		Private Sub comboSortStyle_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles radComboSortMode.SelectedIndexChanged
			If e.Position = -1 Then
				Return
			End If

			Select Case radComboSortMode.Items(e.Position).Text
				Case "Ascending"
					radComboDemo.SortStyle = Telerik.WinControls.Enumerations.SortStyle.Ascending
				Case "Descending"
					radComboDemo.SortStyle = Telerik.WinControls.Enumerations.SortStyle.Descending
				Case "None"
					radComboDemo.SortStyle = Telerik.WinControls.Enumerations.SortStyle.None
			End Select
		End Sub

		Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radBtnAdd.Click
			Dim item As New RadListDataItem()
			Dim num As Integer = radComboDemo.Items.Count + 1
			item.Text = "New item " & num.ToString()
			radComboDemo.Items.Add(item)
			radComboDemo.SelectedItem = item
			UpdateDropDownList(Me.radComboDemo, New Telerik.WinControls.UI.Data.PositionChangedEventArgs(0))
		End Sub

		Private Sub btnRemove_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radBtnRemove.Click
			If radComboDemo.SelectedIndex <> -1 Then
				radComboDemo.Items.Remove(radComboDemo.Items(radComboDemo.SelectedIndex))
				UpdateDropDownList(Me.radComboDemo, New Telerik.WinControls.UI.Data.PositionChangedEventArgs(0))
			End If
		End Sub

		Private Sub UpdateDropDownList(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles radComboDemo.SelectedIndexChanged
			If radComboDemo.SelectedIndex <> -1 Then
				radTxtIndex.Text = radComboDemo.SelectedIndex.ToString()
				Dim item As RadListDataItem = radComboDemo.SelectedItem
				radTxtText.Text = item.Text
			Else
				radTxtIndex.Text = String.Empty
				radTxtText.Text = String.Empty
			End If
		End Sub

		Private Sub radComboDemo_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radComboDemo.SelectedValueChanged
			UpdateDropDownList(Me.radComboDemo, New Telerik.WinControls.UI.Data.PositionChangedEventArgs(0))
		End Sub


		Private Sub tBoxText_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radTxtText.TextChanged
			Dim item As RadListDataItem = radComboDemo.SelectedItem
			If (item IsNot Nothing) AndAlso (item.Text <> radTxtText.Text) Then
				radComboDemo.SelectedItem.Text = radTxtText.Text
				radComboDemo.SelectedItem = item
			End If
		End Sub
	End Class
End Namespace