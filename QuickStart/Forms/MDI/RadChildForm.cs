using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.WinControls;
using System.IO;
using System.Reflection;
using System.Diagnostics;

namespace Telerik.Examples.WinControls.Forms.MDI
{
    /// <summary>
    /// example form
    /// </summary>
    public partial class RadChildForm : Telerik.WinControls.UI.RadForm  
    {
        /// <summary>
        /// default constructor
        /// </summary>
        public RadChildForm()
        {
            InitializeComponent();
            this.radStatusBar1.ThemeName = "Desert";
            this.radMenu1.ThemeName = "Desert";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.radProgressBarElement1.PerformStepValue1();
            if (this.radProgressBarElement1.Value1 >= this.radProgressBarElement1.Maximum)
                this.radProgressBarElement1.Value1 = this.radProgressBarElement1.Minimum;
        }

        private void radButtonElement1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for clicking RadButton", "StatusBarClick event", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}