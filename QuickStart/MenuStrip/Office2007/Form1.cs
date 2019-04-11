using Telerik.QuickStart.WinControls;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.MenuStrip.Office2007
{
    public partial class Form1 : ExamplesForm
    {
        private const string THEME = "ControlDefault";

        public Form1()
        {
            InitializeComponent();

            this.radMenuItem4.ShowArrow = true;
            this.radMenuItem5.ShowArrow = true;
            this.radMenuItem6.ShowArrow = true;
            this.radMenuItem7.ShowArrow = true;
            this.radMenuItem8.ShowArrow = true;

            ThemeResolutionService.ApplyThemeToControlTree(this, THEME);
            this.SetEnabledQsfbButton(QSFButtons.ChangeTheme, false);
        }
    }
}