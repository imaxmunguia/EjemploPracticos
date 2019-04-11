using System;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.PageView.ViewSwitch
{
    public partial class Form1 : ExamplesForm
    {
        #region Constructor/Initialization

        public Form1()
        {
            InitializeComponent();

            this.radPageView1.Anchor = AnchorStyles.None;
            this.SetEnabledQsfbButton(QSFButtons.ChangeTheme | QSFButtons.TransparentBackground, false);

            ExamplesForm.FillComboFromEnum(this.viewModeCombo, typeof(PageViewMode), this.radPageView1.ViewMode);
        }

        protected override void OnLoad(EventArgs e)
        {
            this.AddSamplePages();
            base.OnLoad(e);

            ExamplesForm.CenterControlOnParent(this.radPageView1);
        }

        protected override string GetExampleDefaultTheme()
        {
            return "ControlDefault";
        }

        private void AddSamplePages()
        {
            PageViewLabels.currIndex = 0;

            for (int i = 0; i < 5; i++)
            {
                RadPageViewPage page = new RadPageViewPage();
                page.Text = PageViewImages.Names[i];
                page.Image = PageViewImages.Images[i];
                page.Title = page.Text + " - [Title]";
                page.Description = page.Text + " - [Description]";

                page.Controls.Add(PageViewLabels.CreateLabel());

                this.radPageView1.Pages.Add(page);
            }
        }

        #endregion

        #region Event Handlers

        private void viewModeCombo_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            RadListDataItem item = this.viewModeCombo.SelectedItem as RadListDataItem;
            this.radPageView1.ViewMode = (PageViewMode)item.Value;
            if (this.radPageView1.ViewMode == PageViewMode.Stack)
            {
                RadPageViewStackElement stack = this.radPageView1.ViewElement as RadPageViewStackElement;
                stack.ItemSelectionMode = StackViewItemSelectionMode.ContentWithSelected;
            }
        }

        #endregion
    }
}
