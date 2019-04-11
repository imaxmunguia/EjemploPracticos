Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.Chart.CandlestickCharts
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
			Dim chartMargins1 As New Telerik.Charting.Styles.ChartMargins()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Dim chartSeries1 As New Telerik.Charting.ChartSeries()
			Dim chartSeriesItem1 As New Telerik.Charting.ChartSeriesItem()
			Dim chartSeriesItem2 As New Telerik.Charting.ChartSeriesItem()
			Dim chartSeriesItem3 As New Telerik.Charting.ChartSeriesItem()
			Dim chartSeriesItem4 As New Telerik.Charting.ChartSeriesItem()
			Dim chartSeriesItem5 As New Telerik.Charting.ChartSeriesItem()
			Me.radChart1 = New Telerik.WinControls.UI.RadChart()
			CType(Me.radChart1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radChart1
			' 
			Me.radChart1.Appearance.Border.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(131))))), (CInt(Fix((CByte(171))))), (CInt(Fix((CByte(184))))))
			Me.radChart1.Appearance.FillStyle.FillType = Telerik.Charting.Styles.FillType.Hatch
			Me.radChart1.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(225))))), (CInt(Fix((CByte(235))))), (CInt(Fix((CByte(239))))))
			Me.radChart1.Appearance.FillStyle.SecondColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(207))))), (CInt(Fix((CByte(223))))), (CInt(Fix((CByte(229))))))
			Me.radChart1.ChartTitle.Appearance.Border.Visible = False
			Me.radChart1.ChartTitle.Appearance.FillStyle.MainColor = System.Drawing.Color.Empty
			Me.radChart1.ChartTitle.TextBlock.Appearance.TextProperties.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(81))))), (CInt(Fix((CByte(103))))), (CInt(Fix((CByte(114))))))
			Me.radChart1.ChartTitle.TextBlock.Appearance.TextProperties.Font = New System.Drawing.Font("Arial", 21.75F)
			Me.radChart1.ChartTitle.TextBlock.Text = "Candlestick Chart"
			Me.radChart1.DefaultType = Telerik.Charting.ChartSeriesType.CandleStick
			Me.radChart1.Legend.Appearance.Border.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(193))))), (CInt(Fix((CByte(214))))), (CInt(Fix((CByte(221))))))
			Me.radChart1.Legend.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(241))))), (CInt(Fix((CByte(253))))), (CInt(Fix((CByte(255))))))
			Me.radChart1.Location = New System.Drawing.Point(12, 12)
			Me.radChart1.Name = "radChart1"
			Me.radChart1.PlotArea.Appearance.Border.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(193))))), (CInt(Fix((CByte(214))))), (CInt(Fix((CByte(221))))))
			chartMargins1.Bottom = (CType(resources.GetObject("chartMargins1.Bottom"), Telerik.Charting.Styles.Unit))
			chartMargins1.Left = (CType(resources.GetObject("chartMargins1.Left"), Telerik.Charting.Styles.Unit))
			chartMargins1.Right = (CType(resources.GetObject("chartMargins1.Right"), Telerik.Charting.Styles.Unit))
			chartMargins1.Top = (CType(resources.GetObject("chartMargins1.Top"), Telerik.Charting.Styles.Unit))
			Me.radChart1.PlotArea.Appearance.Dimensions.Margins = chartMargins1
			Me.radChart1.PlotArea.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(241))))), (CInt(Fix((CByte(253))))), (CInt(Fix((CByte(255))))))
			Me.radChart1.PlotArea.XAxis.Appearance.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(193))))), (CInt(Fix((CByte(214))))), (CInt(Fix((CByte(221))))))
			Me.radChart1.PlotArea.XAxis.Appearance.MajorGridLines.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(232))))), (CInt(Fix((CByte(227))))))
			Me.radChart1.PlotArea.XAxis.Appearance.MajorGridLines.PenStyle = System.Drawing.Drawing2D.DashStyle.Solid
			Me.radChart1.PlotArea.XAxis.Appearance.MajorTick.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(154))))), (CInt(Fix((CByte(153))))), (CInt(Fix((CByte(129))))))
			Me.radChart1.PlotArea.XAxis.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(96))))), (CInt(Fix((CByte(96))))), (CInt(Fix((CByte(78))))))
			Me.radChart1.PlotArea.XAxis.LayoutMode = Telerik.Charting.Styles.ChartAxisLayoutMode.Inside
			Me.radChart1.PlotArea.XAxis.MaxValue = 5
			Me.radChart1.PlotArea.XAxis.MinValue = 1
			Me.radChart1.PlotArea.YAxis.Appearance.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(193))))), (CInt(Fix((CByte(214))))), (CInt(Fix((CByte(221))))))
			Me.radChart1.PlotArea.YAxis.Appearance.MajorGridLines.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(232))))), (CInt(Fix((CByte(227))))))
			Me.radChart1.PlotArea.YAxis.Appearance.MajorGridLines.PenStyle = System.Drawing.Drawing2D.DashStyle.Solid
			Me.radChart1.PlotArea.YAxis.Appearance.MajorTick.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(154))))), (CInt(Fix((CByte(153))))), (CInt(Fix((CByte(129))))))
			Me.radChart1.PlotArea.YAxis.Appearance.MinorGridLines.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(232))))), (CInt(Fix((CByte(227))))))
			Me.radChart1.PlotArea.YAxis.Appearance.MinorGridLines.Visible = False
			Me.radChart1.PlotArea.YAxis.Appearance.MinorTick.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(154))))), (CInt(Fix((CByte(153))))), (CInt(Fix((CByte(129))))))
			Me.radChart1.PlotArea.YAxis.Appearance.MinorTick.Visible = False
			Me.radChart1.PlotArea.YAxis.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(96))))), (CInt(Fix((CByte(96))))), (CInt(Fix((CByte(78))))))
			Me.radChart1.PlotArea.YAxis.MaxValue = 80
			Me.radChart1.PlotArea.YAxis2.MaxValue = 5
			Me.radChart1.PlotArea.YAxis2.MinValue = 1
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
			chartSeries1.Items.AddRange(New Telerik.Charting.ChartSeriesItem() { chartSeriesItem1, chartSeriesItem2, chartSeriesItem3, chartSeriesItem4, chartSeriesItem5})
			chartSeries1.Name = "Product A"
			chartSeries1.Type = Telerik.Charting.ChartSeriesType.SplineArea
			Me.radChart1.Series.AddRange(New Telerik.Charting.ChartSeries() { chartSeries1})
			Me.radChart1.Size = New System.Drawing.Size(400, 300)
			Me.radChart1.Skin = "Apple"
			Me.radChart1.SkinsOverrideStyles = True
			Me.radChart1.TabIndex = 0
			' 
			' Form1
			' 

			Me.Controls.Add(Me.radChart1)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(1230, 606)
			CType(Me.radChart1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radChart1 As Telerik.WinControls.UI.RadChart
	End Class
End Namespace

