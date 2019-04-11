Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.Chart.EmptyValues
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As Global.System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim corners1 As New Global.Telerik.Charting.Styles.Corners()
			Dim corners2 As New Global.Telerik.Charting.Styles.Corners()
			Dim unit1 As New Global.Telerik.Charting.Styles.Unit()
			Dim unit2 As New Global.Telerik.Charting.Styles.Unit()
			Dim unit3 As New Global.Telerik.Charting.Styles.Unit()
			Dim corners3 As New Global.Telerik.Charting.Styles.Corners()
			Dim corners4 As New Global.Telerik.Charting.Styles.Corners()
			Dim corners5 As New Global.Telerik.Charting.Styles.Corners()
			Dim corners6 As New Global.Telerik.Charting.Styles.Corners()
			Dim corners7 As New Global.Telerik.Charting.Styles.Corners()
			Dim corners8 As New Global.Telerik.Charting.Styles.Corners()
			Dim corners9 As New Global.Telerik.Charting.Styles.Corners()
			Dim corners10 As New Global.Telerik.Charting.Styles.Corners()
			Dim corners11 As New Global.Telerik.Charting.Styles.Corners()
			Dim unit4 As New Global.Telerik.Charting.Styles.Unit()
			Dim unit5 As New Global.Telerik.Charting.Styles.Unit()
			Dim unit6 As New Global.Telerik.Charting.Styles.Unit()
			Dim unit7 As New Global.Telerik.Charting.Styles.Unit()
			Dim corners12 As New Global.Telerik.Charting.Styles.Corners()
			Dim corners13 As New Global.Telerik.Charting.Styles.Corners()
			Dim corners14 As New Global.Telerik.Charting.Styles.Corners()
			Dim corners15 As New Global.Telerik.Charting.Styles.Corners()
			Dim corners16 As New Global.Telerik.Charting.Styles.Corners()
			Dim corners17 As New Global.Telerik.Charting.Styles.Corners()
			Dim corners18 As New Global.Telerik.Charting.Styles.Corners()
			Dim corners19 As New Global.Telerik.Charting.Styles.Corners()
			Dim corners20 As New Global.Telerik.Charting.Styles.Corners()
			Dim corners21 As New Global.Telerik.Charting.Styles.Corners()
			Dim corners22 As New Global.Telerik.Charting.Styles.Corners()
			Dim corners23 As New Global.Telerik.Charting.Styles.Corners()
			Dim corners24 As New Global.Telerik.Charting.Styles.Corners()
			Dim corners25 As New Global.Telerik.Charting.Styles.Corners()
			Dim corners26 As New Global.Telerik.Charting.Styles.Corners()
			Dim corners27 As New Global.Telerik.Charting.Styles.Corners()
			Dim chartSeries1 As New Global.Telerik.Charting.ChartSeries()
			Dim corners28 As New Global.Telerik.Charting.Styles.Corners()
			Dim corners29 As New Global.Telerik.Charting.Styles.Corners()
			Dim corners30 As New Global.Telerik.Charting.Styles.Corners()
			Dim corners31 As New Global.Telerik.Charting.Styles.Corners()
			Dim corners32 As New Global.Telerik.Charting.Styles.Corners()
			Dim chartSeriesItem1 As New Global.Telerik.Charting.ChartSeriesItem()
			Dim corners33 As New Global.Telerik.Charting.Styles.Corners()
			Dim corners34 As New Global.Telerik.Charting.Styles.Corners()
			Dim corners35 As New Global.Telerik.Charting.Styles.Corners()
			Dim corners36 As New Global.Telerik.Charting.Styles.Corners()
			Dim corners37 As New Global.Telerik.Charting.Styles.Corners()
			Dim chartSeriesItem2 As New Global.Telerik.Charting.ChartSeriesItem()
			Dim corners38 As New Global.Telerik.Charting.Styles.Corners()
			Dim corners39 As New Global.Telerik.Charting.Styles.Corners()
			Dim corners40 As New Global.Telerik.Charting.Styles.Corners()
			Dim corners41 As New Global.Telerik.Charting.Styles.Corners()
			Dim corners42 As New Global.Telerik.Charting.Styles.Corners()
			Dim chartSeriesItem3 As New Global.Telerik.Charting.ChartSeriesItem()
			Dim corners43 As New Global.Telerik.Charting.Styles.Corners()
			Dim corners44 As New Global.Telerik.Charting.Styles.Corners()
			Dim corners45 As New Global.Telerik.Charting.Styles.Corners()
			Dim corners46 As New Global.Telerik.Charting.Styles.Corners()
			Dim corners47 As New Global.Telerik.Charting.Styles.Corners()
			Dim chartSeriesItem4 As New Global.Telerik.Charting.ChartSeriesItem()
			Dim corners48 As New Global.Telerik.Charting.Styles.Corners()
			Dim corners49 As New Global.Telerik.Charting.Styles.Corners()
			Dim corners50 As New Global.Telerik.Charting.Styles.Corners()
			Dim corners51 As New Global.Telerik.Charting.Styles.Corners()
			Dim corners52 As New Global.Telerik.Charting.Styles.Corners()
			Dim chartSeriesItem5 As New Global.Telerik.Charting.ChartSeriesItem()
			Dim corners53 As New Global.Telerik.Charting.Styles.Corners()
			Dim corners54 As New Global.Telerik.Charting.Styles.Corners()
			Dim corners55 As New Global.Telerik.Charting.Styles.Corners()
			Dim corners56 As New Global.Telerik.Charting.Styles.Corners()
			Dim corners57 As New Global.Telerik.Charting.Styles.Corners()
			Dim chartSeries2 As New Global.Telerik.Charting.ChartSeries()
			Dim corners58 As New Global.Telerik.Charting.Styles.Corners()
			Dim corners59 As New Global.Telerik.Charting.Styles.Corners()
			Dim corners60 As New Global.Telerik.Charting.Styles.Corners()
			Dim corners61 As New Global.Telerik.Charting.Styles.Corners()
			Dim corners62 As New Global.Telerik.Charting.Styles.Corners()
			Dim chartSeriesItem6 As New Global.Telerik.Charting.ChartSeriesItem()
			Dim corners63 As New Global.Telerik.Charting.Styles.Corners()
			Dim corners64 As New Global.Telerik.Charting.Styles.Corners()
			Dim corners65 As New Global.Telerik.Charting.Styles.Corners()
			Dim corners66 As New Global.Telerik.Charting.Styles.Corners()
			Dim corners67 As New Global.Telerik.Charting.Styles.Corners()
			Dim chartSeriesItem7 As New Global.Telerik.Charting.ChartSeriesItem()
			Dim corners68 As New Global.Telerik.Charting.Styles.Corners()
			Dim corners69 As New Global.Telerik.Charting.Styles.Corners()
			Dim corners70 As New Global.Telerik.Charting.Styles.Corners()
			Dim corners71 As New Global.Telerik.Charting.Styles.Corners()
			Dim corners72 As New Global.Telerik.Charting.Styles.Corners()
			Dim chartSeriesItem8 As New Global.Telerik.Charting.ChartSeriesItem()
			Dim corners73 As New Global.Telerik.Charting.Styles.Corners()
			Dim corners74 As New Global.Telerik.Charting.Styles.Corners()
			Dim corners75 As New Global.Telerik.Charting.Styles.Corners()
			Dim corners76 As New Global.Telerik.Charting.Styles.Corners()
			Dim corners77 As New Global.Telerik.Charting.Styles.Corners()
			Dim chartSeriesItem9 As New Global.Telerik.Charting.ChartSeriesItem()
			Dim corners78 As New Global.Telerik.Charting.Styles.Corners()
			Dim corners79 As New Global.Telerik.Charting.Styles.Corners()
			Dim corners80 As New Global.Telerik.Charting.Styles.Corners()
			Dim corners81 As New Global.Telerik.Charting.Styles.Corners()
			Dim corners82 As New Global.Telerik.Charting.Styles.Corners()
			Dim chartSeriesItem10 As New Global.Telerik.Charting.ChartSeriesItem()
			Dim corners83 As New Global.Telerik.Charting.Styles.Corners()
			Dim corners84 As New Global.Telerik.Charting.Styles.Corners()
			Dim corners85 As New Global.Telerik.Charting.Styles.Corners()
			Dim corners86 As New Global.Telerik.Charting.Styles.Corners()
			Dim corners87 As New Global.Telerik.Charting.Styles.Corners()
			Me.radChart1 = New Global.Telerik.WinControls.UI.RadChart()
			Me.radChart1.Skin = "Default2006"
			CType(Me.radChart1, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radChart1
			' 
			Me.radChart1.Skin = "Default2006"
			Me.radChart1.Appearance.Border.Color = Global.System.Drawing.Color.FromArgb((CInt(Fix((CByte(188))))), (CInt(Fix((CByte(229))))), (CInt(Fix((CByte(231))))))
			Me.radChart1.Appearance.Border.Width = 8F
			Me.radChart1.Appearance.Corners = corners1
			Me.radChart1.Appearance.FillStyle.MainColor = Global.System.Drawing.Color.FromArgb((CInt(Fix((CByte(239))))), (CInt(Fix((CByte(255))))), (CInt(Fix((CByte(254))))))
			Me.radChart1.Appearance.FillStyle.SecondColor = Global.System.Drawing.Color.AliceBlue
			Me.radChart1.ChartTitle.Appearance.Border.Visible = False
			Me.radChart1.ChartTitle.Appearance.Corners = corners2
			unit1.Type = Global.Telerik.Charting.Styles.UnitType.Percentage
			unit1.Value = 1F
			unit2.Value = 10F
			unit3.Value = 10F
			Me.radChart1.ChartTitle.Appearance.Dimensions.Margins = New Global.Telerik.Charting.Styles.ChartMargins(unit1, unit2, unit3, unit2)
			Me.radChart1.ChartTitle.Appearance.FillStyle.MainColor = Global.System.Drawing.Color.Empty
			Me.radChart1.ChartTitle.Marker.Appearance.Corners = corners3
			Me.radChart1.ChartTitle.TextBlock.Appearance.Corners = corners4
			Me.radChart1.ChartTitle.TextBlock.Appearance.TextProperties.Color = Global.System.Drawing.Color.FromArgb((CInt(Fix((CByte(232))))), (CInt(Fix((CByte(147))))), (CInt(Fix((CByte(0))))))
			Me.radChart1.ChartTitle.TextBlock.Appearance.TextProperties.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F)
			Me.radChart1.ChartTitle.TextBlock.Text = "Empty Values"
			Me.radChart1.DataGroupColumn = Nothing
			Me.radChart1.Legend.Appearance.Border.Color = Global.System.Drawing.Color.FromArgb((CInt(Fix((CByte(194))))), (CInt(Fix((CByte(212))))), (CInt(Fix((CByte(109))))))
			corners5.BottomLeft = Global.Telerik.Charting.Styles.CornerType.Round
			corners5.BottomRight = Global.Telerik.Charting.Styles.CornerType.Round
			corners5.TopLeft = Global.Telerik.Charting.Styles.CornerType.Round
			corners5.TopRight = Global.Telerik.Charting.Styles.CornerType.Round
			Me.radChart1.Legend.Appearance.Corners = corners5
			Me.radChart1.Legend.Appearance.ItemAppearance.Corners = corners6
			Me.radChart1.Legend.Appearance.ItemMarkerAppearance.Corners = corners7
			Me.radChart1.Legend.Appearance.ItemTextAppearance.Corners = corners8
			Me.radChart1.Legend.Appearance.ItemTextAppearance.TextProperties.Color = Global.System.Drawing.Color.FromArgb((CInt(Fix((CByte(154))))), (CInt(Fix((CByte(187))))), (CInt(Fix((CByte(76))))))
			Me.radChart1.Legend.Appearance.ItemTextAppearance.TextProperties.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F)
			Me.radChart1.Legend.Marker.Appearance.Corners = corners9
			Me.radChart1.Legend.TextBlock.Appearance.Corners = corners10
			Me.radChart1.Location = New Global.System.Drawing.Point(12, 12)
			Me.radChart1.Name = "radChart1"
			Me.radChart1.PlotArea.Appearance.Border.Color = Global.System.Drawing.Color.FromArgb((CInt(Fix((CByte(226))))), (CInt(Fix((CByte(201))))), (CInt(Fix((CByte(156))))))
			Me.radChart1.PlotArea.Appearance.Border.Width = 3F
			Me.radChart1.PlotArea.Appearance.Corners = corners11
			unit4.Type = Global.Telerik.Charting.Styles.UnitType.Percentage
			unit4.Value = 15F
			unit5.Type = Global.Telerik.Charting.Styles.UnitType.Percentage
			unit5.Value = 17F
			unit6.Type = Global.Telerik.Charting.Styles.UnitType.Percentage
			unit6.Value = 10F
			unit7.Type = Global.Telerik.Charting.Styles.UnitType.Percentage
			unit7.Value = 10F
			Me.radChart1.PlotArea.Appearance.Dimensions.Margins = New Global.Telerik.Charting.Styles.ChartMargins(unit4, unit5, unit6, unit7)
			Me.radChart1.PlotArea.Appearance.FillStyle.MainColor = Global.System.Drawing.Color.White
			Me.radChart1.SkinsOverrideStyles = True
			Me.radChart1.Skin = "Apple"
			Me.radChart1.PlotArea.XAxis.Appearance.Color = Global.System.Drawing.Color.FromArgb((CInt(Fix((CByte(226))))), (CInt(Fix((CByte(201))))), (CInt(Fix((CByte(156))))))
			Me.radChart1.PlotArea.XAxis.Appearance.LabelAppearance.Corners = corners13
			Me.radChart1.PlotArea.XAxis.Appearance.MajorGridLines.Color = Global.System.Drawing.Color.FromArgb((CInt(Fix((CByte(244))))), (CInt(Fix((CByte(227))))), (CInt(Fix((CByte(195))))))
			Me.radChart1.PlotArea.XAxis.Appearance.MajorGridLines.PenStyle = Global.System.Drawing.Drawing2D.DashStyle.Solid
			Me.radChart1.PlotArea.XAxis.Appearance.MajorGridLines.Visible = False
			Me.radChart1.PlotArea.XAxis.Appearance.MajorTick.Color = Global.System.Drawing.Color.FromArgb((CInt(Fix((CByte(244))))), (CInt(Fix((CByte(227))))), (CInt(Fix((CByte(195))))))
			Me.radChart1.PlotArea.XAxis.Appearance.TextAppearance.Corners = corners14
			Me.radChart1.PlotArea.XAxis.Appearance.TextAppearance.TextProperties.Color = Global.System.Drawing.Color.FromArgb((CInt(Fix((CByte(69))))), (CInt(Fix((CByte(163))))), (CInt(Fix((CByte(184))))))
			Me.radChart1.PlotArea.XAxis.Appearance.TextAppearance.TextProperties.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F)
			Me.radChart1.PlotArea.XAxis.AxisLabel.Appearance.Corners = corners15
			Me.radChart1.PlotArea.XAxis.AxisLabel.Marker.Appearance.Corners = corners16
			Me.radChart1.PlotArea.XAxis.AxisLabel.TextBlock.Appearance.Corners = corners17
			Me.radChart1.PlotArea.XAxis.LayoutMode = Global.Telerik.Charting.Styles.ChartAxisLayoutMode.Inside
			Me.radChart1.PlotArea.XAxis.MaxValue = 5
			Me.radChart1.PlotArea.XAxis.MinValue = 1
			Me.radChart1.PlotArea.XAxis.Step = 1
			Me.radChart1.PlotArea.YAxis.Appearance.Color = Global.System.Drawing.Color.FromArgb((CInt(Fix((CByte(226))))), (CInt(Fix((CByte(201))))), (CInt(Fix((CByte(156))))))
			Me.radChart1.PlotArea.YAxis.Appearance.LabelAppearance.Corners = corners18
			Me.radChart1.PlotArea.YAxis.Appearance.MajorGridLines.Color = Global.System.Drawing.Color.FromArgb((CInt(Fix((CByte(244))))), (CInt(Fix((CByte(227))))), (CInt(Fix((CByte(195))))))
			Me.radChart1.PlotArea.YAxis.Appearance.MajorGridLines.PenStyle = Global.System.Drawing.Drawing2D.DashStyle.Solid
			Me.radChart1.PlotArea.YAxis.Appearance.MajorTick.Color = Global.System.Drawing.Color.FromArgb((CInt(Fix((CByte(244))))), (CInt(Fix((CByte(227))))), (CInt(Fix((CByte(195))))))
			Me.radChart1.PlotArea.YAxis.Appearance.MinorGridLines.Color = Global.System.Drawing.Color.FromArgb((CInt(Fix((CByte(244))))), (CInt(Fix((CByte(227))))), (CInt(Fix((CByte(195))))))
			Me.radChart1.PlotArea.YAxis.Appearance.MinorGridLines.PenStyle = Global.System.Drawing.Drawing2D.DashStyle.Solid
			Me.radChart1.PlotArea.YAxis.Appearance.MinorGridLines.Visible = False
			Me.radChart1.PlotArea.YAxis.Appearance.MinorTick.Color = Global.System.Drawing.Color.FromArgb((CInt(Fix((CByte(244))))), (CInt(Fix((CByte(227))))), (CInt(Fix((CByte(195))))))
			Me.radChart1.PlotArea.YAxis.Appearance.MinorTick.Visible = False
			Me.radChart1.PlotArea.YAxis.Appearance.TextAppearance.Corners = corners19
			Me.radChart1.PlotArea.YAxis.Appearance.TextAppearance.TextProperties.Color = Global.System.Drawing.Color.FromArgb((CInt(Fix((CByte(69))))), (CInt(Fix((CByte(163))))), (CInt(Fix((CByte(184))))))
			Me.radChart1.PlotArea.YAxis.Appearance.TextAppearance.TextProperties.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F)
			Me.radChart1.PlotArea.YAxis.AxisLabel.Appearance.Corners = corners20
			Me.radChart1.PlotArea.YAxis.AxisLabel.Marker.Appearance.Corners = corners21
			Me.radChart1.PlotArea.YAxis.AxisLabel.TextBlock.Appearance.Corners = corners22
			Me.radChart1.PlotArea.YAxis.Step = 20
			Me.radChart1.PlotArea.YAxis2.Appearance.Color = Global.System.Drawing.Color.FromArgb((CInt(Fix((CByte(226))))), (CInt(Fix((CByte(201))))), (CInt(Fix((CByte(156))))))
			Me.radChart1.PlotArea.YAxis2.Appearance.LabelAppearance.Corners = corners23
			Me.radChart1.PlotArea.YAxis2.Appearance.MajorGridLines.Color = Global.System.Drawing.Color.FromArgb((CInt(Fix((CByte(244))))), (CInt(Fix((CByte(227))))), (CInt(Fix((CByte(195))))))
			Me.radChart1.PlotArea.YAxis2.Appearance.MajorTick.Color = Global.System.Drawing.Color.FromArgb((CInt(Fix((CByte(244))))), (CInt(Fix((CByte(227))))), (CInt(Fix((CByte(195))))))
			Me.radChart1.PlotArea.YAxis2.Appearance.MinorGridLines.Color = Global.System.Drawing.Color.FromArgb((CInt(Fix((CByte(244))))), (CInt(Fix((CByte(227))))), (CInt(Fix((CByte(195))))))
			Me.radChart1.PlotArea.YAxis2.Appearance.MinorTick.Color = Global.System.Drawing.Color.FromArgb((CInt(Fix((CByte(244))))), (CInt(Fix((CByte(227))))), (CInt(Fix((CByte(195))))))
			Me.radChart1.PlotArea.YAxis2.Appearance.TextAppearance.Corners = corners24
			Me.radChart1.PlotArea.YAxis2.Appearance.TextAppearance.TextProperties.Color = Global.System.Drawing.Color.FromArgb((CInt(Fix((CByte(69))))), (CInt(Fix((CByte(163))))), (CInt(Fix((CByte(184))))))
			Me.radChart1.PlotArea.YAxis2.Appearance.TextAppearance.TextProperties.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F)
			Me.radChart1.PlotArea.YAxis2.AxisLabel.Appearance.Corners = corners25
			Me.radChart1.PlotArea.YAxis2.AxisLabel.Marker.Appearance.Corners = corners26
			Me.radChart1.PlotArea.YAxis2.AxisLabel.TextBlock.Appearance.Corners = corners27
			Me.radChart1.PlotArea.YAxis2.MaxValue = 5
			Me.radChart1.PlotArea.YAxis2.MinValue = 1
			Me.radChart1.PlotArea.YAxis2.Step = 1
			chartSeries1.Appearance.Corners = corners28
			chartSeries1.Appearance.EmptyValue.PointMark.Corners = corners29
			chartSeries1.Appearance.LabelAppearance.Corners = corners30
			chartSeries1.Appearance.PointMark.Corners = corners31
			chartSeries1.Appearance.TextAppearance.Corners = corners32
			chartSeries1.Appearance.TextAppearance.TextProperties.Color = Global.System.Drawing.Color.FromArgb((CInt(Fix((CByte(154))))), (CInt(Fix((CByte(187))))), (CInt(Fix((CByte(76))))))
			chartSeries1.Appearance.TextAppearance.TextProperties.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F)
			chartSeriesItem1.Appearance.Corners = corners33
			chartSeriesItem1.Label.Appearance.Corners = corners34
			chartSeriesItem1.Label.Marker.Appearance.Corners = corners35
			chartSeriesItem1.Label.TextBlock.Appearance.Corners = corners36
			chartSeriesItem1.PointAppearance.Corners = corners37
			chartSeriesItem1.YValue = 73
			chartSeriesItem1.YValue2 = 52
			chartSeriesItem2.Appearance.Corners = corners38
			chartSeriesItem2.Label.Appearance.Corners = corners39
			chartSeriesItem2.Label.Marker.Appearance.Corners = corners40
			chartSeriesItem2.Label.TextBlock.Appearance.Corners = corners41
			chartSeriesItem2.PointAppearance.Corners = corners42
			chartSeriesItem2.YValue = 23
			chartSeriesItem2.YValue2 = 76
			chartSeriesItem3.Appearance.Corners = corners43
			chartSeriesItem3.Label.Appearance.Corners = corners44
			chartSeriesItem3.Label.Marker.Appearance.Corners = corners45
			chartSeriesItem3.Label.TextBlock.Appearance.Corners = corners46
			chartSeriesItem3.PointAppearance.Corners = corners47
			chartSeriesItem3.YValue = 22
			chartSeriesItem3.YValue2 = 25
			chartSeriesItem4.Appearance.Corners = corners48
			chartSeriesItem4.Label.Appearance.Corners = corners49
			chartSeriesItem4.Label.Marker.Appearance.Corners = corners50
			chartSeriesItem4.Label.TextBlock.Appearance.Corners = corners51
			chartSeriesItem4.PointAppearance.Corners = corners52
			chartSeriesItem4.YValue = 24
			chartSeriesItem4.YValue2 = 93
			chartSeriesItem5.Appearance.Corners = corners53
			chartSeriesItem5.Label.Appearance.Corners = corners54
			chartSeriesItem5.Label.Marker.Appearance.Corners = corners55
			chartSeriesItem5.Label.TextBlock.Appearance.Corners = corners56
			chartSeriesItem5.PointAppearance.Corners = corners57
			chartSeriesItem5.YValue = 75
			chartSeriesItem5.YValue2 = 55
			chartSeries1.Items.AddRange(New Global.Telerik.Charting.ChartSeriesItem() { chartSeriesItem1, chartSeriesItem2, chartSeriesItem3, chartSeriesItem4, chartSeriesItem5})
			chartSeries1.Name = "Product A"
			chartSeries1.Type = Global.Telerik.Charting.ChartSeriesType.SplineArea
			chartSeries2.Appearance.Corners = corners58
			chartSeries2.Appearance.EmptyValue.PointMark.Corners = corners59
			chartSeries2.Appearance.LabelAppearance.Corners = corners60
			chartSeries2.Appearance.PointMark.Corners = corners61
			chartSeries2.Appearance.TextAppearance.Corners = corners62
			chartSeries2.Appearance.TextAppearance.TextProperties.Color = Global.System.Drawing.Color.FromArgb((CInt(Fix((CByte(154))))), (CInt(Fix((CByte(187))))), (CInt(Fix((CByte(76))))))
			chartSeries2.Appearance.TextAppearance.TextProperties.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F)
			chartSeriesItem6.Appearance.Corners = corners63
			chartSeriesItem6.Label.Appearance.Corners = corners64
			chartSeriesItem6.Label.Marker.Appearance.Corners = corners65
			chartSeriesItem6.Label.TextBlock.Appearance.Corners = corners66
			chartSeriesItem6.PointAppearance.Corners = corners67
			chartSeriesItem6.YValue = 6
			chartSeriesItem6.YValue2 = 53
			chartSeriesItem7.Appearance.Corners = corners68
			chartSeriesItem7.Label.Appearance.Corners = corners69
			chartSeriesItem7.Label.Marker.Appearance.Corners = corners70
			chartSeriesItem7.Label.TextBlock.Appearance.Corners = corners71
			chartSeriesItem7.PointAppearance.Corners = corners72
			chartSeriesItem7.YValue = 24
			chartSeriesItem7.YValue2 = 22
			chartSeriesItem8.Appearance.Corners = corners73
			chartSeriesItem8.Label.Appearance.Corners = corners74
			chartSeriesItem8.Label.Marker.Appearance.Corners = corners75
			chartSeriesItem8.Label.TextBlock.Appearance.Corners = corners76
			chartSeriesItem8.PointAppearance.Corners = corners77
			chartSeriesItem8.YValue = 51
			chartSeriesItem8.YValue2 = 78
			chartSeriesItem9.Appearance.Corners = corners78
			chartSeriesItem9.Label.Appearance.Corners = corners79
			chartSeriesItem9.Label.Marker.Appearance.Corners = corners80
			chartSeriesItem9.Label.TextBlock.Appearance.Corners = corners81
			chartSeriesItem9.PointAppearance.Corners = corners82
			chartSeriesItem9.YValue = 95
			chartSeriesItem9.YValue2 = 10
			chartSeriesItem10.Appearance.Corners = corners83
			chartSeriesItem10.Label.Appearance.Corners = corners84
			chartSeriesItem10.Label.Marker.Appearance.Corners = corners85
			chartSeriesItem10.Label.TextBlock.Appearance.Corners = corners86
			chartSeriesItem10.PointAppearance.Corners = corners87
			chartSeriesItem10.YValue = 18
			chartSeriesItem10.YValue2 = 60
			chartSeries2.Items.AddRange(New Global.Telerik.Charting.ChartSeriesItem() { chartSeriesItem6, chartSeriesItem7, chartSeriesItem8, chartSeriesItem9, chartSeriesItem10})
			chartSeries2.Name = "Product B"
			chartSeries2.Type = Global.Telerik.Charting.ChartSeriesType.SplineArea
			Me.radChart1.Series.Add(chartSeries1)
			Me.radChart1.Series.Add(chartSeries2)
			Me.radChart1.SkinsOverrideStyles = True
			Me.radChart1.Skin = "Apple"
			Me.radChart1.Size = New Global.System.Drawing.Size(400, 300)
			Me.radChart1.TabIndex = 0
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New Global.System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.radChart1)
			Me.Name = "Form1"
			Me.Size = New Global.System.Drawing.Size(1232, 822)
			CType(Me.radChart1, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radChart1 As Global.Telerik.WinControls.UI.RadChart
	End Class
End Namespace

