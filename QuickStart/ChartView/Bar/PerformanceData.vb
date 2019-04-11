Namespace Telerik.Examples.WinControls.ChartView.Bar
    Public Class PerformanceData
        Private _quarter As String
        Private _name As String
        Private _performance As Double

        Public Sub New(name As String, quarter As String, performance As Double)
            Me._name = name
            Me._quarter = quarter
            Me._performance = performance
        End Sub

        Public ReadOnly Property QuarterName() As String
            Get
                Return Me._quarter
            End Get
        End Property

        Public ReadOnly Property RepresentativeName() As String
            Get
                Return Me._name
            End Get
        End Property

        Public ReadOnly Property Performance() As Double
            Get
                Return Me._performance
            End Get
        End Property
    End Class
End Namespace
