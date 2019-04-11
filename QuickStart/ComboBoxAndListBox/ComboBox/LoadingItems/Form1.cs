using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;
using System.Collections;
using Telerik.Examples.WinControls.Editors.ComboBox;
using System.Diagnostics;

namespace Telerik.Examples.WinControls.ComboBoxAndListBox.ComboBox.LoadingItems
{
	/// <summary>
	/// This example demonstrates the capability of <strong>RadComboBox</strong> to handle large numbers of items.
	/// </summary>
	public partial class Form1 : EditorExampleBaseForm
	{
		public Form1()
		{
			InitializeComponent();
			this.SelectedControl = this.radComboDemo;
            this.radComboDemo.DropDownMinSize = new Size(this.radComboDemo.Width, 280);
        }

		private void radBtnLoad_Click(object sender, EventArgs e)
		{
            radComboDemo.ListElement.BeginUpdate();

			radComboDemo.Items.Clear();

            radComboDemo.CloseDropDown();

            radProgressBar.Value1 = 0;
            int count = GetItemsCount();
            int delta = count / 10;

			this.radProgressBar.Maximum = count;

            Stopwatch watch = new Stopwatch();

            watch.Start();
            for (int i = 0; i < count; i++)
			{
                radComboDemo.Items.Add(new RadListDataItem("item" + i.ToString()));

				this.radProgressBar.Value1++;

                if ((i % delta) == 0)
                {
                    //Causes the app to redraw the progress bar
                    Application.DoEvents();
                }
			}

            radComboDemo.ListElement.EndUpdate();

            watch.Stop();
            radLabelElapsed.Size = new Size(100, 20);
			radLabelElapsed.Text = "Time elapsed: " + watch.ElapsedMilliseconds.ToString() + " ms";

            radComboDemo.SelectedIndex = count - 1;

            this.radComboDemo.DropDownListElement.TextBox.TextBoxItem.Focus();
            this.radComboDemo.ShowDropDown();
		}

		private int GetItemsCount()
        {
            if (radRadio500.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                return 500;
            }
            else if (radRadio1000.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                return 1000;
            }
            else if (radRadio2000.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                return 2000;
            }
            else if (radRadio5000.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                return 5000;
            }
            return 1000;
        }
    }
}
