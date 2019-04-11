using System;
using System.Collections.Generic;
using System.Drawing;
using Telerik.Charting;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.Tests;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.ChartView.Scatter
{
    /// <summary>
    /// RadChartView example
    /// </summary>
    public partial class Form1 : ExamplesForm
    {
        private CustomShape customShape;
        private ShapedForm shapedForm = new ShapedForm();

		public Form1()
		{
			InitializeComponent();

			this.SelectedControl = this.radChartView1;

            CartesianArea area = this.radChartView1.GetArea<CartesianArea>();
            area.ShowGrid = true;
            CartesianGrid grid = area.GetGrid<CartesianGrid>();
            grid.DrawHorizontalStripes = true;
            grid.DrawVerticalStripes = true;

            InitializeChartAxes();

            this.SetEnabledQsfbButton(QSFButtons.ChangeTheme, false);
		}

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            RealEstateViewModel model = new RealEstateViewModel();

            LinearAxis[] axes = this.radChartView1.Axes.Get<LinearAxis>();

            for (int i = 0; i < 2; i++)
            {
                ScatterSeries series = new ScatterSeries();
                series.Name = (i == 0) ? "Apartment" : "Coop";
                series.HorizontalAxis = axes[0];
                series.VerticalAxis = axes[1];

                series.DataSource = model.GetData(i);
                series.XValueMember = "SquareFeet";
                series.YValueMember = "PricePerSqFeet";
                series.PointSize = new SizeF(6f, 6f);
                this.radChartView1.Series.Add(series);
            }

            this.Initialize();
        }

        private List<PointF> CreateInitialShape(int vertices, double radius1, double radius2)
        {
            List<PointF> pts = new List<PointF>();

            if (radius1 == 0) return null;

            if (radius2 == 0) return null;

            for (int i = 0; i < vertices; i++)
            {
                double angle1 = ((4.0 * i - vertices) * Math.PI) / (2.0f * vertices);
                double angle2 = ((4.0 * i - vertices + 2) * Math.PI) / (2.0f * vertices);
                pts.Add(new PointF((float)(Math.Cos(angle1) * radius1), (float)(Math.Sin(angle1) * radius1)));
                pts.Add(new PointF((float)(Math.Cos(angle2) * radius2), (float)(Math.Sin(angle2) * radius2)));
            }
            return pts;
        }

        private void Initialize()
        {
            this.customShape = new CustomShape();
            this.customShape.CreateClosedShape(CreateInitialShape(5, 100, 60));

            RadListDataItem item = new RadListDataItem("CustomShape");
            item.Value = typeof(CustomShape);
            this.radDropDownListShapes.Items.Add(item);
            item = new RadListDataItem("RoundRectShape");
            item.Value = typeof(RoundRectShape);
            this.radDropDownListShapes.Items.Add(item);
            item = new RadListDataItem("EllipseShape");
            item.Value = typeof(EllipseShape);
            this.radDropDownListShapes.Items.Add(item);
            item = new RadListDataItem("DonutShape");
            item.Value = typeof(DonutShape);
            this.radDropDownListShapes.Items.Add(item);
            this.radDropDownListShapes.SelectedIndex = 0;

            this.radDropDownListShapes.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(radDropDownListShapes_SelectedIndexChanged);
            this.radDropDownListSeries.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(radDropDownListSeries_SelectedIndexChanged);

            for (int i = 0; i < this.radChartView1.Series.Count; i++)
			{
                item = new RadListDataItem("Series " + (i + 1));
                item.Value = this.radChartView1.Series[i];
                this.radDropDownListSeries.Items.Add(item);
            }

            this.radDropDownListSeries.SelectedIndex = 0;
            this.radDropDownListShapes.SelectedIndex = 2;

            this.radSpinEditorPointRadius.Value = (decimal)this.radChartView1.Series[0].PointSize.Width;
        }

        private void InitializeChartAxes()
        {
            CartesianArea area = this.radChartView1.GetArea<CartesianArea>();

            LinearAxis horizontalAxis = new LinearAxis();
            horizontalAxis.LabelFitMode = AxisLabelFitMode.MultiLine;
            horizontalAxis.Title = "Property Area (sq.ft.)";
            horizontalAxis.Minimum = 450;
            horizontalAxis.Maximum = 2550;
            horizontalAxis.MajorStep = 150;
            area.Axes.Add(horizontalAxis);

            LinearAxis verticalAxis = new LinearAxis();
            verticalAxis.AxisType = AxisType.Second;
            verticalAxis.Title = "Price (USD) per sq. ft.";
            verticalAxis.Minimum = 1;
            verticalAxis.Maximum = 9;
            area.Axes.Add(verticalAxis);
        }

        private void ApplyShapeToPoints(ElementShape shape)
        {
            ScatterSeries series = this.radDropDownListSeries.SelectedValue as ScatterSeries;

            foreach (ScatterPointElement point in series.Children)
            {
                point.Shape = shape;
            }
        }

        private void radButtonEditShape_Click(object sender, EventArgs e)
        {
            if (this.radDropDownListShapes.SelectedIndex == 0)
            {
                CustomShapeEditorForm editor = new CustomShapeEditorForm();
                this.customShape = editor.EditShape(this.customShape);
                this.ApplyShapeToPoints(this.customShape);
            }
        }

        private void radSpinEditor1_ValueChanged(object sender, EventArgs e)
        {
            ScatterSeries series = this.radDropDownListSeries.SelectedValue as ScatterSeries;

            series.PointSize = new SizeF((float)this.radSpinEditorPointRadius.Value, (float)this.radSpinEditorPointRadius.Value);
        }

        private void radDropDownListSeries_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            ScatterSeries series = this.radDropDownListSeries.SelectedValue as ScatterSeries;
            ScatterPointElement point = series.Children[0] as ScatterPointElement;
            this.radSpinEditorPointRadius.Value = (decimal)series.PointSize.Width;

            Type shapeType;

            if (point.Shape == null)
            {
                shapeType = typeof(EllipseShape);
            }
            else
            {
                shapeType = point.Shape.GetType();
            }

            this.radDropDownListShapes.SelectedValue = shapeType;
            this.radGroupBox1.HeaderText = this.radDropDownListSeries.SelectedItem.Text + " Settings";
        }

        private void radDropDownListShapes_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            switch (this.radDropDownListShapes.SelectedIndex)
            {
                case 0:
                    this.ApplyShapeToPoints(this.customShape);
                    this.radButtonEditShape.Enabled = true;
                    break;
                case 1:
                    this.ApplyShapeToPoints(new RoundRectShape(2));
                    this.radButtonEditShape.Enabled = false;
                    break;
                case 2:
                    this.ApplyShapeToPoints(new EllipseShape());
                    this.radButtonEditShape.Enabled = false;
                    break;
                case 3:
                    this.ApplyShapeToPoints( new DonutShape());
                    this.radButtonEditShape.Enabled = false;
                    break;
                case 4:
                    this.ApplyShapeToPoints(new TabOffice12Shape());
                    this.radButtonEditShape.Enabled = false;
                    break;
                case 5:
                    this.ApplyShapeToPoints(new TabVsShape());
                    this.radButtonEditShape.Enabled = false;
                    break;
            }
        }
	}
}

