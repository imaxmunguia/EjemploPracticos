using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;

namespace Telerik.Examples.WinControls.ListView.Settings
{
    public partial class Form1 : ListViewExamplesControl
    {
        public Form1()
        {
            InitializeComponent();

            this.radGroupBoxDetailView.Visible = false;
            this.radGroupBoxIconView.Visible = false;
            this.radGroupBoxIconView.Location = this.radGroupBoxDetailView.Location;

            SyncSettings();

         
        }

        private void radDropDownListViewType_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            switch (this.radDropDownListViewType.Text)
            {
                case "List View":
                    this.radListView1.ViewType = Telerik.WinControls.UI.ListViewType.ListView;
                    break;
                case "Icon View":
                    this.radListView1.ViewType = Telerik.WinControls.UI.ListViewType.IconsView;
                    break;
                case "Detail View":
                    this.radListView1.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView;
                    break;
            }
        }

        private void radCheckBoxShowCheckboxes_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            this.radListView1.ShowCheckBoxes = this.radCheckBoxShowCheckboxes.Checked;
        }

        private void radCheckBoxGroups_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            this.radListView1.ShowGroups = this.radCheckBoxGroups.Checked;
        }

        private void radCheckBoxArbWidth_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            this.radListView1.AllowArbitraryItemWidth = this.radCheckBoxArbWidth.Checked;
        }

        private void radCheckBoxArbHeight_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            this.radListView1.AllowArbitraryItemHeight = this.radCheckBoxArbHeight.Checked;
        }

        private void radCheckBoxFullRowSelect_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            this.radListView1.FullRowSelect = this.radCheckBoxFullRowSelect.Checked;
        }

        private void radCheckBoxColHeaders_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            this.radListView1.ShowColumnHeaders = this.radCheckBoxColHeaders.Checked;
        }

        private void radCheckBoxColResize_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            this.radListView1.AllowColumnResize = this.radCheckBoxColResize.Checked;
        }

        private void radCheckBoxColReorder_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            this.radListView1.AllowColumnReorder = this.radCheckBoxColReorder.Checked;
        }

        private void radCheckBoxColSort_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            this.radListView1.EnableColumnSort = this.radCheckBoxColSort.Checked;
        }

        private void radSpinEditorHeaderHeight_ValueChanged(object sender, EventArgs e)
        {
            this.radListView1.HeaderHeight = (float)this.radSpinEditorHeaderHeight.Value;
        }

        private void radSpinEditorGroupIndent_ValueChanged(object sender, EventArgs e)
        {
            this.radListView1.GroupIndent = (int)this.radSpinEditorGroupIndent.Value;
        }

        private void radSpinEditorItemSpacing_ValueChanged(object sender, EventArgs e)
        {
            this.radListView1.ItemSpacing = (int)this.radSpinEditorItemSpacing.Value;
        }
         
        private void radSpinEditorItemWidth_ValueChanged(object sender, EventArgs e)
        {
            this.radListView1.ItemSize = new Size((int)this.radSpinEditorItemWidth.Value, this.radListView1.ItemSize.Height);
        }

        private void radSpinEditorItemHeight_ValueChanged(object sender, EventArgs e)
        {
            this.radListView1.ItemSize = new Size(this.radListView1.ItemSize.Width, (int)this.radSpinEditorItemHeight.Value);
        } 

        private void radSpinEditorGroupHeight_ValueChanged(object sender, EventArgs e)
        {
            this.radListView1.GroupItemSize = new Size(this.radListView1.GroupItemSize.Width, (int)this.radSpinEditorGroupHeight.Value);
        }

        private void radDropDownList2_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if(this.radListView1.ViewType == Telerik.WinControls.UI.ListViewType.IconsView)
            {
                this.radListView1.ListViewElement.ViewElement.Orientation = (this.radDropDownList2.Text == "Vertical") ?
                    Orientation.Vertical : Orientation.Horizontal;
            }
        }

        private void radListView1_ViewTypeChanged(object sender, EventArgs e)
        {
            this.radGroupBoxDetailView.Visible = false;
            this.radGroupBoxIconView.Visible = false;

            if (this.radListView1.ViewType == Telerik.WinControls.UI.ListViewType.DetailsView)
            {
                this.radGroupBoxDetailView.Visible = true;
                this.radListView1.ItemSize = new Size(200, 32);
            }
            if (this.radListView1.ViewType == Telerik.WinControls.UI.ListViewType.IconsView)
            {
                this.radGroupBoxIconView.Visible = true;
                this.radListView1.ItemSize = new Size(155, 46);
            }
            if (this.radListView1.ViewType == Telerik.WinControls.UI.ListViewType.ListView)
            {
                this.radListView1.ItemSize = new Size(200, 32);
            }

            SyncSettings();
        }
        
        private void SyncSettings()
        {
            this.radCheckBoxArbWidth.Checked = this.radListView1.AllowArbitraryItemWidth;
            this.radCheckBoxArbHeight.Checked = this.radListView1.AllowArbitraryItemHeight;
            this.radCheckBoxFullRowSelect.Checked = this.radListView1.FullRowSelect;

            this.radSpinEditorItemSpacing.Value = this.radListView1.ItemSpacing;
            this.radSpinEditorGroupIndent.Value = this.radListView1.GroupIndent;
            
            this.radSpinEditorItemWidth.Value = this.radListView1.ItemSize.Width;
            this.radSpinEditorItemHeight.Value = this.radListView1.ItemSize.Height;

            this.radSpinEditorGroupHeight.Value = this.radListView1.GroupItemSize.Height;
        }

        public override Control ContentControl
        {
            get
            {
                return this.radPanel2;
            }
        }
    }
}
