using System.Windows.Forms;
using Telerik.Examples.WinControls.Editors.ComboBox;
using System.Collections;
using System.Globalization;
using Telerik.WinControls.UI;
using Telerik.WinControls;
using System;

namespace Telerik.Examples.WinControls.Editors.MaskTextBox.NumericBehavior
{
	public partial class Form1 : EditorExampleBaseForm
	{
        private const string THEME = "ControlDefault";

		public Form1()
		{
			InitializeComponent();
            this.SetTheme();
            this.LoadCultureInfos();
		}

        private void SetTheme()
        {
            ThemeResolutionService.ApplyThemeToControlTree(this, THEME);
            ThemeResolutionService.ApplyThemeToControlTree(this.settingsPanel, THEME);
        }

        private void LoadCultureInfos()
        {
            SortedList cultures = new SortedList();

			CultureInfo temp;
			for (int i = 0; i < CultureInfo.GetCultures(CultureTypes.SpecificCultures).Length; i++)
			{
				temp = CultureInfo.GetCultures(CultureTypes.SpecificCultures)[i];
				cultures.Add(temp.EnglishName, temp);
			}

			IEnumerator ie = cultures.Keys.GetEnumerator();
			while (ie.MoveNext())
			{
				string name = (string)ie.Current;
				this.radComboCultures.Items.Add(new RadListDataItem(name, cultures[name]/*.ToString()*/));
			}

            radComboCultures.SelectedItem = radComboCultures.Items[radComboCultures.FindStringExact(CultureInfo.CurrentCulture.EnglishName)];
            this.radComboCultures.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(CulturesList_SelectedIndexChanged);
		}

        void CulturesList_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
		{
            foreach (Control control in this.radPanelDemoHolder.Controls)
            {
                if (control is RadMaskedEditBox)
                {
                    RadMaskedEditBox maskEdit = control as RadMaskedEditBox;

                    maskEdit.Culture = (radComboCultures.SelectedValue as CultureInfo);
                    if (maskEdit.MaskType == MaskType.DateTime)
                    {
                        maskEdit.Value = DateTime.Now;
                    }
                }
            }
		}

        private void radTextBox1_TextChanged(object sender, System.EventArgs e)
        {
            this.radMaskedEditBox19.Mask = radTextBox1.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.RadMaskedEditBox1.Value = DateTime.Now;
            this.RadMaskedEditBox2.Value = DateTime.Now;
            this.RadMaskedEditBox3.Value = DateTime.Now;
            this.RadMaskedEditBox4.Value = DateTime.Now;
            this.RadMaskedEditBox5.Value = DateTime.Now;
        }
	}
}