namespace Telerik.Examples.WinControls.Editors.MaskTextBox.Globalization
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
            this.radMaskedEditDateTime = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.radLblCulture = new Telerik.WinControls.UI.RadLabel();
            this.radComboCultures = new Telerik.WinControls.UI.RadDropDownList();
            this.radLblFullDateTime = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMaskedEditDateTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLblCulture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radComboCultures)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLblFullDateTime)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Location = new System.Drawing.Point(665, 1);
            // 
            // 
            // 
            this.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black;
            this.settingsPanel.Size = new System.Drawing.Size(200, 788);
            // 
            // radMaskedEditDateTime
            // 
            this.radMaskedEditDateTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radMaskedEditDateTime.BackColor = System.Drawing.Color.Transparent;
            this.radMaskedEditDateTime.Culture = null;
            this.radMaskedEditDateTime.ForeColor = System.Drawing.Color.Black;
            this.radMaskedEditDateTime.Location = new System.Drawing.Point(374, 410);
            this.radMaskedEditDateTime.Mask = "F";
            this.radMaskedEditDateTime.MaskType = Telerik.WinControls.UI.MaskType.DateTime;
            this.radMaskedEditDateTime.Name = "radMaskedEditDateTime";
            this.radMaskedEditDateTime.Padding = new System.Windows.Forms.Padding(2, 2, 2, 3);
            // 
            // 
            // 
            this.radMaskedEditDateTime.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radMaskedEditDateTime.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radMaskedEditDateTime.SelectedText = "November";
            this.radMaskedEditDateTime.SelectionLength = 8;
            this.radMaskedEditDateTime.SelectionStart = 10;
            this.radMaskedEditDateTime.Size = new System.Drawing.Size(221, 20);
            this.radMaskedEditDateTime.TabIndex = 0;
            this.radMaskedEditDateTime.Text = "Thursday, November 01, 2007 12:00:00 AM";
            this.radMaskedEditDateTime.Value = new System.DateTime(2007, 11, 1, 0, 0, 0, 0);
            // 
            // radLblCulture
            // 
            this.radLblCulture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radLblCulture.BackColor = System.Drawing.Color.Transparent;
            this.radLblCulture.ForeColor = System.Drawing.Color.Black;
            this.radLblCulture.Location = new System.Drawing.Point(271, 361);
            this.radLblCulture.Name = "radLblCulture";
            // 
            // 
            // 
            this.radLblCulture.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radLblCulture.Size = new System.Drawing.Size(83, 14);
            this.radLblCulture.TabIndex = 8;
            this.radLblCulture.Text = "Choose culture:";
            // 
            // radComboCultures
            // 
            this.radComboCultures.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radComboCultures.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.radComboCultures.BackColor = System.Drawing.Color.Transparent;
            this.radComboCultures.DropDownSizingMode = ((Telerik.WinControls.UI.SizingMode)((Telerik.WinControls.UI.SizingMode.RightBottom | Telerik.WinControls.UI.SizingMode.UpDown)));
            this.radComboCultures.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.radComboCultures.ForeColor = System.Drawing.Color.Black;
            this.radComboCultures.Location = new System.Drawing.Point(374, 361);
            this.radComboCultures.MaxDropDownItems = 6;
            this.radComboCultures.Name = "radComboCultures";
            // 
            // 
            // 
            this.radComboCultures.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radComboCultures.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radComboCultures.Size = new System.Drawing.Size(221, 20);
            this.radComboCultures.TabIndex = 7;
            // 
            // radLblFullDateTime
            // 
            this.radLblFullDateTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radLblFullDateTime.ForeColor = System.Drawing.Color.Black;
            this.radLblFullDateTime.Location = new System.Drawing.Point(273, 410);
            this.radLblFullDateTime.Name = "radLblFullDateTime";
            // 
            // 
            // 
            this.radLblFullDateTime.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radLblFullDateTime.Size = new System.Drawing.Size(81, 14);
            this.radLblFullDateTime.TabIndex = 9;
            this.radLblFullDateTime.Text = "Full Date Time:";
            // 
            // Form1
            // 
            this.Controls.Add(this.radMaskedEditDateTime);
            this.Controls.Add(this.radLblCulture);
            this.Controls.Add(this.radLblFullDateTime);
            this.Controls.Add(this.radComboCultures);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(866, 790);
            this.Controls.SetChildIndex(this.radComboCultures, 0);
            this.Controls.SetChildIndex(this.radLblFullDateTime, 0);
            this.Controls.SetChildIndex(this.radLblCulture, 0);
            this.Controls.SetChildIndex(this.radMaskedEditDateTime, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMaskedEditDateTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLblCulture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radComboCultures)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLblFullDateTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

        private Telerik.WinControls.UI.RadMaskedEditBox radMaskedEditDateTime;
		private Telerik.WinControls.UI.RadLabel radLblCulture;
		private Telerik.WinControls.UI.RadDropDownList radComboCultures;
        private Telerik.WinControls.UI.RadLabel radLblFullDateTime;
	}
}