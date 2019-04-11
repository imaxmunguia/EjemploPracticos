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

namespace Telerik.Examples.WinControls.TrackStatusControls.ScrollBars.FirstLook
{
	public partial class Form1 : EditorExampleBaseForm
	{
        private Control currentScrollBar = null;
		public Form1()
		{
			InitializeComponent();
			UpdateScrollbars();
            this.SelectedControl = this.radHScrollBar1;
        }

        #region Utility Methods
        private void UpdateGUIForProperties(Control ctl)
        {
                RadScrollBar sb = (RadScrollBar)ctl;

				spinMax.Value = sb.Maximum;
				spinMin.Value = sb.Minimum;
				spinLargeChange.Value = sb.LargeChange;
				spinSmallChange.Value = sb.SmallChange;
				spinValue.Value = sb.Value;

				spinThumbLength.Value = (decimal)sb.ThumbLengthProportion >= -1 && (decimal)sb.ThumbLengthProportion <=1 ? 
					(decimal)sb.ThumbLengthProportion : (decimal)0.1;
				spinThumbLength.Enabled = true;
				spinMinThumb.Value = sb.MinThumbLength;
				spinMinThumb.Enabled = true;
        }

        private void SetCurrentMaximum(int newValue)
        {
			
				((RadScrollBar)this.radHScrollBar1).Maximum = newValue;
				((RadScrollBar)this.radVScrollBar1).Maximum = newValue;
        }

        private void SetCurrentMinimum(int newValue)
        {
				((RadScrollBar)this.radHScrollBar1).Minimum = newValue;
				((RadScrollBar)this.radVScrollBar1).Minimum = newValue;
        }

        private void SetCurrentLargeChange(int newValue)
        {
            try
            {
					((RadScrollBar)this.radHScrollBar1).LargeChange = newValue;
					((RadScrollBar)this.radVScrollBar1).LargeChange = newValue;
            }
            catch (ArgumentOutOfRangeException e)
            {
                MessageBox.Show(e.Message, "Wrong value",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SetCurrentSmallChange(int newValue)
        {
            try
            {
					((RadScrollBar)this.radVScrollBar1).SmallChange = newValue;
					((RadScrollBar)this.radHScrollBar1).SmallChange = newValue;
            }
            catch (ArgumentOutOfRangeException e)
            {
                MessageBox.Show(e.Message, "Wrong value",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SetCurrentValue(int newValue)
        {
            try
            {
					((RadScrollBar)this.radVScrollBar1).Value = newValue;
					((RadScrollBar)this.radHScrollBar1).Value = newValue;
            }
            catch (ArgumentOutOfRangeException e)
            {
                MessageBox.Show(e.Message, "Wrong value",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private string GetCurrentMaximum()
        {
            if (this.currentScrollBar is ScrollBar)
                return ((ScrollBar)this.currentScrollBar).Maximum.ToString();
            else
                return ((RadScrollBar)this.currentScrollBar).Maximum.ToString();
        }

        private string GetCurrentMinimum()
        {
            if (this.currentScrollBar is ScrollBar)
                return ((ScrollBar)this.currentScrollBar).Minimum.ToString();
            else
                return ((RadScrollBar)this.currentScrollBar).Minimum.ToString();
        }

        private string GetCurrentLargeChange()
        {
            if (this.currentScrollBar is ScrollBar)
                return ((ScrollBar)this.currentScrollBar).LargeChange.ToString();
            else
                return ((RadScrollBar)this.currentScrollBar).LargeChange.ToString();
        }

        private string GetCurrentSmallChange()
        {
            if (this.currentScrollBar is ScrollBar)
                return ((ScrollBar)this.currentScrollBar).SmallChange.ToString();
            else
                return ((RadScrollBar)this.currentScrollBar).SmallChange.ToString();
        }

        private string GetCurrentValue()
        {
            if (this.currentScrollBar is ScrollBar)
                return ((ScrollBar)this.currentScrollBar).Value.ToString();
            else
                return ((RadScrollBar)this.currentScrollBar).Value.ToString();
        }
        #endregion

        #region Scroll Events

        private void radVScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            spinValue.Value = radVScrollBar1.Value;
			radHScrollBar1.Value = radVScrollBar1.Value;
        }

        private void radHScrollBar1_ValueChanged(object sender, EventArgs e)
        {
			spinValue.Value = radHScrollBar1.Value;
			radVScrollBar1.Value = radHScrollBar1.Value;
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

        #region ScrollBar Properties Editing
        private void SetScrollBarValue(RadSpinEditor input)
        {
			int newValue = (int)input.Value;
            if (input == this.spinMax)
                SetCurrentMaximum(newValue);
            else if (input == this.spinMin)
				SetCurrentMinimum(newValue);
            else if (input == this.spinLargeChange)
				SetCurrentLargeChange(newValue);
            else if (input == this.spinSmallChange)
				SetCurrentSmallChange(newValue);
            else if (input == this.spinValue)
				SetCurrentValue(newValue);

			UpdateScrollbars();
        }

        #endregion

		#region ScrollBar Choosing

        private void UpdateScrollbars()
        {
            UpdateGUIForProperties(this.radVScrollBar1);
            UpdateGUIForProperties(this.radHScrollBar1);
        }
		#endregion


		private void spinMax_ValueChanged(object sender, EventArgs e)
		{
			SetScrollBarValue((RadSpinEditor)sender);
		}

		private void spinMin_ValueChanged(object sender, EventArgs e)
		{
			SetScrollBarValue((RadSpinEditor)sender);
		}

		private void spinLargeChange_ValueChanged(object sender, EventArgs e)
		{
			SetScrollBarValue((RadSpinEditor)sender);
		}

		private void spinSmallChange_ValueChanged(object sender, EventArgs e)
		{
			SetScrollBarValue((RadSpinEditor)sender);
		}

		private void spinValue_ValueChanged(object sender, EventArgs e)
		{
			SetScrollBarValue((RadSpinEditor)sender);
		}

		private void spinThumbLength_ValueChanged(object sender, EventArgs e)
		{
			double newValue = (double)spinThumbLength.Value;
				((RadScrollBar)this.radVScrollBar1).ThumbLengthProportion = newValue;
				((RadScrollBar)this.radHScrollBar1).ThumbLengthProportion = newValue;

			UpdateScrollbars();
		}

		private void spinMinThumb_ValueChanged(object sender, EventArgs e)
		{
			int newValue = (int)spinMinThumb.Value;
				((RadScrollBar)this.radVScrollBar1).MinThumbLength = newValue;
				((RadScrollBar)this.radHScrollBar1).MinThumbLength = newValue;

			UpdateScrollbars();
		}
	}
}