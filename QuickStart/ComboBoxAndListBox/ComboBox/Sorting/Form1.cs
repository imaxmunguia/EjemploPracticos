using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.QuickStart.WinControls;
using Telerik.Examples.WinControls.Editors.ComboBox;

namespace Telerik.Examples.WinControls.ComboBoxAndListBox.ComboBox.Sorting
{
	public partial class Form1 : EditorExampleBaseForm
	{
        private Timer showDropDownTimeout;

		public Form1()
		{
			InitializeComponent();
            this.showDropDownTimeout = new Timer(this.components);
            this.showDropDownTimeout.Interval = 1000;
            this.showDropDownTimeout.Tick += new EventHandler(showDropDownTimeout_Tick);
            this.showDropDownTimeout.Start();
		}

        void showDropDownTimeout_Tick(object sender, EventArgs e)
        {
            this.radComboDemo.DropDownListElement.TextBox.TextBoxItem.Focus();
            this.radComboDemo.ShowDropDown();
            this.showDropDownTimeout.Stop();
        }

		private void Form1_Load(object sender, EventArgs e)
		{
            this.radComboSortMode.SelectedIndex = this.radComboSortMode.ListElement.FindString("None");

			this.SelectedControl = this.radComboDemo;
		}

		private void comboSortStyle_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
		{
            if (e.Position == -1)
            {
                return;
            }

            switch (radComboSortMode.Items[e.Position].Text)
			{
				case "Ascending":
					radComboDemo.SortStyle = Telerik.WinControls.Enumerations.SortStyle.Ascending;
					break;
				case "Descending":
                    radComboDemo.SortStyle = Telerik.WinControls.Enumerations.SortStyle.Descending;
					break;
				case "None":
                    radComboDemo.SortStyle = Telerik.WinControls.Enumerations.SortStyle.None;
					break;
			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
            RadListDataItem item = new RadListDataItem();
			int num = radComboDemo.Items.Count + 1;
            item.Text = "New item " + num.ToString();
            radComboDemo.Items.Add(item);
			radComboDemo.SelectedItem = item;
            UpdateDropDownList(this.radComboDemo,  new Telerik.WinControls.UI.Data.PositionChangedEventArgs(0));
		}

		private void btnRemove_Click(object sender, EventArgs e)
		{
			if (radComboDemo.SelectedIndex != -1)
			{
				radComboDemo.Items.Remove(radComboDemo.Items[radComboDemo.SelectedIndex]);
                UpdateDropDownList(this.radComboDemo, new Telerik.WinControls.UI.Data.PositionChangedEventArgs(0));
			}
		}

		private void UpdateDropDownList(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
		{
			if (radComboDemo.SelectedIndex != -1)
			{
                radTxtIndex.Text = radComboDemo.SelectedIndex.ToString();
				RadListDataItem item = radComboDemo.SelectedItem;
                radTxtText.Text = item.Text;
			}
			else
			{
                radTxtIndex.Text = string.Empty;
                radTxtText.Text = string.Empty;
			}
		}

        void radComboDemo_SelectedValueChanged(object sender, System.EventArgs e)
        {
            UpdateDropDownList(this.radComboDemo, new Telerik.WinControls.UI.Data.PositionChangedEventArgs(0));
        }


		private void tBoxText_TextChanged(object sender, EventArgs e)
		{
			RadListDataItem item = radComboDemo.SelectedItem;
            if ((item != null) && (item.Text != radTxtText.Text))
			{
				radComboDemo.SelectedItem.Text = radTxtText.Text;
                radComboDemo.SelectedItem = item;
			}
		}
    }
}