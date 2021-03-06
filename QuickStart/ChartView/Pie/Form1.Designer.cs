﻿namespace Telerik.Examples.WinControls.ChartView.Pie
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
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radSpinEditor1 = new Telerik.WinControls.UI.RadSpinEditor();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radSpinEditor2 = new Telerik.WinControls.UI.RadSpinEditor();
            this.radCheckBox1 = new Telerik.WinControls.UI.RadCheckBox();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radDropDownList1 = new Telerik.WinControls.UI.RadDropDownList();
            this.radChartView1 = new Telerik.WinControls.UI.RadChartView();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radRadioButton2 = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioButton1 = new Telerik.WinControls.UI.RadRadioButton();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radSpinDonutRadius = new Telerik.WinControls.UI.RadSpinEditor();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radChartView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinDonutRadius)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radSpinDonutRadius);
            this.settingsPanel.Controls.Add(this.radLabel4);
            this.settingsPanel.Controls.Add(this.radGroupBox1);
            this.settingsPanel.Controls.Add(this.radDropDownList1);
            this.settingsPanel.Controls.Add(this.radLabel3);
            this.settingsPanel.Controls.Add(this.radLabel1);
            this.settingsPanel.Controls.Add(this.radLabel2);
            this.settingsPanel.Controls.Add(this.radSpinEditor1);
            this.settingsPanel.Controls.Add(this.radCheckBox1);
            this.settingsPanel.Controls.Add(this.radSpinEditor2);
            this.settingsPanel.Location = new System.Drawing.Point(994, 46);
            this.settingsPanel.Size = new System.Drawing.Size(252, 364);
            this.settingsPanel.Controls.SetChildIndex(this.radSpinEditor2, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radCheckBox1, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radSpinEditor1, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radLabel2, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radLabel1, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radLabel3, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radDropDownList1, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radGroupBox1, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radLabel4, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radSpinDonutRadius, 0);
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(14, 8);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(64, 18);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "Start Angle:";
            // 
            // radSpinEditor1
            // 
            this.radSpinEditor1.Location = new System.Drawing.Point(14, 32);
            this.radSpinEditor1.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.radSpinEditor1.Name = "radSpinEditor1";
            // 
            // 
            // 
            this.radSpinEditor1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radSpinEditor1.Size = new System.Drawing.Size(100, 20);
            this.radSpinEditor1.TabIndex = 2;
            this.radSpinEditor1.TabStop = false;
            this.radSpinEditor1.Value = new decimal(new int[] {
            270,
            0,
            0,
            0});
            this.radSpinEditor1.Wrap = true;
            this.radSpinEditor1.ValueChanged += new System.EventHandler(this.radSpinEditor1_ValueChanged);
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(14, 58);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(68, 18);
            this.radLabel2.TabIndex = 3;
            this.radLabel2.Text = "Total Range:";
            // 
            // radSpinEditor2
            // 
            this.radSpinEditor2.Location = new System.Drawing.Point(14, 82);
            this.radSpinEditor2.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.radSpinEditor2.Minimum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.radSpinEditor2.Name = "radSpinEditor2";
            // 
            // 
            // 
            this.radSpinEditor2.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radSpinEditor2.Size = new System.Drawing.Size(100, 20);
            this.radSpinEditor2.TabIndex = 4;
            this.radSpinEditor2.TabStop = false;
            this.radSpinEditor2.Value = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.radSpinEditor2.ValueChanged += new System.EventHandler(this.radSpinEditor2_ValueChanged);
            // 
            // radCheckBox1
            // 
            this.radCheckBox1.Location = new System.Drawing.Point(14, 158);
            this.radCheckBox1.Name = "radCheckBox1";
            this.radCheckBox1.Size = new System.Drawing.Size(82, 18);
            this.radCheckBox1.TabIndex = 5;
            this.radCheckBox1.Text = "Show Labels";
            this.radCheckBox1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.radCheckBox1.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBox1_ToggleStateChanged);
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(14, 108);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(87, 18);
            this.radLabel3.TabIndex = 6;
            this.radLabel3.Text = "Selection Mode:";
            // 
            // radDropDownList1
            // 
            this.radDropDownList1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.radDropDownList1.Location = new System.Drawing.Point(14, 132);
            this.radDropDownList1.Name = "radDropDownList1";
            this.radDropDownList1.NullText = "Choose selection mode";
            this.radDropDownList1.Size = new System.Drawing.Size(106, 20);
            this.radDropDownList1.TabIndex = 7;
            // 
            // radChartView1
            // 
            this.radChartView1.AreaType = Telerik.WinControls.UI.ChartAreaType.Pie;
            this.radChartView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radChartView1.Location = new System.Drawing.Point(0, 0);
            this.radChartView1.Name = "radChartView1";
            this.radChartView1.ShowLegend = false;
            this.radChartView1.ShowTitle = false;
            this.radChartView1.Size = new System.Drawing.Size(1391, 832);
            this.radChartView1.TabIndex = 1;
            this.radChartView1.Text = "radChartView1";
            this.radChartView1.Title = "Chart title";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.radRadioButton2);
            this.radGroupBox1.Controls.Add(this.radRadioButton1);
            this.radGroupBox1.HeaderText = "Chart type";
            this.radGroupBox1.Location = new System.Drawing.Point(14, 181);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(200, 77);
            this.radGroupBox1.TabIndex = 8;
            this.radGroupBox1.Text = "Chart type";
            // 
            // radRadioButton2
            // 
            this.radRadioButton2.Location = new System.Drawing.Point(6, 49);
            this.radRadioButton2.Name = "radRadioButton2";
            this.radRadioButton2.Size = new System.Drawing.Size(110, 18);
            this.radRadioButton2.TabIndex = 1;
            this.radRadioButton2.Text = "Donut";
            this.radRadioButton2.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioButton2_ToggleStateChanged);
            // 
            // radRadioButton1
            // 
            this.radRadioButton1.Location = new System.Drawing.Point(6, 25);
            this.radRadioButton1.Name = "radRadioButton1";
            this.radRadioButton1.Size = new System.Drawing.Size(110, 18);
            this.radRadioButton1.TabIndex = 0;
            this.radRadioButton1.TabStop = true;
            this.radRadioButton1.Text = "Pie";
            this.radRadioButton1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.radRadioButton1.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioButton1_ToggleStateChanged);
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(14, 265);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(105, 18);
            this.radLabel4.TabIndex = 9;
            this.radLabel4.Text = "Donut radius factor:";
            // 
            // radSpinDonutRadius
            // 
            this.radSpinDonutRadius.Location = new System.Drawing.Point(14, 290);
            this.radSpinDonutRadius.Name = "radSpinDonutRadius";
            this.radSpinDonutRadius.Size = new System.Drawing.Size(100, 20);
            this.radSpinDonutRadius.TabIndex = 10;
            this.radSpinDonutRadius.TabStop = false;
            this.radSpinDonutRadius.ValueChanged += new System.EventHandler(this.radSpinDonutRadius_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radChartView1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1391, 832);
            this.Controls.SetChildIndex(this.radChartView1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radChartView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinDonutRadius)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadChartView radChartView1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadSpinEditor radSpinEditor1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadSpinEditor radSpinEditor2;
        private Telerik.WinControls.UI.RadCheckBox radCheckBox1;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadDropDownList radDropDownList1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadRadioButton radRadioButton2;
        private Telerik.WinControls.UI.RadRadioButton radRadioButton1;
        private Telerik.WinControls.UI.RadSpinEditor radSpinDonutRadius;
        private Telerik.WinControls.UI.RadLabel radLabel4;
    }
}