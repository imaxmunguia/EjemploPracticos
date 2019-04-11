using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.Buttons.Theming
{
    /// <summary>
    /// updated the path
    /// </summary>
	public partial class Form1 : ExamplesForm
	{
		public Form1()
		{
			InitializeComponent();			
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			//radTextBox1.NullText = textBox1.Text;
		}

		private void radTextBox2_TextChanging(object sender, Telerik.WinControls.TextChangingEventArgs e)
		{
			
		}

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

		private void radRepeatButton1_ButtonClick(object sender, EventArgs e)
		{
			if (progressBar1.Value < progressBar1.Maximum)
			{
				progressBar1.Increment(1);
			}
			else
			{
				progressBar1.Value = progressBar1.Minimum;
			}
		}

		private void radMenuItem1_Click(object sender, EventArgs e)
		{
			radButton2.RootElement.Children[0].AngleTransform += 10f;
			SetDefaultItem(radMenuItem1);
		}

		private void SetDefaultItem(RadMenuItem item)
		{
			radSplitButton1.DefaultItem = item;
			radSplitButton1.ImageIndex = item.ImageIndex;
			radSplitButton1.Text = item.Text;
		}

		private void radMenuItem2_Click(object sender, EventArgs e)
		{
			radButton2.RootElement.Children[0].AngleTransform -= 10f;
			SetDefaultItem(radMenuItem2);
		}
	}
}