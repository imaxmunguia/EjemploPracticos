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
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.TrackStatusControls.TrackBar.FirstLook
{
	public partial class Form1 : EditorExampleBaseForm
	{
		public Form1()
		{
			InitializeComponent();
            
            this.radVerticalTrackbar.Value = (this.radPanelDemoHolder.PanelElement.Shape as RoundRectShape).Radius;
		}

        private void OnVerticalTrackBar_Scroll(object sender, EventArgs e)
        {
            (this.radPanelDemoHolder.PanelElement.Shape as RoundRectShape).Radius = this.radVerticalTrackbar.Value;
            this.radPanelDemoHolder.Invalidate();
        }

        private void OnHorizontalTrackBar_Scroll(object sender, EventArgs e)
        {
            this.radPanelDemoHolder.PanelElement.Margin = new Padding(this.radHorizontalTrackBar.Value);
        }
	}
}