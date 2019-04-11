namespace Telerik.Examples.WinControls.TreeView.RightToLeft
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
            this.radTreeView1 = new Telerik.WinControls.UI.RadTreeView();
            this.radCheckBoxRightToLeft = new Telerik.WinControls.UI.RadCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTreeView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxRightToLeft)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radCheckBoxRightToLeft);
            this.settingsPanel.ForeColor = System.Drawing.Color.Black;
            this.settingsPanel.Location = new System.Drawing.Point(1040, 1);
            // 
            // 
            // 
            this.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black;
            this.settingsPanel.Size = new System.Drawing.Size(200, 830);
            this.settingsPanel.ThemeName = "ControlDefault";
            this.settingsPanel.Controls.SetChildIndex(this.radCheckBoxRightToLeft, 0);
            // 
            // radTreeView1
            // 
            this.radTreeView1.AccessibleName = "RadTreeView";
            this.radTreeView1.AccessibleRole = System.Windows.Forms.AccessibleRole.List;
            this.radTreeView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radTreeView1.BackColor = System.Drawing.Color.Transparent;
            this.radTreeView1.CheckBoxes = true;
            this.radTreeView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.radTreeView1.Font = new System.Drawing.Font("Tahoma", 8.6F);
            this.radTreeView1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radTreeView1.Location = new System.Drawing.Point(17, 19);
            this.radTreeView1.Name = "radTreeView1";           
            this.radTreeView1.Size = new System.Drawing.Size(246, 441);
            this.radTreeView1.TabIndex = 0;
            this.radTreeView1.Text = "radTreeView1";
            this.radTreeView1.ItemHeight = 27;
            // 
            // radCheckBoxRightToLeft
            // 
            this.radCheckBoxRightToLeft.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radCheckBoxRightToLeft.Location = new System.Drawing.Point(10, 37);
            this.radCheckBoxRightToLeft.Name = "radCheckBoxRightToLeft";
            this.radCheckBoxRightToLeft.Size = new System.Drawing.Size(82, 18);
            this.radCheckBoxRightToLeft.TabIndex = 1;
            this.radCheckBoxRightToLeft.Text = "Right to Left";
            this.radCheckBoxRightToLeft.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBoxRightToLeft_ToggleStateChanged);
            // 
            // Form1
            // 
            this.Controls.Add(this.radTreeView1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1241, 832);
            this.Controls.SetChildIndex(this.radTreeView1, 1);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTreeView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxRightToLeft)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

        private Telerik.WinControls.UI.RadTreeView radTreeView1;
        private Telerik.WinControls.UI.RadCheckBox radCheckBoxRightToLeft;


	}
}