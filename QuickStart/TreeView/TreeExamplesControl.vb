Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples
	Public Class TreeExamplesControl
		Inherits ExamplesForm
		Private topRightBitmap As Bitmap = My.Resources.TV_gradient
		Private headerPanel As TreeExampleHeaderPanel

		Public Sub New()
			headerPanel = New TreeExampleHeaderPanel()
			Me.Controls.Add(headerPanel)
			Me.AutoScroll = False
		End Sub

		Public Overridable ReadOnly Property TreeControl() As RadTreeView
			Get
				Return Nothing
			End Get
		End Property

		Public Overridable ReadOnly Property BottomRightImage() As Bitmap
			Get
				Return Nothing
			End Get
		End Property

		Public Overridable ReadOnly Property HeaderText() As String
			Get
				Return ""
			End Get
		End Property

		Public Overridable ReadOnly Property TopRightImage() As Bitmap
			Get
				Return Me.topRightBitmap
			End Get
		End Property

		Protected Overridable Function CalculateTreeWidth(ByVal clientWidth As Integer) As Integer
			Return clientWidth - (197 + 264)
		End Function

		Protected Overridable Function CalculateOffset(ByVal clientWidth As Integer) As Integer
			Return 194
		End Function

		Protected Overridable Sub UpdateTreeDimensions()
			If Me.TreeControl IsNot Nothing Then
				Dim width As Integer = Me.ClientSize.Width
				Dim height As Integer = Me.ClientSize.Height
				Dim offset As Integer = CalculateOffset(width)
				Me.TreeControl.Size = New Size(CalculateTreeWidth(width), height - 94 - 30)
				Me.TreeControl.Location = New Point(offset, 62 + 30)
				Me.headerPanel.Size = New Size(Me.TreeControl.Size.Width, 30)
				Me.headerPanel.Location = New Point(offset, 62)
			End If
		End Sub

		Protected Overridable Sub PaintImages(ByVal g As Graphics)
			If TopRightImage IsNot Nothing Then
				g.DrawImage(TopRightImage, New Point(Me.Size.Width - TopRightImage.Width, 0))
			End If
			If BottomRightImage IsNot Nothing Then
				g.DrawImage(BottomRightImage, New Point(Me.Size.Width - BottomRightImage.Width, Me.Size.Height - BottomRightImage.Height))
			End If
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)
			If TreeControl IsNot Nothing Then
				Me.TreeControl.ItemHeight = 27
				Me.TreeControl.ShowLines = False
				Me.TreeControl.FullRowSelect = True
				Me.TreeControl.ExpandAnimation = ExpandAnimation.None
				Me.headerPanel.Text = HeaderText
				Me.TreeControl.AllowEdit = True
				Me.TreeControl.AllowAdd = False
				Me.TreeControl.AllowRemove = False
				Me.TreeControl.AllowDefaultContextMenu = True
			End If
		End Sub

		Protected Overrides Sub OnSizeChanged(ByVal e As EventArgs)
			MyBase.OnSizeChanged(e)
			UpdateTreeDimensions()
		End Sub

		Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
			MyBase.OnPaint(e)
			PaintImages(e.Graphics)
		End Sub
	End Class
End Namespace