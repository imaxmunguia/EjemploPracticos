Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.Chart.LogarithmicYAxis
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
			Dim chartMargins1 As New Global.Telerik.Charting.Styles.ChartMargins()
			Dim resources As New Global.System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Dim chartMargins2 As New Global.Telerik.Charting.Styles.ChartMargins()
			Dim chartSeries1 As New Global.Telerik.Charting.ChartSeries()
			Dim chartSeriesItem1 As New Global.Telerik.Charting.ChartSeriesItem()
			Dim chartSeriesItem2 As New Global.Telerik.Charting.ChartSeriesItem()
			Dim chartSeriesItem3 As New Global.Telerik.Charting.ChartSeriesItem()
			Dim chartSeriesItem4 As New Global.Telerik.Charting.ChartSeriesItem()
			Dim chartSeriesItem5 As New Global.Telerik.Charting.ChartSeriesItem()
			Dim chartSeries2 As New Global.Telerik.Charting.ChartSeries()
			Dim chartSeriesItem6 As New Global.Telerik.Charting.ChartSeriesItem()
			Dim chartSeriesItem7 As New Global.Telerik.Charting.ChartSeriesItem()
			Dim chartSeriesItem8 As New Global.Telerik.Charting.ChartSeriesItem()
			Dim chartSeriesItem9 As New Global.Telerik.Charting.ChartSeriesItem()
			Dim chartSeriesItem10 As New Global.Telerik.Charting.ChartSeriesItem()
			Me.radChart1 = New Global.Telerik.WinControls.UI.RadChart()
			CType(Me.radChart1, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radChart1
			' 
			Me.radChart1.Appearance.Border.Color = Global.System.Drawing.Color.FromArgb((CInt(Fix((CByte(182))))), (CInt(Fix((CByte(224))))), (CInt(Fix((CByte(249))))))
			Me.radChart1.Appearance.FillStyle.MainColor = Global.System.Drawing.Color.FromArgb((CInt(Fix((CByte(240))))), (CInt(Fix((CByte(252))))), (CInt(Fix((CByte(255))))))
			Me.radChart1.AutoLayout = True
			Me.radChart1.ChartTitle.Appearance.Border.Visible = False
			Me.radChart1.ChartTitle.Appearance.FillStyle.MainColor = Global.System.Drawing.Color.Empty
			Me.radChart1.ChartTitle.Appearance.Position.AlignedPosition = Global.Telerik.Charting.Styles.AlignedPositions.Top
			Me.radChart1.ChartTitle.TextBlock.Appearance.TextProperties.Color = Global.System.Drawing.Color.FromArgb((CInt(Fix((CByte(70))))), (CInt(Fix((CByte(143))))), (CInt(Fix((CByte(190))))))
			Me.radChart1.ChartTitle.TextBlock.Text = "Logarithmic Y-Axis"
			Me.radChart1.Legend.Appearance.Border.Color = Global.System.Drawing.Color.FromArgb((CInt(Fix((CByte(208))))), (CInt(Fix((CByte(237))))), (CInt(Fix((CByte(255))))))
			corners1.BottomLeft = Global.Telerik.Charting.Styles.CornerType.Round
			corners1.BottomRight = Global.Telerik.Charting.Styles.CornerType.Round
			corners1.RoundSize = 6
			corners1.TopLeft = Global.Telerik.Charting.Styles.CornerType.Round
			corners1.TopRight = Global.Telerik.Charting.Styles.CornerType.Round
			Me.radChart1.Legend.Appearance.Corners = corners1
			chartMargins1.Right = (CType(resources.GetObject("chartMargins1.Right"), Global.Telerik.Charting.Styles.Unit))
			chartMargins1.Top = (CType(resources.GetObject("chartMargins1.Top"), Global.Telerik.Charting.Styles.Unit))
			Me.radChart1.Legend.Appearance.Dimensions.Margins = chartMargins1
			Me.radChart1.Legend.Appearance.ItemTextAppearance.TextProperties.Color = Global.System.Drawing.Color.FromArgb((CInt(Fix((CByte(62))))), (CInt(Fix((CByte(117))))), (CInt(Fix((CByte(154))))))
			Me.radChart1.Legend.Appearance.Visible = False
			Me.radChart1.Legend.Visible = False
			Me.radChart1.Location = New Global.System.Drawing.Point(12, 12)
			Me.radChart1.Name = "radChart1"
			Me.radChart1.PlotArea.Appearance.Border.Color = Global.System.Drawing.Color.FromArgb((CInt(Fix((CByte(149))))), (CInt(Fix((CByte(184))))), (CInt(Fix((CByte(206))))))
			chartMargins2.Bottom = (CType(resources.GetObject("chartMargins2.Bottom"), Global.Telerik.Charting.Styles.Unit))
			chartMargins2.Left = (CType(resources.GetObject("chartMargins2.Left"), Global.Telerik.Charting.Styles.Unit))
			chartMargins2.Right = (CType(resources.GetObject("chartMargins2.Right"), Global.Telerik.Charting.Styles.Unit))
			chartMargins2.Top = (CType(resources.GetObject("chartMargins2.Top"), Global.Telerik.Charting.Styles.Unit))
			Me.radChart1.PlotArea.Appearance.Dimensions.Margins = chartMargins2
			Me.radChart1.PlotArea.Appearance.FillStyle.FillType = Global.Telerik.Charting.Styles.FillType.Solid
			Me.radChart1.PlotArea.Appearance.FillStyle.MainColor = Global.System.Drawing.Color.White
			Me.radChart1.PlotArea.Appearance.FillStyle.SecondColor = Global.System.Drawing.Color.White
			Me.radChart1.PlotArea.XAxis.Appearance.Color = Global.System.Drawing.Color.FromArgb((CInt(Fix((CByte(149))))), (CInt(Fix((CByte(184))))), (CInt(Fix((CByte(206))))))
			Me.radChart1.PlotArea.XAxis.Appearance.MajorGridLines.Color = Global.System.Drawing.Color.FromArgb((CInt(Fix((CByte(153))))), (CInt(Fix((CByte(187))))), (CInt(Fix((CByte(207))))))
			Me.radChart1.PlotArea.XAxis.Appearance.MajorTick.Color = Global.System.Drawing.Color.FromArgb((CInt(Fix((CByte(149))))), (CInt(Fix((CByte(184))))), (CInt(Fix((CByte(206))))))
			Me.radChart1.PlotArea.XAxis.Appearance.TextAppearance.TextProperties.Color = Global.System.Drawing.Color.FromArgb((CInt(Fix((CByte(62))))), (CInt(Fix((CByte(117))))), (CInt(Fix((CByte(154))))))
			Me.radChart1.PlotArea.XAxis.LayoutMode = Global.Telerik.Charting.Styles.ChartAxisLayoutMode.Inside
			Me.radChart1.PlotArea.XAxis.MaxValue = 5
			Me.radChart1.PlotArea.XAxis.MinValue = 1
			Me.radChart1.PlotArea.YAxis.Appearance.Color = Global.System.Drawing.Color.FromArgb((CInt(Fix((CByte(149))))), (CInt(Fix((CByte(184))))), (CInt(Fix((CByte(206))))))
			Me.radChart1.PlotArea.YAxis.Appearance.MajorGridLines.Color = Global.System.Drawing.Color.FromArgb((CInt(Fix((CByte(153))))), (CInt(Fix((CByte(187))))), (CInt(Fix((CByte(207))))))
			Me.radChart1.PlotArea.YAxis.Appearance.MajorGridLines.PenStyle = Global.System.Drawing.Drawing2D.DashStyle.Solid
			Me.radChart1.PlotArea.YAxis.Appearance.MajorTick.Color = Global.System.Drawing.Color.FromArgb((CInt(Fix((CByte(149))))), (CInt(Fix((CByte(184))))), (CInt(Fix((CByte(206))))))
			Me.radChart1.PlotArea.YAxis.Appearance.MinorGridLines.Color = Global.System.Drawing.Color.FromArgb((CInt(Fix((CByte(153))))), (CInt(Fix((CByte(187))))), (CInt(Fix((CByte(207))))))
			Me.radChart1.PlotArea.YAxis.Appearance.MinorGridLines.Visible = False
			Me.radChart1.PlotArea.YAxis.Appearance.MinorTick.Color = Global.System.Drawing.Color.Silver
			Me.radChart1.PlotArea.YAxis.Appearance.MinorTick.Visible = False
			Me.radChart1.PlotArea.YAxis.Appearance.TextAppearance.TextProperties.Color = Global.System.Drawing.Color.FromArgb((CInt(Fix((CByte(62))))), (CInt(Fix((CByte(117))))), (CInt(Fix((CByte(154))))))
			Me.radChart1.PlotArea.YAxis.MaxValue = 100
			Me.radChart1.PlotArea.YAxis.Step = 10
			chartSeries1.Appearance.TextAppearance.TextProperties.Color = Global.System.Drawing.Color.FromArgb((CInt(Fix((CByte(72))))), (CInt(Fix((CByte(124))))), (CInt(Fix((CByte(160))))))
			chartSeriesItem1.YValue = 73
			chartSeriesItem1.YValue2 = 52
			chartSeriesItem2.YValue = 23
			chartSeriesItem2.YValue2 = 76
			chartSeriesItem3.YValue = 22
			chartSeriesItem3.YValue2 = 25
			chartSeriesItem4.YValue = 24
			chartSeriesItem4.YValue2 = 93
			chartSeriesItem5.YValue = 75
			chartSeriesItem5.YValue2 = 55
			chartSeries1.Items.AddRange(New Global.Telerik.Charting.ChartSeriesItem() { chartSeriesItem1, chartSeriesItem2, chartSeriesItem3, chartSeriesItem4, chartSeriesItem5})
			chartSeries1.Name = "Product A"
			chartSeries1.Type = Global.Telerik.Charting.ChartSeriesType.SplineArea
			chartSeries2.Appearance.TextAppearance.TextProperties.Color = Global.System.Drawing.Color.FromArgb((CInt(Fix((CByte(72))))), (CInt(Fix((CByte(124))))), (CInt(Fix((CByte(160))))))
			chartSeriesItem6.YValue = 6
			chartSeriesItem6.YValue2 = 53
			chartSeriesItem7.YValue = 24
			chartSeriesItem7.YValue2 = 22
			chartSeriesItem8.YValue = 51
			chartSeriesItem8.YValue2 = 78
			chartSeriesItem9.YValue = 95
			chartSeriesItem9.YValue2 = 10
			chartSeriesItem10.YValue = 18
			chartSeriesItem10.YValue2 = 60
			chartSeries2.Items.AddRange(New Global.Telerik.Charting.ChartSeriesItem() { chartSeriesItem6, chartSeriesItem7, chartSeriesItem8, chartSeriesItem9, chartSeriesItem10})
			chartSeries2.Name = "Product B"
			chartSeries2.Type = Global.Telerik.Charting.ChartSeriesType.SplineArea
			Me.radChart1.Series.AddRange(New Global.Telerik.Charting.ChartSeries() { chartSeries1, chartSeries2})
			Me.radChart1.Size = New Global.System.Drawing.Size(400, 300)
			Me.radChart1.Skin = "Apple"
			Me.radChart1.SkinsOverrideStyles = True
			Me.radChart1.TabIndex = 0
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New Global.System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.radChart1)
			Me.Name = "Form1"
			Me.Size = New Global.System.Drawing.Size(1230, 606)
			CType(Me.radChart1, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radChart1 As Global.Telerik.WinControls.UI.RadChart
	End Class
End Namespace

