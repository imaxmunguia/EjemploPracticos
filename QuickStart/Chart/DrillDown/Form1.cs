using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.Charting;
using Telerik.QuickStart.WinControls;
using System.Data.OleDb;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.Chart.DrillDown
{
	/// <summary>
	/// Main form for the drill down example
	/// </summary>
    public partial class Form1 : ExamplesForm
    {
		Telerik.Examples.WinControls.DataSources.ChartDataSetTableAdapters.RevenueTableAdapter rta;

		//stores the currently selected year
		int year;

        public Form1()
        {
            InitializeComponent();

            this.EnabledQSFButtons = QSFButtons.None;
			//populate the datasource from the database
			rta = new Telerik.Examples.WinControls.DataSources.ChartDataSetTableAdapters.RevenueTableAdapter();
			//fill the revenue by years
			rta.FillByYear(this.chartDataSet.Revenue);

			//setup the chart X axis properties
			radChart1.PlotArea.XAxis.IsZeroBased = false;
			radChart1.PlotArea.XAxis.AutoScale = false;
			radChart1.PlotArea.XAxis.MinValue = 2003;
			radChart1.PlotArea.XAxis.MaxValue = 2005;

			//attach the datasource to the chart
			radChart1.DataManager.DataSource = this.chartDataSet.Revenue;
			radChart1.Series[0].DataYColumn = "Revenue";
			radChart1.Series[0].DataXColumn = "Year";
			radChart1.Series[0].Name = "Years";
			radChart1.DataBind();
			radChart1.Update();
        }

		private void radChart1_Click(object sender, ChartClickEventArgs args)
		{
			if (args.Element.ActiveRegion.Parent is ChartSeriesItem && 
				(args.Element.ActiveRegion.Parent as ChartSeriesItem).Parent.Name == "Years")
			{
				//a bar representing the revenue for a year was clicked
				year = (args.Element as ChartSeriesItem).Index + 2003;
				//fill revenue values for the year whose bar was clicked
				rta.FillByQuarter(this.chartDataSet.Revenue, year);

				//setup chart properties with appopriate axis labels
				radChart1.PlotArea.XAxis.DataLabelsColumn = "Quarter";
				radChart1.Series[0].Clear();
				radChart1.Series[0].DataYColumn = "Revenue";
				radChart1.Series[0].Name = "Quarters";
				radChart1.DataBind();
			}
			else if (args.Element is ChartSeriesItem && 
				(args.Element as ChartSeriesItem).Parent.Name == "Quarters")
			{
				//a bar representing the revenue for a year was clicked
				int quarter = (args.Element as ChartSeriesItem).Index + 1;

				//fill revenue values for the year whose bar was clicked
				rta.FillByMonth(this.chartDataSet.Revenue, year, quarter);

				//setup chart properties with appopriate axis labels
				radChart1.PlotArea.XAxis.DataLabelsColumn = "Month";
				radChart1.Series[0].Clear();
				radChart1.Series[0].DataYColumn = "Revenue";
				radChart1.Series[0].Name = "Months";
				radChart1.DataBind();

                //Detach Click event handler for the innermost chart
#pragma warning disable 618
                radChart1.Click -= new RadChart.ChartClickEventHandler(radChart1_Click);
			}
		}
    }
}