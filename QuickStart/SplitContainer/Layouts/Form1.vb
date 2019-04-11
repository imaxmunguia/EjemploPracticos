Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Docking
Imports Telerik.WinControls.Primitives

Namespace Telerik.Examples.WinControls.SplitContainer.Layouts
	Partial Public Class Form1
		Inherits Form
		#Region "Fields"

		Private random As Random

		#End Region

		#Region "Constructor"

		Public Sub New()
			InitializeComponent()

			Me.random = New Random()

			Me.Size = New Size(800, 600)
			Me.StartPosition = FormStartPosition.CenterParent
		End Sub

		#End Region

		#Region "Implementation"

		Private Sub BeginLayout()
			Telerik.WinControls.ControlHelper.BeginUpdate(Me.rootContainer)
			Me.rootContainer.SuspendLayout()
			Me.DisposeChildPanels()
		End Sub

		Private Sub EndLayout()
			Me.rootContainer.ResumeLayout(True)
			Telerik.WinControls.ControlHelper.EndUpdate(Me.rootContainer, True)
		End Sub

		Private Sub DisposeChildPanels()
			Dim count As Integer = Me.rootContainer.SplitPanels.Count
			For i As Integer = count - 1 To 0 Step -1
				rootContainer.SplitPanels(0).Dispose()
			Next i
		End Sub

		Private Function CreateSplitPanel() As SplitPanel
			Dim panel As New SplitPanel()
			Dim back As Color = Color.FromArgb(Me.random.Next(155, 255), Me.random.Next(155, 255), Me.random.Next(155, 255))
			Dim fill As FillPrimitive = TryCast(panel.SplitPanelElement.Children(0), FillPrimitive)
			fill.BackColor = back
			fill.GradientStyle = Telerik.WinControls.GradientStyles.Solid

			Return panel
		End Function

		Private Sub CreateLine(ByVal count As Integer, ByVal orientation As Orientation)
			Me.BeginLayout()

			Me.rootContainer.Orientation = orientation

			For i As Integer = 0 To count - 1
				Me.rootContainer.SplitPanels.Add(Me.CreateSplitPanel())
			Next i

			Me.rootContainer.ResumeLayout(True)

			Me.EndLayout()
		End Sub

		Private Sub CreateGrid(ByVal cols As Integer, ByVal rows As Integer, ByVal centerFill As Boolean)
			Me.CreateGrid(cols, rows, Orientation.Horizontal, centerFill)
		End Sub

		Private Sub CreateGrid(ByVal cols As Integer, ByVal rows As Integer, ByVal orientation As Orientation, ByVal centerFill As Boolean)
			Me.BeginLayout()

			Me.rootContainer.Orientation = orientation

			For i As Integer = 0 To rows - 1
				Dim container As New RadSplitContainer()
				container.Orientation = Orientation.Vertical
				container.SizeInfo.AbsoluteSize = New Size(100, 100)

				For j As Integer = 0 To cols - 1
					Dim panel As SplitPanel = Me.CreateSplitPanel()
					panel.SizeInfo.AbsoluteSize = New Size(100, 100)
					container.SplitPanels.Add(panel)
				Next j

				Me.rootContainer.SplitPanels.Add(container)
			Next i

			If centerFill Then
				TryCast(Me.rootContainer.SplitPanels(rows \ 2), RadSplitContainer).SplitPanels(cols \ 2).SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill
			End If

			Me.EndLayout()
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			Me.CreateGrid(5, 5, True)
		End Sub

		#End Region

		#Region "Event Handlers"

		Private Sub colX9Button_Click(ByVal sender As Object, ByVal e As EventArgs) Handles colX9Button.Click
			Me.CreateLine(9, Orientation.Horizontal)
		End Sub

		Private Sub rowX9_Click(ByVal sender As Object, ByVal e As EventArgs) Handles rowX9.Click
			Me.CreateLine(9, Orientation.Vertical)
		End Sub

		Private Sub gridX9Button_Click(ByVal sender As Object, ByVal e As EventArgs) Handles gridX9Button.Click
			Me.CreateGrid(3, 3, False)
		End Sub

		Private Sub gridX25Button_Click(ByVal sender As Object, ByVal e As EventArgs) Handles gridX25Button.Click
			Me.CreateGrid(5, 5, False)
		End Sub

		Private Sub grixX25FillButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles grixX25FillButton.Click
			Me.CreateGrid(5, 5, True)
		End Sub

		Private Sub absHorizontalButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles absHorizontalButton.Click
			Me.BeginLayout()
			Me.CreateLine(3, Orientation.Horizontal)

			Dim sizeInfo As SplitPanelSizeInfo = Me.rootContainer.SplitPanels(0).SizeInfo
			sizeInfo.SizeMode = SplitPanelSizeMode.Absolute
			sizeInfo.AbsoluteSize = New Size(200, 100)

			sizeInfo = Me.rootContainer.SplitPanels(Me.rootContainer.SplitPanels.Count - 1).SizeInfo
			sizeInfo.SizeMode = SplitPanelSizeMode.Absolute
			sizeInfo.AbsoluteSize = New Size(200, 100)

			Me.EndLayout()
		End Sub

		Private Sub absVerticalButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles absVerticalButton.Click
			Me.BeginLayout()
			Me.CreateLine(3, Orientation.Vertical)

			Dim sizeInfo As SplitPanelSizeInfo = Me.rootContainer.SplitPanels(0).SizeInfo
			sizeInfo.SizeMode = SplitPanelSizeMode.Absolute
			sizeInfo.AbsoluteSize = New Size(100, 200)

			sizeInfo = Me.rootContainer.SplitPanels(Me.rootContainer.SplitPanels.Count - 1).SizeInfo
			sizeInfo.SizeMode = SplitPanelSizeMode.Absolute
			sizeInfo.AbsoluteSize = New Size(100, 200)

			Me.EndLayout()
		End Sub

		Private Sub minMaxButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles minMaxButton.Click
			Me.CreateLine(3, Orientation.Vertical)

			Dim sizeInfo As SplitPanelSizeInfo = Me.rootContainer.SplitPanels(1).SizeInfo
			sizeInfo.MinimumSize = New Size(200, 0)
			sizeInfo.MaximumSize = New Size(300, 0)

			Dim label As New Label()
			label.AutoSize = False
			label.Dock = DockStyle.Top
			label.Height = 100
			label.BackColor = Color.Transparent
			label.Text = "SizeInfo.MinimumSize = [200, 0]" & Constants.vbCrLf & "SizeInfo.MaximumSize = [300, 0]"
			Me.rootContainer.SplitPanels(1).Padding = New Padding(1)
			Me.rootContainer.SplitPanels(1).Controls.Add(label)

		End Sub

		Private Sub AddThreePanels()
			Dim rootContainer As New RadSplitContainer()
			For i As Integer = 0 To 2
				rootContainer.SplitPanels.Add(New SplitPanel())
			Next i
		End Sub

		#End Region
	End Class
End Namespace
