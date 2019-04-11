using System;
using System.Collections.Generic;
using System.Text;

namespace Telerik.Examples.WinControls.ChartView.Scatter
{
    public class RealEstateData
    {
        private string type;
        private double sqFeet;
        private double price;

        public RealEstateData(string type, double squareFeet, double price)
        {
            this.type = type;
            this.sqFeet = squareFeet;
            this.price = price;
        }

        public string Type
        {
            get
            {
                return this.type;
            }
        }

        public double SquareFeet
        {
            get
            {
                return this.sqFeet;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }
        }

        public double PricePerSqFeet
        {
            get
            {
                return this.Price / this.SquareFeet;
            }
        }
    }

}
