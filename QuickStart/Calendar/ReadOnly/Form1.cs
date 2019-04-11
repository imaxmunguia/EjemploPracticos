using Telerik.QuickStart.WinControls;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.Calendar.ReadOnly
{
	public partial class Form1 : ExamplesForm
	{
		public Form1()
		{
			InitializeComponent();
            SetTheme();
			this.SelectedControl = this.radCalendar1;
            this.radCheckReadOnly.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
		}

        private void SetTheme()
        {
            ThemeResolutionService.ApplyThemeToControlTree(this, "ControlDefault");
        }

        private void radCheckReadOnly_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            this.radCalendar1.ReadOnly = this.radCheckReadOnly.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On;
        }
	}
}