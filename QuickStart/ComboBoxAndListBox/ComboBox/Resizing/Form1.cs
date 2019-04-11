using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using System.IO;
using Telerik.WinControls.UI;
using Telerik.Examples.WinControls.Editors.ComboBox;

namespace Telerik.Examples.WinControls.ComboBoxAndListBox.ComboBox.Resizing
{
	public partial class Form1 : EditorExampleBaseForm
	{
        private Timer showDropDownTimeout;

		public Form1()
		{
			InitializeComponent();           
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
           

            this.radComboDemo.ListElement.AutoSizeItems = true;
            this.showDropDownTimeout = new Timer(this.components);
            this.showDropDownTimeout.Tick += new EventHandler(showDropDownTimeout_Tick);
            this.showDropDownTimeout.Interval = 1000;
            this.SelectedControl = this.radComboDemo;
            this.radComboDemo.DefaultItemsCountInDropDown = 20;
            this.radRadioNone.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;

            this.radComboDemo.ItemDataBound += new Telerik.WinControls.UI.ListItemDataBoundEventHandler(radComboDemo_ItemDataBound);

            this.LoadData();
            this.showDropDownTimeout.Start();
            this.radComboDemo.DropDownSizingMode = Telerik.WinControls.UI.SizingMode.None;
           
        }
        

        private void radComboDemo_ItemDataBound(object sender, ListItemDataBoundEventArgs e)
        {
            RadListDataItem item = e.NewItem;
            item.Text += " " +
                (item.DataBoundItem as DataRowView)["FirstName"];

            Telerik.Examples.WinControls.DataSources.NorthwindDataSet.EmployeesRow row =
                ((item.DataBoundItem as DataRowView).Row as Telerik.Examples.WinControls.DataSources.NorthwindDataSet.EmployeesRow);

            item.TextImageRelation = TextImageRelation.ImageBeforeText;
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

        void showDropDownTimeout_Tick(object sender, EventArgs e)
        {
            this.radComboDemo.DropDownListElement.TextBox.TextBoxItem.Focus();
            this.radComboDemo.ShowDropDown();
            this.showDropDownTimeout.Stop();
        }

        private void OnRadioSizingMode_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if (radRadioNone.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                radComboDemo.DropDownSizingMode = Telerik.WinControls.UI.SizingMode.None;
            }

            else if (radRadioRightBottom.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                radComboDemo.DropDownSizingMode = Telerik.WinControls.UI.SizingMode.RightBottom;
            }

            else if (radRadioUpDown.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                radComboDemo.DropDownSizingMode = Telerik.WinControls.UI.SizingMode.UpDown;
            }

            else if (radRadioBottomUpDown.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                radComboDemo.DropDownSizingMode = Telerik.WinControls.UI.SizingMode.UpDownAndRightBottom;
            }
        }
    }
}
