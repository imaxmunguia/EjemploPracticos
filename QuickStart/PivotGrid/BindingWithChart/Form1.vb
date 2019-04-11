Imports Telerik.Pivot.DataProviders
Imports System.IO
Imports Telerik.WinControls.UI
Imports System.Drawing
Imports Telerik.Pivot.Core
Imports System.Collections.Generic
Imports Telerik.Examples.WinControls.PivotGrid
Imports System
Imports Telerik.Charting
Imports Microsoft.VisualBasic
Imports Telerik.Pivot.Core.Aggregates

Namespace Telerik.Examples.WinControls.PivotGrid.BindingWithChart

    Public Class Form1
        Private orders As New List(Of Order2)()
        Private provider As LocalDataSourceProvider

        Public Sub New()
            Me.InitializeComponent()

            Me.LoadData()
            Me.SetupAxes()
            Me.SetupPivot()
            Me.LoadSettings()
            Me.WireEvents()
        End Sub

        Private Sub LoadSettings()
            Me.radChartView1.ChartElement.LegendPosition = LegendPosition.Right
            Me.radChartView1.ChartElement.LegendElement.Alignment = ContentAlignment.TopCenter

            Me.checkBoxDelayUpdates.Checked = Me.radPivotGrid1.ChartDataProvider.DelayUpdate
            Me.checkBoxSelectionOnly.Checked = Me.radPivotGrid1.ChartDataProvider.SelectionOnly
            Me.checkBoxColumnSubTotals.Checked = Me.radPivotGrid1.ChartDataProvider.IncludeColumnSubTotals
            Me.checkBoxRowSubTotals.Checked = Me.radPivotGrid1.ChartDataProvider.IncludeRowSubTotals
            Me.checkBoxColumnGrandTotals.Checked = Me.radPivotGrid1.ChartDataProvider.IncludeColumnGrandTotals
            Me.checkBoxRowGrandTotals.Checked = Me.radPivotGrid1.ChartDataProvider.IncludeRowGrandTotals

            If Me.radPivotGrid1.ChartDataProvider.SeriesAxis = PivotAxis.Rows Then
                Me.radioRows.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            Else
                Me.radioColumns.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            End If

            If Me.radPivotGrid1.ChartDataProvider.GeneratedSeriesType = GeneratedSeriesType.Bar Then
                Me.radioBarSeries.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            ElseIf Me.radPivotGrid1.ChartDataProvider.GeneratedSeriesType = GeneratedSeriesType.Line Then
                Me.radioLineSeries.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            ElseIf Me.radPivotGrid1.ChartDataProvider.GeneratedSeriesType = GeneratedSeriesType.Area Then
                Me.radioAreaSeries.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            End If
        End Sub

        Private Sub SetupAxes()
            Dim verticalAxis As New LinearAxis()
            verticalAxis.AxisType = AxisType.Second

            Dim horizontalAxis As New CategoricalAxis()
            horizontalAxis.LabelFitMode = AxisLabelFitMode.MultiLine

            Me.radChartView1.Area.Axes.Add(horizontalAxis)
            Me.radChartView1.Area.Axes.Add(verticalAxis)
        End Sub

        Private Sub WireEvents()
            AddHandler Me.checkBoxDelayUpdates.ToggleStateChanged, AddressOf checkBox_ToggleStateChanged
            AddHandler Me.checkBoxSelectionOnly.ToggleStateChanged, AddressOf checkBox_ToggleStateChanged
            AddHandler Me.checkBoxColumnSubTotals.ToggleStateChanged, AddressOf checkBox_ToggleStateChanged
            AddHandler Me.checkBoxRowSubTotals.ToggleStateChanged, AddressOf checkBox_ToggleStateChanged
            AddHandler Me.checkBoxColumnGrandTotals.ToggleStateChanged, AddressOf checkBox_ToggleStateChanged
            AddHandler Me.checkBoxRowGrandTotals.ToggleStateChanged, AddressOf checkBox_ToggleStateChanged

            AddHandler Me.radioRows.ToggleStateChanged, AddressOf radioRows_ToggleStateChanged
            AddHandler Me.radioColumns.ToggleStateChanged, AddressOf radioRows_ToggleStateChanged

            AddHandler Me.radioBarSeries.ToggleStateChanged, AddressOf radioSeries_ToggleStateChanged
            AddHandler Me.radioLineSeries.ToggleStateChanged, AddressOf radioSeries_ToggleStateChanged
            AddHandler Me.radioAreaSeries.ToggleStateChanged, AddressOf radioSeries_ToggleStateChanged

            AddHandler Me.radPivotGrid1.ChartDataProvider.UpdateCompleted, AddressOf ChartDataProvider_UpdateCompleted

        End Sub

        Private Sub radioSeries_ToggleStateChanged(sender As Object, args As StateChangedEventArgs)
            If Me.radioBarSeries.IsChecked Then
                Me.radPivotGrid1.ChartDataProvider.GeneratedSeriesType = GeneratedSeriesType.Bar
            ElseIf Me.radioAreaSeries.IsChecked Then

                Me.radPivotGrid1.ChartDataProvider.GeneratedSeriesType = GeneratedSeriesType.Area
            ElseIf Me.radioLineSeries.IsChecked Then
                Me.radPivotGrid1.ChartDataProvider.GeneratedSeriesType = GeneratedSeriesType.Line
            End If

            UpdateAxesPlotMode()
        End Sub


        Private Sub ChartDataProvider_UpdateCompleted(sender As Object, e As EventArgs)
            UpdateSeriesCombineMode()
        End Sub

        Private Sub UpdateAxesPlotMode()
            Dim axis As CategoricalAxis = TryCast(Me.radChartView1.Axes(0), CategoricalAxis)
            If axis IsNot Nothing Then
                If Me.radPivotGrid1.ChartDataProvider.GeneratedSeriesType = GeneratedSeriesType.Bar Then
                    axis.PlotMode = Telerik.Charting.AxisPlotMode.BetweenTicks
                Else
                    axis.PlotMode = AxisPlotMode.OnTicksPadded
                End If
            End If
        End Sub

        Private Sub UpdateSeriesCombineMode()
            If Me.radPivotGrid1.ChartDataProvider.GeneratedSeriesType <> GeneratedSeriesType.Bar Then
                For Each series As CartesianSeries In Me.radChartView1.Series
                    series.CombineMode = ChartSeriesCombineMode.Stack
                Next
            End If
        End Sub

        Private Sub radioRows_ToggleStateChanged(sender As Object, args As StateChangedEventArgs)
            Me.radPivotGrid1.ChartDataProvider.SeriesAxis = If(Me.radioRows.IsChecked, PivotAxis.Rows, PivotAxis.Columns)
        End Sub

        Private Sub checkBox_ToggleStateChanged(sender As Object, args As StateChangedEventArgs)
            If sender Is Me.checkBoxDelayUpdates Then
                Me.radPivotGrid1.ChartDataProvider.DelayUpdate = Me.checkBoxDelayUpdates.Checked
            ElseIf sender Is Me.checkBoxSelectionOnly Then
                Me.radPivotGrid1.ChartDataProvider.SelectionOnly = Me.checkBoxSelectionOnly.Checked
            ElseIf sender Is Me.checkBoxColumnSubTotals Then
                Me.radPivotGrid1.ChartDataProvider.IncludeColumnSubTotals = Me.checkBoxColumnSubTotals.Checked
            ElseIf sender Is Me.checkBoxRowSubTotals Then
                Me.radPivotGrid1.ChartDataProvider.IncludeRowSubTotals = Me.checkBoxRowSubTotals.Checked
            ElseIf sender Is Me.checkBoxColumnGrandTotals Then
                Me.radPivotGrid1.ChartDataProvider.IncludeColumnGrandTotals = Me.checkBoxColumnGrandTotals.Checked
            ElseIf sender Is Me.checkBoxRowGrandTotals Then
                Me.radPivotGrid1.ChartDataProvider.IncludeRowGrandTotals = Me.checkBoxRowGrandTotals.Checked
            End If
        End Sub

        Private Sub SetupPivot()
            Me.provider = New LocalDataSourceProvider() With { _
             .ItemsSource = Me.orders _
            }

            Me.provider.RowGroupDescriptions.Add(New PropertyGroupDescription() With { _
             .PropertyName = "Product", _
             .GroupComparer = New GroupNameComparer() _
            })

            Me.provider.ColumnGroupDescriptions.Add(New DateTimeGroupDescription() With { _
             .PropertyName = "Date", _
             .[Step] = DateTimeStep.Month _
            })
            Me.provider.ColumnGroupDescriptions.Add(New PropertyGroupDescription() With { _
             .PropertyName = "Promotion", _
             .GroupComparer = New GroupNameComparer() _
            })

            Me.provider.AggregateDescriptions.Add(New PropertyAggregateDescription() With { _
             .PropertyName = "Quantity", _
             .CustomName = "Avg. Quantity", _
             .AggregateFunction = AggregateFunctions.Average _
            })

            Me.radPivotGrid1.PivotGridElement.DataProvider = Me.provider
            Me.radPivotGrid1.PivotGridElement.RefreshData()

            Me.radChartView1.DataSource = Me.radPivotGrid1

            Dim firstNode As PivotGroupNode = Me.radPivotGrid1.PivotGridElement.ColumnRootGroup.Children(0)
            Me.radPivotGrid1.PivotGridElement.SelectColumn(firstNode)
        End Sub

        Private Sub LoadData()
            Dim stream As Stream = System.Reflection.Assembly.GetAssembly(Me.[GetType]()).GetManifestResourceStream("PivotData.txt")

            Using streamReader As New StreamReader(stream)
                While streamReader.Peek() <> -1
                    Dim items As String() = streamReader.ReadLine().Split(ControlChars.Tab)
                    Dim o As New Order2() With { _
                     .[Date] = DateTime.Parse(items(0), System.Globalization.CultureInfo.InvariantCulture), _
                     .Product = items(1), _
                     .Quantity = Integer.Parse(items(2), System.Globalization.CultureInfo.InvariantCulture), _
                     .Net = Double.Parse(items(3), System.Globalization.CultureInfo.InvariantCulture), _
                     .Promotion = items(4), _
                     .Advertisement = items(5) _
                    }
                    Me.orders.Add(o)
                End While
            End Using
        End Sub

    End Class

End Namespace