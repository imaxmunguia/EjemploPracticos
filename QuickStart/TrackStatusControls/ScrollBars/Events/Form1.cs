using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.Examples.WinControls.Editors.ComboBox;

namespace Telerik.Examples.WinControls.TrackStatusControls.ScrollBars.Events
{
	public partial class Form1 : EditorExampleBaseForm
	{
		public Form1()
		{
			InitializeComponent();

            this.SelectedControl = this.radHScrollBar1;
        }

        #region Scroll Events
        private void dumpScrollInfo(string company, int value, ScrollEventArgs e)
        {
            this.radTxtEvents.SelectedText = company + " " + e.ScrollOrientation.ToString() +
                ": Type = " + e.Type.ToString() +
                "; oldValue = " + e.OldValue.ToString() +
                "; newValue = " + e.NewValue.ToString() +
                "; value = " + value.ToString() + "\r\n";
        }

        private void radVScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            dumpScrollInfo("Telerik", radVScrollBar1.Value, e);
        }

        private void radHScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            dumpScrollInfo("Telerik", radHScrollBar1.Value, e);
        }


        private void dumpValueChanged(string company, string scrollOrientation, int value, ScrollEventArgs e)
        {
            this.radTxtEvents.SelectedText = company + " " + scrollOrientation.ToString() +
                ": Type = " + e.Type.ToString() +
                "; Value = " + value.ToString() + "\r\n";
        }


        private void radVScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            this.radTxtEvents.SelectedText = "Telerik Vertical ValueChanged: value = " +
                radVScrollBar1.Value.ToString() + "\r\n";
        }

        private void radHScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            this.radTxtEvents.SelectedText = "Telerik Horizontal ValueChanged: value = " +
                radHScrollBar1.Value.ToString() + "\r\n";
        }

		#endregion

        #region ScrollBar Context Menu
        private RadScrollBar GetScrollBar(object contextMenuEventSender)
        {
            ToolStripDropDownItem item = contextMenuEventSender as ToolStripDropDownItem;
            if (item == null)
                return null;

            ContextMenuStrip menu = item.Owner as ContextMenuStrip;
            if (menu == null)
                return null;

            return menu.SourceControl as RadScrollBar;
        }

        private void scrollToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RadScrollBar scrollBar = GetScrollBar(sender);
            if (scrollBar != null)
                scrollBar.PerformScrollTo(Cursor.Position);
        }

        private void leftTopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RadScrollBar scrollBar = GetScrollBar(sender);
            if (scrollBar != null)
                scrollBar.PerformFirst();
        }

        private void rightBottomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RadScrollBar scrollBar = GetScrollBar(sender);
            if (scrollBar != null)
                scrollBar.PerformLast();
        }

        private void pageLeftUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RadScrollBar scrollBar = GetScrollBar(sender);
            if (scrollBar != null)
                scrollBar.PerformLargeDecrement(1);
        }

        private void pageRightBottomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RadScrollBar scrollBar = GetScrollBar(sender);
            if (scrollBar != null)
                scrollBar.PerformLargeIncrement(1);
        }

        private void scrollLeftUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RadScrollBar scrollBar = GetScrollBar(sender);
            if (scrollBar != null)
                scrollBar.PerformSmallDecrement(1);
        }

        private void scrollRightBottomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RadScrollBar scrollBar = GetScrollBar(sender);
            if (scrollBar != null)
                scrollBar.PerformSmallIncrement(1);
        }
        #endregion

		private void radButton1_Click(object sender, EventArgs e)
		{
			this.radTxtEvents.Text = String.Empty;
		}
	}
}