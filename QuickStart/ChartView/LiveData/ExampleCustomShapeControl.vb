Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Telerik.WinControls
Imports System.Drawing
Imports System.ComponentModel

Namespace Telerik.Examples.WinControls.ChartView.LiveData
    <ToolboxItem(True)> _
    Class ExampleCustomShapeControl
        Inherits RadControl
        Private m_element As ExampleCustomShapeElement

        Public ReadOnly Property Element() As ExampleCustomShapeElement
            Get
                Return m_element
            End Get
        End Property

        Public Property LeftText() As String
            Get
                Return Me.m_element.LeftText
            End Get
            Set(value As String)
                Me.m_element.LeftText = value
            End Set
        End Property

        Public Property RightText() As String
            Get
                Return Me.m_element.RightText
            End Get
            Set(value As String)
                Me.m_element.RightText = value
            End Set
        End Property


        Public Sub New()
        End Sub

        Protected Overrides ReadOnly Property DefaultSize() As Size
            Get
                Return New Size(200, 30)
            End Get
        End Property

        Protected Overrides Sub CreateChildItems(parent As RadElement)
            Me.m_element = New ExampleCustomShapeElement()
            Me.RootElement.Children.Add(m_element)
            MyBase.CreateChildItems(parent)
        End Sub
    End Class
End Namespace