using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using Telerik.QuickStart.WinControls;

namespace Telerik.Examples.WinControls.Chart.DataBinding.XMLBinding
{
	public partial class Form1 : ExamplesForm
	{
		public Form1()
		{
			InitializeComponent();
            this.EnabledQSFButtons = QSFButtons.None;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			radChart1.ChartTitle.TextBlock.Text = "Programming Books by Cost";
			//load the xml file to be displayed
			radChart1.DataSource = "..\\Chart\\DataBinding\\XMLBinding\\data.xml"; 
			radChart1.DataBind();
		}
	}
}