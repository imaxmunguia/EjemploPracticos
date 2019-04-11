using System;

namespace Telerik.Examples.WinControls.ChartView.Linear
{
    public class SalesRevenue
    {
        private string month;
        private double revenue;

        public SalesRevenue(string month, double revenue)
        {
            this.month = month;
            this.revenue = revenue;
        }

        public string Month
        {
            get
            {
                return this.month;
            }
        }

        public double Revenue
        {
            get
            {
                return this.revenue;
            }
        }
    }
}
