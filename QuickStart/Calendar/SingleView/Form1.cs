using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.Calendar.SingleView
{
	public partial class Form1 : ExamplesForm
	{
		public Form1()
		{
			InitializeComponent();
            SetTheme();
			this.SelectedControl = this.radCalendar1;
            this.radRadioRows.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
		}

        private void SetTheme()
        {
            ThemeResolutionService.ApplyThemeToControlTree(this, "ControlDefault");
        }

        private void radRadioRows_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if (this.radRadioRows.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.radCalendar1.Orientation = Orientation.Horizontal;
            }

            if (this.radRadioCols.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.radCalendar1.Orientation = Orientation.Vertical;
            }
        }
	}
}