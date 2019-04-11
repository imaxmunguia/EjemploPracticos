using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.Charting;
using Telerik.QuickStart.WinControls;

namespace Telerik.Examples.WinControls.Chart.CandlestickCharts
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();

			radChart1.Series.Clear();

			ChartSeries cs = new ChartSeries();
			
			ChartSeriesItem csi = new ChartSeriesItem();
			csi.XValue = 0;
			csi.YValue = 3;
			csi.YValue2 = 4.5;
			csi.YValue3 = 1;
			csi.YValue4 = 6;
			cs.Items.Add(csi);

			ChartSeriesItem csi2 = new ChartSeriesItem();
			csi2.XValue = 1;
			csi2.YValue = 5;
			csi2.YValue2 = 4;
			csi2.YValue3 = 2;
			csi2.YValue4 = 8;
			cs.Items.Add(csi2);

			ChartSeriesItem csi3 = new ChartSeriesItem();
			csi3.XValue = 2;
			csi3.YValue = 5.5;
			csi3.YValue2 = 5;
			csi3.YValue3 = 3;
			csi3.YValue4 = 6;
			cs.Items.Add(csi3);

			ChartSeriesItem csi4 = new ChartSeriesItem();
			csi4.XValue = 3;
			csi4.YValue = 5;
			csi4.YValue2 = 4;
			csi4.YValue3 = 3;
			csi4.YValue4 = 7;
			cs.Items.Add(csi4);

			ChartSeriesItem csi5 = new ChartSeriesItem();
			csi5.XValue = 4;
			csi5.YValue = 5;
			csi5.YValue2 = 6;
			csi5.YValue3 = 4;
			csi5.YValue4 = 6.5;
			cs.Items.Add(csi5);

			cs.Type = ChartSeriesType.CandleStick;
            cs.Appearance.LabelAppearance.Visible = false;
			radChart1.Series.Add(cs);

			radChart1.PlotArea.XAxis.AutoScale = false;
			radChart1.PlotArea.XAxis.MaxValue = 4;
			radChart1.PlotArea.XAxis.MinValue = 0;
			radChart1.PlotArea.XAxis.Step = 1;

			radChart1.Update();
            this.EnabledQSFButtons = QSFButtons.None;
        }
    }
}