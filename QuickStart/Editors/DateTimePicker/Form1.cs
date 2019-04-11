using System;
using Telerik.Examples.WinControls.Editors.ComboBox;

namespace Telerik.Examples.WinControls.Editors.DateTimePicker
{

    public partial class Form1 : EditorExampleBaseForm
    {
        private const string THEME = "ControlDefault";

        /// <summary>
        /// 
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            this.SelectedControl = this.radDateTimePicker1;
            this.radDateTimePicker3.DateTimePickerElement.ShowCurrentTime = false;
			this.radDateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.radDateTimePicker3.Culture = new System.Globalization.CultureInfo("en-US");
            this.radDateTimePicker3.DateTimePickerElement.CustomFormat = "hh:mm:ss tt";
            this.radRadio12Hours.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.SetTheme();
        }

        private void SetTheme()
        {
            this.radBtnClearAll.ThemeName = THEME;
            this.radRadio12Hours.ThemeName = THEME;
            this.radRadio24Hours.ThemeName = THEME;
            this.radDateTimePicker1.ThemeName = THEME;
            this.radDateTimePicker2.ThemeName = THEME;
            this.radDateTimePicker3.ThemeName = THEME;
            this.radGroupExampleSettings.ThemeName = THEME;
            this.radLblLongDateFormat.ThemeName = THEME;
            this.radLblShortDateFormat.ThemeName = THEME;
            this.radLblTimeFormat.ThemeName = THEME;

            this.radDateTimePicker1.DateTimePickerElement.TextBoxElement.TextBoxItem.HostedControl.Enabled = true;
            this.radDateTimePicker2.DateTimePickerElement.TextBoxElement.TextBoxItem.HostedControl.Enabled = true;
            this.radDateTimePicker3.DateTimePickerElement.TextBoxElement.TextBoxItem.HostedControl.Enabled = true;
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            this.radDateTimePicker1.DateTimePickerElement.SetToNullValue();
            this.radDateTimePicker2.DateTimePickerElement.SetToNullValue();
            this.radDateTimePicker3.DateTimePickerElement.SetToNullValue();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.radDateTimePicker1.Value = DateTime.Now;
            this.radDateTimePicker2.Value = DateTime.Now;
            this.radDateTimePicker3.Value = DateTime.Now;
        }

        private void OnRadRadioHourFormat_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if (this.radRadio12Hours.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.radDateTimePicker3.DateTimePickerElement.CustomFormat = "hh:mm:ss  tt";
            }
            else
            {
                this.radDateTimePicker3.DateTimePickerElement.CustomFormat = "HH:mm:ss";
            }
        }
    }
}