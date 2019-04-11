namespace Telerik.Examples.WinControls.ChartView.Radar
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
            Telerik.WinControls.UI.PolarAxis polarAxis3 = new Telerik.WinControls.UI.PolarAxis();
            Telerik.WinControls.UI.PolarAxis polarAxis4 = new Telerik.WinControls.UI.PolarAxis();
            this.radChartView1 = new Telerik.WinControls.UI.RadChartView();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radSpinEditorPointRadius = new Telerik.WinControls.UI.RadSpinEditor();
            this.radSpinEditorLineWidth = new Telerik.WinControls.UI.RadSpinEditor();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radChartView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorPointRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorLineWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radGroupBox1);
            this.settingsPanel.Location = new System.Drawing.Point(1093, 52);
            this.settingsPanel.Size = new System.Drawing.Size(153, 284);
            this.settingsPanel.Controls.SetChildIndex(this.radGroupBox1, 0);
            // 
            // radChartView1
            // 
            this.radChartView1.AreaType = Telerik.WinControls.UI.ChartAreaType.Polar;
            this.radChartView1.Axes.Add(polarAxis3);
            this.radChartView1.Axes.Add(polarAxis4);
            this.radChartView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radChartView1.Location = new System.Drawing.Point(0, 0);
            this.radChartView1.Name = "radChartView1";
            this.radChartView1.Size = new System.Drawing.Size(1306, 815);
            this.radChartView1.TabIndex = 1;
            this.radChartView1.Text = "radChartView1";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGroupBox1.Controls.Add(this.radLabel2);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.Controls.Add(this.radSpinEditorPointRadius);
            this.radGroupBox1.Controls.Add(this.radSpinEditorLineWidth);
            this.radGroupBox1.FooterImageIndex = -1;
            this.radGroupBox1.FooterImageKey = "";
            this.radGroupBox1.HeaderImageIndex = -1;
            this.radGroupBox1.HeaderImageKey = "";
            this.radGroupBox1.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBox1.HeaderText = "Settings";
            this.radGroupBox1.Location = new System.Drawing.Point(4, 5);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.radGroupBox1.Size = new System.Drawing.Size(163, 85);
            this.radGroupBox1.TabIndex = 1;
            this.radGroupBox1.Text = "Settings";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(6, 48);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(66, 18);
            this.radLabel2.TabIndex = 1;
            this.radLabel2.Text = "Point size";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(6, 22);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(58, 18);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "Line width";
            // 
            // radSpinEditorPointRadius
            // 
            this.radSpinEditorPointRadius.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radSpinEditorPointRadius.Location = new System.Drawing.Point(78, 48);
            this.radSpinEditorPointRadius.Name = "radSpinEditorPointRadius";
            this.radSpinEditorPointRadius.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radSpinEditorPointRadius.ShowBorder = true;
            this.radSpinEditorPointRadius.Size = new System.Drawing.Size(80, 20);
            this.radSpinEditorPointRadius.TabIndex = 0;
            this.radSpinEditorPointRadius.TabStop = false;
            this.radSpinEditorPointRadius.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.radSpinEditorPointRadius.ValueChanged += new System.EventHandler(this.radSpinEditorPointRadius_ValueChanged);
            // 
            // radSpinEditorLineWidth
            // 
            this.radSpinEditorLineWidth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radSpinEditorLineWidth.Location = new System.Drawing.Point(78, 22);
            this.radSpinEditorLineWidth.Name = "radSpinEditorLineWidth";
            this.radSpinEditorLineWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.radSpinEditorLineWidth.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radSpinEditorLineWidth.ShowBorder = true;
            this.radSpinEditorLineWidth.Size = new System.Drawing.Size(80, 20);
            this.radSpinEditorLineWidth.TabIndex = 0;
            this.radSpinEditorLineWidth.TabStop = false;
            this.radSpinEditorLineWidth.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.radSpinEditorLineWidth.ValueChanged += new System.EventHandler(this.radSpinEditorLineWidth_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radChartView1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1306, 815);
            this.Controls.SetChildIndex(this.radChartView1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radChartView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorPointRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorLineWidth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadChartView radChartView1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadSpinEditor radSpinEditorLineWidth;
        private Telerik.WinControls.UI.RadSpinEditor radSpinEditorPointRadius;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
    }
}