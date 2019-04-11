using System;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.MenuStrip.MenuItemWithCustomElement
{
    public partial class Form1 : ExamplesForm
    {
		private RadDropDownList sizeDropDownList;
        private RadDropDownList fontDropDownList;
        private RadPageView pageView;
        private const string THEME = "ControlDefault";

        public Form1()
        {
            InitializeComponent();
            ThemeResolutionService.ApplyThemeToControlTree(this, THEME);
            this.SetEnabledQsfbButton(QSFButtons.ChangeTheme, false);            
        }

        void AddToolStrip()
        {
            RadCommandBar commandBar = new RadCommandBar();
            commandBar.ImageList = this.imageList1;

            CommandBarRowElement element = new CommandBarRowElement();
            element.AllowDrag = false;
            commandBar.Rows.Add(element);

            CommandBarStripElement toolStripItem = new CommandBarStripElement();
            toolStripItem.AllowDrag = false;
            toolStripItem.OverflowButton.Visibility = ElementVisibility.Collapsed;
            toolStripItem.StretchHorizontally = true;
            element.Strips.Add(toolStripItem);

            CommandBarButton button1 = new CommandBarButton();
            button1.ImageIndex = 0;
            toolStripItem.Items.Add(button1);

            CommandBarButton button2 = new CommandBarButton();
            button2.ImageIndex = 1;
            toolStripItem.Items.Add(button2);

            CommandBarButton button3 = new CommandBarButton();
            button3.ImageIndex = 2;
            toolStripItem.Items.Add(button3);

            CommandBarButton button4 = new CommandBarButton();
            button4.ImageIndex = 3;
            toolStripItem.Items.Add(button4);

            CommandBarButton button5 = new CommandBarButton();
            button5.ImageIndex = 4;
            toolStripItem.Items.Add(button5);

            commandBar.EndInit();

            RadMenuContentItem item = new RadMenuContentItem();
            item.ContentElement = new RadHostItem(commandBar);
            item.MinSize = new Size(120, 31);

            this.radMenuItem1.Items.Add(item);
        }

        void AddTabStrip()
        {
            fontDropDownList = new RadDropDownList();
            fontDropDownList.Margin = new Padding(25, 5, 5, 5);
            fontDropDownList.Text = "Select Font";
            fontDropDownList.Items.Add(new RadListDataItem("Arial"));
            fontDropDownList.Items.Add(new RadListDataItem("Tahoma"));
            fontDropDownList.Items.Add(new RadListDataItem("Times New Roman"));
            fontDropDownList.Items.Add(new RadListDataItem("Verdana"));

            sizeDropDownList = new RadDropDownList();
            sizeDropDownList.Margin = new Padding(25, 5, 5, 5);
            sizeDropDownList.Text = "8";
            sizeDropDownList.Items.Add(new RadListDataItem("7"));
            sizeDropDownList.Items.Add(new RadListDataItem("8"));
            sizeDropDownList.Items.Add(new RadListDataItem("9"));
            sizeDropDownList.Items.Add(new RadListDataItem("10"));
            sizeDropDownList.Items.Add(new RadListDataItem("11"));
            sizeDropDownList.Items.Add(new RadListDataItem("12"));

            pageView = new RadPageView();
            RadPageViewPage fontPage = new RadPageViewPage();
            fontPage.Text = "Font";
            fontPage.Controls.Add(fontDropDownList);
            pageView.Pages.Add(fontPage);
            RadPageViewPage sizePage = new RadPageViewPage();
            sizePage.Text = "Size";
            sizePage.Controls.Add(sizeDropDownList);
            pageView.Pages.Add(sizePage);

            RadMenuContentItem contentItem = new RadMenuContentItem();
            contentItem.ContentElement = new RadHostItem(pageView);
            contentItem.MinSize = new Size(120, 100);

            this.radMenuItem2.Items.Insert(6, contentItem);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AddToolStrip();
            AddTabStrip();
        }
    }
}