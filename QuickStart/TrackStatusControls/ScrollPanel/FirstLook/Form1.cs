using System;
using Telerik.WinControls.UI;
using Telerik.QuickStart.WinControls;

namespace Telerik.Examples.WinControls.TrackStatusControls.ScrollPanel.FirstLook
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();

            this.SelectedControl = this.radScrollPanelDemo;
            this.EnabledQSFButtons = QSFButtons.LoadTheme | QSFButtons.ControlSpy;
        }

        private void SetHorizontalState(ScrollState newState)
        {
            radScrollPanelDemo.SetHorizontalState(newState);
        }

        private void SetVerticalState(ScrollState newState)
        {
            radScrollPanelDemo.SetVerticalState(newState);
        }

        private void radComboBox1_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            this.radScrollPanelDemo.UsePhysicalScrolling = this.radComboBox1.SelectedIndex == 1;
        }

		private void radButton1_Click(object sender, EventArgs e)
		{
			radScrollPanelDemo.ManageSquare();
		}

		private void radButton2_Click(object sender, EventArgs e)
		{
			radScrollPanelDemo.ManageTriangle();
		}

		private void radButton3_Click(object sender, EventArgs e)
		{
			radScrollPanelDemo.ManageBackground();
		}

		private void radButton4_Click(object sender, EventArgs e)
		{
			radScrollPanelDemo.ScrollToSquare();
		}

		private void radButton5_Click(object sender, EventArgs e)
		{
			radScrollPanelDemo.ScrollToTriangle();
		}

        private void OnHorizontalRadioOption_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (this.radRadioHAlwaysHide.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                SetHorizontalState(ScrollState.AlwaysHide);
            }
            else if (this.radRadioHAlwaysShow.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                SetHorizontalState(ScrollState.AlwaysShow);
            }
            else if (this.radRadioHAutoHide.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                SetHorizontalState(ScrollState.AutoHide);
            }
        }

        private void OnVerticalRadioOption_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (this.radRadioVAlwaysHide.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                SetVerticalState(ScrollState.AlwaysHide);
            }
            else if (this.radRadioVAlwaysShow.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                SetVerticalState(ScrollState.AlwaysShow);
            }
            else if (this.radRadioVAutoHide.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                SetVerticalState(ScrollState.AutoHide);
            }
        }
    }
}