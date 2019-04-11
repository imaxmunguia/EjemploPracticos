using System;
using System.Drawing;
using Telerik.Examples.WinControls.Editors.ComboBox;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.RadDesktopAlert.FirstLook
{
    public partial class Form1 : EditorExampleBaseForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Overrides

        protected override bool IsFadeAnimationEnabled()
        {
            return false;
        }

        protected override string GetExampleDefaultTheme()
        {
            return "ControlDefault";
        }

        #endregion

        #region Event handling

        private void OnThemesList_IndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            this.radDesktopAlert1.ThemeName = this.ddThemeName.SelectedItem.Text;
        }

        private void OnPositionList_IndexChaned(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            this.radDesktopAlert1.ScreenPosition = (AlertScreenPosition)Enum.Parse(typeof(AlertScreenPosition), this.ddScreenPosition.SelectedItem.Text);
        }

        private void SpinEditorWidth_ValueChanged(object sender, EventArgs e)
        {
            this.radDesktopAlert1.FixedSize = new Size((int)this.spinEditorWidth.Value, (int)this.spinEditorHeight.Value);
        }
        private void SpinEditorHeight_ValueChanged(object sender, EventArgs e)
        {
            this.radDesktopAlert1.FixedSize = new Size((int)this.spinEditorWidth.Value, (int)this.spinEditorHeight.Value);
        }

        private void fadeInCheck_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (this.fadeInCheck.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.radDesktopAlert1.FadeAnimationType = this.radDesktopAlert1.FadeAnimationType | FadeAnimationType.FadeIn;
            }
            else
            {
                this.radDesktopAlert1.FadeAnimationType = this.radDesktopAlert1.FadeAnimationType & ~FadeAnimationType.FadeIn;
            }
        }

        private void fadeOutCheck_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (this.fadeOutCheck.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.radDesktopAlert1.FadeAnimationType = this.radDesktopAlert1.FadeAnimationType | FadeAnimationType.FadeOut;
            }
            else
            {
                this.radDesktopAlert1.FadeAnimationType = (this.radDesktopAlert1.FadeAnimationType & ~FadeAnimationType.FadeOut);
            }
        }

        private void spinFadeDuration_ValueChanged(object sender, EventArgs e)
        {
            this.radDesktopAlert1.FadeAnimationFrames = (int)this.spinFadeDuration.Value;
        }

        private void autoCloseCheck_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radDesktopAlert1.AutoClose = this.autoCloseCheck.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On;
        }

        private void closeButtonCheck_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radDesktopAlert1.ShowCloseButton = args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On;
        }

        private void pinButtonCheck_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radDesktopAlert1.ShowPinButton = args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On;
        }

        private void optionsButtonCheck_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radDesktopAlert1.ShowOptionsButton = args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On;
        }

        private void checkPopupAnimation_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radDesktopAlert1.PopupAnimation = args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On;
        }

        private void ddAnimationDirection_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            this.radDesktopAlert1.PopupAnimationDirection = (RadDirection)Enum.Parse(typeof(RadDirection), this.ddAnimationDirection.SelectedItem.Text);
        }

        private void spinPopupAnimationFrames_ValueChanged(object sender, EventArgs e)
        {
            this.radDesktopAlert1.PopupAnimationFrames = (int)this.spinPopupAnimationFrames.Value;
        }
        
        private void btnPreview_Click(object sender, EventArgs e)
        {
            this.radDesktopAlert1.CaptionText = this.txtCaption.Text;
            this.radDesktopAlert1.ContentText = this.txtContent.Text;
            this.radDesktopAlert1.Show();
        }

        private void SpinOpacity_ValueChanged(object sender, EventArgs e)
        {
            this.radDesktopAlert1.Opacity = (float)this.spinOpacity.Value;
        }

        private void autoCloseDelaySpin_ValueChanged(object sender, EventArgs e)
        {
            this.radDesktopAlert1.AutoCloseDelay = (int)this.autoCloseDelaySpin.Value;
        }

        #endregion
    }
}
