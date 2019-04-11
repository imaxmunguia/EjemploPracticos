using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Telerik.Examples.WinControls.PageView
{
    class PageViewLabels
    {
        public static string[] Texts;
        public static int currIndex = 0;
        private static Font labelFont;

        static PageViewLabels()
        {
            Texts = new string[10];
            int index = 0;
            Texts[index++] = "The " + Telerik.WinControls.VersionNumber.MarketingVersion + " is an important milestone in the development of RadControls for WinForms, not only because the toolset is expanded with two new brand new controls (RadReminder and RadDesktopAlert), but because it brings many enterprise features and unprecedented level of customization to RadGridView for WinForms, which we have been developing over the last two releases. In addition, in our attempt to provide more intelligent, lighter, better performing, and easily customizable controls, we are presenting you the successors of several controls, which were due for revamp.";
            Texts[index++] = "Such controls are RadPageView, RadListControl and RadDropDownList.";
            Texts[index++] = "RadDesktopAlert is a modern notification control, which mimics the alerts found in Microsoft Outlook.";
            Texts[index++] = "RadPageView is the successor of RadTabStrip and RadPanelBar by providing different views over a collection of pages. Each page is a stand-alone Panel where controls may be added through the Visual Studio’s Designer. The control is fully customizable yet greatly optimized for both memory consumption and performance.";
            Texts[index++] = "Available views are StripView, StackView and OutlookView.";
            Texts[index++] = "StripView encapsulates the TabControl view, but offers a myriad of settings which have been requested by our customers, allowing for deep customization of the items’ strip and content area, such as the position of the strip (Top, Right, Bottom and Left), item alignment and better fitment in the available space, extended scrolling and overflow support, as well as a dedicated close button for each tab/page.";
            Texts[index++] = "StackView is the same as PanelBar’s base view. Items are organized in a stack (either vertical or horizontal) and the content area is either centered or aligned at the top or bottom.";
            Texts[index++] = "OutlookView is based on the StackView and provides the same look-and-feel as in Microsoft's Outlook Navigation Bar.";
            Texts[index++] = "The brand new RadListControl and RadDropDownList controls will entirely replace the existing RadListBox and RadComboBox controls.";
            Texts[index++] = "The new controls will provide the extensibility options that are currently lacking, and will offer much better performance than the ongoing versions, due to the use of a new generic data engine, developed for RadGridView.";

            labelFont = new Font("Segoe UI", 10);
        }

        public static Label CreateLabel()
        {
            if (currIndex >= Texts.Length)
            {
                currIndex = 0;
            }

            Label label = new Label();
            label.AutoSize = false;
            label.Font = labelFont;
            label.Dock = DockStyle.Fill;
            label.Text = Texts[currIndex++];
            label.TextAlign = ContentAlignment.MiddleCenter;

            return label;
        }
    }
}
