using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI.Docking;

namespace Telerik.Examples.WinControls.Docking.Serialization
{
	public partial class Form1 : Form
	{
		int counter;

		public Form1()
		{
			InitializeComponent();
		}

        ToolWindow CreatePanel(string caption, DockPosition dockPosition, Size size, Color backColor)
		{
            counter++;
            ToolWindow panel = new ToolWindow();
            panel.CloseAction = DockWindowCloseAction.Close;
            panel.Text = caption + " " + counter;
			panel.BackColor = backColor;
            panel.Size = size;
			this.radDock1.DockWindow(panel, dockPosition);

			return panel;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			CreatePanel("Tool Window", DockPosition.Right, new Size(this.Width / 2, this.Height / 2), Color.FromArgb(255, 192, 192));
			CreatePanel("Tool Window", DockPosition.Top, new Size(this.Width / 2, this.Height / 2), Color.FromArgb(192, 255, 192));
			CreatePanel("Tool Window", DockPosition.Left, new Size(this.Width / 2, 100), Color.FromArgb(192, 192, 255));
		}

        private void radButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "XML files|*.xml|All files|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                radDock1.LoadFromXml(dialog.FileName);
            }
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "XML files|*.xml|All files|*.*";
            dialog.FileName = "";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                radDock1.SaveToXml(dialog.FileName);
            }
        }

        private void removeAllRadButton_Click(object sender, EventArgs e)
        {
            radDock1.CloseWindows(radDock1.DockWindows);
        }

        private void radMenuItem1_Click(object sender, EventArgs e)
        {
            Random random = new Random(DateTime.Now.Second);
            CreatePanel("Tool Window", DockPosition.Left, new Size(100, 100), Color.FromArgb(random.Next(100, 255), random.Next(100, 255), random.Next(100, 255)));
        }

        private void radMenuItem2_Click(object sender, EventArgs e)
        {
            Random random = new Random(DateTime.Now.Second);
            CreatePanel("Tool Window", DockPosition.Right, new Size(100, 100), Color.FromArgb(random.Next(100, 255), random.Next(100, 255), random.Next(100, 255)));
        }

        private void radMenuItem3_Click(object sender, EventArgs e)
        {
            Random random = new Random(DateTime.Now.Second);
            CreatePanel("Tool Window", DockPosition.Top, new Size(100, 100), Color.FromArgb(random.Next(100, 255), random.Next(100, 255), random.Next(100, 255)));
        }

        private void radMenuItem4_Click(object sender, EventArgs e)
        {
            Random random = new Random(DateTime.Now.Second);
            CreatePanel("Tool Window", DockPosition.Bottom, new Size(100, 100), Color.FromArgb(random.Next(100, 255), random.Next(100, 255), random.Next(100, 255)));
        }

        private void radMenuItem5_Click(object sender, EventArgs e)
        {
            Random random = new Random(DateTime.Now.Second);
            ToolWindow panel = CreatePanel("Tool Window", DockPosition.Bottom, new Size(100, 100), Color.FromArgb(random.Next(100, 255), random.Next(100, 255), random.Next(100, 255)));

            //Todo: change for release to use the appropriate Float method
            radDock1.FloatWindow(panel, Rectangle.Empty);
        }

        private void radMenuItem8_Click(object sender, EventArgs e)
        {
            ToolWindow panel = CreatePanel("Tool Window", DockPosition.Left, new Size(100, 100), Color.FromArgb(255, 192, 192));
            radDock1.AutoHideWindow(panel);
        }

        private void radMenuItem9_Click(object sender, EventArgs e)
        {
            ToolWindow panel = CreatePanel("Tool Window", DockPosition.Right, new Size(100, 100), Color.FromArgb(255, 192, 192));
            radDock1.AutoHideWindow(panel);
        }

        private void radMenuItem10_Click(object sender, EventArgs e)
        {
            ToolWindow panel = CreatePanel("Tool Window", DockPosition.Top, new Size(100, 100), Color.FromArgb(255, 192, 192));
            radDock1.AutoHideWindow(panel);
        }

        private void radMenuItem11_Click(object sender, EventArgs e)
        {
            ToolWindow panel = CreatePanel("Tool Window", DockPosition.Bottom, new Size(100, 100), Color.FromArgb(255, 192, 192));
            radDock1.AutoHideWindow(panel);
        }

        private void AddRandomRadButton_Click(object sender, EventArgs e)
        {
            Random random = new Random(DateTime.Now.Second);
            DockPosition dockPos = DockPosition.Left;
            int index = random.Next(1, 5);
            if (index == 1) dockPos = DockPosition.Left;
            else if (index == 2) dockPos = DockPosition.Right;
            else if (index == 3) dockPos = DockPosition.Top;
            else if (index == 4) dockPos = DockPosition.Bottom;
            ToolWindow window = CreatePanel("Tool Window", dockPos, new Size(100, 100), 
                Color.FromArgb(random.Next(100, 255), random.Next(100, 255), random.Next(100, 255)));
        }

        private void dockingManager1_DockingStateChanged(object sender, Telerik.WinControls.UI.Docking.DockWindowEventArgs e)
        {
            string message = "DockObject current state: ";
            DockWindow window = e.DockWindow;
            if (window != null) message = window.Text + " current state: ";
            AddLog(message + e.DockWindow.DockState, true);
            AddLog("", true); 
        }

        private void dockingManager1_DockingStateChanging(object sender, Telerik.WinControls.UI.Docking.DockStateChangingEventArgs e)
        {
            string message = "DockObject previous state: ";
            DockWindow window = e.NewWindow;
            if (window != null) message = window.Text + " previous state: ";
            AddLog(message + e.NewWindow.DockState, true);
        }

        private void AddLog(string text, bool newLine)
        {
            logTextBox.Text += text + ((newLine) ? "\r\n" : "");
            logTextBox.Select(logTextBox.Text.Length, -1);
            logTextBox.ScrollToCaret();
        }

        private void dockingManager1_LayoutLoaded(object sender, EventArgs e)
        {
            counter = radDock1.DockWindows.Count;
            AddLog("Docking Manager: LoadedFromXml", true);
        }

        private void dockingManager1_LayoutSaved(object sender, EventArgs e)
        {
            AddLog("Docking Manager: SavedToXml", true);
        }
	}
}