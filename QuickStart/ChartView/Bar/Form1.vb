Imports System
Imports System.Windows.Forms
Imports Telerik.Charting
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.ChartView.Bar
    ''' <summary>
    ''' RadTreeView example
    ''' </summary>
    Partial Public Class Form1
        Inherits ExamplesForm
        Public Sub New()
            InitializeComponent()

            Me.SelectedControl = Me.radChartView1

            Me.SetEnabledQsfbButton(QSFButtons.ChangeTheme, False)
        End Sub

        Protected Overrides Sub OnLoad(e As EventArgs)
            MyBase.OnLoad(e)

            Dim area As CartesianArea = Me.radChartView1.GetArea(Of CartesianArea)()
            area.ShowGrid = True

            Me.radDropDownList1.SelectedIndex = 0

            Dim verticalAcix As New LinearAxis()
            verticalAcix.AxisType = AxisType.Second
            Dim horizontalAxis As New CategoricalAxis()
            Dim model As New PerformanceModel()

            For i As Integer = 0 To 3
                Dim barSeries As New BarSeries("Performance", "RepresentativeName")
                barSeries.HorizontalAxis = horizontalAxis
                barSeries.VerticalAxis = verticalAcix
                barSeries.DataSource = model.GetData(i)
                Me.radChartView1.Series.Add(barSeries)
                For Each pointElement As DataPointElement In barSeries.Children
                    pointElement.BorderWidth = 0
                Next
            Next

            Dim theme As Theme = theme.ReadCSSText("theme{name: ControlDefault;elementType: Telerik.WinControls.UI.RadChartElement; controlType: Telerik.WinControls.UI.RadChartView; }Bar{    HeightAspectRatio{  Value: 0.9;EndValue: 1;MaxValue: 1;Frames: 30;Interval: 20;EasingType: InOutCubic;RandomDelay: 200;RemoveAfterApply: true; }}")
            ThemeRepository.Add(theme, False)
        End Sub

        Private Sub showLabelsCheckBox_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles showLabelsCheckBox.ToggleStateChanged
            For i As Integer = 0 To Me.radChartView1.Series.Count - 1
                Dim barSeries As BarSeries = Me.radChartView1.GetSeries(Of BarSeries)(i)
                barSeries.ShowLabels = Not barSeries.ShowLabels
            Next
        End Sub

        Private Sub orientationCheckBox_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles orientationCheckBox.ToggleStateChanged
            Dim grid As CartesianGrid = Me.radChartView1.GetArea(Of CartesianArea)().GetGrid(Of CartesianGrid)()

            If Me.orientationCheckBox.IsChecked Then
                Me.radChartView1.GetArea(Of CartesianArea)().Orientation = Orientation.Horizontal
                grid.DrawVerticalStripes = True
                grid.DrawHorizontalStripes = False
            Else
                Me.radChartView1.GetArea(Of CartesianArea)().Orientation = Orientation.Vertical
                grid.DrawVerticalStripes = False
                grid.DrawHorizontalStripes = True
            End If
        End Sub

        Private Sub radDropDownList1_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles radDropDownList1.SelectedIndexChanged
            If Me.radChartView1.Series.Count = 0 Then
                Return
            End If

            Dim combineMode As ChartSeriesCombineMode = ChartSeriesCombineMode.None
            If radDropDownList1.SelectedIndex = 0 Then
                combineMode = ChartSeriesCombineMode.Cluster
            ElseIf radDropDownList1.SelectedIndex = 1 Then
                combineMode = ChartSeriesCombineMode.Stack
            ElseIf radDropDownList1.SelectedIndex = 2 Then
                combineMode = ChartSeriesCombineMode.Stack100
            End If

            For i As Integer = 0 To Me.radChartView1.Series.Count - 1
                Me.radChartView1.GetSeries(Of BarSeries)(i).CombineMode = combineMode
            Next
        End Sub
    End Class
End Namespace
