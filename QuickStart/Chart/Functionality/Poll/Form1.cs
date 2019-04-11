using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.Charting;
using Telerik.QuickStart.WinControls;

namespace Telerik.Examples.WinControls.Chart.Functionality.Poll
{
	public partial class Form1 : ExamplesForm
	{
		public Form1()
		{
			InitializeComponent();
			//specifies a datasource of an array of double values
			radChart1.DataSource = new double[]{1.4, 1.9, 3.6, 4.2, 6.1};

			radChart1.DataBind();

            this.EnabledQSFButtons = QSFButtons.None;
		}
	}
}