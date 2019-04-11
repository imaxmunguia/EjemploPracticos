Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Telerik.WinControls.UI
Imports System.Drawing
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.ChartView.LiveData
    Class ExampleCustomShapeElement
        Inherits LightVisualElement
        Private m_leftText As LightVisualElement
        Private m_rightText As LightVisualElement

        Public Property LeftText() As String
            Get
                Return m_leftText.Text
            End Get
            Set(value As String)
                m_leftText.Text = value
            End Set
        End Property
        Public Property RightText() As String
            Get
                Return m_rightText.Text
            End Get
            Set(value As String)
                m_rightText.Text = value
            End Set
        End Property

        Protected Overrides Sub CreateChildElements()
            MyBase.CreateChildElements()

            Me.BackColor = Color.FromArgb(142, 196, 65)
            Me.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias

            Me.Shape = GetShape()
            Me.DrawFill = True
            Me.GradientStyle = GradientStyles.Solid

            m_rightText = New LightVisualElement()
            m_rightText.ForeColor = Color.Black
            m_rightText.TextWrap = True
            m_rightText.TextAlignment = ContentAlignment.MiddleLeft

            m_leftText = New LightVisualElement()
            m_leftText.ForeColor = Color.White
            m_leftText.Font = New Font("Segoe UI", 22.0F, System.Drawing.FontStyle.Regular)
            m_leftText.TextAlignment = ContentAlignment.MiddleRight

            Me.Children.Add(m_leftText)
            Me.Children.Add(m_rightText)
        End Sub

        Private Function GetShape() As ElementShape
            Dim points As New List(Of PointF)
            points.Add(New PointF(0, 30))
            points.Add(New PointF(10, 0))
            points.Add(New PointF(200, 0))
            points.Add(New PointF(200, 30))
			
            Dim shape As New CustomShape()
            shape.CreateClosedShape(points)
            Return shape
        End Function

        Protected Overrides Function MeasureOverride(availableSize As SizeF) As SizeF
            Dim result As SizeF = SizeF.Empty

            MyBase.MeasureOverride(availableSize)

            Dim availableRightTextSize As New SizeF(80, availableSize.Height)
            Me.m_rightText.Measure(availableRightTextSize)

            Dim rightTextDesiredSize As SizeF = Me.m_rightText.DesiredSize
            Dim availableLeftTextSize As New SizeF(availableSize.Width - rightTextDesiredSize.Width, availableSize.Height)
            Me.m_leftText.Measure(availableLeftTextSize)

            result.Width += rightTextDesiredSize.Width + m_leftText.DefaultSize.Width
            result.Height = availableSize.Height

            Return result
        End Function

        Protected Overrides Function ArrangeOverride(finalSize As SizeF) As SizeF
            Dim rect As RectangleF = GetClientRectangle(finalSize)

            'rightText
            Dim rightTextArea As New RectangleF(finalSize.Width - 85, 0, Me.m_rightText.DesiredSize.Width, rect.Height)
            Me.m_rightText.Arrange(rightTextArea)

            'leftText
            Dim leftTextArea As New RectangleF(finalSize.Width - 90 - Me.m_leftText.DesiredSize.Width, 0, Me.m_leftText.DesiredSize.Width, rect.Height)
            Me.m_leftText.Arrange(leftTextArea)

            Return finalSize
        End Function

    End Class
End Namespace