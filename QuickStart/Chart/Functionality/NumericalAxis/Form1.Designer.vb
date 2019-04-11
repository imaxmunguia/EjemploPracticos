Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.Chart.Functionality.NumericalAxis
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
			Dim unit1 As New Telerik.Charting.Styles.Unit()
			Dim unit2 As New Telerik.Charting.Styles.Unit()
			Dim unit3 As New Telerik.Charting.Styles.Unit()
			Dim unit4 As New Telerik.Charting.Styles.Unit()
			Dim chartAxisItem1 As New Telerik.Charting.ChartAxisItem()
			Dim chartAxisItem2 As New Telerik.Charting.ChartAxisItem()
			Dim chartAxisItem3 As New Telerik.Charting.ChartAxisItem()
			Dim chartAxisItem4 As New Telerik.Charting.ChartAxisItem()
			Dim chartAxisItem5 As New Telerik.Charting.ChartAxisItem()
			Dim chartAxisItem6 As New Telerik.Charting.ChartAxisItem()
			Dim chartAxisItem7 As New Telerik.Charting.ChartAxisItem()
			Dim chartAxisItem8 As New Telerik.Charting.ChartAxisItem()
			Dim chartSeries1 As New Telerik.Charting.ChartSeries()
			Dim gradientElement1 As New Telerik.Charting.GradientElement()
			Dim gradientElement2 As New Telerik.Charting.GradientElement()
			Dim gradientElement3 As New Telerik.Charting.GradientElement()
			Me.radChart1 = New Telerik.WinControls.UI.RadChart()
			CType(Me.radChart1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radChart1
			' 
			Me.radChart1.Appearance.Border.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(203))))), (CInt(Fix((CByte(225))))), (CInt(Fix((CByte(169))))))
			Me.radChart1.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(235))))), (CInt(Fix((CByte(249))))), (CInt(Fix((CByte(213))))))
			Me.radChart1.ChartTitle.Appearance.Border.Color = System.Drawing.Color.Empty
			Me.radChart1.ChartTitle.Appearance.FillStyle.MainColor = System.Drawing.Color.Empty
			Me.radChart1.ChartTitle.TextBlock.Appearance.TextProperties.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(77))))), (CInt(Fix((CByte(153))))), (CInt(Fix((CByte(4))))))
			Me.radChart1.ChartTitle.TextBlock.Text = "NYSE Index"
			Me.radChart1.Legend.Appearance.Border.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(225))))), (CInt(Fix((CByte(217))))), (CInt(Fix((CByte(201))))))
			Me.radChart1.Legend.Appearance.Corners = New Telerik.Charting.Styles.Corners(Telerik.Charting.Styles.CornerType.Round, Telerik.Charting.Styles.CornerType.Round, Telerik.Charting.Styles.CornerType.Round, Telerik.Charting.Styles.CornerType.Round, 6)
			Me.radChart1.Legend.Appearance.ItemTextAppearance.TextProperties.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(113))))), (CInt(Fix((CByte(94))))), (CInt(Fix((CByte(57))))))
			Me.radChart1.Location = New System.Drawing.Point(12, 12)
			Me.radChart1.Name = "radChart1"
			Me.radChart1.PlotArea.Appearance.Border.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(226))))), (CInt(Fix((CByte(218))))), (CInt(Fix((CByte(202))))))
			unit1.Type = Telerik.Charting.Styles.UnitType.Percentage
			unit1.Value = 18F
			unit2.Type = Telerik.Charting.Styles.UnitType.Percentage
			unit2.Value = 23F
			unit3.Type = Telerik.Charting.Styles.UnitType.Percentage
			unit3.Value = 12F
			unit4.Type = Telerik.Charting.Styles.UnitType.Percentage
			unit4.Value = 10F
			Me.radChart1.PlotArea.Appearance.Dimensions.Margins = New Telerik.Charting.Styles.ChartMargins(unit1, unit2, unit3, unit4)
			Me.radChart1.PlotArea.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(254))))), (CInt(Fix((CByte(255))))), (CInt(Fix((CByte(228))))))
			Me.radChart1.PlotArea.Appearance.FillStyle.SecondColor = System.Drawing.Color.Transparent
			Me.radChart1.SkinsOverrideStyles = True
			Me.radChart1.Skin = "Apple"
			Me.radChart1.PlotArea.XAxis.Appearance.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(226))))), (CInt(Fix((CByte(218))))), (CInt(Fix((CByte(202))))))
			Me.radChart1.PlotArea.XAxis.Appearance.LabelAppearance.RotationAngle = 45F
			Me.radChart1.PlotArea.XAxis.Appearance.MajorGridLines.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(226))))), (CInt(Fix((CByte(218))))), (CInt(Fix((CByte(202))))))
			Me.radChart1.PlotArea.XAxis.Appearance.MajorTick.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(216))))), (CInt(Fix((CByte(207))))), (CInt(Fix((CByte(190))))))
			Me.radChart1.PlotArea.XAxis.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(112))))), (CInt(Fix((CByte(93))))), (CInt(Fix((CByte(56))))))
			Me.radChart1.PlotArea.XAxis.Appearance.ValueFormat = Telerik.Charting.Styles.ChartValueFormat.ShortTime
			Me.radChart1.PlotArea.XAxis.AutoScale = False
			Me.radChart1.PlotArea.XAxis.AxisLabel.TextBlock.Appearance.TextProperties.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(112))))), (CInt(Fix((CByte(93))))), (CInt(Fix((CByte(56))))))
			chartAxisItem1.Appearance.RotationAngle = 45F
			chartAxisItem1.TextBlock.Appearance.TextProperties.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(112))))), (CInt(Fix((CByte(93))))), (CInt(Fix((CByte(56))))))
			chartAxisItem2.Appearance.RotationAngle = 45F
			chartAxisItem2.TextBlock.Appearance.TextProperties.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(112))))), (CInt(Fix((CByte(93))))), (CInt(Fix((CByte(56))))))
			chartAxisItem2.Value = New Decimal(New Integer() { 1, 0, 0, 0})
			chartAxisItem3.Appearance.RotationAngle = 45F
			chartAxisItem3.TextBlock.Appearance.TextProperties.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(112))))), (CInt(Fix((CByte(93))))), (CInt(Fix((CByte(56))))))
			chartAxisItem3.Value = New Decimal(New Integer() { 2, 0, 0, 0})
			chartAxisItem4.Appearance.RotationAngle = 45F
			chartAxisItem4.TextBlock.Appearance.TextProperties.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(112))))), (CInt(Fix((CByte(93))))), (CInt(Fix((CByte(56))))))
			chartAxisItem4.Value = New Decimal(New Integer() { 3, 0, 0, 0})
			chartAxisItem5.Appearance.RotationAngle = 45F
			chartAxisItem5.TextBlock.Appearance.TextProperties.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(112))))), (CInt(Fix((CByte(93))))), (CInt(Fix((CByte(56))))))
			chartAxisItem5.Value = New Decimal(New Integer() { 4, 0, 0, 0})
			chartAxisItem6.Appearance.RotationAngle = 45F
			chartAxisItem6.TextBlock.Appearance.TextProperties.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(112))))), (CInt(Fix((CByte(93))))), (CInt(Fix((CByte(56))))))
			chartAxisItem6.Value = New Decimal(New Integer() { 5, 0, 0, 0})
			chartAxisItem7.Appearance.RotationAngle = 45F
			chartAxisItem7.TextBlock.Appearance.TextProperties.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(112))))), (CInt(Fix((CByte(93))))), (CInt(Fix((CByte(56))))))
			chartAxisItem7.Value = New Decimal(New Integer() { 6, 0, 0, 0})
			chartAxisItem8.Appearance.RotationAngle = 45F
			chartAxisItem8.TextBlock.Appearance.TextProperties.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(112))))), (CInt(Fix((CByte(93))))), (CInt(Fix((CByte(56))))))
			chartAxisItem8.Value = New Decimal(New Integer() { 7, 0, 0, 0})
			Me.radChart1.PlotArea.XAxis.Items.AddRange(New Telerik.Charting.ChartAxisItem() { chartAxisItem1, chartAxisItem2, chartAxisItem3, chartAxisItem4, chartAxisItem5, chartAxisItem6, chartAxisItem7, chartAxisItem8})
			Me.radChart1.PlotArea.XAxis.LayoutMode = Telerik.Charting.Styles.ChartAxisLayoutMode.Inside
			Me.radChart1.PlotArea.YAxis.Appearance.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(226))))), (CInt(Fix((CByte(218))))), (CInt(Fix((CByte(202))))))
			Me.radChart1.PlotArea.YAxis.Appearance.MajorGridLines.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(231))))), (CInt(Fix((CByte(225))))), (CInt(Fix((CByte(212))))))
			Me.radChart1.PlotArea.YAxis.Appearance.MajorTick.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(226))))), (CInt(Fix((CByte(218))))), (CInt(Fix((CByte(202))))))
			Me.radChart1.PlotArea.YAxis.Appearance.MinorGridLines.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(231))))), (CInt(Fix((CByte(225))))), (CInt(Fix((CByte(212))))))
			Me.radChart1.PlotArea.YAxis.Appearance.MinorTick.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(226))))), (CInt(Fix((CByte(218))))), (CInt(Fix((CByte(202))))))
			Me.radChart1.PlotArea.YAxis.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(112))))), (CInt(Fix((CByte(93))))), (CInt(Fix((CByte(56))))))
			Me.radChart1.PlotArea.YAxis.AxisLabel.TextBlock.Appearance.TextProperties.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(112))))), (CInt(Fix((CByte(93))))), (CInt(Fix((CByte(56))))))
			Me.radChart1.PlotArea.YAxis.IsZeroBased = False
			Me.radChart1.PlotArea.YAxis.MaxValue = 80
			Me.radChart1.PlotArea.YAxis.Step = 10
			chartSeries1.Appearance.Border.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(128))))), (CInt(Fix((CByte(0))))))
			gradientElement1.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(243))))), (CInt(Fix((CByte(206))))), (CInt(Fix((CByte(119))))))
			gradientElement2.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(236))))), (CInt(Fix((CByte(190))))), (CInt(Fix((CByte(82))))))
			gradientElement2.Position = 0.5F
			gradientElement3.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(210))))), (CInt(Fix((CByte(157))))), (CInt(Fix((CByte(44))))))
			gradientElement3.Position = 1F
			chartSeries1.Appearance.FillStyle.FillSettings.ComplexGradient.AddRange(New Telerik.Charting.GradientElement() { gradientElement1, gradientElement2, gradientElement3})
			chartSeries1.Appearance.FillStyle.FillType = Telerik.Charting.Styles.FillType.ComplexGradient
			chartSeries1.Appearance.ShowLabels = False
			chartSeries1.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(112))))), (CInt(Fix((CByte(93))))), (CInt(Fix((CByte(56))))))
			chartSeries1.Name = "Index"
			chartSeries1.Type = Telerik.Charting.ChartSeriesType.Area
			Me.radChart1.Series.AddRange(New Telerik.Charting.ChartSeries() { chartSeries1})
			Me.radChart1.Size = New System.Drawing.Size(500, 300)
			Me.radChart1.TabIndex = 0
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.radChart1)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(903, 796)
			CType(Me.radChart1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radChart1 As Telerik.WinControls.UI.RadChart
	End Class
End Namespace