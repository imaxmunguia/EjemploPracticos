using System;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.Primitives;
using Telerik.WinControls.Themes;

namespace Telerik.Examples.WinControls.RibbonBar.FirstLook
{
    public partial class Form1 : ExamplesForm
    {
        private static readonly Color[,] PaleteColors = new Color[3, 8] {     
            { Color.Black, Color.FromArgb(127, 127, 127), Color.FromArgb(136, 0, 21), Color.FromArgb(237, 28, 36), Color.FromArgb(255, 127, 39), Color.FromArgb(255, 242, 0), Color.FromArgb(34, 177, 76), Color.FromArgb(0, 162, 232) }, 
            { Color.White, Color.FromArgb(195, 195, 195), Color.FromArgb(185, 122, 87), Color.FromArgb(255, 174, 201), Color.FromArgb(255, 201, 14), Color.FromArgb(239, 228, 176), Color.FromArgb(181, 230, 29), Color.FromArgb(153, 217, 234) }, 
            { Color.FromArgb(103, 91, 234), Color.FromArgb(33, 71, 201), Color.FromArgb(192, 221, 42), Color.FromArgb(40, 17, 41), Color.FromArgb(218, 74, 20), Color.FromArgb(64, 0, 192), Color.FromArgb(12, 100, 89), Color.FromArgb(45, 225, 241) }
        };

        public Form1()
        {
            InitializeComponent();

            this.SetEnabledQsfbButton(QSFButtons.ChangeTheme, false);
            this.SetEnabledQsfbButton(QSFButtons.TransparentBackground, false);

            this.radRibbonBar1.RibbonBarElement.TabStripElement.SelectedItem =
                this.radRibbonBar1.RibbonBarElement.TabStripElement.Items[0];

            this.radGalleryElement1.SelectedItem = this.radGalleryElement1.Items[0] as RadGalleryItem;


            this.InitializeButtonGroupAsColorPalete(this.radRibbonBarButtonGroup14, 6);
            this.InitializeButtonGroupAsColorPalete(this.radRibbonBarButtonGroup15, 8);

            this.radRibbonBarBackstageView1.ItemClicked += new EventHandler<BackstageItemEventArgs>(radRibbonBarBackstageView1_ItemClicked);            
        }

        protected override void OnLoad(EventArgs e)
        {
            ThemeResolutionService.ApplyThemeToControlTree(this.settingsPanel, MainForm.DefaultTheme);
        }

        private void InitializeButtonGroupAsColorPalete(RadRibbonBarButtonGroup group, int colorBoxesPerRow)
        {
            group.Orientation = Orientation.Vertical;
            group.ShowBackColor = false;
            group.ShowBorder = false;

            int rows = 3;

            for (int i = 1; i <= rows; i++)
            {
                RadRibbonBarButtonGroup newRow = new RadRibbonBarButtonGroup();
                newRow.Name = "row" + i;
                newRow.Orientation = Orientation.Horizontal;
                newRow.ShowBackColor = false;
                newRow.ShowBorder = false;
                newRow.Padding = new Padding(2);
                group.Items.Add(newRow);

                this.AddColorButtonsInButtonGroup(i - 1, colorBoxesPerRow, newRow);
            }
        }

        private void AddColorButtonsInButtonGroup(int rowIndex, int colorBoxesPerRow, RadRibbonBarButtonGroup group)
        {
            int count = colorBoxesPerRow;

            for (int i = 1; i <= count; i++)
            {
                RadButtonElement button = new RadButtonElement();
                button.Name = "button" + rowIndex + i;
                button.Text = String.Empty;
                button.Margin = new Padding(1);
                button.MinSize = new Size(16, 16);
                button.MaxSize = new Size(16, 16);
                button.ShowBorder = false;
                
                FillPrimitive fillPrimitive = button.ButtonFillElement;
                fillPrimitive.Margin = new Padding(1);
                fillPrimitive.BackColor = PaleteColors[rowIndex, i - 1];
                fillPrimitive.GradientStyle = GradientStyles.Solid;

                group.Items.Add(button);
            }
        }

        private void radButtonElement49_Click(object sender, EventArgs e)
        {
            using (RadColorDialog dialog = new RadColorDialog())
            {
                dialog.ShowDialog();
            }
        }
         
        void radRibbonBarBackstageView1_ItemClicked(object sender, BackstageItemEventArgs e)
        {
            if (e.Item is BackstageButtonItem)
            {
                this.radRibbonBarBackstageView1.HidePopup();
            }
        }

        private void radButtonSetBlackTheme_Click(object sender, EventArgs e)
        {
            string theme = "Office2010Black";
            this.radRibbonBar1.ApplicationMenuStyle = ApplicationMenuStyle.ApplicationMenu;
            this.SetThemeName(theme);
        }

        private void radButtonSetDefaultTheme_Click(object sender, EventArgs e)
        {
            string theme = "ControlDefault";
            this.radRibbonBar1.ApplicationMenuStyle = ApplicationMenuStyle.BackstageView;
            this.SetThemeName(theme);
        }

        private void radButtonSetSilverTheme_Click(object sender, EventArgs e)
        {
            string theme = "Office2010Silver";
            this.radRibbonBar1.ApplicationMenuStyle = ApplicationMenuStyle.ApplicationMenu;
            this.SetThemeName(theme);
        }

        private void radGalleryElement1_GalleryItemHover(object sender, GalleryItemHoverEventArgs args)
        {
            this.pictureBoxTool.Image = args.GalleryItem.Image;
        }

        private void radButtonElement54_Click(object sender, EventArgs e)
        {
            string theme = "Office2010Black";
            this.radRibbonBar1.ApplicationMenuStyle = ApplicationMenuStyle.BackstageView;
            this.SetThemeName(theme);
        }

        private void radButtonElement55_Click(object sender, EventArgs e)
        {
            string theme = "Office2010Blue";
            this.radRibbonBar1.ApplicationMenuStyle = ApplicationMenuStyle.BackstageView;
            this.SetThemeName(theme);
        }

        private void radButtonElement56_Click(object sender, EventArgs e)
        {
            string theme = "Office2010Silver";
            this.radRibbonBar1.ApplicationMenuStyle = ApplicationMenuStyle.BackstageView;
            this.SetThemeName(theme);
        }

        private void SetThemeName(string themeName)
        {
            this.radRibbonBar1.ThemeName = themeName;
            this.radScrollablePanel1.ThemeName = themeName;
            this.radRibbonBarBackstageView1.ThemeName = themeName;
            this.radSeparator1.ThemeName = themeName;
            this.radSeparator2.ThemeName = themeName;
            this.radSeparator3.ThemeName = themeName;

            this.radButton1.ThemeName = themeName;
            this.radButton2.ThemeName = themeName;
            this.radButton3.ThemeName = themeName;
            this.radButton4.ThemeName = themeName;
            this.radButton5.ThemeName = themeName;
            this.radButton6.ThemeName = themeName;
        }
    }
}