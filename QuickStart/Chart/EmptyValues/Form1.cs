using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.Charting;
using Telerik.QuickStart.WinControls;

namespace Telerik.Examples.WinControls.Chart.EmptyValues
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();

			radChart1.Series.Clear();
			radChart1.Skin = "LightBlue";
			ChartSeries cs = new ChartSeries();
			cs.Items.Add(new ChartSeriesItem(0,3));

			ChartSeriesItem csi = new ChartSeriesItem(1, 6);
			cs.Items.Add(csi);

			ChartSeriesItem csi1 = new ChartSeriesItem(2, 4);
			csi1.Empty = true;
			cs.Items.Add(csi1);

			cs.Items.Add(new ChartSeriesItem(3, 3));
			cs.Items.Add(new ChartSeriesItem(4, 8));
			cs.Type = ChartSeriesType.SplineArea;
			

			radChart1.Series.Add(cs);

			radChart1.PlotArea.XAxis.LayoutMode = Telerik.Charting.Styles.ChartAxisLayoutMode.Normal;
			radChart1.PlotArea.XAxis.AutoScale = false;
			radChart1.PlotArea.XAxis.MaxValue = 4;
			radChart1.PlotArea.XAxis.MinValue = 0;
			radChart1.PlotArea.XAxis.Step = 1;
			
			cs.Appearance.Border.Width = 5;
			radChart1.Update();

            this.EnabledQSFButtons = QSFButtons.None;

        }
    }
}