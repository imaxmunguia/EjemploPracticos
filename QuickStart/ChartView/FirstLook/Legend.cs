using System;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using System.Drawing;

namespace Telerik.Examples.WinControls.ChartView.FirstLook
{
    public class Legend: RadControl
    {
        LegendElement legendElement;

        public Legend()
        { }

        protected override void CreateChildItems(RadElement parent)
        {
            base.CreateChildItems(parent);
            legendElement = new LegendElement();
            parent.Children.Add(legendElement);

            this.BackColor = Color.White;
        }

        public void BuildLegend(RadChartElement element)
        {
            this.legendElement.BuildLegend(element);
        }
    }
}
