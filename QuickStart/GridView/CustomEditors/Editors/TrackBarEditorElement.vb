Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Telerik.WinControls.UI
Imports System.Windows.Forms
Imports System.Drawing
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.GridView.CustomEditors
	Public Class TrackBarEditorElement
		Inherits RadTrackBarElement
		Private editor As TrackBarEditor

		Public Sub New(ByVal editor As TrackBarEditor)
			Me.CanFocus = True
			Me.editor = editor
			Me.Maximum = 100
			Me.TickFrequency = 10
			Me.StretchVertically = False
		End Sub

		Public Event TrackPositionChanged As EventHandler

		Protected Overrides ReadOnly Property ThemeEffectiveType() As Type
			Get
				Return GetType(RadTrackBarElement)
			End Get
		End Property

		Protected Overrides Sub OnKeyDown(ByVal e As KeyEventArgs)
			MyBase.OnKeyDown(e)

			Dim grid As RadGridView = TryCast(Me.ElementTree.Control, RadGridView)
			If grid IsNot Nothing Then
				Select Case e.KeyCode
					Case Keys.Escape, Keys.Enter, Keys.Up, Keys.Down
						grid.GridBehavior.ProcessKeyDown(e)

					Case Keys.Left
						If Me.Value > Me.Minimum Then
							Me.Value -= 1
						End If

					Case Keys.Right
						If Me.Value < Me.Maximum Then
							Me.Value += 1
						End If

					Case Keys.Home
						Me.Value = Me.Minimum

					Case Keys.End
						Me.Value = Me.Maximum
				End Select
			End If
		End Sub

		Protected Overrides Function MeasureOverride(ByVal availableSize As SizeF) As SizeF
			Dim desiredHeight As Integer = 30
			For Each element As RadElement In Me.Children
				element.Measure(New SizeF(availableSize.Width, desiredHeight))
			Next element
			Return New SizeF(1, desiredHeight)
		End Function

		Protected Overrides Function ArrangeOverride(ByVal finalSize As SizeF) As SizeF
			Dim size As SizeF = finalSize
			size.Width -= 40
			Return MyBase.ArrangeOverride(size)
		End Function

		Protected Overrides Sub OnPropertyChanged(ByVal e As RadPropertyChangedEventArgs)
			MyBase.OnPropertyChanged(e)
			If e.Property Is RadTrackBarItem.ValueProperty AndAlso Me.Parent IsNot Nothing AndAlso Me.TrackPositionChangedEvent IsNot Nothing Then
				RaiseEvent TrackPositionChanged(Me, EventArgs.Empty)
			End If
		End Sub
	End Class
End Namespace
