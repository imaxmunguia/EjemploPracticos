using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.Charting;
using Telerik.QuickStart.WinControls;

namespace Telerik.Examples.WinControls.Chart.MarkedZones
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();

			radChart1.Series.Clear();

			//adding the series items
			ChartSeries cs = new ChartSeries();

			cs.Items.Add(new ChartSeriesItem(3));
			cs.Items.Add(new ChartSeriesItem(6));
			cs.Items.Add(new ChartSeriesItem(4));
			cs.Items.Add(new ChartSeriesItem(3));
			cs.Items.Add(new ChartSeriesItem(8));

			radChart1.Series.Add(cs);

			//adding the colored zones
			ChartMarkedZone zone1 = new ChartMarkedZone();
			zone1.ValueStartY = 0;
			zone1.ValueEndY = 3;
			zone1.Appearance.FillStyle.MainColor = Color.LightGreen;
			radChart1.PlotArea.MarkedZones.Add(zone1);

			ChartMarkedZone zone2 = new ChartMarkedZone();
			zone2.ValueStartY = 3;
			zone2.ValueEndY = 6;
			zone2.Appearance.FillStyle.MainColor = Color.LightYellow;
			radChart1.PlotArea.MarkedZones.Add(zone2);

			ChartMarkedZone zone3 = new ChartMarkedZone();
			zone3.ValueStartY = 6;
			zone3.ValueEndY = 8;
			zone3.Appearance.FillStyle.MainColor = Color.PaleVioletRed;

			radChart1.PlotArea.MarkedZones.Add(zone3);

			radChart1.Update();

            this.EnabledQSFButtons = QSFButtons.None;
        }
    }
}