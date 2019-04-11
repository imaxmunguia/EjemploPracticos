using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Telerik.Charting;
using Telerik.QuickStart.WinControls;
using Telerik.Charting.Styles;

namespace Telerik.Examples.WinControls.Chart.DataBinding.LiveDataFeed
{
	public partial class Form1 : ExamplesForm
	{
		DataSet ds = new DataSet();
		public Form1()
		{
			InitializeComponent();
			//retrieves the XML content from the online datasource
			ds.ReadXml("http://store.rabbitvalley.org/rss_feed.rss");
			ChartSeries s = radChart1.Series[0];
			
			s.Appearance.ShowLabels = true;
			s.Name = "10 Ten Moving Items";
			//initializes chart properties
			radChart1.Appearance.BarWidthPercent = 60;
			radChart1.PlotArea.YAxis.AutoScale = false;
			radChart1.PlotArea.YAxis.AddRange(0, 11, 1);
			radChart1.PlotArea.YAxis.AxisLabel.Visible = false;
			radChart1.PlotArea.YAxis.Appearance.MajorTick.Visible = false;
			radChart1.PlotArea.YAxis.Appearance.LabelAppearance.Visible = false;
		    radChart1.PlotArea.XAxis.LayoutMode = ChartAxisLayoutMode.Inside;

			int i = 10;
			//adds series items from the from the data
			foreach (DataRow dr in ds.Tables[2].Rows)
			{
				s.Items.Add(new ChartSeriesItem(i--, (string)dr["Title"]));
			}
			radChart1.ChartTitle.TextBlock.Text = "Rabbit Valley 10 Ten Moving Items";

            this.EnabledQSFButtons = QSFButtons.None;
		}
	}
}