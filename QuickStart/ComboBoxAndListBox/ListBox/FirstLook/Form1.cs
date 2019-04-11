using System;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.Enumerations;

namespace Telerik.Examples.WinControls.ComboBoxAndListBox.ListBox.FirstLook
{
    public partial class Form1 : ExamplesForm
    {
        string[] itemsText = new string[] { "(NONE)", "(NONE)", "(NONE)", "AAC File", "ASA", "ASAX", "ASCX", "ASPX", "MP3", "MPEG" };
        string[] itemsDescriptionText = new string[] { "AudioCD", "File Folder", "Help and Support Center protocol", "Quicktime File", "ASA File", "ASP.NET Server Application", "ASP.NET User Control", "ASP.NET Server Page", "Winamp Media File", "Movie Clip" };
        
        public Form1()
        {
            InitializeComponent();
            base.SetEnabledQsfbButton(QSFButtons.TransparentBackground, false);
            this.radListBoxDemo.ItemHeight = 50;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.radDropDownList1.SelectedIndex = 0;
            this.radComboSelectionMode.SelectedIndex = 1;
            this.radListBoxDemo.SelectedIndex = 0;
            this.radComboSortStyle.SelectedIndex = 2;
        }

        private void ClearSelectedItemControls()
        {
            this.radComboImageAlign.SelectedItem = null;
            this.radComboTextAlign.SelectedItem = null;
            this.radComboTextImage.SelectedItem = null;
            this.radComboTextOrientation.SelectedItem = null;
        }

        private void radListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.UpdateSettingsControls();
        }

        private void UpdateSettingsControls()
        {
            foreach (var item in radListBoxDemo.SelectedItems)
            {
                this.radComboImageAlign.SelectedIndex = this.radComboImageAlign.ListElement.FindString(item.ImageAlignment.ToString());
                this.radComboTextAlign.SelectedIndex = this.radComboTextAlign.ListElement.FindString(item.TextAlignment.ToString());
                this.radComboTextImage.SelectedIndex = this.radComboTextImage.ListElement.FindString(item.TextImageRelation.ToString());
                this.radComboTextOrientation.SelectedIndex = this.radComboTextOrientation.ListElement.FindString(item.TextOrientation.ToString());
            }
        }

        private void comboImageAlign_SelectedIndexChanged(object sender, EventArgs e)
        {
            RadListDataItem item = radListBoxDemo.SelectedItem;
            if (item == null)
                return;

            RadListDataItem comboItem = this.radComboImageAlign.SelectedItem;
            switch (comboItem.Text)
            {
                case "TopLeft":
                    item.ImageAlignment = ContentAlignment.TopLeft;
                    break;
                case "TopCenter":
                    item.ImageAlignment = ContentAlignment.TopCenter;
                    break;
                case "TopRight":
                    item.ImageAlignment = ContentAlignment.TopRight;
                    break;
                case "MiddleLeft":
                    item.ImageAlignment = ContentAlignment.MiddleLeft;
                    break;
                case "MiddleCenter":
                    item.ImageAlignment = ContentAlignment.MiddleCenter;
                    break;
                case "MiddleRight":
                    item.ImageAlignment = ContentAlignment.MiddleRight;
                    break;
                case "BottomLeft":
                    item.ImageAlignment = ContentAlignment.BottomLeft;
                    break;
                case "BottomCenter":
                    item.ImageAlignment = ContentAlignment.BottomCenter;
                    break;
                case "BottomRight":
                    item.ImageAlignment = ContentAlignment.BottomRight;
                    break;
            }
        }

        private void comboTextAlign_SelectedIndexChanged(object sender, EventArgs e)
        {
            RadListDataItem item = radListBoxDemo.SelectedItem;
            if (item == null)
                return;

            RadListDataItem comboItem = this.radComboTextAlign.SelectedItem;
            switch (comboItem.Text)
            {
                case "TopLeft":
                    item.TextAlignment = ContentAlignment.TopLeft;
                    break;
                case "TopCenter":
                    item.TextAlignment = ContentAlignment.TopCenter;
                    break;
                case "TopRight":
                    item.TextAlignment = ContentAlignment.TopRight;
                    break;
                case "MiddleLeft":
                    item.TextAlignment = ContentAlignment.MiddleLeft;
                    break;
                case "MiddleCenter":
                    item.TextAlignment = ContentAlignment.MiddleCenter;
                    break;
                case "MiddleRight":
                    item.TextAlignment = ContentAlignment.MiddleRight;
                    break;
                case "BottomLeft":
                    item.TextAlignment = ContentAlignment.BottomLeft;
                    break;
                case "BottomCenter":
                    item.TextAlignment = ContentAlignment.BottomCenter;
                    break;
                case "BottomRight":
                    item.TextAlignment = ContentAlignment.BottomRight;
                    break;
            }
        }

        private void comboTextImageRel_SelectedIndexChanged(object sender, EventArgs e)
        {
            RadListDataItem item = radListBoxDemo.SelectedItem;
            if (item == null)
                return;
            RadListDataItem comboItem = this.radComboTextImage.SelectedItem;
            switch (comboItem.Text)
            {
                case "ImageAboveText":
                    {
                        item.TextImageRelation = TextImageRelation.ImageAboveText;
                        break;
                    }
                case "ImageBeforeText":
                    {
                        item.TextImageRelation = TextImageRelation.ImageBeforeText;
                        break;
                    }
                case "TextAboveImage":
                    {
                        item.TextImageRelation = TextImageRelation.TextAboveImage;
                        break;
                    }
                case "TextBeforeImage":
                    {
                        item.TextImageRelation = TextImageRelation.TextBeforeImage;
                        break;
                    }
                case "Overlay":
                    {
                        item.TextImageRelation = TextImageRelation.Overlay;
                        break;
                    }
            }
        }

        private void comboTextOrientation_SelectedIndexChanged(object sender, EventArgs e)
        {
            RadListDataItem item = radListBoxDemo.SelectedItem;

            RadListDataItem comboItem = this.radComboTextOrientation.SelectedItem;
            if (item != null)
            {
                if (comboItem.Text == "Vertical")
                    item.TextOrientation = Orientation.Vertical;
                else
                    item.TextOrientation = Orientation.Horizontal;
            }
        }

        private void comboSelectionMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            radListBoxDemo.SelectionMode = (SelectionMode)(this.radComboSelectionMode.SelectedIndex);
        }

        private void comboSortStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.radComboSortStyle.SelectedText)
            {
                case "Ascending":
                    radListBoxDemo.SortStyle = Telerik.WinControls.Enumerations.SortStyle.Ascending;
                    break;
                case "Descending":
                    radListBoxDemo.SortStyle = Telerik.WinControls.Enumerations.SortStyle.Descending;
                    break;
                case "None":
                    radListBoxDemo.SortStyle = Telerik.WinControls.Enumerations.SortStyle.None;
                    break;
                default:
                    break;
            }
        }

        private void OnSortStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.radComboSortStyle.SelectedItem.Text == SortStyle.Ascending.ToString())
            {
                this.radListBoxDemo.SortStyle = SortStyle.Ascending;
            }
            else if (this.radComboSortStyle.SelectedItem.Text == SortStyle.Descending.ToString())
            {
                this.radListBoxDemo.SortStyle = SortStyle.Descending;
            }
            else
            {
                this.radListBoxDemo.SortStyle = SortStyle.None;
            }
        }

        private void radDropDownList1_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            this.radListBoxDemo.Items.Clear();
            RadListDataItem item;
            bool isRadListDataItems = this.radDropDownList1.SelectedItem.Text == "RadListDataItems";

            for (int i = 0; i < 10; i++)
            {
                item = isRadListDataItems ? new RadListDataItem() : new DescriptionTextListDataItem();
                item.Text = itemsText[i];
                item.Image = imageList1.Images[i];
                if (!isRadListDataItems)
                {
                    ((DescriptionTextListDataItem)item).DescriptionText = itemsDescriptionText[i];
                }
                this.radListBoxDemo.Items.Add(item);
            }

            this.radListBoxDemo.SelectedIndex = 0;
            this.radGroupItem.Enabled = isRadListDataItems;
        }
    }
}