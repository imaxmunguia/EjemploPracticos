namespace Telerik.Examples.WinControls.Editors.RadColorSelector.FirstLook
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
            this.radColorSelector1 = new Telerik.WinControls.UI.RadColorSelector();
            this.radCheckBox9 = new Telerik.WinControls.UI.RadCheckBox();
            this.radCheckBox5 = new Telerik.WinControls.UI.RadCheckBox();
            this.radCheckBox6 = new Telerik.WinControls.UI.RadCheckBox();
            this.radCheckBox7 = new Telerik.WinControls.UI.RadCheckBox();
            this.radCheckBox8 = new Telerik.WinControls.UI.RadCheckBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radTextBox1 = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radTextBox2 = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radTextBox3 = new Telerik.WinControls.UI.RadTextBox();
            this.radCheckBox3 = new Telerik.WinControls.UI.RadCheckBox();
            this.radCheckBox1 = new Telerik.WinControls.UI.RadCheckBox();
            this.radCheckBox2 = new Telerik.WinControls.UI.RadCheckBox();
            this.radCheckBox4 = new Telerik.WinControls.UI.RadCheckBox();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.radGroupBox3 = new Telerik.WinControls.UI.RadGroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox3)).BeginInit();
            this.radGroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radGroupBox1);
            this.settingsPanel.Controls.Add(this.radGroupBox2);
            this.settingsPanel.Controls.Add(this.radGroupBox3);
            this.settingsPanel.Location = new System.Drawing.Point(779, 1);
            // 
            // 
            // 
            this.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black;
            this.settingsPanel.Size = new System.Drawing.Size(200, 867);
            this.settingsPanel.ThemeName = "ControlDefault";
            this.settingsPanel.Controls.SetChildIndex(this.radGroupBox3, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radGroupBox2, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radGroupBox1, 0);
            // 
            // radColorSelector1
            // 
            this.radColorSelector1.AddNewColorButtonText = "Add Custom Color";
            this.radColorSelector1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radColorSelector1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(219)))), ((int)(((byte)(247)))));
            this.radColorSelector1.BasicTabHeading = "Basic";
            this.radColorSelector1.Location = new System.Drawing.Point(175, 218);
            this.radColorSelector1.MinimumSize = new System.Drawing.Size(508, 395);
            this.radColorSelector1.Name = "radColorSelector1";
            this.radColorSelector1.OldColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.radColorSelector1.OldColorLabelHeading = "Current";
            this.radColorSelector1.ProfessionalTabHeading = "Professional";
            this.radColorSelector1.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.radColorSelector1.SelectedColorLabelHeading = "New";
            this.radColorSelector1.SelectedHslColor = Telerik.WinControls.HslColor.FromAhsl(0, 1, 1);
            this.radColorSelector1.Size = new System.Drawing.Size(631, 433);
            this.radColorSelector1.SystemTabHeading = "System";
            this.radColorSelector1.TabIndex = 0;
            this.radColorSelector1.WebTabHeading = "Web";
            this.radColorSelector1.ColorChanged += new Telerik.WinControls.ColorChangedEventHandler(this.radColorSelector1_ColorChanged);
            // 
            // radCheckBox9
            // 
            this.radCheckBox9.BackColor = System.Drawing.Color.Transparent;
            this.radCheckBox9.ForeColor = System.Drawing.Color.Black;
            this.radCheckBox9.Location = new System.Drawing.Point(9, 115);
            this.radCheckBox9.Name = "radCheckBox9";
            // 
            // 
            // 
            this.radCheckBox9.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radCheckBox9.Size = new System.Drawing.Size(110, 29);
            this.radCheckBox9.TabIndex = 4;
            this.radCheckBox9.Text = "Allow Color Pick\r\nFrom Screen";
            this.radCheckBox9.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBox9_Click);
            // 
            // radCheckBox5
            // 
            this.radCheckBox5.BackColor = System.Drawing.Color.Transparent;
            this.radCheckBox5.ForeColor = System.Drawing.Color.Black;
            this.radCheckBox5.Location = new System.Drawing.Point(9, 67);
            this.radCheckBox5.Name = "radCheckBox5";
            // 
            // 
            // 
            this.radCheckBox5.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radCheckBox5.Size = new System.Drawing.Size(139, 17);
            this.radCheckBox5.TabIndex = 2;
            this.radCheckBox5.Text = "Show HEX Color Value";
            this.radCheckBox5.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBox5_Click);
            // 
            // radCheckBox6
            // 
            this.radCheckBox6.BackColor = System.Drawing.Color.Transparent;
            this.radCheckBox6.ForeColor = System.Drawing.Color.Black;
            this.radCheckBox6.Location = new System.Drawing.Point(9, 21);
            this.radCheckBox6.Name = "radCheckBox6";
            // 
            // 
            // 
            this.radCheckBox6.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radCheckBox6.Size = new System.Drawing.Size(128, 17);
            this.radCheckBox6.TabIndex = 0;
            this.radCheckBox6.Text = "Show Custom Colors";
            this.radCheckBox6.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBox6_Click);
            // 
            // radCheckBox7
            // 
            this.radCheckBox7.BackColor = System.Drawing.Color.Transparent;
            this.radCheckBox7.ForeColor = System.Drawing.Color.Black;
            this.radCheckBox7.Location = new System.Drawing.Point(9, 44);
            this.radCheckBox7.Name = "radCheckBox7";
            // 
            // 
            // 
            this.radCheckBox7.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radCheckBox7.Size = new System.Drawing.Size(117, 17);
            this.radCheckBox7.TabIndex = 1;
            this.radCheckBox7.Text = "Allow Color Saving";
            this.radCheckBox7.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBox7_Click);
            // 
            // radCheckBox8
            // 
            this.radCheckBox8.BackColor = System.Drawing.Color.Transparent;
            this.radCheckBox8.ForeColor = System.Drawing.Color.Black;
            this.radCheckBox8.Location = new System.Drawing.Point(9, 92);
            this.radCheckBox8.Name = "radCheckBox8";
            // 
            // 
            // 
            this.radCheckBox8.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radCheckBox8.Size = new System.Drawing.Size(146, 17);
            this.radCheckBox8.TabIndex = 3;
            this.radCheckBox8.Text = "Allow HEX Value Editing";
            this.radCheckBox8.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBox8_Click);
            // 
            // radLabel1
            // 
            this.radLabel1.ForeColor = System.Drawing.Color.Black;
            this.radLabel1.Location = new System.Drawing.Point(15, 23);
            this.radLabel1.Name = "radLabel1";
            // 
            // 
            // 
            this.radLabel1.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radLabel1.Size = new System.Drawing.Size(91, 14);
            this.radLabel1.TabIndex = 5;
            this.radLabel1.Text = "New Color Label:";
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radTextBox1
            // 
            this.radTextBox1.ForeColor = System.Drawing.Color.Black;
            this.radTextBox1.Location = new System.Drawing.Point(30, 43);
            this.radTextBox1.Name = "radTextBox1";
            // 
            // 
            // 
            this.radTextBox1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radTextBox1.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radTextBox1.Size = new System.Drawing.Size(122, 20);
            this.radTextBox1.TabIndex = 4;
            this.radTextBox1.TextChanged += new System.EventHandler(this.radTextBox1_TextChanged);
            // 
            // radLabel3
            // 
            this.radLabel3.ForeColor = System.Drawing.Color.Black;
            this.radLabel3.Location = new System.Drawing.Point(15, 115);
            this.radLabel3.Name = "radLabel3";
            // 
            // 
            // 
            this.radLabel3.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radLabel3.Size = new System.Drawing.Size(88, 14);
            this.radLabel3.TabIndex = 7;
            this.radLabel3.Text = "Add Color Label:";
            this.radLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radTextBox2
            // 
            this.radTextBox2.ForeColor = System.Drawing.Color.Black;
            this.radTextBox2.Location = new System.Drawing.Point(30, 89);
            this.radTextBox2.Name = "radTextBox2";
            // 
            // 
            // 
            this.radTextBox2.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radTextBox2.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radTextBox2.Size = new System.Drawing.Size(122, 20);
            this.radTextBox2.TabIndex = 6;
            this.radTextBox2.TextChanged += new System.EventHandler(this.radTextBox2_TextChanged);
            // 
            // radLabel2
            // 
            this.radLabel2.ForeColor = System.Drawing.Color.Black;
            this.radLabel2.Location = new System.Drawing.Point(15, 69);
            this.radLabel2.Name = "radLabel2";
            // 
            // 
            // 
            this.radLabel2.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radLabel2.Size = new System.Drawing.Size(106, 14);
            this.radLabel2.TabIndex = 7;
            this.radLabel2.Text = "Current Color Label:";
            this.radLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radTextBox3
            // 
            this.radTextBox3.ForeColor = System.Drawing.Color.Black;
            this.radTextBox3.Location = new System.Drawing.Point(30, 135);
            this.radTextBox3.Name = "radTextBox3";
            // 
            // 
            // 
            this.radTextBox3.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radTextBox3.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radTextBox3.Size = new System.Drawing.Size(122, 20);
            this.radTextBox3.TabIndex = 6;
            this.radTextBox3.TextChanged += new System.EventHandler(this.radTextBox3_TextChanged);
            // 
            // radCheckBox3
            // 
            this.radCheckBox3.BackColor = System.Drawing.Color.Transparent;
            this.radCheckBox3.ForeColor = System.Drawing.Color.Black;
            this.radCheckBox3.Location = new System.Drawing.Point(8, 66);
            this.radCheckBox3.Name = "radCheckBox3";
            // 
            // 
            // 
            this.radCheckBox3.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radCheckBox3.Size = new System.Drawing.Size(135, 17);
            this.radCheckBox3.TabIndex = 2;
            this.radCheckBox3.Text = "Show Web Colors Tab";
            this.radCheckBox3.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBox3_Click);
            // 
            // radCheckBox1
            // 
            this.radCheckBox1.BackColor = System.Drawing.Color.Transparent;
            this.radCheckBox1.ForeColor = System.Drawing.Color.Black;
            this.radCheckBox1.Location = new System.Drawing.Point(8, 20);
            this.radCheckBox1.Name = "radCheckBox1";
            // 
            // 
            // 
            this.radCheckBox1.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radCheckBox1.Size = new System.Drawing.Size(140, 17);
            this.radCheckBox1.TabIndex = 0;
            this.radCheckBox1.Text = "Show Basic Colors Tab";
            this.radCheckBox1.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBox1_Click);
            // 
            // radCheckBox2
            // 
            this.radCheckBox2.BackColor = System.Drawing.Color.Transparent;
            this.radCheckBox2.ForeColor = System.Drawing.Color.Black;
            this.radCheckBox2.Location = new System.Drawing.Point(8, 43);
            this.radCheckBox2.Name = "radCheckBox2";
            // 
            // 
            // 
            this.radCheckBox2.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radCheckBox2.Size = new System.Drawing.Size(150, 17);
            this.radCheckBox2.TabIndex = 1;
            this.radCheckBox2.Text = "Show System Colors Tab";
            this.radCheckBox2.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBox2_Click);
            // 
            // radCheckBox4
            // 
            this.radCheckBox4.BackColor = System.Drawing.Color.Transparent;
            this.radCheckBox4.ForeColor = System.Drawing.Color.Black;
            this.radCheckBox4.Location = new System.Drawing.Point(8, 89);
            this.radCheckBox4.Name = "radCheckBox4";
            // 
            // 
            // 
            this.radCheckBox4.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radCheckBox4.Size = new System.Drawing.Size(122, 29);
            this.radCheckBox4.TabIndex = 3;
            this.radCheckBox4.Text = "Show Professional\r\nColors Tab";
            this.radCheckBox4.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBox4_Click);
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.Controls.Add(this.radCheckBox3);
            this.radGroupBox1.Controls.Add(this.radCheckBox1);
            this.radGroupBox1.Controls.Add(this.radCheckBox4);
            this.radGroupBox1.Controls.Add(this.radCheckBox2);
            this.radGroupBox1.FooterImageIndex = -1;
            this.radGroupBox1.FooterImageKey = "";
            this.radGroupBox1.FooterText = "";
            this.radGroupBox1.ForeColor = System.Drawing.Color.Black;
            this.radGroupBox1.HeaderImageIndex = -1;
            this.radGroupBox1.HeaderImageKey = "";
            this.radGroupBox1.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBox1.HeaderText = " Color Tab Visibility ";
            this.radGroupBox1.Location = new System.Drawing.Point(15, 6);
            this.radGroupBox1.Name = "radGroupBox1";
            // 
            // 
            // 
            this.radGroupBox1.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radGroupBox1.Size = new System.Drawing.Size(162, 132);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = " Color Tab Visibility ";
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.Controls.Add(this.radLabel1);
            this.radGroupBox2.Controls.Add(this.radTextBox1);
            this.radGroupBox2.Controls.Add(this.radTextBox3);
            this.radGroupBox2.Controls.Add(this.radLabel3);
            this.radGroupBox2.Controls.Add(this.radLabel2);
            this.radGroupBox2.Controls.Add(this.radTextBox2);
            this.radGroupBox2.FooterImageIndex = -1;
            this.radGroupBox2.FooterImageKey = "";
            this.radGroupBox2.FooterText = "";
            this.radGroupBox2.ForeColor = System.Drawing.Color.Black;
            this.radGroupBox2.HeaderImageIndex = -1;
            this.radGroupBox2.HeaderImageKey = "";
            this.radGroupBox2.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBox2.HeaderText = " Captions ";
            this.radGroupBox2.Location = new System.Drawing.Point(15, 143);
            this.radGroupBox2.Name = "radGroupBox2";
            // 
            // 
            // 
            this.radGroupBox2.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radGroupBox2.Size = new System.Drawing.Size(162, 182);
            this.radGroupBox2.TabIndex = 1;
            this.radGroupBox2.Text = " Captions ";
            // 
            // radGroupBox3
            // 
            this.radGroupBox3.Controls.Add(this.radCheckBox9);
            this.radGroupBox3.Controls.Add(this.radCheckBox6);
            this.radGroupBox3.Controls.Add(this.radCheckBox5);
            this.radGroupBox3.Controls.Add(this.radCheckBox8);
            this.radGroupBox3.Controls.Add(this.radCheckBox7);
            this.radGroupBox3.FooterImageIndex = -1;
            this.radGroupBox3.FooterImageKey = "";
            this.radGroupBox3.FooterText = "";
            this.radGroupBox3.ForeColor = System.Drawing.Color.Black;
            this.radGroupBox3.HeaderImageIndex = -1;
            this.radGroupBox3.HeaderImageKey = "";
            this.radGroupBox3.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBox3.HeaderText = " Color Tab Visibility ";
            this.radGroupBox3.Location = new System.Drawing.Point(15, 331);
            this.radGroupBox3.Name = "radGroupBox3";
            // 
            // 
            // 
            this.radGroupBox3.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radGroupBox3.Size = new System.Drawing.Size(162, 161);
            this.radGroupBox3.TabIndex = 2;
            this.radGroupBox3.Text = " Color Tab Visibility ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font; 
            this.Controls.Add(this.radColorSelector1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(980, 869);
            this.Controls.SetChildIndex(this.radColorSelector1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            this.radGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox3)).EndInit();
            this.radGroupBox3.ResumeLayout(false);
            this.radGroupBox3.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

        private Telerik.WinControls.UI.RadColorSelector radColorSelector1;
		private Telerik.WinControls.UI.RadLabel radLabel3;
		private Telerik.WinControls.UI.RadLabel radLabel2;
		private Telerik.WinControls.UI.RadTextBox radTextBox3;
		private Telerik.WinControls.UI.RadTextBox radTextBox2;
		private Telerik.WinControls.UI.RadLabel radLabel1;
		private Telerik.WinControls.UI.RadTextBox radTextBox1;
		private Telerik.WinControls.UI.RadCheckBox radCheckBox4;
		private Telerik.WinControls.UI.RadCheckBox radCheckBox3;
		private Telerik.WinControls.UI.RadCheckBox radCheckBox2;
        private Telerik.WinControls.UI.RadCheckBox radCheckBox1;
		private Telerik.WinControls.UI.RadCheckBox radCheckBox5;
		private Telerik.WinControls.UI.RadCheckBox radCheckBox6;
		private Telerik.WinControls.UI.RadCheckBox radCheckBox7;
		private Telerik.WinControls.UI.RadCheckBox radCheckBox8;
		private Telerik.WinControls.UI.RadCheckBox radCheckBox9;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox3;

	}
}
