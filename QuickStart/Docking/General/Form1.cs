using System;
using Telerik.WinControls.UI.Docking;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.Docking.General
{
	public partial class Form1 : Telerik.WinControls.UI.RadForm
	{
		#region Fields

		private bool processDockStateChange = true;

		#endregion

		public Form1()
		{
			InitializeComponent();

            RadListDataItem item = new RadListDataItem("Tool Window 1");
            item.Value = this.toolWindow1;
			this.radComboBox1.Items.Add(item);

            item = new RadListDataItem("Tool Window 2");
            item.Value = this.toolWindow2;
			this.radComboBox1.Items.Add(item);
			this.radComboBox1.SelectedIndex = 0;

			this.processDockStateChange = false;

			foreach (DockState state in Enum.GetValues(typeof(DockState)))
			{
                item = new RadListDataItem(state.ToString());
                item.Value = state;
				this.radComboBox2.Items.Add(item);
			}

			this.radComboBox2.SelectedIndex = 0;
			this.processDockStateChange = true;

			this.radDock1.DockStateChanging += radDock1_DockStateChanging;
			this.radDock1.DockStateChanged += radDock1_DockStateChanged;
			this.radDock1.ActiveWindowChanging += new DockWindowCancelEventHandler(radDock1_ActiveWindowChanging);
			this.radDock1.ActiveWindowChanged += new DockWindowEventHandler(radDock1_ActiveWindowChanged);
		}

		private void radDock1_ActiveWindowChanging(object sender, DockWindowCancelEventArgs e)
		{
			e.Cancel = e.NewWindow is DocumentWindow;
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			this.SetDockState(this.radDock1.ActiveWindow);
		}

		private void radDock1_ActiveWindowChanged(object sender, DockWindowEventArgs e)
		{
			this.SetDockState(e.DockWindow);
		}

		private void radDock1_DockStateChanged(object sender, DockWindowEventArgs e)
		{
			this.SetDockState(e.DockWindow);

			string message = e.DockWindow.Text + " dock state changed to " + e.DockWindow.DockState;
			AddLog(message, true);
		}

		private DockWindow GetSelectedDockWindow()
		{
            RadListDataItem item = this.radComboBox1.SelectedItem as RadListDataItem;
			if (item == null)
			{
				return null;
			}

			return item.Value as DockWindow;
		}

		private void radDock1_DockStateChanging(object sender, DockStateChangingEventArgs e)
		{
			string message = e.NewWindow.Text + " current dock state - " + e.NewWindow.DockState + " - changing to " + e.NewDockState;
			AddLog(message, true);
		}

		private void AddLog(string text, bool newLine)
		{
			textBox1.Text += text + ((newLine) ? "\r\n" : "");
			textBox1.Select(textBox1.Text.Length, -1);
			textBox1.ScrollToCaret();
		}

		private void radComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			DockWindow window = this.GetSelectedDockWindow();
			if (window != null)
			{
				this.radDock1.ActiveWindow = window;
			}
		}

        private void radComboBox2_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
		{
			if (!this.processDockStateChange)
			{
				return;
			}

			DockWindow window = this.GetSelectedDockWindow();
			if (window != null)
			{
                DockState state = (DockState)this.radComboBox2.SelectedValue;
				window.DockState = state;
				this.SetDockState(window);
			}
		}

		private void radButton1_Click(object sender, EventArgs e)
		{
			this.textBox1.Text = string.Empty;
		}

		private void SetDockState(DockWindow window)
		{
			if (window == this.toolWindow1)
			{
				this.radComboBox1.SelectedIndex = 0;
			}
			else if (window == this.toolWindow2)
			{
				this.radComboBox1.SelectedIndex = 1;
			}

			this.processDockStateChange = false;
			this.radComboBox2.SelectedIndex = (int)window.DockState;
			this.processDockStateChange = true;
		}
	}
}