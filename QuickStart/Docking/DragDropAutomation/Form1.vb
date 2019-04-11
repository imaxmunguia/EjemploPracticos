Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI.Docking
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.Docking.DragDropAutomation
	Partial Public Class Form1
		Inherits ExamplesForm
		#Region "Fields"

		Private Const MouseOffsetX As Integer = 10
        Private Const MouseOffsetY As Integer = 2
		Private service As DragDropService
		Private operation As DragOperation
		Private prevPosition As Point
		Private stopTimer As Timer

		#End Region

		#Region "Constructor"

		Public Sub New()
			InitializeComponent()

			Me.stopTimer = New Timer(Me.components)
			Me.stopTimer.Interval = 500
			AddHandler stopTimer.Tick, AddressOf stopTimer_Tick

			Me.timer1.Interval = 100
			Me.service = Me.radDock1.GetService(Of DragDropService)()
			Me.service.DragDropBehavior = DragDropBehavior.Manual
			AddHandler service.PreviewHitTest, AddressOf service_PreviewHitTest
			AddHandler service.Stopped, AddressOf service_Stopped

			Me.toolWindow1.AllowedDockState = Me.toolWindow1.AllowedDockState And Not AllowedDockState.Hidden
			Me.toolWindow2.AllowedDockState = Me.toolWindow2.AllowedDockState And Not AllowedDockState.Hidden
			Me.toolWindow3.AllowedDockState = Me.toolWindow3.AllowedDockState And Not AllowedDockState.Hidden
		End Sub

		#End Region

		#Region "Event Handlers"

		Private Sub stopTimer_Tick(ByVal sender As Object, ByVal e As EventArgs)
			Me.service.Stop(True)
			Me.stopTimer.Stop()
		End Sub

		Private Sub service_Stopped(ByVal sender As Object, ByVal e As EventArgs)
			Me.timer1.Stop()

			'enable buttons
			Me.scenario1Button.Enabled = True
			Me.scenario2Button.Enabled = True
			Me.initialStateButton.Enabled = True
		End Sub

		Private Sub service_PreviewHitTest(ByVal sender As Object, ByVal e As DragDropHitTestEventArgs)
			Select Case Me.operation
				Case DragOperation.Scenario1
					If e.DropTarget Is Me.radDock1.MainDocumentContainer AndAlso (e.HitTest.DockPosition IsNot Nothing AndAlso e.HitTest.DockPosition = DockPosition.Fill) Then
						Me.timer1.Stop()
						Me.stopTimer.Start()
					End If
				Case DragOperation.Scenario2
					If e.DropTarget Is Me.toolWindow2.DockTabStrip AndAlso (e.HitTest.DockPosition IsNot Nothing AndAlso e.HitTest.DockPosition = DockPosition.Bottom) Then
						Me.timer1.Stop()
						Me.stopTimer.Start()
					End If
			End Select
		End Sub

		Private Sub timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles timer1.Tick
			Select Case Me.operation
				Case DragOperation.Scenario1
					Me.service.PerformDrag(Me.GetAnchorPoint(DockPosition.Fill))
				Case DragOperation.Scenario2
					Me.service.PerformDrag(Me.GetAnchorPoint(DockPosition.Bottom))
			End Select
		End Sub

		Private Sub scenario1Button_Click(ByVal sender As Object, ByVal e As EventArgs) Handles scenario1Button.Click
			Me.Reset()
			Me.operation = DragOperation.Scenario1

			Me.Start()
		End Sub

		Private Sub scenario2Button_Click(ByVal sender As Object, ByVal e As EventArgs) Handles scenario2Button.Click
			Me.Reset()
			Me.operation = DragOperation.Scenario2
			Me.toolWindow2.DockState = DockState.Floating

			Me.Start()
		End Sub

		Private Sub initialStateButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles initialStateButton.Click
			Me.Reset()
		End Sub

		#End Region

		#Region "Implementation"

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			ThemeResolutionService.ApplyThemeToControlTree(Me.settingsPanel, MainForm.DefaultTheme)
		End Sub

		Private Sub Start()
			Dim dockBounds As Rectangle = Me.RectangleToScreen(Me.radDock1.Bounds)
			Me.prevPosition = dockBounds.Location
			Me.radDock1.FloatWindow(Me.toolWindow1, New Rectangle(Me.prevPosition, FloatingWindow.DefaultFloatingSize))
			Me.service.Start(Me.toolWindow1.FloatingParent, Me.prevPosition)

			'start the timer
			Me.timer1.Start()

			'disable buttons
			Me.scenario1Button.Enabled = False
			Me.scenario2Button.Enabled = False
			Me.initialStateButton.Enabled = False
		End Sub

		Private Sub Reset()
			Dim redockService As RedockService = Me.radDock1.GetService(Of RedockService)()
			For Each toolWindow As ToolWindow In Me.radDock1.DockWindows.ToolWindows
				toolWindow.DockState = DockState.Docked
				redockService.ClearState(toolWindow, DockState.Floating)
			Next toolWindow
		End Sub

		Private Function GetAnchorPoint(ByVal position As DockPosition) As Point
			Dim curr As Point = Me.prevPosition
			curr.Offset(MouseOffsetX, MouseOffsetY)

			Dim centerGuideSize As Size = Me.radDock1.DockingGuidesTemplate.CenterBackgroundImage.PreferredSize
			Dim parentBounds As Rectangle
			If position = DockPosition.Fill Then
				parentBounds = Me.radDock1.MainDocumentContainer.Parent.RectangleToScreen(Me.radDock1.MainDocumentContainer.Bounds)
			Else
				parentBounds = Me.toolWindow2.DockTabStrip.Parent.RectangleToScreen(Me.toolWindow2.DockTabStrip.Bounds)
			End If

			Dim guideBounds As New Rectangle(parentBounds.X + (parentBounds.Width - centerGuideSize.Width) / 2, parentBounds.Y + (parentBounds.Height - centerGuideSize.Height) / 2, centerGuideSize.Width, centerGuideSize.Height)

			Dim anchor As Point = curr
			Select Case position
				Case DockPosition.Fill
					anchor = New Point(guideBounds.X + (guideBounds.Width / 2), guideBounds.Y + (guideBounds.Height / 2))
				Case DockPosition.Bottom
					anchor = New Point(guideBounds.X + (guideBounds.Width / 2), guideBounds.Bottom - 10)
			End Select
			'clamp the drag location
			If curr.X > anchor.X Then
				curr.X = anchor.X
			End If
			If curr.Y > anchor.Y Then
				curr.Y = anchor.Y
			End If

			Me.prevPosition = curr

			Return curr
		End Function

		#End Region

		#Region "Nested Types"

		Private Enum DragOperation
			Scenario1
			Scenario2
		End Enum

		#End Region
	End Class
End Namespace
