namespace Telerik.Examples.WinControls.Docking.DragDrop
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radDock1 = new Telerik.WinControls.UI.Docking.RadDock();
            this.documentWindow1 = new Telerik.WinControls.UI.Docking.DocumentWindow();
            this.radSplitContainer2 = new Telerik.WinControls.UI.RadSplitContainer();
            this.radSplitContainer1 = new Telerik.WinControls.UI.RadSplitContainer();
            this.toolTabStrip1 = new Telerik.WinControls.UI.Docking.ToolTabStrip();
            this.toolWindow1 = new Telerik.WinControls.UI.Docking.ToolWindow();
            this.documentContainer1 = new Telerik.WinControls.UI.Docking.DocumentContainer();
            this.documentTabStrip1 = new Telerik.WinControls.UI.Docking.DocumentTabStrip();
            this.toolTabStrip2 = new Telerik.WinControls.UI.Docking.ToolTabStrip();
            this.toolWindow2 = new Telerik.WinControls.UI.Docking.ToolWindow();
            this.toolTabStrip3 = new Telerik.WinControls.UI.Docking.ToolTabStrip();
            this.toolWindow3 = new Telerik.WinControls.UI.Docking.ToolWindow();
            this.tool1Drag = new Telerik.WinControls.UI.RadCheckBox();
            this.tool2Drag = new Telerik.WinControls.UI.RadCheckBox();
            this.tool3Drop = new Telerik.WinControls.UI.RadCheckBox();
            this.allowDockBottom = new Telerik.WinControls.UI.RadCheckBox();
            this.radCheckBox1 = new Telerik.WinControls.UI.RadCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radDock1)).BeginInit();
            this.radDock1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer2)).BeginInit();
            this.radSplitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).BeginInit();
            this.radSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip1)).BeginInit();
            this.toolTabStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentContainer1)).BeginInit();
            this.documentContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentTabStrip1)).BeginInit();
            this.documentTabStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip2)).BeginInit();
            this.toolTabStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip3)).BeginInit();
            this.toolTabStrip3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tool1Drag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tool2Drag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tool3Drop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allowDockBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radCheckBox1);
            this.settingsPanel.Controls.Add(this.allowDockBottom);
            this.settingsPanel.Controls.Add(this.tool3Drop);
            this.settingsPanel.Controls.Add(this.tool2Drag);
            this.settingsPanel.Controls.Add(this.tool1Drag);
            this.settingsPanel.Location = new System.Drawing.Point(552, 1);
            this.settingsPanel.Size = new System.Drawing.Size(200, 806);
            this.settingsPanel.ThemeName = "ControlDefault";
            this.settingsPanel.Controls.SetChildIndex(this.tool1Drag, 0);
            this.settingsPanel.Controls.SetChildIndex(this.tool2Drag, 0);
            this.settingsPanel.Controls.SetChildIndex(this.tool3Drop, 0);
            this.settingsPanel.Controls.SetChildIndex(this.allowDockBottom, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radCheckBox1, 0);
            // 
            // radDock1
            // 
            this.radDock1.ActiveWindow = this.documentWindow1;
            this.radDock1.Controls.Add(this.radSplitContainer2);
            this.radDock1.Controls.Add(this.toolTabStrip3);
            this.radDock1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radDock1.DocumentManager.DocumentInsertOrder = Telerik.WinControls.UI.Docking.DockWindowInsertOrder.InFront;
            this.radDock1.Location = new System.Drawing.Point(0, 0);
            this.radDock1.MainDocumentContainer = this.documentContainer1;
            this.radDock1.Name = "radDock1";
            // 
            // 
            // 
            this.radDock1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.radDock1.Size = new System.Drawing.Size(753, 808);
            this.radDock1.TabIndex = 1;
            this.radDock1.TabStop = false;
            this.radDock1.Text = "radDock1";
            // 
            // documentWindow1
            // 
            this.documentWindow1.Location = new System.Drawing.Point(5, 27);
            this.documentWindow1.Name = "documentWindow1";
            this.documentWindow1.Size = new System.Drawing.Size(337, 573);
            this.documentWindow1.Text = "documentWindow1";
            // 
            // radSplitContainer2
            // 
            this.radSplitContainer2.Controls.Add(this.radSplitContainer1);
            this.radSplitContainer2.Controls.Add(this.toolTabStrip2);
            this.radSplitContainer2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.radSplitContainer2.IsCleanUpTarget = true;
            this.radSplitContainer2.Location = new System.Drawing.Point(0, 0);
            this.radSplitContainer2.Name = "radSplitContainer2";
            this.radSplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // 
            // 
            this.radSplitContainer2.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.radSplitContainer2.Size = new System.Drawing.Size(550, 808);
            this.radSplitContainer2.TabIndex = 0;
            this.radSplitContainer2.TabStop = false;
            // 
            // radSplitContainer1
            // 
            this.radSplitContainer1.Controls.Add(this.toolTabStrip1);
            this.radSplitContainer1.Controls.Add(this.documentContainer1);
            this.radSplitContainer1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.radSplitContainer1.IsCleanUpTarget = true;
            this.radSplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.radSplitContainer1.Name = "radSplitContainer1";
            // 
            // 
            // 
            this.radSplitContainer1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.radSplitContainer1.Size = new System.Drawing.Size(550, 605);
            this.radSplitContainer1.TabIndex = 0;
            this.radSplitContainer1.TabStop = false;
            // 
            // toolTabStrip1
            // 
            this.toolTabStrip1.Controls.Add(this.toolWindow1);
            this.toolTabStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolTabStrip1.Name = "toolTabStrip1";
            // 
            // 
            // 
            this.toolTabStrip1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.toolTabStrip1.SelectedIndex = 0;
            this.toolTabStrip1.Size = new System.Drawing.Size(200, 605);
            this.toolTabStrip1.TabIndex = 1;
            this.toolTabStrip1.TabStop = false;
            // 
            // toolWindow1
            // 
            this.toolWindow1.Location = new System.Drawing.Point(1, 26);
            this.toolWindow1.Name = "toolWindow1";
            this.toolWindow1.Size = new System.Drawing.Size(198, 578);
            this.toolWindow1.Text = "toolWindow1";
            // 
            // documentContainer1
            // 
            this.documentContainer1.Controls.Add(this.documentTabStrip1);
            this.documentContainer1.Location = new System.Drawing.Point(203, 0);
            this.documentContainer1.Name = "documentContainer1";
            // 
            // 
            // 
            this.documentContainer1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.documentContainer1.Size = new System.Drawing.Size(347, 605);
            this.documentContainer1.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill;
            this.documentContainer1.TabIndex = 0;
            this.documentContainer1.TabStop = false;
            // 
            // documentTabStrip1
            // 
            this.documentTabStrip1.Controls.Add(this.documentWindow1);
            this.documentTabStrip1.Location = new System.Drawing.Point(0, 0);
            this.documentTabStrip1.Name = "documentTabStrip1";
            // 
            // 
            // 
            this.documentTabStrip1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.documentTabStrip1.SelectedIndex = 0;
            this.documentTabStrip1.Size = new System.Drawing.Size(347, 605);
            this.documentTabStrip1.TabIndex = 0;
            this.documentTabStrip1.TabStop = false;
            // 
            // toolTabStrip2
            // 
            this.toolTabStrip2.Controls.Add(this.toolWindow2);
            this.toolTabStrip2.Location = new System.Drawing.Point(0, 608);
            this.toolTabStrip2.Name = "toolTabStrip2";
            // 
            // 
            // 
            this.toolTabStrip2.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.toolTabStrip2.SelectedIndex = 0;
            this.toolTabStrip2.Size = new System.Drawing.Size(550, 200);
            this.toolTabStrip2.TabIndex = 1;
            this.toolTabStrip2.TabStop = false;
            // 
            // toolWindow2
            // 
            this.toolWindow2.Location = new System.Drawing.Point(1, 26);
            this.toolWindow2.Name = "toolWindow2";
            this.toolWindow2.Size = new System.Drawing.Size(548, 173);
            this.toolWindow2.Text = "toolWindow2";
            // 
            // toolTabStrip3
            // 
            this.toolTabStrip3.Controls.Add(this.toolWindow3);
            this.toolTabStrip3.Location = new System.Drawing.Point(553, 0);
            this.toolTabStrip3.Name = "toolTabStrip3";
            // 
            // 
            // 
            this.toolTabStrip3.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.toolTabStrip3.SelectedIndex = 0;
            this.toolTabStrip3.Size = new System.Drawing.Size(200, 808);
            this.toolTabStrip3.TabIndex = 1;
            this.toolTabStrip3.TabStop = false;
            // 
            // toolWindow3
            // 
            this.toolWindow3.Location = new System.Drawing.Point(1, 26);
            this.toolWindow3.Name = "toolWindow3";
            this.toolWindow3.Size = new System.Drawing.Size(198, 781);
            this.toolWindow3.Text = "toolWindow3";
            // 
            // tool1Drag
            // 
            this.tool1Drag.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tool1Drag.AutoSize = true;
            this.tool1Drag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.tool1Drag.Location = new System.Drawing.Point(10, 41);
            this.tool1Drag.Name = "tool1Drag";
            // 
            // 
            // 
            this.tool1Drag.RootElement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.tool1Drag.Size = new System.Drawing.Size(141, 14);
            this.tool1Drag.TabIndex = 0;
            this.tool1Drag.Text = "Allow toolWindow1 Drag";
            this.tool1Drag.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // tool2Drag
            // 
            this.tool2Drag.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tool2Drag.AutoSize = true;
            this.tool2Drag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.tool2Drag.Location = new System.Drawing.Point(10, 61);
            this.tool2Drag.Name = "tool2Drag";
            // 
            // 
            // 
            this.tool2Drag.RootElement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.tool2Drag.Size = new System.Drawing.Size(141, 14);
            this.tool2Drag.TabIndex = 1;
            this.tool2Drag.Text = "Allow toolWindow2 Drag";
            this.tool2Drag.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // tool3Drop
            // 
            this.tool3Drop.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tool3Drop.AutoSize = true;
            this.tool3Drop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.tool3Drop.Location = new System.Drawing.Point(10, 81);
            this.tool3Drop.Name = "tool3Drop";
            // 
            // 
            // 
            this.tool3Drop.RootElement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.tool3Drop.Size = new System.Drawing.Size(183, 14);
            this.tool3Drop.TabIndex = 2;
            this.tool3Drop.Text = "Allow Drop on toolWindow3 Only";
            // 
            // allowDockBottom
            // 
            this.allowDockBottom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.allowDockBottom.AutoSize = true;
            this.allowDockBottom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.allowDockBottom.Location = new System.Drawing.Point(10, 101);
            this.allowDockBottom.Name = "allowDockBottom";
            // 
            // 
            // 
            this.allowDockBottom.RootElement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.allowDockBottom.Size = new System.Drawing.Size(180, 14);
            this.allowDockBottom.TabIndex = 3;
            this.allowDockBottom.Text = "Allow DockPosition.Bottom Only";
            // 
            // radCheckBox1
            // 
            this.radCheckBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radCheckBox1.AutoSize = true;
            this.radCheckBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.radCheckBox1.Location = new System.Drawing.Point(10, 121);
            this.radCheckBox1.Name = "radCheckBox1";
            // 
            // 
            // 
            this.radCheckBox1.RootElement.AutoSize = false;
            this.radCheckBox1.RootElement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.radCheckBox1.Size = new System.Drawing.Size(142, 14);
            this.radCheckBox1.TabIndex = 4;
            this.radCheckBox1.Text = "Preview DragDrop Mode";
            this.radCheckBox1.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBox1_ToggleStateChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radDock1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(753, 808);
            this.Controls.SetChildIndex(this.radDock1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radDock1)).EndInit();
            this.radDock1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer2)).EndInit();
            this.radSplitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).EndInit();
            this.radSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip1)).EndInit();
            this.toolTabStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.documentContainer1)).EndInit();
            this.documentContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.documentTabStrip1)).EndInit();
            this.documentTabStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip2)).EndInit();
            this.toolTabStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip3)).EndInit();
            this.toolTabStrip3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tool1Drag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tool2Drag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tool3Drop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allowDockBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.Docking.RadDock radDock1;
        private Telerik.WinControls.UI.Docking.ToolWindow toolWindow3;
        private Telerik.WinControls.UI.RadCheckBox tool1Drag;
        private Telerik.WinControls.UI.RadSplitContainer radSplitContainer2;
        private Telerik.WinControls.UI.RadSplitContainer radSplitContainer1;
        private Telerik.WinControls.UI.Docking.ToolTabStrip toolTabStrip1;
        private Telerik.WinControls.UI.Docking.ToolWindow toolWindow1;
        private Telerik.WinControls.UI.Docking.DocumentContainer documentContainer1;
        private Telerik.WinControls.UI.Docking.DocumentTabStrip documentTabStrip1;
        private Telerik.WinControls.UI.Docking.DocumentWindow documentWindow1;
        private Telerik.WinControls.UI.Docking.ToolTabStrip toolTabStrip2;
        private Telerik.WinControls.UI.Docking.ToolWindow toolWindow2;
        private Telerik.WinControls.UI.Docking.ToolTabStrip toolTabStrip3;
        private Telerik.WinControls.UI.RadCheckBox tool3Drop;
        private Telerik.WinControls.UI.RadCheckBox tool2Drag;
        private Telerik.WinControls.UI.RadCheckBox allowDockBottom;
        private Telerik.WinControls.UI.RadCheckBox radCheckBox1;
    }
}
