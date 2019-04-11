Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.ChartView.LiveData
    Partial Public Class Form1

        Private model As New LiveDataModel()
        Private font As New Font("Segoe UI", 12.0F, System.Drawing.FontStyle.Regular)

        Public Sub New()
            InitializeComponent()

            AddHandler Me.Load, AddressOf Form1_Load
            AddHandler Me.Leave, AddressOf Form1_Leave

            InitializeChart1()
            InitializeChart2()
            Me.SetEnabledQsfbButton(QSFButtons.ChangeTheme, False)
        End Sub

        Private Sub Form1_Load(sender As Object, e As EventArgs)
            model.StartTimer()
            AddHandler model.PropertyChanged, AddressOf model_PropertyChanged
        End Sub

        Private Sub Form1_Leave(sender As Object, e As EventArgs)
            model.StopTimer()
            RemoveHandler model.PropertyChanged, AddressOf model_PropertyChanged
        End Sub

        Private Sub InitializeChart1()
            Dim area As CartesianArea = Me.radChartView1.GetArea(Of CartesianArea)()
            Dim grid As CartesianGrid = area.GetGrid(Of CartesianGrid)()
            grid.ForeColor = Color.FromArgb(235, 235, 235)
            grid.DrawVerticalStripes = False
            grid.DrawHorizontalStripes = True
            grid.DrawHorizontalFills = False
            grid.DrawVerticalFills = False
            area.ShowGrid = True

            Dim lineSeries As New LineSeries()
            lineSeries.PointSize = New SizeF(0, 0)
            lineSeries.CategoryMember = "Category"
            lineSeries.ValueMember = "Value"
            lineSeries.DataSource = model.Data
            lineSeries.BorderColor = Color.FromArgb(142, 196, 65)
            lineSeries.BorderWidth = 2

            Me.radChartView1.Series.Add(lineSeries)

            Me.radChartView1.ChartElement.TitlePosition = TitlePosition.Top
            Me.radChartView1.ChartElement.TitleElement.TextAlignment = ContentAlignment.MiddleLeft
            Me.radChartView1.ChartElement.TitleElement.Margin = New Padding(10, 10, 0, 0)
            Me.radChartView1.ChartElement.TitleElement.Font = font
            Me.radChartView1.View.Margin = New Padding(10, 0, 35, 0)

            Dim axeY As LinearAxis = radChartView1.Axes.[Get](Of LinearAxis)(1)
            axeY.Minimum = 500
            axeY.Maximum = 2000
            axeY.MajorStep = 500

            Dim axeX As CategoricalAxis = radChartView1.Axes.[Get](Of CategoricalAxis)(0)
            axeX.LabelInterval = 5
            axeX.LabelFormat = "{0:HH:mm:ss.f}"
            axeX.LastLabelVisibility = Charting.AxisLastLabelVisibility.Visible
        End Sub

        Private Sub InitializeChart2()
            Dim area As CartesianArea = Me.radChartView2.GetArea(Of CartesianArea)()
            Dim grid As CartesianGrid = area.GetGrid(Of CartesianGrid)()
            grid.ForeColor = Color.FromArgb(235, 235, 235)
            grid.DrawVerticalStripes = False
            grid.DrawHorizontalStripes = True
            grid.DrawHorizontalFills = False
            grid.DrawVerticalFills = False
            area.ShowGrid = True

            Dim trackball As New ChartTrackballController()
            trackball.IsFixedSize = True
            trackball.FixedSize = New System.Drawing.Size(150, 30)
            AddHandler trackball.TextNeeded, AddressOf trackball_TextNeeded
            Me.radChartView2.Controllers.Add(trackball)

            Dim areaSeries As New AreaSeries()
            areaSeries.Spline = False
            areaSeries.CategoryMember = "Category"
            areaSeries.ValueMember = "Value"
            areaSeries.DataSource = model.Data2
            areaSeries.PointSize = New SizeF(0, 0)
            areaSeries.BorderColor = Color.FromArgb(142, 196, 65)
            areaSeries.BackColor = Color.FromArgb(150, Color.FromArgb(142, 196, 65))

            Me.radChartView2.Series.Add(areaSeries)

            Me.radChartView2.ChartElement.TitlePosition = TitlePosition.Top
            Me.radChartView2.ChartElement.TitleElement.TextAlignment = ContentAlignment.MiddleLeft
            Me.radChartView2.ChartElement.TitleElement.Margin = New Padding(10, 10, 0, 0)
            Me.radChartView2.ChartElement.TitleElement.Font = font
            Me.radChartView2.View.Margin = New Padding(10, 0, 0, 10)

            Dim axeY As LinearAxis = radChartView2.Axes.[Get](Of LinearAxis)(1)
            axeY.Minimum = 3000
            axeY.Maximum = 4200

            Dim axeX As CategoricalAxis = radChartView2.Axes.[Get](Of CategoricalAxis)(0)
            axeX.LabelInterval = 2
            axeX.LabelFormat = "{0:HH}"
            axeX.LastLabelVisibility = Charting.AxisLastLabelVisibility.Visible

        End Sub

        Private Sub trackball_TextNeeded(sender As Object, e As TextNeededEventArgs)
            Dim dataItem As ChartBusinessObject = TryCast(e.Points(0).DataPoint.DataItem, ChartBusinessObject)
            If dataItem Is Nothing Then
                Return
            End If

            Dim textBuilder As New StringBuilder()
            textBuilder.Append("<html><color=255,0,0,0>")
            textBuilder.Append([String].Format("Online users at {0:HH}h:<b>{1}</b>", dataItem.Category, dataItem.Value))
            textBuilder.Append("</html>")
            e.Text = textBuilder.ToString()
            e.Element.BorderBoxStyle = BorderBoxStyle.FourBorders
            e.Element.Location = New Point(e.Element.Location.X, 0)
        End Sub

        Private Sub model_PropertyChanged(sender As Object, e As PropertyChangedEventArgs)
            Me.exampleCustomShapeControl1.LeftText = model.MessagesPerSecond
            Me.exampleCustomShapeControl2.LeftText = model.MessagesPerMinute
        End Sub
    End Class
End Namespace