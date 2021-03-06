using Telerik.Examples.WinControls.Editors.ComboBox;
using Telerik.WinControls.Enumerations;

namespace Telerik.Examples.WinControls.Buttons.ToggleButton
{
	/// <summary>
	/// Main class for the toggle button example
	/// </summary>
    public partial class Form1 : EditorExampleBaseForm
    {
        public Form1()
        {
            InitializeComponent();
            SetTheme();
        }

        private void SetTheme()
        {
            this.radToggleButton6.ThemeName = "ControlDefault";
        }

        private void radToggleButton6_ToggleStateChanging(object sender, Telerik.WinControls.UI.StateChangingEventArgs args)
        {
			if (!(radToggleButton6.ToggleState == ToggleState.On))
			{
				radToggleButton6.ImageIndex = 4;
				label1.Text = "Button Toggled On";
			}
			else
			{
				radToggleButton6.ImageIndex = 3;
				label1.Text = "Button Toggled Off";
			}
        }
    }
}