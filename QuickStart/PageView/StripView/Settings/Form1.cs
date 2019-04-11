using System;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.PageView.StripView.Settings
{
    public partial class Form1 : ExamplesForm
    {
        #region Fields

        private RadPageViewStripElement strip;
        private int imageIndex;

        #endregion

        #region Constructor/Initialization

        public Form1()
        {
            InitializeComponent();

            this.SetEnabledQsfbButton(QSFButtons.TransparentBackground | QSFButtons.ChangeTheme, false);

            this.strip = this.radPageView1.ViewElement as RadPageViewStripElement;
            this.strip.ItemDragMode = PageViewItemDragMode.Preview;

            ExamplesForm.FillComboFromEnum(this.stripAlignCombo, typeof(StripViewAlignment), this.strip.StripAlignment);
            ExamplesForm.FillComboFromEnum(this.itemAlignCombo, typeof(StripViewItemAlignment), this.strip.ItemAlignment);
            ExamplesForm.FillComboFromEnum(this.fitModeCombo, typeof(StripViewItemFitMode), this.strip.ItemFitMode);
            ExamplesForm.FillComboFromEnum(this.sizeModeCombo, typeof(PageViewItemSizeMode), this.strip.ItemSizeMode);
            ExamplesForm.FillComboFromEnum(this.orientationCombo, typeof(PageViewContentOrientation), this.strip.ItemContentOrientation);

            this.spacingSpin.Value = this.strip.ItemSpacing;

            foreach (RadPageViewPage page in this.radPageView1.Pages)
            {
                page.Image = PageViewImages.Images[this.imageIndex++];
                page.Controls.Add(PageViewLabels.CreateLabel());
            }

            this.radPageView1.NewPageRequested += radPageView1_NewPageRequested;
        }

        protected override void OnLoad(EventArgs e)
        {
            ExamplesForm.CenterControlOnParent(this.radPageView1);

            base.OnLoad(e);
        }

        protected override string GetExampleDefaultTheme()
        {
            return "ControlDefault";
        }

        #endregion

        #region Event Handlers

        private void radPageView1_NewPageRequested(object sender, EventArgs e)
        {
            this.addPageButton_Click(null, EventArgs.Empty);
        }

        private void stripAlignCombo_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            RadListDataItem item = this.stripAlignCombo.SelectedItem as RadListDataItem;
            this.strip.StripAlignment = (StripViewAlignment)item.Value;
        }

        private void itemAlignCombo_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            RadListDataItem item = this.itemAlignCombo.SelectedItem as RadListDataItem;
            this.strip.ItemAlignment = (StripViewItemAlignment)item.Value;
        }

        private void fitModeCombo_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            RadListDataItem item = this.fitModeCombo.SelectedItem as RadListDataItem;
            this.strip.ItemFitMode = (StripViewItemFitMode)item.Value;
        }

        private void sizeModeCombo_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            RadListDataItem item = this.sizeModeCombo.SelectedItem as RadListDataItem;
            this.strip.ItemSizeMode = (PageViewItemSizeMode)item.Value;
        }

        private void orientationCombo_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            RadListDataItem item = this.orientationCombo.SelectedItem as RadListDataItem;
            this.strip.ItemContentOrientation = (PageViewContentOrientation)item.Value;
        }

        private void spacingSpin_ValueChanged(object sender, EventArgs e)
        {
            strip.ItemSpacing = (int)this.spacingSpin.Value;
        }

        private void addPageButton_Click(object sender, EventArgs e)
        {
            RadPageViewPage page = new RadPageViewPage();
            page.Text = "Page " + (strip.Items.Count + 1);

            if(this.imageIndex == PageViewImages.Images.Length)
            {
                this.imageIndex = 0;
            }

            page.Image = PageViewImages.Images[this.imageIndex++];
            page.Controls.Add(PageViewLabels.CreateLabel());

            this.radPageView1.Pages.Add(page);
            this.radPageView1.SelectedPage = page;
        }

        #endregion
    }
}
