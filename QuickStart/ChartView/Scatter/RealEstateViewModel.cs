using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;
using System.Globalization;

namespace Telerik.Examples.WinControls.ChartView.Scatter
{
    class RealEstateViewModel : INotifyPropertyChanged
    {
        public RealEstateViewModel()
        {
            List<RealEstateData> data = ParseData();
            GetDataCompleted(data);
        }

        private IEnumerable<RealEstateData> apartmentData;
        private IEnumerable<RealEstateData> coOpData;

        public IEnumerable<RealEstateData> ApartmentData
        {
            get
            {
                return this.apartmentData;
            }
            private set
            {
                if (this.apartmentData == value)
                    return;

                this.apartmentData = value;
                this.OnPropertyChanged("ApartmentData");
            }
        }

        public IEnumerable<RealEstateData> CoOpData
        {
            get
            {
                return this.coOpData;
            }
            set
            {
                if (this.coOpData == value)
                    return;

                this.coOpData = value;
                this.OnPropertyChanged("CoOpData");
            }
        }

        public IEnumerable<RealEstateData> GetData(int index)
        {
            if (index == 0)
            {
                return this.CoOpData;
            }

            if (index == 1)
            {
                return this.ApartmentData;
            }

            return null;
        }

        protected void GetDataCompleted(List<RealEstateData> data)
        {
            List<RealEstateData> coOpData = new List<RealEstateData>();
            List<RealEstateData> apartmentData = new List<RealEstateData>();

            foreach (RealEstateData item in data)
            {
                if (item.Type == "co-op")
                {
                    coOpData.Add(item);
                }
                else
                {
                    apartmentData.Add(item);
                }
            }

            this.CoOpData = coOpData;
            this.ApartmentData = apartmentData;
        }

        private List<RealEstateData> ParseData()
        {
            List<RealEstateData> chartData = new List<RealEstateData>();
            char[] separator = {'\r', '\n'};
            string fileContents = Properties.Resources.RealEstateAgency;
            string[] lines = fileContents.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            foreach(string line in lines)
            {
                if (string.IsNullOrEmpty(line))
                    continue;

                string[] data = line.Split(',');
                double sqFeet = double.Parse(data[0], CultureInfo.InvariantCulture);
                double price = double.Parse(data[1], CultureInfo.InvariantCulture);
                string type = data[2];
                RealEstateData realEstateData = new RealEstateData(type, sqFeet, price);
                chartData.Add(realEstateData);
            }
            return chartData;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
