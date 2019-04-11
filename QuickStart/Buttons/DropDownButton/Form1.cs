using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.QuickStart.WinControls;
using Telerik.Examples.WinControls.Properties;
using Telerik.Examples.WinControls.Editors.ComboBox;

namespace Telerik.Examples.WinControls.Buttons.DropDownButton
{
    public partial class Form1 : EditorExampleBaseForm
	{
        private const string THEME = "ControlDefault";

		public Form1()
		{
			InitializeComponent();
            SetTheme();
		}

        private void SetTheme()
        {
            ThemeResolutionService.ApplyThemeToControlTree(this, THEME);
            ThemeResolutionService.ApplyThemeToControlTree(this.settingsPanel, THEME);
        }
	}
}