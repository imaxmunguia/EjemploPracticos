using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.Chart.DataBinding.List
{
	public partial class Form1 : ExamplesForm
	{
		public Form1()
		{
			InitializeComponent();
			//initializes a simple list containing integers

            radChart1.DataBound += new EventHandler<EventArgs>(radChart1_DataBound);
            
            List<int> chartData = new List<int>();
			chartData.Add(900);
			chartData.Add(860);
			chartData.Add(830);
			chartData.Add(890);
			chartData.Add(940);
			chartData.Add(1230);

			radChart1.ChartTitle.TextBlock.Text = "Units Sold";
			//assigning the list as a datasource and binding it to the chart
			radChart1.DataSource = chartData;
			radChart1.DataBind();

            this.EnabledQSFButtons = QSFButtons.None;
		}

        void radChart1_DataBound(object sender, EventArgs e)
        {
            #pragma warning disable 618
            ((RadChart)sender).Series[0].Appearance.TextAppearance.TextProperties.Color = System.Drawing.Color.White;
        }

        
	}
}