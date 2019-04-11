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

namespace Telerik.Examples.WinControls.Chart.ChartTypes.Bar
{
	public partial class Form1 : ExamplesForm
	{
		public Form1()
		{
			InitializeComponent();
			//populate datavalues
			DataSet ds = GetSampleData();
			
			//set the properties to be used from the datasource to populate the chart
			radChart2.ChartTitle.TextBlock.Text = "Sales by Month";
			radChart2.DataManager.DataSource = ds;
			radChart2.DataManager.ValuesYColumns = new string[] { "Sales" };
			radChart2.DataManager.LabelsColumn = "Month";
			radChart2.DataManager.DataMember = "Product A";
			radChart2.DataBind();

            this.EnabledQSFButtons = QSFButtons.None;
		}
		/// <summary>
		/// Returns a simple dataset to be bound to the chart
		/// </summary>
		/// <returns></returns>
		public DataSet GetSampleData()
		{
			DataTable dt = new DataTable("Product A");
			dt.Columns.Add("id", typeof(int));
			dt.Columns.Add("Sales", typeof(double));
			dt.Columns.Add("Month", typeof(string));

			DataRow drv = dt.NewRow();
			drv[0] = 0;
			drv[1] = 1000;
			drv[2] = "January";
			dt.Rows.Add(drv);

			drv = dt.NewRow();
			drv[0] = 1;
			drv[1] = 1200;
			drv[2] = "February";
			dt.Rows.Add(drv);

			drv = dt.NewRow();
			drv[0] = 2;
			drv[1] = 1200;
			drv[2] = "March";
			dt.Rows.Add(drv);

			drv = dt.NewRow();
			drv[0] = 3;
			drv[1] = 1240;
			drv[2] = "April";
			dt.Rows.Add(drv);

			drv = dt.NewRow();
			drv[0] = 4;
			drv[1] = 1249;
			drv[2] = "May";
			dt.Rows.Add(drv);

			drv = dt.NewRow();
			drv[0] = 5;
			drv[1] = 1320;
			drv[2] = "June";
			dt.Rows.Add(drv);

			drv = dt.NewRow();
			drv[0] = 6;
			drv[1] = 1410;
			drv[2] = "July";
			dt.Rows.Add(drv);
			
			DataSet ds = new DataSet();
			ds.Tables.Add(new DataTable("Books"));
			ds.Tables.Add(dt);

			return ds;
		}
	}
}