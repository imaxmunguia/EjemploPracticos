using System;
using Telerik.Charting;
using Telerik.QuickStart.WinControls;

namespace Telerik.Examples.WinControls.Chart.Functionality.Multilanguage
{
	public partial class Form1 : ExamplesForm
	{
		public Form1()
		{
			InitializeComponent();

			radComboBox1.Text = "Select language";
			radComboBox1.SelectedIndex = 0;
			this.Refresh();

            this.EnabledQSFButtons = QSFButtons.None;
		}

        private void radComboBox1_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
		{
			string fileName =  String.Empty;
			switch(radComboBox1.SelectedIndex)
			{
				//english
				case 0:
					fileName = "..\\Chart\\Functionality\\Multilanguage\\EN.xml";
					break;
				//german
				case 1:
					fileName = "..\\Chart\\Functionality\\Multilanguage\\DE.xml";
					break;
				//spanish
				case 2:
					fileName = "..\\Chart\\Functionality\\Multilanguage\\ES.xml";
					break;
				//french
				case 3:
					fileName = "..\\Chart\\Functionality\\Multilanguage\\FR.xml";
					break;
			}
			if(System.IO.File.Exists(fileName))
			{
				SetExplode(radComboBox1.SelectedIndex);
				this.Refresh();
			}
		}
		private void SetExplode(int itemIndex)
		{
			ChartSeries s = radChart1.Series[0];
			int index = 0;
			foreach (ChartSeriesItem seriesItem in s.Items)
			{
				seriesItem.Appearance.Exploded  = index == itemIndex;
				index++;
			}
		}

	}
}