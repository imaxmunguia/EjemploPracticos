Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.Chart.IntelligentLabels
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
			Dim chartMargins2 As New Telerik.Charting.Styles.ChartMargins()
			Dim chartPaddings1 As New Telerik.Charting.Styles.ChartPaddings()
			Dim chartMargins3 As New Telerik.Charting.Styles.ChartMargins()
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
			Me.radChart1.Appearance.Border.Color = System.Drawing.Color.Silver
			Me.radChart1.Appearance.FillStyle.FillSettings.GradientMode = Telerik.Charting.Styles.GradientFillStyle.Center
			Me.radChart1.Appearance.FillStyle.FillType = Telerik.Charting.Styles.FillType.Gradient
			Me.radChart1.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(65))))), (CInt(Fix((CByte(192))))), (CInt(Fix((CByte(247))))))
			Me.radChart1.Appearance.FillStyle.SecondColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(26))))), (CInt(Fix((CByte(120))))), (CInt(Fix((CByte(176))))))
			Me.radChart1.ChartTitle.Appearance.Border.Width = 0F
			chartMargins1.Bottom = (CType(resources.GetObject("chartMargins1.Bottom"), Telerik.Charting.Styles.Unit))
			chartMargins1.Left = (CType(resources.GetObject("chartMargins1.Left"), Telerik.Charting.Styles.Unit))
			chartMargins1.Right = (CType(resources.GetObject("chartMargins1.Right"), Telerik.Charting.Styles.Unit))
			chartMargins1.Top = (CType(resources.GetObject("chartMargins1.Top"), Telerik.Charting.Styles.Unit))
			Me.radChart1.ChartTitle.Appearance.Dimensions.Margins = chartMargins1
			Me.radChart1.ChartTitle.Appearance.FillStyle.MainColor = System.Drawing.Color.Transparent
			Me.radChart1.ChartTitle.TextBlock.Appearance.TextProperties.Color = System.Drawing.Color.White
			Me.radChart1.ChartTitle.TextBlock.Appearance.TextProperties.Font = New System.Drawing.Font("Microsoft Sans Serif", 14F)
			Me.radChart1.ChartTitle.TextBlock.Text = "Intelligent Labels"
			Me.radChart1.DefaultType = Telerik.Charting.ChartSeriesType.SplineArea
			Me.radChart1.IntelligentLabelsEnabled = True
			Me.radChart1.Legend.Appearance.Border.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(96))))), (CInt(Fix((CByte(164))))), (CInt(Fix((CByte(205))))))
			chartMargins2.Right = (CType(resources.GetObject("chartMargins2.Right"), Telerik.Charting.Styles.Unit))
			chartMargins2.Top = (CType(resources.GetObject("chartMargins2.Top"), Telerik.Charting.Styles.Unit))
			Me.radChart1.Legend.Appearance.Dimensions.Margins = chartMargins2
			chartPaddings1.Bottom = (CType(resources.GetObject("chartPaddings1.Bottom"), Telerik.Charting.Styles.Unit))
			chartPaddings1.Left = (CType(resources.GetObject("chartPaddings1.Left"), Telerik.Charting.Styles.Unit))
			chartPaddings1.Right = (CType(resources.GetObject("chartPaddings1.Right"), Telerik.Charting.Styles.Unit))
			chartPaddings1.Top = (CType(resources.GetObject("chartPaddings1.Top"), Telerik.Charting.Styles.Unit))
			Me.radChart1.Legend.Appearance.Dimensions.Paddings = chartPaddings1
			Me.radChart1.Legend.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(50))))), (CInt(Fix((CByte(255))))), (CInt(Fix((CByte(255))))), (CInt(Fix((CByte(255))))))
			Me.radChart1.Legend.Appearance.ItemTextAppearance.TextProperties.Color = System.Drawing.Color.White
			Me.radChart1.Legend.Appearance.ItemTextAppearance.TextProperties.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F)
			Me.radChart1.Location = New System.Drawing.Point(12, 12)
			Me.radChart1.Name = "radChart1"
			Me.radChart1.PlotArea.Appearance.Border.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(50))))), (CInt(Fix((CByte(255))))), (CInt(Fix((CByte(255))))), (CInt(Fix((CByte(255))))))
			chartMargins3.Bottom = (CType(resources.GetObject("chartMargins3.Bottom"), Telerik.Charting.Styles.Unit))
			chartMargins3.Left = (CType(resources.GetObject("chartMargins3.Left"), Telerik.Charting.Styles.Unit))
			chartMargins3.Right = (CType(resources.GetObject("chartMargins3.Right"), Telerik.Charting.Styles.Unit))
			chartMargins3.Top = (CType(resources.GetObject("chartMargins3.Top"), Telerik.Charting.Styles.Unit))
			Me.radChart1.PlotArea.Appearance.Dimensions.Margins = chartMargins3
			Me.radChart1.PlotArea.Appearance.FillStyle.FillType = Telerik.Charting.Styles.FillType.Solid
			Me.radChart1.PlotArea.Appearance.FillStyle.MainColor = System.Drawing.Color.Transparent
			Me.radChart1.PlotArea.Appearance.FillStyle.SecondColor = System.Drawing.Color.White
			Me.radChart1.PlotArea.XAxis.Appearance.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(50))))), (CInt(Fix((CByte(255))))), (CInt(Fix((CByte(255))))), (CInt(Fix((CByte(255))))))
			Me.radChart1.PlotArea.XAxis.Appearance.MajorGridLines.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(50))))), (CInt(Fix((CByte(255))))), (CInt(Fix((CByte(255))))), (CInt(Fix((CByte(255))))))
			Me.radChart1.PlotArea.XAxis.Appearance.MajorTick.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(50))))), (CInt(Fix((CByte(255))))), (CInt(Fix((CByte(255))))), (CInt(Fix((CByte(255))))))
			Me.radChart1.PlotArea.XAxis.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.White
			Me.radChart1.PlotArea.XAxis.Appearance.TextAppearance.TextProperties.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F)
			Me.radChart1.PlotArea.XAxis.AxisLabel.TextBlock.Appearance.TextProperties.Color = System.Drawing.Color.White
			Me.radChart1.PlotArea.XAxis.LayoutMode = Telerik.Charting.Styles.ChartAxisLayoutMode.Inside
			Me.radChart1.PlotArea.XAxis.MaxValue = 5
			Me.radChart1.PlotArea.XAxis.MinValue = 1
			Me.radChart1.PlotArea.YAxis.Appearance.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(50))))), (CInt(Fix((CByte(255))))), (CInt(Fix((CByte(255))))), (CInt(Fix((CByte(255))))))
			Me.radChart1.PlotArea.YAxis.Appearance.MajorGridLines.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(50))))), (CInt(Fix((CByte(255))))), (CInt(Fix((CByte(255))))), (CInt(Fix((CByte(255))))))
			Me.radChart1.PlotArea.YAxis.Appearance.MajorTick.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(50))))), (CInt(Fix((CByte(255))))), (CInt(Fix((CByte(255))))), (CInt(Fix((CByte(255))))))
			Me.radChart1.PlotArea.YAxis.Appearance.MinorGridLines.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(50))))), (CInt(Fix((CByte(255))))), (CInt(Fix((CByte(255))))), (CInt(Fix((CByte(255))))))
			Me.radChart1.PlotArea.YAxis.Appearance.MinorTick.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(50))))), (CInt(Fix((CByte(255))))), (CInt(Fix((CByte(255))))), (CInt(Fix((CByte(255))))))
			Me.radChart1.PlotArea.YAxis.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.White
			Me.radChart1.PlotArea.YAxis.Appearance.TextAppearance.TextProperties.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F)
			Me.radChart1.PlotArea.YAxis.MaxValue = 80
			Me.radChart1.PlotArea.YAxis.Step = 10
			Me.radChart1.PlotArea.YAxis2.Appearance.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(50))))), (CInt(Fix((CByte(255))))), (CInt(Fix((CByte(255))))), (CInt(Fix((CByte(255))))))
			Me.radChart1.PlotArea.YAxis2.Appearance.MajorGridLines.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(50))))), (CInt(Fix((CByte(255))))), (CInt(Fix((CByte(255))))), (CInt(Fix((CByte(255))))))
			Me.radChart1.PlotArea.YAxis2.Appearance.MajorTick.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(50))))), (CInt(Fix((CByte(255))))), (CInt(Fix((CByte(255))))), (CInt(Fix((CByte(255))))))
			Me.radChart1.PlotArea.YAxis2.Appearance.MinorGridLines.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(50))))), (CInt(Fix((CByte(255))))), (CInt(Fix((CByte(255))))), (CInt(Fix((CByte(255))))))
			Me.radChart1.PlotArea.YAxis2.Appearance.MinorTick.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(50))))), (CInt(Fix((CByte(255))))), (CInt(Fix((CByte(255))))), (CInt(Fix((CByte(255))))))
			Me.radChart1.PlotArea.YAxis2.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.White
			Me.radChart1.PlotArea.YAxis2.Appearance.TextAppearance.TextProperties.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F)
			chartSeries1.Appearance.Border.Color = System.Drawing.Color.Empty
			chartSeries1.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(213))))), (CInt(Fix((CByte(247))))), (CInt(Fix((CByte(255))))))
			chartSeries1.Appearance.FillStyle.SecondColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(157))))), (CInt(Fix((CByte(217))))), (CInt(Fix((CByte(238))))))
			chartSeries1.Appearance.PointMark.FillStyle.MainColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(213))))), (CInt(Fix((CByte(247))))), (CInt(Fix((CByte(255))))))
			chartSeries1.Appearance.PointMark.FillStyle.SecondColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(157))))), (CInt(Fix((CByte(217))))), (CInt(Fix((CByte(238))))))
			chartSeries1.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.White
			chartSeries1.Appearance.TextAppearance.TextProperties.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F)
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
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
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

