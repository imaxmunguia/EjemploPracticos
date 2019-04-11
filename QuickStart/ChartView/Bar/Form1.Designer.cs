namespace Telerik.Examples.WinControls.ChartView.Bar
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            Telerik.WinControls.UI.RadListDataItem radListDataItem1 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem2 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem3 = new Telerik.WinControls.UI.RadListDataItem();
            this.radChartView1 = new Telerik.WinControls.UI.RadChartView();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radDropDownList1 = new Telerik.WinControls.UI.RadDropDownList();
            this.showLabelsCheckBox = new Telerik.WinControls.UI.RadCheckBox();
            this.orientationCheckBox = new Telerik.WinControls.UI.RadCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radChartView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showLabelsCheckBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orientationCheckBox)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.orientationCheckBox);
            this.settingsPanel.Controls.Add(this.showLabelsCheckBox);
            this.settingsPanel.Controls.Add(this.radDropDownList1);
            this.settingsPanel.Controls.Add(this.radLabel2);
            this.settingsPanel.Controls.Add(this.radLabel1);
            this.settingsPanel.ForeColor = System.Drawing.Color.Black;
            this.settingsPanel.Location = new System.Drawing.Point(834, 1);
            this.settingsPanel.Size = new System.Drawing.Size(812, 883);
            this.settingsPanel.ThemeName = "ControlDefault";
            this.settingsPanel.Controls.SetChildIndex(this.radLabel1, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radLabel2, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radDropDownList1, 0);
            this.settingsPanel.Controls.SetChildIndex(this.showLabelsCheckBox, 0);
            this.settingsPanel.Controls.SetChildIndex(this.orientationCheckBox, 0);
            // 
            // radChartView1
            // 
            this.radChartView1.ShowToolTip = true;
            this.radChartView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radChartView1.Location = new System.Drawing.Point(0, 0);
            this.radChartView1.Name = "radChartView1";
            this.radChartView1.Size = new System.Drawing.Size(1647, 885);
            this.radChartView1.TabIndex = 1;
            this.radChartView1.Text = "radChartView1";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(29, 11);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(86, 18);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Combine mode:";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(27, 96);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(107, 18);
            this.radLabel2.TabIndex = 1;
            this.radLabel2.Text = "Change Orientation:";
            // 
            // radDropDownList1
            // 
            this.radDropDownList1.DropDownAnimationEnabled = true;
            this.radDropDownList1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            radListDataItem1.Text = "Cluster";
            radListDataItem1.TextWrap = true;
            radListDataItem2.Text = "Stack";
            radListDataItem2.TextWrap = true;
            radListDataItem3.Text = "Stack100";
            radListDataItem3.TextWrap = true;
            this.radDropDownList1.Items.Add(radListDataItem1);
            this.radDropDownList1.Items.Add(radListDataItem2);
            this.radDropDownList1.Items.Add(radListDataItem3);
            this.radDropDownList1.Location = new System.Drawing.Point(29, 35);
            this.radDropDownList1.MaxDropDownItems = 0;
            this.radDropDownList1.Name = "radDropDownList1";
            this.radDropDownList1.ShowImageInEditorArea = true;
            this.radDropDownList1.Size = new System.Drawing.Size(174, 20);
            this.radDropDownList1.TabIndex = 2;
            this.radDropDownList1.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.radDropDownList1_SelectedIndexChanged);
            // 
            // showLabelsCheckBox
            // 
            this.showLabelsCheckBox.Location = new System.Drawing.Point(29, 61);
            this.showLabelsCheckBox.Name = "showLabelsCheckBox";
            this.showLabelsCheckBox.Size = new System.Drawing.Size(82, 18);
            this.showLabelsCheckBox.TabIndex = 3;
            this.showLabelsCheckBox.Text = "Show Labels";
            this.showLabelsCheckBox.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.showLabelsCheckBox_ToggleStateChanged);
            // 
            // orientationCheckBox
            // 
            this.orientationCheckBox.Location = new System.Drawing.Point(43, 120);
            this.orientationCheckBox.Name = "orientationCheckBox";
            this.orientationCheckBox.Size = new System.Drawing.Size(72, 18);
            this.orientationCheckBox.TabIndex = 4;
            this.orientationCheckBox.Text = "Horizontal";
            this.orientationCheckBox.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.orientationCheckBox_ToggleStateChanged);
            // 
            // Form1
            // 
            this.Controls.Add(this.radChartView1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1647, 885);
            this.Controls.SetChildIndex(this.radChartView1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radChartView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showLabelsCheckBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orientationCheckBox)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

        private Telerik.WinControls.UI.RadChartView radChartView1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadCheckBox orientationCheckBox;
        private Telerik.WinControls.UI.RadCheckBox showLabelsCheckBox;
        private Telerik.WinControls.UI.RadDropDownList radDropDownList1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
	}
}
