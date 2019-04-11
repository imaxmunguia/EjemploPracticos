Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.ComponentModel

Namespace Telerik.Examples.WinControls.ChartView.LiveData
    Class ChartBusinessObject
        Dim m_value As Double
        Dim m_category As DateTime

        Public Property Value() As Double
            Get
                Return Me.m_value
            End Get
            Set(value As Double)
                Me.m_value = value
            End Set
        End Property

        Public Property Category() As DateTime
            Get
                Return Me.m_category
            End Get
            Set(value As DateTime)
                Me.m_category = value
            End Set
        End Property
    End Class
End Namespace

