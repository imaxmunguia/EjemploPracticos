namespace Telerik.Examples.WinControls.RadScheduler.TimelineGrouping
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
            this.radScheduler1 = new Telerik.WinControls.UI.RadScheduler();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radScheduler1)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Location = new System.Drawing.Point(1056, 1);
            this.settingsPanel.Size = new System.Drawing.Size(200, 631);
            this.settingsPanel.ThemeName = "ControlDefault";
            // 
            // radScheduler1
            // 
            this.radScheduler1.DataSource = null;
            this.radScheduler1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radScheduler1.GroupType = Telerik.WinControls.UI.GroupType.None;
            this.radScheduler1.HeaderFormat = "dd dddd";
            this.radScheduler1.Location = new System.Drawing.Point(0, 0);
            this.radScheduler1.Name = "radScheduler1";
            this.radScheduler1.Size = new System.Drawing.Size(1257, 633);
            this.radScheduler1.TabIndex = 1;
            this.radScheduler1.Text = "radScheduler1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radScheduler1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1257, 633);
            this.Controls.SetChildIndex(this.radScheduler1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radScheduler1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadScheduler radScheduler1;
    }
}