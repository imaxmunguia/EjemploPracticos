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

namespace Telerik.Examples.WinControls.Chart.ChartTypes.Bubble
{
	public partial class Form1 : ExamplesForm
	{
		DataSet ds = new DataSet();
		public Form1()
		{
			InitializeComponent();

			//populate datavalues
			ds = GetSampleData();

			//set the properties to be used from the datasource to populate the chart
			radChart1.PlotArea.YAxis.AxisMode = Telerik.Charting.ChartYAxisMode.Extended;
			radChart1.ChartTitle.TextBlock.Text = "Bubble";
			radChart1.DataManager.DataSource = ds;
			radChart1.DataManager.DataMember = "Data";
			radChart1.DataBind();

            this.EnabledQSFButtons = QSFButtons.None;
		}
		/// <summary>
		/// Returns a simple dataset to be bound to the chart
		/// </summary>
		/// <returns></returns>
		public DataSet GetSampleData()
		{
			DataTable dt = new DataTable("Data");
			dt.Columns.Add("X", typeof(int));
			dt.Columns.Add("Y", typeof(int));
			dt.Columns.Add("X2", typeof(int));
			dt.Columns.Add("Y2", typeof(int));

			DataRow drv = dt.NewRow();
			drv[0] = -20;
			drv[1] = -10;
			drv[2] = 10;
			drv[3] = 5;
			dt.Rows.Add(drv);

			drv = dt.NewRow();
			drv[0] = 10;
			drv[1] = 20;
			drv[2] = 5;
			drv[3] = 10;
			dt.Rows.Add(drv);

			drv = dt.NewRow();
			drv[0] = -30;
			drv[1] = 40;
			drv[2] = 5;
			drv[3] = 10;
			dt.Rows.Add(drv);

			drv = dt.NewRow();
			drv[0] = 40;
			drv[1] = -30;
			drv[2] = 15;
			drv[3] = 15;
			dt.Rows.Add(drv);

			drv = dt.NewRow();
			drv[0] = 20;
			drv[1] = -50;
			drv[2] = 5;
			drv[3] = 20;
			dt.Rows.Add(drv);

			drv = dt.NewRow();
			drv[0] = 0;
			drv[1] = 0;
			drv[2] = 5;
			drv[3] = 10;
			dt.Rows.Add(drv);

			ds = new DataSet();
			ds.Tables.Add(dt);

			return ds;
		}
	}
}