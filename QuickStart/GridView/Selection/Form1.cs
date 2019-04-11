using System;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.GridView.Selection
{
	public partial class Form1 : ExamplesForm
	{
		public Form1()
		{
			InitializeComponent();
            
			this.SelectedControl = this.radGridView1;
		}

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BindGrid();

            this.radGridView1.MultiSelect = true;
            this.radGridView1.EnableHotTracking = true;
            this.radGridView1.SelectionMode = GridViewSelectionMode.FullRowSelect;
            this.radComboSelectionMode.SelectedIndex = 0;
            
            this.LoadInitialSelection();
        }

        private void LoadInitialSelection()
        {
            for (int rowsCount = 0; rowsCount < 10; rowsCount++)
            {
                this.radGridView1.Rows[rowsCount].IsSelected = true;
            }
        }

        private void BindGrid()
        {
            aggregatesSampleTableTableAdapter.Fill(nwindRadGridView.EmployeeOrders);
            this.radGridView1.DataSource = this.aggregatesSampleTableBindingSource;

            this.radGridView1.Columns["UnitPrice"].FormatString = "${0:F2}";
        }

        private void radComboBox1_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
		{
            if (this.radComboSelectionMode.SelectedIndex == 0)
            {
                this.radGridView1.SelectionMode = Telerik.WinControls.UI.GridViewSelectionMode.FullRowSelect;
            }
            else
            {
                this.radGridView1.SelectionMode = Telerik.WinControls.UI.GridViewSelectionMode.CellSelect;
            }
		}

		private void radCheckBox1_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
		{
            this.radGridView1.MultiSelect = this.radCheckMulti.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On;
		}

		private void radCheckBox2_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
		{
            this.radGridView1.TableElement.ShowTranslucentSelectionRectangle = this.radCheckTranslucent.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On;
		}

        private void radCheckBox3_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radGridView1.HideSelection = this.radCheckHideSel.Checked;
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            this.radGridView1.SelectAll();
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            this.radGridView1.ClearSelection();
        }

        protected override string GetExampleDefaultTheme()
        {
            return "ControlDefault";
        }
	}
}