using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.Themes.Design;
using Telerik.WinControls.UI;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.Primitives;

namespace Telerik.Examples.WinControls.MenuStrip.FirstLook
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();

            base.SetEnabledQsfbButton(QSFButtons.ChangeTheme, false);
            this.radMenu1.MenuElement.MenuBorder.Visibility = ElementVisibility.Hidden;
			this.SelectedControl = radMenu1;
            this.radMenu1.MenuElement.MenuFill.Visibility = ElementVisibility.Collapsed;
        }

        //protected override void OnLoad(EventArgs e)
        //{
        //    ThemeResolutionService.ApplyThemeToControlTree(this.settingsPanel, MainForm.DefaultTheme);
        //}

		private void radMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("The Menu item '" + (sender as RadMenuItemBase).Text + "' is clicked.");
		}
		
		private RadButtonElement selectedButton = null;
		private Color oldBorderColor = Color.FromArgb(115, 146, 189);

		private void radButton1_Click(object sender, EventArgs e)
		{
			ClassSelector selector = new ClassSelector("ButtonBorder");
			BorderPrimitive border;
			
			if(this.selectedButton != null)
			{
				border = (BorderPrimitive)selector.GetSelectedElements(this.selectedButton).First.Value;
				border.ForeColor = this.oldBorderColor;
			}

			this.selectedButton = (sender as RadButton).ButtonElement;

            border = (BorderPrimitive)selector.GetSelectedElements(this.selectedButton).First.Value;
			border.ForeColor = Color.Red;
			
			this.menuBurn.Enabled = true;
			this.menuEmail.Enabled = true;
			this.menuOpenWidth.Enabled = true;
			this.menuPrint.Enabled = true;
		}
    }
}