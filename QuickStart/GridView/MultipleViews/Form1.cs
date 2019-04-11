using System;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.GridView.MultipleViews
{
    public partial class Form1 : ExamplesForm
    {
        private const string THEME = "ControlDefault";

        #region Fields

        TableViewDefinition tableView;
        ColumnGroupsViewDefinition columnGroupsView;
        HtmlViewDefinition htmlView;

        #endregion

        public Form1()
        {
            InitializeComponent();
            this.SetEnabledQsfbButton(QSFButtons.ChangeTheme, false);
            this.radGridView1.EnableFiltering = true;
            this.radGridView1.ShowFilteringRow = false;
            this.radGridView1.ShowHeaderCellButtons = true;
        }

        private void SetTheme()
        {
        }

        private void InitializeGrid()
        {
            // column groups view
            this.columnGroupsView = new ColumnGroupsViewDefinition();
            this.columnGroupsView.ColumnGroups.Add(new GridViewColumnGroup("General"));
            this.columnGroupsView.ColumnGroups.Add(new GridViewColumnGroup("Details"));
            this.columnGroupsView.ColumnGroups[1].Groups.Add(new GridViewColumnGroup("Address"));
            this.columnGroupsView.ColumnGroups[1].Groups.Add(new GridViewColumnGroup());
            this.columnGroupsView.ColumnGroups[0].Rows.Add(new GridViewColumnGroupRow());
            this.columnGroupsView.ColumnGroups[0].Rows.Add(new GridViewColumnGroupRow());
            this.columnGroupsView.ColumnGroups[0].Rows[0].Columns.Add(this.radGridView1.Columns["CustomerID"]);
            this.columnGroupsView.ColumnGroups[0].Rows[0].Columns.Add(this.radGridView1.Columns["ContactName"]);
            this.columnGroupsView.ColumnGroups[0].Rows[1].Columns.Add(this.radGridView1.Columns["CompanyName"]);
            this.columnGroupsView.ColumnGroups[1].Groups[0].Rows.Add(new GridViewColumnGroupRow());
            this.columnGroupsView.ColumnGroups[1].Groups[0].Rows[0].Columns.Add(this.radGridView1.Columns["City"]);
            this.columnGroupsView.ColumnGroups[1].Groups[0].Rows[0].Columns.Add(this.radGridView1.Columns["Country"]);
            this.columnGroupsView.ColumnGroups[1].Groups[1].Rows.Add(new GridViewColumnGroupRow());
            this.columnGroupsView.ColumnGroups[1].Groups[1].Rows[0].Columns.Add(this.radGridView1.Columns["Phone"]);

            // html view
            this.htmlView = new HtmlViewDefinition();
            this.htmlView.RowTemplate.Rows.Add(new RowDefinition());
            this.htmlView.RowTemplate.Rows[0].Cells.Add(new CellDefinition("CustomerID"));
            this.htmlView.RowTemplate.Rows[0].Cells.Add(new CellDefinition("ContactName"));
            this.htmlView.RowTemplate.Rows[0].Cells.Add(new CellDefinition("City"));
            this.htmlView.RowTemplate.Rows[0].Cells.Add(new CellDefinition("Country"));
            this.htmlView.RowTemplate.Rows[0].Cells[2].RowSpan = 2;
            this.htmlView.RowTemplate.Rows[0].Cells[3].RowSpan = 2;
            this.htmlView.RowTemplate.Rows.Add(new RowDefinition());
            this.htmlView.RowTemplate.Rows[1].Cells.Add(new CellDefinition("CompanyName"));
            this.htmlView.RowTemplate.Rows[1].Cells[0].ColSpan = 2;
        }

        #region Event Handlers

        protected override void OnLoad(EventArgs e)
        {
            ThemeResolutionService.ApplyThemeToControlTree(this, THEME);
            ThemeResolutionService.ApplyThemeToControlTree(this.settingsPanel, THEME);

            this.customersTableAdapter.Fill(this.northwindDataSet.Customers);

            // table view
            this.tableView = (TableViewDefinition)this.radGridView1.ViewDefinition;
            InitializeGrid();
            this.radRadioHTML.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.radGridView1.ViewDefinition = htmlView;
        }

        private void radSpinEditor1_ValueChanged(object sender, EventArgs e)
        {
            this.radGridView1.TableElement.CellSpacing = (int)this.radSpinEditor1.Value;
        }

        private void radSpinEditor2_ValueChanged(object sender, EventArgs e)
        {
            this.radGridView1.TableElement.RowSpacing = (int)this.radSpinEditor2.Value;
        }

        private void radRadioTable_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (this.radRadioGCView.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.radGridView1.ViewDefinition = columnGroupsView;
                this.radGridView1.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.None;
            }

            if (this.radRadioHTML.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.radGridView1.ViewDefinition = htmlView;
                this.radGridView1.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.None;
            }

            if (this.radRadioTable.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.radGridView1.ViewDefinition = tableView;
                this.radGridView1.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            }

            this.radGridView1.TableElement.CellSpacing = (int)radSpinEditor1.Value;
            this.radGridView1.TableElement.RowSpacing = (int)radSpinEditor2.Value;
        }

        #endregion Event Handlers
    }
}
