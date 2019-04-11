namespace Telerik.Examples.WinControls.PageView.StripView.StripButtons
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
            this.radPageView1 = new Telerik.WinControls.UI.RadPageView();
            this.animatedScrollingCheck = new Telerik.WinControls.UI.RadCheckBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.stripButtonsCombo = new Telerik.WinControls.UI.RadDropDownList();
            this.selectedPageCombo = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animatedScrollingCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stripButtonsCombo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedPageCombo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.selectedPageCombo);
            this.settingsPanel.Controls.Add(this.radLabel2);
            this.settingsPanel.Controls.Add(this.stripButtonsCombo);
            this.settingsPanel.Controls.Add(this.radLabel1);
            this.settingsPanel.Controls.Add(this.animatedScrollingCheck);
            this.settingsPanel.ForeColor = System.Drawing.Color.Black;
            this.settingsPanel.Location = new System.Drawing.Point(1097, 1);
            // 
            // 
            // 
            this.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black;
            this.settingsPanel.Size = new System.Drawing.Size(200, 493);
            this.settingsPanel.ThemeName = "ControlDefault";
            this.settingsPanel.Controls.SetChildIndex(this.animatedScrollingCheck, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radLabel1, 0);
            this.settingsPanel.Controls.SetChildIndex(this.stripButtonsCombo, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radLabel2, 0);
            this.settingsPanel.Controls.SetChildIndex(this.selectedPageCombo, 0);
            // 
            // radPageView1
            // 
            this.radPageView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radPageView1.Location = new System.Drawing.Point(291, 58);
            this.radPageView1.Name = "radPageView1";
            this.radPageView1.Size = new System.Drawing.Size(610, 385);
            this.radPageView1.TabIndex = 1;
            this.radPageView1.Text = "radPageView1";
            // 
            // animatedScrollingCheck
            // 
            this.animatedScrollingCheck.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.animatedScrollingCheck.Location = new System.Drawing.Point(10, 146);
            this.animatedScrollingCheck.Name = "animatedScrollingCheck";
            this.animatedScrollingCheck.Size = new System.Drawing.Size(141, 18);
            this.animatedScrollingCheck.TabIndex = 2;
            this.animatedScrollingCheck.Text = "Animated Strip Scrolling";
            this.animatedScrollingCheck.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.animatedScrollingCheck_ToggleStateChanged);
            // 
            // radLabel1
            // 
            this.radLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radLabel1.Location = new System.Drawing.Point(10, 37);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(74, 16);
            this.radLabel1.TabIndex = 3;
            this.radLabel1.Text = "Strip Buttons:";
            // 
            // stripButtonsCombo
            // 
            this.stripButtonsCombo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.stripButtonsCombo.AutoCompleteDataSource = null;
            this.stripButtonsCombo.DropDownAnimationEnabled = false;
            this.stripButtonsCombo.DropDownAnimationFrames = 1;
            this.stripButtonsCombo.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.stripButtonsCombo.Location = new System.Drawing.Point(10, 59);
            this.stripButtonsCombo.Name = "stripButtonsCombo";
            this.stripButtonsCombo.Size = new System.Drawing.Size(180, 20);
            this.stripButtonsCombo.TabIndex = 4;
            this.stripButtonsCombo.TabStop = false;
            this.stripButtonsCombo.Text = "radDropDownList1";
            this.stripButtonsCombo.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.stripButtonsCombo_SelectedIndexChanged);
            // 
            // selectedPageCombo
            // 
            this.selectedPageCombo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.selectedPageCombo.AutoCompleteDataSource = null;
            this.selectedPageCombo.DropDownAnimationEnabled = false;
            this.selectedPageCombo.DropDownAnimationFrames = 1;
            this.selectedPageCombo.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.selectedPageCombo.Location = new System.Drawing.Point(10, 107);
            this.selectedPageCombo.Name = "selectedPageCombo";
            this.selectedPageCombo.Size = new System.Drawing.Size(180, 20);
            this.selectedPageCombo.TabIndex = 6;
            this.selectedPageCombo.TabStop = false;
            this.selectedPageCombo.Text = "radDropDownList1";
            this.selectedPageCombo.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.selectedPageCombo_SelectedIndexChanged);
            // 
            // radLabel2
            // 
            this.radLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radLabel2.Location = new System.Drawing.Point(10, 85);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(83, 16);
            this.radLabel2.TabIndex = 5;
            this.radLabel2.Text = "Selected Page:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radPageView1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1298, 495);
            this.Controls.SetChildIndex(this.radPageView1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animatedScrollingCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stripButtonsCombo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedPageCombo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPageView radPageView1;
        private Telerik.WinControls.UI.RadDropDownList selectedPageCombo;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadDropDownList stripButtonsCombo;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadCheckBox animatedScrollingCheck;

    }
}