using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.Charting;
using Telerik.QuickStart.WinControls;

namespace Telerik.Examples.WinControls.Chart.IntelligentLabels
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();

			radChart1.Series.Clear();

			ChartSeries cs = new ChartSeries();

			cs.Items.Add(new ChartSeriesItem(3));
			cs.Items.Add(new ChartSeriesItem(6));
			cs.Items.Add(new ChartSeriesItem(4));
			cs.Items.Add(new ChartSeriesItem(3));
			cs.Items.Add(new ChartSeriesItem(8));
			cs.Type = ChartSeriesType.SplineArea;
			cs.Appearance.TextAppearance.TextProperties.Font = new Font("Arial", 9, FontStyle.Bold, GraphicsUnit.Point);
			ChartSeries cs1 = new ChartSeries();

			cs1.Items.Add(new ChartSeriesItem(3.1));
			cs1.Items.Add(new ChartSeriesItem(6.1));
			cs1.Items.Add(new ChartSeriesItem(4.1));
			cs1.Items.Add(new ChartSeriesItem(3.1));
			cs1.Items.Add(new ChartSeriesItem(8.1));
			cs1.Type = ChartSeriesType.SplineArea;
			cs1.Appearance.TextAppearance.TextProperties.Font = new Font("Arial", 9, FontStyle.Bold, GraphicsUnit.Point);
			ChartSeries cs2 = new ChartSeries();

			cs2.Items.Add(new ChartSeriesItem(3.2));
			cs2.Items.Add(new ChartSeriesItem(6.2));
			cs2.Items.Add(new ChartSeriesItem(4.2));
			cs2.Items.Add(new ChartSeriesItem(3.2));
			cs2.Items.Add(new ChartSeriesItem(8.2));
			cs2.Type = ChartSeriesType.SplineArea;
			cs2.Appearance.TextAppearance.TextProperties.Font = new Font("Arial", 9, FontStyle.Bold, GraphicsUnit.Point);

			radChart1.Series.Add(cs2);
			radChart1.Series.Add(cs1);
			radChart1.Series.Add(cs);

			radChart1.PlotArea.XAxis.LayoutMode = Telerik.Charting.Styles.ChartAxisLayoutMode.Normal;
			radChart1.PlotArea.XAxis.AutoScale = false;
			radChart1.PlotArea.XAxis.MaxValue = 4;
			radChart1.PlotArea.XAxis.MinValue = 0;
			radChart1.PlotArea.XAxis.Step = 1;
			radChart1.IntelligentLabelsEnabled = true;
			
			radChart1.Update();

            this.EnabledQSFButtons = QSFButtons.None;
        }
    }
}