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

Namespace Telerik.Examples.WinControls.Docking.MDI
	Partial Public Class Form1
		Inherits Form
		Private Shared count As Integer

		Public Sub New()
			InitializeComponent()

			Me.radDock1.AutoDetectMdiChildren = True
			AddHandler radDock1.DockStateChanging, AddressOf radDock1_DockStateChanging
			AddHandler radDock1.DockStateChanged, AddressOf radDock1_DockStateChanged
			AddHandler radDock1.ActiveWindowChanging, AddressOf radDock1_ActiveWindowChanging
			AddHandler radDock1.ActiveWindowChanged, AddressOf radDock1_ActiveWindowChanged
			Me.documentContainer1.SendToBack()
			Me.radDock1.DockWindow(Me.toolWindow2, DockPosition.Bottom)
		End Sub

		Private Sub radDock1_ActiveWindowChanged(ByVal sender As Object, ByVal e As DockWindowEventArgs)
			Me.AddLog("Active window changed; new active window: " & e.DockWindow.Text, True)
		End Sub

		Private Sub radDock1_ActiveWindowChanging(ByVal sender As Object, ByVal e As DockWindowCancelEventArgs)
			Me.AddLog("Active window changing; current active window: " & e.NewWindow.Text, True)
		End Sub

		Private Sub radDock1_DockStateChanged(ByVal sender As Object, ByVal e As DockWindowEventArgs)
			Me.AddLog("Dock State for window " & e.DockWindow.Text & " changed to " & e.DockWindow.DockState, True)
		End Sub

		Private Sub radDock1_DockStateChanging(ByVal sender As Object, ByVal e As DockStateChangingEventArgs)
			Me.AddLog("Window " & e.NewWindow.Text & " DockState changing to " & e.NewDockState & "; current state: " & e.NewWindow.DockState, True)
		End Sub

		Private Sub newRadButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles newMDIRadButton.Click
			Dim form As New Form()
'TODO: INSTANT VB TODO TASK: Assignments within expressions are not supported in VB.NET
'ORIGINAL LINE: form.Text = "Demo Form" + (count += 1).ToString();
            count = count + 1
			form.Text = "Demo Form" & count.ToString()
			form.MdiParent = Me
			form.Show()
		End Sub

		Private Sub AddLog(ByVal text As String, ByVal newLine As Boolean)
			logRadTextBox.Text += Text & (If((newLine), Constants.vbCrLf, ""))
			logRadTextBox.Select(logRadTextBox.Text.Length, -1)
			logRadTextBox.ScrollToCaret()
		End Sub

		Private Sub customerMDIRadButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles customerMDIRadButton.Click
			Dim form As New CustomerForm()
'TODO: INSTANT VB TODO TASK: Assignments within expressions are not supported in VB.NET
'ORIGINAL LINE: form.Text = "Customer Form" + (count += 1).ToString();
            count = count + 1
			form.Text = "Customer Form" & count.ToString()
			form.MdiParent = Me
			form.Show()
		End Sub

		Private Sub orderMDIRadButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles orderMDIRadButton.Click
			Dim form As New OrderForm()
'TODO: INSTANT VB TODO TASK: Assignments within expressions are not supported in VB.NET
'ORIGINAL LINE: form.Text = "Order Form" + (count += 1).ToString();
            count = count + 1
			form.Text = "Order Form" & count.ToString()
			form.MdiParent = Me
			form.Show()
		End Sub

		Private Sub reportMDIRadButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles reportMDIRadButton.Click
			Dim form As New ReportForm()
'TODO: INSTANT VB TODO TASK: Assignments within expressions are not supported in VB.NET
'ORIGINAL LINE: form.Text = "Report Form" + (count += 1).ToString();
            count = count + 1
			form.Text = "Report Form" & count.ToString()
			form.MdiParent = Me
			form.Show()
		End Sub

		Private Sub imageMDIRadButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles imageMDIRadButton.Click
			Dim form As New ImageForm()
'TODO: INSTANT VB TODO TASK: Assignments within expressions are not supported in VB.NET
'ORIGINAL LINE: form.Text = "Image Form" + (count += 1).ToString();
            count = count + 1
			form.Text = "Image Form" & count.ToString()
			form.MdiParent = Me
			form.Show()
		End Sub
	End Class
End Namespace