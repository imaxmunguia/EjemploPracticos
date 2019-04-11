namespace Telerik.Examples.WinControls.Chart.ChartTypes.StackedBar100
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
            Telerik.Charting.Styles.ChartMargins chartMargins1 = new Telerik.Charting.Styles.ChartMargins();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Telerik.Charting.Styles.ChartMargins chartMargins2 = new Telerik.Charting.Styles.ChartMargins();
            Telerik.Charting.Styles.ChartPaddings chartPaddings1 = new Telerik.Charting.Styles.ChartPaddings();
            Telerik.Charting.Styles.ChartMargins chartMargins3 = new Telerik.Charting.Styles.ChartMargins();
            Telerik.Charting.ChartSeries chartSeries1 = new Telerik.Charting.ChartSeries();
            Telerik.Charting.ChartSeries chartSeries2 = new Telerik.Charting.ChartSeries();
#pragma warning disable 618
            this.radChart1 = new Telerik.WinControls.UI.RadChart();
            ((System.ComponentModel.ISupportInitialize)(this.radChart1)).BeginInit();
            this.SuspendLayout();
            // 
            // radChart1
            // 
            this.radChart1.Appearance.Border.Color = System.Drawing.Color.Silver;
            this.radChart1.Appearance.FillStyle.FillSettings.GradientMode = Telerik.Charting.Styles.GradientFillStyle.Center;
            this.radChart1.Appearance.FillStyle.FillType = Telerik.Charting.Styles.FillType.Gradient;
            this.radChart1.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(192)))), ((int)(((byte)(247)))));
            this.radChart1.Appearance.FillStyle.SecondColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(120)))), ((int)(((byte)(176)))));
            this.radChart1.ChartTitle.Appearance.Border.Width = 0F;
            chartMargins1.Bottom = ((Telerik.Charting.Styles.Unit)(resources.GetObject("chartMargins1.Bottom")));
            chartMargins1.Left = ((Telerik.Charting.Styles.Unit)(resources.GetObject("chartMargins1.Left")));
            chartMargins1.Right = ((Telerik.Charting.Styles.Unit)(resources.GetObject("chartMargins1.Right")));
            chartMargins1.Top = ((Telerik.Charting.Styles.Unit)(resources.GetObject("chartMargins1.Top")));
            this.radChart1.ChartTitle.Appearance.Dimensions.Margins = chartMargins1;
            this.radChart1.ChartTitle.Appearance.FillStyle.MainColor = System.Drawing.Color.Transparent;
            this.radChart1.ChartTitle.TextBlock.Appearance.TextProperties.Color = System.Drawing.Color.White;
            this.radChart1.ChartTitle.TextBlock.Appearance.TextProperties.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.radChart1.ChartTitle.TextBlock.Text = "Stacked Bar 100";
            this.radChart1.DefaultType = Telerik.Charting.ChartSeriesType.StackedBar100;
            this.radChart1.Legend.Appearance.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(164)))), ((int)(((byte)(205)))));
            chartMargins2.Right = ((Telerik.Charting.Styles.Unit)(resources.GetObject("chartMargins2.Right")));
            chartMargins2.Top = ((Telerik.Charting.Styles.Unit)(resources.GetObject("chartMargins2.Top")));
            this.radChart1.Legend.Appearance.Dimensions.Margins = chartMargins2;
            chartPaddings1.Bottom = ((Telerik.Charting.Styles.Unit)(resources.GetObject("chartPaddings1.Bottom")));
            chartPaddings1.Left = ((Telerik.Charting.Styles.Unit)(resources.GetObject("chartPaddings1.Left")));
            chartPaddings1.Right = ((Telerik.Charting.Styles.Unit)(resources.GetObject("chartPaddings1.Right")));
            chartPaddings1.Top = ((Telerik.Charting.Styles.Unit)(resources.GetObject("chartPaddings1.Top")));
            this.radChart1.Legend.Appearance.Dimensions.Paddings = chartPaddings1;
            this.radChart1.Legend.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radChart1.Legend.Appearance.ItemTextAppearance.TextProperties.Color = System.Drawing.Color.White;
            this.radChart1.Legend.Appearance.ItemTextAppearance.TextProperties.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.radChart1.Location = new System.Drawing.Point(12, 12);
            this.radChart1.Name = "radChart1";
            this.radChart1.PlotArea.Appearance.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            chartMargins3.Bottom = ((Telerik.Charting.Styles.Unit)(resources.GetObject("chartMargins3.Bottom")));
            chartMargins3.Left = ((Telerik.Charting.Styles.Unit)(resources.GetObject("chartMargins3.Left")));
            chartMargins3.Right = ((Telerik.Charting.Styles.Unit)(resources.GetObject("chartMargins3.Right")));
            chartMargins3.Top = ((Telerik.Charting.Styles.Unit)(resources.GetObject("chartMargins3.Top")));
            this.radChart1.PlotArea.Appearance.Dimensions.Margins = chartMargins3;
            this.radChart1.PlotArea.Appearance.FillStyle.FillType = Telerik.Charting.Styles.FillType.Solid;
            this.radChart1.PlotArea.Appearance.FillStyle.MainColor = System.Drawing.Color.Transparent;
            this.radChart1.PlotArea.Appearance.FillStyle.SecondColor = System.Drawing.Color.White;
            this.radChart1.PlotArea.XAxis.Appearance.Color = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radChart1.PlotArea.XAxis.Appearance.MajorGridLines.Color = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radChart1.PlotArea.XAxis.Appearance.MajorTick.Color = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radChart1.PlotArea.XAxis.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.White;
            this.radChart1.PlotArea.XAxis.Appearance.TextAppearance.TextProperties.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.radChart1.PlotArea.XAxis.AxisLabel.TextBlock.Appearance.TextProperties.Color = System.Drawing.Color.White;
            this.radChart1.PlotArea.XAxis.MinValue = 1;
            this.radChart1.PlotArea.YAxis.Appearance.Color = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radChart1.PlotArea.YAxis.Appearance.MajorGridLines.Color = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radChart1.PlotArea.YAxis.Appearance.MajorTick.Color = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radChart1.PlotArea.YAxis.Appearance.MinorGridLines.Color = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radChart1.PlotArea.YAxis.Appearance.MinorTick.Color = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radChart1.PlotArea.YAxis.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.White;
            this.radChart1.PlotArea.YAxis.Appearance.TextAppearance.TextProperties.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.radChart1.PlotArea.YAxis.MaxValue = 100;
            this.radChart1.PlotArea.YAxis.Step = 10;
            this.radChart1.PlotArea.YAxis2.Appearance.Color = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radChart1.PlotArea.YAxis2.Appearance.MajorGridLines.Color = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radChart1.PlotArea.YAxis2.Appearance.MajorTick.Color = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radChart1.PlotArea.YAxis2.Appearance.MinorGridLines.Color = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radChart1.PlotArea.YAxis2.Appearance.MinorTick.Color = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radChart1.PlotArea.YAxis2.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.White;
            this.radChart1.PlotArea.YAxis2.Appearance.TextAppearance.TextProperties.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            chartSeries1.Appearance.Border.Color = System.Drawing.Color.Empty;
            chartSeries1.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            chartSeries1.Appearance.FillStyle.SecondColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(217)))), ((int)(((byte)(238)))));
            chartSeries1.Appearance.PointMark.FillStyle.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            chartSeries1.Appearance.PointMark.FillStyle.SecondColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(217)))), ((int)(((byte)(238)))));
            chartSeries1.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.White;
            chartSeries1.Appearance.TextAppearance.TextProperties.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            chartSeries1.Name = "Series 1";
            chartSeries1.Type = Telerik.Charting.ChartSeriesType.StackedBar100;
            chartSeries2.Appearance.Border.Color = System.Drawing.Color.Empty;
            chartSeries2.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(221)))), ((int)(((byte)(246)))));
            chartSeries2.Appearance.FillStyle.SecondColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(161)))), ((int)(((byte)(197)))));
            chartSeries2.Appearance.PointMark.FillStyle.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(221)))), ((int)(((byte)(246)))));
            chartSeries2.Appearance.PointMark.FillStyle.SecondColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(161)))), ((int)(((byte)(197)))));
            chartSeries2.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.White;
            chartSeries2.Appearance.TextAppearance.TextProperties.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            chartSeries2.Name = "Series 2";
            chartSeries2.Type = Telerik.Charting.ChartSeriesType.StackedBar100;
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