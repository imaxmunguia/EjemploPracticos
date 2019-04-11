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

namespace Telerik.Examples.WinControls.Chart.ChartTypes.Bezier
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
			radChart1.ChartTitle.TextBlock.Text = "Bezier";
			radChart1.DataManager.DataSource = ds;
			radChart1.DataManager.ValuesYColumns = new string[] { "Y" };
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
			dt.Columns.Add("Y", typeof(double));
			
			DataRow drv = dt.NewRow();
			drv[0] = 10;
			drv[1] = 20;
			dt.Rows.Add(drv);

			drv = dt.NewRow();
			drv[0] = 140;
			drv[1] = 100;
			dt.Rows.Add(drv);

			drv = dt.NewRow();
			drv[0] = -40;
			drv[1] = 100;
			dt.Rows.Add(drv);

			drv = dt.NewRow();
			drv[0] = 90;
			drv[1] = 20;
			dt.Rows.Add(drv);

			ds = new DataSet();
			ds.Tables.Add(dt);

			return ds;
		}
	}
}