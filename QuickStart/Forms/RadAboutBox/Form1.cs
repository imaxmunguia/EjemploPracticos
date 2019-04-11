using System;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.Themes;

namespace Telerik.Examples.WinControls.Forms.RadAboutBox
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();
            this.radButton1.Click += new EventHandler(radButton1_Click);
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            RadAboutBox1 aboutBox = new RadAboutBox1();

            string selectedTheme = "ControlDefault";
            if (this.radRadioButton2.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                selectedTheme = "Office2010Silver";
            }
            else if (this.radRadioButton3.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                selectedTheme = "Office2010Black";
            }
            else if (this.radRadioButton4.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                selectedTheme = "TelerikMetro";
            }
            else if (this.radRadioButton5.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                selectedTheme = "Desert";
            }

            aboutBox.ThemeName = selectedTheme;
            aboutBox.ShowDialog(this);
        }
    }
}
