﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Telerik.Charting;
using Telerik.Examples.WinControls.ChartView.Linear;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;
using System.Drawing;

namespace Telerik.Examples.WinControls.ChartView.Spline
{
    /// <summary>
    /// RadChartView example
    /// </summary>
    public partial class Form1 : ExamplesForm
    {
        private List<SalesRevenue> collection1, collection2;
        private BindingSource lineCombineModes, areaCombineModes;
        private List<string> chartTypes;
        private string selectedChartType;
        private ChartSeriesCombineMode selectedCombineMode;
        private bool showLabels;

        public Form1()
        {
            InitializeComponent();

            InitializeData();

            this.SelectedControl = this.radChartView1;

            this.SetEnabledQsfbButton(QSFButtons.ChangeTheme, false);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.radChartView1.GetArea<CartesianArea>().ShowGrid = true;

            this.radDropDownList1.DataSource = chartTypes;
            this.radDropDownList2.DataSource = lineCombineModes;

            this.radDropDownList1.SelectedValue = "Spline Area";

            CartesianArea area = this.radChartView1.GetArea<CartesianArea>();
            area.ShowGrid = true;
            CartesianGrid grid = area.GetGrid<CartesianGrid>();
            grid.DrawHorizontalStripes = true;
            grid.DrawVerticalStripes = true;
        }

        private void radDropDownList1_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (this.radDropDownList1.SelectedItem != null)
            {
                selectedChartType = this.radDropDownList1.SelectedItem.Text;

                this.radChartView1.Series.Clear();
                this.radChartView1.Axes.Clear();

                UpdateCombineModesDropDown();
                GenerateSeries(selectedChartType);
            }
        }

        private void radDropDownList2_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (this.radDropDownList2.SelectedValue != null)
            {
                selectedCombineMode = (ChartSeriesCombineMode)this.radDropDownList2.SelectedValue;
                UpdateSeriesCombineMode(selectedCombineMode);
            }
        }

        private void radCheckBox1_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            showLabels = args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On ? true : false;
            UpdateLabelsVisibility();
        }

        private void GenerateSeries(string seriesType)
        {
            CategoricalAxis horizontalAxis = new CategoricalAxis();
            LinearAxis verticalAxis = new LinearAxis();
            verticalAxis.AxisType = AxisType.Second;

            for (int i = 0; i < 2; i++)
            {
                CartesianSeries series;
                if (seriesType == "Spline Area")
                {
                    series = new AreaSeries();
                }
                else
                {
                    series = new LineSeries();
                }

                series.PointSize = new SizeF(5, 5);
                series.HorizontalAxis = horizontalAxis;
                series.VerticalAxis = verticalAxis;

                ((LineSeries)series).Spline = true;
                series.BorderWidth = 2;
                series.CategoryMember = "Month";
                series.ValueMember = "Revenue";
                series.DataSource = i == 0 ? collection1 : collection2;
                series.ShowLabels = showLabels;
                series.CombineMode = selectedCombineMode;
                this.radChartView1.Series.Add(series);
            }
        }

        private void UpdateCombineModesDropDown()
        {
            if (selectedChartType == "Spline Area")
            {
                this.radDropDownList2.DataSource = areaCombineModes;
            }
            else
            {
                this.radDropDownList2.DataSource = lineCombineModes;
            }
        }

        private void UpdateSeriesCombineMode(ChartSeriesCombineMode combineMode)
        {
            foreach (CartesianSeries series in this.radChartView1.Series)
            {
                series.CombineMode = combineMode;
            }
        }

        private void UpdateLabelsVisibility()
        {
            foreach (CartesianSeries series in this.radChartView1.Series)
            {
                series.ShowLabels = showLabels;
            }
        }

        private void InitializeData()
        {
            this.collection1 = new List<SalesRevenue>();
            this.collection1.Add(new SalesRevenue("January", 3.5));
            this.collection1.Add(new SalesRevenue("February", 2.8));
            this.collection1.Add(new SalesRevenue("March", 3.4));
            this.collection1.Add(new SalesRevenue("April", 3.2));
            this.collection1.Add(new SalesRevenue("May", 3.4));
            this.collection1.Add(new SalesRevenue("June", 3.7));
            this.collection1.Add(new SalesRevenue("July", 3.1));
            this.collection1.Add(new SalesRevenue("August", 2.9));
            this.collection1.Add(new SalesRevenue("September", 3.3));
            this.collection1.Add(new SalesRevenue("October", 3.1));
            this.collection1.Add(new SalesRevenue("November", 3.6));
            this.collection1.Add(new SalesRevenue("December", 3.7));

            this.collection2 = new List<SalesRevenue>();
            this.collection2.Add(new SalesRevenue("January", 1.5));
            this.collection2.Add(new SalesRevenue("February", 1.7));
            this.collection2.Add(new SalesRevenue("March", 1.4));
            this.collection2.Add(new SalesRevenue("April", 1.6));
            this.collection2.Add(new SalesRevenue("May", 1.8));
            this.collection2.Add(new SalesRevenue("June", 1.5));
            this.collection2.Add(new SalesRevenue("July", 1.5));
            this.collection2.Add(new SalesRevenue("August", 1.7));
            this.collection2.Add(new SalesRevenue("September", 2.1));
            this.collection2.Add(new SalesRevenue("October", 1.6));
            this.collection2.Add(new SalesRevenue("November", 2));
            this.collection2.Add(new SalesRevenue("December", 1.6));

            lineCombineModes = new BindingSource();
            lineCombineModes.Add(ChartSeriesCombineMode.None);
            lineCombineModes.Add(ChartSeriesCombineMode.Stack);

            areaCombineModes = new BindingSource();
            areaCombineModes.Add(ChartSeriesCombineMode.Stack);
            areaCombineModes.Add(ChartSeriesCombineMode.Stack100);

            chartTypes = new List<string>();
            chartTypes.Add("Spline");
            chartTypes.Add("Spline Area");

            showLabels = true;
        }
    }
}
