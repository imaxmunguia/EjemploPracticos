namespace Telerik.Examples.WinControls.Docking.MDI
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
            Telerik.WinControls.UI.Docking.GuidToNameMapping guidToNameMapping1 = new Telerik.WinControls.UI.Docking.GuidToNameMapping();
            Telerik.WinControls.UI.Docking.GuidToNameMapping guidToNameMapping2 = new Telerik.WinControls.UI.Docking.GuidToNameMapping();
            this.logRadTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.imageMDIRadButton = new Telerik.WinControls.UI.RadButton();
            this.reportMDIRadButton = new Telerik.WinControls.UI.RadButton();
            this.orderMDIRadButton = new Telerik.WinControls.UI.RadButton();
            this.customerMDIRadButton = new Telerik.WinControls.UI.RadButton();
            this.label1 = new System.Windows.Forms.Label();
            this.newMDIRadButton = new Telerik.WinControls.UI.RadButton();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.radDock1 = new Telerik.WinControls.UI.Docking.RadDock();
            this.toolWindow1 = new Telerik.WinControls.UI.Docking.ToolWindow();
            this.documentContainer1 = new Telerik.WinControls.UI.Docking.DocumentContainer();
            this.radSplitContainer1 = new Telerik.WinControls.UI.RadSplitContainer();
            this.toolTabStrip1 = new Telerik.WinControls.UI.Docking.ToolTabStrip();
            this.toolTabStrip2 = new Telerik.WinControls.UI.Docking.ToolTabStrip();
            this.toolWindow2 = new Telerik.WinControls.UI.Docking.ToolWindow();
            ((System.ComponentModel.ISupportInitialize)(this.logRadTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageMDIRadButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportMDIRadButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderMDIRadButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerMDIRadButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newMDIRadButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDock1)).BeginInit();
            this.radDock1.SuspendLayout();
            this.toolWindow1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentContainer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).BeginInit();
            this.radSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip1)).BeginInit();
            this.toolTabStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip2)).BeginInit();
            this.toolTabStrip2.SuspendLayout();
            this.toolWindow2.SuspendLayout();
            this.SuspendLayout();
            // 
            // logRadTextBox
            // 
            this.logRadTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logRadTextBox.Location = new System.Drawing.Point(0, 0);
            this.logRadTextBox.Multiline = true;
            this.logRadTextBox.Name = "logRadTextBox";
            // 
            // 
            // 
            this.logRadTextBox.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.logRadTextBox.RootElement.StretchVertically = true;
            this.logRadTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logRadTextBox.Size = new System.Drawing.Size(198, 296);
            this.logRadTextBox.TabIndex = 0;
            this.logRadTextBox.TabStop = false;
            // 
            // imageMDIRadButton
            // 
            this.imageMDIRadButton.BackColor = System.Drawing.SystemColors.Control;
            this.imageMDIRadButton.Image = global::Telerik.Examples.WinControls.Properties.Resources.msIcon1;
            this.imageMDIRadButton.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.imageMDIRadButton.Location = new System.Drawing.Point(29, 157);
            this.imageMDIRadButton.Name = "imageMDIRadButton";
            this.imageMDIRadButton.Size = new System.Drawing.Size(165, 27);
            this.imageMDIRadButton.TabIndex = 4;
            this.imageMDIRadButton.Text = "Add Image child form";
            this.imageMDIRadButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.imageMDIRadButton.Click += new System.EventHandler(this.imageMDIRadButton_Click);
            // 
            // reportMDIRadButton
            // 
            this.reportMDIRadButton.BackColor = System.Drawing.SystemColors.Control;
            this.reportMDIRadButton.Image = global::Telerik.Examples.WinControls.Properties.Resources.msIcon1;
            this.reportMDIRadButton.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.reportMDIRadButton.Location = new System.Drawing.Point(29, 122);
            this.reportMDIRadButton.Name = "reportMDIRadButton";
            this.reportMDIRadButton.Size = new System.Drawing.Size(165, 27);
            this.reportMDIRadButton.TabIndex = 3;
            this.reportMDIRadButton.Text = "Add Report child form";
            this.reportMDIRadButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.reportMDIRadButton.Click += new System.EventHandler(this.reportMDIRadButton_Click);
            // 
            // orderMDIRadButton
            // 
            this.orderMDIRadButton.BackColor = System.Drawing.SystemColors.Control;
            this.orderMDIRadButton.Image = global::Telerik.Examples.WinControls.Properties.Resources.msIcon1;
            this.orderMDIRadButton.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.orderMDIRadButton.Location = new System.Drawing.Point(29, 87);
            this.orderMDIRadButton.Name = "orderMDIRadButton";
            this.orderMDIRadButton.Size = new System.Drawing.Size(165, 27);
            this.orderMDIRadButton.TabIndex = 2;
            this.orderMDIRadButton.Text = "Add Order child form";
            this.orderMDIRadButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.orderMDIRadButton.Click += new System.EventHandler(this.orderMDIRadButton_Click);
            // 
            // customerMDIRadButton
            // 
            this.customerMDIRadButton.BackColor = System.Drawing.SystemColors.Control;
            this.customerMDIRadButton.Image = global::Telerik.Examples.WinControls.Properties.Resources.msIcon1;
            this.customerMDIRadButton.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.customerMDIRadButton.Location = new System.Drawing.Point(29, 52);
            this.customerMDIRadButton.Name = "customerMDIRadButton";
            this.customerMDIRadButton.Size = new System.Drawing.Size(165, 27);
            this.customerMDIRadButton.TabIndex = 1;
            this.customerMDIRadButton.Text = "Add Customer child form";
            this.customerMDIRadButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.customerMDIRadButton.Click += new System.EventHandler(this.customerMDIRadButton_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(11, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 81);
            this.label1.TabIndex = 6;
            this.label1.Text = "Right click on tab or drag and drop tabbed document item to show context menu.";
            // 
            // newMDIRadButton
            // 
            this.newMDIRadButton.BackColor = System.Drawing.SystemColors.Control;
            this.newMDIRadButton.Image = global::Telerik.Examples.WinControls.Properties.Resources.msIcon1;
            this.newMDIRadButton.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.newMDIRadButton.Location = new System.Drawing.Point(29, 17);
            this.newMDIRadButton.Name = "newMDIRadButton";
            this.newMDIRadButton.Size = new System.Drawing.Size(165, 27);
            this.newMDIRadButton.TabIndex = 0;
            this.newMDIRadButton.Text = "New MDI child form";
            this.newMDIRadButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.newMDIRadButton.Click += new System.EventHandler(this.newRadButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // radDock1
            // 
            this.radDock1.ActiveWindow = this.toolWindow1;
            this.radDock1.Controls.Add(this.documentContainer1);
            this.radDock1.Controls.Add(this.radSplitContainer1);
            this.radDock1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radDock1.DocumentManager.DocumentInsertOrder = Telerik.WinControls.UI.Docking.DockWindowInsertOrder.InFront;
            guidToNameMapping1.Guid = new System.Guid("3e428570-705e-4bed-9d7b-62cc6f7ea32f");
            guidToNameMapping1.Name = "toolWindow1";
            guidToNameMapping2.Guid = new System.Guid("b489d229-833b-49fa-92e1-e7992b2fcc56");
            guidToNameMapping2.Name = "toolWindow2";
            this.radDock1.GuidToNameMappings.Add(guidToNameMapping1);
            this.radDock1.GuidToNameMappings.Add(guidToNameMapping2);
            this.radDock1.Location = new System.Drawing.Point(0, 0);
            this.radDock1.MainDocumentContainer = this.documentContainer1;
            this.radDock1.Name = "radDock1";
            // 
            // 
            // 
            this.radDock1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.radDock1.Size = new System.Drawing.Size(900, 650);
            this.radDock1.TabIndex = 5;
            this.radDock1.TabStop = false;
            // 
            // toolWindow1
            // 
            this.toolWindow1.Controls.Add(this.imageMDIRadButton);
            this.toolWindow1.Controls.Add(this.reportMDIRadButton);
            this.toolWindow1.Controls.Add(this.orderMDIRadButton);
            this.toolWindow1.Controls.Add(this.customerMDIRadButton);
            this.toolWindow1.Controls.Add(this.label1);
            this.toolWindow1.Controls.Add(this.newMDIRadButton);
            this.toolWindow1.Location = new System.Drawing.Point(1, 26);
            this.toolWindow1.Name = "toolWindow1";
            this.toolWindow1.Size = new System.Drawing.Size(198, 297);
            this.toolWindow1.Text = "Settings";
            // 
            // documentContainer1
            // 
            this.documentContainer1.Location = new System.Drawing.Point(0, 0);
            this.documentContainer1.Name = "documentContainer1";
            // 
            // 
            // 
            this.documentContainer1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.documentContainer1.Size = new System.Drawing.Size(697, 650);
            this.documentContainer1.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill;
            this.documentContainer1.TabIndex = 0;
            this.documentContainer1.TabStop = false;
            // 
            // radSplitContainer1
            // 
            this.radSplitContainer1.Controls.Add(this.toolTabStrip1);
            this.radSplitContainer1.Controls.Add(this.toolTabStrip2);
            this.radSplitContainer1.Location = new System.Drawing.Point(700, 0);
            this.radSplitContainer1.Name = "radSplitContainer1";
            this.radSplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // 
            // 
            this.radSplitContainer1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.radSplitContainer1.Size = new System.Drawing.Size(200, 650);
            this.radSplitContainer1.TabIndex = 1;
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
            this.toolTabStrip1.Size = new System.Drawing.Size(200, 324);
            this.toolTabStrip1.TabIndex = 0;
            this.toolTabStrip1.TabStop = false;
            // 
            // toolTabStrip2
            // 
            this.toolTabStrip2.Controls.Add(this.toolWindow2);
            this.toolTabStrip2.Location = new System.Drawing.Point(0, 327);
            this.toolTabStrip2.Name = "toolTabStrip2";
            // 
            // 
            // 
            this.toolTabStrip2.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.toolTabStrip2.SelectedIndex = 0;
            this.toolTabStrip2.Size = new System.Drawing.Size(200, 323);
            this.toolTabStrip2.TabIndex = 1;
            this.toolTabStrip2.TabStop = false;
            // 
            // toolWindow2
            // 
            this.toolWindow2.Controls.Add(this.logRadTextBox);
            this.toolWindow2.Location = new System.Drawing.Point(1, 26);
            this.toolWindow2.Name = "toolWindow2";
            this.toolWindow2.Size = new System.Drawing.Size(198, 296);
            this.toolWindow2.Text = "Log";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Controls.Add(this.radDock1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "MDI Parent Form";
            ((System.ComponentModel.ISupportInitialize)(this.logRadTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageMDIRadButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportMDIRadButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderMDIRadButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerMDIRadButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newMDIRadButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDock1)).EndInit();
            this.radDock1.ResumeLayout(false);
            this.toolWindow1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.documentContainer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).EndInit();
            this.radSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip1)).EndInit();
            this.toolTabStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip2)).EndInit();
            this.toolTabStrip2.ResumeLayout(false);
            this.toolWindow2.ResumeLayout(false);
            this.toolWindow2.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

        private Telerik.WinControls.UI.RadButton newMDIRadButton;
        private Telerik.WinControls.UI.RadTextBox logRadTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private Telerik.WinControls.UI.RadButton reportMDIRadButton;
        private Telerik.WinControls.UI.RadButton orderMDIRadButton;
        private Telerik.WinControls.UI.RadButton customerMDIRadButton;
        private Telerik.WinControls.UI.RadButton imageMDIRadButton;
        private Telerik.WinControls.UI.Docking.RadDock radDock1;
        private Telerik.WinControls.UI.Docking.ToolWindow toolWindow1;
        private Telerik.WinControls.UI.Docking.DocumentContainer documentContainer1;
        private Telerik.WinControls.UI.RadSplitContainer radSplitContainer1;
        private Telerik.WinControls.UI.Docking.ToolTabStrip toolTabStrip1;
        private Telerik.WinControls.UI.Docking.ToolTabStrip toolTabStrip2;
        private Telerik.WinControls.UI.Docking.ToolWindow toolWindow2;
        
	}
}