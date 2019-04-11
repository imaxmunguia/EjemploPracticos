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
Imports Telerik.WinControls
Imports Telerik.Examples.WinControls.Editors.ComboBox

Namespace Telerik.Examples.WinControls.TrackStatusControls.ScrollBars.Events
	Partial Public Class Form1
		Inherits EditorExampleBaseForm
		Public Sub New()
			InitializeComponent()

			Me.SelectedControl = Me.radHScrollBar1
		End Sub

		#Region "Scroll Events"
		Private Sub dumpScrollInfo(ByVal company As String, ByVal value As Integer, ByVal e As ScrollEventArgs)
			Me.radTxtEvents.SelectedText = company & " " & e.ScrollOrientation.ToString() & ": Type = " & e.Type.ToString() & "; oldValue = " & e.OldValue.ToString() & "; newValue = " & e.NewValue.ToString() & "; value = " & value.ToString() & Constants.vbCrLf
		End Sub

		Private Sub radVScrollBar1_Scroll(ByVal sender As Object, ByVal e As ScrollEventArgs) Handles radVScrollBar1.Scroll
			dumpScrollInfo("Telerik", radVScrollBar1.Value, e)
		End Sub

		Private Sub radHScrollBar1_Scroll(ByVal sender As Object, ByVal e As ScrollEventArgs) Handles radHScrollBar1.Scroll
			dumpScrollInfo("Telerik", radHScrollBar1.Value, e)
		End Sub


		Private Sub dumpValueChanged(ByVal company As String, ByVal scrollOrientation As String, ByVal value As Integer, ByVal e As ScrollEventArgs)
			Me.radTxtEvents.SelectedText = company & " " & scrollOrientation.ToString() & ": Type = " & e.Type.ToString() & "; Value = " & value.ToString() & Constants.vbCrLf
		End Sub


		Private Sub radVScrollBar1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radVScrollBar1.ValueChanged
			Me.radTxtEvents.SelectedText = "Telerik Vertical ValueChanged: value = " & radVScrollBar1.Value.ToString() & Constants.vbCrLf
		End Sub

		Private Sub radHScrollBar1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radHScrollBar1.ValueChanged
			Me.radTxtEvents.SelectedText = "Telerik Horizontal ValueChanged: value = " & radHScrollBar1.Value.ToString() & Constants.vbCrLf
		End Sub

		#End Region

		#Region "ScrollBar Context Menu"
		Private Function GetScrollBar(ByVal contextMenuEventSender As Object) As RadScrollBar
			Dim item As ToolStripDropDownItem = TryCast(contextMenuEventSender, ToolStripDropDownItem)
			If item Is Nothing Then
				Return Nothing
			End If

			Dim menu As ContextMenuStrip = TryCast(item.Owner, ContextMenuStrip)
			If menu Is Nothing Then
				Return Nothing
			End If

			Return TryCast(menu.SourceControl, RadScrollBar)
		End Function

		Private Sub scrollToToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles scrollToToolStripMenuItem.Click
			Dim scrollBar As RadScrollBar = GetScrollBar(sender)
			If scrollBar IsNot Nothing Then
				scrollBar.PerformScrollTo(Cursor.Position)
			End If
		End Sub

		Private Sub leftTopToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles leftTopToolStripMenuItem.Click
			Dim scrollBar As RadScrollBar = GetScrollBar(sender)
			If scrollBar IsNot Nothing Then
				scrollBar.PerformFirst()
			End If
		End Sub

		Private Sub rightBottomToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles rightBottomToolStripMenuItem.Click
			Dim scrollBar As RadScrollBar = GetScrollBar(sender)
			If scrollBar IsNot Nothing Then
				scrollBar.PerformLast()
			End If
		End Sub

		Private Sub pageLeftUpToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles pageLeftUpToolStripMenuItem.Click
			Dim scrollBar As RadScrollBar = GetScrollBar(sender)
			If scrollBar IsNot Nothing Then
				scrollBar.PerformLargeDecrement(1)
			End If
		End Sub

		Private Sub pageRightBottomToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles pageRightBottomToolStripMenuItem.Click
			Dim scrollBar As RadScrollBar = GetScrollBar(sender)
			If scrollBar IsNot Nothing Then
				scrollBar.PerformLargeIncrement(1)
			End If
		End Sub

		Private Sub scrollLeftUpToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles scrollLeftUpToolStripMenuItem.Click
			Dim scrollBar As RadScrollBar = GetScrollBar(sender)
			If scrollBar IsNot Nothing Then
				scrollBar.PerformSmallDecrement(1)
			End If
		End Sub

		Private Sub scrollRightBottomToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles scrollRightBottomToolStripMenuItem.Click
			Dim scrollBar As RadScrollBar = GetScrollBar(sender)
			If scrollBar IsNot Nothing Then
				scrollBar.PerformSmallIncrement(1)
			End If
		End Sub
		#End Region

		Private Sub radButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radBtnClear.Click
			Me.radTxtEvents.Text = String.Empty
		End Sub
	End Class
End Namespace