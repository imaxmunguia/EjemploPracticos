using System;
using Telerik.QuickStart.WinControls;
using System.Collections;
using System.Globalization;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.Editors.MaskTextBox.Globalization
{
	/// <summary>
	/// Represents a globalization example of mask box
	/// </summary>
	public partial class Form1 : ExamplesForm
	{
        private const string THEME = "ControlDefault";

		public Form1()
		{
			InitializeComponent();

			this.Load += new EventHandler(Form1_Load);

			this.SelectedControl = this.radMaskedEditDateTime;
            this.SetTheme();
		}

        private void SetTheme()
        {
            this.radLblCulture.ThemeName = THEME;
            this.radLblFullDateTime.ThemeName = THEME;
            this.radMaskedEditDateTime.ThemeName = THEME;
            this.radComboCultures.ThemeName = THEME;
            
        }

		void Form1_Load(object sender, EventArgs e)
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
				this.radComboCultures.Items.Add(new RadListDataItem(name, cultures[name]));
			}

            radComboCultures.SelectedItem = radComboCultures.Items[radComboCultures.FindStringExact(CultureInfo.CurrentCulture.EnglishName)];
            this.radComboCultures.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(CulturesList_SelectedIndexChanged);
		}

        void CulturesList_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
		{
			this.radMaskedEditDateTime.Culture = (radComboCultures.SelectedValue as CultureInfo);
		}
	}
}