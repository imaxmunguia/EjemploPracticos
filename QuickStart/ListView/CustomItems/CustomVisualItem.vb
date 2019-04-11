Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Layouts
Imports System.Drawing
Imports Telerik.WinControls
Imports System.Windows.Forms

Namespace Telerik.Examples.WinControls.ListView.CustomItems
	Class CustomVisualItem
		Inherits IconListViewVisualItem
		Private imageElement As LightVisualElement
		Private titleElement As LightVisualElement
		Private artistElement As LightVisualElement
		Private ratingElement As RatingElement
		Private stackLayout As StackLayoutPanel

		Protected Overrides Sub CreateChildElements()
			MyBase.CreateChildElements()

			stackLayout = New StackLayoutPanel()
			stackLayout.Orientation = System.Windows.Forms.Orientation.Vertical

			imageElement = New LightVisualElement()
			imageElement.DrawText = False
			imageElement.ImageLayout = System.Windows.Forms.ImageLayout.Zoom
			imageElement.StretchVertically = False
			imageElement.Margin = New System.Windows.Forms.Padding(10, 5, 10, 5)

			stackLayout.Children.Add(imageElement)

			titleElement = New LightVisualElement()
			titleElement.TextAlignment = ContentAlignment.MiddleLeft
			titleElement.Margin = New Padding(10, 5, 10, 5)
			titleElement.Font = New System.Drawing.Font("Segoe UI", 12, FontStyle.Bold, GraphicsUnit.Point)
			stackLayout.Children.Add(titleElement)

			artistElement = New LightVisualElement()
			artistElement.TextAlignment = ContentAlignment.MiddleLeft
			artistElement.Margin = New Padding(10, 5, 10, 5)
			artistElement.Font = New System.Drawing.Font("Segoe UI", 9, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
			artistElement.ForeColor = Color.FromArgb(255, 114, 118, 125)
			stackLayout.Children.Add(artistElement)

			ratingElement = New RatingElement()
			ratingElement.StarSpacing = -4
			ratingElement.Margin = New System.Windows.Forms.Padding(10, 5, 10, 10)
			stackLayout.Children.Add(ratingElement)

			Me.Children.Add(stackLayout)

			Me.Padding = New Padding(5)
			Me.Shape = New RoundRectShape(3)
			Me.BorderColor = Color.FromArgb(255, 110, 153, 210)
			Me.BorderGradientStyle = GradientStyles.Solid
			Me.DrawBorder = True
			Me.DrawFill = True
			Me.BackColor = Color.FromArgb(255, 230, 238, 254)
			Me.GradientStyle = GradientStyles.Solid
		End Sub

		Protected Overrides Sub SynchronizeProperties()
			Me.imageElement.Image = System.Drawing.Image.FromStream(New System.IO.MemoryStream(DirectCast(Me.Data("Image"), Byte())))
			Me.titleElement.Text = Convert.ToString(Me.Data("AlbumName"))
			Me.artistElement.Text = Convert.ToString(Me.Data("ArtistName"))
			Dim rating As Double = 7 + 3.9 * CDbl(Me.Data("Rating"))
			Me.ratingElement.Rating = CInt(rating)
		End Sub

		Protected Overrides Function MeasureOverride(availableSize As SizeF) As SizeF
			Dim measuredSize As SizeF = MyBase.MeasureOverride(availableSize)

			Me.stackLayout.Measure(measuredSize)

			Return measuredSize
		End Function

		Protected Overrides Function ArrangeOverride(finalSize As SizeF) As SizeF
			MyBase.ArrangeOverride(finalSize)

			Me.stackLayout.Arrange(New RectangleF(PointF.Empty, finalSize))

			Return finalSize
		End Function
	End Class
End Namespace

'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik, @toddanglin
'Facebook: facebook.com/telerik
'=======================================================
