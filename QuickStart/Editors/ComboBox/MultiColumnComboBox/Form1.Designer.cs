namespace Telerik.Examples.WinControls.Editors.ComboBox.MultiColumnComboBox
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
            this.radMultiColumnComboBox1 = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.radGroupSettings = new Telerik.WinControls.UI.RadGroupBox();
            this.radCheckAutoFilter = new Telerik.WinControls.UI.RadCheckBox();
            this.radCheckRotate = new Telerik.WinControls.UI.RadCheckBox();
            this.radCheckRTL = new Telerik.WinControls.UI.RadCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelDemoHolder)).BeginInit();
            this.radPanelDemoHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radMultiColumnComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMultiColumnComboBox1.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMultiColumnComboBox1.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupSettings)).BeginInit();
            this.radGroupSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckAutoFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckRotate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckRTL)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanelDemoHolder
            // 
            this.radPanelDemoHolder.Controls.Add(this.radMultiColumnComboBox1);
            this.radPanelDemoHolder.Location = new System.Drawing.Point(309, 343);
            this.radPanelDemoHolder.MaximumSize = new System.Drawing.Size(362, 100);
            this.radPanelDemoHolder.MinimumSize = new System.Drawing.Size(362, 100);
            // 
            // 
            // 
            this.radPanelDemoHolder.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radPanelDemoHolder.RootElement.MaxSize = new System.Drawing.Size(362, 100);
            this.radPanelDemoHolder.RootElement.MinSize = new System.Drawing.Size(362, 100);
            this.radPanelDemoHolder.Size = new System.Drawing.Size(362, 100);
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radGroupSettings);
            this.settingsPanel.Location = new System.Drawing.Point(779, 1);
            // 
            // 
            // 
            this.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black;
            this.settingsPanel.Size = new System.Drawing.Size(200, 784);
            this.settingsPanel.Controls.SetChildIndex(this.radGroupSettings, 0);
            // 
            // radMultiColumnComboBox1
            // 
            this.radMultiColumnComboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // radMultiColumnComboBox1.NestedRadGridView
            // 
            this.radMultiColumnComboBox1.EditorControl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.radMultiColumnComboBox1.EditorControl.Location = new System.Drawing.Point(4, 1);
            // 
            // 
            // 
            this.radMultiColumnComboBox1.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.radMultiColumnComboBox1.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.radMultiColumnComboBox1.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.radMultiColumnComboBox1.EditorControl.MasterTemplate.EnableGrouping = false;
            this.radMultiColumnComboBox1.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.radMultiColumnComboBox1.EditorControl.Name = "NestedRadGridView";
            this.radMultiColumnComboBox1.EditorControl.ReadOnly = true;
            this.radMultiColumnComboBox1.EditorControl.ShowGroupPanel = false;
            this.radMultiColumnComboBox1.EditorControl.Size = new System.Drawing.Size(282, 104);
            this.radMultiColumnComboBox1.EditorControl.TabIndex = 0;
            this.radMultiColumnComboBox1.ForeColor = System.Drawing.Color.Black;
            this.radMultiColumnComboBox1.Location = new System.Drawing.Point(28, 40);
            this.radMultiColumnComboBox1.Name = "radMultiColumnComboBox1";
            // 
            // 
            // 
            this.radMultiColumnComboBox1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radMultiColumnComboBox1.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radMultiColumnComboBox1.Size = new System.Drawing.Size(306, 20);
            this.radMultiColumnComboBox1.TabIndex = 0;
            // 
            // radGroupSettings
            // 
            this.radGroupSettings.Controls.Add(this.radCheckAutoFilter);
            this.radGroupSettings.Controls.Add(this.radCheckRotate);
            this.radGroupSettings.Controls.Add(this.radCheckRTL);
            this.radGroupSettings.FooterImageIndex = -1;
            this.radGroupSettings.FooterImageKey = "";
            this.radGroupSettings.FooterText = "";
            this.radGroupSettings.ForeColor = System.Drawing.Color.Black;
            this.radGroupSettings.HeaderImageIndex = -1;
            this.radGroupSettings.HeaderImageKey = "";
            this.radGroupSettings.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupSettings.HeaderText = "Settings";
            this.radGroupSettings.Location = new System.Drawing.Point(15, 6);
            this.radGroupSettings.Name = "radGroupSettings";
            // 
            // 
            // 
            this.radGroupSettings.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radGroupSettings.Size = new System.Drawing.Size(162, 108);
            this.radGroupSettings.TabIndex = 0;
            this.radGroupSettings.Text = "Settings";
            // 
            // radCheckAutoFilter
            // 
            this.radCheckAutoFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.radCheckAutoFilter.Location = new System.Drawing.Point(13, 32);
            this.radCheckAutoFilter.Name = "radCheckAutoFilter";
            // 
            // 
            // 
            this.radCheckAutoFilter.RootElement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.radCheckAutoFilter.Size = new System.Drawing.Size(74, 17);
            this.radCheckAutoFilter.TabIndex = 0;
            this.radCheckAutoFilter.Text = "Auto Filter";
            this.radCheckAutoFilter.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.OnCheckAutoFilter_ToggleStateChanged);
            // 
            // radCheckRotate
            // 
            this.radCheckRotate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.radCheckRotate.Location = new System.Drawing.Point(13, 55);
            this.radCheckRotate.Name = "radCheckRotate";
            // 
            // 
            // 
            this.radCheckRotate.RootElement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.radCheckRotate.Size = new System.Drawing.Size(141, 17);
            this.radCheckRotate.TabIndex = 0;
            this.radCheckRotate.Text = "Rotate On Double-Click";
            this.radCheckRotate.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.OnCheckRotate_ToggleStateChanged);
            // 
            // radCheckRTL
            // 
            this.radCheckRTL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.radCheckRTL.Location = new System.Drawing.Point(13, 78);
            this.radCheckRTL.Name = "radCheckRTL";
            this.radCheckRTL.Size = new System.Drawing.Size(87, 17);
            this.radCheckRTL.TabIndex = 0;
            this.radCheckRTL.Text = "Right To Left";
            this.radCheckRTL.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.OnCheckBoxRTL_ToggleStateChanged);
            // 
            // Form1
            // 
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(980, 786);
            ((System.ComponentModel.ISupportInitialize)(this.radPanelDemoHolder)).EndInit();
            this.radPanelDemoHolder.ResumeLayout(false);
            this.radPanelDemoHolder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radMultiColumnComboBox1.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMultiColumnComboBox1.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMultiColumnComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupSettings)).EndInit();
            this.radGroupSettings.ResumeLayout(false);
            this.radGroupSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckAutoFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckRotate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckRTL)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

        private Telerik.WinControls.UI.RadMultiColumnComboBox radMultiColumnComboBox1;
        private Telerik.WinControls.UI.RadGroupBox radGroupSettings;
        private Telerik.WinControls.UI.RadCheckBox radCheckAutoFilter;
        private Telerik.WinControls.UI.RadCheckBox radCheckRotate;
        private Telerik.WinControls.UI.RadCheckBox radCheckRTL;
	}
}