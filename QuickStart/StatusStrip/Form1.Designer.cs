namespace Telerik.Examples.WinControls.StatusStrip
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.radStatusBar1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.radButtonElement1 = new Telerik.WinControls.UI.RadButtonElement();
            this.CommandBarSeparator3 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.radLabelElement3 = new Telerik.WinControls.UI.RadLabelElement();
            this.CommandBarSeparator4 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.radLabelElement2 = new Telerik.WinControls.UI.RadLabelElement();
            this.radProgressBarElement1 = new Telerik.WinControls.UI.RadProgressBarElement();
            this.CommandBarSeparator5 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.radCheckBoxElement1 = new Telerik.WinControls.UI.RadCheckBoxElement();
            this.radLabelElement1 = new Telerik.WinControls.UI.RadLabelElement();
            this.CommandBarSeparator2 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.radSplitButtonElement1 = new Telerik.WinControls.UI.RadSplitButtonElement();
            this.radMenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem2 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem9 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem10 = new Telerik.WinControls.UI.RadMenuItem();
            this.CommandBarSeparator1 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.radMenuItem3 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem4 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem5 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuSeparatorItem1 = new Telerik.WinControls.UI.RadMenuSeparatorItem();
            this.radMenuItem6 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem7 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem8 = new Telerik.WinControls.UI.RadMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.radTitleBar1 = new Telerik.WinControls.UI.RadTitleBar();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.roundRectShape1 = new Telerik.WinControls.RoundRectShape(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.radStatusBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTitleBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            this.SuspendLayout();
            // 
            // radStatusBar1
            // 
            this.radStatusBar1.AutoSize = true;
            this.radStatusBar1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radButtonElement1,
            this.CommandBarSeparator3,
            this.radLabelElement3,
            this.CommandBarSeparator4,
            this.radLabelElement2,
            this.radProgressBarElement1,
            this.CommandBarSeparator5,
            this.radCheckBoxElement1,
            this.radLabelElement1,
            this.CommandBarSeparator2,
            this.radSplitButtonElement1,
            this.CommandBarSeparator1});
            this.radStatusBar1.LayoutStyle = Telerik.WinControls.UI.RadStatusBarLayoutStyle.Stack;
            this.radStatusBar1.Location = new System.Drawing.Point(0, 218);
            this.radStatusBar1.Margin = new System.Windows.Forms.Padding(5);
            this.radStatusBar1.Name = "radStatusBar1";
            this.radStatusBar1.Size = new System.Drawing.Size(631, 25);
            this.radStatusBar1.SizingGrip = true;
            this.radStatusBar1.TabIndex = 0;
            this.radStatusBar1.Text = "radStatusBar1";
            ((Telerik.WinControls.UI.RadStatusBarElement)(this.radStatusBar1.GetChildAt(0))).Text = "radStatusBar1";
            ((Telerik.WinControls.UI.RadStatusBarElement)(this.radStatusBar1.GetChildAt(0))).Padding = new System.Windows.Forms.Padding(2);
            ((Telerik.WinControls.UI.RadStatusBarElement)(this.radStatusBar1.GetChildAt(0))).MinSize = new System.Drawing.Size(0, 19);
            ((Telerik.WinControls.UI.StatusBarBoxLayout)(this.radStatusBar1.GetChildAt(0).GetChildAt(3))).Margin = new System.Windows.Forms.Padding(0, 0, 14, 0);
            // 
            // radButtonElement1
            // 
            this.radButtonElement1.CanFocus = true;
            this.radButtonElement1.Margin = new System.Windows.Forms.Padding(1);
            this.radButtonElement1.Name = "radButtonElement1";
            this.radStatusBar1.SetSpring(this.radButtonElement1, false);
            this.radButtonElement1.Text = "Page 1 of 1";
            this.radButtonElement1.Click += new System.EventHandler(this.radButtonElement1_Click);
            // 
            // CommandBarSeparator3
            // 
            this.CommandBarSeparator3.Margin = new System.Windows.Forms.Padding(1);
            this.CommandBarSeparator3.MinSize = new System.Drawing.Size(2, 17);
            this.CommandBarSeparator3.Name = "CommandBarSeparator3";
            this.radStatusBar1.SetSpring(this.CommandBarSeparator3, false);
            this.CommandBarSeparator3.Text = "CommandBarSeparator3";
            // 
            // radLabelElement3
            // 
            this.radLabelElement3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.radLabelElement3.Margin = new System.Windows.Forms.Padding(1);
            this.radLabelElement3.Name = "radLabelElement3";
            this.radStatusBar1.SetSpring(this.radLabelElement3, false);
            this.radLabelElement3.Text = "Words: 2";
            // 
            // CommandBarSeparator4
            // 
            this.CommandBarSeparator4.Margin = new System.Windows.Forms.Padding(1);
            this.CommandBarSeparator4.MinSize = new System.Drawing.Size(2, 17);
            this.CommandBarSeparator4.Name = "CommandBarSeparator4";
            this.radStatusBar1.SetSpring(this.CommandBarSeparator4, false);
            this.CommandBarSeparator4.Text = "CommandBarSeparator4";
            // 
            // radLabelElement2
            // 
            this.radLabelElement2.Margin = new System.Windows.Forms.Padding(1);
            this.radLabelElement2.Name = "radLabelElement2";
            this.radStatusBar1.SetSpring(this.radLabelElement2, false);
            this.radLabelElement2.Text = "Saving...";
            // 
            // radProgressBarElement1
            // 
            this.radProgressBarElement1.AutoSize = false;
            this.radProgressBarElement1.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.FitToAvailableSize;
            this.radProgressBarElement1.Bounds = new System.Drawing.Rectangle(0, 0, 133, 16);
            this.radProgressBarElement1.ClipDrawing = true;
            this.radProgressBarElement1.DefaultSize = new System.Drawing.Size(130, 16);
            this.radProgressBarElement1.Margin = new System.Windows.Forms.Padding(1);
            this.radProgressBarElement1.Name = "radProgressBarElement1";
            this.radStatusBar1.SetSpring(this.radProgressBarElement1, false);
            this.radProgressBarElement1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CommandBarSeparator5
            // 
            this.CommandBarSeparator5.Margin = new System.Windows.Forms.Padding(1);
            this.CommandBarSeparator5.MinSize = new System.Drawing.Size(2, 17);
            this.CommandBarSeparator5.Name = "CommandBarSeparator5";
            this.radStatusBar1.SetSpring(this.CommandBarSeparator5, false);
            this.CommandBarSeparator5.Text = "CommandBarSeparator5";
            // 
            // radCheckBoxElement1
            // 
            this.radCheckBoxElement1.CanFocus = true;
            this.radCheckBoxElement1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off;
            this.radCheckBoxElement1.Margin = new System.Windows.Forms.Padding(1);
            this.radCheckBoxElement1.Name = "radCheckBoxElement1";
            this.radCheckBoxElement1.ShowBorder = false;
            this.radStatusBar1.SetSpring(this.radCheckBoxElement1, false);
            this.radCheckBoxElement1.Text = "Check for errors";
            // 
            // radLabelElement1
            // 
            this.radLabelElement1.Margin = new System.Windows.Forms.Padding(1);
            this.radLabelElement1.Name = "radLabelElement1";
            this.radStatusBar1.SetSpring(this.radLabelElement1, false);
            this.radLabelElement1.Text = "English (US)";
            // 
            // CommandBarSeparator2
            // 
            this.CommandBarSeparator2.Margin = new System.Windows.Forms.Padding(1);
            this.CommandBarSeparator2.MinSize = new System.Drawing.Size(2, 17);
            this.CommandBarSeparator2.Name = "CommandBarSeparator2";
            this.radStatusBar1.SetSpring(this.CommandBarSeparator2, false);
            this.CommandBarSeparator2.Text = "CommandBarSeparator2";
            // 
            // radSplitButtonElement1
            // 
            this.radSplitButtonElement1.ArrowButtonMinSize = new System.Drawing.Size(12, 12);
            this.radSplitButtonElement1.DefaultItem = null;
            this.radSplitButtonElement1.DropDownDirection = Telerik.WinControls.UI.RadDirection.Down;
            this.radSplitButtonElement1.ExpandArrowButton = false;
            this.radSplitButtonElement1.HasTwoColumnDropDown = false;
            this.radSplitButtonElement1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem1,
            this.radMenuItem2,
            this.radMenuItem9,
            this.radMenuItem10});
            this.radSplitButtonElement1.Margin = new System.Windows.Forms.Padding(1);
            this.radSplitButtonElement1.Name = "radSplitButtonElement1";
            this.radStatusBar1.SetSpring(this.radSplitButtonElement1, false);
            this.radSplitButtonElement1.Text = "Zoom";
            this.radSplitButtonElement1.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // radMenuItem1
            // 
            this.radMenuItem1.Name = "radMenuItem1";
            this.radMenuItem1.Text = "50%";
            this.radMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // radMenuItem2
            // 
            this.radMenuItem2.Name = "radMenuItem2";
            this.radMenuItem2.Text = "75%";
            this.radMenuItem2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // radMenuItem9
            // 
            this.radMenuItem9.Name = "radMenuItem9";
            this.radMenuItem9.Text = "100%";
            this.radMenuItem9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // radMenuItem10
            // 
            this.radMenuItem10.Name = "radMenuItem10";
            this.radMenuItem10.Text = "200%";
            this.radMenuItem10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // CommandBarSeparator1
            // 
            this.CommandBarSeparator1.Margin = new System.Windows.Forms.Padding(1);
            this.CommandBarSeparator1.MinSize = new System.Drawing.Size(2, 17);
            this.CommandBarSeparator1.Name = "CommandBarSeparator1";
            this.radStatusBar1.SetSpring(this.CommandBarSeparator1, false);
            this.CommandBarSeparator1.Text = "CommandBarSeparator1";
            // 
            // radMenuItem3
            // 
            this.radMenuItem3.Name = "radMenuItem3";
            this.radMenuItem3.Text = "radMenuItem3";
            this.radMenuItem3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // radMenuItem4
            // 
            this.radMenuItem4.Name = "radMenuItem4";
            this.radMenuItem4.Text = "radMenuItem4";
            this.radMenuItem4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // radMenuItem5
            // 
            this.radMenuItem5.Name = "radMenuItem5";
            this.radMenuItem5.Text = "radMenuItem5";
            this.radMenuItem5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // radMenuSeparatorItem1
            // 
            this.radMenuSeparatorItem1.Class = "RadMenuItem";
            this.radMenuSeparatorItem1.Name = "radMenuSeparatorItem1";
            this.radMenuSeparatorItem1.Text = "radMenuSeparatorItem1";
            // 
            // radMenuItem6
            // 
            this.radMenuItem6.Name = "radMenuItem6";
            this.radMenuItem6.Text = "radMenuItem6";
            this.radMenuItem6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // radMenuItem7
            // 
            this.radMenuItem7.Name = "radMenuItem7";
            this.radMenuItem7.Text = "radMenuItem7";
            this.radMenuItem7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // radMenuItem8
            // 
            this.radMenuItem8.Name = "radMenuItem8";
            this.radMenuItem8.Text = "radMenuItem8";
            this.radMenuItem8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // radTitleBar1
            // 
            this.radTitleBar1.Text = "RadStatusStrip Example";
            this.radTitleBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radTitleBar1.Location = new System.Drawing.Point(0, 0);
            this.radTitleBar1.Name = "radTitleBar1";
            this.radTitleBar1.Size = new System.Drawing.Size(631, 23);
            this.radTitleBar1.TabIndex = 1;
            this.radTitleBar1.TabStop = false;
            this.radTitleBar1.Text = "RadStatusStrip";
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(1))).Text = "RadStatusStrip Example";
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(1))).Alignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // radLabel1
            // 
            this.radLabel1.AutoSize = false;
            this.radLabel1.BackColor = System.Drawing.Color.Transparent;
            this.radLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radLabel1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.radLabel1.Location = new System.Drawing.Point(0, 23);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            // 
            // 
            // 
            this.radLabel1.RootElement.StretchHorizontally = true;
            this.radLabel1.RootElement.StretchVertically = true;
            this.radLabel1.Size = new System.Drawing.Size(631, 195);
            this.radLabel1.TabIndex = 2;
            this.radLabel1.Text = resources.GetString("radLabel1.Text");
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(631, 243);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.radTitleBar1);
            this.Controls.Add(this.radStatusBar1);
            this.Name = "Form1";
            this.Shape = this.roundRectShape1;
            this.Text = "RadStatusStrip Example";
            ((System.ComponentModel.ISupportInitialize)(this.radStatusBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTitleBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadStatusStrip radStatusBar1;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement1;
        private Telerik.WinControls.UI.RadProgressBarElement radProgressBarElement1;
        private Telerik.WinControls.UI.CommandBarSeparator CommandBarSeparator1;
        private Telerik.WinControls.UI.CommandBarSeparator CommandBarSeparator2;
        private System.Windows.Forms.Timer timer1;
        private Telerik.WinControls.UI.RadSplitButtonElement radSplitButtonElement1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem1;
        private Telerik.WinControls.UI.RadTitleBar radTitleBar1;
        private Telerik.WinControls.UI.RadLabelElement radLabelElement1;
        private Telerik.WinControls.UI.CommandBarSeparator CommandBarSeparator5;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem2;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem3;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem4;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem5;
        private Telerik.WinControls.UI.RadMenuSeparatorItem radMenuSeparatorItem1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem6;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem7;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem8;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem9;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem10;
        private Telerik.WinControls.UI.RadLabelElement radLabelElement2;
        private Telerik.WinControls.UI.CommandBarSeparator CommandBarSeparator3;
        private Telerik.WinControls.UI.RadLabelElement radLabelElement3;
        private Telerik.WinControls.UI.CommandBarSeparator CommandBarSeparator4;
        private Telerik.WinControls.UI.RadCheckBoxElement radCheckBoxElement1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.RoundRectShape roundRectShape1;
    }
}