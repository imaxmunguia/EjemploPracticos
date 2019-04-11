Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.Chart.ChartTypes.Area
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
			Dim corners2 As New Telerik.Charting.Styles.Corners()
			Dim chartMargins1 As New Telerik.Charting.Styles.ChartMargins()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Dim corners3 As New Telerik.Charting.Styles.Corners()
			Dim chartMargins2 As New Telerik.Charting.Styles.ChartMargins()
			Dim chartSeries1 As New Telerik.Charting.ChartSeries()
			Dim chartSeriesItem1 As New Telerik.Charting.ChartSeriesItem()
			Dim chartSeriesItem2 As New Telerik.Charting.ChartSeriesItem()
			Dim chartSeriesItem3 As New Telerik.Charting.ChartSeriesItem()
			Dim chartSeriesItem4 As New Telerik.Charting.ChartSeriesItem()
			Dim chartSeriesItem5 As New Telerik.Charting.ChartSeriesItem()
			Dim chartSeries2 As New Telerik.Charting.ChartSeries()
			Dim chartSeriesItem6 As New Telerik.Charting.ChartSeriesItem()
			Dim chartSeriesItem7 As New Telerik.Charting.ChartSeriesItem()
			Dim chartSeriesItem8 As New Telerik.Charting.ChartSeriesItem()
			Dim chartSeriesItem9 As New Telerik.Charting.ChartSeriesItem()
			Dim chartSeriesItem10 As New Telerik.Charting.ChartSeriesItem()
			Me.radChart1 = New Telerik.WinControls.UI.RadChart()
			CType(Me.radChart1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radChart1
			' 
			Me.radChart1.Appearance.Border.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(117))))), (CInt(Fix((CByte(117))))), (CInt(Fix((CByte(117))))))
			Me.radChart1.Appearance.FillStyle.FillType = Telerik.Charting.Styles.FillType.Gradient
			Me.radChart1.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(244))))), (CInt(Fix((CByte(244))))), (CInt(Fix((CByte(234))))))
			Me.radChart1.Appearance.FillStyle.SecondColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(167))))), (CInt(Fix((CByte(172))))), (CInt(Fix((CByte(137))))))
			Me.radChart1.ChartTitle.Appearance.Border.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(64))))), (CInt(Fix((CByte(64))))), (CInt(Fix((CByte(64))))))
			corners1.BottomLeft = Telerik.Charting.Styles.CornerType.Round
			corners1.BottomRight = Telerik.Charting.Styles.CornerType.Round
			corners1.TopLeft = Telerik.Charting.Styles.CornerType.Round
			corners1.TopRight = Telerik.Charting.Styles.CornerType.Round
			Me.radChart1.ChartTitle.Appearance.Corners = corners1
			Me.radChart1.ChartTitle.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(177))))), (CInt(Fix((CByte(183))))), (CInt(Fix((CByte(144))))))
			Me.radChart1.ChartTitle.Appearance.Position.AlignedPosition = Telerik.Charting.Styles.AlignedPositions.Top
			Me.radChart1.ChartTitle.TextBlock.Appearance.TextProperties.Color = System.Drawing.Color.White
			Me.radChart1.ChartTitle.TextBlock.Appearance.TextProperties.Font = New System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold)
			Me.radChart1.ChartTitle.TextBlock.Text = "Area"
			Me.radChart1.DefaultType = Telerik.Charting.ChartSeriesType.Area
			Me.radChart1.Legend.Appearance.Border.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(64))))), (CInt(Fix((CByte(64))))), (CInt(Fix((CByte(64))))))
			corners2.BottomLeft = Telerik.Charting.Styles.CornerType.Round
			corners2.BottomRight = Telerik.Charting.Styles.CornerType.Round
			corners2.TopLeft = Telerik.Charting.Styles.CornerType.Round
			corners2.TopRight = Telerik.Charting.Styles.CornerType.Round
			Me.radChart1.Legend.Appearance.Corners = corners2
			chartMargins1.Right = (CType(resources.GetObject("chartMargins1.Right"), Telerik.Charting.Styles.Unit))
			chartMargins1.Top = (CType(resources.GetObject("chartMargins1.Top"), Telerik.Charting.Styles.Unit))
			Me.radChart1.Legend.Appearance.Dimensions.Margins = chartMargins1
			Me.radChart1.Legend.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(177))))), (CInt(Fix((CByte(183))))), (CInt(Fix((CByte(144))))))
			Me.radChart1.Legend.Appearance.ItemTextAppearance.TextProperties.Font = New System.Drawing.Font("Arial", 9.75F)
			Me.radChart1.Location = New System.Drawing.Point(12, 12)
			Me.radChart1.Name = "radChart1"
			Me.radChart1.PlotArea.Appearance.Border.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(94))))), (CInt(Fix((CByte(94))))), (CInt(Fix((CByte(93))))))
			corners3.BottomLeft = Telerik.Charting.Styles.CornerType.Round
			corners3.BottomRight = Telerik.Charting.Styles.CornerType.Round
			corners3.RoundSize = 6
			corners3.TopLeft = Telerik.Charting.Styles.CornerType.Round
			corners3.TopRight = Telerik.Charting.Styles.CornerType.Round
			Me.radChart1.PlotArea.Appearance.Corners = corners3
			chartMargins2.Bottom = (CType(resources.GetObject("chartMargins2.Bottom"), Telerik.Charting.Styles.Unit))
			chartMargins2.Left = (CType(resources.GetObject("chartMargins2.Left"), Telerik.Charting.Styles.Unit))
			chartMargins2.Right = (CType(resources.GetObject("chartMargins2.Right"), Telerik.Charting.Styles.Unit))
			chartMargins2.Top = (CType(resources.GetObject("chartMargins2.Top"), Telerik.Charting.Styles.Unit))
			Me.radChart1.PlotArea.Appearance.Dimensions.Margins = chartMargins2
			Me.radChart1.PlotArea.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(65))))), (CInt(Fix((CByte(201))))), (CInt(Fix((CByte(254))))))
			Me.radChart1.PlotArea.Appearance.FillStyle.SecondColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(107))))), (CInt(Fix((CByte(186))))))
			Me.radChart1.PlotArea.XAxis.Appearance.MajorGridLines.Color = System.Drawing.Color.DimGray
			Me.radChart1.PlotArea.XAxis.Appearance.MajorGridLines.Visible = False
			Me.radChart1.PlotArea.XAxis.Appearance.MajorTick.Color = System.Drawing.Color.Black
			Me.radChart1.PlotArea.XAxis.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.Black
			Me.radChart1.PlotArea.XAxis.AxisLabel.TextBlock.Appearance.TextProperties.Font = New System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold)
			Me.radChart1.PlotArea.XAxis.LayoutMode = Telerik.Charting.Styles.ChartAxisLayoutMode.Inside
			Me.radChart1.PlotArea.XAxis.MaxValue = 5
			Me.radChart1.PlotArea.XAxis.MinValue = 1
			Me.radChart1.PlotArea.YAxis.Appearance.Color = System.Drawing.Color.Silver
			Me.radChart1.PlotArea.YAxis.Appearance.MajorGridLines.Color = System.Drawing.Color.Black
			Me.radChart1.PlotArea.YAxis.Appearance.MajorTick.Color = System.Drawing.Color.Silver
			Me.radChart1.PlotArea.YAxis.Appearance.MinorGridLines.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(224))))), (CInt(Fix((CByte(224))))))
			Me.radChart1.PlotArea.YAxis.Appearance.MinorGridLines.Visible = False
			Me.radChart1.PlotArea.YAxis.Appearance.MinorTick.Color = System.Drawing.Color.Silver
			Me.radChart1.PlotArea.YAxis.Appearance.MinorTick.Visible = False
			Me.radChart1.PlotArea.YAxis.Appearance.Visible = Telerik.Charting.Styles.ChartAxisVisibility.False
			Me.radChart1.PlotArea.YAxis.AxisLabel.TextBlock.Appearance.TextProperties.Font = New System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold)
			Me.radChart1.PlotArea.YAxis.MaxValue = 100
			Me.radChart1.PlotArea.YAxis.Step = 10
			Me.radChart1.PlotArea.YAxis.Visible = Telerik.Charting.Styles.ChartAxisVisibility.False
			Me.radChart1.PlotArea.YAxis2.AxisLabel.TextBlock.Appearance.TextProperties.Font = New System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold)
			chartSeries1.Appearance.Border.Color = System.Drawing.Color.Black
			chartSeries1.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.Black
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
			chartSeries1.Type = Telerik.Charting.ChartSeriesType.Area
			chartSeries2.Appearance.Border.Color = System.Drawing.Color.Black
			chartSeries2.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.Black
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
			chartSeries2.Items.AddRange(New Telerik.Charting.ChartSeriesItem() { chartSeriesItem6, chartSeriesItem7, chartSeriesItem8, chartSeriesItem9, chartSeriesItem10})
			chartSeries2.Name = "Product B"
			chartSeries2.Type = Telerik.Charting.ChartSeriesType.Area
			Me.radChart1.Series.AddRange(New Telerik.Charting.ChartSeries() { chartSeries1, chartSeries2})
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

