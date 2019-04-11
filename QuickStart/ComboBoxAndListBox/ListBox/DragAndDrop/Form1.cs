using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.ComboBoxAndListBox.ListBox.DragAndDrop
{

    public partial class Form1 : ExamplesForm
    {
        RadItemDragDropManager dragDropMan1;
        private Font itemsFont = null;

        public Form1()
        {
            InitializeComponent();

            Font font = new Font("Segoe Print", 12.0f, FontStyle.Bold);
            itemsFont = font;
            foreach (RadListDataItem item in this.radListBox1.Items)
            {
                item.Font = font;
            }

            base.SetEnabledQsfbButton(QSFButtons.TransparentBackground, true);
            dragDropMan1 = new RadItemDragDropManager(this.radListBox1, this.radListBox1.Items, this.radListBox2, this.radListBox2.Items);
            SetTheme();
            this.radListBox1.AutoSizeItems = true;
            this.radListBox2.AutoSizeItems = true;

            this.Disposed += new EventHandler(Form1_Disposed);
        }

        void Form1_Disposed(object sender, EventArgs e)
        {
            itemsFont.Dispose();   
        }

        protected override void OnLoad(EventArgs e)
        {
            ThemeResolutionService.ApplyThemeToControlTree(this.settingsPanel, MainForm.DefaultTheme);
        }

        private void SetTheme()
        {
            string ControlDefault = "ControlDefault";
            this.radButton1.ThemeName = ControlDefault;
            this.radButton2.ThemeName = ControlDefault;
            this.radButton3.ThemeName = ControlDefault;
            this.radButton4.ThemeName = ControlDefault;
            this.radButton5.ThemeName = ControlDefault;
            this.radButton6.ThemeName = ControlDefault;
            this.radButton7.ThemeName = ControlDefault;
            this.radButton8.ThemeName = ControlDefault;
        }

        void radButton1_Click(object sender, EventArgs e)
        {
            //moves selectedItem from ListBox1 to ListBox2
            MoveToTargetListBox(radListBox1, radListBox2);
        }

        void radButton2_Click(object sender, EventArgs e)
        {
            //moves selectedItem from ListBox2 to ListBox1
            MoveToTargetListBox(radListBox2, radListBox1);
        }

        private void radButton3_Click(object sender, EventArgs e)
        {
            //moves all items from listBox1 to ListBox2
            MoveAllItems(radListBox1, radListBox2);
        }

        void radButton4_Click(object sender, EventArgs e)
        {
            //moves all items from listBox2 to ListBox1
            MoveAllItems(radListBox2, radListBox1);
        }

        private void radButton7_Click(object sender, EventArgs e)
        {
            //moves up SelectedItem in radListBox1 
            MoveUp(radListBox1);
        }

        private void radButton8_Click(object sender, EventArgs e)
        {
            //moves down SelectedItem in radListBox1
            MoveDown(radListBox1);
        }

        private void radButton5_Click(object sender, EventArgs e)
        {
            //moves up SelectedItem in radListBox2
            MoveUp(radListBox2);
        }

        private void radButton6_Click(object sender, EventArgs e)
        {
            //moves down SelectedItem in radListBox2
            MoveDown(radListBox2);
        }

        private void MoveUp(RadListControl listBox)
        {
            if (listBox.Items.Count < 2) { return; }
            if (listBox.SelectedItem == null) { return; }
            if (listBox.SelectedIndex == 0) { return; }
            RadListDataItem item = listBox.SelectedItem;
            int index = listBox.SelectedIndex;
            listBox.Items.Remove(item);
            listBox.Items.Insert(index - 1, item);
            listBox.SelectedItem = item;
        }

        private void MoveDown(RadListControl listBox)
        {
            if (listBox.Items.Count < 2) { return; }
            if (listBox.SelectedItem == null) { return; }
            if (listBox.SelectedIndex == listBox.Items.Count - 1) { return; }
            RadListDataItem item = listBox.SelectedItem;
            int index = listBox.SelectedIndex;
            listBox.Items.Remove(item);
            listBox.Items.Insert(index + 1, item);
            listBox.SelectedItem = item;
        }

        private void MoveAllItems(RadListControl sourceListBox, RadListControl targetListBox)
        {
            for (int i = 0; i < sourceListBox.Items.Count; )
            {
                RadListDataItem item = sourceListBox.Items[i];
                sourceListBox.Items.Remove(item);
                targetListBox.Items.Add(item);
            }
        }

        private void MoveToTargetListBox(RadListControl sourceListBox, RadListControl targetListBox)
        {
            if (sourceListBox.Items.Count == 0) { return; }
            if (sourceListBox.SelectedItem == null) { return; }

            RadListDataItem item = sourceListBox.SelectedItem;
            sourceListBox.Items.Remove(item);
            targetListBox.Items.Add(item);
        }
    }
}
