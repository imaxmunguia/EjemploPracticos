namespace Telerik.Examples.WinControls.Forms.RadAboutBox
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
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radRadioButton1 = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioButton2 = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioButton3 = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioButton4 = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioButton5 = new Telerik.WinControls.UI.RadRadioButton();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButton4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButton5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radGroupBox1);
            this.settingsPanel.Location = new System.Drawing.Point(973, 1);
            // 
            // 
            // 
            this.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black;
            this.settingsPanel.Size = new System.Drawing.Size(250, 617);
            this.settingsPanel.ThemeName = "ControlDefault";
            this.settingsPanel.Controls.SetChildIndex(this.radGroupBox1, 0);
            // 
            // radButton1
            // 
            this.radButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radButton1.Location = new System.Drawing.Point(498, 294);
            this.radButton1.Name = "radButton1";
            // 
            // 
            // 
            this.radButton1.Size = new System.Drawing.Size(229, 30);
            this.radButton1.TabIndex = 1;
            this.radButton1.Text = "Show RadAboutBox";
            // 
            // radRadioButton1
            // 
            this.radRadioButton1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.radRadioButton1.Location = new System.Drawing.Point(28, 21);
            this.radRadioButton1.Name = "radRadioButton1";
            this.radRadioButton1.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // 
            // 
            this.radRadioButton1.Size = new System.Drawing.Size(101, 16);
            this.radRadioButton1.TabIndex = 12;
            this.radRadioButton1.Text = "Office2010 Blue";
            this.radRadioButton1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // radRadioButton2
            // 
            this.radRadioButton2.Location = new System.Drawing.Point(28, 43);
            this.radRadioButton2.Name = "radRadioButton2";
            this.radRadioButton2.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // 
            // 
            this.radRadioButton2.Size = new System.Drawing.Size(106, 16);
            this.radRadioButton2.TabIndex = 13;
            this.radRadioButton2.Text = "Office2010 Silver";
            // 
            // radRadioButton3
            // 
            this.radRadioButton3.Location = new System.Drawing.Point(28, 65);
            this.radRadioButton3.Name = "radRadioButton3";
            this.radRadioButton3.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // 
            // 
            this.radRadioButton3.Size = new System.Drawing.Size(106, 16);
            this.radRadioButton3.TabIndex = 14;
            this.radRadioButton3.Text = "Office2010 Black";
            // 
            // radRadioButton4
            // 
            this.radRadioButton4.Location = new System.Drawing.Point(28, 87);
            this.radRadioButton4.Name = "radRadioButton4";
            this.radRadioButton4.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // 
            // 
            this.radRadioButton4.Size = new System.Drawing.Size(47, 16);
            this.radRadioButton4.TabIndex = 15;
            this.radRadioButton4.Text = "TelerikMetro";
            // 
            // radRadioButton5
            // 
            this.radRadioButton5.Location = new System.Drawing.Point(28, 109);
            this.radRadioButton5.Name = "radRadioButton5";
            this.radRadioButton5.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // 
            // 
            this.radRadioButton5.Size = new System.Drawing.Size(54, 16);
            this.radRadioButton5.TabIndex = 16;
            this.radRadioButton5.Text = "Desert";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.Controls.Add(this.radRadioButton1);
            this.radGroupBox1.Controls.Add(this.radRadioButton5);
            this.radGroupBox1.Controls.Add(this.radRadioButton2);
            this.radGroupBox1.Controls.Add(this.radRadioButton4);
            this.radGroupBox1.Controls.Add(this.radRadioButton3);
            this.radGroupBox1.FooterImageIndex = -1;
            this.radGroupBox1.FooterImageKey = "";
            this.radGroupBox1.HeaderImageIndex = -1;
            this.radGroupBox1.HeaderImageKey = "";
            this.radGroupBox1.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBox1.HeaderText = "Select Theme";
            this.radGroupBox1.Location = new System.Drawing.Point(15, 6);
            this.radGroupBox1.Name = "radGroupBox1";
            // 
            // 
            // 
            this.radGroupBox1.Size = new System.Drawing.Size(162, 139);
            this.radGroupBox1.TabIndex = 17;
            this.radGroupBox1.Text = "Select Theme";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radButton1);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(1224, 619);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            this.Controls.SetChildIndex(this.radButton1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButton4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButton5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadRadioButton radRadioButton5;
        private Telerik.WinControls.UI.RadRadioButton radRadioButton4;
        private Telerik.WinControls.UI.RadRadioButton radRadioButton3;
        private Telerik.WinControls.UI.RadRadioButton radRadioButton2;
        private Telerik.WinControls.UI.RadRadioButton radRadioButton1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
    }
}