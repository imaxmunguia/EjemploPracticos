using System.ComponentModel;
namespace Telerik.Examples.WinControls.Buttons.CheckBoxes
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
            this.components = new Container();
            this.radCheckBox3 = new Telerik.WinControls.UI.RadCheckBox();
            this.radCheckBox2 = new Telerik.WinControls.UI.RadCheckBox();
            this.radCheckBox1 = new Telerik.WinControls.UI.RadCheckBox();
            this.radGroupEvents = new Telerik.WinControls.UI.RadGroupBox();
            this.radTextBoxEvents = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelDemoHolder)).BeginInit();
            this.radPanelDemoHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupEvents)).BeginInit();
            this.radGroupEvents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxEvents)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanelDemoHolder
            // 
            this.radPanelDemoHolder.Controls.Add(this.radCheckBox1);
            this.radPanelDemoHolder.Controls.Add(this.radCheckBox3);
            this.radPanelDemoHolder.Controls.Add(this.radCheckBox2);
            this.radPanelDemoHolder.Location = new System.Drawing.Point(512, 218);
            // 
            // 
            // 
            this.radPanelDemoHolder.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radPanelDemoHolder.Size = new System.Drawing.Size(255, 173);
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radGroupEvents);
            this.settingsPanel.Location = new System.Drawing.Point(973, 1);
            // 
            // 
            // 
            this.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black;
            this.settingsPanel.Size = new System.Drawing.Size(250, 534);
            this.settingsPanel.Controls.SetChildIndex(this.radGroupEvents, 0);
            // 
            // radCheckBox3
            // 
            this.radCheckBox3.BackColor = System.Drawing.Color.Transparent;
            this.radCheckBox3.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCheckBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.radCheckBox3.Location = new System.Drawing.Point(72, 98);
            this.radCheckBox3.Name = "radCheckBox3";
            // 
            // 
            // 
            this.radCheckBox3.RootElement.ToolTipText = null;
            this.radCheckBox3.Size = new System.Drawing.Size(111, 26);
            this.radCheckBox3.TabIndex = 2;
            this.radCheckBox3.Text = "Arial, 14pt";
            this.radCheckBox3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radCheckBox3.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBox1_ToggleStateChanged);
            // 
            // radCheckBox2
            // 
            this.radCheckBox2.BackColor = System.Drawing.Color.Transparent;
            this.radCheckBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCheckBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.radCheckBox2.Location = new System.Drawing.Point(72, 73);
            this.radCheckBox2.Name = "radCheckBox2";
            // 
            // 
            // 
            this.radCheckBox2.RootElement.ToolTipText = null;
            this.radCheckBox2.Size = new System.Drawing.Size(98, 22);
            this.radCheckBox2.TabIndex = 1;
            this.radCheckBox2.Text = "Arial, 12pt";
            this.radCheckBox2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radCheckBox2.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBox1_ToggleStateChanged);
            // 
            // radCheckBox1
            // 
            this.radCheckBox1.BackColor = System.Drawing.Color.Transparent;
            this.radCheckBox1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radCheckBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.radCheckBox1.Location = new System.Drawing.Point(72, 48);
            this.radCheckBox1.Name = "radCheckBox1";
            // 
            // 
            // 
            this.radCheckBox1.RootElement.ToolTipText = null;
            this.radCheckBox1.Size = new System.Drawing.Size(85, 19);
            this.radCheckBox1.TabIndex = 0;
            this.radCheckBox1.Text = "Arial, 10pt";
            this.radCheckBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radCheckBox1.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBox1_ToggleStateChanged);
            // 
            // radGroupEvents
            // 
            this.radGroupEvents.Controls.Add(this.radTextBoxEvents);
            this.radGroupEvents.FooterImageIndex = -1;
            this.radGroupEvents.FooterImageKey = "";
            this.radGroupEvents.FooterText = "";
            this.radGroupEvents.ForeColor = System.Drawing.Color.Black;
            this.radGroupEvents.HeaderImageIndex = -1;
            this.radGroupEvents.HeaderImageKey = "";
            this.radGroupEvents.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupEvents.HeaderText = " Events ";
            this.radGroupEvents.Location = new System.Drawing.Point(15, 6);
            this.radGroupEvents.Name = "radGroupEvents";
            // 
            // 
            // 
            this.radGroupEvents.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radGroupEvents.Size = new System.Drawing.Size(162, 188);
            this.radGroupEvents.TabIndex = 0;
            this.radGroupEvents.Text = " Events ";
            // 
            // radTextBoxEvents
            // 
            this.radTextBoxEvents.ForeColor = System.Drawing.Color.Black;
            this.radTextBoxEvents.Location = new System.Drawing.Point(13, 23);
            this.radTextBoxEvents.Multiline = true;
            this.radTextBoxEvents.Name = "radTextBoxEvents";
            // 
            // 
            // 
            this.radTextBoxEvents.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radTextBoxEvents.RootElement.StretchVertically = true;
            this.radTextBoxEvents.Size = new System.Drawing.Size(138, 154);
            this.radTextBoxEvents.TabIndex = 0;
            // 
            // Form1
            // 
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(2, 35, 2, 4);
            this.Size = new System.Drawing.Size(1224, 536);
            ((System.ComponentModel.ISupportInitialize)(this.radPanelDemoHolder)).EndInit();
            this.radPanelDemoHolder.ResumeLayout(false);
            this.radPanelDemoHolder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupEvents)).EndInit();
            this.radGroupEvents.ResumeLayout(false);
            this.radGroupEvents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxEvents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadCheckBox radCheckBox1;
        private Telerik.WinControls.UI.RadCheckBox radCheckBox2;
        private Telerik.WinControls.UI.RadCheckBox radCheckBox3;
        private Telerik.WinControls.UI.RadGroupBox radGroupEvents;
        private Telerik.WinControls.UI.RadTextBox radTextBoxEvents;
    }
}