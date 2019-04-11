using Telerik.WinControls.UI;
namespace Telerik.Examples.WinControls.ChartView.LabelFormatting
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
            this.radChartView1 = new Telerik.WinControls.UI.RadChartView();
            this.radCheckBox1 = new Telerik.WinControls.UI.RadCheckBox();
            this.radCheckBox2 = new Telerik.WinControls.UI.RadCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radChartView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radCheckBox2);
            this.settingsPanel.Controls.Add(this.radCheckBox1);
            this.settingsPanel.Location = new System.Drawing.Point(989, 19);
            this.settingsPanel.Size = new System.Drawing.Size(304, 832);
            this.settingsPanel.Controls.SetChildIndex(this.radCheckBox1, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radCheckBox2, 0);
            // 
            // radChartView1
            // 
            this.radChartView1.ChartElement.TitlePosition = Telerik.WinControls.UI.TitlePosition.Top;
            this.radChartView1.ChartElement.TitleElement.Font = new System.Drawing.Font("Segoe UI Light", 20f);
            this.radChartView1.ChartElement.TitleElement.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.radChartView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radChartView1.Location = new System.Drawing.Point(0, 0);
            this.radChartView1.Name = "radChartView1";
            this.radChartView1.ShowLegend = false;
            this.radChartView1.ShowTitle = true;
            this.radChartView1.Size = new System.Drawing.Size(1190, 832);
            this.radChartView1.TabIndex = 1;
            this.radChartView1.Text = "radChartView1";
            this.radChartView1.Title = "Stock Index";
            this.radChartView1.LabelFormatting += new ChartViewLabelFormattingEventHandler(radChartView1_LabelFormatting);
            this.radChartView1.View.Margin = new System.Windows.Forms.Padding(20, 0, 20, 20);
            // 
            // radCheckBox1
            // 
            this.radCheckBox1.Location = new System.Drawing.Point(98, 5);
            this.radCheckBox1.Name = "radCheckBox1";
            this.radCheckBox1.Size = new System.Drawing.Size(91, 18);
            this.radCheckBox1.TabIndex = 1;
            this.radCheckBox1.Text = "Show Labels";
            this.radCheckBox1.Checked = true;
            this.radCheckBox1.ToggleStateChanged += new StateChangedEventHandler(radCheckBox1_ToggleStateChanged);
            // 
            // radCheckBox2
            // 
            this.radCheckBox2.Location = new System.Drawing.Point(98, 30);
            this.radCheckBox2.Name = "radCheckBox2";
            this.radCheckBox2.Size = new System.Drawing.Size(91, 18);
            this.radCheckBox2.TabIndex = 2;
            this.radCheckBox2.Text = "Enable custom appearance";
            this.radCheckBox2.Checked = true;
            this.radCheckBox2.ToggleStateChanged += new StateChangedEventHandler(radCheckBox2_ToggleStateChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radChartView1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1190, 832);
            this.Resize += new System.EventHandler(Form1_Resize);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            this.Controls.SetChildIndex(this.radChartView1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radChartView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadCheckBox radCheckBox2;
        private Telerik.WinControls.UI.RadCheckBox radCheckBox1;
        private Telerik.WinControls.UI.RadChartView radChartView1;
    }
}