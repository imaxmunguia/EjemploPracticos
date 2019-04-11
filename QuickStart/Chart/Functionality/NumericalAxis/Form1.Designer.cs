namespace Telerik.Examples.WinControls.Chart.Functionality.NumericalAxis
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
            Telerik.Charting.Styles.Unit unit3 = new Telerik.Charting.Styles.Unit();
            Telerik.Charting.Styles.Unit unit4 = new Telerik.Charting.Styles.Unit();
            Telerik.Charting.ChartAxisItem chartAxisItem1 = new Telerik.Charting.ChartAxisItem();
            Telerik.Charting.ChartAxisItem chartAxisItem2 = new Telerik.Charting.ChartAxisItem();
            Telerik.Charting.ChartAxisItem chartAxisItem3 = new Telerik.Charting.ChartAxisItem();
            Telerik.Charting.ChartAxisItem chartAxisItem4 = new Telerik.Charting.ChartAxisItem();
            Telerik.Charting.ChartAxisItem chartAxisItem5 = new Telerik.Charting.ChartAxisItem();
            Telerik.Charting.ChartAxisItem chartAxisItem6 = new Telerik.Charting.ChartAxisItem();
            Telerik.Charting.ChartAxisItem chartAxisItem7 = new Telerik.Charting.ChartAxisItem();
            Telerik.Charting.ChartAxisItem chartAxisItem8 = new Telerik.Charting.ChartAxisItem();
            Telerik.Charting.ChartSeries chartSeries1 = new Telerik.Charting.ChartSeries();
            Telerik.Charting.GradientElement gradientElement1 = new Telerik.Charting.GradientElement();
            Telerik.Charting.GradientElement gradientElement2 = new Telerik.Charting.GradientElement();
            Telerik.Charting.GradientElement gradientElement3 = new Telerik.Charting.GradientElement();
#pragma warning disable 618
            this.radChart1 = new Telerik.WinControls.UI.RadChart();
            ((System.ComponentModel.ISupportInitialize)(this.radChart1)).BeginInit();
            this.SuspendLayout();
            // 
            // radChart1
            // 
            this.radChart1.Appearance.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(225)))), ((int)(((byte)(169)))));
            this.radChart1.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(249)))), ((int)(((byte)(213)))));
            this.radChart1.ChartTitle.Appearance.Border.Color = System.Drawing.Color.Empty;
            this.radChart1.ChartTitle.Appearance.FillStyle.MainColor = System.Drawing.Color.Empty;
            this.radChart1.ChartTitle.TextBlock.Appearance.TextProperties.Color = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(153)))), ((int)(((byte)(4)))));
            this.radChart1.ChartTitle.TextBlock.Text = "NYSE Index";
            this.radChart1.Legend.Appearance.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(217)))), ((int)(((byte)(201)))));
            this.radChart1.Legend.Appearance.Corners = new Telerik.Charting.Styles.Corners(Telerik.Charting.Styles.CornerType.Round, Telerik.Charting.Styles.CornerType.Round, Telerik.Charting.Styles.CornerType.Round, Telerik.Charting.Styles.CornerType.Round, 6);
            this.radChart1.Legend.Appearance.ItemTextAppearance.TextProperties.Color = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(94)))), ((int)(((byte)(57)))));
            this.radChart1.Location = new System.Drawing.Point(12, 12);
            this.radChart1.Name = "radChart1";
            this.radChart1.PlotArea.Appearance.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(218)))), ((int)(((byte)(202)))));
            unit1.Type = Telerik.Charting.Styles.UnitType.Percentage;
            unit1.Value = 18F;
            unit2.Type = Telerik.Charting.Styles.UnitType.Percentage;
            unit2.Value = 23F;
            unit3.Type = Telerik.Charting.Styles.UnitType.Percentage;
            unit3.Value = 12F;
            unit4.Type = Telerik.Charting.Styles.UnitType.Percentage;
            unit4.Value = 10F;
            this.radChart1.PlotArea.Appearance.Dimensions.Margins = new Telerik.Charting.Styles.ChartMargins(unit1, unit2, unit3, unit4);
            this.radChart1.PlotArea.Appearance.FillStyle.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(228)))));
            this.radChart1.PlotArea.Appearance.FillStyle.SecondColor = System.Drawing.Color.Transparent;
            this.radChart1.SkinsOverrideStyles = true;
            this.radChart1.Skin = "Apple";
            this.radChart1.PlotArea.XAxis.Appearance.Color = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(218)))), ((int)(((byte)(202)))));
            this.radChart1.PlotArea.XAxis.Appearance.LabelAppearance.RotationAngle = 45F;
            this.radChart1.PlotArea.XAxis.Appearance.MajorGridLines.Color = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(218)))), ((int)(((byte)(202)))));
            this.radChart1.PlotArea.XAxis.Appearance.MajorTick.Color = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(207)))), ((int)(((byte)(190)))));
            this.radChart1.PlotArea.XAxis.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(93)))), ((int)(((byte)(56)))));
            this.radChart1.PlotArea.XAxis.Appearance.ValueFormat = Telerik.Charting.Styles.ChartValueFormat.ShortTime;
            this.radChart1.PlotArea.XAxis.AutoScale = false;
            this.radChart1.PlotArea.XAxis.AxisLabel.TextBlock.Appearance.TextProperties.Color = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(93)))), ((int)(((byte)(56)))));
            chartAxisItem1.Appearance.RotationAngle = 45F;
            chartAxisItem1.TextBlock.Appearance.TextProperties.Color = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(93)))), ((int)(((byte)(56)))));
            chartAxisItem2.Appearance.RotationAngle = 45F;
            chartAxisItem2.TextBlock.Appearance.TextProperties.Color = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(93)))), ((int)(((byte)(56)))));
            chartAxisItem2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            chartAxisItem3.Appearance.RotationAngle = 45F;
            chartAxisItem3.TextBlock.Appearance.TextProperties.Color = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(93)))), ((int)(((byte)(56)))));
            chartAxisItem3.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            chartAxisItem4.Appearance.RotationAngle = 45F;
            chartAxisItem4.TextBlock.Appearance.TextProperties.Color = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(93)))), ((int)(((byte)(56)))));
            chartAxisItem4.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            chartAxisItem5.Appearance.RotationAngle = 45F;
            chartAxisItem5.TextBlock.Appearance.TextProperties.Color = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(93)))), ((int)(((byte)(56)))));
            chartAxisItem5.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            chartAxisItem6.Appearance.RotationAngle = 45F;
            chartAxisItem6.TextBlock.Appearance.TextProperties.Color = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(93)))), ((int)(((byte)(56)))));
            chartAxisItem6.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            chartAxisItem7.Appearance.RotationAngle = 45F;
            chartAxisItem7.TextBlock.Appearance.TextProperties.Color = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(93)))), ((int)(((byte)(56)))));
            chartAxisItem7.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            chartAxisItem8.Appearance.RotationAngle = 45F;
            chartAxisItem8.TextBlock.Appearance.TextProperties.Color = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(93)))), ((int)(((byte)(56)))));
            chartAxisItem8.Value = new decimal(new int[] {
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
            chartAxisItem7,
            chartAxisItem8});
            this.radChart1.PlotArea.XAxis.LayoutMode = Telerik.Charting.Styles.ChartAxisLayoutMode.Inside;
            this.radChart1.PlotArea.YAxis.Appearance.Color = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(218)))), ((int)(((byte)(202)))));
            this.radChart1.PlotArea.YAxis.Appearance.MajorGridLines.Color = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(225)))), ((int)(((byte)(212)))));
            this.radChart1.PlotArea.YAxis.Appearance.MajorTick.Color = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(218)))), ((int)(((byte)(202)))));
            this.radChart1.PlotArea.YAxis.Appearance.MinorGridLines.Color = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(225)))), ((int)(((byte)(212)))));
            this.radChart1.PlotArea.YAxis.Appearance.MinorTick.Color = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(218)))), ((int)(((byte)(202)))));
            this.radChart1.PlotArea.YAxis.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(93)))), ((int)(((byte)(56)))));
            this.radChart1.PlotArea.YAxis.AxisLabel.TextBlock.Appearance.TextProperties.Color = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(93)))), ((int)(((byte)(56)))));
            this.radChart1.PlotArea.YAxis.IsZeroBased = false;
            this.radChart1.PlotArea.YAxis.MaxValue = 80;
            this.radChart1.PlotArea.YAxis.Step = 10;
            chartSeries1.Appearance.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            gradientElement1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(206)))), ((int)(((byte)(119)))));
            gradientElement2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(190)))), ((int)(((byte)(82)))));
            gradientElement2.Position = 0.5F;
            gradientElement3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(157)))), ((int)(((byte)(44)))));
            gradientElement3.Position = 1F;
            chartSeries1.Appearance.FillStyle.FillSettings.ComplexGradient.AddRange(new Telerik.Charting.GradientElement[] {
            gradientElement1,
            gradientElement2,
            gradientElement3});
            chartSeries1.Appearance.FillStyle.FillType = Telerik.Charting.Styles.FillType.ComplexGradient;
            chartSeries1.Appearance.ShowLabels = false;
            chartSeries1.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(93)))), ((int)(((byte)(56)))));
            chartSeries1.Name = "Index";
            chartSeries1.Type = Telerik.Charting.ChartSeriesType.Area;
            this.radChart1.Series.AddRange(new Telerik.Charting.ChartSeries[] {
            chartSeries1});
            this.radChart1.Size = new System.Drawing.Size(500, 300);
            this.radChart1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radChart1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(903, 796);
            ((System.ComponentModel.ISupportInitialize)(this.radChart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadChart radChart1;
    }
}