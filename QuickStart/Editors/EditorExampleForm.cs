using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.Editors.ComboBox
{
    /// <summary>
    /// This is a base control for all RadComboBox examples.
    /// </summary>
    public partial class EditorExampleBaseForm : ExamplesForm
    {
        private AnimatedPropertySetting fadeAnimation;

        public EditorExampleBaseForm()
        {
            InitializeComponent();
            this.radPanelDemoHolder.ThemeClassName = "Telerik.Examples.WinControls.RadEditorHolder";
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            //this.BackColor = Color.Transparent;
            this.AutoScaleMode = AutoScaleMode.None;
                       
        }

        /// <summary>
        /// Resets the location of the panel that holds the example so that it
        /// always resides in the middle of the available space.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnResize(EventArgs e)
        {
            if (this.radPanelDemoHolder != null)
            {
                float xCoord = ((float)(this.Width - this.radPanelDemoHolder.Width)) / 2;
                float yCoord = ((float)(this.Height - this.radPanelDemoHolder.Height)) / 2;

                this.radPanelDemoHolder.Location = Point.Round(new PointF(xCoord, yCoord));
            }

            base.OnResize(e);
        }

        /// <summary>
        /// Overidden in order to start a fade-in animation that shows the panel that
        /// holds the demo. Before the animation is started, all child controls in the panel
        /// are hidden.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            bool enableFadeAnimation = this.IsFadeAnimationEnabled();

            if (!enableFadeAnimation)
            {
                return;
            }

            foreach (Control currentControl in this.radPanelDemoHolder.Controls)
            {
                RadControl radControl = currentControl as RadControl;

                if (radControl != null)
                {
                    radControl.Visible = false;
                }
            }

            fadeAnimation = new AnimatedPropertySetting(
                RadItem.OpacityProperty, 25, 10, (object)0.01);
            fadeAnimation.AnimationFinished += new AnimationFinishedEventHandler(loadAnimation_AnimationFinished);
            fadeAnimation.StartValue = 0.0;
            fadeAnimation.EndValue = 1.0;
            fadeAnimation.ApplyValue(this.radPanelDemoHolder.PanelElement);
        }

        protected virtual bool IsFadeAnimationEnabled()
        {
            return true;
        }

        /// <summary>
        /// At the end of the animation, all child controls of the panel are shown.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadAnimation_AnimationFinished(object sender, AnimationStatusEventArgs e)
        {
            foreach (Control currentControl in this.radPanelDemoHolder.Controls)
            {
                RadControl radControl = currentControl as RadControl;

                if (radControl != null)
                {
                    radControl.Visible = true;
                }
            }
        }

        #region IDisposable Members

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (this.components != null)
                {
                    components.Dispose();
                }

                if (this.fadeAnimation != null)
                {
                    this.fadeAnimation.Stop(this.radPanelDemoHolder.PanelElement);
                }
            }
            base.Dispose(disposing);
        }

        #endregion
    }
}
