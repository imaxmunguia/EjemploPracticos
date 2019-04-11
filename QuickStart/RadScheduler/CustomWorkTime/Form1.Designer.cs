namespace Telerik.Examples.WinControls.RadScheduler.CustomWorkTime
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
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radDateTimePicker2 = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radDateTimePicker1 = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radScheduler1 = new Telerik.WinControls.UI.RadScheduler();
            this.radSchedulerNavigator1 = new Telerik.WinControls.UI.RadSchedulerNavigator();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePicker2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePicker1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radScheduler1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSchedulerNavigator1)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radGroupBox1);
            this.settingsPanel.Location = new System.Drawing.Point(1056, 1);
            this.settingsPanel.Size = new System.Drawing.Size(217, 1251);
            this.settingsPanel.ThemeName = "ControlDefault";
            this.settingsPanel.Controls.SetChildIndex(this.radGroupBox1, 0);
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupBox1.Controls.Add(this.radDateTimePicker2);
            this.radGroupBox1.Controls.Add(this.radLabel2);
            this.radGroupBox1.Controls.Add(this.radDateTimePicker1);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.FooterImageIndex = -1;
            this.radGroupBox1.FooterImageKey = "";
            this.radGroupBox1.HeaderImageIndex = -1;
            this.radGroupBox1.HeaderImageKey = "";
            this.radGroupBox1.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBox1.HeaderText = "WorkTime Settings";
            this.radGroupBox1.Location = new System.Drawing.Point(10, 48);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.radGroupBox1.Size = new System.Drawing.Size(197, 131);
            this.radGroupBox1.TabIndex = 5;
            this.radGroupBox1.Text = "WorkTime Settings";
            // 
            // radDateTimePicker2
            // 
            this.radDateTimePicker2.CustomFormat = "HH:mm";
            this.radDateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.radDateTimePicker2.Location = new System.Drawing.Point(14, 95);
            this.radDateTimePicker2.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.radDateTimePicker2.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.radDateTimePicker2.Name = "radDateTimePicker2";
            this.radDateTimePicker2.NullDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.radDateTimePicker2.ShowUpDown = true;
            this.radDateTimePicker2.Size = new System.Drawing.Size(150, 22);
            this.radDateTimePicker2.TabIndex = 3;
            this.radDateTimePicker2.Text = "radDateTimePicker2";
            this.radDateTimePicker2.Value = new System.DateTime(2010, 1, 18, 16, 45, 7, 444);
            this.radDateTimePicker2.ValueChanged += new System.EventHandler(this.radDateTimePicker_ValueChanged);
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(14, 74);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(21, 14);
            this.radLabel2.TabIndex = 2;
            this.radLabel2.Text = "To:";
            this.radLabel2.TextWrap = true;
            // 
            // radDateTimePicker1
            // 
            this.radDateTimePicker1.CustomFormat = "HH:mm";
            this.radDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.radDateTimePicker1.Location = new System.Drawing.Point(14, 45);
            this.radDateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.radDateTimePicker1.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.radDateTimePicker1.Name = "radDateTimePicker1";
            this.radDateTimePicker1.NullDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.radDateTimePicker1.ShowUpDown = true;
            this.radDateTimePicker1.Size = new System.Drawing.Size(150, 22);
            this.radDateTimePicker1.TabIndex = 1;
            this.radDateTimePicker1.Text = "radDateTimePicker1";
            this.radDateTimePicker1.Value = new System.DateTime(2010, 1, 18, 16, 44, 48, 954);
            this.radDateTimePicker1.ValueChanged += new System.EventHandler(this.radDateTimePicker_ValueChanged);
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(14, 24);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(34, 14);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "From:";
            this.radLabel1.TextWrap = true;
            // 
            // radScheduler1
            // 
            this.radScheduler1.DataSource = null;
            this.radScheduler1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radScheduler1.GroupType = Telerik.WinControls.UI.GroupType.None;
            this.radScheduler1.HeaderFormat = "dd dddd";
            this.radScheduler1.Location = new System.Drawing.Point(0, 79);
            this.radScheduler1.Name = "radScheduler1";
            this.radScheduler1.Size = new System.Drawing.Size(1257, 587);
            this.radScheduler1.TabIndex = 1;
            this.radScheduler1.Text = "radScheduler1";
            this.radScheduler1.ActiveViewChanged += new System.EventHandler<Telerik.WinControls.UI.SchedulerViewChangedEventArgs>(this.radScheduler1_ActiveViewChanged);
            // 
            // radSchedulerNavigator1
            // 
            this.radSchedulerNavigator1.AutoSize = true;
            this.radSchedulerNavigator1.DateFormat = "yyyy/MM/dd";
            this.radSchedulerNavigator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radSchedulerNavigator1.Location = new System.Drawing.Point(0, 0);
            this.radSchedulerNavigator1.MinimumSize = new System.Drawing.Size(400, 74);
            this.radSchedulerNavigator1.Name = "radSchedulerNavigator1";
            // 
            // 
            // 
            this.radSchedulerNavigator1.RootElement.MinSize = new System.Drawing.Size(400, 74);
            this.radSchedulerNavigator1.RootElement.StretchVertically = false;
            this.radSchedulerNavigator1.Size = new System.Drawing.Size(1257, 79);
            this.radSchedulerNavigator1.TabIndex = 2;
            this.radSchedulerNavigator1.Text = "radSchedulerNavigator1";
            this.radSchedulerNavigator1.ThemeName = "ControlDefault";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radScheduler1);
            this.Controls.Add(this.radSchedulerNavigator1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1257, 666);
            this.Controls.SetChildIndex(this.radSchedulerNavigator1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            this.Controls.SetChildIndex(this.radScheduler1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePicker2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePicker1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radScheduler1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSchedulerNavigator1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadDateTimePicker radDateTimePicker2;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadDateTimePicker radDateTimePicker1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadScheduler radScheduler1;
        private Telerik.WinControls.UI.RadSchedulerNavigator radSchedulerNavigator1;

    }
}