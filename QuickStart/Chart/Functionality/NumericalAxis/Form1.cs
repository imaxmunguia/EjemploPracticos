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

namespace Telerik.Examples.WinControls.Chart.Functionality.NumericalAxis
{
    /// <summary>
    /// Form demonstrating RadChart's capabilities. Example name: Numerical Axis
    /// </summary>
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();

            this.EnabledQSFButtons = QSFButtons.None;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            const double hourStep = 1 / 24.0;
            //const double minuteStep = hourStep / 60;
            const double fiveMinuteStep = hourStep / 12;

            double startTime = new DateTime(2008, 1, 1, 8, 0, 0, 0).ToOADate();
            double endTime = new DateTime(2008, 1, 1, 17, 0, 0, 0).ToOADate();

            radChart1.PlotArea.XAxis.AddRange(startTime, endTime, hourStep);

            Random r = new Random();

            ChartSeries series = radChart1.Series[0];
            series.Items.Clear();


            for (double currentTime = startTime; currentTime < endTime; currentTime += fiveMinuteStep)
            {
                ChartSeriesItem item = new ChartSeriesItem();
                item.XValue = currentTime + (r.NextDouble() - 0.5) * fiveMinuteStep;
                item.YValue = 7065 + (r.NextDouble() - 0.5) * 90;
                series.Items.Add(item);
            }

            radChart1.Series.Add(series);
        }
    }
}