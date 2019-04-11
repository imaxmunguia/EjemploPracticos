using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Data;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.GridView.CreateRowInfo
{
    public partial class AdvanceFilterControl : UserControl
    {
        #region Fields

        private RadGridView gridView;
        private FilterDescriptor advancedFilterDescriptor = new FilterDescriptor(String.Empty, FilterOperator.None, null);

        #endregion

        #region Constructors

        public AdvanceFilterControl()
        {
            InitializeComponent();
            this.radDdlColumns.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(radDdlColumns_SelectedIndexChanged);

        }

        public AdvanceFilterControl(RadGridView template)
            : this()
        {
            this.gridView = template;
        }

        #endregion

        #region Properties

        public RadGridView GridView
        {
            get
            {
                return this.gridView;
            }
            set
            {
                if (this.gridView != value)
                {
                    if (this.gridView != null)
                    {
                        this.gridView.CustomFiltering -= new GridViewCustomFilteringEventHandler(GridView_CustomFiltering);
                    }

                    this.gridView = value;

                    if (this.gridView != null)
                    {
                        this.gridView.CustomFiltering += new GridViewCustomFilteringEventHandler(GridView_CustomFiltering);
                        this.UpdateTheme(this.Controls);
                    }

                    this.InitializeAdvanceView();
                }
            }
        }

        private void UpdateTheme(ControlCollection controls)
        {
            foreach (Control currentControl in controls)
            {
                RadControl current = currentControl as RadControl;
                if (current != null)
                {
                    current.ThemeName = this.gridView.ThemeName;
                    Telerik.WinControls.UI.RadPageView pageView = current as Telerik.WinControls.UI.RadPageView;
                    if (pageView != null)
                    {
                        foreach (RadPageViewPage page in pageView.Pages)
                        {
                            this.UpdateTheme(page.Controls);
                        }
                    }
                }
            }
        }

        #endregion

        #region Methods

        private void InitializeAdvanceView()
        {
            this.radDdlColumns.DataSource = this.gridView.Columns;
            this.radDdlColumns.ValueMember = "Name";
            this.radDdlColumns.DisplayMember = "Name";
        }

        #endregion

        #region Event Handlers

        private void radDdlColumns_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            this.radDropDownButtonOperator.Items.Clear();
            this.rtbValue1.Text = String.Empty;
            this.rtbValue1.Enabled = false;

            if (this.radDdlColumns.SelectedItem != null)
            {
                GridViewDataColumn dataColumn = this.radDdlColumns.SelectedItem.DataBoundItem as GridViewDataColumn;

                this.radDropDownButtonOperator.Enabled = true;
                this.radDropDownButtonOperator.Text = "No Filter";

                this.advancedFilterDescriptor.Operator = FilterOperator.None;
                this.advancedFilterDescriptor.PropertyName = dataColumn.Name;

                List<FilterOperationContext> listContext = FilterOperationContext.GetFilterOperations(dataColumn.DataType);
                foreach (FilterOperationContext context in listContext)
                {
                    RadMenuItem menuItem = new RadMenuItem(context.Name, context.Operator);
                    menuItem.Click += new EventHandler(menuItem_Click);
                    this.radDropDownButtonOperator.Items.Add(menuItem);
                }
            }
            else
            {
                this.radDropDownButtonOperator.Enabled = false;
                this.radDropDownButtonOperator.Text = String.Empty;
            }
        }

        private void menuItem_Click(object sender, EventArgs e)
        {
            RadMenuItem menuItem = sender as RadMenuItem;
            this.radDropDownButtonOperator.Text = menuItem.Text;

            FilterOperator filterOperator = (FilterOperator)menuItem.Tag;
            this.advancedFilterDescriptor.Operator = filterOperator;

            this.rtbValue1.Enabled = filterOperator != FilterOperator.None &&
                                         filterOperator != FilterOperator.IsNull &&
                                         filterOperator != FilterOperator.IsNotNull;
        }

        private void rtbValue1_TextChanged(object sender, EventArgs e)
        {
            if (this.radDdlColumns.SelectedItem != null)
            {
                object value = null;

                if (!String.IsNullOrEmpty(this.rtbValue1.Text))
                {
                    GridViewDataColumn dataColumn = this.radDdlColumns.SelectedItem.DataBoundItem as GridViewDataColumn;
                    value = RadDataConverter.Instance.Parse(dataColumn, rtbValue1.Text);
                }

                this.advancedFilterDescriptor.Value = value;
            }
        }

        private void radBtnAdvanceApply_Click(object sender, EventArgs e)
        {
            this.gridView.EndEdit();

            GridTableElement tableElement = this.gridView.TableElement;
            MasterGridViewTemplate masterTemplate = this.gridView.MasterTemplate;
            tableElement.BeginUpdate();
            this.gridView.EnableCustomFiltering = false;
            masterTemplate.DataView.Refresh();
            tableElement.EndUpdate(false);

            foreach (GridViewRowInfo row in this.gridView.Rows)
            {
                foreach (GridViewCellInfo cell in row.Cells)
                {
                    cell.Style.Reset();
                }
            }

            this.gridView.FilterDescriptors.BeginUpdate();
            this.gridView.FilterDescriptors.Clear();
            FilterDescriptor descriptor = this.advancedFilterDescriptor.Clone() as FilterDescriptor;
            this.gridView.FilterDescriptors.Add(descriptor);
            this.gridView.FilterDescriptors.EndUpdate();
        }

        private void radTextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            this.gridView.EndEdit();

            GridTableElement tableElement = this.gridView.TableElement;
            MasterGridViewTemplate masterTemplate = this.gridView.MasterTemplate;

            tableElement.BeginUpdate();
            this.gridView.FilterDescriptors.Clear();
            this.gridView.EnableCustomFiltering = true;
            masterTemplate.DataView.Refresh();
            tableElement.EndUpdate(false);

            this.gridView.TableElement.ViewElement.UpdateRows(true);
        }

        void GridView_CustomFiltering(object sender, GridViewCustomFilteringEventArgs e)
        {
            string searchPattern = this.radTextBoxSearch.Text; 

            bool isEmptyPattern = String.IsNullOrEmpty(searchPattern);
            e.Visible = isEmptyPattern;

            foreach (GridViewCellInfo cell in e.Row.Cells)
            {
                string value = String.Empty;
                object cellValue = cell.Value;

                if (cellValue != null && !Convert.IsDBNull(cellValue))
                {
                    value = Convert.ToString(cellValue);
                }

                bool contains = false;

                if (!isEmptyPattern)
                {
                    contains = value.Contains(searchPattern);
                    e.Visible |= contains;
                }

                gridView.MasterTemplate.SynchronizationService.SuspendEvent(KnownEvents.RowInvalidated);
                if (contains)
                {
                    cell.Style.CustomizeFill = true;
                    cell.Style.BackColor = Color.FromArgb(201, 252, 254);
                }
                else
                {
                    cell.Style.Reset();
                }
                gridView.MasterTemplate.SynchronizationService.ResumeEvent(KnownEvents.RowInvalidated);
            }
        }

        #endregion
    }
}
