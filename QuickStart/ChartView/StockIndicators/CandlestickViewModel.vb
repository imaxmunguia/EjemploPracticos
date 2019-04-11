Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.ComponentModel
Imports System.Globalization
Imports Microsoft.VisualBasic

Namespace Telerik.Examples.WinControls.ChartView.StockIndicators
    Public Class CandlestickViewModel
        Implements INotifyPropertyChanged

        Private m_data As BindingList(Of CandleDataInfo)

        Public Sub New()
            m_data = ParseData()
        End Sub

        Public Property Data() As BindingList(Of CandleDataInfo)
            Get
                Return m_data
            End Get
            Set(value As BindingList(Of CandleDataInfo))
                If Me.m_data Is Nothing Then
                    Me.m_data = value
                ElseIf Not Me.m_data.Equals(value) Then
                    Me.m_data = value
                    Me.OnPropertyChanged("Data")
                End If
            End Set
        End Property

        Friend Shared Function ParseData() As BindingList(Of CandleDataInfo)
            Dim chartData As New BindingList(Of CandleDataInfo)()
            Dim separator As Char() = {ControlChars.Cr, ControlChars.Lf}
            Dim fileContents As String = My.Resources.OhlcData
            Dim lines As String() = fileContents.Split(separator, StringSplitOptions.RemoveEmptyEntries)
            For Each line As String In lines
                If String.IsNullOrEmpty(line) Then
                    Continue For
                End If

                Dim data As String() = line.Split(","c)
                Dim dataItem As New CandleDataInfo() With { _
                    .[Date] = DateTime.Parse(data(0), CultureInfo.InvariantCulture), _
                    .Open = Double.Parse(data(1), CultureInfo.InvariantCulture), _
                    .High = Double.Parse(data(2), CultureInfo.InvariantCulture), _
                    .Low = Double.Parse(data(3), CultureInfo.InvariantCulture), _
                    .Close = Double.Parse(data(4), CultureInfo.InvariantCulture) _
                }

                chartData.Add(dataItem)
            Next
            Return chartData
        End Function

        Public Event PropertyChanged As PropertyChangedEventHandler

        Protected Overridable Sub OnPropertyChanged(propertyName As String)
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
        End Sub

        Public Event PropertyChanged1(sender As Object, e As PropertyChangedEventArgs) Implements INotifyPropertyChanged.PropertyChanged
    End Class
End Namespace
