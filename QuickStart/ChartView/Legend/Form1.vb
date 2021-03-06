﻿Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.WinControls.Tests
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.ChartView.Legend
    Partial Public Class Form1

        Private customShape As CustomShape

        Public Sub New()
            InitializeComponent()
            AddHandler radDropDownListLegendPosition.SelectedIndexChanged, AddressOf radDropDownListLegendPosition_SelectedIndexChanged
            AddHandler radDropDownListShapes.SelectedIndexChanged, AddressOf radDropDownListMarkerShape_SelectedIndexChanged
            AddHandler radDropDownListTitlePosition.SelectedIndexChanged, AddressOf radDropDownListTitlePosition_SelectedIndexChanged
            AddHandler radDropDownListLegendPosition.SelectedIndexChanged, AddressOf radDropDownListLegendPosition_SelectedIndexChanged

            AddHandler radRadioButtonHorizontalTitle.ToggleStateChanged, AddressOf radRadioButtonTitleOrientation_ToggleStateChanged
            AddHandler radRadioButtonVerticalTitle.ToggleStateChanged, AddressOf radRadioButtonTitleOrientation_ToggleStateChanged
            AddHandler radRadioButtonHorizontalLegend.ToggleStateChanged, AddressOf radRadioButtonLegendOrientation_ToggleStateChanged
            AddHandler radRadioButtonVerticalLegend.ToggleStateChanged, AddressOf radRadioButtonLegendOrientation_ToggleStateChanged

            AddHandler radSpinEditorLegendX.ValueChanged, AddressOf radSpinEditorFloatingLegendPosition_ValueChanged
            AddHandler radSpinEditorLegendY.ValueChanged, AddressOf radSpinEditorFloatingLegendPosition_ValueChanged
            AddHandler radTextBoxControlTitle.TextChanged, AddressOf radTextBoxControlTitle_TextChanged
            AddHandler radCheckBoxFlipText.ToggleStateChanged, AddressOf radCheckBoxFlipText_ToggleStateChanged
            AddHandler radButtonEditShape.Click, AddressOf radButtonEditShape_Click

        End Sub

        Protected Overrides Sub OnLoad(e As EventArgs)
            MyBase.OnLoad(e)

            Me.radChartView1.ShowTitle = True
            Me.radChartView1.ShowLegend = True
            Me.radChartView1.Title = "OS Platform Statistics Q1 2012"
            Me.radTextBoxControlTitle.Text = Me.radChartView1.Title
            Me.radChartView1.LegendTitle = "Legend"
            Me.radChartView1.ChartElement.LegendElement.Alignment = ContentAlignment.TopCenter
            Me.radDropDownListTitlePosition.DataSource = [Enum].GetValues(GetType(TitlePosition))
            Me.radDropDownListLegendPosition.DataSource = [Enum].GetValues(GetType(LegendPosition))

            Dim [set] As New DataSet()

            Dim windowsXPTable As New DataTable("WindowsXP")
            Dim windows7Table As New DataTable("Windows7")
            Dim linuxTable As New DataTable("Linux")
            Dim macTable As New DataTable("Mac")

            [set].Tables.Add(windowsXPTable)
            [set].Tables.Add(windows7Table)
            [set].Tables.Add(linuxTable)
            [set].Tables.Add(macTable)

            For Each table As DataTable In [set].Tables
                table.Columns.Add("Month")
                table.Columns.Add("Usage", GetType(Double))
            Next

            windowsXPTable.Rows.Add("January", 31.4)
            windowsXPTable.Rows.Add("February", 24.0)
            windowsXPTable.Rows.Add("March", 18.9)

            windows7Table.Rows.Add("January", 27.1)
            windows7Table.Rows.Add("February", 35.7)
            windows7Table.Rows.Add("March", 43.9)

            linuxTable.Rows.Add("January", 6.9)
            linuxTable.Rows.Add("February", 13.0)
            linuxTable.Rows.Add("March", 8.9)

            macTable.Rows.Add("January", 8.0)
            macTable.Rows.Add("February", 12.1)
            macTable.Rows.Add("March", 9.9)

            Me.radChartView1.DataSource = [set]

            Dim windowsXPSeries As New BarSeries("Usage", "Month")
            windowsXPSeries.DataMember = "WindowsXP"
            windowsXPSeries.LegendTitle = "Windows XP"
            Dim windows7Series As New BarSeries("Usage", "Month")
            windows7Series.DataMember = "Windows7"
            windows7Series.LegendTitle = "Windows 7"
            Dim linuxSeries As New BarSeries("Usage", "Month")
            linuxSeries.DataMember = "Linux"
            linuxSeries.LegendTitle = "Linux"
            Dim macSeries As New BarSeries("Usage", "Month")
            macSeries.DataMember = "Mac"
            macSeries.LegendTitle = "Mac"

            Me.radChartView1.Series.AddRange(windowsXPSeries, windows7Series, linuxSeries, macSeries)

            Me.customShape = New CustomShape()
            Me.customShape.CreateClosedShape(CreateInitialShape(5, 100, 60))

            Dim item As New RadListDataItem("CustomShape")
            item.Value = GetType(CustomShape)
            Me.radDropDownListShapes.Items.Add(item)
            item = New RadListDataItem("RectangleShape")
            item.Value = GetType(RoundRectShape)
            Me.radDropDownListShapes.Items.Add(item)
            item = New RadListDataItem("RoundRectShape")
            item.Value = GetType(RoundRectShape)
            Me.radDropDownListShapes.Items.Add(item)
            item = New RadListDataItem("EllipseShape")
            item.Value = GetType(EllipseShape)
            Me.radDropDownListShapes.Items.Add(item)
            item = New RadListDataItem("DonutShape")
            item.Value = GetType(DonutShape)
            Me.radDropDownListShapes.Items.Add(item)
            Me.radDropDownListShapes.SelectedIndex = 1
        End Sub

        Private Function CreateInitialShape(vertices As Integer, radius1 As Double, radius2 As Double) As List(Of PointF)
            Dim pts As New List(Of PointF)()

            For i As Integer = 0 To vertices - 1
                Dim angle1 As Double = ((4.0 * i - vertices) * Math.PI) / (2.0F * vertices)
                Dim angle2 As Double = ((4.0 * i - vertices + 2) * Math.PI) / (2.0F * vertices)
                pts.Add(New PointF(CSng(Math.Cos(angle1) * radius1), CSng(Math.Sin(angle1) * radius1)))
                pts.Add(New PointF(CSng(Math.Cos(angle2) * radius2), CSng(Math.Sin(angle2) * radius2)))
            Next

            Return pts
        End Function

        Private Sub ApplyShapeToPoints(shape As ElementShape)
            For Each legendItem As LegendItemElement In Me.radChartView1.ChartElement.LegendElement.StackElement.Children
                legendItem.MarkerElement.Shape = shape
            Next
        End Sub

        Private Sub radDropDownListTitlePosition_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
            Me.radChartView1.ChartElement.TitlePosition = DirectCast(Me.radDropDownListTitlePosition.SelectedValue, TitlePosition)
        End Sub

        Private Sub radRadioButtonTitleOrientation_ToggleStateChanged(sender As Object, args As StateChangedEventArgs)
            If sender Is Me.radRadioButtonHorizontalTitle Then
                If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On] Then
                    Me.radChartView1.ChartElement.TitleElement.TextOrientation = Orientation.Horizontal
                Else
                    Me.radChartView1.ChartElement.TitleElement.TextOrientation = Orientation.Vertical
                End If
            End If
        End Sub

        Private Sub radDropDownListLegendPosition_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
            Dim position As LegendPosition = DirectCast(Me.radDropDownListLegendPosition.SelectedValue, LegendPosition)
            Me.radChartView1.ChartElement.LegendPosition = position

            If position = LegendPosition.Float Then
                Me.radSpinEditorLegendX.Enabled = True
                Me.radSpinEditorLegendY.Enabled = True
            Else
                Me.radSpinEditorLegendX.Enabled = False
                Me.radSpinEditorLegendY.Enabled = False
            End If
        End Sub

        Private Sub radSpinEditorFloatingLegendPosition_ValueChanged(sender As Object, e As EventArgs)
            If sender Is Me.radSpinEditorLegendX Then
                Me.radChartView1.ChartElement.LegendOffset = New Point(CInt(Me.radSpinEditorLegendX.Value), Me.radChartView1.ChartElement.LegendOffset.Y)
            Else
                Me.radChartView1.ChartElement.LegendOffset = New Point(Me.radChartView1.ChartElement.LegendOffset.X, CInt(Me.radSpinEditorLegendY.Value))
            End If
        End Sub

        Private Sub radRadioButtonLegendOrientation_ToggleStateChanged(sender As Object, args As StateChangedEventArgs)
            If sender Is Me.radRadioButtonHorizontalLegend Then
                If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On] Then
                    Me.radChartView1.ChartElement.LegendElement.StackElement.Orientation = Orientation.Horizontal
                Else
                    Me.radChartView1.ChartElement.LegendElement.StackElement.Orientation = Orientation.Vertical
                End If
            End If
        End Sub

        Private Sub radTextBoxControlTitle_TextChanged(sender As Object, e As EventArgs)
            Me.radChartView1.Title = Me.radTextBoxControlTitle.Text
        End Sub

        Private Sub radCheckBoxFlipText_ToggleStateChanged(sender As Object, args As StateChangedEventArgs)
            Me.radChartView1.ChartElement.TitleElement.FlipText = Me.radCheckBoxFlipText.Checked
            Me.radChartView1.ChartElement.TitleElement.Invalidate()
        End Sub

        Private Sub radDropDownListMarkerShape_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
            Select Case Me.radDropDownListShapes.SelectedIndex
                Case 0
                    Me.ApplyShapeToPoints(Me.customShape)
                    Me.radButtonEditShape.Enabled = True
                    Exit Select
                Case 1
                    Me.ApplyShapeToPoints(New RoundRectShape(0))
                    Me.radButtonEditShape.Enabled = False
                    Exit Select
                Case 2
                    Me.ApplyShapeToPoints(New RoundRectShape(2))
                    Me.radButtonEditShape.Enabled = False
                    Exit Select
                Case 3
                    Me.ApplyShapeToPoints(New EllipseShape())
                    Me.radButtonEditShape.Enabled = False
                    Exit Select
                Case 4
                    Me.ApplyShapeToPoints(New DonutShape())
                    Me.radButtonEditShape.Enabled = False
                    Exit Select
                Case 5
                    Me.ApplyShapeToPoints(New TabOffice12Shape())
                    Me.radButtonEditShape.Enabled = False
                    Exit Select
                Case 6
                    Me.ApplyShapeToPoints(New TabVsShape())
                    Me.radButtonEditShape.Enabled = False
                    Exit Select
            End Select
        End Sub

        Private Sub radButtonEditShape_Click(sender As Object, e As EventArgs)
            If Me.radDropDownListShapes.SelectedIndex = 0 Then
                Dim editor As New CustomShapeEditorForm()
                Me.customShape = editor.EditShape(Me.customShape)
                Me.ApplyShapeToPoints(Me.customShape)
            End If
        End Sub
    End Class
End Namespace