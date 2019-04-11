using System;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.QuickStart.WinControls;

namespace Telerik.Examples.WinControls.MenuStrip.BasicStates
{
    public partial class Form1 : ExamplesForm
    {
        private const string THEME = "ControlDefault";

        public Form1()
        {
            InitializeComponent();
            ThemeResolutionService.ApplyThemeToControlTree(this, THEME);
            this.SetEnabledQsfbButton(QSFButtons.ChangeTheme, false);

        }

        void disableItem_Click(object sender, EventArgs e)
        {
			RadMenuItem item = (RadMenuItem) sender;
			item.Enabled = false;
        }

        void removeItem_Click(object sender, EventArgs e)
        {
			IHierarchicalItem item = (IHierarchicalItem) sender;
			RadMenuItem parentItem = (RadMenuItem) item.ParentItem;
			parentItem.Items.Remove((RadMenuItem)sender);
        }

        void addItem_Click(object sender, EventArgs e)
        {
			RadMenuItem item = new RadMenuItem();
			item.Text = "New " + (sender as RadMenuItem).Text;

			IHierarchicalItem hItem = (IHierarchicalItem) sender;
			RadMenuItemBase parentItem = (RadMenuItemBase) hItem.ParentItem;
			parentItem.Items.Add(item);
        }
    }
}