using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.GridView.CustomRows
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
			// TODO: This line of code loads data into the 'nwindDataSet.Cars' table. You can move, or remove it, as needed.
            this.carsTableAdapter.Fill(this.nwindDataSet.Cars);
         
			radGridView1.DataSource = this.carsBindingSource;
            radGridView1.EnableHotTracking = true;
        }

        protected override string GetExampleDefaultTheme()
        {
            return "ControlDefault";
        }
    }
}