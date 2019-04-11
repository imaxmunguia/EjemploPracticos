using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.UI;

using View = Telerik.WinControls.UI.RadPageView;

namespace Telerik.Examples.WinControls.PageView.StripView.CheckButtons
{
    public partial class Form1 : ExamplesForm
    {
        #region Static

        private const string themeName = "StripViewCheckButtons";
        

        #endregion

        #region Fields

        private View view;
        private RadPageViewStripElement strip;

        #endregion

        #region Constructor

        public Form1()
        {
            InitializeComponent();

            this.SetEnabledQsfbButton(QSFButtons.TransparentBackground | QSFButtons.ChangeTheme, false);

            this.view = new Telerik.WinControls.UI.RadPageView();
            this.view.Size = new Size(400, 300);
            this.view.Anchor = AnchorStyles.None;
            this.view.Parent = this;
            this.strip = this.view.ViewElement as RadPageViewStripElement;
            this.view.SelectedPageChanged += new EventHandler(view_SelectedPageChanged);
            this.view.ThemeName = themeName;

            PageViewLabels.currIndex = 0;

            for (int i = 0; i < 10; i++)
            {
                RadPageViewPage page = new RadPageViewPage();
                page.Text = PageViewImages.Names[i];
                page.Image = PageViewImages.Images[i];
                page.Controls.Add(PageViewLabels.CreateLabel());

                this.view.Pages.Add(page);
            }

            this.strip.StripButtons = StripViewButtons.Scroll | StripViewButtons.ItemList;
            this.enableAnimationCheck.Checked = strip.AnimatedStripScrolling;
        }

        static Form1()
        {
            ThemeResolutionService.LoadPackageResource("Telerik.Examples.WinControls.PageView.StripView.CheckButtons.StripViewCheckButtons.tssp");
        }

        #endregion

        #region Overrides

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            ExamplesForm.FillComboFromEnum(this.animationTypeCombo, typeof(RadEasingType), this.strip.StripScrollingAnimation);
            ExamplesForm.CenterControlOnParent(this.view);
        }

        protected override string GetExampleDefaultTheme()
        {
            return themeName;
        }

        #endregion

        #region Event Handlers

        private void view_SelectedPageChanged(object sender, EventArgs e)
        {
            this.strip.Header.Image = this.view.SelectedPage.Image;
        }

        private void enableAnimationCheck_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.strip.AnimatedStripScrolling = args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On;
        }

        private void animationTypeCombo_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            RadListDataItem item = this.animationTypeCombo.SelectedItem as RadListDataItem;
            this.strip.StripScrollingAnimation = (RadEasingType)item.Value;
        }

        private void shrinkItemsCheck_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.strip.ItemFitMode = StripViewItemFitMode.Shrink;
            }
            else
            {
                this.strip.ItemFitMode = StripViewItemFitMode.None;
            }
        }

        #endregion
    }
}
