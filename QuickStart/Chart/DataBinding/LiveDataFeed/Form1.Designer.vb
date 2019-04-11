Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.Chart.DataBinding.LiveDataFeed
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
			Me.radChart1 = New Telerik.WinControls.UI.RadChart()
			Me.radChart1.Skin = "Default2006"
			CType(Me.radChart1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radChart1
			' 
			Me.radChart1.Appearance.Border.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(209))))), (CInt(Fix((CByte(197))))), (CInt(Fix((CByte(175))))))
			Me.radChart1.Appearance.Corners = corners1
			Me.radChart1.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(240))))), (CInt(Fix((CByte(237))))), (CInt(Fix((CByte(225))))))
			Me.radChart1.ChartTitle.Appearance.Border.Visible = False
			Me.radChart1.ChartTitle.Appearance.Corners = corners2
			Me.radChart1.ChartTitle.Appearance.FillStyle.MainColor = System.Drawing.Color.Empty
			Me.radChart1.ChartTitle.Marker.Appearance.Corners = corners3
			Me.radChart1.ChartTitle.TextBlock.Appearance.Corners = corners4
			Me.radChart1.ChartTitle.TextBlock.Appearance.TextProperties.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(157))))), (CInt(Fix((CByte(126))))), (CInt(Fix((CByte(97))))))
			Me.radChart1.DataGroupColumn = Nothing
			Me.radChart1.Legend.Appearance.Border.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(225))))), (CInt(Fix((CByte(217))))), (CInt(Fix((CByte(201))))))
			corners5.BottomLeft = Telerik.Charting.Styles.CornerType.Round
			corners5.BottomRight = Telerik.Charting.Styles.CornerType.Round
			corners5.RoundSize = 6
			corners5.TopLeft = Telerik.Charting.Styles.CornerType.Round
			corners5.TopRight = Telerik.Charting.Styles.CornerType.Round
			Me.radChart1.Legend.Appearance.Corners = corners5
			Me.radChart1.Legend.Appearance.ItemAppearance.Corners = corners6
			Me.radChart1.Legend.Appearance.ItemMarkerAppearance.Corners = corners7
			Me.radChart1.Legend.Appearance.ItemTextAppearance.Corners = corners8
			Me.radChart1.Legend.Appearance.ItemTextAppearance.TextProperties.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(151))))), (CInt(Fix((CByte(137))))), (CInt(Fix((CByte(110))))))
			Me.radChart1.Legend.Marker.Appearance.Corners = corners9
			Me.radChart1.Legend.TextBlock.Appearance.Corners = corners10
			Me.radChart1.Location = New System.Drawing.Point(12, 15)
			Me.radChart1.Name = "radChart1"
			Me.radChart1.PlotArea.Appearance.Border.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(225))))), (CInt(Fix((CByte(217))))), (CInt(Fix((CByte(201))))))
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
			Me.radChart1.PlotArea.Appearance.FillStyle.MainColor = System.Drawing.Color.White
			Me.radChart1.SkinsOverrideStyles = True
			Me.radChart1.Skin = "Apple"
			Me.radChart1.PlotArea.XAxis.Appearance.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(225))))), (CInt(Fix((CByte(217))))), (CInt(Fix((CByte(201))))))
			Me.radChart1.PlotArea.XAxis.Appearance.LabelAppearance.Corners = corners13
			Me.radChart1.PlotArea.XAxis.Appearance.MajorGridLines.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(226))))), (CInt(Fix((CByte(218))))), (CInt(Fix((CByte(202))))))
			Me.radChart1.PlotArea.XAxis.Appearance.MajorTick.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(225))))), (CInt(Fix((CByte(217))))), (CInt(Fix((CByte(201))))))
			Me.radChart1.PlotArea.XAxis.Appearance.TextAppearance.Corners = corners14
			Me.radChart1.PlotArea.XAxis.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(112))))), (CInt(Fix((CByte(93))))), (CInt(Fix((CByte(56))))))
			Me.radChart1.PlotArea.XAxis.AxisLabel.Appearance.Corners = corners15
			Me.radChart1.PlotArea.XAxis.AxisLabel.Marker.Appearance.Corners = corners16
			Me.radChart1.PlotArea.XAxis.AxisLabel.TextBlock.Appearance.Corners = corners17
			Me.radChart1.PlotArea.XAxis.MaxValue = 7
			Me.radChart1.PlotArea.XAxis.MinValue = 1
			Me.radChart1.PlotArea.XAxis.Step = 1
			Me.radChart1.PlotArea.YAxis.Appearance.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(225))))), (CInt(Fix((CByte(217))))), (CInt(Fix((CByte(201))))))
			Me.radChart1.PlotArea.YAxis.Appearance.LabelAppearance.Corners = corners18
			Me.radChart1.PlotArea.YAxis.Appearance.MajorGridLines.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(226))))), (CInt(Fix((CByte(218))))), (CInt(Fix((CByte(202))))))
			Me.radChart1.PlotArea.YAxis.Appearance.MajorGridLines.PenStyle = System.Drawing.Drawing2D.DashStyle.Solid
			Me.radChart1.PlotArea.YAxis.Appearance.MajorTick.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(225))))), (CInt(Fix((CByte(217))))), (CInt(Fix((CByte(201))))))
			Me.radChart1.PlotArea.YAxis.Appearance.MinorGridLines.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(226))))), (CInt(Fix((CByte(218))))), (CInt(Fix((CByte(202))))))
			Me.radChart1.PlotArea.YAxis.Appearance.MinorGridLines.Visible = False
			Me.radChart1.PlotArea.YAxis.Appearance.MinorTick.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(225))))), (CInt(Fix((CByte(217))))), (CInt(Fix((CByte(201))))))
			Me.radChart1.PlotArea.YAxis.Appearance.MinorTick.Visible = False
			Me.radChart1.PlotArea.YAxis.Appearance.TextAppearance.Corners = corners19
			Me.radChart1.PlotArea.YAxis.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(112))))), (CInt(Fix((CByte(93))))), (CInt(Fix((CByte(56))))))
			Me.radChart1.PlotArea.YAxis.AxisLabel.Appearance.Corners = corners20
			Me.radChart1.PlotArea.YAxis.AxisLabel.Marker.Appearance.Corners = corners21
			Me.radChart1.PlotArea.YAxis.AxisLabel.TextBlock.Appearance.Corners = corners22
			Me.radChart1.PlotArea.YAxis.Step = 20
			Me.radChart1.PlotArea.YAxis2.Appearance.LabelAppearance.Corners = corners23
			Me.radChart1.PlotArea.YAxis2.Appearance.TextAppearance.Corners = corners24
			Me.radChart1.PlotArea.YAxis2.AxisLabel.Appearance.Corners = corners25
			Me.radChart1.PlotArea.YAxis2.AxisLabel.Marker.Appearance.Corners = corners26
			Me.radChart1.PlotArea.YAxis2.AxisLabel.TextBlock.Appearance.Corners = corners27
			Me.radChart1.PlotArea.YAxis2.MaxValue = 7
			Me.radChart1.PlotArea.YAxis2.MinValue = 1
			Me.radChart1.PlotArea.YAxis2.Step = 1
			chartSeries1.Appearance.Border.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(223))))), (CInt(Fix((CByte(170))))), (CInt(Fix((CByte(43))))))
			chartSeries1.Appearance.Corners = corners28
			chartSeries1.Appearance.EmptyValue.PointMark.Corners = corners29
			chartSeries1.Appearance.LabelAppearance.Corners = corners30
			chartSeries1.Appearance.PointMark.Corners = corners31
			chartSeries1.Appearance.TextAppearance.Corners = corners32
			chartSeries1.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(151))))), (CInt(Fix((CByte(137))))), (CInt(Fix((CByte(110))))))
			chartSeries1.Name = "Series 1"
			Me.radChart1.Series.Add(chartSeries1)
			Me.radChart1.Size = New System.Drawing.Size(400, 300)
			Me.radChart1.TabIndex = 0
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