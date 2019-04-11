using System;
using System.Drawing;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.GridView.CustomFiltering
{
    public partial class Form1 : ExamplesForm
    {
        
        public Form1()
        {
            InitializeComponent();
			
            this.radGridView.EnableHotTracking = true;
            this.radGridView.ShowFilteringRow = false;
            this.radGridView.EnableFiltering = true;
            this.radGridView.EnableCustomFiltering = true;
            
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
			this.customersTableAdapter.Fill(this.nwindRadGridView.Customers);

            this.SelectedControl = this.filterTextBox;
        }

        private void radGridView1_CustomFiltering(object sender, GridViewCustomFilteringEventArgs e)
        {
            if (string.IsNullOrEmpty(this.filterTextBox.Text))
            {
                e.Visible = true;

                for (int i = 0; i < this.radGridView.ColumnCount; i++)
                {
                    e.Row.Cells[i].Style.Reset();
                    e.Row.InvalidateRow();
                }
                return;
            }

            e.Visible = false;
            for (int i = 0; i < this.radGridView.ColumnCount; i++)
            {
                string text = e.Row.Cells[i].Value.ToString();
                if (text.IndexOf(this.filterTextBox.Text, 0, StringComparison.InvariantCultureIgnoreCase) >= 0)
                {
                    e.Visible = true;
                    e.Row.Cells[i].Style.CustomizeFill = true;
                    e.Row.Cells[i].Style.DrawFill = true;
                    e.Row.Cells[i].Style.BackColor = Color.FromArgb(201, 252, 254);
                }
                else
                {
                    e.Row.Cells[i].Style.Reset();
                    e.Row.InvalidateRow();
                }
            }
        }

        protected override string GetExampleDefaultTheme()
        {
            return "ControlDefault";
        }

        private void filterTextBox_TextChanged(object sender, EventArgs e)
        {
            this.radGridView.MasterTemplate.Refresh();
        }
    }
}
