using System;
using System.Drawing;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.Calendar.Navigation
{
	public partial class Form1 : ExamplesForm
	{
		public Form1()
		{
			InitializeComponent();
            SetTheme();
			this.radCalendar1.MultiViewColumns = 1;
			this.radCalendar1.MultiViewColumns = 2;
			
			this.SelectedControl = this.radCalendar1;
   
            this.radCalendar1.RangeMinDate = this.radDateTimePicker1.Value;
            this.radCalendar1.RangeMaxDate = this.radDateTimePicker2.Value;
            this.radDateTimePicker3.Value = DateTime.Now;
        }

        private void SetTheme()
        {
            ThemeResolutionService.ApplyThemeToControlTree(this, "ControlDefault");
            this.radSpinNavigationStep.ForeColor = Color.Black;
        }

		private void radCheckBox1_Click(object sender, EventArgs e)
		{
			this.radCalendar1.ShowNavigationButtons = !(this.radCheckBox1.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On);
		}

		private void radCheckBox2_Click(object sender, EventArgs e)
		{
			this.radCalendar1.ShowFastNavigationButtons = !(this.radCheckBox2.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On);
		}

		private void radCheckBox3_Click(object sender, EventArgs e)
		{
			this.radCalendar1.ShowHeader = !(this.radCheckBox3.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On);
		}

		private void radDateTimePicker1_ValueChanged(object sender, EventArgs e)
		{
			this.radCalendar1.RangeMinDate = this.radDateTimePicker1.Value;
		}

		private void radDateTimePicker2_ValueChanged(object sender, EventArgs e)
		{
			this.radCalendar1.RangeMaxDate = this.radDateTimePicker2.Value;
		}

		private void radDateTimePicker3_ValueChanged(object sender, EventArgs e)
		{
			this.radCalendar1.FocusedDate = this.radDateTimePicker3.Value;
		}

        private void radSpinNavigationStep_ValueChanged(object sender, EventArgs e)
        {
            this.radCalendar1.FastNavigationStep = (int)this.radSpinNavigationStep.Value;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.radCalendar1.RangeMinDate = this.radDateTimePicker1.Value;
            this.radCalendar1.RangeMaxDate = this.radDateTimePicker2.Value;
        }
	}
}