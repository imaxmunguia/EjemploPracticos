﻿namespace Telerik.Examples.WinControls.RadScheduler.Printing
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
            Telerik.WinControls.UI.DateTimeInterval dateTimeInterval1 = new Telerik.WinControls.UI.DateTimeInterval();
            Telerik.WinControls.UI.SchedulerDailyPrintStyle schedulerDailyPrintStyle1 = new Telerik.WinControls.UI.SchedulerDailyPrintStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.radScheduler1 = new Telerik.WinControls.UI.RadScheduler();
            this.radSchedulerNavigator1 = new Telerik.WinControls.UI.RadSchedulerNavigator();
            this.radPrintDocument1 = new Telerik.WinControls.UI.RadPrintDocument();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radioDetails = new Telerik.WinControls.UI.RadRadioButton();
            this.radioMonthly = new Telerik.WinControls.UI.RadRadioButton();
            this.radioWeekly = new Telerik.WinControls.UI.RadRadioButton();
            this.radioDaily = new Telerik.WinControls.UI.RadRadioButton();
            this.buttonPrint = new Telerik.WinControls.UI.RadButton();
            this.buttonPreview = new Telerik.WinControls.UI.RadButton();
            this.buttonSettings = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radScheduler1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSchedulerNavigator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioMonthly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioWeekly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioDaily)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSettings)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.settingsPanel.Controls.Add(this.buttonSettings);
            this.settingsPanel.Controls.Add(this.buttonPreview);
            this.settingsPanel.Controls.Add(this.radGroupBox1);
            this.settingsPanel.Controls.Add(this.buttonPrint);
            this.settingsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.settingsPanel.Location = new System.Drawing.Point(1122, 0);
            this.settingsPanel.Size = new System.Drawing.Size(238, 749);
            this.settingsPanel.Controls.SetChildIndex(this.buttonPrint, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radGroupBox1, 0);
            this.settingsPanel.Controls.SetChildIndex(this.buttonPreview, 0);
            this.settingsPanel.Controls.SetChildIndex(this.buttonSettings, 0);
            // 
            // radScheduler1
            // 
            dateTimeInterval1.End = new System.DateTime(((long)(0)));
            dateTimeInterval1.Start = new System.DateTime(((long)(0)));
            this.radScheduler1.AccessibleInterval = dateTimeInterval1;
            this.radScheduler1.AppointmentTitleFormat = null;
            this.radScheduler1.Culture = new System.Globalization.CultureInfo("en-US");
            this.radScheduler1.DataSource = null;
            this.radScheduler1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radScheduler1.GroupType = Telerik.WinControls.UI.GroupType.None;
            this.radScheduler1.HeaderFormat = "dd dddd";
            this.radScheduler1.Location = new System.Drawing.Point(0, 77);
            this.radScheduler1.Name = "radScheduler1";
            schedulerDailyPrintStyle1.AppointmentFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            schedulerDailyPrintStyle1.DateEndRange = new System.DateTime(2012, 2, 13, 0, 0, 0, 0);
            schedulerDailyPrintStyle1.DateHeadingFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            schedulerDailyPrintStyle1.DateStartRange = new System.DateTime(2012, 2, 8, 0, 0, 0, 0);
            schedulerDailyPrintStyle1.PageHeadingFont = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.radScheduler1.PrintStyle = schedulerDailyPrintStyle1;
            this.radScheduler1.Size = new System.Drawing.Size(1122, 672);
            this.radScheduler1.TabIndex = 1;
            this.radScheduler1.Text = "radScheduler1";
            this.radScheduler1.ActiveViewChanged += new System.EventHandler<Telerik.WinControls.UI.SchedulerViewChangedEventArgs>(radScheduler1_ActiveViewChanged);
            // 
            // radSchedulerNavigator1
            // 
            this.radSchedulerNavigator1.AssociatedScheduler = this.radScheduler1;
            this.radSchedulerNavigator1.DateFormat = "yyyy/MM/dd";
            this.radSchedulerNavigator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radSchedulerNavigator1.Location = new System.Drawing.Point(0, 0);
            this.radSchedulerNavigator1.Name = "radSchedulerNavigator1";
            this.radSchedulerNavigator1.NavigationStepType = Telerik.WinControls.UI.NavigationStepTypes.Day;
            // 
            // 
            // 
            this.radSchedulerNavigator1.RootElement.StretchVertically = false;
            this.radSchedulerNavigator1.Size = new System.Drawing.Size(1122, 77);
            this.radSchedulerNavigator1.TabIndex = 2;
            this.radSchedulerNavigator1.Text = "radSchedulerNavigator1";
            // 
            // radPrintDocument1
            // 
            this.radPrintDocument1.AssociatedObject = this.radScheduler1;
            this.radPrintDocument1.FooterFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radPrintDocument1.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radPrintDocument1.LeftFooter = "Page [Page #] of [Total Pages]";
            this.radPrintDocument1.LeftHeader = "[Time Printed]";
            this.radPrintDocument1.MiddleFooter = "***";
            this.radPrintDocument1.MiddleHeader = "Weekly Task List";
            this.radPrintDocument1.RightFooter = "Printed by: [User Name]";
            this.radPrintDocument1.RightHeader = "[Date Printed]";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.radioDetails);
            this.radGroupBox1.Controls.Add(this.radioMonthly);
            this.radGroupBox1.Controls.Add(this.radioWeekly);
            this.radGroupBox1.Controls.Add(this.radioDaily);
            this.radGroupBox1.FooterImageIndex = -1;
            this.radGroupBox1.FooterImageKey = "";
            this.radGroupBox1.HeaderImageIndex = -1;
            this.radGroupBox1.HeaderImageKey = "";
            this.radGroupBox1.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBox1.HeaderText = "Print Style";
            this.radGroupBox1.Location = new System.Drawing.Point(19, 37);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            // 
            // 
            // 
            this.radGroupBox1.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.radGroupBox1.Size = new System.Drawing.Size(200, 128);
            this.radGroupBox1.TabIndex = 1;
            this.radGroupBox1.Text = "Print Style";
            // 
            // radioDetails
            // 
            this.radioDetails.Location = new System.Drawing.Point(18, 97);
            this.radioDetails.Name = "radioDetails";
            this.radioDetails.Size = new System.Drawing.Size(110, 18);
            this.radioDetails.TabIndex = 3;
            this.radioDetails.Text = "Details Style";
            this.radioDetails.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radio_ToggleStateChanged);
            // 
            // radioMonthly
            // 
            this.radioMonthly.Location = new System.Drawing.Point(18, 73);
            this.radioMonthly.Name = "radioMonthly";
            this.radioMonthly.Size = new System.Drawing.Size(110, 18);
            this.radioMonthly.TabIndex = 2;
            this.radioMonthly.Text = "Monthly Style";
            this.radioMonthly.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radio_ToggleStateChanged);
            // 
            // radioWeekly
            // 
            this.radioWeekly.Location = new System.Drawing.Point(18, 49);
            this.radioWeekly.Name = "radioWeekly";
            this.radioWeekly.Size = new System.Drawing.Size(110, 18);
            this.radioWeekly.TabIndex = 1;
            this.radioWeekly.Text = "Weekly Style";
            this.radioWeekly.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radio_ToggleStateChanged);
            // 
            // radioDaily
            // 
            this.radioDaily.Location = new System.Drawing.Point(18, 25);
            this.radioDaily.Name = "radioDaily";
            this.radioDaily.Size = new System.Drawing.Size(110, 18);
            this.radioDaily.TabIndex = 0;
            this.radioDaily.TabStop = true;
            this.radioDaily.Text = "Daily Style";
            this.radioDaily.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.radioDaily.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radio_ToggleStateChanged);
            // 
            // buttonPrint
            // 
            this.buttonPrint.Location = new System.Drawing.Point(19, 185);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(130, 24);
            this.buttonPrint.TabIndex = 2;
            this.buttonPrint.Text = "Print ...";
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // buttonPreview
            // 
            this.buttonPreview.Location = new System.Drawing.Point(19, 223);
            this.buttonPreview.Name = "buttonPreview";
            this.buttonPreview.Size = new System.Drawing.Size(130, 24);
            this.buttonPreview.TabIndex = 3;
            this.buttonPreview.Text = "Print Preview";
            this.buttonPreview.Click += new System.EventHandler(this.buttonPreview_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.Location = new System.Drawing.Point(19, 261);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(130, 24);
            this.buttonSettings.TabIndex = 4;
            this.buttonSettings.Text = "Print Settings";
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radScheduler1);
            this.Controls.Add(this.radSchedulerNavigator1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1360, 749);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            this.Controls.SetChildIndex(this.radSchedulerNavigator1, 0);
            this.Controls.SetChildIndex(this.radScheduler1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radScheduler1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSchedulerNavigator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radioDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioMonthly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioWeekly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioDaily)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSettings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadScheduler radScheduler1;
        private Telerik.WinControls.UI.RadSchedulerNavigator radSchedulerNavigator1;
        private Telerik.WinControls.UI.RadPrintDocument radPrintDocument1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadRadioButton radioDaily;
        private Telerik.WinControls.UI.RadRadioButton radioWeekly;
        private Telerik.WinControls.UI.RadRadioButton radioMonthly;
        private Telerik.WinControls.UI.RadRadioButton radioDetails;
        private Telerik.WinControls.UI.RadButton buttonPrint;
        private Telerik.WinControls.UI.RadButton buttonPreview;
        private Telerik.WinControls.UI.RadButton buttonSettings;
    }
}