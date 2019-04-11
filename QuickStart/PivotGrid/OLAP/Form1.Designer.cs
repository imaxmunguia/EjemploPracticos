namespace Telerik.Examples.WinControls.PivotGrid.OLAP
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
            this.radPivotGrid1 = new Telerik.WinControls.UI.RadPivotGrid();
            this.radPivotFieldList1 = new Telerik.WinControls.UI.RadPivotFieldList();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radPivotGrid1)).BeginInit();
            this.radPivotGrid1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // radPivotGrid1
            // 
            this.radPivotGrid1.Controls.Add(this.radButton1);
            this.radPivotGrid1.DataMember = null;
            this.radPivotGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPivotGrid1.Location = new System.Drawing.Point(0, 0);
            this.radPivotGrid1.Name = "radPivotGrid1";
            this.radPivotGrid1.Size = new System.Drawing.Size(539, 526);
            this.radPivotGrid1.ShowFilterArea = true;
            this.radPivotGrid1.TabIndex = 0;
            this.radPivotGrid1.Text = "radPivotGrid1";
            // 
            // radPivotFieldList1
            // 
            this.radPivotFieldList1.AssociatedPivotGrid = this.radPivotGrid1;
            this.radPivotFieldList1.Dock = System.Windows.Forms.DockStyle.Right;
            this.radPivotFieldList1.Location = new System.Drawing.Point(539, 0);
            this.radPivotFieldList1.MinimumSize = new System.Drawing.Size(225, 305);
            this.radPivotFieldList1.Name = "radPivotFieldList1";
            this.radPivotFieldList1.Size = new System.Drawing.Size(258, 526);
            this.radPivotFieldList1.TabIndex = 1;
            // 
            // radButton1
            // 
            this.radButton1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.radButton1.Location = new System.Drawing.Point(165, 245);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(215, 31);
            this.radButton1.TabIndex = 0;
            this.radButton1.Text = "Connect to \"Adventure Works\" Cube";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(797, 526);
            this.Controls.Add(this.radPivotGrid1);
            this.Controls.Add(this.radPivotFieldList1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.radPivotGrid1)).EndInit();
            this.radPivotGrid1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPivotGrid radPivotGrid1;
        private Telerik.WinControls.UI.RadPivotFieldList radPivotFieldList1;
        private Telerik.WinControls.UI.RadButton radButton1;
    }
}