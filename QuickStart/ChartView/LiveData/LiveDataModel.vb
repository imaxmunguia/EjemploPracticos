Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.ComponentModel
Imports System.Windows.Forms

Namespace Telerik.Examples.WinControls.ChartView.LiveData
    Class LiveDataModel
        Implements INotifyPropertyChanged

        Public m_data As BindingList(Of ChartBusinessObject)
        Public m_data2 As BindingList(Of ChartBusinessObject)
        Private m_messagesPerSecond As String
        Private m_messagesPerMinute As String
        Private tickCountSecond As Integer
        Private tickCountMinute As Integer
        Private timer As Timer
        Private lastDate As DateTime
        Private random As New Random()

        Public Sub New()
            Me.timer = New Timer()
            Me.timer.Interval = 200
            AddHandler Me.timer.Tick, AddressOf OnTimer

            Me.FillData()
            Me.FillData2()
            Me.MessagesPerSecond = Me.random.[Next](900, 1100).ToString("#,#")
            Me.MessagesPerMinute = Me.random.[Next](50000, 55000).ToString("#,#")
        End Sub

        Public Property MessagesPerSecond() As String
            Get
                Return Me.m_messagesPerSecond
            End Get
            Set(value As String)
                If Me.m_messagesPerSecond <> value Then
                    Me.m_messagesPerSecond = value
                    Me.OnPropertyChanged("MessagesPerSecond")
                End If
            End Set
        End Property

        Public Property MessagesPerMinute() As String
            Get
                Return Me.m_messagesPerMinute
            End Get
            Set(value As String)
                If Me.m_messagesPerMinute <> value Then
                    Me.m_messagesPerMinute = value
                    Me.OnPropertyChanged("MessagesPerMinute")
                End If
            End Set
        End Property

        Public Property Data() As BindingList(Of ChartBusinessObject)
            Get
                Return Me.m_data
            End Get
            Set(value As BindingList(Of ChartBusinessObject))
                If Me.m_data Is Nothing Then
                    Me.m_data = value
                ElseIf Not Me.m_data.Equals(value) Then
                    Me.m_data = value
                    Me.OnPropertyChanged("Data")
                End If

            End Set
        End Property

        Public Property Data2() As BindingList(Of ChartBusinessObject)
            Get
                Return Me.m_data2
            End Get
            Set(value As BindingList(Of ChartBusinessObject))
                If Me.m_data2 Is Nothing Then
                    Me.m_data2 = value
                ElseIf Not Me.m_data2.Equals(value) Then
                    Me.m_data2 = value
                    Me.OnPropertyChanged("Data2")
                End If
            End Set
        End Property

        Public Sub StartTimer()
            Me.timer.Start()
        End Sub

        Public Sub StopTimer()
            Me.timer.[Stop]()
        End Sub

        Public Sub UpdateTimer(interval As Double)
            Me.timer.Interval = CInt(interval)
        End Sub

        Private Sub FillData()
            Dim collection As New BindingList(Of ChartBusinessObject)()
            Me.lastDate = DateTime.Now

            For i As Integer = 0 To 30
                Me.lastDate = Me.lastDate.AddMilliseconds(200)
                collection.Add(Me.CreateBusinessObject())
            Next

            Me.Data = collection
        End Sub

        Private Sub FillData2()
            Dim collection As New BindingList(Of ChartBusinessObject)()
            Dim [date] As New DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day)

            For i As Integer = 0 To 23
                collection.Add(Me.CreateBusinessObject2([date].AddHours(i)))
            Next

            Me.Data2 = collection
        End Sub

        Private Sub OnTimer(sender As Object, e As EventArgs)
            Me.lastDate = Me.lastDate.AddMilliseconds(200)
            Me.Data.RemoveAt(0)
            Me.Data.Add(Me.CreateBusinessObject())
            Me.UpdateMetrics()
        End Sub

        Private Sub UpdateMetrics()
            Me.tickCountSecond += 1
            Me.tickCountMinute += 1

            If Me.tickCountSecond = 5 Then
                Me.tickCountSecond = 0
                Me.MessagesPerSecond = Me.random.[Next](900, 1100).ToString("#,#")
            End If

            If Me.tickCountMinute = 300 Then
                Me.tickCountMinute = 0
                Me.MessagesPerMinute = Me.random.[Next](50000, 55000).ToString("#,#")
            End If
        End Sub

        Private Function CreateBusinessObject() As ChartBusinessObject
            Dim obj As New ChartBusinessObject()

            obj.Value = Me.random.[Next](800, 1800)
            obj.Category = Me.lastDate

            Return obj
        End Function

        Private Function CreateBusinessObject2([date] As DateTime) As ChartBusinessObject
            Dim obj As New ChartBusinessObject()

            obj.Value = Me.random.[Next](3300, 3800)
            obj.Category = [date]

            Return obj
        End Function

        Public Event PropertyChanged As PropertyChangedEventHandler

        Protected Overridable Sub OnPropertyChanged(propertyName As String)
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
        End Sub

        Public Event PropertyChanged1(sender As Object, e As PropertyChangedEventArgs) Implements INotifyPropertyChanged.PropertyChanged
    End Class
End Namespace
