using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.Charting;
using Telerik.QuickStart.WinControls;
using Telerik.Charting.Styles;

namespace Telerik.Examples.WinControls.Chart.ChartTypes.StackedArea
{
    public partial class Form1 : ExamplesForm
    {
		private Random rand = new Random();
        public Form1()
        {
            InitializeComponent();

			radChart1.ChartTitle.TextBlock.Text = "Stacked Area";
			
			radChart1.Series.Clear();

			ChartSeries cs = new ChartSeries();
			cs.Items.Add(new ChartSeriesItem(1));
			cs.Items.Add(new ChartSeriesItem(3));
			cs.Items.Add(new ChartSeriesItem(3));
			cs.Items.Add(new ChartSeriesItem(4));
			cs.Items.Add(new ChartSeriesItem(7));
			cs.Items.Add(new ChartSeriesItem(4));
			cs.Items.Add(new ChartSeriesItem(5));
			cs.Items.Add(new ChartSeriesItem(5));
            cs.Type = ChartSeriesType.StackedArea;
			radChart1.Series.Add(cs);

			ChartSeries cs1 = new ChartSeries();
			cs1.Items.Add(new ChartSeriesItem(3));
			cs1.Items.Add(new ChartSeriesItem(2));
			cs1.Items.Add(new ChartSeriesItem(6));
			cs1.Items.Add(new ChartSeriesItem(4));
			cs1.Items.Add(new ChartSeriesItem(6));
			cs1.Items.Add(new ChartSeriesItem(5));
			cs1.Items.Add(new ChartSeriesItem(4));
			cs1.Items.Add(new ChartSeriesItem(5));
            cs1.Type = ChartSeriesType.StackedArea;
			radChart1.Series.Add(cs1);
			radChart1.Update();

            this.EnabledQSFButtons = QSFButtons.None;
        }
    }
}