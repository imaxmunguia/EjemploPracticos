using Telerik.WinControls;
namespace Telerik.Examples.WinControls.ChartView.FirstLook
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
            this.tableLayoutPanel1 = new Telerik.Examples.WinControls.ChartView.FirstLook.CustomTableLayoutPanel();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.radChartView1 = new Telerik.WinControls.UI.RadChartView();
            this.radChartView2 = new Telerik.WinControls.UI.RadChartView();
            this.radChartView3 = new Telerik.WinControls.UI.RadChartView();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
            this.radPanel3 = new Telerik.WinControls.UI.RadPanel();
            this.radPanel4 = new Telerik.WinControls.UI.RadPanel();
            this.legend1 = new Telerik.Examples.WinControls.ChartView.FirstLook.Legend();
            this.legend2 = new Telerik.Examples.WinControls.ChartView.FirstLook.Legend();
            this.legend3 = new Telerik.Examples.WinControls.ChartView.FirstLook.Legend();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radChartView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radChartView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radChartView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.legend1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.legend2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.legend3)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Location = new System.Drawing.Point(1501, 19);
            this.settingsPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.Controls.Add(this.radChartView1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.radChartView2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.radChartView3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.radGridView1, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.radPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.radPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.radPanel3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.radPanel4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.legend1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.legend2, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.legend3, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(0, 0);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // radGridView1
            // 
            this.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.SetColumnSpan(this.radGridView1, 2);      
            this.radGridView1.Location = new System.Drawing.Point(0, 0);
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.Margin = new System.Windows.Forms.Padding(0);
            this.radGridView1.Size = new System.Drawing.Size(592, 458);
            this.radGridView1.TabIndex = 0;
            this.radGridView1.Text = "radGridView1";
            this.radGridView1.GridViewElement.BorderColor = System.Drawing.Color.White;
           
            // 
            // radChartView1
            // 
            this.radChartView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radChartView1.Location = new System.Drawing.Point(0, 45);
            this.radChartView1.Margin = new System.Windows.Forms.Padding(0);
            this.radChartView1.Name = "radChartView1";
            this.radChartView1.Size = new System.Drawing.Size(1, 1);
            this.radChartView1.TabIndex = 0;
            this.radChartView1.Text = "radChartView1";
            this.radChartView1.View.Margin = new System.Windows.Forms.Padding(10);
            this.radChartView1.Paint += new System.Windows.Forms.PaintEventHandler(radChartView1_Paint);
            // 
            // radChartView2
            // 
            this.radChartView2.AreaType = Telerik.WinControls.UI.ChartAreaType.Pie;
            this.radChartView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radChartView2.Location = new System.Drawing.Point(1, 45);
            this.radChartView2.Margin = new System.Windows.Forms.Padding(0);
            this.radChartView2.Name = "radChartView2";
            this.radChartView2.Size = new System.Drawing.Size(1, 1);
            this.radChartView2.TabIndex = 1;
            this.radChartView2.Text = "radChartView2";
            this.radChartView2.View.Margin = new System.Windows.Forms.Padding(10);
            this.radChartView2.Paint += new System.Windows.Forms.PaintEventHandler(radChartView2_Paint);
            // 
            // radChartView3
            // 
            this.radChartView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radChartView3.Location = new System.Drawing.Point(0, 23);
            this.radChartView3.Margin = new System.Windows.Forms.Padding(0);
            this.radChartView3.Name = "radChartView3";
            this.radChartView3.Size = new System.Drawing.Size(1, 1);
            this.radChartView3.TabIndex = 2;
            this.radChartView3.Text = "radChartView3";
            this.radChartView3.View.Margin = new System.Windows.Forms.Padding(10);
            this.radChartView3.Paint += new System.Windows.Forms.PaintEventHandler(radChartView3_Paint);
            // 
            // radPanel1
            // 
            this.radPanel1.BackColor = System.Drawing.Color.FromArgb(238, 239, 238);
            this.tableLayoutPanel1.SetColumnSpan(this.radPanel1, 4);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(2, 45);
            this.radPanel1.TabIndex = 4;
            this.radPanel1.Text = "SALES DASHBOARD 2012";
            ((Telerik.WinControls.UI.RadPanelElement)(this.radPanel1.GetChildAt(0))).Text = "SALES DASHBOARD 2012";
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel1.GetChildAt(0).GetChildAt(1))).ForeColor = System.Drawing.Color.FromArgb(238, 239, 238);
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radPanel1.GetChildAt(0).GetChildAt(2))).Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            // 
            // radPanel2
            // 
            this.radPanel2.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.SetColumnSpan(this.radPanel2, 2);
            this.radPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel2.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPanel2.Location = new System.Drawing.Point(0, 0);
            this.radPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.radPanel2.Name = "radPanel1";
            this.radPanel2.Size = new System.Drawing.Size(2, 45);
            this.radPanel2.TabIndex = 4;
            this.radPanel2.Text = "SALES DASHBOARD 2012";
            ((Telerik.WinControls.UI.RadPanelElement)(this.radPanel2.GetChildAt(0))).Text = "Total sales by product";
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel2.GetChildAt(0).GetChildAt(1))).ForeColor = System.Drawing.Color.White;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radPanel2.GetChildAt(0).GetChildAt(2))).Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            // 
            // radPanel3
            // 
            this.radPanel3.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.SetColumnSpan(this.radPanel3, 2);
            this.radPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel3.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPanel3.Location = new System.Drawing.Point(0, 0);
            this.radPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.radPanel3.Name = "radPanel1";
            this.radPanel3.Size = new System.Drawing.Size(2, 45);
            this.radPanel3.TabIndex = 4;
            this.radPanel3.Text = "SALES DASHBOARD 2012";
            ((Telerik.WinControls.UI.RadPanelElement)(this.radPanel3.GetChildAt(0))).Text = "Sales breakdown by region";
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel3.GetChildAt(0).GetChildAt(1))).ForeColor = System.Drawing.Color.White;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radPanel3.GetChildAt(0).GetChildAt(2))).Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            // 
            // radPanel4
            // 
            this.radPanel4.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.SetColumnSpan(this.radPanel4, 4);
            this.radPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel4.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPanel4.Location = new System.Drawing.Point(0, 0);
            this.radPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.radPanel4.Name = "radPanel1";
            this.radPanel4.Size = new System.Drawing.Size(2, 45);
            this.radPanel4.TabIndex = 4;
            this.radPanel4.Text = "SALES DASHBOARD 2012";
            ((Telerik.WinControls.UI.RadPanelElement)(this.radPanel4.GetChildAt(0))).Text = "Percent of target";
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel4.GetChildAt(0).GetChildAt(1))).ForeColor = System.Drawing.Color.White;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radPanel4.GetChildAt(0).GetChildAt(2))).Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            
            // 
            // legend1
            // 
            this.legend1.BackColor = System.Drawing.Color.White;
            this.legend1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.legend1.Location = new System.Drawing.Point(-99, 45);
            this.legend1.Margin = new System.Windows.Forms.Padding(0);
            this.legend1.Name = "legend1";
            this.legend1.Size = new System.Drawing.Size(100, 1);
            this.legend1.TabIndex = 5;
            // 
            // legend2
            // 
            this.legend2.BackColor = System.Drawing.Color.White;
            this.legend2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.legend2.Location = new System.Drawing.Point(-98, 45);
            this.legend2.Margin = new System.Windows.Forms.Padding(0);
            this.legend2.Name = "legend2";
            this.legend2.Size = new System.Drawing.Size(100, 1);
            this.legend2.TabIndex = 6;
            // 
            // legend3
            // 
            this.legend3.BackColor = System.Drawing.Color.White;
            this.legend3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.legend3.Location = new System.Drawing.Point(-99, 23);
            this.legend3.Margin = new System.Windows.Forms.Padding(0);
            this.legend3.Name = "legend3";
            this.legend3.Size = new System.Drawing.Size(100, 1);
            this.legend3.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(0, 0);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radChartView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radChartView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radChartView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.legend1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.legend2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.legend3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomTableLayoutPanel tableLayoutPanel1;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.UI.RadChartView radChartView1;
        private Telerik.WinControls.UI.RadChartView radChartView2;
        private Telerik.WinControls.UI.RadChartView radChartView3;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadPanel radPanel2;
        private Telerik.WinControls.UI.RadPanel radPanel3;
        private Telerik.WinControls.UI.RadPanel radPanel4;
        private Legend legend1;
        private Legend legend2;
        private Legend legend3;
                
	}
}
