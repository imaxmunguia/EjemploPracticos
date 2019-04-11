using System;
using Telerik.Examples.WinControls.Editors.ComboBox;
using Telerik.WinControls.UI;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Telerik.Examples.WinControls.Editors.TimePicker
{
	public partial class Form1 : EditorExampleBaseForm
	{
        Timer timer = new Timer();

		public Form1()
		{
			InitializeComponent();
            this.SelectedControl = this.radTimePicker1;
            SetEnabledQsfbButton(QuickStart.WinControls.QSFButtons.ChangeTheme, true);

            this.radClock1.ShowSystemTime = false;

            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 1000;
          
		}

        void SynchronizeTime()
        {
            DateTime currentTime = (DateTime)this.radClock1.Value;
            currentTime = currentTime.AddSeconds(1);
            this.radLabelDate.Text = currentTime.ToLongDateString();
            this.radClock1.Value = currentTime;
            if (this.radTimePicker1.Value.Value.Minute != currentTime.Minute ||
                this.radTimePicker1.Value.Value.Hour != currentTime.Hour)
            {
                this.radTimePicker1.Value = currentTime;
            }
        }

        void timer_Tick(object sender, EventArgs e)
        {
            SynchronizeTime();
        }

        private void radPageView1_SelectedPageChanging(object sender, Telerik.WinControls.UI.RadPageViewCancelEventArgs e)
        {
            e.Cancel = true;
        }
        
        private void radTimePicker1_ValueChanged(object sender, EventArgs e)
		{
            this.radClock1.Value = this.radTimePicker1.Value;
        }

        private void radCheckBox1_ToggleStateChanged(object sender, StateChangedEventArgs args)
		{
			this.radTimePicker1.ReadOnly = this.radCheckBox1.IsChecked;
		}

		private void TablesDropDownList_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
		{
			this.radTimePicker1.TimeTables = (TimeTables)(e.Position);
		}

		private void ClockPossitionDropDownList_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
		{
			this.radTimePicker1.ClockPosition = (ClockPosition)(e.Position);
		}

        private void Form1_Load(object sender, EventArgs e)
        {

            TablesDropDownList.SelectedIndex = 1;
            ClockPossitionDropDownList.SelectedIndex = 0;

            DateTime currentTime = DateTime.Now;
            this.radTimePicker1.Value = currentTime;

            SynchronizeTime();
            timer.Start();

            try
            {
                RegistryKey timeZoneInfoKey = Registry.LocalMachine.
                    OpenSubKey(@"SYSTEM\CurrentControlSet\Control\TimeZoneInformation");
                if (timeZoneInfoKey != null)
                {
                    object timeZoneKeyName = timeZoneInfoKey.GetValue("TimeZoneKeyName");
                    if (timeZoneKeyName != null)
                    {
                        RegistryKey timeZoneNameKey = Registry.LocalMachine.
                            OpenSubKey(@"Software\Microsoft\Windows NT\CurrentVersion\Time Zones\" + timeZoneKeyName);
                        if (timeZoneKeyName != null)
                        {
                            object displayName = timeZoneNameKey.GetValue("Display");
                            if (displayName != null)
                            {
                                radLabelTimeZone.Text = displayName.ToString();
                                return;
                            }
                        }
                    }
                }
            }
            catch { }

            TimeZone localZone = TimeZone.CurrentTimeZone;
            int hours = localZone.GetUtcOffset(currentTime).Hours;
            radLabelTimeZone.Text = "UTC" + (hours > 0 ? "+" : "-") + Math.Abs(hours).ToString();

            this.radTimePicker1.Value = null;
        }

        void Form1_Disposed(object sender, EventArgs e)
        {
            timer.Stop();
            timer.Dispose();
        }
    }
}
