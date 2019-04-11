using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Xml;
using Telerik.WinControls.Themes.Design;
using Telerik.WinControls.UI;
using System.Xml.XPath;
using Telerik.QuickStart.WinControls;
using System.IO;
using Telerik.Examples.WinControls.Editors.ComboBox;

namespace Telerik.Examples.WinControls.ComboBoxAndListBox.ComboBox.ImagesAndMultiline
{
	public partial class Form1 : EditorExampleBaseForm
	{
        private Timer dropDownTimeout;

		public Form1()
		{
			InitializeComponent();

            this.dropDownTimeout = new Timer(this.components);
            this.dropDownTimeout.Interval = 1000;
            this.dropDownTimeout.Tick += new EventHandler(this.OnDropDownTimeout_Tick);

            this.radComboDemo.ListElement.AutoSizeItems = true;
            this.radComboDemo.DropDownMinSize = new Size(0, 200);
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);

            this.dropDownTimeout.Tick -= new EventHandler(this.OnDropDownTimeout_Tick);
        }

        private void radComboDemo_ItemDataBound(object sender, ListItemDataBoundEventArgs e)
        {
            RadListDataItem item = e.NewItem;
            item.Text += " " + (item.DataBoundItem as DataRowView)["FirstName"];

            Telerik.Examples.WinControls.DataSources.NorthwindDataSet.EmployeesRow row = (item.DataBoundItem as DataRowView).Row as Telerik.Examples.WinControls.DataSources.NorthwindDataSet.EmployeesRow;
            item.Image = GetImageFromData(row.Photo);

            item.Font = new Font("Arial", 10, FontStyle.Bold);
        }

        private Image GetImageFromData(byte[] imageData)
        {
            const int OleHeaderLength = 78;
            MemoryStream memoryStream = new MemoryStream();
            if (HasOleContainerHeader(imageData))
            {
                memoryStream.Write(imageData, OleHeaderLength, imageData.Length - OleHeaderLength);
            }
            else
            {
                memoryStream.Write(imageData, 0, imageData.Length);
            }
            Bitmap bitmap = new Bitmap(memoryStream);
            return bitmap.GetThumbnailImage(55, 65, null, new IntPtr());
        }

        private bool HasOleContainerHeader(byte[] imageByteArray)
        {
            const byte OleByte0 = 21;
            const byte OleByte1 = 28;
            return (imageByteArray[0] == OleByte0) && (imageByteArray[1] == OleByte1);
        }

        protected override void OnLoad(EventArgs e)
        {
            this.LoadData();
            base.OnLoad(e);
        }

        private void LoadData()
        {
            try
            {
                this.employeesTableAdapter.Fill(this.northwindDataSet.Employees);
            }
            catch (Exception exception1)
            {
                string message = "To run this sample, you must have SQL Server with the Northwind database installed.";
                throw new DataException(message, exception1);
            }
        }

        private void LoadAnimationSettings()
        {
            this.radComboDropDownAnim.DataSource = Enum.GetValues(typeof(RadEasingType));
        }

        private void LoadInitialSettings()
        {
            this.radComboDropDownStyle.SelectedIndex = 0;
            this.radComboDemo.DropDownAnimationFrames = 50;
        }

        #region Event handling

		private void Form1_Load(object sender, EventArgs e)
		{

			this.SelectedControl = this.radComboDemo;
            this.LoadAnimationSettings();
            this.LoadInitialSettings();
            this.dropDownTimeout.Start();
		}
				
		private void radComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (radComboDemo.SelectedIndex != -1)
			{
                radTxtIndex.Text = radComboDemo.SelectedIndex.ToString();
                RadListDataItem item = radComboDemo.SelectedItem;
                radTxtText.Text = item.Text;
                radComboImageAlignment.SelectedIndex = radComboImageAlignment.ListElement.FindString(item.ImageAlignment.ToString());
                radComboTextAlignment.SelectedIndex = radComboTextAlignment.ListElement.FindString(item.TextAlignment.ToString());
                radComboTextImageRel.SelectedIndex = radComboTextImageRel.ListElement.FindString(item.TextImageRelation.ToString());
			}
		}

		private void comboDropDownStyle_SelectedIndexChanged(object sender, EventArgs e)
		{
			radComboDemo.DropDownStyle = (RadDropDownStyle)(this.radComboDropDownStyle.SelectedIndex + 1);
		}

		private void comboImageAlign_SelectedIndexChanged(object sender, EventArgs e)
		{
            RadListDataItem item = radComboDemo.SelectedItem;
			if (item == null)
				return;
			switch (this.radComboImageAlignment.Text)
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
            RadListDataItem item = radComboDemo.SelectedItem;

			if (item == null)
				return;

			switch (this.radComboTextAlignment.Text)
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
			RadListDataItem item = radComboDemo.SelectedItem;
			if (item == null)
				return;
			switch (this.radComboTextImageRel.SelectedText)
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

		private void tBoxText_TextChanged(object sender, EventArgs e)
		{
			RadListDataItem item = radComboDemo.SelectedItem;
			if ((item != null) && (item.Text != radTxtText.Text))
			{
                radComboDemo.SelectedItem.Text = radTxtText.Text;
			}
        }
        private void OnRadComboAnimType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!this.radComboDemo.DropDownAnimationEnabled)
                this.radComboDemo.DropDownAnimationEnabled = true;

            if (this.radComboDropDownAnim.SelectedItem != null)
            {
                this.radComboDemo.DropDownAnimationEasing = (RadEasingType)this.radComboDropDownAnim.SelectedItem.DataBoundItem;
            }
        }

        private void OnDropDownTimeout_Tick(object sender, EventArgs e)
        {
            this.radComboDemo.DropDownListElement.TextBox.TextBoxItem.Focus();
            this.radComboDemo.ShowDropDown();
            this.dropDownTimeout.Stop();
        }

        #endregion

        private void OnRadTextBox_TextChanged(object sender, EventArgs e)
        {
            this.radComboDemo.SelectedItem.Text = this.radTxtText.Text;
        }
    }
}
