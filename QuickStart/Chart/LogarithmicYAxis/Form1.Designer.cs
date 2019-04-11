namespace Telerik.Examples.WinControls.Chart.LogarithmicYAxis
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
            Telerik.Charting.Styles.Corners corners1 = new Telerik.Charting.Styles.Corners();
            Telerik.Charting.Styles.ChartMargins chartMargins1 = new Telerik.Charting.Styles.ChartMargins();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Telerik.Charting.Styles.ChartMargins chartMargins2 = new Telerik.Charting.Styles.ChartMargins();
            Telerik.Charting.ChartSeries chartSeries1 = new Telerik.Charting.ChartSeries();
            Telerik.Charting.ChartSeriesItem chartSeriesItem1 = new Telerik.Charting.ChartSeriesItem();
            Telerik.Charting.ChartSeriesItem chartSeriesItem2 = new Telerik.Charting.ChartSeriesItem();
            Telerik.Charting.ChartSeriesItem chartSeriesItem3 = new Telerik.Charting.ChartSeriesItem();
            Telerik.Charting.ChartSeriesItem chartSeriesItem4 = new Telerik.Charting.ChartSeriesItem();
            Telerik.Charting.ChartSeriesItem chartSeriesItem5 = new Telerik.Charting.ChartSeriesItem();
            Telerik.Charting.ChartSeries chartSeries2 = new Telerik.Charting.ChartSeries();
            Telerik.Charting.ChartSeriesItem chartSeriesItem6 = new Telerik.Charting.ChartSeriesItem();
            Telerik.Charting.ChartSeriesItem chartSeriesItem7 = new Telerik.Charting.ChartSeriesItem();
            Telerik.Charting.ChartSeriesItem chartSeriesItem8 = new Telerik.Charting.ChartSeriesItem();
            Telerik.Charting.ChartSeriesItem chartSeriesItem9 = new Telerik.Charting.ChartSeriesItem();
            Telerik.Charting.ChartSeriesItem chartSeriesItem10 = new Telerik.Charting.ChartSeriesItem();
#pragma warning disable 618
            this.radChart1 = new Telerik.WinControls.UI.RadChart();
            ((System.ComponentModel.ISupportInitialize)(this.radChart1)).BeginInit();
            this.SuspendLayout();
            // 
            // radChart1
            // 
            this.radChart1.Appearance.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(249)))));
            this.radChart1.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.radChart1.AutoLayout = true;
            this.radChart1.ChartTitle.Appearance.Border.Visible = false;
            this.radChart1.ChartTitle.Appearance.FillStyle.MainColor = System.Drawing.Color.Empty;
            this.radChart1.ChartTitle.Appearance.Position.AlignedPosition = Telerik.Charting.Styles.AlignedPositions.Top;
            this.radChart1.ChartTitle.TextBlock.Appearance.TextProperties.Color = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(143)))), ((int)(((byte)(190)))));
            this.radChart1.ChartTitle.TextBlock.Text = "Logarithmic Y-Axis";
            this.radChart1.Legend.Appearance.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            corners1.BottomLeft = Telerik.Charting.Styles.CornerType.Round;
            corners1.BottomRight = Telerik.Charting.Styles.CornerType.Round;
            corners1.RoundSize = 6;
            corners1.TopLeft = Telerik.Charting.Styles.CornerType.Round;
            corners1.TopRight = Telerik.Charting.Styles.CornerType.Round;
            this.radChart1.Legend.Appearance.Corners = corners1;
            chartMargins1.Right = ((Telerik.Charting.Styles.Unit)(resources.GetObject("chartMargins1.Right")));
            chartMargins1.Top = ((Telerik.Charting.Styles.Unit)(resources.GetObject("chartMargins1.Top")));
            this.radChart1.Legend.Appearance.Dimensions.Margins = chartMargins1;
            this.radChart1.Legend.Appearance.ItemTextAppearance.TextProperties.Color = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(117)))), ((int)(((byte)(154)))));
            this.radChart1.Legend.Appearance.Visible = false;
            this.radChart1.Legend.Visible = false;
            this.radChart1.Location = new System.Drawing.Point(12, 12);
            this.radChart1.Name = "radChart1";
            this.radChart1.PlotArea.Appearance.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            chartMargins2.Bottom = ((Telerik.Charting.Styles.Unit)(resources.GetObject("chartMargins2.Bottom")));
            chartMargins2.Left = ((Telerik.Charting.Styles.Unit)(resources.GetObject("chartMargins2.Left")));
            chartMargins2.Right = ((Telerik.Charting.Styles.Unit)(resources.GetObject("chartMargins2.Right")));
            chartMargins2.Top = ((Telerik.Charting.Styles.Unit)(resources.GetObject("chartMargins2.Top")));
            this.radChart1.PlotArea.Appearance.Dimensions.Margins = chartMargins2;
            this.radChart1.PlotArea.Appearance.FillStyle.FillType = Telerik.Charting.Styles.FillType.Solid;
            this.radChart1.PlotArea.Appearance.FillStyle.MainColor = System.Drawing.Color.White;
            this.radChart1.PlotArea.Appearance.FillStyle.SecondColor = System.Drawing.Color.White;
            this.radChart1.PlotArea.XAxis.Appearance.Color = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.radChart1.PlotArea.XAxis.Appearance.MajorGridLines.Color = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(187)))), ((int)(((byte)(207)))));
            this.radChart1.PlotArea.XAxis.Appearance.MajorTick.Color = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.radChart1.PlotArea.XAxis.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(117)))), ((int)(((byte)(154)))));
            this.radChart1.PlotArea.XAxis.LayoutMode = Telerik.Charting.Styles.ChartAxisLayoutMode.Inside;
            this.radChart1.PlotArea.XAxis.MaxValue = 5;
            this.radChart1.PlotArea.XAxis.MinValue = 1;
            this.radChart1.PlotArea.YAxis.Appearance.Color = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.radChart1.PlotArea.YAxis.Appearance.MajorGridLines.Color = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(187)))), ((int)(((byte)(207)))));
            this.radChart1.PlotArea.YAxis.Appearance.MajorGridLines.PenStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.radChart1.PlotArea.YAxis.Appearance.MajorTick.Color = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.radChart1.PlotArea.YAxis.Appearance.MinorGridLines.Color = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(187)))), ((int)(((byte)(207)))));
            this.radChart1.PlotArea.YAxis.Appearance.MinorGridLines.Visible = false;
            this.radChart1.PlotArea.YAxis.Appearance.MinorTick.Color = System.Drawing.Color.Silver;
            this.radChart1.PlotArea.YAxis.Appearance.MinorTick.Visible = false;
            this.radChart1.PlotArea.YAxis.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(117)))), ((int)(((byte)(154)))));
            this.radChart1.PlotArea.YAxis.MaxValue = 100;
            this.radChart1.PlotArea.YAxis.Step = 10;
            chartSeries1.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(124)))), ((int)(((byte)(160)))));
            chartSeriesItem1.YValue = 73;
            chartSeriesItem1.YValue2 = 52;
            chartSeriesItem2.YValue = 23;
            chartSeriesItem2.YValue2 = 76;
            chartSeriesItem3.YValue = 22;
            chartSeriesItem3.YValue2 = 25;
            chartSeriesItem4.YValue = 24;
            chartSeriesItem4.YValue2 = 93;
            chartSeriesItem5.YValue = 75;
            chartSeriesItem5.YValue2 = 55;
            chartSeries1.Items.AddRange(new Telerik.Charting.ChartSeriesItem[] {
            chartSeriesItem1,
            chartSeriesItem2,
            chartSeriesItem3,
            chartSeriesItem4,
            chartSeriesItem5});
            chartSeries1.Name = "Product A";
            chartSeries1.Type = Telerik.Charting.ChartSeriesType.SplineArea;
            chartSeries2.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(124)))), ((int)(((byte)(160)))));
            chartSeriesItem6.YValue = 6;
            chartSeriesItem6.YValue2 = 53;
            chartSeriesItem7.YValue = 24;
            chartSeriesItem7.YValue2 = 22;
            chartSeriesItem8.YValue = 51;
            chartSeriesItem8.YValue2 = 78;
            chartSeriesItem9.YValue = 95;
            chartSeriesItem9.YValue2 = 10;
            chartSeriesItem10.YValue = 18;
            chartSeriesItem10.YValue2 = 60;
            chartSeries2.Items.AddRange(new Telerik.Charting.ChartSeriesItem[] {
            chartSeriesItem6,
            chartSeriesItem7,
            chartSeriesItem8,
            chartSeriesItem9,
            chartSeriesItem10});
            chartSeries2.Name = "Product B";
            chartSeries2.Type = Telerik.Charting.ChartSeriesType.SplineArea;
            this.radChart1.Series.AddRange(new Telerik.Charting.ChartSeries[] {
            chartSeries1,
            chartSeries2});
            this.radChart1.Size = new System.Drawing.Size(400, 300);
            this.radChart1.Skin = "Apple";
            this.radChart1.SkinsOverrideStyles = true;
            this.radChart1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radChart1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1230, 606);
            ((System.ComponentModel.ISupportInitialize)(this.radChart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadChart radChart1;
    }
}

