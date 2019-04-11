Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.Editors.ComboBox
	''' <summary>
	''' This is a base control for all RadComboBox examples.
	''' </summary>
	Partial Public Class EditorExampleBaseForm
		Inherits ExamplesForm
		Private fadeAnimation As AnimatedPropertySetting

		Public Sub New()
			InitializeComponent()
			Me.radPanelDemoHolder.ThemeClassName = "Telerik.Examples.WinControls.RadEditorHolder"
			Me.SetStyle(ControlStyles.SupportsTransparentBackColor, True)
			'this.BackColor = Color.Transparent;
			Me.AutoScaleMode = AutoScaleMode.None

		End Sub

		''' <summary>
		''' Resets the location of the panel that holds the example so that it
		''' always resides in the middle of the available space.
		''' </summary>
		''' <param name="e"></param>
		Protected Overrides Sub OnResize(ByVal e As EventArgs)
			If Me.radPanelDemoHolder IsNot Nothing Then
				Dim xCoord As Single = (CSng(Me.Width - Me.radPanelDemoHolder.Width)) / 2
				Dim yCoord As Single = (CSng(Me.Height - Me.radPanelDemoHolder.Height)) / 2

				Me.radPanelDemoHolder.Location = Point.Round(New PointF(xCoord, yCoord))
			End If

			MyBase.OnResize(e)
		End Sub

		''' <summary>
		''' Overidden in order to start a fade-in animation that shows the panel that
		''' holds the demo. Before the animation is started, all child controls in the panel
		''' are hidden.
		''' </summary>
		''' <param name="e"></param>
		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			Dim enableFadeAnimation As Boolean = Me.IsFadeAnimationEnabled()

			If (Not enableFadeAnimation) Then
				Return
			End If

			For Each currentControl As Control In Me.radPanelDemoHolder.Controls
				Dim radControl As RadControl = TryCast(currentControl, RadControl)

				If radControl IsNot Nothing Then
					radControl.Visible = False
				End If
			Next currentControl

			fadeAnimation = New AnimatedPropertySetting(RadItem.OpacityProperty, 25, 10, CObj(0.01))
			AddHandler fadeAnimation.AnimationFinished, AddressOf loadAnimation_AnimationFinished
			fadeAnimation.StartValue = 0.0
			fadeAnimation.EndValue = 1.0
			fadeAnimation.ApplyValue(Me.radPanelDemoHolder.PanelElement)
		End Sub

		Protected Overridable Function IsFadeAnimationEnabled() As Boolean
			Return True
		End Function

		''' <summary>
		''' At the end of the animation, all child controls of the panel are shown.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub loadAnimation_AnimationFinished(ByVal sender As Object, ByVal e As AnimationStatusEventArgs)
			For Each currentControl As Control In Me.radPanelDemoHolder.Controls
				Dim radControl As RadControl = TryCast(currentControl, RadControl)

				If radControl IsNot Nothing Then
					radControl.Visible = True
				End If
			Next currentControl
		End Sub

		#Region "IDisposable Members"

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If Me.components IsNot Nothing Then
					components.Dispose()
				End If

				If Me.fadeAnimation IsNot Nothing Then
					Me.fadeAnimation.Stop(Me.radPanelDemoHolder.PanelElement)
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#End Region
	End Class
End Namespace
