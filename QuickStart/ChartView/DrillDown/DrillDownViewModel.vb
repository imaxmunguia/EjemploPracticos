Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.ComponentModel
Imports System.Globalization


Namespace Telerik.Examples.WinControls.ChartView.DrillDown
    Public Class DrillDownViewModel
        Implements INotifyPropertyChanged
        Private m_data As BindingList(Of DrillDownDataInfo)

        Public Sub New()
            m_data = ParseDataByYear()
        End Sub

        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

        Public Property Data() As BindingList(Of DrillDownDataInfo)
            Get
                Return m_data
            End Get
            Set(value As BindingList(Of DrillDownDataInfo))
                Me.m_data = value
                Me.OnPropertyChanged("Data")

            End Set
        End Property

        Friend Shared Function ParseDataByYear() As BindingList(Of DrillDownDataInfo)
            Dim chartData As New BindingList(Of DrillDownDataInfo)()
            Dim separator As Char() = {Microsoft.VisualBasic.ControlChars.Cr, Microsoft.VisualBasic.ControlChars.Lf}
            Dim fileContents As String = My.Resources.DJIA
            Dim lines As String() = fileContents.Split(separator, StringSplitOptions.RemoveEmptyEntries)
            Dim count As Integer = 0
            For Each line As String In lines
                If System.Math.Max(System.Threading.Interlocked.Increment(count), count - 1) > 10 Then
                    '''top 10
                    Exit For
                End If

                If String.IsNullOrEmpty(line) Then
                    Continue For
                End If

                Dim data As String() = line.Split(","c)
                Dim dataItem As New DrillDownDataInfo(DateTime.Parse(data(0), CultureInfo.InvariantCulture), Double.Parse(data(1), CultureInfo.InvariantCulture))


                chartData.Add(dataItem)
            Next

            Return chartData
        End Function

        Friend Shared Function ParseDataByMonth(year As Integer) As BindingList(Of DrillDownDataInfo)
            Dim chartData As New BindingList(Of DrillDownDataInfo)()
            Dim separator As Char() = {Microsoft.VisualBasic.ControlChars.Cr, Microsoft.VisualBasic.ControlChars.Lf}
            Dim fileContents As String = My.Resources.DJIAM
            Dim lines As String() = fileContents.Split(separator, StringSplitOptions.RemoveEmptyEntries)
            For Each line As String In lines
                If String.IsNullOrEmpty(line) Then
                    Continue For
                End If

                Dim data As String() = line.Split(","c)
                Dim [date] As DateTime = DateTime.Parse(data(0), CultureInfo.InvariantCulture)
                If [date].Year = year Then

                    Dim dataItem As New DrillDownDataInfo([date], Double.Parse(data(1), CultureInfo.InvariantCulture))


                    chartData.Add(dataItem)
                End If
            Next

            Return chartData
        End Function

        Friend Shared Function ParseDataByDay(year As Integer, month As Integer) As BindingList(Of DrillDownDataInfo)
            Dim chartData As New BindingList(Of DrillDownDataInfo)()
            Dim separator As Char() = {Microsoft.VisualBasic.ControlChars.Cr, Microsoft.VisualBasic.ControlChars.Lf}
            Dim fileContents As String = My.Resources.DJIAD
            Dim lines As String() = fileContents.Split(separator, StringSplitOptions.RemoveEmptyEntries)
            For Each line As String In lines
                If String.IsNullOrEmpty(line) Then
                    Continue For
                End If

                Dim data As String() = line.Split(","c)
                Dim [date] As DateTime = DateTime.Parse(data(0), CultureInfo.InvariantCulture)
                If [date].Year = year AndAlso [date].Month = month AndAlso Not String.IsNullOrEmpty(data(1)) Then

                    Dim dataItem As New DrillDownDataInfo([date], Double.Parse(data(1), CultureInfo.InvariantCulture))


                    chartData.Add(dataItem)
                End If
            Next

            Return chartData
        End Function

      
        Protected Overridable Sub OnPropertyChanged(propertyName As String)
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
        End Sub
    End Class
End Namespace

