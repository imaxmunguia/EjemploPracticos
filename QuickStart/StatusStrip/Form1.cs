using System;
using System.Windows.Forms;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.StatusStrip
{
    /// <summary>
    /// example form
    /// </summary>
    public partial class Form1 : Telerik.WinControls.UI.ShapedForm  
    {
        /// <summary>
        /// default constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            this.Shape = new RoundRectShape(5);
            this.Padding = new Padding(1, 1, 1, 0);
            this.radSplitButtonElement1.GetChildAt(1).GetChildAt(0).GetChildAt(2).AutoSize = true;

            this.timer1.Start();
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