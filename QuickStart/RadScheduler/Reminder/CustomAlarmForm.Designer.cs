namespace Telerik.Examples.WinControls.RadScheduler.Reminder
{
    partial class CustomAlarmForm
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
            this.radListBox1 = new Telerik.WinControls.UI.RadListControl();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            this.radButton3 = new Telerik.WinControls.UI.RadButton();
            this.radButton4 = new Telerik.WinControls.UI.RadButton();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.radListBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radListBox1
            // 
            this.radListBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.radListBox1.Location = new System.Drawing.Point(12, 38);
            this.radListBox1.Name = "radListBox1";
            this.radListBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.radListBox1.Size = new System.Drawing.Size(188, 323);
            this.radListBox1.TabIndex = 0;
            this.radListBox1.Text = "Click to add new item";
            this.radListBox1.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.radListBox1_SelectedIndexChanged);
            // 
            // radButton1
            // 
            this.radButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radButton1.Location = new System.Drawing.Point(207, 38);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(130, 24);
            this.radButton1.TabIndex = 1;
            this.radButton1.Text = "Open Item";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // radButton2
            // 
            this.radButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radButton2.Location = new System.Drawing.Point(207, 68);
            this.radButton2.Name = "radButton2";
            this.radButton2.Size = new System.Drawing.Size(130, 24);
            this.radButton2.TabIndex = 2;
            this.radButton2.Text = "Snooze with a minute";
            this.radButton2.Click += new System.EventHandler(this.radButton2_Click);
            // 
            // radButton3
            // 
            this.radButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radButton3.Location = new System.Drawing.Point(207, 98);
            this.radButton3.Name = "radButton3";
            this.radButton3.Size = new System.Drawing.Size(130, 24);
            this.radButton3.TabIndex = 3;
            this.radButton3.Text = "Dismiss";
            this.radButton3.Click += new System.EventHandler(this.radButton3_Click);
            // 
            // radButton4
            // 
            this.radButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radButton4.Location = new System.Drawing.Point(207, 128);
            this.radButton4.Name = "radButton4";
            this.radButton4.Size = new System.Drawing.Size(130, 24);
            this.radButton4.TabIndex = 4;
            this.radButton4.Text = "Dismiss All";
            this.radButton4.Click += new System.EventHandler(this.radButton4_Click);
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(13, 13);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(41, 16);
            this.radLabel1.TabIndex = 5;
            this.radLabel1.Text = "Events";
            // 
            // CustomAlarmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 387);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.radButton4);
            this.Controls.Add(this.radButton3);
            this.Controls.Add(this.radButton2);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.radListBox1);
            this.Name = "CustomAlarmForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomAlarmForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CustomAlarmForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.radListBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadListControl radListBox1;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadButton radButton2;
        private Telerik.WinControls.UI.RadButton radButton3;
        private Telerik.WinControls.UI.RadButton radButton4;
        private Telerik.WinControls.UI.RadLabel radLabel1;
    }
}