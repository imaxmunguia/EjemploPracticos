using System.Drawing;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.Calendar.LayoutCustomization
{
	public partial class Form1 : ExamplesForm
	{
		private Size defaultSize;

		public Form1()
		{
			InitializeComponent();
            SetTheme();
			this.defaultSize = this.radCalendar1.Size;
            this.radRadio7Cols.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
		}

        private void SetTheme()
        {
            ThemeResolutionService.ApplyThemeToControlTree(this, "ControlDefault");
        }

        private void CenterCalendar()
        {
            this.radCalendar1.Location = new Point(this.Width / 2 - this.radCalendar1.Width / 2, this.Height / 2 - this.radCalendar1.Height / 2);
        }

        #region Event Handlers
        private void radRadioButton1_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if (this.radRadio7Cols.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.radCalendar1.MonthLayout = Telerik.WinControls.UI.MonthLayout.Layout_7columns_x_6rows;
                this.radCalendar1.Size = this.defaultSize;
            }

            if (this.radRadio14Cols.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.radCalendar1.MonthLayout = Telerik.WinControls.UI.MonthLayout.Layout_14columns_x_3rows;
                this.radCalendar1.Size = new Size(this.defaultSize.Width * 2, this.defaultSize.Height / 2 + 20);
            }

            if (this.radRadio21Cols.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.radCalendar1.MonthLayout = Telerik.WinControls.UI.MonthLayout.Layout_21columns_x_2rows;
                this.radCalendar1.Size = new Size(this.defaultSize.Width * 3, this.defaultSize.Height / 2 + 10);
            }

            CenterCalendar();
        }
        #endregion
    }
}