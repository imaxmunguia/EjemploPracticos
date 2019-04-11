namespace Telerik.Examples.WinControls.Editors.DateTimePicker
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
            this.radDateTimePicker1 = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radLblLongDateFormat = new Telerik.WinControls.UI.RadLabel();
            this.radLblShortDateFormat = new Telerik.WinControls.UI.RadLabel();
            this.radDateTimePicker2 = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radLblTimeFormat = new Telerik.WinControls.UI.RadLabel();
            this.radDateTimePicker3 = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radBtnClearAll = new Telerik.WinControls.UI.RadButton();
            this.radGroupExampleSettings = new Telerik.WinControls.UI.RadGroupBox();
            this.radRadio24Hours = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadio12Hours = new Telerik.WinControls.UI.RadRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelDemoHolder)).BeginInit();
            this.radPanelDemoHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePicker1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLblLongDateFormat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLblShortDateFormat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePicker2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLblTimeFormat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePicker3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBtnClearAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupExampleSettings)).BeginInit();
            this.radGroupExampleSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radRadio24Hours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadio12Hours)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanelDemoHolder
            // 
            this.radPanelDemoHolder.Controls.Add(this.radLblLongDateFormat);
            this.radPanelDemoHolder.Controls.Add(this.radDateTimePicker2);
            this.radPanelDemoHolder.Controls.Add(this.radDateTimePicker1);
            this.radPanelDemoHolder.Controls.Add(this.radLblShortDateFormat);
            this.radPanelDemoHolder.Controls.Add(this.radDateTimePicker3);
            this.radPanelDemoHolder.Controls.Add(this.radLblTimeFormat);
            this.radPanelDemoHolder.Location = new System.Drawing.Point(410, 299);
            // 
            // 
            // 
            this.radPanelDemoHolder.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radPanelDemoHolder.Size = new System.Drawing.Size(405, 139);
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radGroupExampleSettings);
            this.settingsPanel.Location = new System.Drawing.Point(1023, 1);
            // 
            // 
            // 
            this.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black;
            this.settingsPanel.Size = new System.Drawing.Size(200, 735);
            this.settingsPanel.Controls.SetChildIndex(this.radGroupExampleSettings, 0);
            // 
            // radDateTimePicker1
            // 
            this.radDateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radDateTimePicker1.Checked = true;
            this.radDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.radDateTimePicker1.Location = new System.Drawing.Point(173, 25);
            this.radDateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.radDateTimePicker1.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.radDateTimePicker1.Name = "radDateTimePicker1";
            this.radDateTimePicker1.NullDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.radDateTimePicker1.Size = new System.Drawing.Size(191, 22);
            this.radDateTimePicker1.TabIndex = 0;
            this.radDateTimePicker1.TabStop = false;
            this.radDateTimePicker1.Text = "radDateTimePicker1";
            this.radDateTimePicker1.Value = new System.DateTime(2007, 8, 23, 15, 29, 8, 309);
            // 
            // radLblLongDateFormat
            // 
            this.radLblLongDateFormat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radLblLongDateFormat.Location = new System.Drawing.Point(56, 25);
            this.radLblLongDateFormat.Name = "radLblLongDateFormat";
            // 
            // 
            // 
            this.radLblLongDateFormat.Size = new System.Drawing.Size(95, 16);
            this.radLblLongDateFormat.TabIndex = 1;
            this.radLblLongDateFormat.Text = "Long date format:";
            // 
            // radLblShortDateFormat
            // 
            this.radLblShortDateFormat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radLblShortDateFormat.Location = new System.Drawing.Point(56, 59);
            this.radLblShortDateFormat.Name = "radLblShortDateFormat";
            // 
            // 
            // 
            this.radLblShortDateFormat.Size = new System.Drawing.Size(97, 16);
            this.radLblShortDateFormat.TabIndex = 3;
            this.radLblShortDateFormat.Text = "Short date format:";
            // 
            // radDateTimePicker2
            // 
            this.radDateTimePicker2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radDateTimePicker2.Checked = true;
            this.radDateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.radDateTimePicker2.Location = new System.Drawing.Point(173, 59);
            this.radDateTimePicker2.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.radDateTimePicker2.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.radDateTimePicker2.Name = "radDateTimePicker2";
            this.radDateTimePicker2.NullDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.radDateTimePicker2.Size = new System.Drawing.Size(191, 22);
            this.radDateTimePicker2.TabIndex = 2;
            this.radDateTimePicker2.TabStop = false;
            this.radDateTimePicker2.Text = "radDateTimePicker2";
            this.radDateTimePicker2.Value = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            // 
            // radLblTimeFormat
            // 
            this.radLblTimeFormat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radLblTimeFormat.Location = new System.Drawing.Point(56, 92);
            this.radLblTimeFormat.Name = "radLblTimeFormat";
            // 
            // 
            // 
            this.radLblTimeFormat.Size = new System.Drawing.Size(70, 16);
            this.radLblTimeFormat.TabIndex = 5;
            this.radLblTimeFormat.Text = "Time format:";
            // 
            // radDateTimePicker3
            // 
            this.radDateTimePicker3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radDateTimePicker3.Checked = true;
            this.radDateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.radDateTimePicker3.Location = new System.Drawing.Point(173, 93);
            this.radDateTimePicker3.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.radDateTimePicker3.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.radDateTimePicker3.Name = "radDateTimePicker3";
            this.radDateTimePicker3.NullDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.radDateTimePicker3.ShowUpDown = true;
            this.radDateTimePicker3.Size = new System.Drawing.Size(191, 22);
            this.radDateTimePicker3.TabIndex = 4;
            this.radDateTimePicker3.TabStop = false;
            this.radDateTimePicker3.Text = "radDateTimePicker3";
            this.radDateTimePicker3.Value = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            // 
            // radBtnClearAll
            // 
            this.radBtnClearAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.radBtnClearAll.Location = new System.Drawing.Point(16, 84);
            this.radBtnClearAll.Name = "radBtnClearAll";
            this.radBtnClearAll.Size = new System.Drawing.Size(128, 23);
            this.radBtnClearAll.TabIndex = 6;
            this.radBtnClearAll.Text = "Clear All";
            this.radBtnClearAll.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // radGroupExampleSettings
            // 
            this.radGroupExampleSettings.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupExampleSettings.Controls.Add(this.radRadio24Hours);
            this.radGroupExampleSettings.Controls.Add(this.radRadio12Hours);
            this.radGroupExampleSettings.Controls.Add(this.radBtnClearAll);
            this.radGroupExampleSettings.FooterImageIndex = -1;
            this.radGroupExampleSettings.FooterImageKey = "";
            this.radGroupExampleSettings.FooterText = "";
            this.radGroupExampleSettings.ForeColor = System.Drawing.Color.Black;
            this.radGroupExampleSettings.HeaderImageIndex = -1;
            this.radGroupExampleSettings.HeaderImageKey = "";
            this.radGroupExampleSettings.HeaderMargin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.radGroupExampleSettings.HeaderText = " Settings ";
            this.radGroupExampleSettings.Location = new System.Drawing.Point(10, 6);
            this.radGroupExampleSettings.Name = "radGroupExampleSettings";
            this.radGroupExampleSettings.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            // 
            // 
            // 
            this.radGroupExampleSettings.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radGroupExampleSettings.RootElement.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.radGroupExampleSettings.Size = new System.Drawing.Size(180, 122);
            this.radGroupExampleSettings.TabIndex = 7;
            this.radGroupExampleSettings.Text = " Settings ";
            // 
            // radRadio24Hours
            // 
            this.radRadio24Hours.Location = new System.Drawing.Point(16, 53);
            this.radRadio24Hours.Name = "radRadio24Hours";
            // 
            // 
            // 
            this.radRadio24Hours.Size = new System.Drawing.Size(66, 16);
            this.radRadio24Hours.TabIndex = 7;
            this.radRadio24Hours.Text = "24 Hours";
            this.radRadio24Hours.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.OnRadRadioHourFormat_ToggleStateChanged);
            // 
            // radRadio12Hours
            // 
            this.radRadio12Hours.Location = new System.Drawing.Point(16, 31);
            this.radRadio12Hours.Name = "radRadio12Hours";
            // 
            // 
            // 
            this.radRadio12Hours.Size = new System.Drawing.Size(66, 16);
            this.radRadio12Hours.TabIndex = 7;
            this.radRadio12Hours.Text = "12 Hours";
            this.radRadio12Hours.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.OnRadRadioHourFormat_ToggleStateChanged);
            // 
            // Form1
            // 
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1224, 737);
            this.Load +=new System.EventHandler(Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPanelDemoHolder)).EndInit();
            this.radPanelDemoHolder.ResumeLayout(false);
            this.radPanelDemoHolder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePicker1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLblLongDateFormat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLblShortDateFormat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePicker2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLblTimeFormat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePicker3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBtnClearAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupExampleSettings)).EndInit();
            this.radGroupExampleSettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radRadio24Hours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadio12Hours)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadDateTimePicker radDateTimePicker1;
        private Telerik.WinControls.UI.RadLabel radLblLongDateFormat;
        private Telerik.WinControls.UI.RadLabel radLblShortDateFormat;
        private Telerik.WinControls.UI.RadDateTimePicker radDateTimePicker2;
        private Telerik.WinControls.UI.RadLabel radLblTimeFormat;
        private Telerik.WinControls.UI.RadDateTimePicker radDateTimePicker3;
        private Telerik.WinControls.UI.RadButton radBtnClearAll;
        private Telerik.WinControls.UI.RadGroupBox radGroupExampleSettings;
        private Telerik.WinControls.UI.RadRadioButton radRadio24Hours;
        private Telerik.WinControls.UI.RadRadioButton radRadio12Hours;

    }
}