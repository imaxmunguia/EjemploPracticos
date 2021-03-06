﻿using System.Drawing;
namespace Telerik.Examples.WinControls.Editors.SpinEdit.FirstLook
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
            this.radSpinDemo = new Telerik.WinControls.UI.RadSpinEditor();
            this.radGroupRTL = new Telerik.WinControls.UI.RadGroupBox();
            this.radCheckBox1 = new Telerik.WinControls.UI.RadCheckBox();
            this.radGroupEvents = new Telerik.WinControls.UI.RadGroupBox();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radListBox1 = new Telerik.WinControls.UI.RadListControl();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelDemoHolder)).BeginInit();
            this.radPanelDemoHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinDemo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupRTL)).BeginInit();
            this.radGroupRTL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupEvents)).BeginInit();
            this.radGroupEvents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radListBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanelDemoHolder
            // 
            this.radPanelDemoHolder.Controls.Add(this.radSpinDemo);
            this.radPanelDemoHolder.Location = new System.Drawing.Point(496, 300);
            // 
            // 
            // 
            this.radPanelDemoHolder.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radPanelDemoHolder.Size = new System.Drawing.Size(233, 137);
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radGroupRTL);
            this.settingsPanel.Controls.Add(this.radGroupEvents);
            this.settingsPanel.Location = new System.Drawing.Point(1023, 1);
            // 
            // 
            // 
            this.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black;
            this.settingsPanel.Size = new System.Drawing.Size(200, 735);
            this.settingsPanel.Controls.SetChildIndex(this.radGroupEvents, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radGroupRTL, 0);
            // 
            // radSpinDemo
            // 
            this.radSpinDemo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radSpinDemo.BackColor = System.Drawing.Color.Transparent;
            this.radSpinDemo.ForeColor = System.Drawing.Color.Black;
            this.radSpinDemo.Location = new System.Drawing.Point(51, 58);
            this.radSpinDemo.Name = "radSpinDemo";
            // 
            // 
            // 
            this.radSpinDemo.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radSpinDemo.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radSpinDemo.ShowBorder = true;
            this.radSpinDemo.Size = new System.Drawing.Size(131, 20);
            this.radSpinDemo.TabIndex = 2;
            this.radSpinDemo.TabStop = false;
            // 
            // radGroupRTL
            // 
            this.radGroupRTL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupRTL.Controls.Add(this.radCheckBox1);
            this.radGroupRTL.FooterImageIndex = -1;
            this.radGroupRTL.FooterImageKey = "";
            this.radGroupRTL.FooterText = "";
            this.radGroupRTL.ForeColor = System.Drawing.Color.Black;
            this.radGroupRTL.HeaderImageIndex = -1;
            this.radGroupRTL.HeaderImageKey = "";
            this.radGroupRTL.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupRTL.HeaderText = " RTL Support ";
            this.radGroupRTL.Location = new System.Drawing.Point(10, 6);
            this.radGroupRTL.Name = "radGroupRTL";
            this.radGroupRTL.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            // 
            // 
            // 
            this.radGroupRTL.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radGroupRTL.RootElement.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.radGroupRTL.Size = new System.Drawing.Size(180, 58);
            this.radGroupRTL.TabIndex = 0;
            this.radGroupRTL.Text = " RTL Support ";
            // 
            // radCheckBox1
            // 
            this.radCheckBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.radCheckBox1.Location = new System.Drawing.Point(14, 28);
            this.radCheckBox1.Name = "radCheckBox1";
            // 
            // 
            // 
            this.radCheckBox1.RootElement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.radCheckBox1.Size = new System.Drawing.Size(87, 17);
            this.radCheckBox1.TabIndex = 0;
            this.radCheckBox1.Text = "Right To Left";
            this.radCheckBox1.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.OnCheckRightToLeft_StateChanged);
            // 
            // radGroupEvents
            // 
            this.radGroupEvents.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupEvents.Controls.Add(this.radButton1);
            this.radGroupEvents.Controls.Add(this.radListBox1);
            this.radGroupEvents.FooterImageIndex = -1;
            this.radGroupEvents.FooterImageKey = "";
            this.radGroupEvents.FooterText = "";
            this.radGroupEvents.ForeColor = System.Drawing.Color.Black;
            this.radGroupEvents.HeaderImageIndex = -1;
            this.radGroupEvents.HeaderImageKey = "";
            this.radGroupEvents.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupEvents.HeaderText = " Events ";
            this.radGroupEvents.Location = new System.Drawing.Point(10, 71);
            this.radGroupEvents.Name = "radGroupEvents";
            this.radGroupEvents.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            // 
            // 
            // 
            this.radGroupEvents.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radGroupEvents.RootElement.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.radGroupEvents.Size = new System.Drawing.Size(180, 382);
            this.radGroupEvents.TabIndex = 0;
            this.radGroupEvents.Text = " Events ";
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(14, 314);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(153, 32);
            this.radButton1.TabIndex = 1;
            this.radButton1.Text = "Clear list";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // radListBox1
            // 
            this.radListBox1.ForeColor = System.Drawing.Color.Black;
            this.radListBox1.Location = new System.Drawing.Point(14, 19);
            this.radListBox1.Name = "radListBox1";
            // 
            // 
            // 
            this.radListBox1.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radListBox1.Size = new System.Drawing.Size(153, 276);
            this.radListBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1224, 737);
            ((System.ComponentModel.ISupportInitialize)(this.radPanelDemoHolder)).EndInit();
            this.radPanelDemoHolder.ResumeLayout(false);
            this.radPanelDemoHolder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radSpinDemo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupRTL)).EndInit();
            this.radGroupRTL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupEvents)).EndInit();
            this.radGroupEvents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radListBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadSpinEditor radSpinDemo;
        private Telerik.WinControls.UI.RadGroupBox radGroupEvents;
        private Telerik.WinControls.UI.RadGroupBox radGroupRTL;
        private Telerik.WinControls.UI.RadCheckBox radCheckBox1;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadListControl radListBox1;
    }
}