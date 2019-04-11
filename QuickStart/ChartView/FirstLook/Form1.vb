Imports System
Imports System.Collections.Generic
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports System.Windows.Forms
Imports Telerik.Charting
Imports System.Data
Imports System.Drawing
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.ChartView.FirstLook
    ''' <summary>
    ''' RadChartView example
    ''' </summary>
    Partial Public Class Form1
        Inherits ExamplesForm
        Private model As OrderViewModel

        Public Sub New()
            InitializeComponent()
            Me.SetEnabledQsfbButton(QSFButtons.ChangeTheme, False)
        End Sub

        Protected Overrides Sub OnLoad(e As EventArgs)
            MyBase.OnLoad(e)

            model = New OrderViewModel()

            InitializeBarSeries()
            InitializePieSeries()
            InitializeLineSeries()
            InitalizeGrid()

            AddHandler radChartView1.Paint, AddressOf radChartView1_Paint
            AddHandler radChartView2.Paint, AddressOf radChartView2_Paint
            AddHandler radChartView3.Paint, AddressOf radChartView3_Paint
        End Sub

        Private Sub InitalizeGrid()
            'AddHandler radGridView1.CellBeginEdit, AddressOf radGridView1_CreateCell
            Me.radGridView1.TableElement.RowHeight = 40
            Me.radGridView1.[ReadOnly] = True
            Me.radGridView1.AutoExpandGroups = True
            Me.radGridView1.AllowAddNewRow = False
            Me.radGridView1.AllowColumnReorder = False
            Me.radGridView1.EnableSorting = False
            Me.radGridView1.ShowGroupPanel = False
            Me.radGridView1.ShowRowHeaderColumn = False
            Me.radGridView1.ForeColor = Color.Black

            Dim textBoxColumn As New GridViewTextBoxColumn()
            textBoxColumn.Name = "Name"
            textBoxColumn.HeaderText = "Name"
            textBoxColumn.FieldName = "Name"
            textBoxColumn.Width = 110
            textBoxColumn.TextAlignment = ContentAlignment.BottomRight
            radGridView1.MasterTemplate.Columns.Add(textBoxColumn)

            Dim textBoxColumn2 As New GridViewTextBoxColumn()
            textBoxColumn2.Name = "Snacks"
            textBoxColumn2.HeaderText = "Snacks"
            textBoxColumn2.FieldName = "Snacks"
            textBoxColumn2.Width = 150
            textBoxColumn2.TextAlignment = ContentAlignment.BottomRight
            radGridView1.MasterTemplate.Columns.Add(textBoxColumn2)

            Dim textBoxColumn3 As New GridViewTextBoxColumn()
            textBoxColumn3.Name = "Beverages"
            textBoxColumn3.HeaderText = "Beverages"
            textBoxColumn3.FieldName = "Beverages"
            textBoxColumn3.Width = 150
            textBoxColumn3.TextAlignment = ContentAlignment.BottomRight
            radGridView1.MasterTemplate.Columns.Add(textBoxColumn3)

            Me.radGridView1.Rows.Add("Europe", Nothing, Nothing)
            Me.radGridView1.Rows.Add("North America", Nothing, Nothing)
            Me.radGridView1.Rows.Add("Asia", Nothing, Nothing)
            Me.radGridView1.Rows.Add("Other", Nothing, Nothing)

            Me.radGridView1.ThemeName = "TelerikMetro"
        End Sub

        Private Sub radGridView1_CreateCell(sender As Object, e As GridViewCreateCellEventArgs) Handles radGridView1.CreateCell
            If e.CellType.Equals(GetType(GridDataCellElement)) AndAlso (e.Column.Name = "Snacks" OrElse e.Column.Name = "Beverages") Then
                e.CellType = GetType(ChartCellElement)
            End If
        End Sub

        Private Sub InitializeLineSeries()
            Dim lineSeries1 As New LineSeries()
            lineSeries1.Name = "Snacks"
            lineSeries1.PointSize = New SizeF(0, 0)
            lineSeries1.BorderWidth = 2
            lineSeries1.DataSource = model.LineStackData
            lineSeries1.ValueMember = "Value"
            lineSeries1.CategoryMember = "Month"
            Me.radChartView3.Series.Add(lineSeries1)

            Dim lineSeries2 As New LineSeries()
            lineSeries2.Name = "Beverages"
            lineSeries2.PointSize = New SizeF(0, 0)
            lineSeries2.BorderWidth = 2
            lineSeries2.ValueMember = "Value"
            lineSeries2.CategoryMember = "Month"
            lineSeries2.DataSource = model.LineBeverageData
            Me.radChartView3.Series.Add(lineSeries2)
        End Sub

        Private Sub InitializePieSeries()
            Dim pieSeries As New PieSeries()
            pieSeries.ValueMember = "Value"
            pieSeries.DataSource = model.Regions
            pieSeries.ShowLabels = True

            Dim regionNames As String() = New String() {"Europe", "North America", "Asia", "Other"}
            For i As Integer = 0 To pieSeries.DataPoints.Count - 1
                DirectCast(pieSeries.DataPoints(i), PieDataPoint).Name = regionNames(i)
            Next

            Me.radChartView2.Series.Add(pieSeries)
        End Sub

        Private Sub InitializeBarSeries()
            Dim barSeries As New BarSeries()
            barSeries.Name = "Snacks"
            barSeries.ValueMember = "Value"
            barSeries.CategoryMember = "Month"
            barSeries.DataSource = model.BarSnackData
            Me.radChartView1.Series.Add(barSeries)

            Dim barSeries2 As New BarSeries()
            barSeries2.Name = "Beverages"
            barSeries2.DataSource = model.BarBeverageData
            barSeries2.ValueMember = "Value"
            barSeries2.CategoryMember = "Month"
            Me.radChartView1.Series.Add(barSeries2)

            For i As Integer = 0 To Me.radChartView1.Series.Count - 1
                Me.radChartView1.GetSeries(Of BarSeries)(i).CombineMode = ChartSeriesCombineMode.Stack
            Next
        End Sub

        Private Sub radChartView3_Paint(sender As Object, e As PaintEventArgs)
            Me.legend3.BuildLegend(Me.radChartView3.ChartElement)
        End Sub

        Private Sub radChartView2_Paint(sender As Object, e As PaintEventArgs)
            Me.legend2.BuildLegend(Me.radChartView2.ChartElement)
        End Sub

        Private Sub radChartView1_Paint(sender As Object, e As PaintEventArgs)
            Me.legend1.BuildLegend(Me.radChartView1.ChartElement)
        End Sub
    End Class

    Public Class CustomTableLayoutPanel
        Inherits TableLayoutPanel
        Public Sub New()
            MyBase.New()
            Me.DoubleBuffered = True
        End Sub
    End Class
End Namespace