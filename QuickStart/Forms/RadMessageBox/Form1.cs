using System;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.Themes;

namespace Telerik.Examples.WinControls.Forms.RadMessageBox
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();
            this.Load+=new EventHandler(Form1_Load);
            this.radBtnShow.Click+=new EventHandler(radButton1_Click);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.radComboButtons.SelectedIndex = 0;
            this.radComboMessageType.SelectedIndex = 0;
            this.radComboThemes.SelectedIndex = 0;
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = this.RetrieveButtonsFromCombo();
            RadMessageIcon icon = this.RetrieveIconFromCombo();
            RightToLeft rtl = RightToLeft.No;

            if (this.radCheckRTL.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                rtl = RightToLeft.Yes;
            }

            DialogResult ds;

            string themeName = this.radComboThemes.SelectedItem.Text;
            Telerik.WinControls.RadMessageBox.SetThemeName(themeName);
            Telerik.WinControls.RadMessageBox.Instance.MinimumSize = new System.Drawing.Size(100, 100);
            ds = Telerik.WinControls.RadMessageBox.Show(this, this.radTxtMessage.Text, this.radTxtCaption.Text, buttons,
                icon, MessageBoxDefaultButton.Button1, rtl);

            this.radTxtDialogResult.Text = String.Format("{0}", ds);
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = this.RetrieveButtonsFromCombo();
            MessageBoxIcon icon = MessageBoxIcon.None;

            switch (this.radComboMessageType.SelectedIndex)
            {
                case 1:
                    icon = MessageBoxIcon.Information;
                    break;
                case 2:
                    icon = MessageBoxIcon.Question;
                    break;
                case 3:
                    icon = MessageBoxIcon.Exclamation;
                    break;
                case 4:
                    icon = MessageBoxIcon.Error;
                    break;
            }

            DialogResult ds;

            if (this.radCheckRTL.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                ds = MessageBox.Show(this, this.radTxtMessage.Text, this.radTxtCaption.Text,
                    buttons, icon, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
            }
            else
            {
                ds = MessageBox.Show(this, this.radTxtMessage.Text, this.radTxtCaption.Text,
                    buttons, icon);
            }

            this.radTxtDialogResult.Text = String.Format("{0}", ds);
        }

        private MessageBoxButtons RetrieveButtonsFromCombo()
        {
            switch (this.radComboButtons.SelectedIndex)
            {
                case 1: return MessageBoxButtons.OKCancel;
                case 2: return MessageBoxButtons.YesNo;
                case 3: return MessageBoxButtons.YesNoCancel;
                case 4: return MessageBoxButtons.RetryCancel;
                case 5: return MessageBoxButtons.AbortRetryIgnore;
            }

            return MessageBoxButtons.OK;
        }

        private RadMessageIcon RetrieveIconFromCombo()
        {
            switch (this.radComboMessageType.SelectedIndex)
            {
                case 1: return RadMessageIcon.Info;
                case 2: return RadMessageIcon.Question;
                case 3: return RadMessageIcon.Exclamation;
                case 4: return RadMessageIcon.Error;
            }
            return RadMessageIcon.None;
        }
    }
}
