using Telerik.QuickStart.WinControls;

namespace Telerik.Examples.WinControls.Chart.FirstLook
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
            if (!radChart1.IsDisposed)
            {
                radChart1.Dispose();
            }
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            Telerik.Charting.Styles.ChartMargins chartMargins1 = new Telerik.Charting.Styles.ChartMargins();
            Telerik.Charting.Styles.Unit unit1 = new Telerik.Charting.Styles.Unit();
            Telerik.Charting.Styles.Unit unit2 = new Telerik.Charting.Styles.Unit();
            Telerik.Charting.Styles.Unit unit3 = new Telerik.Charting.Styles.Unit();
            Telerik.Charting.Styles.Unit unit4 = new Telerik.Charting.Styles.Unit();
            Telerik.Charting.Styles.ChartMargins chartMargins2 = new Telerik.Charting.Styles.ChartMargins();
            Telerik.Charting.Styles.Unit unit5 = new Telerik.Charting.Styles.Unit();
            Telerik.Charting.Styles.Corners corners1 = new Telerik.Charting.Styles.Corners();
            Telerik.Charting.Styles.ChartMargins chartMargins3 = new Telerik.Charting.Styles.ChartMargins();
            Telerik.Charting.Styles.Unit unit6 = new Telerik.Charting.Styles.Unit();
            Telerik.Charting.Styles.Unit unit7 = new Telerik.Charting.Styles.Unit();
            Telerik.Charting.Styles.Unit unit8 = new Telerik.Charting.Styles.Unit();
            Telerik.Charting.Styles.Unit unit9 = new Telerik.Charting.Styles.Unit();
            Telerik.Charting.ChartSeries chartSeries1 = new Telerik.Charting.ChartSeries();
            Telerik.Charting.ChartSeries chartSeries2 = new Telerik.Charting.ChartSeries();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
#pragma warning disable 618
            this.radChart1 = new Telerik.WinControls.UI.RadChart();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel = new Telerik.QuickStart.WinControls.RadCustomPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radButton7 = new Telerik.WinControls.UI.RadButton();
            this.radButton5 = new Telerik.WinControls.UI.RadButton();
            this.radButton3 = new Telerik.WinControls.UI.RadButton();
            this.radButton4 = new Telerik.WinControls.UI.RadButton();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.roundRectShape1 = new Telerik.WinControls.RoundRectShape();
            this.trackBarUThumbShape1 = new Telerik.WinControls.UI.TrackBarUThumbShape();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.radChart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // radChart1
            // 
            this.radChart1.Appearance.Border.Color = System.Drawing.Color.Silver;
            this.radChart1.Appearance.FillStyle.MainColor = System.Drawing.Color.WhiteSmoke;
            this.radChart1.ChartTitle.Appearance.Border.Width = 1F;
            unit1.Value = 14F;
            chartMargins1.Bottom = unit1;
            unit2.Value = 10F;
            chartMargins1.Left = unit2;
            unit3.Value = 10F;
            chartMargins1.Right = unit3;
            unit4.Value = 14F;
            chartMargins1.Top = unit4;
            this.radChart1.ChartTitle.Appearance.Dimensions.Margins = chartMargins1;
            this.radChart1.ChartTitle.Appearance.Position.AlignedPosition = Telerik.Charting.Styles.AlignedPositions.Top;
            this.radChart1.ChartTitle.TextBlock.Appearance.TextProperties.Color = System.Drawing.Color.Gray;
            this.radChart1.ChartTitle.TextBlock.Text = "Secondary Y-Axis";
            this.radChart1.Legend.Appearance.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            unit5.Value = 15F;
            chartMargins2.Right = unit5;
            this.radChart1.Legend.Appearance.Dimensions.Margins = chartMargins2;
            this.radChart1.Legend.Appearance.ItemTextAppearance.TextProperties.Font = new System.Drawing.Font("Arial", 9.75F);
            this.radChart1.Location = new System.Drawing.Point(263, 47);
            this.radChart1.Name = "radChart1";
            this.radChart1.PlotArea.Appearance.Border.Color = System.Drawing.Color.Silver;
            corners1.BottomLeft = Telerik.Charting.Styles.CornerType.Round;
            corners1.BottomRight = Telerik.Charting.Styles.CornerType.Round;
            corners1.RoundSize = 6;
            corners1.TopLeft = Telerik.Charting.Styles.CornerType.Round;
            corners1.TopRight = Telerik.Charting.Styles.CornerType.Round;
            this.radChart1.PlotArea.Appearance.Corners = corners1;
            unit6.Value = 35F;
            chartMargins3.Bottom = unit6;
            unit7.Value = 35F;
            chartMargins3.Left = unit7;
            unit8.Value = 100F;
            chartMargins3.Right = unit8;
            unit9.Value = 50F;
            chartMargins3.Top = unit9;
            this.radChart1.PlotArea.Appearance.Dimensions.Margins = chartMargins3;
            this.radChart1.PlotArea.Appearance.FillStyle.FillType = Telerik.Charting.Styles.FillType.Solid;
            this.radChart1.PlotArea.Appearance.FillStyle.MainColor = System.Drawing.Color.White;
            this.radChart1.PlotArea.Appearance.FillStyle.SecondColor = System.Drawing.Color.White;
            this.radChart1.PlotArea.XAxis.Appearance.Color = System.Drawing.Color.Silver;
            this.radChart1.PlotArea.XAxis.Appearance.MajorGridLines.Color = System.Drawing.Color.Silver;
            this.radChart1.PlotArea.XAxis.Appearance.MajorTick.Color = System.Drawing.Color.Silver;
            this.radChart1.PlotArea.XAxis.AxisLabel.TextBlock.Appearance.TextProperties.Font = new System.Drawing.Font("Arial", 10F);
            this.radChart1.PlotArea.XAxis.MinValue = 1;
            this.radChart1.PlotArea.YAxis.Appearance.Color = System.Drawing.Color.Silver;
            this.radChart1.PlotArea.YAxis.Appearance.MajorGridLines.Color = System.Drawing.Color.Silver;
            this.radChart1.PlotArea.YAxis.Appearance.MajorTick.Color = System.Drawing.Color.Silver;
            this.radChart1.PlotArea.YAxis.Appearance.MinorGridLines.Color = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.radChart1.PlotArea.YAxis.Appearance.MinorTick.Color = System.Drawing.Color.Silver;
            this.radChart1.PlotArea.YAxis.AxisLabel.TextBlock.Appearance.TextProperties.Font = new System.Drawing.Font("Arial", 10F);
            this.radChart1.PlotArea.YAxis.MaxValue = 90;
            this.radChart1.PlotArea.YAxis.Step = 10;
            this.radChart1.PlotArea.YAxis2.AxisLabel.TextBlock.Appearance.TextProperties.Font = new System.Drawing.Font("Arial", 10F);
            this.radChart1.PlotArea.YAxis2.MaxValue = 100;
            this.radChart1.PlotArea.YAxis2.Step = 10;
            chartSeries1.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(206)))), ((int)(((byte)(38)))));
            chartSeries1.Appearance.FillStyle.SecondColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(221)))));
            chartSeries1.Appearance.PointMark.FillStyle.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(206)))), ((int)(((byte)(38)))));
            chartSeries1.Appearance.PointMark.FillStyle.SecondColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(221)))));
            chartSeries1.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.Black;
            chartSeries1.Appearance.TextAppearance.TextProperties.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartSeries1.Name = "Series 1";
            chartSeries1.Type = Telerik.Charting.ChartSeriesType.Area;
            chartSeries2.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            chartSeries2.Appearance.FillStyle.SecondColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            chartSeries2.Appearance.PointMark.FillStyle.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            chartSeries2.Appearance.PointMark.FillStyle.SecondColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            chartSeries2.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.Black;
            chartSeries2.Appearance.TextAppearance.TextProperties.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartSeries2.Name = "Series 2";
            chartSeries2.Type = Telerik.Charting.ChartSeriesType.Area;
            chartSeries2.YAxisType = Telerik.Charting.ChartYAxisType.Secondary;
            this.radChart1.Series.AddRange(new Telerik.Charting.ChartSeries[] {
            chartSeries1,
            chartSeries2});
            this.radChart1.Size = new System.Drawing.Size(400, 300);
            this.radChart1.Skin = "Apple";
            this.radChart1.SkinsOverrideStyles = true;
            this.radChart1.TabIndex = 0;
            // 
            // radButton1
            // 
            this.radButton1.BackColor = System.Drawing.Color.Transparent;
            this.radButton1.Font = new System.Drawing.Font("Arial", 14F);
            this.radButton1.ForeColor = System.Drawing.Color.Black;
            this.radButton1.ImageList = this.imageList1;
            this.radButton1.ImageScalingSize = new System.Drawing.Size(64, 64);
            this.radButton1.Location = new System.Drawing.Point(12, 33);
            this.radButton1.Name = "radButton1";
            // 
            // 
            // 
            this.radButton1.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radButton1.Size = new System.Drawing.Size(227, 88);
            this.radButton1.TabIndex = 1;
            this.radButton1.Text = "Pie";
            this.radButton1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton1.GetChildAt(0))).Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton1.GetChildAt(0))).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton1.GetChildAt(0))).TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton1.GetChildAt(0))).Text = "Pie";
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton1.GetChildAt(0))).Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButton1.GetChildAt(0).GetChildAt(0))).NumberOfColors = 1;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButton1.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Layouts.ImageAndTextLayoutPanel)(this.radButton1.GetChildAt(0).GetChildAt(1))).Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radButton1.GetChildAt(0).GetChildAt(1).GetChildAt(1))).StretchHorizontally = true;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radButton1.GetChildAt(0).GetChildAt(1).GetChildAt(1))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(83)))), ((int)(((byte)(62)))));
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radButton1.GetChildAt(0).GetChildAt(1).GetChildAt(1))).Font = new System.Drawing.Font("Arial", 14F);
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radButton1.GetChildAt(0).GetChildAt(1).GetChildAt(1))).Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radButton1.GetChildAt(0).GetChildAt(1).GetChildAt(1))).Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radButton1.GetChildAt(0).GetChildAt(2))).ForeColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radButton1.GetChildAt(0).GetChildAt(2))).BackColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radButton1.GetChildAt(0).GetChildAt(2))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Bubble.png");
            this.imageList1.Images.SetKeyName(1, "Candlestick.png");
            this.imageList1.Images.SetKeyName(2, "Gant.png");
            this.imageList1.Images.SetKeyName(3, "Pie.png");
            this.imageList1.Images.SetKeyName(4, "SplineArea.png");
            this.imageList1.Images.SetKeyName(5, "SplineLine.png");
            this.imageList1.Images.SetKeyName(6, "StackedArea100.png");
            this.imageList1.Images.SetKeyName(7, "StackedArea.png");
            this.imageList1.Images.SetKeyName(8, "StackedBar100.png");
            this.imageList1.Images.SetKeyName(9, "StackedSplineArea100.png");
            this.imageList1.Images.SetKeyName(10, "StackedSplineArea.png");
            this.imageList1.Images.SetKeyName(11, "StakedBar.png");
            this.imageList1.Images.SetKeyName(12, "Area.png");
            this.imageList1.Images.SetKeyName(13, "Bar.png");
            this.imageList1.Images.SetKeyName(14, "Line.png");
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(242)))), ((int)(((byte)(217)))));
            this.panel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.panel.Controls.Add(this.pictureBox1);
            this.panel.Controls.Add(this.radButton7);
            this.panel.Controls.Add(this.radButton5);
            this.panel.Controls.Add(this.radButton3);
            this.panel.Controls.Add(this.radButton4);
            this.panel.Controls.Add(this.radButton1);
            this.panel.Controls.Add(this.radLabel1);
            this.panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.panel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(111)))), ((int)(((byte)(61)))));
            this.panel.LineBounds = new System.Drawing.Rectangle(10, 30, 240, 30);
            this.panel.Location = new System.Drawing.Point(5, 5);
            this.panel.Name = "panel";
            // 
            // 
            // 
            this.panel.RootElement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(111)))), ((int)(((byte)(61)))));
            this.panel.Size = new System.Drawing.Size(250, 495);
            this.panel.TabIndex = 0;
            this.panel.ThemeName = "Examples";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.panel.GetChildAt(0).GetChildAt(0))).ForeColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.panel.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(242)))), ((int)(((byte)(217)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.panel.GetChildAt(0).GetChildAt(1))).GradientStyle = Telerik.WinControls.GradientStyles.Solid;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.panel.GetChildAt(0).GetChildAt(1))).ForeColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.panel.GetChildAt(0).GetChildAt(2))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.panel.GetChildAt(0).GetChildAt(2))).Font = new System.Drawing.Font("Arial", 14F);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Telerik.Examples.WinControls.Properties.Resources.separator;
            this.pictureBox1.Location = new System.Drawing.Point(16, 28);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 6);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // radButton7
            // 
            this.radButton7.BackColor = System.Drawing.Color.Transparent;
            this.radButton7.Font = new System.Drawing.Font("Arial", 14F);
            this.radButton7.ForeColor = System.Drawing.Color.Black;
            this.radButton7.ImageList = this.imageList1;
            this.radButton7.ImageScalingSize = new System.Drawing.Size(64, 64);
            this.radButton7.Location = new System.Drawing.Point(12, 306);
            this.radButton7.Name = "radButton7";
            // 
            // 
            // 
            this.radButton7.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radButton7.Size = new System.Drawing.Size(226, 88);
            this.radButton7.TabIndex = 4;
            this.radButton7.Text = "Area";
            this.radButton7.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radButton7.Click += new System.EventHandler(this.radButton7_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton7.GetChildAt(0))).Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton7.GetChildAt(0))).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton7.GetChildAt(0))).TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton7.GetChildAt(0))).Text = "Area";
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton7.GetChildAt(0))).Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButton7.GetChildAt(0).GetChildAt(0))).NumberOfColors = 1;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButton7.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Layouts.ImageAndTextLayoutPanel)(this.radButton7.GetChildAt(0).GetChildAt(1))).Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radButton7.GetChildAt(0).GetChildAt(1).GetChildAt(1))).StretchHorizontally = true;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radButton7.GetChildAt(0).GetChildAt(1).GetChildAt(1))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(83)))), ((int)(((byte)(62)))));
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radButton7.GetChildAt(0).GetChildAt(1).GetChildAt(1))).Font = new System.Drawing.Font("Arial", 14F);
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radButton7.GetChildAt(0).GetChildAt(1).GetChildAt(1))).Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radButton7.GetChildAt(0).GetChildAt(1).GetChildAt(1))).Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radButton7.GetChildAt(0).GetChildAt(2))).ForeColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radButton7.GetChildAt(0).GetChildAt(2))).BackColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radButton7.GetChildAt(0).GetChildAt(2))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // radButton5
            // 
            this.radButton5.BackColor = System.Drawing.Color.Transparent;
            this.radButton5.Font = new System.Drawing.Font("Arial", 14F);
            this.radButton5.ForeColor = System.Drawing.Color.Black;
            this.radButton5.ImageList = this.imageList1;
            this.radButton5.ImageScalingSize = new System.Drawing.Size(64, 64);
            this.radButton5.Location = new System.Drawing.Point(12, 397);
            this.radButton5.Name = "radButton5";
            // 
            // 
            // 
            this.radButton5.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radButton5.Size = new System.Drawing.Size(226, 88);
            this.radButton5.TabIndex = 5;
            this.radButton5.Text = " Line";
            this.radButton5.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radButton5.Click += new System.EventHandler(this.radButton5_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton5.GetChildAt(0))).Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton5.GetChildAt(0))).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton5.GetChildAt(0))).TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton5.GetChildAt(0))).Text = " Line";
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton5.GetChildAt(0))).Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButton5.GetChildAt(0).GetChildAt(0))).NumberOfColors = 1;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButton5.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButton5.GetChildAt(0).GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.Layouts.ImageAndTextLayoutPanel)(this.radButton5.GetChildAt(0).GetChildAt(1))).Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radButton5.GetChildAt(0).GetChildAt(1).GetChildAt(1))).StretchHorizontally = true;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radButton5.GetChildAt(0).GetChildAt(1).GetChildAt(1))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(83)))), ((int)(((byte)(62)))));
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radButton5.GetChildAt(0).GetChildAt(1).GetChildAt(1))).Font = new System.Drawing.Font("Arial", 14F);
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radButton5.GetChildAt(0).GetChildAt(1).GetChildAt(1))).Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radButton5.GetChildAt(0).GetChildAt(1).GetChildAt(1))).Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radButton5.GetChildAt(0).GetChildAt(2))).ForeColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radButton5.GetChildAt(0).GetChildAt(2))).BackColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radButton5.GetChildAt(0).GetChildAt(2))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // radButton3
            // 
            this.radButton3.BackColor = System.Drawing.Color.Transparent;
            this.radButton3.Font = new System.Drawing.Font("Arial", 14F);
            this.radButton3.ForeColor = System.Drawing.Color.Black;
            this.radButton3.ImageList = this.imageList1;
            this.radButton3.ImageScalingSize = new System.Drawing.Size(64, 64);
            this.radButton3.Location = new System.Drawing.Point(12, 214);
            this.radButton3.Name = "radButton3";
            // 
            // 
            // 
            this.radButton3.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radButton3.Size = new System.Drawing.Size(226, 88);
            this.radButton3.TabIndex = 3;
            this.radButton3.Text = "Stacked Bar";
            this.radButton3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radButton3.Click += new System.EventHandler(this.radButton3_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton3.GetChildAt(0))).Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton3.GetChildAt(0))).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton3.GetChildAt(0))).TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton3.GetChildAt(0))).Text = "Stacked Bar";
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton3.GetChildAt(0))).Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButton3.GetChildAt(0).GetChildAt(0))).NumberOfColors = 1;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButton3.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Layouts.ImageAndTextLayoutPanel)(this.radButton3.GetChildAt(0).GetChildAt(1))).Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radButton3.GetChildAt(0).GetChildAt(1).GetChildAt(1))).StretchHorizontally = true;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radButton3.GetChildAt(0).GetChildAt(1).GetChildAt(1))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(83)))), ((int)(((byte)(62)))));
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radButton3.GetChildAt(0).GetChildAt(1).GetChildAt(1))).Font = new System.Drawing.Font("Arial", 14F);
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radButton3.GetChildAt(0).GetChildAt(1).GetChildAt(1))).Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radButton3.GetChildAt(0).GetChildAt(1).GetChildAt(1))).Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radButton3.GetChildAt(0).GetChildAt(2))).ForeColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radButton3.GetChildAt(0).GetChildAt(2))).BackColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radButton3.GetChildAt(0).GetChildAt(2))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // radButton4
            // 
            this.radButton4.BackColor = System.Drawing.Color.Transparent;
            this.radButton4.Font = new System.Drawing.Font("Arial", 14F);
            this.radButton4.ForeColor = System.Drawing.Color.Black;
            this.radButton4.ImageList = this.imageList1;
            this.radButton4.ImageScalingSize = new System.Drawing.Size(64, 64);
            this.radButton4.Location = new System.Drawing.Point(12, 124);
            this.radButton4.Name = "radButton4";
            // 
            // 
            // 
            this.radButton4.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radButton4.Size = new System.Drawing.Size(226, 88);
            this.radButton4.TabIndex = 2;
            this.radButton4.Text = "Bar";
            this.radButton4.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radButton4.Click += new System.EventHandler(this.radButton4_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton4.GetChildAt(0))).Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton4.GetChildAt(0))).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton4.GetChildAt(0))).TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton4.GetChildAt(0))).Text = "Bar";
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton4.GetChildAt(0))).Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButton4.GetChildAt(0).GetChildAt(0))).NumberOfColors = 1;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButton4.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Layouts.ImageAndTextLayoutPanel)(this.radButton4.GetChildAt(0).GetChildAt(1))).Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radButton4.GetChildAt(0).GetChildAt(1).GetChildAt(1))).StretchHorizontally = true;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radButton4.GetChildAt(0).GetChildAt(1).GetChildAt(1))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(83)))), ((int)(((byte)(62)))));
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radButton4.GetChildAt(0).GetChildAt(1).GetChildAt(1))).Font = new System.Drawing.Font("Arial", 14F);
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radButton4.GetChildAt(0).GetChildAt(1).GetChildAt(1))).Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radButton4.GetChildAt(0).GetChildAt(1).GetChildAt(1))).Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radButton4.GetChildAt(0).GetChildAt(2))).ForeColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radButton4.GetChildAt(0).GetChildAt(2))).BackColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radButton4.GetChildAt(0).GetChildAt(2))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // radLabel1
            // 
            this.radLabel1.BackColor = System.Drawing.Color.Transparent;
            this.radLabel1.Font = new System.Drawing.Font("Arial", 14F);
            this.radLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(77)))), ((int)(((byte)(0)))));
            this.radLabel1.Location = new System.Drawing.Point(16, 3);
            this.radLabel1.Name = "radLabel1";
            // 
            // 
            // 
            this.radLabel1.RootElement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(77)))), ((int)(((byte)(0)))));
            this.radLabel1.Size = new System.Drawing.Size(181, 26);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "Choose Chart Type:";
            // 
            // roundRectShape1
            // 
            this.roundRectShape1.BottomLeftRounded = true;
            this.roundRectShape1.BottomRightRounded = true;
            this.roundRectShape1.TopLeftRounded = true;
            this.roundRectShape1.TopRightRounded = true;
            // 
            // radLabel2
            // 
            this.radLabel2.BackColor = System.Drawing.Color.Transparent;
            this.radLabel2.Font = new System.Drawing.Font("Arial", 14F);
            this.radLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(77)))), ((int)(((byte)(0)))));
            this.radLabel2.Location = new System.Drawing.Point(261, 8);
            this.radLabel2.Name = "radLabel2";
            // 
            // 
            // 
            this.radLabel2.RootElement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(77)))), ((int)(((byte)(0)))));
            this.radLabel2.Size = new System.Drawing.Size(82, 26);
            this.radLabel2.TabIndex = 2;
            this.radLabel2.Text = "Preview:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Telerik.Examples.WinControls.Properties.Resources.separator;
            this.pictureBox2.Location = new System.Drawing.Point(259, 33);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(440, 6);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.radChart1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1001, 753);
            ((System.ComponentModel.ISupportInitialize)(this.radChart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Telerik.WinControls.UI.RadChart radChart1;
		private Telerik.WinControls.UI.RadButton radButton1;
		private System.Windows.Forms.ImageList imageList1;
		private RadCustomPanel panel;
		private Telerik.WinControls.UI.RadButton radButton3;
		private Telerik.WinControls.UI.RadButton radButton4;
		private Telerik.WinControls.UI.RadButton radButton5;
		private Telerik.WinControls.UI.RadButton radButton7;
		private Telerik.WinControls.UI.RadLabel radLabel1;
		private Telerik.WinControls.RoundRectShape roundRectShape1;
		private Telerik.WinControls.UI.TrackBarUThumbShape trackBarUThumbShape1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private Telerik.WinControls.UI.RadLabel radLabel2;
		private System.Windows.Forms.PictureBox pictureBox2;
	}
}