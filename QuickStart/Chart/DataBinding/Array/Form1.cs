using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;

namespace Telerik.Examples.WinControls.Chart.DataBinding.Array
{
	public partial class Form1 : ExamplesForm
	{
		public Form1()
		{
			InitializeComponent();
			//initialize a simple array of double values to be displayed
			radChart1.DataSource = new double[] { 1.4, 1.9, 3.6, 3.6, 4.1 };

			radChart1.ChartTitle.TextBlock.Text = "Units Purchased (Thousands)";
			radChart1.DataBind();

            this.EnabledQSFButtons = QSFButtons.None;
		}
	}
}