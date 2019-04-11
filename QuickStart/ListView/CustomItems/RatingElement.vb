Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Telerik.WinControls.UI
Imports System.Drawing
Imports Telerik.WinControls.Paint
Imports Telerik.Examples.WinControls.Properties

Namespace Telerik.Examples.WinControls.ListView.CustomItems
	Public Class RatingElement
		Inherits LightVisualElement
		Public Shared m_starOn As Bitmap
		Public Shared m_starOff As Bitmap

		Private m_rating As Integer

		Public Property StarOn() As Bitmap
			Get
				Return m_StarOn
			End Get
			Set
				m_StarOn = Value
			End Set
		End Property

		Public Property StarOff() As Bitmap
			Get
				Return m_StarOff
			End Get
			Set
				m_StarOff = Value
			End Set
		End Property


		Public Property Stars() As Integer
			Get
				Return m_Stars
			End Get
			Set
				m_Stars = Value
			End Set
		End Property
		Private m_Stars As Integer

		Public Property Rating() As Integer
			Get
				Return m_rating
			End Get
			Set
				If m_rating <> value Then
					m_rating = value
					Invalidate()
				End If
			End Set
		End Property

		Public Property StarSpacing() As Integer
			Get
				Return m_StarSpacing
			End Get
			Set
				m_StarSpacing = Value
			End Set
		End Property
		Private m_StarSpacing As Integer

		Shared Sub New()
			m_starOn = My.Resources.Resources.bigStarOn
			m_starOff = My.Resources.Resources.bigStarOn
		End Sub

		Public Sub New()
			Stars = 10
			StarOn = m_starOn
			StarOff = m_starOff
		End Sub

		Protected Overrides Sub InitializeFields()
			MyBase.InitializeFields()
			Me.StretchHorizontally = True
		End Sub

		Protected Overrides Function MeasureOverride(availableSize As SizeF) As SizeF
			Dim desiredSize As SizeF = SizeF.Empty

			Dim star As Bitmap = StarOn

			Dim border As System.Windows.Forms.Padding = GetBorderThickness(False)
			desiredSize.Height = star.Height + border.Vertical + Padding.Vertical
			desiredSize.Width = (star.Width + StarSpacing) * Stars + border.Horizontal + Padding.Horizontal

			desiredSize.Width += 40

			Return desiredSize
		End Function

		Protected Overrides Sub PaintElement(graphics As IGraphics, angle As Single, scale As SizeF)
			Dim clientRect As RectangleF = GetClientRectangle(Me.Size)
			Dim x As Integer = CInt(clientRect.X)
			Dim y As Integer = CInt(clientRect.Y)
			Dim i As Integer = 0
			While i < Rating
				graphics.DrawBitmap(StarOn, x, y)
				x += m_starOn.Width + StarSpacing
				i += 1
			End While
			While i < Stars
				graphics.DrawBitmap(StarOff, x, y)
				x += m_starOn.Width + StarSpacing
				i += 1
			End While

			Dim g As Graphics = DirectCast(graphics.UnderlayGraphics, Graphics)
			Using brush As New SolidBrush(Me.ForeColor)
				y += 3
				g.DrawString(String.Format("{0}/{1}", Rating, Stars), Me.Font, brush, New PointF(x + 4, y - 2))
			End Using
		End Sub
	End Class
End Namespace
