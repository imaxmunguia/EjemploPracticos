﻿using System;
using System.Collections.Generic;
using System.IO; 
using System.Windows.Forms;
using Telerik.Pivot.Core;
using Telerik.Pivot.Core.ViewModels;

using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;
using Telerik.Pivot.Core.Aggregates;

namespace Telerik.Examples.WinControls.PivotGrid.Settings
{
    public partial class Form1 : ExamplesForm
    {
        private RadPivotGrid pivot;

        bool suspendEvents = false; 
        List<Order2> orders = new List<Order2>();
        LocalDataSourceProvider provider;

        public Form1()
        {
            InitializeComponent();

            this.pivot = new RadPivotGrid();
            this.pivot.Dock = DockStyle.Fill;
            this.Controls.Add(this.pivot);

        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.pivot.GroupDescriptorElementCreating += new GroupDescriptorElementCreatingEventHandler(pivot_GroupDescriptorElementCreating);
            this.LoadData();

            this.provider = new LocalDataSourceProvider() { ItemsSource = orders };

            provider.RowGroupDescriptions.Add(new PropertyGroupDescription() { PropertyName = "Product", GroupComparer = new GroupNameComparer(), SortOrder = Telerik.Pivot.Core.SortOrder.Descending });
            provider.RowGroupDescriptions.Add(new PropertyGroupDescription() { PropertyName = "Promotion", GroupComparer = new GroupNameComparer() });

            provider.ColumnGroupDescriptions.Add(new PropertyGroupDescription() { PropertyName = "Advertisement", GroupComparer = new GroupNameComparer() });
            provider.ColumnGroupDescriptions.Add(new DateTimeGroupDescription() { PropertyName = "Date", Step = DateTimeStep.Month });

            provider.AggregateDescriptions.Add(new PropertyAggregateDescription() { PropertyName = "Quantity", AggregateFunction = AggregateFunctions.Sum });
            provider.AggregateDescriptions.Add(new PropertyAggregateDescription() { PropertyName = "Net", AggregateFunction = AggregateFunctions.Sum });

            provider.AggregatesPosition = PivotAxis.Rows;
            provider.AggregatesLevel = 2;
             
            this.pivot.ColumnGrandTotalsPosition = TotalsPos.First;
            this.pivot.ColumnsSubTotalsPosition = TotalsPos.First;

            this.pivot.RowGrandTotalsPosition = TotalsPos.Last;
            this.pivot.RowsSubTotalsPosition = TotalsPos.First;
            this.pivot.PivotGridElement.UpdateCompleted += new EventHandler(pivotGridElement_DataUpdated);
            this.pivot.PivotGridElement.DataProvider = provider;
        }

        void pivot_GroupDescriptorElementCreating(object sender, GroupDescriptorElementCreatingEventArgs e)
        {
            if (e.GroupDescriptorElement.FieldName == "Product")
            {
                e.GroupDescriptorElement.FilterPopup.PopupOpening += new RadPopupOpeningEventHandler(FilterPopup_PopupOpening);
                e.GroupDescriptorElement.FilterPopup.PopupOpened += new RadPopupOpenedEventHandler(FilterPopup_PopupOpened);
                
            }
        }

        void FilterPopup_PopupOpening(object sender, System.ComponentModel.CancelEventArgs args)
        {
            PivotGroupFilterPopup popup = sender as PivotGroupFilterPopup;
            popup.TreeViewMenuItem.TreeElement.TreeView.SortOrder = System.Windows.Forms.SortOrder.Ascending;           
        }
       
        void FilterPopup_PopupOpened(object sender, EventArgs args)
        {
            PivotGroupFilterPopup popup = sender as PivotGroupFilterPopup;      
            popup.TreeViewMenuItem.TreeElement.TreeView.SortOrder = System.Windows.Forms.SortOrder.None;            
        }

        private void RowGrandTotalChecked(object sender, StateChangedEventArgs e)
        {
            if (this.suspendEvents)
            {
                return;
            }

            if (pivot != null && sender != null)
            {
                this.pivot.RowGrandTotalsPosition = GetPosition(sender);
            }
        }

        private void RowSubTotalChecked(object sender, StateChangedEventArgs e)
        {
            if (this.suspendEvents)
            {
                return;
            }

            if (pivot != null && sender != null)
            {
                this.pivot.RowsSubTotalsPosition = GetPosition(sender);
            }
        }

        private void ColumnGrandTotalChecked(object sender, StateChangedEventArgs e)
        {
            if (this.suspendEvents)
            {
                return;
            }

            if (pivot != null && sender != null)
            {
                this.pivot.ColumnGrandTotalsPosition = GetPosition(sender);
            }
        }

        private void ColumnSubTotalChecked(object sender, StateChangedEventArgs e)
        {
            if (this.suspendEvents)
            {
                return;
            }

            if (pivot != null && sender != null)
            {
                this.pivot.ColumnsSubTotalsPosition = GetPosition(sender);
            }
        }

        private void AggregatesPositionChecked(object sender, StateChangedEventArgs args)
        {
            if (this.suspendEvents)
            {
                return;
            }

            this.provider.AggregatesPosition = (sender == this.aggregatePositionRows) ? PivotAxis.Rows : PivotAxis.Columns;
        }

        private void radSpinEditor1_ValueChanged(object sender, EventArgs e)
        {
            if (this.suspendEvents)
            {
                return;
            }

            if (this.pivot != null)
            {
                provider.AggregatesLevel = (int)this.radSpinEditor1.Value;
            }
        }

        private TotalsPos GetPosition(object sender)
        {
            if (sender == this.rowGrandTotalFirst || sender == this.columnGrandTotalFirst ||
                sender == this.rowSubTotalFirst || sender == this.columnSubTotalFirst)
            {
                return TotalsPos.First;
            }

            if (sender == this.rowGrandTotalLast || sender == this.columnGrandTotalLast ||
                sender == this.rowSubTotalLast || sender == this.columnSubTotalLast)
            {
                return TotalsPos.Last;
            }

            return TotalsPos.None;
        }

        void pivotGridElement_DataUpdated(object sender, EventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate()
            {
                this.suspendEvents = true;

                switch (this.pivot.RowGrandTotalsPosition)
                {
                    case TotalsPos.First:
                        this.rowGrandTotalFirst.IsChecked = true;
                        break;
                    case TotalsPos.Last:
                        this.rowGrandTotalLast.IsChecked = true;
                        break;
                    case TotalsPos.None:
                        this.rowGrandTotalNone.IsChecked = true;
                        break;
                }

                switch (this.pivot.ColumnGrandTotalsPosition)
                {
                    case TotalsPos.First:
                        this.columnGrandTotalFirst.IsChecked = true;
                        break;
                    case TotalsPos.Last:
                        this.columnGrandTotalLast.IsChecked = true;
                        break;
                    case TotalsPos.None:
                        this.columnGrandTotalNone.IsChecked = true;
                        break;
                }

                switch (this.pivot.RowsSubTotalsPosition)
                {
                    case TotalsPos.First:
                        this.rowSubTotalFirst.IsChecked = true;
                        break;
                    case TotalsPos.Last:
                        this.rowSubTotalLast.IsChecked = true;
                        break;
                    case TotalsPos.None:
                        this.rowSubTotalNone.IsChecked = true;
                        break;
                }

                switch (this.pivot.ColumnsSubTotalsPosition)
                {
                    case TotalsPos.First:
                        this.columnSubTotalFirst.IsChecked = true;
                        break;
                    case TotalsPos.Last:
                        this.columnSubTotalLast.IsChecked = true;
                        break;
                    case TotalsPos.None:
                        this.columnSubTotalNone.IsChecked = true;
                        break;
                }

                switch (this.provider.AggregatesPosition)
                {
                    case PivotAxis.Columns:
                        this.aggregatePositionColumns.IsChecked = true;
                        break;
                    case PivotAxis.Rows:
                        this.aggregatePositionRows.IsChecked = true;
                        break;
                }

                this.radSpinEditor1.Value = this.provider.AggregatesLevel;

                this.suspendEvents = false;
            }));
        }

        private void LoadData()
        {
            Stream stream = System.Reflection.Assembly.GetAssembly(this.GetType()).GetManifestResourceStream("Telerik.Examples.WinControls.PivotGrid.Settings.PivotData.txt");

            using (StreamReader streamReader = new StreamReader(stream))
            {
                while (streamReader.Peek() != -1)
                {
                    string[] items = streamReader.ReadLine().Split('\t');
                    Order2 o = new Order2()
                    {
                        Date = DateTime.Parse(items[0], System.Globalization.CultureInfo.InvariantCulture),
                        Product = items[1],
                        Quantity = int.Parse(items[2], System.Globalization.CultureInfo.InvariantCulture),
                        Net = double.Parse(items[3], System.Globalization.CultureInfo.InvariantCulture),
                        Promotion = items[4],
                        Advertisement = items[5]
                    };
                    orders.Add(o);
                }
            }
        }

    }
}
