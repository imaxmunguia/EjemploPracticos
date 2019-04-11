Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Windows.Forms
Imports Telerik.Charting

Namespace Telerik.Examples.WinControls.ChartView.Bar
    Public Class PerformanceModel
        Implements INotifyPropertyChanged
        Private _q1 As IEnumerable(Of PerformanceData)
        Private _q2 As IEnumerable(Of PerformanceData)
        Private _q3 As IEnumerable(Of PerformanceData)
        Private _q4 As IEnumerable(Of PerformanceData)

        Private _barCombineMode As ChartSeriesCombineMode = ChartSeriesCombineMode.Cluster
        Private _chartOrientation As Orientation = Orientation.Vertical
        Private _isShowLabelsEnabled As Boolean = True
        Private _showLabels As Boolean = False

        Private _gapLength As Double = 0.2
        Private _axisMaxValue As Double = 20000.0
        Private _axisStep As Double = 5000.0
        Private _axisTitle As String = "PROFIT (USD)"
        Private _axisLabelFormat As String = "N0"

        Public Sub New()
        End Sub

        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

        Protected Overridable Sub OnPropertyChanged(propertyName As String)
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
        End Sub

        Public ReadOnly Property Q1() As IEnumerable(Of PerformanceData)
            Get
                If Me._q1 Is Nothing Then
                    Me._q1 = New List(Of PerformanceData)() From { _
                     New PerformanceData("Jason Harley", "Q1, 2010", 17790), _
                     New PerformanceData("Adam White", "Q1, 2010", 12820), _
                     New PerformanceData("Barbara Smith", "Q1, 2010", 14350), _
                     New PerformanceData("Susan Jones", "Q1, 2010", 11150), _
                     New PerformanceData("Tom Marshall", "Q1, 2010", 11800) _
                    }
                End If

                Return Me._q1
            End Get
        End Property

        Public ReadOnly Property Q2() As IEnumerable(Of PerformanceData)
            Get
                If Me._q2 Is Nothing Then
                    Me._q2 = New List(Of PerformanceData)() From { _
                     New PerformanceData("Jason Harley", "Q2, 2010", 15320), _
                     New PerformanceData("Adam White", "Q2, 2010", 14100), _
                     New PerformanceData("Barbara Smith", "Q2, 2010", 13000), _
                     New PerformanceData("Susan Jones", "Q2, 2010", 8850), _
                     New PerformanceData("Tom Marshall", "Q2, 2010", 10900) _
                    }
                End If

                Return Me._q2
            End Get
        End Property

        Public ReadOnly Property Q3() As IEnumerable(Of PerformanceData)
            Get
                If Me._q3 Is Nothing Then
                    Me._q3 = New List(Of PerformanceData)() From { _
                     New PerformanceData("Jason Harley", "Q3, 2010", 13800), _
                     New PerformanceData("Adam White", "Q3, 2010", 12300), _
                     New PerformanceData("Barbara Smith", "Q3, 2010", 14900), _
                     New PerformanceData("Susan Jones", "Q3, 2010", 10100), _
                     New PerformanceData("Tom Marshall", "Q3, 2010", 8700) _
                    }
                End If

                Return Me._q3
            End Get
        End Property

        Public ReadOnly Property Q4() As IEnumerable(Of PerformanceData)
            Get
                If Me._q4 Is Nothing Then
                    Me._q4 = New List(Of PerformanceData)() From { _
                     New PerformanceData("Jason Harley", "Q4, 2010", 15850), _
                     New PerformanceData("Adam White", "Q4, 2010", 11200), _
                     New PerformanceData("Barbara Smith", "Q4, 2010", 14000), _
                     New PerformanceData("Susan Jones", "Q4, 2010", 7500), _
                     New PerformanceData("Tom Marshall", "Q4, 2010", 10000) _
                    }
                End If

                Return Me._q4
            End Get
        End Property

        Public Function GetData(index As Integer) As IEnumerable(Of PerformanceData)
            If index = 0 Then
                Return Me.Q1
            End If

            If index = 1 Then
                Return Me.Q2
            End If

            If index = 2 Then
                Return Me.Q3
            End If

            If index = 3 Then
                Return Me.Q4
            End If

            Return Nothing
        End Function

        Public Property BarCombineMode() As ChartSeriesCombineMode
            Get
                Return Me._barCombineMode
            End Get
            Set(value As ChartSeriesCombineMode)
                If Me._barCombineMode <> value Then
                    Me._barCombineMode = value
                    Me.OnPropertyChanged("BarCombineMode")

                    Me.UpdateLabelsConfiguration(Me._barCombineMode)
                    Me.UpdateAxisConfiguration(Me._barCombineMode)
                End If
            End Set
        End Property

        Public Property ShowLabels() As Boolean
            Get
                Return Me._showLabels
            End Get
            Set(value As Boolean)
                If Me._showLabels <> value Then
                    Me._showLabels = value
                    Me.OnPropertyChanged("ShowLabels")
                End If
            End Set
        End Property

        Public Property IsShowLabelsEnabled() As Boolean
            Get
                Return Me._isShowLabelsEnabled
            End Get
            Set(value As Boolean)
                If Me._isShowLabelsEnabled <> value Then
                    Me._isShowLabelsEnabled = value
                    Me.OnPropertyChanged("IsShowLabelsEnabled")
                End If
            End Set
        End Property

        Public Property ChartOrientation() As Orientation
            Get
                Return Me._chartOrientation
            End Get
            Set(value As Orientation)
                If Me._chartOrientation <> value Then
                    Me._chartOrientation = value
                    Me.OnPropertyChanged("ChartOrientation")
                End If
            End Set
        End Property

        Public Property GapLength() As Double
            Get
                Return Me._gapLength
            End Get
            Set(value As Double)
                If Me._gapLength <> value Then
                    Me._gapLength = value
                    Me.OnPropertyChanged("GapLength")
                End If
            End Set
        End Property

        Public Property AxisMaxValue() As Double
            Get
                Return Me._axisMaxValue
            End Get
            Set(value As Double)
                If Me._axisMaxValue <> value Then
                    Me._axisMaxValue = value
                    Me.OnPropertyChanged("AxisMaxValue")
                End If
            End Set
        End Property

        Public Property AxisStep() As Double
            Get
                Return Me._axisStep
            End Get
            Set(value As Double)
                If Me._axisStep <> value Then
                    Me._axisStep = value
                    Me.OnPropertyChanged("AxisStep")
                End If
            End Set
        End Property

        Public Property AxisTitle() As String
            Get
                Return Me._axisTitle
            End Get
            Set(value As String)
                If Me._axisTitle <> value Then
                    Me._axisTitle = value
                    Me.OnPropertyChanged("AxisTitle")
                End If
            End Set
        End Property

        Public Property AxisLabelFormat() As String
            Get
                Return Me._axisLabelFormat
            End Get
            Set(value As String)
                If Me._axisLabelFormat <> value Then
                    Me._axisLabelFormat = value
                    Me.OnPropertyChanged("AxisLabelFormat")
                End If
            End Set
        End Property

        Private Sub UpdateLabelsConfiguration(mode As ChartSeriesCombineMode)
            Me.ShowLabels = False
            Me.IsShowLabelsEnabled = mode = ChartSeriesCombineMode.Cluster
        End Sub

        Private Sub UpdateAxisConfiguration(mode As ChartSeriesCombineMode)
            If mode = ChartSeriesCombineMode.Cluster Then
                Me.GapLength = 0.2

                Me.AxisMaxValue = 20000.0
                Me.AxisStep = 5000.0

                Me.AxisTitle = "PROFIT (USD)"
                Me.AxisLabelFormat = "N0"
            ElseIf mode = ChartSeriesCombineMode.Stack Then
                Me.GapLength = 0.5

                Me.AxisMaxValue = 70000.0
                Me.AxisStep = 16500.0

                Me.AxisTitle = "PROFIT (USD)"
                Me.AxisLabelFormat = "N0"
            ElseIf mode = ChartSeriesCombineMode.Stack100 Then
                Me.GapLength = 0.5

                Me.AxisMaxValue = 1.0
                Me.AxisStep = 0.25

                Me.AxisTitle = "PROFIT (%)"
                Me.AxisLabelFormat = "P0"
            End If
        End Sub

       
    End Class

End Namespace
