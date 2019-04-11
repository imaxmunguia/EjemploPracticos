using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using System.Xml.Serialization;

namespace Telerik.Examples.WinControls.GridView.Theming
{

	public partial class Form1 : ExamplesForm
	{
		public Form1()
		{
			InitializeComponent();
		    this.SelectedControl = this.radGridView1;		
			radGridView1.ShowGroupPanel = true;
            this.radGridView1.EnableHotTracking = true;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
            radGridView1.TableElement.BeginUpdate();
			//populate and bind the datasource
            aggregatesSampleTableTableAdapter.Fill(nwindRadGridView.EmployeeOrders);
			radGridView1.MasterTemplate.AutoExpandGroups = true;
			radGridView1.MasterTemplate.EnableFiltering = true;
            radGridView1.TableElement.EndUpdate(false);
            //TODO
			//radGridView1.MasterTemplate.BestFitColumns();
		}
        
        private void radCheckBox1_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            radGridView1.EnableHotTracking = this.radCheckBox1.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On;
        }

        protected override string GetExampleDefaultTheme()
        {
            return "ControlDefault";
        }
	}
}
