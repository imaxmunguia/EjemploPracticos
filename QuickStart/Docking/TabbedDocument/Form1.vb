Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI.Docking
Imports Telerik.WinControls.UI
Imports System.Diagnostics
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.Docking.TabbedDocument
	Partial Public Class Form1
		Inherits Form
		Private newDocument As Integer = 3
		Private processSelIndexChanged As Boolean = True

		Public Sub New()
			InitializeComponent()

			Me.toolWindow1.AllowedDockState = AllowedDockState.All And Not AllowedDockState.TabbedDocument
			Me.toolWindow2.AllowedDockState = AllowedDockState.All And Not AllowedDockState.TabbedDocument

			Me.radDock1.DockWindow(Me.toolWindow2, DockPosition.Bottom)
			AddHandler radDock1.DockStateChanging, AddressOf radDock1_DockStateChanging
			AddHandler radDock1.DockStateChanged, AddressOf radDock1_DockStateChanged
			AddHandler radDock1.DockWindowAdded, AddressOf radDock1_DockWindowAdded
			AddHandler radDock1.DockWindowRemoved, AddressOf radDock1_DockWindowRemoved
			AddHandler radDock1.ActiveWindowChanged, AddressOf radDock1_ActiveWindowChanged

			Me.UpdateCombo()
		End Sub

		Private Sub radDock1_ActiveWindowChanged(ByVal sender As Object, ByVal e As DockWindowEventArgs)
			Me.AddLog("ActiveWindow changed; current active window: " & e.DockWindow.Text, True)
			If TypeOf e.DockWindow Is DocumentWindow Then
				Me.SetSelectedDocument(CType(e.DockWindow, DocumentWindow))
			End If
		End Sub

		Private Sub SetSelectedDocument(ByVal selected As DocumentWindow)
			Dim currIndex As Integer = 0
			For Each item As RadListDataItem In Me.currentRadComboBox.Items
				Dim window As DocumentWindow = TryCast(item.Value, DocumentWindow)
				If window Is selected Then
					Me.currentRadComboBox.SelectedIndex = currIndex
					Exit For
				End If
				currIndex += 1
			Next item
		End Sub

		Private Sub radDock1_DockWindowRemoved(ByVal sender As Object, ByVal e As DockWindowEventArgs)
			Me.UpdateCombo()
		End Sub

		Private Sub radDock1_DockWindowAdded(ByVal sender As Object, ByVal e As DockWindowEventArgs)
			Me.UpdateCombo()
		End Sub

		Private Sub radDock1_DockStateChanged(ByVal sender As Object, ByVal e As DockWindowEventArgs)
			Me.AddLog("Dock State for window " & e.DockWindow.text & " changed to " & e.DockWindow.DockState, True)
		End Sub

		Private Sub radDock1_DockStateChanging(ByVal sender As Object, ByVal e As DockStateChangingEventArgs)
			Me.AddLog("Window " & e.NewWindow.text & " DockState changing to " & e.NewDockState & "; current state: " & e.NewWindow.DockState, True)
		End Sub

		Private Sub newRadButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles newRadButton.Click
			Dim docWindow As New DocumentWindow("Document " & newDocument)
			newDocument += 1
			Me.radDock1.AddDocument(docWindow)
		End Sub

		Private Sub AddLog(ByVal text As String, ByVal newLine As Boolean)
			logRadTextBox.Text += Text & (If((newLine), Constants.vbCrLf, ""))
			logRadTextBox.Select(logRadTextBox.Text.Length, -1)
			logRadTextBox.ScrollToCaret()
		End Sub

		Private Sub currentRadComboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles currentRadComboBox.SelectedIndexChanged
			If (Not Me.processSelIndexChanged) Then
				Return
			End If

			Me.processSelIndexChanged = False

			Dim window As DocumentWindow = Me.GetSelectedDocument()
			If window IsNot Nothing Then
				Me.radDock1.ActiveWindow = window
			End If

			Me.processSelIndexChanged = True
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			UpdateCombo()
		End Sub

        Private Sub UpdateCombo()
            Dim rootState As ElementState = Me.currentRadComboBox.RootElement.ElementState
            If rootState <> ElementState.Constructed AndAlso rootState <> ElementState.Loaded AndAlso rootState <> ElementState.Unloaded Then
                Return
            End If

            Me.currentRadComboBox.BeginUpdate()
            Me.currentRadComboBox.Items.Clear()

            Dim active As DockWindow = Me.radDock1.ActiveWindow
            Dim selIndex As Integer = 0
            Dim currIndex As Integer = 0

            For Each window As DocumentWindow In ControlHelper.GetChildControls(Of DocumentWindow)(Me.radDock1.MainDocumentContainer, True)
                Dim item As New RadListDataItem(window.Text)
                item.Value = window
                Me.currentRadComboBox.Items.Add(item)
                If window Is active Then
                    selIndex = currIndex
                End If
                currIndex += 1
            Next window

            If currIndex > 0 Then
                Me.currentRadComboBox.SelectedIndex = selIndex
            End If
            Me.currentRadComboBox.EndUpdate()
        End Sub

		Private Sub contextRadDropDownButton_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles contextRadDropDownButton.MouseDown
			Dim active As DockWindow = Me.radDock1.DocumentManager.ActiveDocument
			If active Is Nothing Then
				Return
			End If

			Dim service As ContextMenuService = Me.radDock1.GetService(Of ContextMenuService)()
			If service Is Nothing Then
				Return
			End If

			Dim bounds As Rectangle = Me.contextRadDropDownButton.Bounds
			bounds = Me.contextRadDropDownButton.Parent.RectangleToScreen(bounds)
			Dim location As New Point(bounds.X, bounds.Bottom + 1)
			service.DisplayContextMenu(active, location)
		End Sub

		Private Function GetSelectedDocument() As DocumentWindow
			Dim item As RadListDataItem = TryCast(Me.currentRadComboBox.SelectedItem, RadListDataItem)
			If item Is Nothing Then
				Return Nothing
			End If

			Return TryCast(item.Value, DocumentWindow)
		End Function
	End Class
End Namespace