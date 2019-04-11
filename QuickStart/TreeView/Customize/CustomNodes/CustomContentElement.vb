Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Telerik.WinControls.UI
Imports System.Data
Imports Telerik.WinControls
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.WinControls.Primitives

Namespace Telerik.Examples.WinControls.TreeView.Customize.CustomNodes
	Public Class CustomContentElement
		Inherits TreeNodeContentElement
		Private imageElement As LightVisualElement
		Private lineElement As LinePrimitive
		Private textElement As LightVisualElement
		Private descriptionElement As LightVisualElement

		Protected Overrides ReadOnly Property ThemeEffectiveType() As Type
			Get
				Return GetType(TreeNodeContentElement)
			End Get
		End Property

		Public Overrides Sub Synchronize()
			Dim treeNodeElement As TreeNodeElement = Me.NodeElement
			Dim node As RadTreeNode = treeNodeElement.Data
			Dim rowView As DataRowView = CType(node.DataBoundItem, DataRowView)

			Me.textElement.Text = "<html><b>" & rowView("LastName") & ", " & rowView("FirstName") & " - <i>" & rowView("Title")
			Me.descriptionElement.Text = CStr(rowView("Notes"))
			Me.imageElement.Image = ImageHelper.GetImageFromBytes(CType(rowView("Photo"), Byte()))

			Me.DrawBorder = True
			Me.DrawFill = True
			Me.BorderColor = Color.FromArgb(110, 153, 210)
			Me.GradientStyle = GradientStyles.Linear
			Me.NumberOfColors = 2

			If node.Level = 0 Then
				Me.BackColor = Color.FromArgb(248, 248, 248)
				Me.BackColor2 = Color.FromArgb(233, 233, 233)
			ElseIf node.Level = 1 Then
				Me.BackColor = Color.FromArgb(230, 239, 255)
				Me.BackColor2 = Color.FromArgb(225, 228, 235)
			Else
				Me.BackColor = Color.FromArgb(174, 190, 217)
				Me.BackColor2 = Color.FromArgb(168, 183, 210)
			End If
		End Sub

		Protected Overrides Sub InitializeFields()
			MyBase.InitializeFields()
			Me.StretchHorizontally = True
			Me.Padding = New Padding(10)
			Me.Margin = New Padding(0, 5, 0, 5)
			Me.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
		End Sub

		Protected Overrides Sub CreateChildElements()
			imageElement = New LightVisualElement()
			imageElement.MaxSize = New Size(100, 100)
			imageElement.ImageLayout = System.Windows.Forms.ImageLayout.Stretch
			imageElement.Margin = New Padding(0, 0, 4, 0)
			imageElement.DrawBorder = True
			imageElement.BorderColor = Color.Gray
			imageElement.BorderGradientStyle = GradientStyles.Solid
			imageElement.ImageAlignment = ContentAlignment.TopLeft
			Me.Children.Add(imageElement)

			lineElement = New LinePrimitive()
			lineElement.BackColor = Color.Black
			Me.Children.Add(lineElement)

			textElement = New LightVisualElement()
			Me.textElement.DisableHTMLRendering = False
			Me.textElement.TextAlignment = ContentAlignment.TopLeft
			Me.textElement.TextWrap = True
			Me.Children.Add(textElement)

			descriptionElement = New LightVisualElement()
			descriptionElement.TextAlignment = ContentAlignment.TopLeft
			Me.descriptionElement.TextWrap = True
			Me.descriptionElement.AutoEllipsis = True
			Me.Children.Add(descriptionElement)

			Me.Shape = New RoundRectShape(2)
			Me.StretchHorizontally = True
		End Sub

		Protected Overrides Function MeasureOverride(ByVal availableSize As SizeF) As SizeF
			MyBase.MeasureOverride(availableSize)

			availableSize.Width -= Padding.Horizontal
			availableSize.Height -= Padding.Vertical

			Me.imageElement.Measure(availableSize)

			availableSize.Width -= Me.imageElement.DesiredSize.Width

			Me.textElement.Measure(availableSize)

			Me.descriptionElement.Measure(availableSize)

			Dim desiredSize As SizeF = SizeF.Empty

			desiredSize.Height += Me.textElement.DesiredSize.Height + 4
			desiredSize.Height += Me.lineElement.DesiredSize.Height + 4
			desiredSize.Height += Me.descriptionElement.DesiredSize.Height
			desiredSize.Height += Me.Padding.Vertical
			desiredSize.Height = Math.Max(desiredSize.Height, Me.imageElement.DesiredSize.Height + 20)

			desiredSize.Width = Math.Max(Me.textElement.DesiredSize.Width, Me.descriptionElement.DesiredSize.Width)
			desiredSize.Width += Me.imageElement.DesiredSize.Width

			Return desiredSize
		End Function

		Protected Overrides Function ArrangeOverride(ByVal finalSize As SizeF) As SizeF
			Dim clientRect As RectangleF = GetClientRectangle(finalSize)

			Dim offset As Single = (clientRect.Height - Me.imageElement.DesiredSize.Height) / 2
			Me.imageElement.Arrange(New RectangleF(clientRect.X, clientRect.Y, Me.imageElement.DesiredSize.Width, Me.imageElement.DesiredSize.Height))

			Dim imageWidth As Single = Me.imageElement.DesiredSize.Width + 5
			clientRect.X += imageWidth
			clientRect.Width -= imageWidth

			Me.textElement.Arrange(New RectangleF(clientRect.X, clientRect.Y, clientRect.Width, Me.textElement.DesiredSize.Height))

			Dim textHeight As Single = Me.textElement.DesiredSize.Height + 2
			clientRect.Y += textHeight
			clientRect.Height -= textHeight

			Me.lineElement.Arrange(New RectangleF(clientRect.X, clientRect.Y, clientRect.Width - 5, Me.lineElement.DesiredSize.Height))

			Dim lineHeight As Single = Me.lineElement.DesiredSize.Height + 2
			clientRect.Y += lineHeight
			clientRect.Height -= lineHeight

			Me.descriptionElement.Arrange(New RectangleF(clientRect.X, clientRect.Y, clientRect.Width, Me.descriptionElement.DesiredSize.Height))

			Return finalSize
		End Function
	End Class
End Namespace