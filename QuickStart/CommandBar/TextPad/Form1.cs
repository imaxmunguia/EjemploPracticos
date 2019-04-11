using System;
using System.Drawing;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.CommandBar.TextPad
{
	public partial class Form1: ExamplesForm
	{
		public Form1()
		{
			InitializeComponent();
		}

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.radCommandBar1.ThemeName = "ControlDefault";

            Control parent = (this.Parent ?? this);
            this.panel1.Location = new Point((parent.Width - this.panel1.Width) /2,
                (parent.Height - this.panel1.Height)/2);
            
        }

        private void alignment_ToggleStateChanging(object sender, Telerik.WinControls.UI.StateChangingEventArgs args)
        {
            CommandBarToggleButton senderButton = (sender as CommandBarToggleButton);

            if (args.NewValue == Telerik.WinControls.Enumerations.ToggleState.Off)
            {
                return;
            }

            if (senderButton != radCommandBarToggleButtonItem4)
            {
                radCommandBarToggleButtonItem4.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off;
            }

            if (senderButton != radCommandBarToggleButtonItem5)
            {
                radCommandBarToggleButtonItem5.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off;
            }

            if (senderButton != radCommandBarToggleButtonItem6)
            {
                radCommandBarToggleButtonItem6.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off;
            }

            if (senderButton != radCommandBarToggleButtonItem7)
            {
                radCommandBarToggleButtonItem7.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off;
            }
        }
	}
}
