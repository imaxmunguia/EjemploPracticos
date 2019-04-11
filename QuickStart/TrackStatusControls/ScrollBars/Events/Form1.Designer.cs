namespace Telerik.Examples.WinControls.TrackStatusControls.ScrollBars.Events
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.scrollToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.leftTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rightBottomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pageLeftUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pageRightBottomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.scrollLeftUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scrollRightBottomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radVScrollBar1 = new Telerik.WinControls.UI.RadVScrollBar();
            this.radHScrollBar1 = new Telerik.WinControls.UI.RadHScrollBar();
            this.radPanelDemo = new Telerik.WinControls.UI.RadPanel();
            this.radBtnClear = new Telerik.WinControls.UI.RadButton();
            this.radTxtEvents = new Telerik.WinControls.UI.RadTextBox();
            this.radLblEvents = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelDemoHolder)).BeginInit();
            this.radPanelDemoHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radVScrollBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radHScrollBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelDemo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBtnClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTxtEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLblEvents)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanelDemoHolder
            // 
            this.radPanelDemoHolder.Controls.Add(this.radPanelDemo);
            this.radPanelDemoHolder.Controls.Add(this.radHScrollBar1);
            this.radPanelDemoHolder.Controls.Add(this.radTxtEvents);
            this.radPanelDemoHolder.Controls.Add(this.radLblEvents);
            this.radPanelDemoHolder.Controls.Add(this.radBtnClear);
            this.radPanelDemoHolder.Controls.Add(this.radVScrollBar1);
            this.radPanelDemoHolder.Location = new System.Drawing.Point(295, 84);
            // 
            // 
            // 
            this.radPanelDemoHolder.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radPanelDemoHolder.Size = new System.Drawing.Size(634, 584);
            // 
            // settingsPanel
            // 
            this.settingsPanel.Location = new System.Drawing.Point(1023, 1);
            // 
            // 
            // 
            this.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black;
            this.settingsPanel.Size = new System.Drawing.Size(200, 750);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scrollToToolStripMenuItem,
            this.toolStripSeparator1,
            this.leftTopToolStripMenuItem,
            this.rightBottomToolStripMenuItem,
            this.toolStripSeparator2,
            this.pageLeftUpToolStripMenuItem,
            this.pageRightBottomToolStripMenuItem,
            this.toolStripSeparator3,
            this.scrollLeftUpToolStripMenuItem,
            this.scrollRightBottomToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(177, 176);
            // 
            // scrollToToolStripMenuItem
            // 
            this.scrollToToolStripMenuItem.Name = "scrollToToolStripMenuItem";
            this.scrollToToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.scrollToToolStripMenuItem.Text = "Scroll To";
            this.scrollToToolStripMenuItem.Click += new System.EventHandler(this.scrollToToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(173, 6);
            // 
            // leftTopToolStripMenuItem
            // 
            this.leftTopToolStripMenuItem.Name = "leftTopToolStripMenuItem";
            this.leftTopToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.leftTopToolStripMenuItem.Text = "Left / Top";
            this.leftTopToolStripMenuItem.Click += new System.EventHandler(this.leftTopToolStripMenuItem_Click);
            // 
            // rightBottomToolStripMenuItem
            // 
            this.rightBottomToolStripMenuItem.Name = "rightBottomToolStripMenuItem";
            this.rightBottomToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.rightBottomToolStripMenuItem.Text = "Right  /Bottom";
            this.rightBottomToolStripMenuItem.Click += new System.EventHandler(this.rightBottomToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(173, 6);
            // 
            // pageLeftUpToolStripMenuItem
            // 
            this.pageLeftUpToolStripMenuItem.Name = "pageLeftUpToolStripMenuItem";
            this.pageLeftUpToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.pageLeftUpToolStripMenuItem.Text = "Page Left / Up";
            this.pageLeftUpToolStripMenuItem.Click += new System.EventHandler(this.pageLeftUpToolStripMenuItem_Click);
            // 
            // pageRightBottomToolStripMenuItem
            // 
            this.pageRightBottomToolStripMenuItem.Name = "pageRightBottomToolStripMenuItem";
            this.pageRightBottomToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.pageRightBottomToolStripMenuItem.Text = "Page Right / Down";
            this.pageRightBottomToolStripMenuItem.Click += new System.EventHandler(this.pageRightBottomToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(173, 6);
            // 
            // scrollLeftUpToolStripMenuItem
            // 
            this.scrollLeftUpToolStripMenuItem.Name = "scrollLeftUpToolStripMenuItem";
            this.scrollLeftUpToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.scrollLeftUpToolStripMenuItem.Text = "Scroll Left / Up";
            this.scrollLeftUpToolStripMenuItem.Click += new System.EventHandler(this.scrollLeftUpToolStripMenuItem_Click);
            // 
            // scrollRightBottomToolStripMenuItem
            // 
            this.scrollRightBottomToolStripMenuItem.Name = "scrollRightBottomToolStripMenuItem";
            this.scrollRightBottomToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.scrollRightBottomToolStripMenuItem.Text = "Scroll Right / Down";
            this.scrollRightBottomToolStripMenuItem.Click += new System.EventHandler(this.scrollRightBottomToolStripMenuItem_Click);
            // 
            // radVScrollBar1
            // 
            this.radVScrollBar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radVScrollBar1.ContextMenuStrip = this.contextMenuStrip1;
            this.radVScrollBar1.ForeColor = System.Drawing.Color.Black;
            this.radVScrollBar1.LargeChange = 1;
            this.radVScrollBar1.Location = new System.Drawing.Point(561, 42);
            this.radVScrollBar1.Margin = new System.Windows.Forms.Padding(2);
            this.radVScrollBar1.Maximum = 20;
            this.radVScrollBar1.Minimum = 10;
            this.radVScrollBar1.Name = "radVScrollBar1";
            // 
            // 
            // 
            this.radVScrollBar1.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radVScrollBar1.RootElement.ToolTipText = null;
            this.radVScrollBar1.Size = new System.Drawing.Size(18, 226);
            this.radVScrollBar1.TabIndex = 36;
            this.radVScrollBar1.Text = "radVScrollBar1";
            this.radVScrollBar1.Value = 15;
            this.radVScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.radVScrollBar1_Scroll);
            this.radVScrollBar1.ValueChanged += new System.EventHandler(this.radVScrollBar1_ValueChanged);
            // 
            // radHScrollBar1
            // 
            this.radHScrollBar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radHScrollBar1.ContextMenuStrip = this.contextMenuStrip1;
            this.radHScrollBar1.ForeColor = System.Drawing.Color.Black;
            this.radHScrollBar1.Location = new System.Drawing.Point(56, 272);
            this.radHScrollBar1.Margin = new System.Windows.Forms.Padding(2);
            this.radHScrollBar1.Name = "radHScrollBar1";
            // 
            // 
            // 
            this.radHScrollBar1.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radHScrollBar1.RootElement.ToolTipText = null;
            this.radHScrollBar1.Size = new System.Drawing.Size(501, 18);
            this.radHScrollBar1.TabIndex = 35;
            this.radHScrollBar1.Text = "radHScrollBar1";
            this.radHScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.radHScrollBar1_Scroll);
            this.radHScrollBar1.ValueChanged += new System.EventHandler(this.radHScrollBar1_ValueChanged);
            // 
            // radPanelDemo
            // 
            this.radPanelDemo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radPanelDemo.ForeColor = System.Drawing.Color.Black;
            this.radPanelDemo.Location = new System.Drawing.Point(57, 42);
            this.radPanelDemo.Name = "radPanelDemo";
            // 
            // 
            // 
            this.radPanelDemo.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radPanelDemo.Size = new System.Drawing.Size(499, 225);
            this.radPanelDemo.TabIndex = 55;
            // 
            // radBtnClear
            // 
            this.radBtnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radBtnClear.Location = new System.Drawing.Point(279, 519);
            this.radBtnClear.Name = "radBtnClear";
            this.radBtnClear.Size = new System.Drawing.Size(77, 23);
            this.radBtnClear.TabIndex = 56;
            this.radBtnClear.Text = "Clear";
            this.radBtnClear.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // radTxtEvents
            // 
            this.radTxtEvents.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radTxtEvents.ForeColor = System.Drawing.Color.Black;
            this.radTxtEvents.Location = new System.Drawing.Point(57, 309);
            this.radTxtEvents.Multiline = true;
            this.radTxtEvents.Name = "radTxtEvents";
            // 
            // 
            // 
            this.radTxtEvents.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radTxtEvents.RootElement.StretchVertically = true;
            this.radTxtEvents.Size = new System.Drawing.Size(522, 204);
            this.radTxtEvents.TabIndex = 57;
            this.radTxtEvents.TabStop = false;
            // 
            // radLblEvents
            // 
            this.radLblEvents.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radLblEvents.ForeColor = System.Drawing.Color.Black;
            this.radLblEvents.Location = new System.Drawing.Point(57, 295);
            this.radLblEvents.Name = "radLblEvents";
            // 
            // 
            // 
            this.radLblEvents.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radLblEvents.Size = new System.Drawing.Size(141, 16);
            this.radLblEvents.TabIndex = 58;
            this.radLblEvents.Text = "Received Scrolling Events:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1224, 752);
            this.Controls.SetChildIndex(this.radPanelDemoHolder, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.radPanelDemoHolder)).EndInit();
            this.radPanelDemoHolder.ResumeLayout(false);
            this.radPanelDemoHolder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radVScrollBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radHScrollBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelDemo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBtnClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTxtEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLblEvents)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

        private Telerik.WinControls.UI.RadHScrollBar radHScrollBar1;
        private Telerik.WinControls.UI.RadVScrollBar radVScrollBar1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem scrollToToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem leftTopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rightBottomToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem pageLeftUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pageRightBottomToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem scrollLeftUpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem scrollRightBottomToolStripMenuItem;
		private Telerik.WinControls.UI.RadPanel radPanelDemo;
		private Telerik.WinControls.UI.RadButton radBtnClear;
        private Telerik.WinControls.UI.RadTextBox radTxtEvents;
        private Telerik.WinControls.UI.RadLabel radLblEvents;
	}
}