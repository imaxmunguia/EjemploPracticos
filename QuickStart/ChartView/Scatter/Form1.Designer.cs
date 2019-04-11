namespace Telerik.Examples.WinControls.ChartView.Scatter
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adventureLT2008DataSet = new Telerik.Examples.WinControls.DataSources.AdventureLT2008DataSet();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.employeeTableAdapter = new Telerik.Examples.WinControls.DataSources.AdventureLT2008DataSetTableAdapters.EmployeeTableAdapter();
            this.radChartView1 = new Telerik.WinControls.UI.RadChartView();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radButtonEditShape = new Telerik.WinControls.UI.RadButton();
            this.radDropDownListShapes = new Telerik.WinControls.UI.RadDropDownList();
            this.radDropDownListSeries = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radSpinEditorPointRadius = new Telerik.WinControls.UI.RadSpinEditor();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureLT2008DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radChartView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonEditShape)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownListShapes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownListSeries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorPointRadius)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            //
            this.settingsPanel.Controls.Add(this.radLabel2);
            this.settingsPanel.Controls.Add(this.radDropDownListSeries);
            this.settingsPanel.Controls.Add(this.radGroupBox1);
            this.settingsPanel.ForeColor = System.Drawing.Color.Black;
            this.settingsPanel.Location = new System.Drawing.Point(1031, 216);
            this.settingsPanel.Size = new System.Drawing.Size(220, 358);
            this.settingsPanel.ThemeName = "ControlDefault";
            this.settingsPanel.Controls.SetChildIndex(this.radGroupBox1, 0);
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.adventureLT2008DataSet;
            // 
            // adventureLT2008DataSet
            // 
            this.adventureLT2008DataSet.DataSetName = "AdventureLT2008DataSet";
            this.adventureLT2008DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "User Business Male.png");
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // radChartView1
            // 
            this.radChartView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radChartView1.ImageList = this.imageList1;
            this.radChartView1.Location = new System.Drawing.Point(0, 0);
            this.radChartView1.Name = "radChartView1";
            this.radChartView1.Size = new System.Drawing.Size(1297, 732);
            this.radChartView1.TabIndex = 1;
            this.radChartView1.Text = "radChartView1";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGroupBox1.Controls.Add(this.radSpinEditorPointRadius);
            this.radGroupBox1.Controls.Add(this.radLabel3);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.Controls.Add(this.radButtonEditShape);
            this.radGroupBox1.Controls.Add(this.radDropDownListShapes);
            this.radGroupBox1.FooterImageIndex = -1;
            this.radGroupBox1.FooterImageKey = "";
            this.radGroupBox1.HeaderImageIndex = -1;
            this.radGroupBox1.HeaderImageKey = "";
            this.radGroupBox1.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBox1.HeaderText = "Series1 Settings";
            this.radGroupBox1.Location = new System.Drawing.Point(4, 47);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.radGroupBox1.Size = new System.Drawing.Size(213, 171);
            this.radGroupBox1.TabIndex = 1;
            this.radGroupBox1.Text = "radGroupBox1";
            // 
            // radButtonEditShape
            // 
            this.radButtonEditShape.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.radButtonEditShape.Location = new System.Drawing.Point(42, 128);
            this.radButtonEditShape.Name = "radButtonEditShape";
            this.radButtonEditShape.Size = new System.Drawing.Size(130, 30);
            this.radButtonEditShape.TabIndex = 1;
            this.radButtonEditShape.Text = "Edit shape";
            this.radButtonEditShape.Click += new System.EventHandler(this.radButtonEditShape_Click);
            // 
            // radDropDownListShapes
            // 
            this.radDropDownListShapes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radDropDownListShapes.DropDownAnimationEnabled = true;
            this.radDropDownListShapes.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.radDropDownListShapes.Location = new System.Drawing.Point(6, 46);
            this.radDropDownListShapes.MaxDropDownItems = 0;
            this.radDropDownListShapes.Name = "radDropDownListShapes";
            this.radDropDownListShapes.ShowImageInEditorArea = true;
            this.radDropDownListShapes.Size = new System.Drawing.Size(202, 20);
            this.radDropDownListShapes.TabIndex = 0;
            this.radDropDownListShapes.Text = "radDropDownList1";
            // 
            // radDropDownListSeries
            // 
            this.radDropDownListSeries.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radDropDownListSeries.DropDownAnimationEnabled = true;
            this.radDropDownListSeries.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.radDropDownListSeries.Location = new System.Drawing.Point(6, 20);
            this.radDropDownListSeries.MaxDropDownItems = 0;
            this.radDropDownListSeries.Name = "radDropDownListSeries";
            this.radDropDownListSeries.ShowImageInEditorArea = true;
            this.radDropDownListSeries.Size = new System.Drawing.Size(202, 20);
            this.radDropDownListSeries.TabIndex = 0;
            this.radDropDownListSeries.Text = "radDropDownList1";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(6, 22);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(37, 18);
            this.radLabel1.TabIndex = 2;
            this.radLabel1.Text = "Shape";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(6, 0);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(36, 18);
            this.radLabel2.TabIndex = 2;
            this.radLabel2.Text = "Series";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(7, 72);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(66, 18);
            this.radLabel3.TabIndex = 2;
            this.radLabel3.Text = "Point size";
            // 
            // radSpinEditorPointRadius
            // 
            this.radSpinEditorPointRadius.Location = new System.Drawing.Point(7, 96);
            this.radSpinEditorPointRadius.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.radSpinEditorPointRadius.Name = "radSpinEditorPointRadius";
            // 
            // 
            // 
            this.radSpinEditorPointRadius.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radSpinEditorPointRadius.ShowBorder = true;
            this.radSpinEditorPointRadius.Size = new System.Drawing.Size(100, 20);
            this.radSpinEditorPointRadius.TabIndex = 3;
            this.radSpinEditorPointRadius.TabStop = false;
            this.radSpinEditorPointRadius.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.radSpinEditorPointRadius.ValueChanged += new System.EventHandler(this.radSpinEditor1_ValueChanged);
            // 
            // Form1
            // 
            this.Controls.Add(this.radChartView1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1297, 732);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            this.Controls.SetChildIndex(this.radChartView1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureLT2008DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radChartView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonEditShape)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownListShapes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownListSeries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorPointRadius)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

        private System.Windows.Forms.BindingSource employeeBindingSource;
        private DataSources.AdventureLT2008DataSet adventureLT2008DataSet;
        private DataSources.AdventureLT2008DataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.ImageList imageList1;
        private Telerik.WinControls.UI.RadChartView radChartView1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadDropDownList radDropDownListShapes;
        private Telerik.WinControls.UI.RadButton radButtonEditShape;
        private Telerik.WinControls.UI.RadDropDownList radDropDownListSeries;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadSpinEditor radSpinEditorPointRadius;
	}
}
