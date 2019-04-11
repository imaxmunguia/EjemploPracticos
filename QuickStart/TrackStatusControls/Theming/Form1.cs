using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;

namespace Telerik.Examples.WinControls.TrackStatusControls.Theming
{
    /// <summary>
    /// Example Beautifying
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
	}
}