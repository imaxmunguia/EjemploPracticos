Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.Chart.DataBinding.Array
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

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
			Dim corners1 As New Telerik.Charting.Styles.Corners()
			Dim unit1 As New Telerik.Charting.Styles.Unit()
			Dim unit2 As New Telerik.Charting.Styles.Unit()
			Dim corners2 As New Telerik.Charting.Styles.Corners()
			Dim unit3 As New Telerik.Charting.Styles.Unit()
			Dim unit4 As New Telerik.Charting.Styles.Unit()
			Dim unit5 As New Telerik.Charting.Styles.Unit()
			Dim corners3 As New Telerik.Charting.Styles.Corners()
			Dim corners4 As New Telerik.Charting.Styles.Corners()
			Dim corners5 As New Telerik.Charting.Styles.Corners()
			Dim corners6 As New Telerik.Charting.Styles.Corners()
			Dim corners7 As New Telerik.Charting.Styles.Corners()
			Dim corners8 As New Telerik.Charting.Styles.Corners()
			Dim corners9 As New Telerik.Charting.Styles.Corners()
			Dim corners10 As New Telerik.Charting.Styles.Corners()
			Dim corners11 As New Telerik.Charting.Styles.Corners()
			Dim unit6 As New Telerik.Charting.Styles.Unit()
			Dim unit7 As New Telerik.Charting.Styles.Unit()
			Dim unit8 As New Telerik.Charting.Styles.Unit()
			Dim unit9 As New Telerik.Charting.Styles.Unit()
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
			Me.radChart1 = New Telerik.WinControls.UI.RadChart()
			Me.radChart1.Skin = "Default2006"
			CType(Me.radChart1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radChart1
			' 
			Me.radChart1.Appearance.Border.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(188))))), (CInt(Fix((CByte(229))))), (CInt(Fix((CByte(231))))))
			Me.radChart1.Appearance.Border.Width = 8F
			Me.radChart1.Appearance.Corners = corners1
			unit1.Value = 303F
			Me.radChart1.Appearance.Dimensions.Height = unit1
			unit2.Value = 403F
			Me.radChart1.Appearance.Dimensions.Width = unit2
			Me.radChart1.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(239))))), (CInt(Fix((CByte(255))))), (CInt(Fix((CByte(254))))))
			Me.radChart1.Appearance.FillStyle.SecondColor = System.Drawing.Color.AliceBlue
			Me.radChart1.ChartTitle.Appearance.Border.Visible = False
			Me.radChart1.ChartTitle.Appearance.Corners = corners2
			unit3.Type = Telerik.Charting.Styles.UnitType.Percentage
			unit3.Value = 1F
			unit4.Value = 10F
			unit5.Value = 10F
			Me.radChart1.ChartTitle.Appearance.Dimensions.Margins = New Telerik.Charting.Styles.ChartMargins(unit3, unit4, unit5, unit4)
			Me.radChart1.ChartTitle.Appearance.FillStyle.MainColor = System.Drawing.Color.Empty
			Me.radChart1.ChartTitle.Marker.Appearance.Corners = corners3
			Me.radChart1.ChartTitle.TextBlock.Appearance.Corners = corners4
			Me.radChart1.ChartTitle.TextBlock.Appearance.TextProperties.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(232))))), (CInt(Fix((CByte(147))))), (CInt(Fix((CByte(0))))))
			Me.radChart1.ChartTitle.TextBlock.Appearance.TextProperties.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F)
			Me.radChart1.ChartTitle.TextBlock.Text = "Array Binding"
			Me.radChart1.DataGroupColumn = Nothing
			Me.radChart1.Legend.Appearance.Border.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(194))))), (CInt(Fix((CByte(212))))), (CInt(Fix((CByte(109))))))
			corners5.BottomLeft = Telerik.Charting.Styles.CornerType.Round
			corners5.BottomRight = Telerik.Charting.Styles.CornerType.Round
			corners5.TopLeft = Telerik.Charting.Styles.CornerType.Round
			corners5.TopRight = Telerik.Charting.Styles.CornerType.Round
			Me.radChart1.Legend.Appearance.Corners = corners5
			Me.radChart1.Legend.Appearance.ItemAppearance.Corners = corners6
			Me.radChart1.Legend.Appearance.ItemMarkerAppearance.Corners = corners7
			Me.radChart1.Legend.Appearance.ItemTextAppearance.Corners = corners8
			Me.radChart1.Legend.Appearance.ItemTextAppearance.TextProperties.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(154))))), (CInt(Fix((CByte(187))))), (CInt(Fix((CByte(76))))))
			Me.radChart1.Legend.Appearance.ItemTextAppearance.TextProperties.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F)
			Me.radChart1.Legend.Marker.Appearance.Corners = corners9
			Me.radChart1.Legend.TextBlock.Appearance.Corners = corners10
			Me.radChart1.Location = New System.Drawing.Point(14, 15)
			Me.radChart1.Name = "radChart1"
			Me.radChart1.PlotArea.Appearance.Border.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(226))))), (CInt(Fix((CByte(201))))), (CInt(Fix((CByte(156))))))
			Me.radChart1.PlotArea.Appearance.Border.Width = 3F
			Me.radChart1.PlotArea.Appearance.Corners = corners11
			unit6.Type = Telerik.Charting.Styles.UnitType.Percentage
			unit6.Value = 15F
			unit7.Type = Telerik.Charting.Styles.UnitType.Percentage
			unit7.Value = 17F
			unit8.Type = Telerik.Charting.Styles.UnitType.Percentage
			unit8.Value = 10F
			unit9.Type = Telerik.Charting.Styles.UnitType.Percentage
			unit9.Value = 10F
			Me.radChart1.PlotArea.Appearance.Dimensions.Margins = New Telerik.Charting.Styles.ChartMargins(unit6, unit7, unit8, unit9)
			Me.radChart1.PlotArea.Appearance.FillStyle.MainColor = System.Drawing.Color.White
			Me.radChart1.SkinsOverrideStyles = True
			Me.radChart1.Skin = "Apple"
			Me.radChart1.PlotArea.XAxis.Appearance.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(226))))), (CInt(Fix((CByte(201))))), (CInt(Fix((CByte(156))))))
			Me.radChart1.PlotArea.XAxis.Appearance.LabelAppearance.Corners = corners13
			Me.radChart1.PlotArea.XAxis.Appearance.MajorGridLines.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(244))))), (CInt(Fix((CByte(227))))), (CInt(Fix((CByte(195))))))
			Me.radChart1.PlotArea.XAxis.Appearance.MajorGridLines.PenStyle = System.Drawing.Drawing2D.DashStyle.Solid
			Me.radChart1.PlotArea.XAxis.Appearance.MajorGridLines.Visible = False
			Me.radChart1.PlotArea.XAxis.Appearance.MajorTick.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(244))))), (CInt(Fix((CByte(227))))), (CInt(Fix((CByte(195))))))
			Me.radChart1.PlotArea.XAxis.Appearance.TextAppearance.Corners = corners14
			Me.radChart1.PlotArea.XAxis.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(69))))), (CInt(Fix((CByte(163))))), (CInt(Fix((CByte(184))))))
			Me.radChart1.PlotArea.XAxis.Appearance.TextAppearance.TextProperties.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F)
			Me.radChart1.PlotArea.XAxis.AxisLabel.Appearance.Corners = corners15
			Me.radChart1.PlotArea.XAxis.AxisLabel.Marker.Appearance.Corners = corners16
			Me.radChart1.PlotArea.XAxis.AxisLabel.TextBlock.Appearance.Corners = corners17
			Me.radChart1.PlotArea.XAxis.LayoutMode = Telerik.Charting.Styles.ChartAxisLayoutMode.Inside
			Me.radChart1.PlotArea.XAxis.MaxValue = 7
			Me.radChart1.PlotArea.XAxis.MinValue = 1
			Me.radChart1.PlotArea.XAxis.Step = 1
			Me.radChart1.PlotArea.YAxis.Appearance.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(226))))), (CInt(Fix((CByte(201))))), (CInt(Fix((CByte(156))))))
			Me.radChart1.PlotArea.YAxis.Appearance.LabelAppearance.Corners = corners18
			Me.radChart1.PlotArea.YAxis.Appearance.MajorGridLines.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(244))))), (CInt(Fix((CByte(227))))), (CInt(Fix((CByte(195))))))
			Me.radChart1.PlotArea.YAxis.Appearance.MajorGridLines.PenStyle = System.Drawing.Drawing2D.DashStyle.Solid
			Me.radChart1.PlotArea.YAxis.Appearance.MajorTick.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(244))))), (CInt(Fix((CByte(227))))), (CInt(Fix((CByte(195))))))
			Me.radChart1.PlotArea.YAxis.Appearance.MinorGridLines.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(244))))), (CInt(Fix((CByte(227))))), (CInt(Fix((CByte(195))))))
			Me.radChart1.PlotArea.YAxis.Appearance.MinorGridLines.PenStyle = System.Drawing.Drawing2D.DashStyle.Solid
			Me.radChart1.PlotArea.YAxis.Appearance.MinorGridLines.Visible = False
			Me.radChart1.PlotArea.YAxis.Appearance.MinorTick.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(244))))), (CInt(Fix((CByte(227))))), (CInt(Fix((CByte(195))))))
			Me.radChart1.PlotArea.YAxis.Appearance.MinorTick.Visible = False
			Me.radChart1.PlotArea.YAxis.Appearance.TextAppearance.Corners = corners19
			Me.radChart1.PlotArea.YAxis.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(69))))), (CInt(Fix((CByte(163))))), (CInt(Fix((CByte(184))))))
			Me.radChart1.PlotArea.YAxis.Appearance.TextAppearance.TextProperties.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F)
			Me.radChart1.PlotArea.YAxis.AxisLabel.Appearance.Corners = corners20
			Me.radChart1.PlotArea.YAxis.AxisLabel.Marker.Appearance.Corners = corners21
			Me.radChart1.PlotArea.YAxis.AxisLabel.TextBlock.Appearance.Corners = corners22
			Me.radChart1.PlotArea.YAxis.MaxValue = 140
			Me.radChart1.PlotArea.YAxis.Step = 20
			Me.radChart1.PlotArea.YAxis2.Appearance.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(226))))), (CInt(Fix((CByte(201))))), (CInt(Fix((CByte(156))))))
			Me.radChart1.PlotArea.YAxis2.Appearance.LabelAppearance.Corners = corners23
			Me.radChart1.PlotArea.YAxis2.Appearance.MajorGridLines.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(244))))), (CInt(Fix((CByte(227))))), (CInt(Fix((CByte(195))))))
			Me.radChart1.PlotArea.YAxis2.Appearance.MajorTick.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(244))))), (CInt(Fix((CByte(227))))), (CInt(Fix((CByte(195))))))
			Me.radChart1.PlotArea.YAxis2.Appearance.MinorGridLines.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(244))))), (CInt(Fix((CByte(227))))), (CInt(Fix((CByte(195))))))
			Me.radChart1.PlotArea.YAxis2.Appearance.MinorTick.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(244))))), (CInt(Fix((CByte(227))))), (CInt(Fix((CByte(195))))))
			Me.radChart1.PlotArea.YAxis2.Appearance.TextAppearance.Corners = corners24
			Me.radChart1.PlotArea.YAxis2.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(69))))), (CInt(Fix((CByte(163))))), (CInt(Fix((CByte(184))))))
			Me.radChart1.PlotArea.YAxis2.Appearance.TextAppearance.TextProperties.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F)
			Me.radChart1.PlotArea.YAxis2.AxisLabel.Appearance.Corners = corners25
			Me.radChart1.PlotArea.YAxis2.AxisLabel.Marker.Appearance.Corners = corners26
			Me.radChart1.PlotArea.YAxis2.AxisLabel.TextBlock.Appearance.Corners = corners27
			Me.radChart1.PlotArea.YAxis2.MaxValue = 7
			Me.radChart1.PlotArea.YAxis2.MinValue = 1
			Me.radChart1.PlotArea.YAxis2.Step = 1
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
			chartSeries3.Type = Telerik.Charting.ChartSeriesType.SplineArea
			Me.radChart1.Series.Add(chartSeries1)
			Me.radChart1.Series.Add(chartSeries2)
			Me.radChart1.Series.Add(chartSeries3)
			Me.radChart1.Size = New System.Drawing.Size(403, 303)
			Me.radChart1.TabIndex = 1
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.radChart1)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(1232, 822)
			CType(Me.radChart1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radChart1 As Telerik.WinControls.UI.RadChart

	End Class
End Namespace