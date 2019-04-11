namespace Telerik.Examples.WinControls.Chart.Functionality.Poll
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
            Telerik.Charting.Styles.Unit unit1 = new Telerik.Charting.Styles.Unit();
            Telerik.Charting.Styles.Unit unit2 = new Telerik.Charting.Styles.Unit();
            Telerik.Charting.Styles.Corners corners1 = new Telerik.Charting.Styles.Corners();
            Telerik.Charting.ChartAxisItem chartAxisItem1 = new Telerik.Charting.ChartAxisItem();
            Telerik.Charting.ChartAxisItem chartAxisItem2 = new Telerik.Charting.ChartAxisItem();
            Telerik.Charting.ChartAxisItem chartAxisItem3 = new Telerik.Charting.ChartAxisItem();
            Telerik.Charting.ChartAxisItem chartAxisItem4 = new Telerik.Charting.ChartAxisItem();
            Telerik.Charting.ChartAxisItem chartAxisItem5 = new Telerik.Charting.ChartAxisItem();
            Telerik.Charting.ChartAxisItem chartAxisItem6 = new Telerik.Charting.ChartAxisItem();
            Telerik.Charting.ChartAxisItem chartAxisItem7 = new Telerik.Charting.ChartAxisItem();
            Telerik.Charting.ChartAxisItem chartAxisItem8 = new Telerik.Charting.ChartAxisItem();
            Telerik.Charting.ChartAxisItem chartAxisItem9 = new Telerik.Charting.ChartAxisItem();
            Telerik.Charting.ChartAxisItem chartAxisItem10 = new Telerik.Charting.ChartAxisItem();
            Telerik.Charting.ChartAxisItem chartAxisItem11 = new Telerik.Charting.ChartAxisItem();
            Telerik.Charting.ChartAxisItem chartAxisItem12 = new Telerik.Charting.ChartAxisItem();
            Telerik.Charting.ChartAxisItem chartAxisItem13 = new Telerik.Charting.ChartAxisItem();
            Telerik.Charting.ChartAxisItem chartAxisItem14 = new Telerik.Charting.ChartAxisItem();
            Telerik.Charting.ChartAxisItem chartAxisItem15 = new Telerik.Charting.ChartAxisItem();
            Telerik.Charting.ChartAxisItem chartAxisItem16 = new Telerik.Charting.ChartAxisItem();
            Telerik.Charting.ChartAxisItem chartAxisItem17 = new Telerik.Charting.ChartAxisItem();
            Telerik.Charting.ChartAxisItem chartAxisItem18 = new Telerik.Charting.ChartAxisItem();
            Telerik.Charting.ChartAxisItem chartAxisItem19 = new Telerik.Charting.ChartAxisItem();
            Telerik.Charting.ChartAxisItem chartAxisItem20 = new Telerik.Charting.ChartAxisItem();
            Telerik.Charting.ChartSeries chartSeries1 = new Telerik.Charting.ChartSeries();
            Telerik.Charting.ChartSeries chartSeries2 = new Telerik.Charting.ChartSeries();
#pragma warning disable 618
            this.radChart1 = new Telerik.WinControls.UI.RadChart();
			this.radChart1.Skin = "Default2006";
            ((System.ComponentModel.ISupportInitialize)(this.radChart1)).BeginInit();
            this.SuspendLayout();
            // 
            // radChart1
            // 
            unit1.Value = 503;
            this.radChart1.Appearance.Dimensions.Height = unit1;
            unit2.Value = 621;
            this.radChart1.Appearance.Dimensions.Width = unit2;
            this.radChart1.ChartTitle.TextBlock.Text = "Consumption by Month";
            this.radChart1.DataGroupColumn = null;
            this.radChart1.DefaultType = Telerik.Charting.ChartSeriesType.Pie;
            this.radChart1.Legend.Appearance.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.radChart1.Location = new System.Drawing.Point(12, 12);
            this.radChart1.Name = "radChart1";
            corners1.BottomLeft = Telerik.Charting.Styles.CornerType.Round;
            corners1.BottomRight = Telerik.Charting.Styles.CornerType.Round;
            corners1.RoundSize = 6;
            corners1.TopLeft = Telerik.Charting.Styles.CornerType.Round;
            corners1.TopRight = Telerik.Charting.Styles.CornerType.Round;
            this.radChart1.PlotArea.Appearance.Corners = corners1;
            this.radChart1.PlotArea.XAxis.Appearance.MajorGridLines.Visible = false;
            this.radChart1.PlotArea.XAxis.AxisLabel.TextBlock.Appearance.TextProperties.Font = new System.Drawing.Font("Arial", 10F);
            chartAxisItem1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            chartAxisItem2.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            chartAxisItem3.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            chartAxisItem4.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            chartAxisItem5.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            chartAxisItem6.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            chartAxisItem7.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.radChart1.PlotArea.XAxis.Items.AddRange(new Telerik.Charting.ChartAxisItem[] {
            chartAxisItem1,
            chartAxisItem2,
            chartAxisItem3,
            chartAxisItem4,
            chartAxisItem5,
            chartAxisItem6,
            chartAxisItem7});
            this.radChart1.PlotArea.XAxis.MaxValue = 7;
            this.radChart1.PlotArea.XAxis.MinValue = 1;
            this.radChart1.PlotArea.XAxis.Step = 1;
            this.radChart1.PlotArea.YAxis.AxisLabel.TextBlock.Appearance.TextProperties.Font = new System.Drawing.Font("Arial", 10F);
            chartAxisItem9.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            chartAxisItem10.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            chartAxisItem11.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            chartAxisItem12.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            chartAxisItem13.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.radChart1.PlotArea.YAxis.Items.AddRange(new Telerik.Charting.ChartAxisItem[] {
            chartAxisItem8,
            chartAxisItem9,
            chartAxisItem10,
            chartAxisItem11,
            chartAxisItem12,
            chartAxisItem13});
            this.radChart1.PlotArea.YAxis.Step = 20;
            this.radChart1.PlotArea.YAxis2.AxisLabel.TextBlock.Appearance.TextProperties.Font = new System.Drawing.Font("Arial", 10F);
            chartAxisItem14.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            chartAxisItem15.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            chartAxisItem16.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            chartAxisItem17.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            chartAxisItem18.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            chartAxisItem19.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            chartAxisItem20.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.radChart1.PlotArea.YAxis2.Items.AddRange(new Telerik.Charting.ChartAxisItem[] {
            chartAxisItem14,
            chartAxisItem15,
            chartAxisItem16,
            chartAxisItem17,
            chartAxisItem18,
            chartAxisItem19,
            chartAxisItem20});
            this.radChart1.PlotArea.YAxis2.MaxValue = 7;
            this.radChart1.PlotArea.YAxis2.MinValue = 1;
            this.radChart1.PlotArea.YAxis2.Step = 1;
            chartSeries1.Name = "Series 1";
            chartSeries1.Type = Telerik.Charting.ChartSeriesType.Pie;
            chartSeries2.Name = "Series 2";
            chartSeries2.Type = Telerik.Charting.ChartSeriesType.Pie;
            this.radChart1.Series.Add(chartSeries1);
            this.radChart1.Series.Add(chartSeries2);
            this.radChart1.Size = new System.Drawing.Size(400, 300);
            this.radChart1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radChart1);
            this.Name = "Form1";
			this.Size = new System.Drawing.Size(450, 350);
            ((System.ComponentModel.ISupportInitialize)(this.radChart1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private Telerik.WinControls.UI.RadChart radChart1;
	}
}