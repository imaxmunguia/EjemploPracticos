Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Telerik.QuickStart.WinControls
Imports System.Drawing
Imports System.Windows.Forms

Namespace Telerik.Examples.WinControls.ListView
	Public Class ListViewExamplesControl
		Inherits ExamplesForm
		Public Overridable ReadOnly Property BottomRightImage() As Bitmap
			Get
				Return Nothing
			End Get
		End Property

		Public Overridable ReadOnly Property TopRightImage() As Bitmap
			Get
				Return Nothing
			End Get
		End Property

		Public Overridable ReadOnly Property ContentControl() As Control
			Get
				Return Nothing
			End Get
		End Property

		Protected Overridable Sub PaintImages(g As Graphics)
			If TopRightImage IsNot Nothing Then
				g.DrawImage(TopRightImage, New Point(Me.Size.Width - TopRightImage.Width, 0))
			End If
			If BottomRightImage IsNot Nothing Then
				g.DrawImage(BottomRightImage, New Point(Me.Size.Width - BottomRightImage.Width, Me.Size.Height - BottomRightImage.Height))
			End If
		End Sub

		Protected Overrides Sub OnPaint(e As PaintEventArgs)
			MyBase.OnPaint(e)
			PaintImages(e.Graphics)
		End Sub

		Protected Overrides Sub OnSizeChanged(e As EventArgs)
			MyBase.OnSizeChanged(e)
			If Me.ContentControl IsNot Nothing Then
				Dim width As Integer = Me.ClientSize.Width
				Dim height As Integer = Me.ClientSize.Height
				Me.ContentControl.Location = New Point((width - ContentControl.Size.Width) / 2, Me.ContentControl.Location.Y)
			End If
		End Sub
	End Class
End Namespace
