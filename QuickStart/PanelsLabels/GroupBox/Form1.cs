﻿using System;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;

namespace Telerik.Examples.WinControls.PanelsLabels.GroupBox
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();
            this.SetEnabledQsfbButton(QSFButtons.ChangeTheme, true);
            this.SetEnabledQsfbButton(QSFButtons.TransparentBackground, true);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.radRadioButton2.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.radRadioButton8.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.radRadioButton3.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
        }

        private void radRadioButton2_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if (args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.radGroupBox1.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Standard;
            }
        }

        private void radRadioButton1_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if (args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.radGroupBox1.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            }
        }

        private void radRadioButton3_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if (args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.radGroupBox1.HeaderPosition = Telerik.WinControls.UI.HeaderPosition.Top;
            }
        }

        private void radRadioButton4_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if (args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.radGroupBox1.HeaderPosition = Telerik.WinControls.UI.HeaderPosition.Right;
            }
        }

        private void radRadioButton5_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if (args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.radGroupBox1.HeaderPosition = Telerik.WinControls.UI.HeaderPosition.Bottom;
            }
        }

        private void radRadioButton6_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if (args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.radGroupBox1.HeaderPosition = Telerik.WinControls.UI.HeaderPosition.Left;
            }
        }

        private void radRadioButton7_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if (args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.radGroupBox1.HeaderTextImageRelation = TextImageRelation.ImageAboveText;
            }
        }

        private void radRadioButton8_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if (args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.radGroupBox1.HeaderTextImageRelation = TextImageRelation.ImageBeforeText;
            }
        }

        private void radRadioButton9_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if (args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.radGroupBox1.HeaderTextImageRelation = TextImageRelation.Overlay;
            }
        }

        private void radRadioButton10_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if (args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.radGroupBox1.HeaderTextImageRelation = TextImageRelation.TextAboveImage;
            }
        }

        private void radRadioButton11_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if (args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.radGroupBox1.HeaderTextImageRelation = TextImageRelation.TextBeforeImage;
            }
        }
    }
}
