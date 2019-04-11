namespace Telerik.Examples.WinControls.Chart.CandlestickCharts
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
            Telerik.Charting.ChartSeries chartSeries1 = new Telerik.Charting.ChartSeries();
            Telerik.Charting.ChartSeriesItem chartSeriesItem1 = new Telerik.Charting.ChartSeriesItem();
            Telerik.Charting.ChartSeriesItem chartSeriesItem2 = new Telerik.Charting.ChartSeriesItem();
            Telerik.Charting.ChartSeriesItem chartSeriesItem3 = new Telerik.Charting.ChartSeriesItem();
            Telerik.Charting.ChartSeriesItem chartSeriesItem4 = new Telerik.Charting.ChartSeriesItem();
            Telerik.Charting.ChartSeriesItem chartSeriesItem5 = new Telerik.Charting.ChartSeriesItem();
#pragma warning disable 618
            this.radChart1 = new Telerik.WinControls.UI.RadChart();
            ((System.ComponentModel.ISupportInitialize)(this.radChart1)).BeginInit();
            this.SuspendLayout();
            // 
            // radChart1
            // 
            this.radChart1.Appearance.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(171)))), ((int)(((byte)(184)))));
            this.radChart1.Appearance.FillStyle.FillType = Telerik.Charting.Styles.FillType.Hatch;
            this.radChart1.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(235)))), ((int)(((byte)(239)))));
            this.radChart1.Appearance.FillStyle.SecondColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.radChart1.ChartTitle.Appearance.Border.Visible = false;
            this.radChart1.ChartTitle.Appearance.FillStyle.MainColor = System.Drawing.Color.Empty;
            this.radChart1.ChartTitle.TextBlock.Appearance.TextProperties.Color = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(103)))), ((int)(((byte)(114)))));
            this.radChart1.ChartTitle.TextBlock.Appearance.TextProperties.Font = new System.Drawing.Font("Arial", 21.75F);
            this.radChart1.ChartTitle.TextBlock.Text = "Candlestick Chart";
            this.radChart1.DefaultType = Telerik.Charting.ChartSeriesType.CandleStick;
            this.radChart1.Legend.Appearance.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(214)))), ((int)(((byte)(221)))));
            this.radChart1.Legend.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.radChart1.Location = new System.Drawing.Point(12, 12);
            this.radChart1.Name = "radChart1";
            this.radChart1.PlotArea.Appearance.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(214)))), ((int)(((byte)(221)))));
            chartMargins1.Bottom = ((Telerik.Charting.Styles.Unit)(resources.GetObject("chartMargins1.Bottom")));
            chartMargins1.Left = ((Telerik.Charting.Styles.Unit)(resources.GetObject("chartMargins1.Left")));
            chartMargins1.Right = ((Telerik.Charting.Styles.Unit)(resources.GetObject("chartMargins1.Right")));
            chartMargins1.Top = ((Telerik.Charting.Styles.Unit)(resources.GetObject("chartMargins1.Top")));
            this.radChart1.PlotArea.Appearance.Dimensions.Margins = chartMargins1;
            this.radChart1.PlotArea.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.radChart1.PlotArea.XAxis.Appearance.Color = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(214)))), ((int)(((byte)(221)))));
            this.radChart1.PlotArea.XAxis.Appearance.MajorGridLines.Color = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(232)))), ((int)(((byte)(227)))));
            this.radChart1.PlotArea.XAxis.Appearance.MajorGridLines.PenStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.radChart1.PlotArea.XAxis.Appearance.MajorTick.Color = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(129)))));
            this.radChart1.PlotArea.XAxis.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(78)))));
            this.radChart1.PlotArea.XAxis.LayoutMode = Telerik.Charting.Styles.ChartAxisLayoutMode.Inside;
            this.radChart1.PlotArea.XAxis.MaxValue = 5;
            this.radChart1.PlotArea.XAxis.MinValue = 1;
            this.radChart1.PlotArea.YAxis.Appearance.Color = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(214)))), ((int)(((byte)(221)))));
            this.radChart1.PlotArea.YAxis.Appearance.MajorGridLines.Color = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(232)))), ((int)(((byte)(227)))));
            this.radChart1.PlotArea.YAxis.Appearance.MajorGridLines.PenStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.radChart1.PlotArea.YAxis.Appearance.MajorTick.Color = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(129)))));
            this.radChart1.PlotArea.YAxis.Appearance.MinorGridLines.Color = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(232)))), ((int)(((byte)(227)))));
            this.radChart1.PlotArea.YAxis.Appearance.MinorGridLines.Visible = false;
            this.radChart1.PlotArea.YAxis.Appearance.MinorTick.Color = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(129)))));
            this.radChart1.PlotArea.YAxis.Appearance.MinorTick.Visible = false;
            this.radChart1.PlotArea.YAxis.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(78)))));
            this.radChart1.PlotArea.YAxis.MaxValue = 80;
            this.radChart1.PlotArea.YAxis2.MaxValue = 5;
            this.radChart1.PlotArea.YAxis2.MinValue = 1;
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
            this.radChart1.Series.AddRange(new Telerik.Charting.ChartSeries[] {
            chartSeries1});
            this.radChart1.Size = new System.Drawing.Size(400, 300);
            this.radChart1.Skin = "Apple";
            this.radChart1.SkinsOverrideStyles = true;
            this.radChart1.TabIndex = 0;
            // 
            // Form1
            // 
 
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

