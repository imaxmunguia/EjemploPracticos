using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.Charting;
using Telerik.QuickStart.WinControls;

namespace Telerik.Examples.WinControls.Chart.StrictMode
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();

			radChart1.Series.Clear();

			ChartSeries cs = new ChartSeries();

			cs.Items.Add(new ChartSeriesItem(0, 3));
			cs.Items.Add(new ChartSeriesItem(1, 3));
			cs.Items.Add(new ChartSeriesItem(3, 4));
			cs.Items.Add(new ChartSeriesItem(3, 3));
			cs.Items.Add(new ChartSeriesItem(4, 5));
            cs.Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.White;
			radChart1.Series.Add(cs);
			
			radChart1.PlotArea.YAxis.AxisMode = ChartYAxisMode.Extended;
            //radChart1.PlotArea.XAxis.LayoutStyle = Telerik.Charting.Styles.ChartAxisLayoutMode.Between;
			radChart1.Update();

            this.EnabledQSFButtons = QSFButtons.None;
        }
    }
}