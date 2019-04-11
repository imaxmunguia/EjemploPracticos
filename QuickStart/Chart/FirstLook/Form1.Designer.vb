Imports Microsoft.VisualBasic
Imports System
Imports Telerik.QuickStart.WinControls

Namespace Telerik.Examples.WinControls.Chart.FirstLook
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
			If (Not radChart1.IsDisposed) Then
				radChart1.Dispose()
			End If
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
			Me.components = New System.ComponentModel.Container()
			Dim chartMargins1 As New Telerik.Charting.Styles.ChartMargins()
			Dim unit1 As New Telerik.Charting.Styles.Unit()
			Dim unit2 As New Telerik.Charting.Styles.Unit()
			Dim unit3 As New Telerik.Charting.Styles.Unit()
			Dim unit4 As New Telerik.Charting.Styles.Unit()
			Dim chartMargins2 As New Telerik.Charting.Styles.ChartMargins()
			Dim unit5 As New Telerik.Charting.Styles.Unit()
			Dim corners1 As New Telerik.Charting.Styles.Corners()
			Dim chartMargins3 As New Telerik.Charting.Styles.ChartMargins()
			Dim unit6 As New Telerik.Charting.Styles.Unit()
			Dim unit7 As New Telerik.Charting.Styles.Unit()
			Dim unit8 As New Telerik.Charting.Styles.Unit()
			Dim unit9 As New Telerik.Charting.Styles.Unit()
			Dim chartSeries1 As New Telerik.Charting.ChartSeries()
			Dim chartSeries2 As New Telerik.Charting.ChartSeries()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.radChart1 = New Telerik.WinControls.UI.RadChart()
			Me.radButton1 = New Telerik.WinControls.UI.RadButton()
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.panel = New Telerik.QuickStart.WinControls.RadCustomPanel()
			Me.pictureBox1 = New System.Windows.Forms.PictureBox()
			Me.radButton7 = New Telerik.WinControls.UI.RadButton()
			Me.radButton5 = New Telerik.WinControls.UI.RadButton()
			Me.radButton3 = New Telerik.WinControls.UI.RadButton()
			Me.radButton4 = New Telerik.WinControls.UI.RadButton()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			Me.roundRectShape1 = New Telerik.WinControls.RoundRectShape()
			Me.trackBarUThumbShape1 = New Telerik.WinControls.UI.TrackBarUThumbShape()
			Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
			Me.pictureBox2 = New System.Windows.Forms.PictureBox()
			CType(Me.radChart1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton7, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radChart1
			' 
			Me.radChart1.Appearance.Border.Color = System.Drawing.Color.Silver
			Me.radChart1.Appearance.FillStyle.MainColor = System.Drawing.Color.WhiteSmoke
			Me.radChart1.ChartTitle.Appearance.Border.Width = 1F
			unit1.Value = 14F
			chartMargins1.Bottom = unit1
			unit2.Value = 10F
			chartMargins1.Left = unit2
			unit3.Value = 10F
			chartMargins1.Right = unit3
			unit4.Value = 14F
			chartMargins1.Top = unit4
			Me.radChart1.ChartTitle.Appearance.Dimensions.Margins = chartMargins1
			Me.radChart1.ChartTitle.Appearance.Position.AlignedPosition = Telerik.Charting.Styles.AlignedPositions.Top
			Me.radChart1.ChartTitle.TextBlock.Appearance.TextProperties.Color = System.Drawing.Color.Gray
			Me.radChart1.ChartTitle.TextBlock.Text = "Secondary Y-Axis"
			Me.radChart1.Legend.Appearance.Border.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(227))))), (CInt(Fix((CByte(227))))), (CInt(Fix((CByte(227))))))
			unit5.Value = 15F
			chartMargins2.Right = unit5
			Me.radChart1.Legend.Appearance.Dimensions.Margins = chartMargins2
			Me.radChart1.Legend.Appearance.ItemTextAppearance.TextProperties.Font = New System.Drawing.Font("Arial", 9.75F)
			Me.radChart1.Location = New System.Drawing.Point(263, 47)
			Me.radChart1.Name = "radChart1"
			Me.radChart1.PlotArea.Appearance.Border.Color = System.Drawing.Color.Silver
			corners1.BottomLeft = Telerik.Charting.Styles.CornerType.Round
			corners1.BottomRight = Telerik.Charting.Styles.CornerType.Round
			corners1.RoundSize = 6
			corners1.TopLeft = Telerik.Charting.Styles.CornerType.Round
			corners1.TopRight = Telerik.Charting.Styles.CornerType.Round
			Me.radChart1.PlotArea.Appearance.Corners = corners1
			unit6.Value = 35F
			chartMargins3.Bottom = unit6
			unit7.Value = 35F
			chartMargins3.Left = unit7
			unit8.Value = 100F
			chartMargins3.Right = unit8
			unit9.Value = 50F
			chartMargins3.Top = unit9
			Me.radChart1.PlotArea.Appearance.Dimensions.Margins = chartMargins3
			Me.radChart1.PlotArea.Appearance.FillStyle.FillType = Telerik.Charting.Styles.FillType.Solid
			Me.radChart1.PlotArea.Appearance.FillStyle.MainColor = System.Drawing.Color.White
			Me.radChart1.PlotArea.Appearance.FillStyle.SecondColor = System.Drawing.Color.White
			Me.radChart1.PlotArea.XAxis.Appearance.Color = System.Drawing.Color.Silver
			Me.radChart1.PlotArea.XAxis.Appearance.MajorGridLines.Color = System.Drawing.Color.Silver
			Me.radChart1.PlotArea.XAxis.Appearance.MajorTick.Color = System.Drawing.Color.Silver
			Me.radChart1.PlotArea.XAxis.AxisLabel.TextBlock.Appearance.TextProperties.Font = New System.Drawing.Font("Arial", 10F)
			Me.radChart1.PlotArea.XAxis.MinValue = 1
			Me.radChart1.PlotArea.YAxis.Appearance.Color = System.Drawing.Color.Silver
			Me.radChart1.PlotArea.YAxis.Appearance.MajorGridLines.Color = System.Drawing.Color.Silver
			Me.radChart1.PlotArea.YAxis.Appearance.MajorTick.Color = System.Drawing.Color.Silver
			Me.radChart1.PlotArea.YAxis.Appearance.MinorGridLines.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(224))))), (CInt(Fix((CByte(224))))))
			Me.radChart1.PlotArea.YAxis.Appearance.MinorTick.Color = System.Drawing.Color.Silver
			Me.radChart1.PlotArea.YAxis.AxisLabel.TextBlock.Appearance.TextProperties.Font = New System.Drawing.Font("Arial", 10F)
			Me.radChart1.PlotArea.YAxis.MaxValue = 90
			Me.radChart1.PlotArea.YAxis.Step = 10
			Me.radChart1.PlotArea.YAxis2.AxisLabel.TextBlock.Appearance.TextProperties.Font = New System.Drawing.Font("Arial", 10F)
			Me.radChart1.PlotArea.YAxis2.MaxValue = 100
			Me.radChart1.PlotArea.YAxis2.Step = 10
			chartSeries1.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(206))))), (CInt(Fix((CByte(38))))))
			chartSeries1.Appearance.FillStyle.SecondColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(247))))), (CInt(Fix((CByte(221))))))
			chartSeries1.Appearance.PointMark.FillStyle.MainColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(206))))), (CInt(Fix((CByte(38))))))
			chartSeries1.Appearance.PointMark.FillStyle.SecondColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(247))))), (CInt(Fix((CByte(221))))))
			chartSeries1.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.Black
			chartSeries1.Appearance.TextAppearance.TextProperties.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			chartSeries1.Name = "Series 1"
			chartSeries1.Type = Telerik.Charting.ChartSeriesType.Area
			chartSeries2.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(99))))), (CInt(Fix((CByte(99))))), (CInt(Fix((CByte(99))))))
			chartSeries2.Appearance.FillStyle.SecondColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(231))))), (CInt(Fix((CByte(231))))), (CInt(Fix((CByte(231))))))
			chartSeries2.Appearance.PointMark.FillStyle.MainColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(99))))), (CInt(Fix((CByte(99))))), (CInt(Fix((CByte(99))))))
			chartSeries2.Appearance.PointMark.FillStyle.SecondColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(231))))), (CInt(Fix((CByte(231))))), (CInt(Fix((CByte(231))))))
			chartSeries2.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.Black
			chartSeries2.Appearance.TextAppearance.TextProperties.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			chartSeries2.Name = "Series 2"
			chartSeries2.Type = Telerik.Charting.ChartSeriesType.Area
			chartSeries2.YAxisType = Telerik.Charting.ChartYAxisType.Secondary
			Me.radChart1.Series.AddRange(New Telerik.Charting.ChartSeries() { chartSeries1, chartSeries2})
			Me.radChart1.Size = New System.Drawing.Size(400, 300)
			Me.radChart1.Skin = "Apple"
			Me.radChart1.SkinsOverrideStyles = True
			Me.radChart1.TabIndex = 0
			' 
			' radButton1
			' 
			Me.radButton1.BackColor = System.Drawing.Color.Transparent
			Me.radButton1.Font = New System.Drawing.Font("Arial", 14F)
			Me.radButton1.ForeColor = System.Drawing.Color.Black
			Me.radButton1.ImageList = Me.imageList1
			Me.radButton1.ImageScalingSize = New System.Drawing.Size(64, 64)
			Me.radButton1.Location = New System.Drawing.Point(12, 33)
			Me.radButton1.Name = "radButton1"
			' 
			' 
			' 
			Me.radButton1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radButton1.Size = New System.Drawing.Size(227, 88)
			Me.radButton1.TabIndex = 1
			Me.radButton1.Text = "Pie"
			Me.radButton1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			Me.radButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
'			Me.radButton1.Click += New System.EventHandler(Me.radButton1_Click);
			CType(Me.radButton1.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = (CType(resources.GetObject("resource.Image"), System.Drawing.Image))
			CType(Me.radButton1.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			CType(Me.radButton1.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			CType(Me.radButton1.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "Pie"
			CType(Me.radButton1.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
			CType(Me.radButton1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).NumberOfColors = 1
			CType(Me.radButton1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.Transparent
			CType(Me.radButton1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Layouts.ImageAndTextLayoutPanel).Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
			CType(Me.radButton1.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).StretchHorizontally = True
			CType(Me.radButton1.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(75))))), (CInt(Fix((CByte(83))))), (CInt(Fix((CByte(62))))))
			CType(Me.radButton1.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Font = New System.Drawing.Font("Arial", 14F)
			CType(Me.radButton1.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
			CType(Me.radButton1.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Alignment = System.Drawing.ContentAlignment.MiddleLeft
			CType(Me.radButton1.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.Transparent
			CType(Me.radButton1.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).BackColor = System.Drawing.Color.Transparent
			CType(Me.radButton1.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
			Me.imageList1.Images.SetKeyName(0, "Bubble.png")
			Me.imageList1.Images.SetKeyName(1, "Candlestick.png")
			Me.imageList1.Images.SetKeyName(2, "Gant.png")
			Me.imageList1.Images.SetKeyName(3, "Pie.png")
			Me.imageList1.Images.SetKeyName(4, "SplineArea.png")
			Me.imageList1.Images.SetKeyName(5, "SplineLine.png")
			Me.imageList1.Images.SetKeyName(6, "StackedArea100.png")
			Me.imageList1.Images.SetKeyName(7, "StackedArea.png")
			Me.imageList1.Images.SetKeyName(8, "StackedBar100.png")
			Me.imageList1.Images.SetKeyName(9, "StackedSplineArea100.png")
			Me.imageList1.Images.SetKeyName(10, "StackedSplineArea.png")
			Me.imageList1.Images.SetKeyName(11, "StakedBar.png")
			Me.imageList1.Images.SetKeyName(12, "Area.png")
			Me.imageList1.Images.SetKeyName(13, "Bar.png")
			Me.imageList1.Images.SetKeyName(14, "Line.png")
			' 
			' panel
			' 
			Me.panel.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(232))))), (CInt(Fix((CByte(242))))), (CInt(Fix((CByte(217))))))
			Me.panel.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(210))))), (CInt(Fix((CByte(210))))), (CInt(Fix((CByte(210))))))
			Me.panel.Controls.Add(Me.pictureBox1)
			Me.panel.Controls.Add(Me.radButton7)
			Me.panel.Controls.Add(Me.radButton5)
			Me.panel.Controls.Add(Me.radButton3)
			Me.panel.Controls.Add(Me.radButton4)
			Me.panel.Controls.Add(Me.radButton1)
			Me.panel.Controls.Add(Me.radLabel1)
			Me.panel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F)
			Me.panel.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(200))))), (CInt(Fix((CByte(111))))), (CInt(Fix((CByte(61))))))
			Me.panel.LineBounds = New System.Drawing.Rectangle(10, 30, 240, 30)
			Me.panel.Location = New System.Drawing.Point(5, 5)
			Me.panel.Name = "panel"
			' 
			' 
			' 
			Me.panel.RootElement.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(200))))), (CInt(Fix((CByte(111))))), (CInt(Fix((CByte(61))))))
			Me.panel.Size = New System.Drawing.Size(250, 495)
			Me.panel.TabIndex = 0
			Me.panel.ThemeName = "Examples"
			CType(Me.panel.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).ForeColor = System.Drawing.Color.Transparent
			CType(Me.panel.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(232))))), (CInt(Fix((CByte(242))))), (CInt(Fix((CByte(217))))))
			CType(Me.panel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Solid
			CType(Me.panel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.Transparent
			CType(Me.panel.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.TextPrimitive).ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(0))))), (CInt(Fix((CByte(0))))))
			CType(Me.panel.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.TextPrimitive).Font = New System.Drawing.Font("Arial", 14F)
			' 
			' pictureBox1
			' 
			Me.pictureBox1.Image = My.Resources.separator
			Me.pictureBox1.Location = New System.Drawing.Point(16, 28)
			Me.pictureBox1.Margin = New System.Windows.Forms.Padding(0)
			Me.pictureBox1.Name = "pictureBox1"
			Me.pictureBox1.Size = New System.Drawing.Size(227, 6)
			Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.pictureBox1.TabIndex = 1
			Me.pictureBox1.TabStop = False
			' 
			' radButton7
			' 
			Me.radButton7.BackColor = System.Drawing.Color.Transparent
			Me.radButton7.Font = New System.Drawing.Font("Arial", 14F)
			Me.radButton7.ForeColor = System.Drawing.Color.Black
			Me.radButton7.ImageList = Me.imageList1
			Me.radButton7.ImageScalingSize = New System.Drawing.Size(64, 64)
			Me.radButton7.Location = New System.Drawing.Point(12, 306)
			Me.radButton7.Name = "radButton7"
			' 
			' 
			' 
			Me.radButton7.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radButton7.Size = New System.Drawing.Size(226, 88)
			Me.radButton7.TabIndex = 4
			Me.radButton7.Text = "Area"
			Me.radButton7.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			Me.radButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
'			Me.radButton7.Click += New System.EventHandler(Me.radButton7_Click);
			CType(Me.radButton7.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = (CType(resources.GetObject("resource.Image1"), System.Drawing.Image))
			CType(Me.radButton7.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			CType(Me.radButton7.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			CType(Me.radButton7.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "Area"
			CType(Me.radButton7.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
			CType(Me.radButton7.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).NumberOfColors = 1
			CType(Me.radButton7.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.Transparent
			CType(Me.radButton7.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Layouts.ImageAndTextLayoutPanel).Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
			CType(Me.radButton7.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).StretchHorizontally = True
			CType(Me.radButton7.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(75))))), (CInt(Fix((CByte(83))))), (CInt(Fix((CByte(62))))))
			CType(Me.radButton7.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Font = New System.Drawing.Font("Arial", 14F)
			CType(Me.radButton7.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
			CType(Me.radButton7.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Alignment = System.Drawing.ContentAlignment.MiddleLeft
			CType(Me.radButton7.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.Transparent
			CType(Me.radButton7.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).BackColor = System.Drawing.Color.Transparent
			CType(Me.radButton7.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
			' 
			' radButton5
			' 
			Me.radButton5.BackColor = System.Drawing.Color.Transparent
			Me.radButton5.Font = New System.Drawing.Font("Arial", 14F)
			Me.radButton5.ForeColor = System.Drawing.Color.Black
			Me.radButton5.ImageList = Me.imageList1
			Me.radButton5.ImageScalingSize = New System.Drawing.Size(64, 64)
			Me.radButton5.Location = New System.Drawing.Point(12, 397)
			Me.radButton5.Name = "radButton5"
			' 
			' 
			' 
			Me.radButton5.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radButton5.Size = New System.Drawing.Size(226, 88)
			Me.radButton5.TabIndex = 5
			Me.radButton5.Text = " Line"
			Me.radButton5.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			Me.radButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
'			Me.radButton5.Click += New System.EventHandler(Me.radButton5_Click);
			CType(Me.radButton5.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = (CType(resources.GetObject("resource.Image2"), System.Drawing.Image))
			CType(Me.radButton5.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			CType(Me.radButton5.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			CType(Me.radButton5.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = " Line"
			CType(Me.radButton5.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
			CType(Me.radButton5.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).NumberOfColors = 1
			CType(Me.radButton5.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.Transparent
			CType(Me.radButton5.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
			CType(Me.radButton5.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Layouts.ImageAndTextLayoutPanel).Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
			CType(Me.radButton5.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).StretchHorizontally = True
			CType(Me.radButton5.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(75))))), (CInt(Fix((CByte(83))))), (CInt(Fix((CByte(62))))))
			CType(Me.radButton5.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Font = New System.Drawing.Font("Arial", 14F)
			CType(Me.radButton5.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
			CType(Me.radButton5.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Alignment = System.Drawing.ContentAlignment.MiddleLeft
			CType(Me.radButton5.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.Transparent
			CType(Me.radButton5.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).BackColor = System.Drawing.Color.Transparent
			CType(Me.radButton5.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
			' 
			' radButton3
			' 
			Me.radButton3.BackColor = System.Drawing.Color.Transparent
			Me.radButton3.Font = New System.Drawing.Font("Arial", 14F)
			Me.radButton3.ForeColor = System.Drawing.Color.Black
			Me.radButton3.ImageList = Me.imageList1
			Me.radButton3.ImageScalingSize = New System.Drawing.Size(64, 64)
			Me.radButton3.Location = New System.Drawing.Point(12, 214)
			Me.radButton3.Name = "radButton3"
			' 
			' 
			' 
			Me.radButton3.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radButton3.Size = New System.Drawing.Size(226, 88)
			Me.radButton3.TabIndex = 3
			Me.radButton3.Text = "Stacked Bar"
			Me.radButton3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			Me.radButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
'			Me.radButton3.Click += New System.EventHandler(Me.radButton3_Click);
			CType(Me.radButton3.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = (CType(resources.GetObject("resource.Image3"), System.Drawing.Image))
			CType(Me.radButton3.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			CType(Me.radButton3.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			CType(Me.radButton3.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "Stacked Bar"
			CType(Me.radButton3.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
			CType(Me.radButton3.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).NumberOfColors = 1
			CType(Me.radButton3.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.Transparent
			CType(Me.radButton3.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Layouts.ImageAndTextLayoutPanel).Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
			CType(Me.radButton3.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).StretchHorizontally = True
			CType(Me.radButton3.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(75))))), (CInt(Fix((CByte(83))))), (CInt(Fix((CByte(62))))))
			CType(Me.radButton3.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Font = New System.Drawing.Font("Arial", 14F)
			CType(Me.radButton3.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
			CType(Me.radButton3.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Alignment = System.Drawing.ContentAlignment.MiddleLeft
			CType(Me.radButton3.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.Transparent
			CType(Me.radButton3.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).BackColor = System.Drawing.Color.Transparent
			CType(Me.radButton3.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
			' 
			' radButton4
			' 
			Me.radButton4.BackColor = System.Drawing.Color.Transparent
			Me.radButton4.Font = New System.Drawing.Font("Arial", 14F)
			Me.radButton4.ForeColor = System.Drawing.Color.Black
			Me.radButton4.ImageList = Me.imageList1
			Me.radButton4.ImageScalingSize = New System.Drawing.Size(64, 64)
			Me.radButton4.Location = New System.Drawing.Point(12, 124)
			Me.radButton4.Name = "radButton4"
			' 
			' 
			' 
			Me.radButton4.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radButton4.Size = New System.Drawing.Size(226, 88)
			Me.radButton4.TabIndex = 2
			Me.radButton4.Text = "Bar"
			Me.radButton4.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			Me.radButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
'			Me.radButton4.Click += New System.EventHandler(Me.radButton4_Click);
			CType(Me.radButton4.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = (CType(resources.GetObject("resource.Image4"), System.Drawing.Image))
			CType(Me.radButton4.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			CType(Me.radButton4.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			CType(Me.radButton4.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "Bar"
			CType(Me.radButton4.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
			CType(Me.radButton4.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).NumberOfColors = 1
			CType(Me.radButton4.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.Transparent
			CType(Me.radButton4.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Layouts.ImageAndTextLayoutPanel).Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
			CType(Me.radButton4.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).StretchHorizontally = True
			CType(Me.radButton4.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(75))))), (CInt(Fix((CByte(83))))), (CInt(Fix((CByte(62))))))
			CType(Me.radButton4.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Font = New System.Drawing.Font("Arial", 14F)
			CType(Me.radButton4.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
			CType(Me.radButton4.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Alignment = System.Drawing.ContentAlignment.MiddleLeft
			CType(Me.radButton4.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.Transparent
			CType(Me.radButton4.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).BackColor = System.Drawing.Color.Transparent
			CType(Me.radButton4.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
			' 
			' radLabel1
			' 
			Me.radLabel1.BackColor = System.Drawing.Color.Transparent
			Me.radLabel1.Font = New System.Drawing.Font("Arial", 14F)
			Me.radLabel1.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(193))))), (CInt(Fix((CByte(77))))), (CInt(Fix((CByte(0))))))
			Me.radLabel1.Location = New System.Drawing.Point(16, 3)
			Me.radLabel1.Name = "radLabel1"
			' 
			' 
			' 
			Me.radLabel1.RootElement.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(193))))), (CInt(Fix((CByte(77))))), (CInt(Fix((CByte(0))))))
			Me.radLabel1.Size = New System.Drawing.Size(181, 26)
			Me.radLabel1.TabIndex = 1
			Me.radLabel1.Text = "Choose Chart Type:"
			' 
			' roundRectShape1
			' 
			Me.roundRectShape1.BottomLeftRounded = True
			Me.roundRectShape1.BottomRightRounded = True
			Me.roundRectShape1.TopLeftRounded = True
			Me.roundRectShape1.TopRightRounded = True
			' 
			' radLabel2
			' 
			Me.radLabel2.BackColor = System.Drawing.Color.Transparent
			Me.radLabel2.Font = New System.Drawing.Font("Arial", 14F)
			Me.radLabel2.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(193))))), (CInt(Fix((CByte(77))))), (CInt(Fix((CByte(0))))))
			Me.radLabel2.Location = New System.Drawing.Point(261, 8)
			Me.radLabel2.Name = "radLabel2"
			' 
			' 
			' 
			Me.radLabel2.RootElement.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(193))))), (CInt(Fix((CByte(77))))), (CInt(Fix((CByte(0))))))
			Me.radLabel2.Size = New System.Drawing.Size(82, 26)
			Me.radLabel2.TabIndex = 2
			Me.radLabel2.Text = "Preview:"
			' 
			' pictureBox2
			' 
			Me.pictureBox2.Image = My.Resources.separator
			Me.pictureBox2.Location = New System.Drawing.Point(259, 33)
			Me.pictureBox2.Name = "pictureBox2"
			Me.pictureBox2.Size = New System.Drawing.Size(440, 6)
			Me.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.pictureBox2.TabIndex = 6
			Me.pictureBox2.TabStop = False
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.pictureBox2)
			Me.Controls.Add(Me.radLabel2)
			Me.Controls.Add(Me.panel)
			Me.Controls.Add(Me.radChart1)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(1001, 753)
			CType(Me.radChart1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			Me.panel.PerformLayout()
			CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton7, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private radChart1 As Telerik.WinControls.UI.RadChart
		Private WithEvents radButton1 As Telerik.WinControls.UI.RadButton
		Private imageList1 As System.Windows.Forms.ImageList
		Private panel As RadCustomPanel
		Private WithEvents radButton3 As Telerik.WinControls.UI.RadButton
		Private WithEvents radButton4 As Telerik.WinControls.UI.RadButton
		Private WithEvents radButton5 As Telerik.WinControls.UI.RadButton
		Private WithEvents radButton7 As Telerik.WinControls.UI.RadButton
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
		Private roundRectShape1 As Telerik.WinControls.RoundRectShape
		Private trackBarUThumbShape1 As Telerik.WinControls.UI.TrackBarUThumbShape
		Private pictureBox1 As System.Windows.Forms.PictureBox
		Private radLabel2 As Telerik.WinControls.UI.RadLabel
		Private pictureBox2 As System.Windows.Forms.PictureBox
	End Class
End Namespace