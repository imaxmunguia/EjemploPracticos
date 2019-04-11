namespace Telerik.Examples.WinControls.RadScheduler.Timeline
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
            this.radScheduler1 = new Telerik.WinControls.UI.RadScheduler();
            this.radDateTimePickerStart = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radDateTimePickerEnd = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radSpinEditorTimeSlots = new Telerik.WinControls.UI.RadSpinEditor();
            this.radRadioButtonWeek = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioButtonMonth = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioButtonHour = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioButtonDay = new Telerik.WinControls.UI.RadRadioButton();
            this.radGroupBox3 = new Telerik.WinControls.UI.RadGroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radScheduler1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePickerStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePickerEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorTimeSlots)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonWeek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox3)).BeginInit();
            this.radGroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radGroupBox3);
            this.settingsPanel.Controls.Add(this.radGroupBox2);
            this.settingsPanel.Location = new System.Drawing.Point(1056, 1);
            this.settingsPanel.Size = new System.Drawing.Size(200, 832);
            this.settingsPanel.ThemeName = "ControlDefault";
            this.settingsPanel.Controls.SetChildIndex(this.radGroupBox2, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radGroupBox3, 0);
            // 
            // radScheduler1
            // 
            this.radScheduler1.ActiveViewType = Telerik.WinControls.UI.SchedulerViewType.Timeline;
            this.radScheduler1.DataSource = null;
            this.radScheduler1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radScheduler1.GroupType = Telerik.WinControls.UI.GroupType.None;
            this.radScheduler1.HeaderFormat = "dd dddd";
            this.radScheduler1.Location = new System.Drawing.Point(0, 0);
            this.radScheduler1.Name = "radScheduler1";
            this.radScheduler1.Size = new System.Drawing.Size(1257, 834);
            this.radScheduler1.TabIndex = 1;
            this.radScheduler1.Text = "radScheduler1";
            // 
            // radDateTimePickerStart
            // 
            this.radDateTimePickerStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radDateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.radDateTimePickerStart.Location = new System.Drawing.Point(13, 43);
            this.radDateTimePickerStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.radDateTimePickerStart.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.radDateTimePickerStart.Name = "radDateTimePickerStart";
            this.radDateTimePickerStart.NullDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.radDateTimePickerStart.Size = new System.Drawing.Size(154, 22);
            this.radDateTimePickerStart.TabIndex = 1;
            this.radDateTimePickerStart.Text = "radDateTimePicker1";
            this.radDateTimePickerStart.Value = new System.DateTime(2010, 1, 12, 9, 56, 48, 405);
            this.radDateTimePickerStart.ValueChanged += new System.EventHandler(this.radDateTimePickerStart_ValueChanged);
            // 
            // radDateTimePickerEnd
            // 
            this.radDateTimePickerEnd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radDateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.radDateTimePickerEnd.Location = new System.Drawing.Point(13, 91);
            this.radDateTimePickerEnd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.radDateTimePickerEnd.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.radDateTimePickerEnd.Name = "radDateTimePickerEnd";
            this.radDateTimePickerEnd.NullDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.radDateTimePickerEnd.Size = new System.Drawing.Size(154, 22);
            this.radDateTimePickerEnd.TabIndex = 2;
            this.radDateTimePickerEnd.Text = "radDateTimePicker2";
            this.radDateTimePickerEnd.Value = new System.DateTime(2010, 1, 12, 9, 57, 3, 799);
            this.radDateTimePickerEnd.ValueChanged += new System.EventHandler(this.radDateTimePickerEnd_ValueChanged);
            // 
            // radLabel1
            // 
            this.radLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radLabel1.Location = new System.Drawing.Point(13, 23);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(91, 14);
            this.radLabel1.TabIndex = 3;
            this.radLabel1.Text = "Range Start Date";
            this.radLabel1.TextWrap = true;
            // 
            // radLabel2
            // 
            this.radLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radLabel2.Location = new System.Drawing.Point(13, 71);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(88, 14);
            this.radLabel2.TabIndex = 4;
            this.radLabel2.Text = "Range End Date";
            this.radLabel2.TextWrap = true;
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupBox2.Controls.Add(this.radLabel4);
            this.radGroupBox2.Controls.Add(this.radSpinEditorTimeSlots);
            this.radGroupBox2.Controls.Add(this.radRadioButtonWeek);
            this.radGroupBox2.Controls.Add(this.radRadioButtonMonth);
            this.radGroupBox2.Controls.Add(this.radRadioButtonHour);
            this.radGroupBox2.Controls.Add(this.radRadioButtonDay);
            this.radGroupBox2.FooterImageIndex = -1;
            this.radGroupBox2.FooterImageKey = "";
            this.radGroupBox2.HeaderImageIndex = -1;
            this.radGroupBox2.HeaderImageKey = "";
            this.radGroupBox2.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBox2.HeaderText = "Time scales";
            this.radGroupBox2.Location = new System.Drawing.Point(10, 37);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.radGroupBox2.Size = new System.Drawing.Size(180, 186);
            this.radGroupBox2.TabIndex = 6;
            this.radGroupBox2.Text = "Time scales";
            // 
            // radLabel4
            // 
            this.radLabel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radLabel4.Location = new System.Drawing.Point(13, 134);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(94, 14);
            this.radLabel4.TabIndex = 9;
            this.radLabel4.Text = "Visible Time Slots";
            this.radLabel4.TextWrap = true;
            // 
            // radSpinEditorTimeSlots
            // 
            this.radSpinEditorTimeSlots.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radSpinEditorTimeSlots.Location = new System.Drawing.Point(13, 154);
            this.radSpinEditorTimeSlots.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.radSpinEditorTimeSlots.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.radSpinEditorTimeSlots.Name = "radSpinEditorTimeSlots";
            // 
            // 
            // 
            this.radSpinEditorTimeSlots.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radSpinEditorTimeSlots.ShowBorder = true;
            this.radSpinEditorTimeSlots.Size = new System.Drawing.Size(156, 20);
            this.radSpinEditorTimeSlots.TabIndex = 8;
            this.radSpinEditorTimeSlots.Text = "radSpinEditorTimeSlots";
            this.radSpinEditorTimeSlots.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.radSpinEditorTimeSlots.ValueChanged += new System.EventHandler(this.radSpinEditorTimeSlots_ValueChanged);
            // 
            // radRadioButtonWeek
            // 
            this.radRadioButtonWeek.Location = new System.Drawing.Point(13, 80);
            this.radRadioButtonWeek.Name = "radRadioButtonWeek";
            this.radRadioButtonWeek.Size = new System.Drawing.Size(110, 18);
            this.radRadioButtonWeek.TabIndex = 2;
            this.radRadioButtonWeek.Text = "Week";
            this.radRadioButtonWeek.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioButtonDay_ToggleStateChanged);
            // 
            // radRadioButtonMonth
            // 
            this.radRadioButtonMonth.Location = new System.Drawing.Point(13, 104);
            this.radRadioButtonMonth.Name = "radRadioButtonMonth";
            this.radRadioButtonMonth.Size = new System.Drawing.Size(110, 18);
            this.radRadioButtonMonth.TabIndex = 2;
            this.radRadioButtonMonth.Text = "Month";
            this.radRadioButtonMonth.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioButtonDay_ToggleStateChanged);
            // 
            // radRadioButtonHour
            // 
            this.radRadioButtonHour.Location = new System.Drawing.Point(13, 56);
            this.radRadioButtonHour.Name = "radRadioButtonHour";
            this.radRadioButtonHour.Size = new System.Drawing.Size(110, 18);
            this.radRadioButtonHour.TabIndex = 1;
            this.radRadioButtonHour.Text = "Hour";
            this.radRadioButtonHour.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioButtonDay_ToggleStateChanged);
            // 
            // radRadioButtonDay
            // 
            this.radRadioButtonDay.Location = new System.Drawing.Point(13, 32);
            this.radRadioButtonDay.Name = "radRadioButtonDay";
            this.radRadioButtonDay.Size = new System.Drawing.Size(110, 18);
            this.radRadioButtonDay.TabIndex = 0;
            this.radRadioButtonDay.Text = "Day";
            this.radRadioButtonDay.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.radRadioButtonDay.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioButtonDay_ToggleStateChanged);
            // 
            // radGroupBox3
            // 
            this.radGroupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupBox3.Controls.Add(this.radLabel1);
            this.radGroupBox3.Controls.Add(this.radDateTimePickerEnd);
            this.radGroupBox3.Controls.Add(this.radDateTimePickerStart);
            this.radGroupBox3.Controls.Add(this.radLabel2);
            this.radGroupBox3.FooterImageIndex = -1;
            this.radGroupBox3.FooterImageKey = "";
            this.radGroupBox3.HeaderImageIndex = -1;
            this.radGroupBox3.HeaderImageKey = "";
            this.radGroupBox3.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBox3.HeaderText = "Date options";
            this.radGroupBox3.Location = new System.Drawing.Point(10, 229);
            this.radGroupBox3.Name = "radGroupBox3";
            this.radGroupBox3.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.radGroupBox3.Size = new System.Drawing.Size(180, 128);
            this.radGroupBox3.TabIndex = 7;
            this.radGroupBox3.Text = "Date options";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radScheduler1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1257, 834);
            this.Tag = "";
            this.Controls.SetChildIndex(this.radScheduler1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radScheduler1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePickerStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePickerEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            this.radGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorTimeSlots)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonWeek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox3)).EndInit();
            this.radGroupBox3.ResumeLayout(false);
            this.radGroupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadDateTimePicker  radDateTimePickerEnd;
        private Telerik.WinControls.UI.RadDateTimePicker radDateTimePickerStart;
        private Telerik.WinControls.UI.RadScheduler radScheduler1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private Telerik.WinControls.UI.RadRadioButton radRadioButtonHour;
        private Telerik.WinControls.UI.RadRadioButton radRadioButtonDay;
        private Telerik.WinControls.UI.RadRadioButton radRadioButtonWeek;
        private Telerik.WinControls.UI.RadRadioButton radRadioButtonMonth;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox3;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadSpinEditor radSpinEditorTimeSlots;
    }
}