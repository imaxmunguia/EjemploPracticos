Imports Microsoft.VisualBasic
Imports System.Windows.Forms

Namespace Telerik.Examples.WinControls.Chart.ChartTypes.Bubble
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
			Dim corners3 As New Telerik.Charting.Styles.Corners()
			Dim corners4 As New Telerik.Charting.Styles.Corners()
			Dim corners5 As New Telerik.Charting.Styles.Corners()
			Dim corners6 As New Telerik.Charting.Styles.Corners()
			Dim corners7 As New Telerik.Charting.Styles.Corners()
			Dim corners8 As New Telerik.Charting.Styles.Corners()
			Dim corners9 As New Telerik.Charting.Styles.Corners()
			Dim corners10 As New Telerik.Charting.Styles.Corners()
			Dim corners11 As New Telerik.Charting.Styles.Corners()
			Dim unit1 As New Telerik.Charting.Styles.Unit()
			Dim unit2 As New Telerik.Charting.Styles.Unit()
			Dim unit3 As New Telerik.Charting.Styles.Unit()
			Dim unit4 As New Telerik.Charting.Styles.Unit()
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
			Dim chartSeriesItem1 As New Telerik.Charting.ChartSeriesItem()
			Dim corners33 As New Telerik.Charting.Styles.Corners()
			Dim corners34 As New Telerik.Charting.Styles.Corners()
			Dim corners35 As New Telerik.Charting.Styles.Corners()
			Dim corners36 As New Telerik.Charting.Styles.Corners()
			Dim corners37 As New Telerik.Charting.Styles.Corners()
			Dim chartSeriesItem2 As New Telerik.Charting.ChartSeriesItem()
			Dim corners38 As New Telerik.Charting.Styles.Corners()
			Dim corners39 As New Telerik.Charting.Styles.Corners()
			Dim corners40 As New Telerik.Charting.Styles.Corners()
			Dim corners41 As New Telerik.Charting.Styles.Corners()
			Dim corners42 As New Telerik.Charting.Styles.Corners()
			Dim chartSeriesItem3 As New Telerik.Charting.ChartSeriesItem()
			Dim corners43 As New Telerik.Charting.Styles.Corners()
			Dim corners44 As New Telerik.Charting.Styles.Corners()
			Dim corners45 As New Telerik.Charting.Styles.Corners()
			Dim corners46 As New Telerik.Charting.Styles.Corners()
			Dim corners47 As New Telerik.Charting.Styles.Corners()
			Dim chartSeriesItem4 As New Telerik.Charting.ChartSeriesItem()
			Dim corners48 As New Telerik.Charting.Styles.Corners()
			Dim corners49 As New Telerik.Charting.Styles.Corners()
			Dim corners50 As New Telerik.Charting.Styles.Corners()
			Dim corners51 As New Telerik.Charting.Styles.Corners()
			Dim corners52 As New Telerik.Charting.Styles.Corners()
			Me.radChart1 = New Telerik.WinControls.UI.RadChart()
			Me.radChart1.Skin = "Default2006"
			CType(Me.radChart1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radChart1
			' 
			Me.radChart1.Appearance.Border.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(131))))), (CInt(Fix((CByte(171))))), (CInt(Fix((CByte(184))))))
			Me.radChart1.Appearance.Corners = corners1
			Me.radChart1.Appearance.FillStyle.FillType = Telerik.Charting.Styles.FillType.Hatch
			Me.radChart1.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(225))))), (CInt(Fix((CByte(235))))), (CInt(Fix((CByte(239))))))
			Me.radChart1.Appearance.FillStyle.SecondColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(207))))), (CInt(Fix((CByte(223))))), (CInt(Fix((CByte(229))))))
			Me.radChart1.ChartTitle.Appearance.Border.Visible = False
			Me.radChart1.ChartTitle.Appearance.Corners = corners2
			Me.radChart1.ChartTitle.Appearance.FillStyle.MainColor = System.Drawing.Color.Empty
			Me.radChart1.ChartTitle.Appearance.Position.AlignedPosition = Telerik.Charting.Styles.AlignedPositions.TopLeft
			Me.radChart1.ChartTitle.Marker.Appearance.Corners = corners3
			Me.radChart1.ChartTitle.TextBlock.Appearance.Corners = corners4
			Me.radChart1.ChartTitle.TextBlock.Appearance.TextProperties.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(81))))), (CInt(Fix((CByte(103))))), (CInt(Fix((CByte(114))))))
			Me.radChart1.ChartTitle.TextBlock.Appearance.TextProperties.Font = New System.Drawing.Font("Arial", 21.75F)
			Me.radChart1.DataGroupColumn = Nothing
			Me.radChart1.DefaultType = Telerik.Charting.ChartSeriesType.Bubble
			Me.radChart1.Legend.Appearance.Border.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(193))))), (CInt(Fix((CByte(214))))), (CInt(Fix((CByte(221))))))
			Me.radChart1.Legend.Appearance.Corners = corners5
			Me.radChart1.Legend.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(241))))), (CInt(Fix((CByte(253))))), (CInt(Fix((CByte(255))))))
			Me.radChart1.Legend.Appearance.ItemAppearance.Corners = corners6
			Me.radChart1.Legend.Appearance.ItemMarkerAppearance.Corners = corners7
			Me.radChart1.Legend.Appearance.ItemTextAppearance.Corners = corners8
			Me.radChart1.Legend.Marker.Appearance.Corners = corners9
			Me.radChart1.Legend.TextBlock.Appearance.Corners = corners10
			Me.radChart1.Location = New System.Drawing.Point(13, 12)
			Me.radChart1.Name = "radChart1"
			Me.radChart1.PlotArea.Appearance.Border.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(193))))), (CInt(Fix((CByte(214))))), (CInt(Fix((CByte(221))))))
			Me.radChart1.PlotArea.Appearance.Corners = corners11
			unit1.Type = Telerik.Charting.Styles.UnitType.Percentage
			unit1.Value = 24F
			unit2.Type = Telerik.Charting.Styles.UnitType.Percentage
			unit2.Value = 22F
			unit3.Type = Telerik.Charting.Styles.UnitType.Percentage
			unit3.Value = 12F
			unit4.Type = Telerik.Charting.Styles.UnitType.Percentage
			unit4.Value = 10F
			Me.radChart1.PlotArea.Appearance.Dimensions.Margins = New Telerik.Charting.Styles.ChartMargins(unit1, unit2, unit3, unit4)
			Me.radChart1.PlotArea.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(241))))), (CInt(Fix((CByte(253))))), (CInt(Fix((CByte(255))))))
			Me.radChart1.SkinsOverrideStyles = True
			Me.radChart1.Skin = "Office2007"
			Me.radChart1.PlotArea.XAxis.Appearance.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(193))))), (CInt(Fix((CByte(214))))), (CInt(Fix((CByte(221))))))
			Me.radChart1.PlotArea.XAxis.Appearance.LabelAppearance.Corners = corners13
			Me.radChart1.PlotArea.XAxis.Appearance.MajorGridLines.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(232))))), (CInt(Fix((CByte(227))))))
			Me.radChart1.PlotArea.XAxis.Appearance.MajorGridLines.PenStyle = System.Drawing.Drawing2D.DashStyle.Solid
			Me.radChart1.PlotArea.XAxis.Appearance.MajorTick.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(154))))), (CInt(Fix((CByte(153))))), (CInt(Fix((CByte(129))))))
			Me.radChart1.PlotArea.XAxis.Appearance.TextAppearance.Corners = corners14
			Me.radChart1.PlotArea.XAxis.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(96))))), (CInt(Fix((CByte(96))))), (CInt(Fix((CByte(78))))))
			Me.radChart1.PlotArea.XAxis.AxisLabel.Appearance.Corners = corners15
			Me.radChart1.PlotArea.XAxis.AxisLabel.Marker.Appearance.Corners = corners16
			Me.radChart1.PlotArea.XAxis.AxisLabel.TextBlock.Appearance.Corners = corners17
			Me.radChart1.PlotArea.XAxis.MaxValue = 4
			Me.radChart1.PlotArea.XAxis.MinValue = 1
			Me.radChart1.PlotArea.XAxis.Step = 1
			Me.radChart1.PlotArea.YAxis.Appearance.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(193))))), (CInt(Fix((CByte(214))))), (CInt(Fix((CByte(221))))))
			Me.radChart1.PlotArea.YAxis.Appearance.LabelAppearance.Corners = corners18
			Me.radChart1.PlotArea.YAxis.Appearance.MajorGridLines.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(232))))), (CInt(Fix((CByte(227))))))
			Me.radChart1.PlotArea.YAxis.Appearance.MajorGridLines.PenStyle = System.Drawing.Drawing2D.DashStyle.Solid
			Me.radChart1.PlotArea.YAxis.Appearance.MajorTick.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(154))))), (CInt(Fix((CByte(153))))), (CInt(Fix((CByte(129))))))
			Me.radChart1.PlotArea.YAxis.Appearance.MinorGridLines.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(232))))), (CInt(Fix((CByte(227))))))
			Me.radChart1.PlotArea.YAxis.Appearance.MinorGridLines.Visible = False
			Me.radChart1.PlotArea.YAxis.Appearance.MinorTick.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(154))))), (CInt(Fix((CByte(153))))), (CInt(Fix((CByte(129))))))
			Me.radChart1.PlotArea.YAxis.Appearance.MinorTick.Visible = False
			Me.radChart1.PlotArea.YAxis.Appearance.TextAppearance.Corners = corners19
			Me.radChart1.PlotArea.YAxis.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(96))))), (CInt(Fix((CByte(96))))), (CInt(Fix((CByte(78))))))
			Me.radChart1.PlotArea.YAxis.AxisLabel.Appearance.Corners = corners20
			Me.radChart1.PlotArea.YAxis.AxisLabel.Marker.Appearance.Corners = corners21
			Me.radChart1.PlotArea.YAxis.AxisLabel.TextBlock.Appearance.Corners = corners22
			Me.radChart1.PlotArea.YAxis.MaxValue = 4
			Me.radChart1.PlotArea.YAxis.Step = 0.5
			Me.radChart1.PlotArea.YAxis2.Appearance.LabelAppearance.Corners = corners23
			Me.radChart1.PlotArea.YAxis2.Appearance.TextAppearance.Corners = corners24
			Me.radChart1.PlotArea.YAxis2.AxisLabel.Appearance.Corners = corners25
			Me.radChart1.PlotArea.YAxis2.AxisLabel.Marker.Appearance.Corners = corners26
			Me.radChart1.PlotArea.YAxis2.AxisLabel.TextBlock.Appearance.Corners = corners27
			Me.radChart1.PlotArea.YAxis2.MaxValue = 4
			Me.radChart1.PlotArea.YAxis2.MinValue = 1
			Me.radChart1.PlotArea.YAxis2.Step = 1
			chartSeries1.Appearance.Corners = corners28
			chartSeries1.Appearance.EmptyValue.PointMark.Corners = corners29
			chartSeries1.Appearance.LabelAppearance.Corners = corners30
			chartSeries1.Appearance.PointMark.Corners = corners31
			chartSeries1.Appearance.TextAppearance.Corners = corners32
			chartSeriesItem1.Appearance.Corners = corners33
			chartSeriesItem1.Label.Appearance.Corners = corners34
			chartSeriesItem1.Label.Marker.Appearance.Corners = corners35
			chartSeriesItem1.Label.TextBlock.Appearance.Corners = corners36
			chartSeriesItem1.PointAppearance.Corners = corners37
			chartSeriesItem1.YValue = 1
			chartSeriesItem2.Appearance.Corners = corners38
			chartSeriesItem2.Label.Appearance.Corners = corners39
			chartSeriesItem2.Label.Marker.Appearance.Corners = corners40
			chartSeriesItem2.Label.TextBlock.Appearance.Corners = corners41
			chartSeriesItem2.PointAppearance.Corners = corners42
			chartSeriesItem2.YValue = 2
			chartSeriesItem3.Appearance.Corners = corners43
			chartSeriesItem3.Label.Appearance.Corners = corners44
			chartSeriesItem3.Label.Marker.Appearance.Corners = corners45
			chartSeriesItem3.Label.TextBlock.Appearance.Corners = corners46
			chartSeriesItem3.PointAppearance.Corners = corners47
			chartSeriesItem3.YValue = 3
			chartSeriesItem4.Appearance.Corners = corners48
			chartSeriesItem4.Label.Appearance.Corners = corners49
			chartSeriesItem4.Label.Marker.Appearance.Corners = corners50
			chartSeriesItem4.Label.TextBlock.Appearance.Corners = corners51
			chartSeriesItem4.PointAppearance.Corners = corners52
			chartSeriesItem4.YValue = 4
			chartSeries1.Items.AddRange(New Telerik.Charting.ChartSeriesItem() { chartSeriesItem1, chartSeriesItem2, chartSeriesItem3, chartSeriesItem4})
			chartSeries1.Name = "Series 1"
			chartSeries1.Type = Telerik.Charting.ChartSeriesType.Bubble
			Me.radChart1.Series.Add(chartSeries1)
			Me.radChart1.Size = New System.Drawing.Size(400, 300)
			Me.radChart1.TabIndex = 0
			' 
			' Form1
			' 

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
