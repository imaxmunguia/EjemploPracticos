Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.Chart.Functionality.NegativeValues
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
			Dim unit1 As New Telerik.Charting.Styles.Unit()
			Dim unit2 As New Telerik.Charting.Styles.Unit()
			Dim unit3 As New Telerik.Charting.Styles.Unit()
			Dim unit4 As New Telerik.Charting.Styles.Unit()
			Dim unit5 As New Telerik.Charting.Styles.Unit()
			Dim unit6 As New Telerik.Charting.Styles.Unit()
			Dim unit7 As New Telerik.Charting.Styles.Unit()
			Dim corners3 As New Telerik.Charting.Styles.Corners()
			Dim corners4 As New Telerik.Charting.Styles.Corners()
			Dim corners5 As New Telerik.Charting.Styles.Corners()
			Dim corners6 As New Telerik.Charting.Styles.Corners()
			Dim corners7 As New Telerik.Charting.Styles.Corners()
			Dim corners8 As New Telerik.Charting.Styles.Corners()
			Dim corners9 As New Telerik.Charting.Styles.Corners()
			Dim corners10 As New Telerik.Charting.Styles.Corners()
			Dim corners11 As New Telerik.Charting.Styles.Corners()
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
			Me.radChart1 = New Telerik.WinControls.UI.RadChart()
			Me.radChart1.Skin = "Default2006"
			CType(Me.radChart1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radChart1
			' 
			Me.radChart1.Appearance.Border.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(103))))), (CInt(Fix((CByte(136))))), (CInt(Fix((CByte(190))))))
			Me.radChart1.Appearance.Corners = corners1
			Me.radChart1.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(249))))), (CInt(Fix((CByte(250))))), (CInt(Fix((CByte(251))))))
			Me.radChart1.ChartTitle.Appearance.Border.Width = 0F
			Me.radChart1.ChartTitle.Appearance.Corners = corners2
			unit1.Type = Telerik.Charting.Styles.UnitType.Percentage
			unit1.Value = 3F
			unit2.Value = 10F
			unit3.Value = 14F
			unit4.Value = 0F
			Me.radChart1.ChartTitle.Appearance.Dimensions.Margins = New Telerik.Charting.Styles.ChartMargins(unit1, unit2, unit3, unit4)
			unit5.Value = 3F
			unit6.Value = 5F
			unit7.Value = 0F
			Me.radChart1.ChartTitle.Appearance.Dimensions.Paddings = New Telerik.Charting.Styles.ChartPaddings(unit5, unit6, unit5, unit7)
			Me.radChart1.ChartTitle.Appearance.FillStyle.MainColor = System.Drawing.Color.Empty
			Me.radChart1.ChartTitle.Appearance.Position.AlignedPosition = Telerik.Charting.Styles.AlignedPositions.TopLeft
			Me.radChart1.ChartTitle.Marker.Appearance.Corners = corners3
			Me.radChart1.ChartTitle.TextBlock.Appearance.Corners = corners4
			Me.radChart1.ChartTitle.TextBlock.Appearance.TextProperties.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(0))))), (CInt(Fix((CByte(102))))))
			Me.radChart1.ChartTitle.TextBlock.Text = "Bar"
			Me.radChart1.DataGroupColumn = Nothing
			Me.radChart1.Legend.Appearance.Border.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(165))))), (CInt(Fix((CByte(190))))), (CInt(Fix((CByte(223))))))
			Me.radChart1.Legend.Appearance.Corners = corners5
			Me.radChart1.Legend.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(231))))), (CInt(Fix((CByte(241))))), (CInt(Fix((CByte(255))))))
			Me.radChart1.Legend.Appearance.ItemAppearance.Corners = corners6
			Me.radChart1.Legend.Appearance.ItemMarkerAppearance.Corners = corners7
			Me.radChart1.Legend.Appearance.ItemTextAppearance.Corners = corners8
			Me.radChart1.Legend.Marker.Appearance.Corners = corners9
			Me.radChart1.Legend.TextBlock.Appearance.Corners = corners10
			Me.radChart1.Location = New System.Drawing.Point(12, 12)
			Me.radChart1.Name = "radChart1"
			Me.radChart1.PlotArea.Appearance.Corners = corners11
			Me.radChart1.PlotArea.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(249))))), (CInt(Fix((CByte(250))))), (CInt(Fix((CByte(251))))))
			Me.radChart1.SkinsOverrideStyles = True
			Me.radChart1.Skin = "Apple"
			Me.radChart1.PlotArea.XAxis.Appearance.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(165))))), (CInt(Fix((CByte(190))))), (CInt(Fix((CByte(223))))))
			Me.radChart1.PlotArea.XAxis.Appearance.LabelAppearance.Corners = corners13
			Me.radChart1.PlotArea.XAxis.Appearance.MajorGridLines.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(165))))), (CInt(Fix((CByte(190))))), (CInt(Fix((CByte(223))))))
			Me.radChart1.PlotArea.XAxis.Appearance.MajorTick.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(165))))), (CInt(Fix((CByte(190))))), (CInt(Fix((CByte(223))))))
			Me.radChart1.PlotArea.XAxis.Appearance.TextAppearance.Corners = corners14
			Me.radChart1.PlotArea.XAxis.AxisLabel.Appearance.Corners = corners15
			Me.radChart1.PlotArea.XAxis.AxisLabel.Marker.Appearance.Corners = corners16
			Me.radChart1.PlotArea.XAxis.AxisLabel.TextBlock.Appearance.Corners = corners17
			Me.radChart1.PlotArea.XAxis.MaxValue = 7
			Me.radChart1.PlotArea.XAxis.MinValue = 1
			Me.radChart1.PlotArea.XAxis.Step = 1
			Me.radChart1.PlotArea.YAxis.Appearance.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(165))))), (CInt(Fix((CByte(190))))), (CInt(Fix((CByte(223))))))
			Me.radChart1.PlotArea.YAxis.Appearance.LabelAppearance.Corners = corners18
			Me.radChart1.PlotArea.YAxis.Appearance.MajorGridLines.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(165))))), (CInt(Fix((CByte(190))))), (CInt(Fix((CByte(223))))))
			Me.radChart1.PlotArea.YAxis.Appearance.MajorTick.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(165))))), (CInt(Fix((CByte(190))))), (CInt(Fix((CByte(223))))))
			Me.radChart1.PlotArea.YAxis.Appearance.MinorGridLines.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(165))))), (CInt(Fix((CByte(190))))), (CInt(Fix((CByte(223))))))
			Me.radChart1.PlotArea.YAxis.Appearance.MinorGridLines.Visible = False
			Me.radChart1.PlotArea.YAxis.Appearance.MinorTick.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(165))))), (CInt(Fix((CByte(190))))), (CInt(Fix((CByte(223))))))
			Me.radChart1.PlotArea.YAxis.Appearance.TextAppearance.Corners = corners19
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
			chartSeries1.Appearance.Corners = corners28
			chartSeries1.Appearance.EmptyValue.PointMark.Corners = corners29
			chartSeries1.Appearance.LabelAppearance.Corners = corners30
			chartSeries1.Appearance.PointMark.Corners = corners31
			chartSeries1.Appearance.TextAppearance.Corners = corners32
			chartSeries1.Name = "Series 1"
			chartSeries2.Appearance.Corners = corners33
			chartSeries2.Appearance.EmptyValue.PointMark.Corners = corners34
			chartSeries2.Appearance.LabelAppearance.Corners = corners35
			chartSeries2.Appearance.PointMark.Corners = corners36
			chartSeries2.Appearance.TextAppearance.Corners = corners37
			chartSeries2.Name = "Series 2"
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
			Me.Size = New System.Drawing.Size(1232, 822)
			CType(Me.radChart1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radChart1 As Telerik.WinControls.UI.RadChart
	End Class
End Namespace