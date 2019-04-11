using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.Layouts;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.GridView.SplitView
{
    public partial class Form1 : ExamplesForm
    {
        #region Constructor

        public Form1()
        {
            InitializeComponent();
        }

        #endregion

        #region Event Handlers

        private void SplitGridControl_Load(object sender, EventArgs e)
        {
            this.order_DetailsTableAdapter.Fill(this.northwindDataSet.Order_Details);
            this.gridView.DataSource = this.northwindDataSet.Order_Details;

            foreach (GridViewDataColumn dataColumn in this.gridView.Columns)
            {
                dataColumn.Width = 100;
            }

            this.gridView.SynchronizeCurrentRowInSplitMode = false;
            this.radRadioButtonVertical.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.gridView.Columns["UnitPrice"].FormatString = "{0:C}";
            this.gridView.Columns["Discount"].FormatString = "{0:0%;0:0%;-}";
        }

        private void radRadioButtonNone_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.gridView.SplitMode = RadGridViewSplitMode.None;
        }

        private void radRadioButtonVertical_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.gridView.SplitMode = RadGridViewSplitMode.Vertical;
        }

        private void radRadioButtonHorizontal_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.gridView.SplitMode = RadGridViewSplitMode.Horizontal;
        }

        #endregion

        protected override string GetExampleDefaultTheme()
        {
            return "ControlDefault";
        }

        private void radCheckBox1_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.gridView.SynchronizeCurrentRowInSplitMode = true;
            }
            else
            {
                this.gridView.SynchronizeCurrentRowInSplitMode = false;
            }
        }
    }
}
