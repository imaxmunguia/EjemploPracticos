using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;
using Telerik.Examples.WinControls.Editors.ComboBox;

namespace Telerik.Examples.WinControls.Buttons.CheckBoxes
{
    public partial class Form1 : EditorExampleBaseForm
    {
        const string initialTheme = "ControlDefault";
        public Form1()
        {
            InitializeComponent();
            SetTheme();
            this.radCheckBox1.Font = new Font(new FontFamily("Arial"), 10.0f, GraphicsUnit.Point);
            this.radCheckBox2.Font = new Font(new FontFamily("Arial"), 12.0f, GraphicsUnit.Point);
            this.radCheckBox3.Font = new Font(new FontFamily("Arial"), 14.0f, GraphicsUnit.Point);
            this.radGroupEvents.ForeColor = Color.Black;
        }

        private void SetTheme()
        {
            this.radGroupEvents.ThemeName = initialTheme;
            this.radTextBoxEvents.ThemeName = initialTheme;
            this.radCheckBox1.ThemeName = initialTheme;
            this.radCheckBox2.ThemeName = initialTheme;
            this.radCheckBox3.ThemeName = initialTheme;
        }

		private void radCheckBox1_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
		{
			this.radTextBoxEvents.Text += string.Format("{0} toggled" + Environment.NewLine, (sender as RadCheckBox).Text);
            this.radTextBoxEvents.SelectionStart = this.radTextBoxEvents.Text.Length;
            this.radTextBoxEvents.ScrollToCaret();
		}
    }
}