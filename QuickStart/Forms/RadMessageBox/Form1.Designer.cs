using Telerik.WinControls.UI;
using System.Collections.Generic;
namespace Telerik.Examples.WinControls.Forms.RadMessageBox
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radTxtMessage = new Telerik.WinControls.UI.RadTextBox();
            this.radCheckRTL = new Telerik.WinControls.UI.RadCheckBox();
            this.radTxtCaption = new Telerik.WinControls.UI.RadTextBox();
            this.radBtnShow = new Telerik.WinControls.UI.RadButton();
            this.radComboMessageType = new Telerik.WinControls.UI.RadDropDownList();
            this.radComboBoxItem7 = new Telerik.WinControls.UI.RadListDataItem();
            this.radComboBoxItem8 = new Telerik.WinControls.UI.RadListDataItem();
            this.radComboBoxItem9 = new Telerik.WinControls.UI.RadListDataItem();
            this.radComboBoxItem10 = new Telerik.WinControls.UI.RadListDataItem();
            this.radComboBoxItem11 = new Telerik.WinControls.UI.RadListDataItem();
            this.radComboButtons = new Telerik.WinControls.UI.RadDropDownList();
            this.radComboBoxItem1 = new Telerik.WinControls.UI.RadListDataItem();
            this.radComboBoxItem2 = new Telerik.WinControls.UI.RadListDataItem();
            this.radComboBoxItem3 = new Telerik.WinControls.UI.RadListDataItem();
            this.radComboBoxItem4 = new Telerik.WinControls.UI.RadListDataItem();
            this.radComboBoxItem5 = new Telerik.WinControls.UI.RadListDataItem();
            this.radComboBoxItem6 = new Telerik.WinControls.UI.RadListDataItem();
            this.radComboThemes = new Telerik.WinControls.UI.RadDropDownList();
            this.radComboBoxItem15 = new Telerik.WinControls.UI.RadListDataItem();
            this.radComboBoxItem16 = new Telerik.WinControls.UI.RadListDataItem();
            this.radComboBoxItem17 = new Telerik.WinControls.UI.RadListDataItem();
            this.radComboBoxItem18 = new Telerik.WinControls.UI.RadListDataItem();
            this.radComboBoxItem19 = new Telerik.WinControls.UI.RadListDataItem();
            this.radComboBoxItem20 = new Telerik.WinControls.UI.RadListDataItem();
            this.radGroupSettings = new Telerik.WinControls.UI.RadGroupBox();
            this.radLblDialog = new Telerik.WinControls.UI.RadLabel();
            this.radLblTheme = new Telerik.WinControls.UI.RadLabel();
            this.radLblButtons = new Telerik.WinControls.UI.RadLabel();
            this.radLblType = new Telerik.WinControls.UI.RadLabel();
            this.radLblText = new Telerik.WinControls.UI.RadLabel();
            this.radLblCaption = new Telerik.WinControls.UI.RadLabel();
            this.radTxtDialogResult = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTxtMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckRTL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTxtCaption)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBtnShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radComboMessageType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radComboButtons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radComboThemes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupSettings)).BeginInit();
            this.radGroupSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLblDialog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLblTheme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLblButtons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLblType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLblText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLblCaption)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTxtDialogResult)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radGroupSettings);
            this.settingsPanel.Location = new System.Drawing.Point(940, 1);
            // 
            // 
            // 
            this.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black;
            this.settingsPanel.Size = new System.Drawing.Size(200, 597);
            this.settingsPanel.Controls.SetChildIndex(this.radGroupSettings, 0);
            // 
            // radTxtMessage
            // 
            this.radTxtMessage.AcceptsReturn = true;
            this.radTxtMessage.ForeColor = System.Drawing.Color.Black;
            this.radTxtMessage.Location = new System.Drawing.Point(9, 94);
            this.radTxtMessage.Multiline = true;
            this.radTxtMessage.Name = "radTxtMessage";
            // 
            // 
            // 
            this.radTxtMessage.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radTxtMessage.RootElement.StretchVertically = true;
            this.radTxtMessage.Size = new System.Drawing.Size(144, 41);
            this.radTxtMessage.TabIndex = 0;
            this.radTxtMessage.Text = "Hello, World!";
            // 
            // radCheckRTL
            // 
            this.radCheckRTL.AllowShowFocusCues = true;
            this.radCheckRTL.BackColor = System.Drawing.Color.Transparent;
            this.radCheckRTL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.radCheckRTL.Location = new System.Drawing.Point(9, 306);
            this.radCheckRTL.Name = "radCheckRTL";
            // 
            // 
            // 
            this.radCheckRTL.RootElement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.radCheckRTL.Size = new System.Drawing.Size(81, 17);
            this.radCheckRTL.TabIndex = 9;
            this.radCheckRTL.Text = "RightToLeft";
            // 
            // radTxtCaption
            // 
            this.radTxtCaption.ForeColor = System.Drawing.Color.Black;
            this.radTxtCaption.Location = new System.Drawing.Point(9, 49);
            this.radTxtCaption.Name = "radTxtCaption";
            this.radTxtCaption.NullText = "Type caption...";
            // 
            // 
            // 
            this.radTxtCaption.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radTxtCaption.Size = new System.Drawing.Size(144, 20);
            this.radTxtCaption.TabIndex = 1;
            this.radTxtCaption.Text = "Message";
            // 
            // radBtnShow
            // 
            this.radBtnShow.AllowShowFocusCues = true;
            this.radBtnShow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radBtnShow.Location = new System.Drawing.Point(456, 284);
            this.radBtnShow.Name = "radBtnShow";
            // 
            // 
            // 
            this.radBtnShow.Size = new System.Drawing.Size(229, 30);
            this.radBtnShow.TabIndex = 5;
            this.radBtnShow.Text = "Show RadMessageBox";
            // 
            // radComboMessageType
            // 
            this.radComboMessageType.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.radComboMessageType.ForeColor = System.Drawing.Color.Black;
            this.radComboMessageType.Items.AddRange(new List<RadListDataItem>( new RadListDataItem[] {
            this.radComboBoxItem7,
            this.radComboBoxItem8,
            this.radComboBoxItem9,
            this.radComboBoxItem10,
            this.radComboBoxItem11}));
            this.radComboMessageType.Location = new System.Drawing.Point(9, 161);
            this.radComboMessageType.Name = "radComboMessageType";
            // 
            // 
            // 
            this.radComboMessageType.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radComboMessageType.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radComboMessageType.Size = new System.Drawing.Size(144, 20);
            this.radComboMessageType.TabIndex = 8;
            // 
            // radComboBoxItem7
            // 
            this.radComboBoxItem7.Text = "None";
            // 
            // radComboBoxItem8
            // 
            this.radComboBoxItem8.Text = "Info";
            // 
            // radComboBoxItem9
            // 
            this.radComboBoxItem9.Text = "Question";
            // 
            // radComboBoxItem10
            // 
            this.radComboBoxItem10.Text = "Exclamation";
            // 
            // radComboBoxItem11
            // 
            this.radComboBoxItem11.Text = "Error";
            // 
            // radComboButtons
            // 
            this.radComboButtons.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.radComboButtons.ForeColor = System.Drawing.Color.Black;
            this.radComboButtons.Items.AddRange(new List<RadListDataItem>( new RadListDataItem[] {
            this.radComboBoxItem1,
            this.radComboBoxItem2,
            this.radComboBoxItem3,
            this.radComboBoxItem4,
            this.radComboBoxItem5,
            this.radComboBoxItem6}));
            this.radComboButtons.Location = new System.Drawing.Point(9, 207);
            this.radComboButtons.Name = "radComboButtons";
            // 
            // 
            // 
            this.radComboButtons.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radComboButtons.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radComboButtons.Size = new System.Drawing.Size(144, 20);
            this.radComboButtons.TabIndex = 6;
            // 
            // radComboBoxItem1
            // 
            this.radComboBoxItem1.Text = "OK";
            // 
            // radComboBoxItem2
            // 
            this.radComboBoxItem2.Text = "OK, Cancel";
            // 
            // radComboBoxItem3
            // 
            this.radComboBoxItem3.Text = "Yes, No";
            // 
            // radComboBoxItem4
            // 
            this.radComboBoxItem4.Text = "Yes, No, Cancel";
            // 
            // radComboBoxItem5
            // 
            this.radComboBoxItem5.Text = "Retry, Cancel";
            // 
            // radComboBoxItem6
            // 
            this.radComboBoxItem6.Text = "Abort, Retry, Ignore";
            // 
            // radComboThemes
            // 
            this.radComboThemes.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.radComboThemes.ForeColor = System.Drawing.Color.Black;
            this.radComboThemes.Items.AddRange(new List<RadListDataItem>( new RadListDataItem[] {
            this.radComboBoxItem15,
            this.radComboBoxItem16,
            this.radComboBoxItem17,
            this.radComboBoxItem18,
            this.radComboBoxItem19,
            this.radComboBoxItem20}));
            this.radComboThemes.Location = new System.Drawing.Point(9, 279);
            this.radComboThemes.Name = "radComboThemes";
            // 
            // 
            // 
            this.radComboThemes.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radComboThemes.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radComboThemes.Size = new System.Drawing.Size(144, 20);
            this.radComboThemes.TabIndex = 11;
            // 
            // radComboBoxItem15
            // 
            this.radComboBoxItem15.Text = "ControlDefault";
            // 
            // radComboBoxItem16
            // 
            this.radComboBoxItem16.Text = "Desert";
            // 
            // radComboBoxItem17
            // 
            this.radComboBoxItem17.Text = "TelerikMetro";
            // 
            // radComboBoxItem18
            // 
            this.radComboBoxItem18.Text = "Office2010Blue";
            // 
            // radComboBoxItem19
            // 
            this.radComboBoxItem19.Text = "Office2010Black";
            // 
            // radComboBoxItem20
            // 
            this.radComboBoxItem20.Text = "Office2010Silver";
            // 
            // radGroupSettings
            // 
            this.radGroupSettings.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupSettings.Controls.Add(this.radLblDialog);
            this.radGroupSettings.Controls.Add(this.radLblTheme);
            this.radGroupSettings.Controls.Add(this.radLblButtons);
            this.radGroupSettings.Controls.Add(this.radCheckRTL);
            this.radGroupSettings.Controls.Add(this.radLblType);
            this.radGroupSettings.Controls.Add(this.radTxtMessage);
            this.radGroupSettings.Controls.Add(this.radComboThemes);
            this.radGroupSettings.Controls.Add(this.radLblText);
            this.radGroupSettings.Controls.Add(this.radLblCaption);
            this.radGroupSettings.Controls.Add(this.radComboButtons);
            this.radGroupSettings.Controls.Add(this.radTxtDialogResult);
            this.radGroupSettings.Controls.Add(this.radTxtCaption);
            this.radGroupSettings.Controls.Add(this.radComboMessageType);
            this.radGroupSettings.FooterImageIndex = -1;
            this.radGroupSettings.FooterImageKey = "";
            this.radGroupSettings.FooterText = "";
            this.radGroupSettings.ForeColor = System.Drawing.Color.Black;
            this.radGroupSettings.HeaderImageIndex = -1;
            this.radGroupSettings.HeaderImageKey = "";
            this.radGroupSettings.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupSettings.HeaderText = " MessageBox Settings ";
            this.radGroupSettings.Location = new System.Drawing.Point(10, 5);
            this.radGroupSettings.Name = "radGroupSettings";
            // 
            // 
            // 
            this.radGroupSettings.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radGroupSettings.Size = new System.Drawing.Size(180, 348);
            this.radGroupSettings.TabIndex = 0;
            this.radGroupSettings.Text = " MessageBox Settings ";
            // 
            // radLblDialog
            // 
            this.radLblDialog.ForeColor = System.Drawing.Color.Black;
            this.radLblDialog.Location = new System.Drawing.Point(9, 236);
            this.radLblDialog.Name = "radLblDialog";
            // 
            // 
            // 
            this.radLblDialog.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radLblDialog.Size = new System.Drawing.Size(75, 14);
            this.radLblDialog.TabIndex = 12;
            this.radLblDialog.Text = "Dialog Result:";
            // 
            // radLblTheme
            // 
            this.radLblTheme.ForeColor = System.Drawing.Color.Black;
            this.radLblTheme.Location = new System.Drawing.Point(9, 259);
            this.radLblTheme.Name = "radLblTheme";
            // 
            // 
            // 
            this.radLblTheme.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radLblTheme.Size = new System.Drawing.Size(111, 14);
            this.radLblTheme.TabIndex = 2;
            this.radLblTheme.Text = "MessageBox Theme:";
            // 
            // radLblButtons
            // 
            this.radLblButtons.ForeColor = System.Drawing.Color.Black;
            this.radLblButtons.Location = new System.Drawing.Point(9, 187);
            this.radLblButtons.Name = "radLblButtons";
            // 
            // 
            // 
            this.radLblButtons.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radLblButtons.Size = new System.Drawing.Size(46, 14);
            this.radLblButtons.TabIndex = 2;
            this.radLblButtons.Text = "Buttons:";
            // 
            // radLblType
            // 
            this.radLblType.ForeColor = System.Drawing.Color.Black;
            this.radLblType.Location = new System.Drawing.Point(9, 141);
            this.radLblType.Name = "radLblType";
            // 
            // 
            // 
            this.radLblType.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radLblType.Size = new System.Drawing.Size(81, 14);
            this.radLblType.TabIndex = 2;
            this.radLblType.Text = "Message Type:";
            // 
            // radLblText
            // 
            this.radLblText.ForeColor = System.Drawing.Color.Black;
            this.radLblText.Location = new System.Drawing.Point(9, 74);
            this.radLblText.Name = "radLblText";
            // 
            // 
            // 
            this.radLblText.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radLblText.Size = new System.Drawing.Size(78, 14);
            this.radLblText.TabIndex = 2;
            this.radLblText.Text = "Message Text:";
            // 
            // radLblCaption
            // 
            this.radLblCaption.ForeColor = System.Drawing.Color.Black;
            this.radLblCaption.Location = new System.Drawing.Point(9, 28);
            this.radLblCaption.Name = "radLblCaption";
            // 
            // 
            // 
            this.radLblCaption.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radLblCaption.Size = new System.Drawing.Size(95, 14);
            this.radLblCaption.TabIndex = 0;
            this.radLblCaption.Text = "Message Caption:";
            // 
            // radTxtDialogResult
            // 
            this.radTxtDialogResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.radTxtDialogResult.ForeColor = System.Drawing.Color.Black;
            this.radTxtDialogResult.Location = new System.Drawing.Point(93, 233);
            this.radTxtDialogResult.Name = "radTxtDialogResult";
            // 
            // 
            // 
            this.radTxtDialogResult.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radTxtDialogResult.Size = new System.Drawing.Size(78, 20);
            this.radTxtDialogResult.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radBtnShow);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(1141, 599);
            this.Controls.SetChildIndex(this.radBtnShow, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radTxtMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckRTL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTxtCaption)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBtnShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radComboMessageType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radComboButtons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radComboThemes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupSettings)).EndInit();
            this.radGroupSettings.ResumeLayout(false);
            this.radGroupSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLblDialog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLblTheme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLblButtons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLblType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLblText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLblCaption)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTxtDialogResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox radTxtMessage;
        private Telerik.WinControls.UI.RadCheckBox radCheckRTL;
        private Telerik.WinControls.UI.RadTextBox radTxtCaption;
        private Telerik.WinControls.UI.RadButton radBtnShow;
        private Telerik.WinControls.UI.RadDropDownList radComboMessageType;
        private Telerik.WinControls.UI.RadDropDownList radComboButtons;
        private Telerik.WinControls.UI.RadDropDownList radComboThemes;
        private Telerik.WinControls.UI.RadListDataItem radComboBoxItem1;
        private Telerik.WinControls.UI.RadListDataItem radComboBoxItem2;
        private Telerik.WinControls.UI.RadListDataItem radComboBoxItem3;
        private Telerik.WinControls.UI.RadListDataItem radComboBoxItem4;
        private Telerik.WinControls.UI.RadListDataItem radComboBoxItem5;
        private Telerik.WinControls.UI.RadListDataItem radComboBoxItem6;
        private Telerik.WinControls.UI.RadListDataItem radComboBoxItem7;
        private Telerik.WinControls.UI.RadListDataItem radComboBoxItem8;
        private Telerik.WinControls.UI.RadListDataItem radComboBoxItem9;
        private Telerik.WinControls.UI.RadListDataItem radComboBoxItem10;
        private Telerik.WinControls.UI.RadListDataItem radComboBoxItem11;
        private Telerik.WinControls.UI.RadListDataItem radComboBoxItem15;
        private Telerik.WinControls.UI.RadListDataItem radComboBoxItem16;
        private Telerik.WinControls.UI.RadListDataItem radComboBoxItem17;
        private Telerik.WinControls.UI.RadListDataItem radComboBoxItem18;
        private Telerik.WinControls.UI.RadListDataItem radComboBoxItem19;
        private Telerik.WinControls.UI.RadListDataItem radComboBoxItem20;
        private Telerik.WinControls.UI.RadGroupBox radGroupSettings;
        private Telerik.WinControls.UI.RadLabel radLblCaption;
        private Telerik.WinControls.UI.RadLabel radLblText;
        private Telerik.WinControls.UI.RadLabel radLblType;
        private Telerik.WinControls.UI.RadLabel radLblButtons;
        private Telerik.WinControls.UI.RadLabel radLblTheme;
        private Telerik.WinControls.UI.RadLabel radLblDialog;
        private Telerik.WinControls.UI.RadTextBox radTxtDialogResult;
    }
}
