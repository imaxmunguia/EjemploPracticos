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

namespace Telerik.Examples.WinControls.Chart.Functionality.NegativeValues
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();

			radChart1.Series.Clear();
			
			//initialize the two series to be displayed in the chart
			ChartSeries cs = new ChartSeries();
			cs.Items.Add(new ChartSeriesItem(-1));
			cs.Items.Add(new ChartSeriesItem(4));
			cs.Items.Add(new ChartSeriesItem(2));
			cs.Items.Add(new ChartSeriesItem(-3));
			cs.Items.Add(new ChartSeriesItem(-2));
			cs.Items.Add(new ChartSeriesItem(0));
			cs.Items.Add(new ChartSeriesItem(2));

			cs.Type = ChartSeriesType.Bar;

			radChart1.Series.Add(cs);
			radChart1.Update();

            this.EnabledQSFButtons = QSFButtons.None;
        }
    }
}