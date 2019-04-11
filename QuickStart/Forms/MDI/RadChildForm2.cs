using System;
using System.Windows.Forms;

namespace Telerik.Examples.WinControls.Forms.MDI
{
    public partial class RadChildForm2 : Telerik.WinControls.UI.RadForm  
    {
       public RadChildForm2()
        {
            InitializeComponent();
            this.radStatusBar1.ThemeName = "Desert";
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
