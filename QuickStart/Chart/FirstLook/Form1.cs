using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.Charting;
//using Telerik.WinControls.RadControlSpy;
using Telerik.WinControls.UI;
using Telerik.WinControls.Primitives;
using Telerik.WinControls;
using Telerik.Charting.Styles;

namespace Telerik.Examples.WinControls.Chart.FirstLook
{
    /// <summary>
    /// Example: First Look
    /// </summary>
	public partial class Form1 : ExamplesForm
	{
		System.Random rand = new Random(DateTime.Now.Millisecond);
		public Form1()
		{
			InitializeComponent();

			radChart1.ChartTitle.TextBlock.Text = "Units Sold (Thousands)";

			//traverse all the buttons in the form setting their mouse events
			foreach (Control ctrl in panel.Controls)
			{
				RadButton btn = ctrl as RadButton;
				if (btn == null)
					continue;

				btn.MouseEnter += new EventHandler(radButton1_MouseEnter);
				btn.MouseLeave += new EventHandler(radButton1_MouseLeave);
			}

			//setup chart as a piechart by default
			radChart1.Series.Clear();
			radChart1.Series.Add(GetRandomData(6, ChartSeriesType.Pie));
			radChart1.Update();

            radChart1.Skin = "Vista";

			radChart1.BorderStyle = BorderStyle.None;

			this.EnabledQSFButtons = QSFButtons.None;            
		}

		void radButton1_MouseLeave(object sender, EventArgs e)
		{
			//setup style in case mouse leaves
			RadButton btn = ((RadButton)sender);
			((FillPrimitive)btn.RootElement.Children[0].Children[0]).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
			((BorderPrimitive)btn.RootElement.Children[0].Children[2]).Visibility = ElementVisibility.Hidden;
			((TextPrimitive)btn.RootElement.Children[0].Children[1].Children[1]).ForeColor = Color.FromArgb(75, 83, 62);
		}

		void radButton1_MouseEnter(object sender, EventArgs e)
		{
			//setup style in case mouse enters
			RadButton btn = ((RadButton)sender);
			((FillPrimitive)btn.RootElement.Children[0].Children[0]).Visibility = Telerik.WinControls.ElementVisibility.Visible;
			((FillPrimitive)btn.RootElement.Children[0].Children[0]).GradientStyle = GradientStyles.Linear;
			((FillPrimitive)btn.RootElement.Children[0].Children[0]).NumberOfColors = 4;
			((FillPrimitive)btn.RootElement.Children[0].Children[0]).BackColor = Color.FromArgb(255, 255, 254);
			((FillPrimitive)btn.RootElement.Children[0].Children[0]).BackColor2 = Color.FromArgb(253, 253, 250);
			((FillPrimitive)btn.RootElement.Children[0].Children[0]).BackColor3 = Color.FromArgb(237, 245, 225);
			((FillPrimitive)btn.RootElement.Children[0].Children[0]).BackColor4 = Color.FromArgb(252, 253, 250);
			((BorderPrimitive)btn.RootElement.Children[0].Children[2]).ForeColor = Color.FromArgb(193, 206, 171);
			((BorderPrimitive)btn.RootElement.Children[0].Children[2]).Visibility = ElementVisibility.Visible;
			((TextPrimitive)btn.RootElement.Children[0].Children[1].Children[1]).ForeColor = Color.FromArgb(103, 138, 51);
		}
		private Telerik.Charting.ChartSeries GetRandomData(int count, ChartSeriesType seriesType)
		{
            Telerik.Charting.ChartSeries series = new Telerik.Charting.ChartSeries();
			series.Type = seriesType;
			for (int i = 0; i < count; ++i)
			{
				series.Items.Add(new ChartSeriesItem(rand.Next(0, 100)));
			}
			return series;
		}

		private void radButton1_Click(object sender, EventArgs e)
		{
			radChart1.Series.Clear();
			radChart1.Series.Add(GetRandomData(6, ChartSeriesType.Pie));
			radChart1.Refresh();
		}

		private void radButton4_Click(object sender, EventArgs e)
		{
			radChart1.Series.Clear();
			radChart1.Series.Add(GetRandomData(6, ChartSeriesType.Bar));
			radChart1.Series.Add(GetRandomData(6, ChartSeriesType.Bar));
			radChart1.Refresh();
		}

		private void radButton3_Click(object sender, EventArgs e)
		{
			radChart1.Series.Clear();
			radChart1.Series.Add(GetRandomData(6, ChartSeriesType.StackedBar));
			radChart1.Series.Add(GetRandomData(6, ChartSeriesType.StackedBar));
			radChart1.Refresh();
		}

		private void radButton7_Click(object sender, EventArgs e)
		{
			radChart1.Series.Clear();
			radChart1.Series.Add(GetRandomData(6, ChartSeriesType.Area));
			radChart1.Series.Add(GetRandomData(6, ChartSeriesType.Area));
			radChart1.Refresh();
		}

		private void radButton5_Click(object sender, EventArgs e)
		{
			radChart1.Series.Clear();
			radChart1.Series.Add(GetRandomData(6, ChartSeriesType.Line));
			radChart1.Series.Add(GetRandomData(6, ChartSeriesType.Line));
			radChart1.Refresh();
		}
	}
}