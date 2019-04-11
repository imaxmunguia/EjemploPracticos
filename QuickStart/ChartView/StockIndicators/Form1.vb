Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.Charting

Namespace Telerik.Examples.WinControls.ChartView.StockIndicators
    Partial Public Class Form1

        Private viewModel As CandlestickViewModel
        Private movingAverageIndicators As List(Of String), financialIndicators As List(Of String)
        Private chartTypes As List(Of String)

        Public Sub New()
            InitializeComponent()

            AddHandler radDropDownList1.SelectedIndexChanged, AddressOf radDropDownList1_SelectedIndexChanged
            AddHandler radDropDownList2.SelectedIndexChanged, AddressOf radDropDownList2_SelectedIndexChanged
            AddHandler radDropDownList3.SelectedIndexChanged, AddressOf radDropDownList3_SelectedIndexChanged

            InitializeData()
        End Sub

        Protected Overrides Sub OnLoad(e As EventArgs)
            MyBase.OnLoad(e)

            Me.radDropDownList1.DataSource = chartTypes
            Me.radDropDownList2.DataSource = movingAverageIndicators
            Me.radDropDownList3.DataSource = financialIndicators

            SetCartesianGrid(Me.radChartView1)
            SetCartesianGrid(Me.radChartView2)
            SetTrackBall()

        End Sub

        Private Sub InitializeData()
            viewModel = New CandlestickViewModel()

            chartTypes = New List(Of String)
            chartTypes.Add("OHLC")
            chartTypes.Add("Candlestick")

            movingAverageIndicators = New List(Of String)
            movingAverageIndicators.Add("MA (5)")
            movingAverageIndicators.Add("Exponential MA (5)")
            movingAverageIndicators.Add("Modified MA (5)")
            movingAverageIndicators.Add("Modified Exponential MA (5)")
            movingAverageIndicators.Add("Weighted MA (5)")
            movingAverageIndicators.Add("Adaptive MA Kaufman (10,4,2)")
            movingAverageIndicators.Add("Bollinger Bands (5,2)")

            financialIndicators = New List(Of String)
            financialIndicators.Add("Average True Range (5)")
            financialIndicators.Add("Commodity Channel Index (5)")
            financialIndicators.Add("MACD (12, 9, 6)")
            financialIndicators.Add("Momentum (5)")
            financialIndicators.Add("Oscillator (8, 4)")
            financialIndicators.Add("RAVI (8, 4)")
            financialIndicators.Add("Rate Of Change (8)")
            financialIndicators.Add("Relative Momentum Index (8)")
            financialIndicators.Add("Relative Strength Index (8)")
            financialIndicators.Add("Stochastic Fast (14, 3)")
            financialIndicators.Add("Stochastic Slow (14, 3, 3)")
            financialIndicators.Add("TRIX (8)")
            financialIndicators.Add("True Range")
            financialIndicators.Add("Ultimate Oscillator (6, 9, 12)")
        End Sub

        Private Sub radDropDownList1_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
            UpdateStockSeries()
        End Sub

        Private Sub radDropDownList2_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
            UpdateStockSeries()
        End Sub

        Private Sub UpdateStockSeries()
            Dim horizontalAxis As DateTimeCategoricalAxis = TryCast(Me.radChartView2.Axes(0), DateTimeCategoricalAxis)
            Dim verticalAxis As LinearAxis = TryCast(Me.radChartView2.Axes(1), LinearAxis)

            Me.radChartView2.Series.Clear()

            If Me.radDropDownList1.SelectedItem IsNot Nothing Then
                Dim seriesType As String = Me.radDropDownList1.SelectedItem.Text

                Dim series As OhlcSeries
                If seriesType = "Candlestick" Then
                    series = New CandlestickSeries()
                Else
                    series = New OhlcSeries()
                End If

                series.BorderColor = Color.FromArgb(102, 102, 102)
                series.BackColor = Color.FromArgb(102, 102, 102)
                series.HorizontalAxis = horizontalAxis
                series.VerticalAxis = verticalAxis
                series.OpenValueMember = "Open"
                series.HighValueMember = "High"
                series.LowValueMember = "Low"
                series.CloseValueMember = "Close"
                series.CategoryMember = "Date"
                series.DataSource = viewModel.Data

                Me.radChartView2.Series.Add(series)

                If Not (TypeOf series Is CandlestickSeries) Then
                    For Each point As OhlcPointElement In series.Children
                        If point.IsFalling Then
                            point.BorderColor = Color.FromArgb(175, 175, 175)
                        End If
                    Next
                End If
            End If

            If Me.radDropDownList2.SelectedItem IsNot Nothing Then
                Dim indicator As IndicatorBase = CreateMAIndicator(Me.radDropDownList2.SelectedItem.Text)
                indicator.BorderColor = Color.Red
                indicator.PointSize = SizeF.Empty

                Dim parentIndicator As IParentIndicator = TryCast(indicator, IParentIndicator)
                If parentIndicator IsNot Nothing Then
                    parentIndicator.ChildIndicator.BorderColor = Color.Black
                End If

                Me.radChartView2.Series.Add(indicator)
            End If
        End Sub

        Private Sub radDropDownList3_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
            Me.radChartView1.View.Margin = New System.Windows.Forms.Padding(15, 10, 10, 10)
            UpdateFinancialIndicator(Me.radDropDownList3.SelectedItem.Text)
        End Sub

        Private Sub UpdateFinancialIndicator(indicatorType As String)
            Dim horizontalAxis As DateTimeCategoricalAxis = TryCast(Me.radChartView1.Axes(0), DateTimeCategoricalAxis)
            Dim verticalAxis As LinearAxis = TryCast(Me.radChartView1.Axes(1), LinearAxis)

            Me.radChartView1.Series.Clear()

            Dim indicator As IndicatorBase = CreateFinancialIndicator(indicatorType)
            indicator.HorizontalAxis = horizontalAxis
            indicator.VerticalAxis = verticalAxis
            indicator.PointSize = SizeF.Empty
            indicator.BorderColor = Color.Black

            Dim parentIndicator As IParentIndicator = TryCast(indicator, IParentIndicator)
            If parentIndicator IsNot Nothing Then
                parentIndicator.ChildIndicator.BorderColor = Color.Red
            End If

            Me.radChartView1.Series.Add(indicator)
        End Sub

        Private Sub SetCartesianGrid(chart As RadChartView)
            Dim area As CartesianArea = chart.GetArea(Of CartesianArea)()
            area.ShowGrid = True

            Dim grid As CartesianGrid = area.GetGrid(Of CartesianGrid)()
            grid.DrawHorizontalFills = False
            grid.DrawVerticalFills = False
            grid.DrawHorizontalStripes = True
            grid.DrawVerticalStripes = True
            grid.ForeColor = Color.LightGray
            grid.BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Solid
        End Sub

        Private Sub SetTrackBall()
            Dim trackBallElement As New ChartTrackballController()

            trackBallElement.Element.TextAlignment = ContentAlignment.MiddleLeft
            trackBallElement.Element.BorderColor = Color.Black
            trackBallElement.Element.BackColor = Color.White
            trackBallElement.Element.BorderGradientStyle = Telerik.WinControls.GradientStyles.Solid
            trackBallElement.Element.GradientStyle = Telerik.WinControls.GradientStyles.Solid
            trackBallElement.Element.Padding = New Padding(3, 0, 3, 3)

            Me.radChartView2.Controllers.Add(trackBallElement)
        End Sub


        Private Sub ConfigureAxis(min As Double, max As Double, majorStep As Double)
            Dim axis As LinearAxis = TryCast(Me.radChartView1.Axes(1), LinearAxis)
            If axis Is Nothing Then
                Return
            End If

            axis.Minimum = min
            axis.Maximum = max
            axis.MajorStep = majorStep
        End Sub

        Private Function CreateMAIndicator(indicatorType As String) As IndicatorBase
            Dim indicator As IndicatorBase

            If indicatorType.StartsWith("MA (") Then
                indicator = New MovingAverageIndicator()
                indicator.Name = "MA"
            ElseIf indicatorType.StartsWith("Exponential MA") Then
                indicator = New ExponentialMovingAverageIndicator()
                indicator.Name = "EMA"
            ElseIf indicatorType.StartsWith("Modified MA") Then
                indicator = New ModifiedMovingAverageIndicator()
                indicator.Name = "MMA"
            ElseIf indicatorType.StartsWith("Modified Exponential MA") Then
                indicator = New ModifiedExponentialMovingAverageIndicator()
                indicator.Name = "MEMA"
            ElseIf indicatorType.StartsWith("Weighted MA") Then
                indicator = New WeightedMovingAverageIndicator()
                indicator.Name = "WMA"
            ElseIf indicatorType.StartsWith("Adaptive MA") Then
                indicator = New AdaptiveMovingAverageKaufmanIndicator()
                indicator.Name = "KAMA"
                DirectCast(indicator, AdaptiveMovingAverageKaufmanIndicator).SlowPeriod = 10
                DirectCast(indicator, AdaptiveMovingAverageKaufmanIndicator).FastPeriod = 4
            Else
                indicator = New BollingerBandsIndicator()
                indicator.Name = "BOLL"
                DirectCast(indicator, BollingerBandsIndicator).StandardDeviations = 2
            End If

            DirectCast(indicator, ValuePeriodIndicatorBase).Period = 5
            indicator.CategoryMember = "Date"
            indicator.ValueMember = "Close"
            indicator.DataSource = viewModel.Data

            Return indicator
        End Function

        Private Function CreateFinancialIndicator(indicatorType As String) As IndicatorBase
            If indicatorType.StartsWith("Average True Range") Then
                Return CreateAverageTrueRangeIndicator()
            ElseIf indicatorType.StartsWith("Commodity Channel Index") Then
                Return CreateCommodityChannelIndexIndicator()
            ElseIf indicatorType.StartsWith("MACD") Then
                Return CreateMACDIndicator()
            ElseIf indicatorType.StartsWith("Momentum") Then
                Return CreateMomentumIndicator()
            ElseIf indicatorType.StartsWith("Oscillator") Then
                Return CreateOscillatorIndicator()
            ElseIf indicatorType.StartsWith("RAVI") Then
                Return CreateRaviIndicator()
            ElseIf indicatorType.StartsWith("Rate Of Change") Then
                Return CreateRateOfChangeIndicator()
            ElseIf indicatorType.StartsWith("Relative Momentum Index") Then
                Return CreateRelativeMomentumIndexIndicator()
            ElseIf indicatorType.StartsWith("Relative Strength Index") Then
                Return CreateRelativeStrengthIndexIndicator()
            ElseIf indicatorType.StartsWith("Stochastic Fast") Then
                Return CreateStochasticFastIndicator()
            ElseIf indicatorType.StartsWith("Stochastic Slow") Then
                Return CreateStochasticSlowIndicator()
            ElseIf indicatorType.StartsWith("True Range") Then
                Return CreateTrueRangeIndicator()
            ElseIf indicatorType.StartsWith("TRIX") Then
                Return CreateTrixIndicator()
            End If
            Return CreateUltimateOscillatorIndicator()
        End Function

        Private Function CreateAverageTrueRangeIndicator() As AverageTrueRangeIndicator
            Dim indicator As New AverageTrueRangeIndicator()
            indicator.Period = 5
            indicator.CategoryMember = "Date"
            indicator.HighValueMember = "High"
            indicator.LowValueMember = "Low"
            indicator.CloseValueMember = "Close"
            indicator.DataSource = viewModel.Data

            ConfigureAxis(0, 5, 1)

            Return indicator
        End Function

        Private Function CreateCommodityChannelIndexIndicator() As CommodityChannelIndexIndicator
            Dim indicator As New CommodityChannelIndexIndicator()
            indicator.Period = 5
            indicator.CategoryMember = "Date"
            indicator.HighValueMember = "High"
            indicator.LowValueMember = "Low"
            indicator.CloseValueMember = "Close"
            indicator.DataSource = viewModel.Data

            ConfigureAxis(-200, 200, 100)

            Return indicator
        End Function


        Private Function CreateMACDIndicator() As IndicatorBase
            Dim indicator As New MacdIndicator()
            indicator.ShortPeriod = 9
            indicator.LongPeriod = 12
            indicator.SignalPeriod = 6
            indicator.CategoryMember = "Date"
            indicator.ValueMember = "Close"
            indicator.DataSource = viewModel.Data

            ConfigureAxis(-2, 2, 1)

            Return indicator
        End Function

        Private Function CreateMomentumIndicator() As MomentumIndicator
            Dim indicator As New MomentumIndicator()
            indicator.Period = 8
            indicator.CategoryMember = "Date"
            indicator.ValueMember = "Close"
            indicator.DataSource = viewModel.Data

            ConfigureAxis(80, 120, 10)

            Return indicator
        End Function

        Private Function CreateOscillatorIndicator() As OscillatorIndicator
            Dim indicator As New OscillatorIndicator()
            indicator.ShortPeriod = 4
            indicator.LongPeriod = 8
            indicator.CategoryMember = "Date"
            indicator.ValueMember = "Close"
            indicator.DataSource = viewModel.Data

            ConfigureAxis(-5, 5, 5)

            Return indicator
        End Function

        Private Function CreateRaviIndicator() As RaviIndicator
            Dim indicator As New RaviIndicator()
            indicator.ShortPeriod = 4
            indicator.LongPeriod = 8
            indicator.CategoryMember = "Date"
            indicator.ValueMember = "Close"
            indicator.DataSource = viewModel.Data

            ConfigureAxis(-5, 5, 5)

            Return indicator
        End Function

        Private Function CreateRateOfChangeIndicator() As RateOfChangeIndicator
            Dim indicator As New RateOfChangeIndicator()
            indicator.Period = 8
            indicator.CategoryMember = "Date"
            indicator.ValueMember = "Close"
            indicator.DataSource = viewModel.Data

            ConfigureAxis(-20, 20, 10)

            Return indicator
        End Function

        Private Function CreateRelativeMomentumIndexIndicator() As RelativeMomentumIndexIndicator
            Dim indicator As New RelativeMomentumIndexIndicator()
            indicator.Period = 8
            indicator.CategoryMember = "Date"
            indicator.ValueMember = "Close"
            indicator.DataSource = viewModel.Data

            ConfigureAxis(0, 100, 20)

            Return indicator
        End Function

        Private Function CreateRelativeStrengthIndexIndicator() As RelativeStrengthIndexIndicator
            Dim indicator As New RelativeStrengthIndexIndicator()
            indicator.Period = 8
            indicator.CategoryMember = "Date"
            indicator.ValueMember = "Close"
            indicator.DataSource = viewModel.Data

            ConfigureAxis(0, 100, 20)

            Return indicator
        End Function

        Private Function CreateStochasticFastIndicator() As StochasticFastIndicator
            Dim indicator As New StochasticFastIndicator()
            indicator.MainPeriod = 14
            indicator.SignalPeriod = 3
            indicator.CategoryMember = "Date"
            indicator.HighValueMember = "High"
            indicator.LowValueMember = "Low"
            indicator.CloseValueMember = "Close"
            indicator.DataSource = viewModel.Data

            ConfigureAxis(0, 100, 20)

            Return indicator
        End Function

        Private Function CreateStochasticSlowIndicator() As StochasticSlowIndicator
            Dim indicator As New StochasticSlowIndicator()
            indicator.MainPeriod = 14
            indicator.SignalPeriod = 3
            indicator.SlowingPeriod = 3
            indicator.CategoryMember = "Date"
            indicator.HighValueMember = "High"
            indicator.LowValueMember = "Low"
            indicator.CloseValueMember = "Close"
            indicator.DataSource = viewModel.Data

            ConfigureAxis(0, 100, 20)

            Return indicator
        End Function

        Private Function CreateTrixIndicator() As TrixIndicator
            Dim indicator As New TrixIndicator()
            indicator.Period = 8
            indicator.CategoryMember = "Date"
            indicator.ValueMember = "Close"
            indicator.DataSource = viewModel.Data

            ConfigureAxis(-1, 1, 0.5)

            Return indicator
        End Function

        Private Function CreateTrueRangeIndicator() As TrueRangeIndicator
            Dim indicator As New TrueRangeIndicator()
            indicator.CategoryMember = "Date"
            indicator.HighValueMember = "High"
            indicator.LowValueMember = "Low"
            indicator.CloseValueMember = "Close"
            indicator.DataSource = viewModel.Data

            ConfigureAxis(0, 6, 1)

            Return indicator
        End Function

        Private Function CreateUltimateOscillatorIndicator() As UltimateOscillatorIndicator
            Dim indicator As New UltimateOscillatorIndicator()
            indicator.Period = 6
            indicator.Period2 = 9
            indicator.Period3 = 12
            indicator.CategoryMember = "Date"
            indicator.CloseValueMember = "Close"
            indicator.HighValueMember = "High"
            indicator.LowValueMember = "Low"
            indicator.DataSource = viewModel.Data

            ConfigureAxis(0, 100, 20)

            Return indicator
        End Function
    End Class
End Namespace
