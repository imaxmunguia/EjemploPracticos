namespace Telerik.Examples.WinControls.Chart.StrictMode
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
            Telerik.Charting.Styles.Corners corners2 = new Telerik.Charting.Styles.Corners();
            Telerik.Charting.Styles.ChartMargins chartMargins1 = new Telerik.Charting.Styles.ChartMargins();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Telerik.Charting.Styles.Corners corners3 = new Telerik.Charting.Styles.Corners();
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
            this.radChart1.Appearance.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.radChart1.Appearance.FillStyle.FillType = Telerik.Charting.Styles.FillType.Gradient;
            this.radChart1.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(234)))));
            this.radChart1.Appearance.FillStyle.SecondColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(172)))), ((int)(((byte)(137)))));
            this.radChart1.ChartTitle.Appearance.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            corners1.BottomLeft = Telerik.Charting.Styles.CornerType.Round;
            corners1.BottomRight = Telerik.Charting.Styles.CornerType.Round;
            corners1.TopLeft = Telerik.Charting.Styles.CornerType.Round;
            corners1.TopRight = Telerik.Charting.Styles.CornerType.Round;
            this.radChart1.ChartTitle.Appearance.Corners = corners1;
            this.radChart1.ChartTitle.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(183)))), ((int)(((byte)(144)))));
            this.radChart1.ChartTitle.Appearance.Position.AlignedPosition = Telerik.Charting.Styles.AlignedPositions.Top;
            this.radChart1.ChartTitle.TextBlock.Appearance.TextProperties.Color = System.Drawing.Color.White;
            this.radChart1.ChartTitle.TextBlock.Appearance.TextProperties.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.radChart1.ChartTitle.TextBlock.Text = "Strict Mode";
            this.radChart1.Legend.Appearance.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            corners2.BottomLeft = Telerik.Charting.Styles.CornerType.Round;
            corners2.BottomRight = Telerik.Charting.Styles.CornerType.Round;
            corners2.TopLeft = Telerik.Charting.Styles.CornerType.Round;
            corners2.TopRight = Telerik.Charting.Styles.CornerType.Round;
            this.radChart1.Legend.Appearance.Corners = corners2;
            chartMargins1.Right = ((Telerik.Charting.Styles.Unit)(resources.GetObject("chartMargins1.Right")));
            chartMargins1.Top = ((Telerik.Charting.Styles.Unit)(resources.GetObject("chartMargins1.Top")));
            this.radChart1.Legend.Appearance.Dimensions.Margins = chartMargins1;
            this.radChart1.Legend.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(183)))), ((int)(((byte)(144)))));
            this.radChart1.Legend.Appearance.ItemTextAppearance.TextProperties.Font = new System.Drawing.Font("Arial", 9.75F);
            this.radChart1.Location = new System.Drawing.Point(12, 12);
            this.radChart1.Name = "radChart1";
            this.radChart1.PlotArea.Appearance.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(93)))));
            corners3.BottomLeft = Telerik.Charting.Styles.CornerType.Round;
            corners3.BottomRight = Telerik.Charting.Styles.CornerType.Round;
            corners3.RoundSize = 6;
            corners3.TopLeft = Telerik.Charting.Styles.CornerType.Round;
            corners3.TopRight = Telerik.Charting.Styles.CornerType.Round;
            this.radChart1.PlotArea.Appearance.Corners = corners3;
            chartMargins2.Bottom = ((Telerik.Charting.Styles.Unit)(resources.GetObject("chartMargins2.Bottom")));
            chartMargins2.Left = ((Telerik.Charting.Styles.Unit)(resources.GetObject("chartMargins2.Left")));
            chartMargins2.Right = ((Telerik.Charting.Styles.Unit)(resources.GetObject("chartMargins2.Right")));
            chartMargins2.Top = ((Telerik.Charting.Styles.Unit)(resources.GetObject("chartMargins2.Top")));
            this.radChart1.PlotArea.Appearance.Dimensions.Margins = chartMargins2;
            this.radChart1.PlotArea.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.radChart1.PlotArea.Appearance.FillStyle.SecondColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(186)))));
            this.radChart1.PlotArea.XAxis.Appearance.MajorGridLines.Color = System.Drawing.Color.DimGray;
            this.radChart1.PlotArea.XAxis.Appearance.MajorGridLines.Visible = false;
            this.radChart1.PlotArea.XAxis.Appearance.MajorTick.Color = System.Drawing.Color.Black;
            this.radChart1.PlotArea.XAxis.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.Black;
            this.radChart1.PlotArea.XAxis.AxisLabel.TextBlock.Appearance.TextProperties.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.radChart1.PlotArea.XAxis.LayoutMode = Telerik.Charting.Styles.ChartAxisLayoutMode.Inside;
            this.radChart1.PlotArea.XAxis.MaxValue = 5;
            this.radChart1.PlotArea.XAxis.MinValue = 1;
            this.radChart1.PlotArea.YAxis.Appearance.Color = System.Drawing.Color.Silver;
            this.radChart1.PlotArea.YAxis.Appearance.MajorGridLines.Color = System.Drawing.Color.Black;
            this.radChart1.PlotArea.YAxis.Appearance.MajorTick.Color = System.Drawing.Color.Silver;
            this.radChart1.PlotArea.YAxis.Appearance.MinorGridLines.Color = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.radChart1.PlotArea.YAxis.Appearance.MinorGridLines.Visible = false;
            this.radChart1.PlotArea.YAxis.Appearance.MinorTick.Color = System.Drawing.Color.Silver;
            this.radChart1.PlotArea.YAxis.Appearance.MinorTick.Visible = false;
            this.radChart1.PlotArea.YAxis.Appearance.Visible = Telerik.Charting.Styles.ChartAxisVisibility.False;
            this.radChart1.PlotArea.YAxis.AxisLabel.TextBlock.Appearance.TextProperties.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.radChart1.PlotArea.YAxis.MaxValue = 100;
            this.radChart1.PlotArea.YAxis.Step = 10;
            this.radChart1.PlotArea.YAxis.Visible = Telerik.Charting.Styles.ChartAxisVisibility.False;
            this.radChart1.PlotArea.YAxis2.AxisLabel.TextBlock.Appearance.TextProperties.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            chartSeries1.Appearance.Border.Color = System.Drawing.Color.Black;
            chartSeries1.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.Black;
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
            chartSeries2.Appearance.Border.Color = System.Drawing.Color.Black;
            chartSeries2.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.Black;
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
