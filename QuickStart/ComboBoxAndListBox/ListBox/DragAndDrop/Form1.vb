Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.ComboBoxAndListBox.ListBox.DragAndDrop

	Partial Public Class Form1
		Inherits ExamplesForm
		Private dragDropMan1 As RadItemDragDropManager
		Private itemsFont As Font = Nothing

		Public Sub New()
			InitializeComponent()

			Dim font As New Font("Segoe Print", 12.0f, FontStyle.Bold)
			itemsFont = font
			For Each item As RadListDataItem In Me.radListBox1.Items
				item.Font = font
			Next item

			MyBase.SetEnabledQsfbButton(QSFButtons.TransparentBackground, True)
			dragDropMan1 = New RadItemDragDropManager(Me.radListBox1, Me.radListBox1.Items, Me.radListBox2, Me.radListBox2.Items)
			SetTheme()
			Me.radListBox1.AutoSizeItems = True
			Me.radListBox2.AutoSizeItems = True

			AddHandler Disposed, AddressOf Form1_Disposed
		End Sub

		Private Sub Form1_Disposed(ByVal sender As Object, ByVal e As EventArgs)
			itemsFont.Dispose()
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			ThemeResolutionService.ApplyThemeToControlTree(Me.settingsPanel, MainForm.DefaultTheme)
		End Sub

		Private Sub SetTheme()
			Dim vista As String = "Vista"
			Me.radButton1.ThemeName = vista
			Me.radButton2.ThemeName = vista
			Me.radButton3.ThemeName = vista
			Me.radButton4.ThemeName = vista
			Me.radButton5.ThemeName = vista
			Me.radButton6.ThemeName = vista
			Me.radButton7.ThemeName = vista
			Me.radButton8.ThemeName = vista
		End Sub

		Private Sub radButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButton1.Click
			'moves selectedItem from ListBox1 to ListBox2
			MoveToTargetListBox(radListBox1, radListBox2)
		End Sub

		Private Sub radButton2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButton2.Click
			'moves selectedItem from ListBox2 to ListBox1
			MoveToTargetListBox(radListBox2, radListBox1)
		End Sub

		Private Sub radButton3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButton3.Click
			'moves all items from listBox1 to ListBox2
			MoveAllItems(radListBox1, radListBox2)
		End Sub

		Private Sub radButton4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButton4.Click
			'moves all items from listBox2 to ListBox1
			MoveAllItems(radListBox2, radListBox1)
		End Sub

		Private Sub radButton7_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButton7.Click
			'moves up SelectedItem in radListBox1 
			MoveUp(radListBox1)
		End Sub

		Private Sub radButton8_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButton8.Click
			'moves down SelectedItem in radListBox1
			MoveDown(radListBox1)
		End Sub

		Private Sub radButton5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButton5.Click
			'moves up SelectedItem in radListBox2
			MoveUp(radListBox2)
		End Sub

		Private Sub radButton6_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButton6.Click
			'moves down SelectedItem in radListBox2
			MoveDown(radListBox2)
		End Sub

		Private Sub MoveUp(ByVal listBox As RadListControl)
			If listBox.Items.Count < 2 Then
				Return
			End If
			If listBox.SelectedItem Is Nothing Then
				Return
			End If
			If listBox.SelectedIndex = 0 Then
				Return
			End If
			Dim item As RadListDataItem = listBox.SelectedItem
			Dim index As Integer = listBox.SelectedIndex
			listBox.Items.Remove(item)
			listBox.Items.Insert(index - 1, item)
			listBox.SelectedItem = item
		End Sub

		Private Sub MoveDown(ByVal listBox As RadListControl)
			If listBox.Items.Count < 2 Then
				Return
			End If
			If listBox.SelectedItem Is Nothing Then
				Return
			End If
			If listBox.SelectedIndex = listBox.Items.Count - 1 Then
				Return
			End If
			Dim item As RadListDataItem = listBox.SelectedItem
			Dim index As Integer = listBox.SelectedIndex
			listBox.Items.Remove(item)
			listBox.Items.Insert(index + 1, item)
			listBox.SelectedItem = item
		End Sub

		Private Sub MoveAllItems(ByVal sourceListBox As RadListControl, ByVal targetListBox As RadListControl)
			Dim i As Integer = 0
			Do While i < sourceListBox.Items.Count
				Dim item As RadListDataItem = sourceListBox.Items(i)
				sourceListBox.Items.Remove(item)
				targetListBox.Items.Add(item)
			Loop
		End Sub

		Private Sub MoveToTargetListBox(ByVal sourceListBox As RadListControl, ByVal targetListBox As RadListControl)
			If sourceListBox.Items.Count = 0 Then
				Return
			End If
			If sourceListBox.SelectedItem Is Nothing Then
				Return
			End If

			Dim item As RadListDataItem = sourceListBox.SelectedItem
			sourceListBox.Items.Remove(item)
			targetListBox.Items.Add(item)
		End Sub
	End Class
End Namespace
