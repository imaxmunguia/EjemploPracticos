Imports System.Collections.Generic
Imports System.Text
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports System.Drawing
Imports System

Namespace Telerik.Examples.WinControls.PropertyGrid.FirstLook
    Public Class SurfaceElement
        Inherits LightVisualElement
        Protected m_currentObject As SurfaceObject

        Public Event CurrentObjectChanged As EventHandler

        Public Property CurrentObject() As SurfaceObject
            Get
                Return m_currentObject
            End Get
            Set(ByVal value As SurfaceObject)
                If Not value.Equals(m_currentObject) Then
                    m_currentObject = value
                    Me.Children.Remove(m_currentObject)
                    Me.Children.Add(m_currentObject)
                    RaiseEvent CurrentObjectChanged(Me, EventArgs.Empty)
                End If
            End Set
        End Property

        Protected Overrides Sub InitializeFields()
            MyBase.InitializeFields()
            Me.DrawFill = True
            Me.DrawBorder = False
            Me.GradientStyle = GradientStyles.Solid
            Me.BackColor = Color.White
        End Sub

        Protected Overrides Function ArrangeOverride(ByVal finalSize As SizeF) As SizeF
            For Each element As SurfaceObject In Me.Children
                element.Arrange(New RectangleF(element.Offset.X, element.Offset.Y, element.Size.Width, element.Size.Height))
            Next
            Return finalSize
        End Function
    End Class
End Namespace
