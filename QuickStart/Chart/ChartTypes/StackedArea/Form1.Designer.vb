Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.Chart.ChartTypes.StackedArea
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
			Dim chartMargins1 As New Telerik.Charting.Styles.ChartMargins()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Dim chartMargins2 As New Telerik.Charting.Styles.ChartMargins()
			Dim chartSeries1 As New Telerik.Charting.ChartSeries()
			Dim chartSeries2 As New Telerik.Charting.ChartSeries()
			Me.radChart1 = New Telerik.WinControls.UI.RadChart()
			CType(Me.radChart1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radChart1
			' 
			Me.radChart1.Appearance.Border.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(209))))), (CInt(Fix((CByte(197))))), (CInt(Fix((CByte(175))))))
			Me.radChart1.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(240))))), (CInt(Fix((CByte(237))))), (CInt(Fix((CByte(225))))))
			Me.radChart1.ChartTitle.Appearance.Border.Visible = False
			Me.radChart1.ChartTitle.Appearance.FillStyle.MainColor = System.Drawing.Color.Empty
			Me.radChart1.ChartTitle.Appearance.Position.AlignedPosition = Telerik.Charting.Styles.AlignedPositions.Top
			Me.radChart1.ChartTitle.TextBlock.Appearance.TextProperties.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(157))))), (CInt(Fix((CByte(126))))), (CInt(Fix((CByte(97))))))
			Me.radChart1.ChartTitle.TextBlock.Text = "Stacked Area"
			Me.radChart1.DefaultType = Telerik.Charting.ChartSeriesType.StackedArea
			Me.radChart1.Legend.Appearance.Border.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(225))))), (CInt(Fix((CByte(217))))), (CInt(Fix((CByte(201))))))
			corners1.BottomLeft = Telerik.Charting.Styles.CornerType.Round
			corners1.BottomRight = Telerik.Charting.Styles.CornerType.Round
			corners1.RoundSize = 6
			corners1.TopLeft = Telerik.Charting.Styles.CornerType.Round
			corners1.TopRight = Telerik.Charting.Styles.CornerType.Round
			Me.radChart1.Legend.Appearance.Corners = corners1
			chartMargins1.Right = (CType(resources.GetObject("chartMargins1.Right"), Telerik.Charting.Styles.Unit))
			chartMargins1.Top = (CType(resources.GetObject("chartMargins1.Top"), Telerik.Charting.Styles.Unit))
			Me.radChart1.Legend.Appearance.Dimensions.Margins = chartMargins1
			Me.radChart1.Legend.Appearance.ItemTextAppearance.TextProperties.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(151))))), (CInt(Fix((CByte(137))))), (CInt(Fix((CByte(110))))))
			Me.radChart1.Location = New System.Drawing.Point(12, 12)
			Me.radChart1.Name = "radChart1"
			Me.radChart1.PlotArea.Appearance.Border.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(225))))), (CInt(Fix((CByte(217))))), (CInt(Fix((CByte(201))))))
			chartMargins2.Bottom = (CType(resources.GetObject("chartMargins2.Bottom"), Telerik.Charting.Styles.Unit))
			chartMargins2.Left = (CType(resources.GetObject("chartMargins2.Left"), Telerik.Charting.Styles.Unit))
			chartMargins2.Right = (CType(resources.GetObject("chartMargins2.Right"), Telerik.Charting.Styles.Unit))
			chartMargins2.Top = (CType(resources.GetObject("chartMargins2.Top"), Telerik.Charting.Styles.Unit))
			Me.radChart1.PlotArea.Appearance.Dimensions.Margins = chartMargins2
			Me.radChart1.PlotArea.Appearance.FillStyle.FillType = Telerik.Charting.Styles.FillType.Solid
			Me.radChart1.PlotArea.Appearance.FillStyle.MainColor = System.Drawing.Color.White
			Me.radChart1.PlotArea.Appearance.FillStyle.SecondColor = System.Drawing.Color.White
			Me.radChart1.PlotArea.XAxis.Appearance.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(225))))), (CInt(Fix((CByte(217))))), (CInt(Fix((CByte(201))))))
			Me.radChart1.PlotArea.XAxis.Appearance.MajorGridLines.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(226))))), (CInt(Fix((CByte(218))))), (CInt(Fix((CByte(202))))))
			Me.radChart1.PlotArea.XAxis.Appearance.MajorTick.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(225))))), (CInt(Fix((CByte(217))))), (CInt(Fix((CByte(201))))))
			Me.radChart1.PlotArea.XAxis.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(112))))), (CInt(Fix((CByte(93))))), (CInt(Fix((CByte(56))))))
			Me.radChart1.PlotArea.XAxis.MinValue = 1
			Me.radChart1.PlotArea.YAxis.Appearance.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(225))))), (CInt(Fix((CByte(217))))), (CInt(Fix((CByte(201))))))
			Me.radChart1.PlotArea.YAxis.Appearance.MajorGridLines.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(226))))), (CInt(Fix((CByte(218))))), (CInt(Fix((CByte(202))))))
			Me.radChart1.PlotArea.YAxis.Appearance.MajorGridLines.PenStyle = System.Drawing.Drawing2D.DashStyle.Solid
			Me.radChart1.PlotArea.YAxis.Appearance.MajorTick.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(225))))), (CInt(Fix((CByte(217))))), (CInt(Fix((CByte(201))))))
			Me.radChart1.PlotArea.YAxis.Appearance.MinorGridLines.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(226))))), (CInt(Fix((CByte(218))))), (CInt(Fix((CByte(202))))))
			Me.radChart1.PlotArea.YAxis.Appearance.MinorGridLines.Visible = False
			Me.radChart1.PlotArea.YAxis.Appearance.MinorTick.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(225))))), (CInt(Fix((CByte(217))))), (CInt(Fix((CByte(201))))))
			Me.radChart1.PlotArea.YAxis.Appearance.MinorTick.Visible = False
			Me.radChart1.PlotArea.YAxis.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(112))))), (CInt(Fix((CByte(93))))), (CInt(Fix((CByte(56))))))
			Me.radChart1.PlotArea.YAxis.MaxValue = 200
			Me.radChart1.PlotArea.YAxis.Step = 20
			chartSeries1.Appearance.Border.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(223))))), (CInt(Fix((CByte(170))))), (CInt(Fix((CByte(43))))))
			chartSeries1.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(151))))), (CInt(Fix((CByte(137))))), (CInt(Fix((CByte(110))))))
			chartSeries1.Name = "Series 1"
			chartSeries1.Type = Telerik.Charting.ChartSeriesType.StackedArea
			chartSeries2.Appearance.Border.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(223))))), (CInt(Fix((CByte(170))))), (CInt(Fix((CByte(43))))))
			chartSeries2.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(151))))), (CInt(Fix((CByte(137))))), (CInt(Fix((CByte(110))))))
			chartSeries2.Name = "Series 2"
			chartSeries2.Type = Telerik.Charting.ChartSeriesType.StackedArea
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