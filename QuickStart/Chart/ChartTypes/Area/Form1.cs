using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.Charting;
using Telerik.QuickStart.WinControls;

namespace Telerik.Examples.WinControls.Chart.ChartTypes.Area
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();

			radChart1.Series.Clear();

			ChartSeries cs = new ChartSeries();
			cs.Items.Add(new ChartSeriesItem(1));
			cs.Items.Add(new ChartSeriesItem(3));
			cs.Items.Add(new ChartSeriesItem(4));
			cs.Items.Add(new ChartSeriesItem(3));
			cs.Items.Add(new ChartSeriesItem(5));
			cs.Items.Add(new ChartSeriesItem(7));
			cs.Items.Add(new ChartSeriesItem(7));
			cs.Items.Add(new ChartSeriesItem(8));
			cs.Items.Add(new ChartSeriesItem(10));
			cs.Items.Add(new ChartSeriesItem(12));
            cs.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.White;
            cs.Type = ChartSeriesType.Area;
			radChart1.Series.Add(cs);

			ChartSeries cs1 = new ChartSeries();
			cs1.Items.Add(new ChartSeriesItem(0));
			cs1.Items.Add(new ChartSeriesItem(1));
			cs1.Items.Add(new ChartSeriesItem(2));
			cs1.Items.Add(new ChartSeriesItem(2));
			cs1.Items.Add(new ChartSeriesItem(1));
			cs1.Items.Add(new ChartSeriesItem(5));
			cs1.Items.Add(new ChartSeriesItem(4));
			cs1.Items.Add(new ChartSeriesItem(7));
			cs1.Items.Add(new ChartSeriesItem(11));
			cs1.Items.Add(new ChartSeriesItem(9));
            cs1.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.White;
            cs1.Type = ChartSeriesType.Area;
			radChart1.Series.Add(cs1);

			radChart1.Update();

            this.EnabledQSFButtons = QSFButtons.None;
        }

    }
}