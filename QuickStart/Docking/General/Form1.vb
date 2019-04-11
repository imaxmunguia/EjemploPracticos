Imports Microsoft.VisualBasic
Imports System
Imports Telerik.WinControls.UI.Docking
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.Docking.General
	Partial Public Class Form1
		Inherits Telerik.WinControls.UI.RadForm
		#Region "Fields"

		Private processDockStateChange As Boolean = True

		#End Region

		Public Sub New()
			InitializeComponent()

			Dim item As New RadListDataItem("Tool Window 1")
			item.Value = Me.toolWindow1
			Me.radComboBox1.Items.Add(item)

			item = New RadListDataItem("Tool Window 2")
			item.Value = Me.toolWindow2
			Me.radComboBox1.Items.Add(item)
			Me.radComboBox1.SelectedIndex = 0

			Me.processDockStateChange = False

			For Each state As DockState In System.Enum.GetValues(GetType(DockState))
				item = New RadListDataItem(state.ToString())
				item.Value = state
				Me.radComboBox2.Items.Add(item)
			Next state

			Me.radComboBox2.SelectedIndex = 0
			Me.processDockStateChange = True

			AddHandler Me.radDock1.DockStateChanging, AddressOf radDock1_DockStateChanging
			AddHandler Me.radDock1.DockStateChanged, AddressOf radDock1_DockStateChanged
			AddHandler radDock1.ActiveWindowChanging, AddressOf radDock1_ActiveWindowChanging
			AddHandler radDock1.ActiveWindowChanged, AddressOf radDock1_ActiveWindowChanged
		End Sub

		Private Sub radDock1_ActiveWindowChanging(ByVal sender As Object, ByVal e As DockWindowCancelEventArgs)
			e.Cancel = TypeOf e.NewWindow Is DocumentWindow
		End Sub

		Protected Overrides Overloads Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			Me.SetDockState(Me.radDock1.ActiveWindow)
		End Sub

		Private Sub radDock1_ActiveWindowChanged(ByVal sender As Object, ByVal e As DockWindowEventArgs)
			Me.SetDockState(e.DockWindow)
		End Sub

		Private Sub radDock1_DockStateChanged(ByVal sender As Object, ByVal e As DockWindowEventArgs)
			Me.SetDockState(e.DockWindow)

			Dim message As String = e.DockWindow.Text & " dock state changed to " & e.DockWindow.DockState
			AddLog(message, True)
		End Sub

		Private Function GetSelectedDockWindow() As DockWindow
			Dim item As RadListDataItem = TryCast(Me.radComboBox1.SelectedItem, RadListDataItem)
			If item Is Nothing Then
				Return Nothing
			End If

			Return TryCast(item.Value, DockWindow)
		End Function

		Private Sub radDock1_DockStateChanging(ByVal sender As Object, ByVal e As DockStateChangingEventArgs)
			Dim message As String = e.NewWindow.Text & " current dock state - " & e.NewWindow.DockState & " - changing to " & e.NewDockState
			AddLog(message, True)
		End Sub

		Private Sub AddLog(ByVal text As String, ByVal newLine As Boolean)
			textBox1.Text += Text & (If((newLine), Constants.vbCrLf, ""))
			textBox1.Select(textBox1.Text.Length, -1)
			textBox1.ScrollToCaret()
		End Sub

		Private Sub radComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radComboBox1.SelectedIndexChanged
			Dim window As DockWindow = Me.GetSelectedDockWindow()
			If window IsNot Nothing Then
				Me.radDock1.ActiveWindow = window
			End If
		End Sub

		Private Sub radComboBox2_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles radComboBox2.SelectedIndexChanged
			If (Not Me.processDockStateChange) Then
				Return
			End If

			Dim window As DockWindow = Me.GetSelectedDockWindow()
			If window IsNot Nothing Then
				Dim state As DockState = CType(Me.radComboBox2.SelectedValue, DockState)
				window.DockState = state
				Me.SetDockState(window)
			End If
		End Sub

		Private Sub radButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButton1.Click
			Me.textBox1.Text = String.Empty
		End Sub

		Private Sub SetDockState(ByVal window As DockWindow)
			If window Is Me.toolWindow1 Then
				Me.radComboBox1.SelectedIndex = 0
			ElseIf window Is Me.toolWindow2 Then
				Me.radComboBox1.SelectedIndex = 1
			End If

			Me.processDockStateChange = False
			Me.radComboBox2.SelectedIndex = CInt(Fix(window.DockState))
			Me.processDockStateChange = True
		End Sub
	End Class
End Namespace