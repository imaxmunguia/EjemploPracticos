using System;
using System.Collections.Generic;
using System.Text;
using Telerik.WinControls;
using System.Drawing;

namespace Telerik.Examples.WinControls.PageView
{
    class PageViewImages
    {
        public static Image[] Images;
        public static string[] Names;

        static PageViewImages()
        {
            Names = new string[] { 
                "Brush.png", "Calendar 1.png", "CD Burner.png", 
                "Chart Pie.png", "Configuration Tools.png", "Configuration.png", 
                "Dice.png", "Download.png", "Home.png", "Logout.png" };

            Type type = typeof(PageViewImages);
            string path = "Telerik.Examples.WinControls.PageView.Resources.";
            Images = new Image[10];

            for (int i = 0; i < 10; i++)
            {
                Images[i] = ResourceHelper.ImageFromResource(type, path + Names[i]);
            }
        }
    }
}
