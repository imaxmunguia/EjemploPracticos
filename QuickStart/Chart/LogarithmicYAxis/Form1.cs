using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.Charting;
using Telerik.QuickStart.WinControls;

namespace Telerik.Examples.WinControls.Chart.LogarithmicYAxis
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();

			radChart1.Series.Clear();

			ChartSeries cs = new ChartSeries();
			cs.Items.Add(new ChartSeriesItem(5));
			cs.Items.Add(new ChartSeriesItem(50));
			cs.Items.Add(new ChartSeriesItem(500));
			cs.Items.Add(new ChartSeriesItem(5000));

			radChart1.PlotArea.YAxis.IsLogarithmic = true;

			radChart1.Series.Add(cs);

			radChart1.Update();
            this.EnabledQSFButtons = QSFButtons.None;
        }
    }
}