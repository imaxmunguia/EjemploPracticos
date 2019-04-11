namespace Telerik.Examples.WinControls.ChartView.StockIndicators
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
            this.radChartView2 = new Telerik.WinControls.UI.RadChartView();
            Telerik.WinControls.UI.DateTimeCategoricalAxis horizontalAxis = new Telerik.WinControls.UI.DateTimeCategoricalAxis();
            Telerik.WinControls.UI.LinearAxis verticalAxis = new Telerik.WinControls.UI.LinearAxis();
            Telerik.WinControls.UI.DateTimeCategoricalAxis horizontalAxis2 = new Telerik.WinControls.UI.DateTimeCategoricalAxis();
            Telerik.WinControls.UI.LinearAxis verticalAxis2 = new Telerik.WinControls.UI.LinearAxis();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radDropDownList1 = new Telerik.WinControls.UI.RadDropDownList();
            this.radDropDownList2 = new Telerik.WinControls.UI.RadDropDownList();
            this.radDropDownList3 = new Telerik.WinControls.UI.RadDropDownList();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radChartView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radChartView2)).BeginInit();
            this.radChartView2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList3)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radDropDownList3);
            this.settingsPanel.Controls.Add(this.radDropDownList2);
            this.settingsPanel.Controls.Add(this.radDropDownList1);
            this.settingsPanel.Controls.Add(this.radLabel1);
            this.settingsPanel.Controls.Add(this.radLabel2);
            this.settingsPanel.Controls.Add(this.radLabel3);
            this.settingsPanel.Location = new System.Drawing.Point(962, 19);
            this.settingsPanel.Size = new System.Drawing.Size(336, 832);
            this.settingsPanel.Controls.SetChildIndex(this.radDropDownList1, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radDropDownList2, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radDropDownList3, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radLabel1, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radLabel2, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radLabel3, 0);
            // 
            // radChartView1
            // 
            this.radChartView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radChartView1.Location = new System.Drawing.Point(77, 400);
            this.radChartView1.Name = "radChartView1";
            this.radChartView1.ShowLegend = false;
            this.radChartView1.ShowTitle = false;
            this.radChartView1.Size = new System.Drawing.Size(480, 160);
            this.radChartView1.TabIndex = 1;
            this.radChartView1.Text = "radChartView1";
            this.radChartView1.Title = "Chart title";
            this.radChartView1.View.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            //
            //
            horizontalAxis2.LabelFormat = "{0:dd.MM}";
            horizontalAxis2.LabelFitMode = Telerik.Charting.AxisLabelFitMode.MultiLine;
            horizontalAxis2.MajorTickInterval = 5;
            this.radChartView1.Area.Axes.Add(horizontalAxis2);
            //
            //
            verticalAxis2.Minimum = 0;
            verticalAxis2.Maximum = 100;
            verticalAxis2.HorizontalLocation = Telerik.Charting.AxisHorizontalLocation.Right;
            verticalAxis2.AxisType = Telerik.Charting.AxisType.Second;
            this.radChartView1.Area.Axes.Add(verticalAxis2);
            // 
            // radChartView2
            // 
            this.radChartView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radChartView2.Location = new System.Drawing.Point(77, 58);
            this.radChartView2.Name = "radChartView2";
            this.radChartView2.ShowLegend = false;
            this.radChartView2.ShowTitle = false;
            this.radChartView2.Size = new System.Drawing.Size(480, 320);
            this.radChartView2.TabIndex = 2;
            this.radChartView2.Text = "radChartView2";
            this.radChartView2.Title = "Chart title";
            this.radChartView2.View.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.radChartView2.ShowTitle = true;
            this.radChartView2.Title = "Investor Adviser: International Software Company (ISC)";
            this.radChartView2.ChartElement.TitlePosition = Telerik.WinControls.UI.TitlePosition.Top;
            this.radChartView2.ChartElement.TitleElement.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            //
            //            
            horizontalAxis.LabelFormat = "{0:dd.MM}";
            horizontalAxis.LabelFitMode = Telerik.Charting.AxisLabelFitMode.MultiLine;
            horizontalAxis.MajorTickInterval = 5;
            this.radChartView2.Area.Axes.Add(horizontalAxis);
            //
            //
            verticalAxis.Minimum = 50;
            verticalAxis.Maximum = 80;
            verticalAxis.HorizontalLocation = Telerik.Charting.AxisHorizontalLocation.Right;
            verticalAxis.AxisType = Telerik.Charting.AxisType.Second;
            this.radChartView2.Area.Axes.Add(verticalAxis);
            // 
            // radDropDownList1
            // 
            this.radDropDownList1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.radDropDownList1.Location = new System.Drawing.Point(114, 32);
            this.radDropDownList1.Name = "radDropDownList1";
            this.radDropDownList1.Size = new System.Drawing.Size(119, 20);
            this.radDropDownList1.TabIndex = 1;
            this.radDropDownList1.Text = "radDropDownList1";
            this.radDropDownList1.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(radDropDownList1_SelectedIndexChanged);
            // 
            // radDropDownList2
            // 
            this.radDropDownList2.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.radDropDownList2.Location = new System.Drawing.Point(114, 82);
            this.radDropDownList2.Name = "radDropDownList2";
            this.radDropDownList2.Size = new System.Drawing.Size(119, 20);
            this.radDropDownList2.TabIndex = 2;
            this.radDropDownList2.Text = "radDropDownList2";
            this.radDropDownList2.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(radDropDownList2_SelectedIndexChanged);
            // 
            // radDropDownList3
            // 
            this.radDropDownList3.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.radDropDownList3.Location = new System.Drawing.Point(114, 132);
            this.radDropDownList3.Name = "radDropDownList3";
            this.radDropDownList3.Size = new System.Drawing.Size(119, 20);
            this.radDropDownList3.TabIndex = 3;
            this.radDropDownList3.Text = "radDropDownList3";
            this.radDropDownList3.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(radDropDownList3_SelectedIndexChanged);
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(114, 8);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(120, 18);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Series Type:";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(114, 58);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(120, 18);
            this.radLabel2.TabIndex = 0;
            this.radLabel2.Text = "Moving Average indicator:";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(114, 108);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(120, 18);
            this.radLabel3.TabIndex = 0;
            this.radLabel3.Text = "Financial indicator:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radChartView1);
            this.Controls.Add(this.radChartView2);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1195, 832);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            this.Controls.SetChildIndex(this.radChartView1, 0);
            this.Controls.SetChildIndex(this.radChartView2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radChartView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radChartView2)).EndInit();
            this.radChartView2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private Telerik.WinControls.UI.RadDropDownList radDropDownList3;
        private Telerik.WinControls.UI.RadDropDownList radDropDownList2;
        private Telerik.WinControls.UI.RadDropDownList radDropDownList1;
        private Telerik.WinControls.UI.RadChartView radChartView1;
        private Telerik.WinControls.UI.RadChartView radChartView2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
    }
}