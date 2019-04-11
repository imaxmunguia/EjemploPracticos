Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.Chart.Functionality.Poll
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
			Dim corners1 As New Telerik.Charting.Styles.Corners()
			Dim chartAxisItem1 As New Telerik.Charting.ChartAxisItem()
			Dim chartAxisItem2 As New Telerik.Charting.ChartAxisItem()
			Dim chartAxisItem3 As New Telerik.Charting.ChartAxisItem()
			Dim chartAxisItem4 As New Telerik.Charting.ChartAxisItem()
			Dim chartAxisItem5 As New Telerik.Charting.ChartAxisItem()
			Dim chartAxisItem6 As New Telerik.Charting.ChartAxisItem()
			Dim chartAxisItem7 As New Telerik.Charting.ChartAxisItem()
			Dim chartAxisItem8 As New Telerik.Charting.ChartAxisItem()
			Dim chartAxisItem9 As New Telerik.Charting.ChartAxisItem()
			Dim chartAxisItem10 As New Telerik.Charting.ChartAxisItem()
			Dim chartAxisItem11 As New Telerik.Charting.ChartAxisItem()
			Dim chartAxisItem12 As New Telerik.Charting.ChartAxisItem()
			Dim chartAxisItem13 As New Telerik.Charting.ChartAxisItem()
			Dim chartAxisItem14 As New Telerik.Charting.ChartAxisItem()
			Dim chartAxisItem15 As New Telerik.Charting.ChartAxisItem()
			Dim chartAxisItem16 As New Telerik.Charting.ChartAxisItem()
			Dim chartAxisItem17 As New Telerik.Charting.ChartAxisItem()
			Dim chartAxisItem18 As New Telerik.Charting.ChartAxisItem()
			Dim chartAxisItem19 As New Telerik.Charting.ChartAxisItem()
			Dim chartAxisItem20 As New Telerik.Charting.ChartAxisItem()
			Dim chartSeries1 As New Telerik.Charting.ChartSeries()
			Dim chartSeries2 As New Telerik.Charting.ChartSeries()
			Me.radChart1 = New Telerik.WinControls.UI.RadChart()
			Me.radChart1.Skin = "Default2006"
			CType(Me.radChart1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radChart1
			' 
			unit1.Value = 503
			Me.radChart1.Appearance.Dimensions.Height = unit1
			unit2.Value = 621
			Me.radChart1.Appearance.Dimensions.Width = unit2
			Me.radChart1.ChartTitle.TextBlock.Text = "Consumption by Month"
			Me.radChart1.DataGroupColumn = Nothing
			Me.radChart1.DefaultType = Telerik.Charting.ChartSeriesType.Pie
			Me.radChart1.Legend.Appearance.Border.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(227))))), (CInt(Fix((CByte(227))))), (CInt(Fix((CByte(227))))))
			Me.radChart1.Location = New System.Drawing.Point(12, 12)
			Me.radChart1.Name = "radChart1"
			corners1.BottomLeft = Telerik.Charting.Styles.CornerType.Round
			corners1.BottomRight = Telerik.Charting.Styles.CornerType.Round
			corners1.RoundSize = 6
			corners1.TopLeft = Telerik.Charting.Styles.CornerType.Round
			corners1.TopRight = Telerik.Charting.Styles.CornerType.Round
			Me.radChart1.PlotArea.Appearance.Corners = corners1
			Me.radChart1.PlotArea.XAxis.Appearance.MajorGridLines.Visible = False
			Me.radChart1.PlotArea.XAxis.AxisLabel.TextBlock.Appearance.TextProperties.Font = New System.Drawing.Font("Arial", 10F)
			chartAxisItem1.Value = New Decimal(New Integer() { 1, 0, 0, 0})
			chartAxisItem2.Value = New Decimal(New Integer() { 2, 0, 0, 0})
			chartAxisItem3.Value = New Decimal(New Integer() { 3, 0, 0, 0})
			chartAxisItem4.Value = New Decimal(New Integer() { 4, 0, 0, 0})
			chartAxisItem5.Value = New Decimal(New Integer() { 5, 0, 0, 0})
			chartAxisItem6.Value = New Decimal(New Integer() { 6, 0, 0, 0})
			chartAxisItem7.Value = New Decimal(New Integer() { 7, 0, 0, 0})
			Me.radChart1.PlotArea.XAxis.Items.AddRange(New Telerik.Charting.ChartAxisItem() { chartAxisItem1, chartAxisItem2, chartAxisItem3, chartAxisItem4, chartAxisItem5, chartAxisItem6, chartAxisItem7})
			Me.radChart1.PlotArea.XAxis.MaxValue = 7
			Me.radChart1.PlotArea.XAxis.MinValue = 1
			Me.radChart1.PlotArea.XAxis.Step = 1
			Me.radChart1.PlotArea.YAxis.AxisLabel.TextBlock.Appearance.TextProperties.Font = New System.Drawing.Font("Arial", 10F)
			chartAxisItem9.Value = New Decimal(New Integer() { 20, 0, 0, 0})
			chartAxisItem10.Value = New Decimal(New Integer() { 40, 0, 0, 0})
			chartAxisItem11.Value = New Decimal(New Integer() { 60, 0, 0, 0})
			chartAxisItem12.Value = New Decimal(New Integer() { 80, 0, 0, 0})
			chartAxisItem13.Value = New Decimal(New Integer() { 100, 0, 0, 0})
			Me.radChart1.PlotArea.YAxis.Items.AddRange(New Telerik.Charting.ChartAxisItem() { chartAxisItem8, chartAxisItem9, chartAxisItem10, chartAxisItem11, chartAxisItem12, chartAxisItem13})
			Me.radChart1.PlotArea.YAxis.Step = 20
			Me.radChart1.PlotArea.YAxis2.AxisLabel.TextBlock.Appearance.TextProperties.Font = New System.Drawing.Font("Arial", 10F)
			chartAxisItem14.Value = New Decimal(New Integer() { 1, 0, 0, 0})
			chartAxisItem15.Value = New Decimal(New Integer() { 2, 0, 0, 0})
			chartAxisItem16.Value = New Decimal(New Integer() { 3, 0, 0, 0})
			chartAxisItem17.Value = New Decimal(New Integer() { 4, 0, 0, 0})
			chartAxisItem18.Value = New Decimal(New Integer() { 5, 0, 0, 0})
			chartAxisItem19.Value = New Decimal(New Integer() { 6, 0, 0, 0})
			chartAxisItem20.Value = New Decimal(New Integer() { 7, 0, 0, 0})
			Me.radChart1.PlotArea.YAxis2.Items.AddRange(New Telerik.Charting.ChartAxisItem() { chartAxisItem14, chartAxisItem15, chartAxisItem16, chartAxisItem17, chartAxisItem18, chartAxisItem19, chartAxisItem20})
			Me.radChart1.PlotArea.YAxis2.MaxValue = 7
			Me.radChart1.PlotArea.YAxis2.MinValue = 1
			Me.radChart1.PlotArea.YAxis2.Step = 1
			chartSeries1.Name = "Series 1"
			chartSeries1.Type = Telerik.Charting.ChartSeriesType.Pie
			chartSeries2.Name = "Series 2"
			chartSeries2.Type = Telerik.Charting.ChartSeriesType.Pie
			Me.radChart1.Series.Add(chartSeries1)
			Me.radChart1.Series.Add(chartSeries2)
			Me.radChart1.Size = New System.Drawing.Size(400, 300)
			Me.radChart1.TabIndex = 0
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.radChart1)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(450, 350)
			CType(Me.radChart1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radChart1 As Telerik.WinControls.UI.RadChart
	End Class
End Namespace