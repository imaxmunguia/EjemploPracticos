using System;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.Enumerations;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.TrackStatusControls.ProgressBar.WaitingBars
{
	public partial class Form1: ExamplesForm
	{
        int step;
                
		public Form1()
		{
			InitializeComponent();

            this.SetEnabledQsfbButton(QSFButtons.TransparentBackground, false);
            ExamplesForm.FillComboFromEnum(this.radDropDownList1, typeof(WaitingBarStyles), WaitingBarStyles.Indeterminate);
            this.radDropDownList1.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(radDropDownList1_SelectedIndexChanged);
		}

        void ShowWarningBox()
        {
            
            if (object.Equals(this.radDropDownList1.SelectedItem.Value, WaitingBarStyles.Dash))
            {
               step = (radWaitingBar1.WaitingBarElement.SeparatorElement.StepWidth + this.radWaitingBar1.WaitingBarElement.SeparatorElement.SeparatorWidth) / 2;            
               if (this.radSpinEditor1.Value >= step)
               {
                   RadMessageBox.Show(this, "The selected Waiting Step value is not meaningful in Dash style! Please input a value less than " + step.ToString() + ".", "Change Waiting Step Value");
               }
               if (this.radSpinEditor1.Value >= step)
               {
                   this.radSpinEditor1.Value = step - 1;
               }
            }
        }

        void radDropDownList1_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            WaitingBarStyles style = (WaitingBarStyles)this.radDropDownList1.SelectedItem.Value;
            this.radWaitingBar1.WaitingStyle = style;
            this.radWaitingBar2.WaitingStyle = style;
            this.radWaitingBar3.WaitingStyle = style;
            this.radWaitingBar4.WaitingStyle = style;
            ShowWarningBox();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.radWaitingBar1.StartWaiting();
            this.radWaitingBar2.StartWaiting();
            this.radWaitingBar3.StartWaiting();
            this.radWaitingBar4.StartWaiting();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            this.radWaitingBar1.StartWaiting();
            this.radWaitingBar2.StartWaiting();
            this.radWaitingBar3.StartWaiting();
            this.radWaitingBar4.StartWaiting();
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            this.radWaitingBar1.StopWaiting();
            this.radWaitingBar2.StopWaiting();
            this.radWaitingBar3.StopWaiting();
            this.radWaitingBar4.StopWaiting();
        }

        private void radButton3_Click(object sender, EventArgs e)
        {
            this.radWaitingBar1.ResetWaiting();
            this.radWaitingBar2.ResetWaiting();
            this.radWaitingBar3.ResetWaiting();
            this.radWaitingBar4.ResetWaiting();
        }

        private void radSpinEditor1_ValueChanged(object sender, EventArgs e)
        {
            int step = Convert.ToInt32(this.radSpinEditor1.Value);
            this.radWaitingBar1.WaitingStep = step;
            this.radWaitingBar2.WaitingStep = step;
            this.radWaitingBar3.WaitingStep = step;
            this.radWaitingBar4.WaitingStep = step;
            ShowWarningBox();
        }

        private void radSpinEditor2_ValueChanged(object sender, EventArgs e)
        {
            int speed = Convert.ToInt32(this.radSpinEditor2.Value);
            this.radWaitingBar1.WaitingSpeed = speed;
            this.radWaitingBar2.WaitingSpeed = speed;
            this.radWaitingBar3.WaitingSpeed = speed;
            this.radWaitingBar4.WaitingSpeed = speed;
        }

        private void radToggleButton1_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if (args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.radWaitingBar1.ShowText = true;
                this.radWaitingBar2.ShowText = true;
                this.radWaitingBar3.ShowText = true;
                this.radWaitingBar4.ShowText = true;
            }
            else 
            {
                this.radWaitingBar1.ShowText = false;
                this.radWaitingBar2.ShowText = false;
                this.radWaitingBar3.ShowText = false;
                this.radWaitingBar4.ShowText = false;
            }
        }

        private void radToggleButton2_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if (args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.radWaitingBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
                this.radWaitingBar2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
                this.radWaitingBar3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
                this.radWaitingBar4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            }
            else
            {
                this.radWaitingBar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
                this.radWaitingBar2.RightToLeft = System.Windows.Forms.RightToLeft.No;
                this.radWaitingBar3.RightToLeft = System.Windows.Forms.RightToLeft.No;
                this.radWaitingBar4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            }
        }

	}
}
