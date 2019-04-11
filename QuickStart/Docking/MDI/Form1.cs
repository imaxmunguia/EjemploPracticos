using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI.Docking;
using Telerik.WinControls.UI;
using System.Diagnostics;

namespace Telerik.Examples.WinControls.Docking.MDI
{
    public partial class Form1 : Form
    {
        private static int count;

        public Form1()
        {
            InitializeComponent();

            this.radDock1.AutoDetectMdiChildren = true;
            this.radDock1.DockStateChanging += new DockStateChangingEventHandler(radDock1_DockStateChanging);
            this.radDock1.DockStateChanged += new DockWindowEventHandler(radDock1_DockStateChanged);
            this.radDock1.ActiveWindowChanging += new DockWindowCancelEventHandler(radDock1_ActiveWindowChanging);
            this.radDock1.ActiveWindowChanged += new DockWindowEventHandler(radDock1_ActiveWindowChanged);
            this.documentContainer1.SendToBack();
            this.radDock1.DockWindow(this.toolWindow2, DockPosition.Bottom);
        }

        private void radDock1_ActiveWindowChanged(object sender, DockWindowEventArgs e)
        {
            this.AddLog("Active window changed; new active window: " + e.DockWindow, true);
        }

        private void radDock1_ActiveWindowChanging(object sender, DockWindowCancelEventArgs e)
        {
            this.AddLog("Active window changing; current active window: " + e.NewWindow, true);
        }

        private void radDock1_DockStateChanged(object sender, DockWindowEventArgs e)
        {
            this.AddLog("Dock State for window " + e.DockWindow + " changed to " + e.DockWindow.DockState, true);
        }

        void radDock1_DockStateChanging(object sender, DockStateChangingEventArgs e)
        {
            this.AddLog("Window " + e.NewWindow + " DockState changing to " + e.NewDockState + "; current state: " + e.NewWindow.DockState, true);
        }

        private void newRadButton_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            form.Text = "Demo Form" + (++count).ToString();
            form.MdiParent = this;
            form.Show();
        }

        private void AddLog(string text, bool newLine)
        {
            logRadTextBox.Text += text + ((newLine) ? "\r\n" : "");
            logRadTextBox.Select(logRadTextBox.Text.Length, -1);
            logRadTextBox.ScrollToCaret();
        }

        private void customerMDIRadButton_Click(object sender, EventArgs e)
        {
            CustomerForm form = new CustomerForm();
            form.Text = "Customer Form" + (++count).ToString();
            form.MdiParent = this;
            form.Show();
        }

        private void orderMDIRadButton_Click(object sender, EventArgs e)
        {
            OrderForm form = new OrderForm();
            form.Text = "Order Form" + (++count).ToString();
            form.MdiParent = this;
            form.Show();
        }

        private void reportMDIRadButton_Click(object sender, EventArgs e)
        {
            ReportForm form = new ReportForm();
            form.Text = "Report Form" + (++count).ToString();
            form.MdiParent = this;
            form.Show();
        }

        private void imageMDIRadButton_Click(object sender, EventArgs e)
        {
            ImageForm form = new ImageForm();
            form.Text = "Image Form" + (++count).ToString();
            form.MdiParent = this;
            form.Show();
        }
    }
}