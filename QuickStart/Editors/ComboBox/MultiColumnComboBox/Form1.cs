using System;
using System.Drawing;
using Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters;
using Telerik.Examples.WinControls.DataSources;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.Data;

namespace Telerik.Examples.WinControls.Editors.ComboBox.MultiColumnComboBox
{
	public partial class Form1 : EditorExampleBaseForm
	{
        private const string THEME = "ControlDefault";

		public Form1()
		{
			InitializeComponent();

			this.SelectedControl = this.radMultiColumnComboBox1;
            this.radMultiColumnComboBox1.AutoSizeDropDownToBestFit = true;

			RadMultiColumnComboBoxElement multiColumnComboElement = this.radMultiColumnComboBox1.MultiColumnComboBoxElement;
			multiColumnComboElement.DropDownSizingMode = SizingMode.UpDownAndRightBottom;
            multiColumnComboElement.DropDownMinSize = new Size(420, 300);

			multiColumnComboElement.EditorControl.MasterTemplate.AutoGenerateColumns = false;

            GridViewTextBoxColumn column = new GridViewTextBoxColumn("CustomerID");
            column.HeaderText = "Customer ID";
			multiColumnComboElement.Columns.Add(column);
			column = new GridViewTextBoxColumn("ContactName");
            column.HeaderText = "Contact Name";
			multiColumnComboElement.Columns.Add(column);
			column = new GridViewTextBoxColumn("ContactTitle");
            column.HeaderText = "Contact Title";
			multiColumnComboElement.Columns.Add(column);
            column = new GridViewTextBoxColumn("Country");
            column.HeaderText = "Country";
			multiColumnComboElement.Columns.Add(column);
			column = new GridViewTextBoxColumn("Phone");
            column.HeaderText = "Phone";
			multiColumnComboElement.Columns.Add(column);

            this.SetTheme();
		}

        void OnTextBoxItem_Click(object sender, EventArgs e)
        {
            this.radMultiColumnComboBox1.MultiColumnComboBoxElement.ShowPopup();
        }

        private void SetTheme()
        {
            this.radMultiColumnComboBox1.ThemeName = THEME;
            this.radCheckAutoFilter.ThemeName = THEME;
            this.radCheckRotate.ThemeName = THEME;
            this.radCheckRTL.ThemeName = THEME;
            this.radGroupSettings.ThemeName = THEME;
        }

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

            NorthwindDataSet nwindDataSet = new NorthwindDataSet();
			CustomersTableAdapter customersTableAdapter = new CustomersTableAdapter();
			customersTableAdapter.Fill(nwindDataSet.Customers);

            this.radMultiColumnComboBox1.DataSource = nwindDataSet.Customers;


            FilterDescriptor descriptor = new FilterDescriptor(this.radMultiColumnComboBox1.DisplayMember, FilterOperator.StartsWith, string.Empty);
            this.radMultiColumnComboBox1.EditorControl.FilterDescriptors.Add(descriptor);
            this.radMultiColumnComboBox1.DropDownStyle = RadDropDownStyle.DropDown;
            // Filtering END
		}



        private void OnCheckBoxRTL_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radMultiColumnComboBox1.RightToLeft = this.radCheckRTL.Checked ? System.Windows.Forms.RightToLeft.Yes : System.Windows.Forms.RightToLeft.No;
        }

        private void OnCheckRotate_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radMultiColumnComboBox1.DblClickRotate = this.radCheckRotate.Checked;
        }

        private void OnCheckAutoFilter_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radMultiColumnComboBox1.AutoFilter = this.radCheckAutoFilter.Checked;
        }

	}
}
