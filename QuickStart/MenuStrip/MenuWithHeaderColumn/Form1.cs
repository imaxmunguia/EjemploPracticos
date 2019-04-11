using System;
using System.Drawing;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;
using Telerik.Examples.WinControls.Properties;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.MenuStrip.MenuWithHeaderColumn
{
    public partial class Form1 : ExamplesForm
    {
        private const string THEME = "ControlDefault";
        public Form1()
        {
            InitializeComponent();
            this.SetEnabledQsfbButton(QSFButtons.ChangeTheme, false);
            ThemeResolutionService.ApplyThemeToControlTree(this, THEME);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.radMenuItem1.DropDown.HeaderText = "RadMenuStrip Header";
            this.radMenuItem1.DropDown.HeaderImage = Resources.telerikLogo1;
            RadDropDownMenuElement popupElement = this.radMenuItem1.DropDown.PopupElement as RadDropDownMenuElement;
            if (popupElement != null)
            {
                popupElement.HeaderColumn.TextImageRelation = TextImageRelation.ImageBeforeText;
                popupElement.HeaderColumnBorder.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
                popupElement.HeaderColumnFill.BackColor = Color.FromArgb(238, 238, 213);
                popupElement.HeaderColumnFill.BackColor2 = Color.FromArgb(153, 208, 221);
                popupElement.HeaderColumnFill.NumberOfColors = 2;
                popupElement.HeaderColumnText.ForeColor = Color.White;
                popupElement.HeaderColumn.TextAlignment = ContentAlignment.MiddleLeft;
                popupElement.HeaderColumnText.Font = new Font("Comic Sans", 16f, FontStyle.Bold);
            }
        }
    }
}
