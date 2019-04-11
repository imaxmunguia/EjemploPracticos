using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.Themes.Design;
using Telerik.WinControls;
using System.Xml.XPath;
using System.Xml;
using Telerik.QuickStart.WinControls;
namespace Telerik.Examples.WinControls.TrackStatusControls.ProgressBar.FirstLook
{
    /// <summary>
    /// Example beautifying 
    /// </summary>
    public partial class Form1 : ExamplesForm
    {
		private bool check;
		
		public Form1()
        {
            InitializeComponent();

			this.SelectedControl = this.radProgressBar1;
            this.SetEnabledQsfbButton(QSFButtons.TransparentBackground, false);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (!check)
            {
                if (radProgressBar1.Value1 < radProgressBar1.Maximum)
                {
                    radProgressBar1.Value1++;
                    radProgressBar2.Value1++;
                    radProgressBar4.Value1++;
                    radProgressBar6.Value1++;
                }
                else
                {
                    check = true;
                }
            }
            else
            {
                if (radProgressBar1.Value1 > radProgressBar1.Minimum)
                {
                    radProgressBar1.Value1--;
                    radProgressBar2.Value1--;
                    radProgressBar4.Value1--;
                    radProgressBar6.Value1--;

                }
                else
                {
                    check = false;
                }
            }
        }

        private void radTrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            radProgressBar5.Value1 = (int)this.radTrackBar1.Value * 10;
        }
    }
}