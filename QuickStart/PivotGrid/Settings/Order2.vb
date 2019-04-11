Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace Telerik.Examples.WinControls.PivotGrid
    Public Class Order2
        Private m_net As Double

        Public Sub New()
        End Sub

        Public Property [Date]() As DateTime
            Get
                Return m_Date
            End Get
            Set(value As DateTime)
                m_Date = Value
            End Set
        End Property
        Private m_Date As DateTime
        Public Property Product() As String
            Get
                Return m_Product
            End Get
            Set(value As String)
                m_Product = Value
            End Set
        End Property
        Private m_Product As String
        Public Property Quantity() As Integer
            Get
                Return m_Quantity
            End Get
            Set(value As Integer)
                m_Quantity = Value
            End Set
        End Property
        Private m_Quantity As Integer

        Public Property Net() As Double
            Get
                ' throw new Exception("Example for error value");
                If Me.m_net = 1025.64 Then
                End If
                Return Me.m_net
            End Get
            Set(value As Double)
                Me.m_net = value
            End Set
        End Property

        Public Property Promotion() As String
            Get
                Return m_Promotion
            End Get
            Set(value As String)
                m_Promotion = Value
            End Set
        End Property
        Private m_Promotion As String
        Public Property Advertisement() As String
            Get
                Return m_Advertisement
            End Get
            Set(value As String)
                m_Advertisement = Value
            End Set
        End Property
        Private m_Advertisement As String

        Public Overrides Function ToString() As String
            Return Me.Product + Me.Promotion + Me.Quantity
        End Function
    End Class
End Namespace

'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik, @toddanglin
'Facebook: facebook.com/telerik
'=======================================================
