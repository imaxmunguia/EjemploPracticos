using System.Drawing;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.MenuStrip.MultilineText
{
    public partial class Form1 : ExamplesForm
    {
        private const string THEME = "ControlDefault";

		Size oldSize = Size.Empty;

        public Form1()
        {
            InitializeComponent();
            ThemeResolutionService.ApplyThemeToControlTree(this, THEME);
            this.SetEnabledQsfbButton(QSFButtons.ChangeTheme, false);
        }

    }
}