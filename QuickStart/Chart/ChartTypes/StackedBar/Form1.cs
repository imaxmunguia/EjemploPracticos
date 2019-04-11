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

namespace Telerik.Examples.WinControls.Chart.ChartTypes.StackedBar
{
    public partial class Form1 : ExamplesForm
    {
		private Random rand = new Random();
        public Form1()
        {
            InitializeComponent();

			radChart1.Series.Clear();

			ChartSeries cs = new ChartSeries();
			cs.Items.Add(new ChartSeriesItem(1));
			cs.Items.Add(new ChartSeriesItem(6));
			cs.Items.Add(new ChartSeriesItem(7));
			cs.Items.Add(new ChartSeriesItem(15));
			cs.Items.Add(new ChartSeriesItem(14));
			cs.Items.Add(new ChartSeriesItem(19));
			cs.Items.Add(new ChartSeriesItem(14));
			cs.Items.Add(new ChartSeriesItem(21));
            cs.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.White;
            cs.Type = ChartSeriesType.StackedBar;

            radChart1.Series.Add(cs);

			ChartSeries cs1 = new ChartSeries();
			cs1.Items.Add(new ChartSeriesItem(4));
			cs1.Items.Add(new ChartSeriesItem(11));
			cs1.Items.Add(new ChartSeriesItem(19));
			cs1.Items.Add(new ChartSeriesItem(11));
			cs1.Items.Add(new ChartSeriesItem(12));
			cs1.Items.Add(new ChartSeriesItem(14));
			cs1.Items.Add(new ChartSeriesItem(17));
			cs1.Items.Add(new ChartSeriesItem(19));
            cs1.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.White;
            cs1.Type = ChartSeriesType.StackedBar;
			radChart1.Series.Add(cs1);
			radChart1.Update();
			
            this.EnabledQSFButtons = QSFButtons.None;
        }
    }
}