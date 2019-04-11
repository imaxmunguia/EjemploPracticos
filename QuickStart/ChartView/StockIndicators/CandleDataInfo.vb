Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.ComponentModel

Namespace Telerik.Examples.WinControls.ChartView.StockIndicators
    Public Class CandleDataInfo
        Implements INotifyPropertyChanged

        Private m_date As DateTime
        Private m_open As Double
        Private m_high As Double
        Private m_low As Double
        Private m_close As Double

        Public Property [Date]() As DateTime
            Get
                Return Me.m_date
            End Get
            Set(value As DateTime)
                Me.m_date = value
                Me.OnPropertyChanged("Date")
            End Set
        End Property

        Public Property Open() As Double
            Get
                Return Me.m_open
            End Get
            Set(value As Double)
                Me.m_open = value
                Me.OnPropertyChanged("Open")
            End Set
        End Property

        Public Property High() As Double
            Get
                Return Me.m_high
            End Get
            Set(value As Double)
                Me.m_high = value
                Me.OnPropertyChanged("High")
            End Set
        End Property

        Public Property Low() As Double
            Get
                Return Me.m_low
            End Get
            Set(value As Double)
                Me.m_low = value
                Me.OnPropertyChanged("Low")
            End Set
        End Property

        Public Property Close() As Double
            Get
                Return Me.m_close
            End Get
            Set(value As Double)
                Me.m_close = value
                Me.OnPropertyChanged("Close")
            End Set
        End Property

        Public Event PropertyChanged As PropertyChangedEventHandler

        Protected Overridable Sub OnPropertyChanged(propertyName As String)
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
        End Sub

        Public Event PropertyChanged1(sender As Object, e As PropertyChangedEventArgs) Implements INotifyPropertyChanged.PropertyChanged
    End Class
End Namespace
