using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;

namespace Telerik.Examples.WinControls.Chart.DataBinding.Database
{
	public partial class Form1 : ExamplesForm
	{
		public Form1()
		{
			InitializeComponent();
			//gets the data from the database
			DataTable dt = GetData();
			
			radChart1.ChartTitle.TextBlock.Text = "Customers by Country";
			radChart1.DataManager.DataSource = dt;
			
			//set the column in the datasource to be used for the labels
			radChart1.DataManager.LabelsColumn = "COUNTRY";

			//sets the labels so that there are no overlaps
			radChart1.IntelligentLabelsEnabled = true;
			radChart1.DataBind();
			radChart1.Series[0].Name = "Country";
			
			//the legend will display the labels of the items, instead of the name of the series
			radChart1.Series[0].Appearance.LegendDisplayMode = Telerik.Charting.ChartSeriesLegendDisplayMode.ItemLabels;
			radChart1.Update();
            
			this.EnabledQSFButtons = QSFButtons.None;
		}
		/// <summary>
		/// Returns a datatable containing data retrieved from the database
		/// </summary>
		/// <returns></returns>
		private DataTable GetData()
		{
			DataTable dt = new DataTable();
			//opens a connection to the northwind database - the file should be placed in the executable directory of the project
			System.Data.OleDb.OleDbConnection dbConn = 
				new System.Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\\DataSources\\Nwind.mdb");
			dbConn.Open();
			//initialize a command returning a list of countries and the number of customers in each one
			OleDbDataAdapter da = new OleDbDataAdapter(
				@"SELECT TOP 6 COUNTRY, count(*)
				FROM CUSTOMERS 
				GROUP BY COUNTRY", 
				dbConn);

			//execute the query and close the connection to the database
			try
			{
				da.Fill(dt);
			}
			finally
			{
				dbConn.Close();
			}
			return dt;
		}
	}
}