using System;
using Telerik.WinControls.UI;
using System.Windows.Forms;
using System.Drawing;
using Telerik.WinControls;
using Telerik.Charting;

namespace Telerik.Examples.WinControls.ChartView.FirstLook
{
    public class LegendElement : LightVisualElement
    {
        StackLayoutElement layout;

        protected override void InitializeFields()
        {
            base.InitializeFields();

            this.Alignment = ContentAlignment.MiddleCenter;
            this.DrawFill = true;
            this.BackColor = Color.White;
            this.GradientStyle = GradientStyles.Solid;
            this.Padding = new Padding(5, 5, 5, 0);
            this.Margin = new Padding(0);
            this.MinSize = new Size(100, 0);
            this.StretchVertically = false;
            this.StretchHorizontally = true;
            this.ShouldHandleMouseInput = false;
            this.NotifyParentOnMouseInput = true;
        }

        protected override void CreateChildElements()
        {
            base.CreateChildElements();

            layout = new StackLayoutElement();
            layout.Orientation = Orientation.Vertical;
            layout.FitInAvailableSize = true;
            layout.StretchVertically = true;
            layout.StretchHorizontally = true;
            this.Children.Add(layout);
        }

        public void BuildLegend(RadChartElement element)
        {
            Telerik.WinControls.UI.ChartView view = element.View;
            BuildLegendCore(view);
        }

        void BuildLegendCore(Telerik.WinControls.UI.ChartView view)
        {
            layout.Children.Clear();
            if (view.AreaType == ChartAreaType.Cartesian)
            {
                foreach (Telerik.WinControls.UI.ChartSeries series in view.Series)
                {
                    Color color;
                    if(series is LineSeries)
                    {
                        color = series.BorderColor;
                    }
                    else
                    {
                        color = series.Children[0].BackColor;
                    }
                    layout.Children.Add(new LegendItemElement(series.Name, color));
                }
            }
            if (view.AreaType == ChartAreaType.Pie && view.Series.Count > 0)
            {
                for (int i = 0; i < view.Series[0].DataPoints.Count; i++)
                {
                    Color color = view.Series[0].Children[i].BackColor;
                    PieDataPoint point = view.Series[0].DataPoints[i] as PieDataPoint;
                    layout.Children.Add(new LegendItemElement(point.Name, color));
                }
            }
        }

        protected override SizeF MeasureOverride(SizeF availableSize)
        {
            SizeF size = base.MeasureOverride(availableSize);
            return size;
        }
    }
}
