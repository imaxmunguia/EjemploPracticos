Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.Chart.ChartTypes.Bar
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		'private System.ComponentModel.IContainer components = null;

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim corners1 As New Telerik.Charting.Styles.Corners()
			Dim corners2 As New Telerik.Charting.Styles.Corners()
			Dim unit1 As New Telerik.Charting.Styles.Unit()
			Dim unit2 As New Telerik.Charting.Styles.Unit()
			Dim unit3 As New Telerik.Charting.Styles.Unit()
			Dim corners3 As New Telerik.Charting.Styles.Corners()
			Dim corners4 As New Telerik.Charting.Styles.Corners()
			Dim corners5 As New Telerik.Charting.Styles.Corners()
			Dim corners6 As New Telerik.Charting.Styles.Corners()
			Dim corners7 As New Telerik.Charting.Styles.Corners()
			Dim corners8 As New Telerik.Charting.Styles.Corners()
			Dim corners9 As New Telerik.Charting.Styles.Corners()
			Dim corners10 As New Telerik.Charting.Styles.Corners()
			Dim corners11 As New Telerik.Charting.Styles.Corners()
			Dim unit4 As New Telerik.Charting.Styles.Unit()
			Dim unit5 As New Telerik.Charting.Styles.Unit()
			Dim unit6 As New Telerik.Charting.Styles.Unit()
			Dim unit7 As New Telerik.Charting.Styles.Unit()
			Dim corners12 As New Telerik.Charting.Styles.Corners()
			Dim corners13 As New Telerik.Charting.Styles.Corners()
			Dim corners14 As New Telerik.Charting.Styles.Corners()
			Dim corners15 As New Telerik.Charting.Styles.Corners()
			Dim corners16 As New Telerik.Charting.Styles.Corners()
			Dim corners17 As New Telerik.Charting.Styles.Corners()
			Dim corners18 As New Telerik.Charting.Styles.Corners()
			Dim corners19 As New Telerik.Charting.Styles.Corners()
			Dim corners20 As New Telerik.Charting.Styles.Corners()
			Dim corners21 As New Telerik.Charting.Styles.Corners()
			Dim corners22 As New Telerik.Charting.Styles.Corners()
			Dim corners23 As New Telerik.Charting.Styles.Corners()
			Dim corners24 As New Telerik.Charting.Styles.Corners()
			Dim corners25 As New Telerik.Charting.Styles.Corners()
			Dim corners26 As New Telerik.Charting.Styles.Corners()
			Dim corners27 As New Telerik.Charting.Styles.Corners()
			Dim chartSeries1 As New Telerik.Charting.ChartSeries()
			Dim corners28 As New Telerik.Charting.Styles.Corners()
			Dim corners29 As New Telerik.Charting.Styles.Corners()
			Dim corners30 As New Telerik.Charting.Styles.Corners()
			Dim corners31 As New Telerik.Charting.Styles.Corners()
			Dim corners32 As New Telerik.Charting.Styles.Corners()
			Dim chartSeries2 As New Telerik.Charting.ChartSeries()
			Dim corners33 As New Telerik.Charting.Styles.Corners()
			Dim corners34 As New Telerik.Charting.Styles.Corners()
			Dim corners35 As New Telerik.Charting.Styles.Corners()
			Dim corners36 As New Telerik.Charting.Styles.Corners()
			Dim corners37 As New Telerik.Charting.Styles.Corners()
			Dim chartSeries3 As New Telerik.Charting.ChartSeries()
			Dim corners38 As New Telerik.Charting.Styles.Corners()
			Dim corners39 As New Telerik.Charting.Styles.Corners()
			Dim corners40 As New Telerik.Charting.Styles.Corners()
			Dim corners41 As New Telerik.Charting.Styles.Corners()
			Dim corners42 As New Telerik.Charting.Styles.Corners()
			Dim chartSeriesItem1 As New Telerik.Charting.ChartSeriesItem()
			Dim corners43 As New Telerik.Charting.Styles.Corners()
			Dim corners44 As New Telerik.Charting.Styles.Corners()
			Dim corners45 As New Telerik.Charting.Styles.Corners()
			Dim corners46 As New Telerik.Charting.Styles.Corners()
			Dim corners47 As New Telerik.Charting.Styles.Corners()
			Dim chartSeriesItem2 As New Telerik.Charting.ChartSeriesItem()
			Dim corners48 As New Telerik.Charting.Styles.Corners()
			Dim corners49 As New Telerik.Charting.Styles.Corners()
			Dim corners50 As New Telerik.Charting.Styles.Corners()
			Dim corners51 As New Telerik.Charting.Styles.Corners()
			Dim corners52 As New Telerik.Charting.Styles.Corners()
			Dim chartSeriesItem3 As New Telerik.Charting.ChartSeriesItem()
			Dim corners53 As New Telerik.Charting.Styles.Corners()
			Dim corners54 As New Telerik.Charting.Styles.Corners()
			Dim corners55 As New Telerik.Charting.Styles.Corners()
			Dim corners56 As New Telerik.Charting.Styles.Corners()
			Dim corners57 As New Telerik.Charting.Styles.Corners()
			Dim chartSeriesItem4 As New Telerik.Charting.ChartSeriesItem()
			Dim corners58 As New Telerik.Charting.Styles.Corners()
			Dim corners59 As New Telerik.Charting.Styles.Corners()
			Dim corners60 As New Telerik.Charting.Styles.Corners()
			Dim corners61 As New Telerik.Charting.Styles.Corners()
			Dim corners62 As New Telerik.Charting.Styles.Corners()
			Dim chartSeriesItem5 As New Telerik.Charting.ChartSeriesItem()
			Dim corners63 As New Telerik.Charting.Styles.Corners()
			Dim corners64 As New Telerik.Charting.Styles.Corners()
			Dim corners65 As New Telerik.Charting.Styles.Corners()
			Dim corners66 As New Telerik.Charting.Styles.Corners()
			Dim corners67 As New Telerik.Charting.Styles.Corners()
			Me.radChart2 = New Telerik.WinControls.UI.RadChart()
			Me.radChart2.Skin = "Default2006"
			CType(Me.radChart2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radChart2
			' 
			Me.radChart2.Appearance.Border.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(188))))), (CInt(Fix((CByte(229))))), (CInt(Fix((CByte(231))))))
			Me.radChart2.Appearance.Border.Width = 8F
			Me.radChart2.Appearance.Corners = corners1
			Me.radChart2.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(239))))), (CInt(Fix((CByte(255))))), (CInt(Fix((CByte(254))))))
			Me.radChart2.Appearance.FillStyle.SecondColor = System.Drawing.Color.AliceBlue
			Me.radChart2.ChartTitle.Appearance.Border.Visible = False
			Me.radChart2.ChartTitle.Appearance.Corners = corners2
			unit1.Type = Telerik.Charting.Styles.UnitType.Percentage
			unit1.Value = 1F
			unit2.Value = 10F
			unit3.Value = 10F
			Me.radChart2.ChartTitle.Appearance.Dimensions.Margins = New Telerik.Charting.Styles.ChartMargins(unit1, unit2, unit3, unit2)
			Me.radChart2.ChartTitle.Appearance.FillStyle.MainColor = System.Drawing.Color.Empty
			Me.radChart2.ChartTitle.Marker.Appearance.Corners = corners3
			Me.radChart2.ChartTitle.TextBlock.Appearance.Corners = corners4
			Me.radChart2.ChartTitle.TextBlock.Appearance.TextProperties.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(232))))), (CInt(Fix((CByte(147))))), (CInt(Fix((CByte(0))))))
			Me.radChart2.ChartTitle.TextBlock.Appearance.TextProperties.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F)
			Me.radChart2.ChartTitle.TextBlock.Text = "Bar"
			Me.radChart2.DataGroupColumn = Nothing
			Me.radChart2.Legend.Appearance.Border.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(194))))), (CInt(Fix((CByte(212))))), (CInt(Fix((CByte(109))))))
			corners5.BottomLeft = Telerik.Charting.Styles.CornerType.Round
			corners5.BottomRight = Telerik.Charting.Styles.CornerType.Round
			corners5.TopLeft = Telerik.Charting.Styles.CornerType.Round
			corners5.TopRight = Telerik.Charting.Styles.CornerType.Round
			Me.radChart2.Legend.Appearance.Corners = corners5
			Me.radChart2.Legend.Appearance.ItemAppearance.Corners = corners6
			Me.radChart2.Legend.Appearance.ItemMarkerAppearance.Corners = corners7
			Me.radChart2.Legend.Appearance.ItemTextAppearance.Corners = corners8
			Me.radChart2.Legend.Appearance.ItemTextAppearance.TextProperties.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(154))))), (CInt(Fix((CByte(187))))), (CInt(Fix((CByte(76))))))
			Me.radChart2.Legend.Appearance.ItemTextAppearance.TextProperties.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F)
			Me.radChart2.Legend.Marker.Appearance.Corners = corners9
			Me.radChart2.Legend.TextBlock.Appearance.Corners = corners10
			Me.radChart2.Location = New System.Drawing.Point(16, 14)
			Me.radChart2.Name = "radChart2"
			Me.radChart2.PlotArea.Appearance.Border.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(226))))), (CInt(Fix((CByte(201))))), (CInt(Fix((CByte(156))))))
			Me.radChart2.PlotArea.Appearance.Border.Width = 3F
			Me.radChart2.PlotArea.Appearance.Corners = corners11
			unit4.Type = Telerik.Charting.Styles.UnitType.Percentage
			unit4.Value = 15F
			unit5.Value = 60F
			unit6.Type = Telerik.Charting.Styles.UnitType.Percentage
			unit6.Value = 10F
			unit7.Value = 50F
			Me.radChart2.PlotArea.Appearance.Dimensions.Margins = New Telerik.Charting.Styles.ChartMargins(unit4, unit5, unit6, unit7)
			Me.radChart2.PlotArea.Appearance.FillStyle.MainColor = System.Drawing.Color.White
			Me.radChart2.SkinsOverrideStyles = True
			Me.radChart2.Skin = "Black"
			Me.radChart2.PlotArea.XAxis.Appearance.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(226))))), (CInt(Fix((CByte(201))))), (CInt(Fix((CByte(156))))))
			Me.radChart2.PlotArea.XAxis.Appearance.LabelAppearance.Corners = corners13
			Me.radChart2.PlotArea.XAxis.Appearance.MajorGridLines.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(244))))), (CInt(Fix((CByte(227))))), (CInt(Fix((CByte(195))))))
			Me.radChart2.PlotArea.XAxis.Appearance.MajorGridLines.PenStyle = System.Drawing.Drawing2D.DashStyle.Solid
			Me.radChart2.PlotArea.XAxis.Appearance.MajorGridLines.Visible = False
			Me.radChart2.PlotArea.XAxis.Appearance.MajorTick.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(244))))), (CInt(Fix((CByte(227))))), (CInt(Fix((CByte(195))))))
			Me.radChart2.PlotArea.XAxis.Appearance.TextAppearance.Corners = corners14
			Me.radChart2.PlotArea.XAxis.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(69))))), (CInt(Fix((CByte(163))))), (CInt(Fix((CByte(184))))))
			Me.radChart2.PlotArea.XAxis.Appearance.TextAppearance.TextProperties.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F)
			Me.radChart2.PlotArea.XAxis.AxisLabel.Appearance.Corners = corners15
			Me.radChart2.PlotArea.XAxis.AxisLabel.Marker.Appearance.Corners = corners16
			Me.radChart2.PlotArea.XAxis.AxisLabel.TextBlock.Appearance.Corners = corners17
			Me.radChart2.PlotArea.XAxis.LayoutMode = Telerik.Charting.Styles.ChartAxisLayoutMode.Inside
			Me.radChart2.PlotArea.XAxis.MaxValue = 7
			Me.radChart2.PlotArea.XAxis.MinValue = 1
			Me.radChart2.PlotArea.XAxis.Step = 1
			Me.radChart2.PlotArea.YAxis.Appearance.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(226))))), (CInt(Fix((CByte(201))))), (CInt(Fix((CByte(156))))))
			Me.radChart2.PlotArea.YAxis.Appearance.LabelAppearance.Corners = corners18
			Me.radChart2.PlotArea.YAxis.Appearance.MajorGridLines.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(244))))), (CInt(Fix((CByte(227))))), (CInt(Fix((CByte(195))))))
			Me.radChart2.PlotArea.YAxis.Appearance.MajorGridLines.PenStyle = System.Drawing.Drawing2D.DashStyle.Solid
			Me.radChart2.PlotArea.YAxis.Appearance.MajorTick.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(244))))), (CInt(Fix((CByte(227))))), (CInt(Fix((CByte(195))))))
			Me.radChart2.PlotArea.YAxis.Appearance.MinorGridLines.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(244))))), (CInt(Fix((CByte(227))))), (CInt(Fix((CByte(195))))))
			Me.radChart2.PlotArea.YAxis.Appearance.MinorGridLines.PenStyle = System.Drawing.Drawing2D.DashStyle.Solid
			Me.radChart2.PlotArea.YAxis.Appearance.MinorGridLines.Visible = False
			Me.radChart2.PlotArea.YAxis.Appearance.MinorTick.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(244))))), (CInt(Fix((CByte(227))))), (CInt(Fix((CByte(195))))))
			Me.radChart2.PlotArea.YAxis.Appearance.MinorTick.Visible = False
			Me.radChart2.PlotArea.YAxis.Appearance.TextAppearance.Corners = corners19
			Me.radChart2.PlotArea.YAxis.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(69))))), (CInt(Fix((CByte(163))))), (CInt(Fix((CByte(184))))))
			Me.radChart2.PlotArea.YAxis.Appearance.TextAppearance.TextProperties.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F)
			Me.radChart2.PlotArea.YAxis.AxisLabel.Appearance.Corners = corners20
			Me.radChart2.PlotArea.YAxis.AxisLabel.Marker.Appearance.Corners = corners21
			Me.radChart2.PlotArea.YAxis.AxisLabel.TextBlock.Appearance.Corners = corners22
			Me.radChart2.PlotArea.YAxis.MaxValue = 140
			Me.radChart2.PlotArea.YAxis.Step = 20
			Me.radChart2.PlotArea.YAxis2.Appearance.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(226))))), (CInt(Fix((CByte(201))))), (CInt(Fix((CByte(156))))))
			Me.radChart2.PlotArea.YAxis2.Appearance.LabelAppearance.Corners = corners23
			Me.radChart2.PlotArea.YAxis2.Appearance.MajorGridLines.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(244))))), (CInt(Fix((CByte(227))))), (CInt(Fix((CByte(195))))))
			Me.radChart2.PlotArea.YAxis2.Appearance.MajorTick.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(244))))), (CInt(Fix((CByte(227))))), (CInt(Fix((CByte(195))))))
			Me.radChart2.PlotArea.YAxis2.Appearance.MinorGridLines.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(244))))), (CInt(Fix((CByte(227))))), (CInt(Fix((CByte(195))))))
			Me.radChart2.PlotArea.YAxis2.Appearance.MinorTick.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(244))))), (CInt(Fix((CByte(227))))), (CInt(Fix((CByte(195))))))
			Me.radChart2.PlotArea.YAxis2.Appearance.TextAppearance.Corners = corners24
			Me.radChart2.PlotArea.YAxis2.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(69))))), (CInt(Fix((CByte(163))))), (CInt(Fix((CByte(184))))))
			Me.radChart2.PlotArea.YAxis2.Appearance.TextAppearance.TextProperties.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F)
			Me.radChart2.PlotArea.YAxis2.AxisLabel.Appearance.Corners = corners25
			Me.radChart2.PlotArea.YAxis2.AxisLabel.Marker.Appearance.Corners = corners26

			Me.radChart2.PlotArea.YAxis2.AxisLabel.TextBlock.Appearance.Corners = corners27
			Me.radChart2.PlotArea.YAxis2.MaxValue = 7
			Me.radChart2.PlotArea.YAxis2.MinValue = 1
			Me.radChart2.PlotArea.YAxis2.Step = 1
			chartSeries1.Appearance.Corners = corners28
			chartSeries1.Appearance.EmptyValue.PointMark.Corners = corners29
			chartSeries1.Appearance.LabelAppearance.Corners = corners30
			chartSeries1.Appearance.PointMark.Corners = corners31
			chartSeries1.Appearance.TextAppearance.Corners = corners32
			chartSeries1.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(154))))), (CInt(Fix((CByte(187))))), (CInt(Fix((CByte(76))))))
			chartSeries1.Appearance.TextAppearance.TextProperties.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F)
			chartSeries1.Name = "Series 1"
			chartSeries1.Type = Telerik.Charting.ChartSeriesType.CandleStick
			chartSeries2.Appearance.Corners = corners33
			chartSeries2.Appearance.EmptyValue.PointMark.Corners = corners34
			chartSeries2.Appearance.LabelAppearance.Corners = corners35
			chartSeries2.Appearance.PointMark.Corners = corners36
			chartSeries2.Appearance.TextAppearance.Corners = corners37
			chartSeries2.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(154))))), (CInt(Fix((CByte(187))))), (CInt(Fix((CByte(76))))))
			chartSeries2.Appearance.TextAppearance.TextProperties.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F)
			chartSeries2.Name = "Series 2"
			chartSeries2.Type = Telerik.Charting.ChartSeriesType.CandleStick
			chartSeries3.Appearance.Corners = corners38
			chartSeries3.Appearance.EmptyValue.PointMark.Corners = corners39
			chartSeries3.Appearance.LabelAppearance.Corners = corners40
			chartSeries3.Appearance.PointMark.Corners = corners41
			chartSeries3.Appearance.TextAppearance.Corners = corners42
			chartSeries3.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(154))))), (CInt(Fix((CByte(187))))), (CInt(Fix((CByte(76))))))
			chartSeries3.Appearance.TextAppearance.TextProperties.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F)
			chartSeriesItem1.Appearance.Corners = corners43
			chartSeriesItem1.Label.Appearance.Corners = corners44
			chartSeriesItem1.Label.Marker.Appearance.Corners = corners45
			chartSeriesItem1.Label.TextBlock.Appearance.Corners = corners46
			chartSeriesItem1.PointAppearance.Corners = corners47
			chartSeriesItem1.YValue = 73
			chartSeriesItem1.YValue2 = 52
			chartSeriesItem2.Appearance.Corners = corners48
			chartSeriesItem2.Label.Appearance.Corners = corners49
			chartSeriesItem2.Label.Marker.Appearance.Corners = corners50
			chartSeriesItem2.Label.TextBlock.Appearance.Corners = corners51
			chartSeriesItem2.PointAppearance.Corners = corners52
			chartSeriesItem2.YValue = 23
			chartSeriesItem2.YValue2 = 76
			chartSeriesItem3.Appearance.Corners = corners53
			chartSeriesItem3.Label.Appearance.Corners = corners54
			chartSeriesItem3.Label.Marker.Appearance.Corners = corners55
			chartSeriesItem3.Label.TextBlock.Appearance.Corners = corners56
			chartSeriesItem3.PointAppearance.Corners = corners57
			chartSeriesItem3.YValue = 22
			chartSeriesItem3.YValue2 = 25
			chartSeriesItem4.Appearance.Corners = corners58
			chartSeriesItem4.Label.Appearance.Corners = corners59
			chartSeriesItem4.Label.Marker.Appearance.Corners = corners60
			chartSeriesItem4.Label.TextBlock.Appearance.Corners = corners61
			chartSeriesItem4.PointAppearance.Corners = corners62
			chartSeriesItem4.YValue = 24
			chartSeriesItem4.YValue2 = 93
			chartSeriesItem5.Appearance.Corners = corners63
			chartSeriesItem5.Label.Appearance.Corners = corners64
			chartSeriesItem5.Label.Marker.Appearance.Corners = corners65
			chartSeriesItem5.Label.TextBlock.Appearance.Corners = corners66
			chartSeriesItem5.PointAppearance.Corners = corners67
			chartSeriesItem5.YValue = 75
			chartSeriesItem5.YValue2 = 55
			chartSeries3.Items.AddRange(New Telerik.Charting.ChartSeriesItem() { chartSeriesItem1, chartSeriesItem2, chartSeriesItem3, chartSeriesItem4, chartSeriesItem5})
			chartSeries3.Name = "Product A"
			Me.radChart2.Series.Add(chartSeries1)
			Me.radChart2.Series.Add(chartSeries2)
			Me.radChart2.Series.Add(chartSeries3)
			Me.radChart2.Size = New System.Drawing.Size(400, 300)
			Me.radChart2.TabIndex = 1
			' 
			' Form1
			' 

			Me.Controls.Add(Me.radChart2)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(1232, 822)
			CType(Me.radChart2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radChart2 As Telerik.WinControls.UI.RadChart
	End Class
End Namespace

