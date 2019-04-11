using System;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.MenuStrip.ApplicationMenu
{
    public partial class Form1 : ExamplesForm
    {
        private const string THEME = "ControlDefault";
        private Timer showDropDownTimeout;

        public Form1()
        {
            InitializeComponent();
            this.SelectedControl = this.radAppMenuDemo;
            ThemeResolutionService.ApplyThemeToControlTree(this, THEME);
            this.showDropDownTimeout = new Timer();
            this.showDropDownTimeout.Tick += new EventHandler(showDropDownTimeout_Tick);
            this.showDropDownTimeout.Interval = 1000;
            this.SetEnabledQsfbButton(QSFButtons.ChangeTheme, false);
        }

        void showDropDownTimeout_Tick(object sender, EventArgs e)
        {
            if (!this.IsDisposed && !this.radAppMenuDemo.IsDisposed)
            {
                this.showDropDownTimeout.Stop();
                this.radAppMenuDemo.Focus();
                this.radAppMenuDemo.ShowDropDown();

            }
            else
            {
                this.showDropDownTimeout.Stop();
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.showDropDownTimeout.Start();
            foreach (RadMenuItemBase item in this.radAppMenuDemo.Items)
                if (item is RadMenuItem)
                {
                    ((RadMenuItem)item).Layout.Margin = new Padding(-3);
                }

        }
    }
}
