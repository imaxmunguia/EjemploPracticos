using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Telerik.Charting;
using Telerik.QuickStart.WinControls;

namespace Telerik.Examples.WinControls.Chart.ChartTypes.Point
{
    /// <summary>
    /// ChartType Point Example
    /// </summary>
	public partial class Form1 : ExamplesForm
	{
		private System.Random rand = new Random();
		public Form1()
		{
			InitializeComponent();
			
			radChart1.PlotArea.YAxis.AxisMode = Telerik.Charting.ChartYAxisMode.Extended;
			
			//construct a new series and add items with random data to it
			ChartSeries series = radChart1.CreateSeries("point", Color.Blue,Color.LightBlue, ChartSeriesType.Point);
            series.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.White;
			for(int i=0; i < 6; ++i)
			{
				ChartSeriesItem item = new ChartSeriesItem();
				item.YValue = rand.Next(1,10);
				item.XValue = i;
				
				series.Items.Add(item);
			}
			
			radChart1.Series.Clear();
			//add series to the chart
			radChart1.Series.Add(series);

            radChart1.SkinsOverrideStyles = true;
            radChart1.Skin = "Apple";
            radChart1.ChartTitle.TextBlock.Text = "Point";

            this.EnabledQSFButtons = QSFButtons.None;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			
		}
	}
}